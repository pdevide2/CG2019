Imports BLL.GlobalBLL
Imports System.Collections.Generic
Imports System.IO.Directory

Public Class ConsultaMovimentoTransito

    Public podeAbrir As Boolean = False
    'variavel flagAcao o Default é readonly, após verificar permissão no módulo pode mudar para Limpar (0)
    Public flagAcao As Integer = Operacao.Leitura
    Dim _acao As Integer
    Dim _acesso As String
    Dim _objModelFk As Object

    Public Enum Operacao

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum
    Property ObjModelFk() As Object
        Get
            Return _objModelFk
        End Get
        Set(ByVal value As Object)
            _objModelFk = value
        End Set
    End Property

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
    Private _tipoEstoque As String
    Public Property TipoEstoque() As String
        Get
            Return _tipoEstoque
        End Get
        Set(ByVal value As String)
            _tipoEstoque = value
        End Set
    End Property

    Public Sub New(ByVal _tipoEstoque As String)

        ' This call is required by the designer.
        InitializeComponent()
        LoginCG() 'Carrega variavel Friend ACE_CODIGO pelo Setting ID_USER
        ' Add any initialization after the InitializeComponent() call.

        Me.TipoEstoque = _tipoEstoque

        podeAbrir = permissaoTela(ACE_MODULO, ACE_CODIGO)


    End Sub
    Public Function permissaoTela(ByVal intModulo As Integer, ByVal intUsuario As Integer) As Boolean
        flagAcao = Operacao.Limpar
        Dim strPermissao As String = ""
        'strPermissao = verPermissao(intModulo, intUsuario)

        'Me.Acesso = strPermissao

        'If strPermissao = "S" Then
        '    MessageBox.Show("Usuário sem permissão de acesso neste módulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'ElseIf strPermissao = "L" Then
        '    flagAcao = Operacao.Leitura
        'ElseIf strPermissao = "G" Then
        '    flagAcao = Operacao.Limpar
        'Else
        '    MessageBox.Show("Configurações de permissão para este módulo não encontrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False

        'End If
        'Me.Acao = flagAcao
        Return True
    End Function
    Function verPermissao(ByVal modulo As Integer, ByVal usuario As Integer) As String

        Dim retorno As String
        Dim oBLL As New BLL.GlobalBLL

        retorno = oBLL.getPermissaoBLL(modulo, usuario)
        Return retorno

    End Function

    Private Sub Estoque_chip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtData1.Text = ShortDate()
        txtData2.Text = ShortDate()
        'Me.Text = IIf(Me.TipoEstoque = "E", "Consulta de Transito de Estoque de Equipamento (POS)", _
        '                                   "Consulta de Transito de Estoque de Chip")
        Me.Text = "Consulta de Transito de Estoque (Chip/POS)"
        Inicio()
    End Sub


    Private Sub Inicio()
        Dim sql As String, intParms As Integer = 0, intTipoEstoque As Integer

        For intTipoEstoque = 1 To 2

            Me.TipoEstoque = IIf(intTipoEstoque = 1, "C", "E") '1 -> chip e 2 -> Equipamento POS

            If Me.TipoEstoque = "E" Then
                sql = "EXEC spLista_mov_transito_equipamento "
            Else
                sql = "EXEC spLista_mov_transito_chip "
            End If

            If Not String.IsNullOrWhiteSpace(txtIdTransito.Text) Then
                sql += " @ID_TRANSITO = '" & txtIdTransito.Text & "'"
                intParms += 1
            Else
                sql += " @ID_TRANSITO = NULL "
                intParms += 1
            End If
            If Not String.IsNullOrWhiteSpace(txtData1.Text) Then
                sql += IIf(intParms > 0, ", ", "") & " @DATA1 = '" & Dtos(txtData1.Text) & "'"
                intParms += 1
            End If
            If Not String.IsNullOrWhiteSpace(txtData2.Text) Then
                sql += IIf(intParms > 0, ", ", "") & " @DATA2 = '" & Dtos(txtData2.Text) & "'"
                intParms += 1
            End If
            sql += IIf(intParms > 0, ", ", "") & " @ID_EMPRESA = " & Publico.Id_empresa
            intParms += 1

            If intTipoEstoque = 1 Then
                dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
                dgvDados.AutoResizeColumns()
            Else
                dgvDados2.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
                dgvDados2.AutoResizeColumns()
            End If

            UpdateFont()
            'Aviso()
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        'Dim strNomeSheet As String = IIf(Me.TipoEstoque = "C", "MovTransito_Chip", "MovTransito_Equipto")
        ExportaExcel2(dgvDados, dgvDados2, "MovimentoTransito", "MovTransitoChip", "MovTransitoEquipto")
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Inicio()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        txtIdTransito.Text = ""
        txtDescTransito.Text = ""
        txtData1.Text = "" 'Dtos(Hoje)  'Data do Estoque
        txtData2.Text = "" 'Dtos(Hoje) 'Data do Estoque

    End Sub

    Public Sub PesquisaFK(oPesqFk As DTO.PesquisaFK)
        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica(Me, oPesqFk)
        frm.Owner = Me
        frm.ShowDialog()

    End Sub

    Private Sub btnPesqLoja_Click(sender As Object, e As EventArgs) Handles btnPesqTransito.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_TRANSITO"
        Me.ObjModelFk.CampoId = "ID_TRANSITO"
        Me.ObjModelFk.CampoDesc = "NOME_TRANSITO"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Transito"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc & _
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where (1 = 1) "

        PesquisaFK(Me.ObjModelFk)

        txtIdTransito.Text = Me.ObjModelFk.txtId.ToString
        txtDescTransito.Text = Me.ObjModelFk.txtDesc

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtData1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumerosData(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles txtData1.Validated
        If Not validaData(txtData1.Text) Then
            MessageBox.Show("Data Inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtData1.Text = ""
        End If
    End Sub

    Private Sub Aviso()
        Dim frm As Object
        Try
            frm = New WaitWindow("A pesquisa retornou " & dgvDados.RowCount.ToString & " registros", 2)

            frm.Show()   'frm is object of WaitForm
            'Perform the process for databinding, etc
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgvDados_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvDados.RowPrePaint
        Dim _id_dest As String
        _id_dest = IIf(IsDBNull(dgvDados.Rows(e.RowIndex).Cells("ID_DESTINO").Value), "", "*")

        If String.IsNullOrWhiteSpace(_id_dest) Then
            For ixx = 0 To dgvDados.ColumnCount - 1
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.Red
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.White
            Next
        Else
            For ixx = 0 To dgvDados.ColumnCount - 1
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.Black
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.White
            Next
        End If
    End Sub

    Private Sub dgvDados2_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvDados2.RowPrePaint
        Dim _id_dest As String
        _id_dest = IIf(IsDBNull(dgvDados2.Rows(e.RowIndex).Cells("ID_DESTINO").Value), "", "*")

        If String.IsNullOrWhiteSpace(_id_dest) Then
            For ixx = 0 To dgvDados.ColumnCount - 1
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.Red
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.White
            Next
        Else
            For ixx = 0 To dgvDados.ColumnCount - 1
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.Black
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.White
            Next
        End If
    End Sub
    Private Sub UpdateFont()


        Dim colHeader() As String
        If Me.TipoEstoque = "E" Then 'Equipamento
            Me.dgvDados2.DefaultCellStyle.Font = New Font("Tahoma", 9.0F, GraphicsUnit.Pixel)

            colHeader = {"Id Transito", "Nome Transito", "Cód. Origem", "Nome Origem", "Série", _
                         "Modelo", "Id Equipto", "Qtd", "Data Lancto", _
                         "Cód. Destino", "Nome Destino", "Id Destino", "Data Movto", "Id Lancto", _
                         "Id Origem", "Descrição Equipamento", "Id Usuário", "Nome Usuário", "ID Empresa"}
            For ixx = 0 To dgvDados2.ColumnCount - 1
                dgvDados2.Columns(ixx).HeaderText = colHeader(ixx)
            Next

        Else 'Chip
            Me.dgvDados.DefaultCellStyle.Font = New Font("Tahoma", 9.0F, GraphicsUnit.Pixel)

            colHeader = {"Id Transito", "Nome Transito", "Cód. Origem", "Nome Origem", "SIMID", _
                         "Operadora", "Qtd", "Data Lancto", "Id Destino", "Cód. Destino", _
                         "Nome Destino", "Data Movto", "Id Lancto", "Id Origem", "Id Chip", _
                         "Id Usuário", "Nome Usuário", "ID Empresa"}
            For ixx = 0 To dgvDados.ColumnCount - 1
                dgvDados.Columns(ixx).HeaderText = colHeader(ixx)
            Next
        End If

    End Sub

End Class