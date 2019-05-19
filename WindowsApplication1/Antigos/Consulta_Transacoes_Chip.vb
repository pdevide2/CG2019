Imports BLL.GlobalBLL
Imports System.Collections.Generic
Imports System.IO.Directory

Public Class Consulta_Transacoes_Chip
    Public podeAbrir As Boolean = False
    'variavel flagAcao o Default é readonly, após verificar permissão no módulo pode mudar para Limpar (0)
    Public flagAcao As Integer = Operacao.Leitura
    Dim _acao As Integer
    Dim _acesso As String
    Public Enum Operacao

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum
    Public Property Acao() As Integer
        Get
            Return _acao
        End Get
        Set(ByVal value As Integer)
            _acao = value
        End Set
    End Property
    Public Property Acesso() As String
        Get
            Return _acesso
        End Get
        Set(ByVal value As String)
            _acesso = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LoginCG() 'Carrega variavel Friend ACE_CODIGO pelo Setting ID_USER
        ' Add any initialization after the InitializeComponent() call.
        podeAbrir = permissaoTela(ACE_MODULO, ACE_CODIGO)


    End Sub
    Public Function permissaoTela(ByVal intModulo As Integer, ByVal intUsuario As Integer) As Boolean
        flagAcao = Operacao.Limpar
        Dim strPermissao As String = ""
        strPermissao = verPermissao(intModulo, intUsuario)

        Me.Acesso = strPermissao

        If strPermissao = "S" Then
            MessageBox.Show("Usuário sem permissão de acesso neste módulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf strPermissao = "L" Then
            flagAcao = Operacao.Leitura
        ElseIf strPermissao = "G" Then
            flagAcao = Operacao.Limpar
        Else
            MessageBox.Show("Configurações de permissão para este módulo não encontrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        Me.Acao = flagAcao
        Return True
    End Function
    Function verPermissao(ByVal modulo As Integer, ByVal usuario As Integer) As String

        Dim retorno As String
        Dim oBLL As New BLL.GlobalBLL

        retorno = oBLL.getPermissaoBLL(modulo, usuario)
        Return retorno

    End Function

    Private Sub Inicio()
        Dim sql As String
        sql = "SELECT ROMANEIO, MODULO, TIPO_PRODUTO, TIPO_OP, DATAMOV, ID_USUARIO, NOME FROM VW_ROMANEIO_ESTOQUE "
        sql += "WHERE TIPO_PRODUTO = 'C' AND DATAMOV >= '" & Dtos(txtData1.Text) & "' AND DATAMOV < '" & Dtos(SomaData("D", +1, txtData2.Text)) & "'"

        dgvDados1.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        dgvDados1.AutoResizeColumns()
    End Sub

    Private Sub Consulta_Transacoes_Chip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio()
    End Sub

    Private Sub dgvDados1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados1.CellClick
        If e.ColumnIndex >= 0 And e.ColumnIndex <= dgvDados1.ColumnCount Then

            CarregaItens(ChaveFilha())

        End If
    End Sub



    Private Sub dgvDados1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados1.CellEnter
        If e.ColumnIndex >= 0 And e.ColumnIndex <= dgvDados1.ColumnCount Then

            CarregaItens(ChaveFilha())

        End If
    End Sub

    Private Sub CarregaItens(ByVal _romaneio As String)
        Dim strRomaneio As String = _romaneio
        Dim sql As String
        sql = "SELECT ROMANEIO, ID_PRODUTO, SIMID, ID_OPERADORA, DESC_OPERADORA, ENTRADA_SAIDA, "
        sql += "QUANTIDADE, TRANSITO, ID_TRANSACAO, DESC_TRANSACAO, ID_LOCAL_DE, NOME_ORIGEM, SIGLA_ORIGEM, ID_LOCAL_PARA, "
        sql += "NOME_DESTINO, SIGLA_DESTINO, DATAMOV, OBSERVACAO, UNIQUE_KEY FROM VW_ROMANEIO_ESTOQUE_ITEM_CHIP "
        sql += "WHERE ROMANEIO = '" & strRomaneio & "'"

        dgvDados2.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        dgvDados2.AutoResizeColumns()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Inicio()
        If dgvDados1.RowCount > 0 Then
            CarregaItens(ChaveFilha())
        Else
            CarregaItens("-1")
        End If

    End Sub

    Private Function ChaveFilha() As String
        Dim tRet As String = "-1"
        Try
            tRet = dgvDados1.CurrentRow.Cells(0).Value.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return tRet
    End Function


End Class