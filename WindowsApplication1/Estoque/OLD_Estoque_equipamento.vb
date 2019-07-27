Imports BLL.GlobalBLL
Imports System.Collections.Generic
Imports System.IO.Directory

Public Class OLD_Estoque_equipamento

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

    Private Sub Estoque_chip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CarregaComboLoja()
        'CarregaComboDatas()
        'CarregaComboCodigoLoja()
        Inicio()
    End Sub


    Private Sub Inicio()
        Dim sql As String
        sql = "SELECT ID_EQUIPAMENTO, SERIE, MODELO, DESC_EQUIPAMENTO, ESTOQUE, TRANSITO, VALOR, ID_LOCAL, NOME, SIGLA, DATAMOV, ID_LOCAL_ESTOQUE, ID_TIPO_EQUIPAMENTO, TIPO_LOCAL "
        sql += " FROM VW_CG_ESTOQUE_EQUIPAMENTO WHERE 1=1 "
        'If cboLoja.Text <> "<TODOS>" Then
        '    sql += " AND NOME = '" & Trim(cboLoja.Text) & "'"
        'End If
        'If cboDatas.Text <> "TODAS" Then
        '    sql += " AND ( DATAMOV >= '" & Trim(cboDatas.Text) & " 00:00:00' AND DATAMOV <= '" & Trim(cboDatas.Text) & " 23:59:59' ) "
        'End If
        'If cboCodigo.Text <> "<TODOS>" Then
        '    sql += " AND CODIGO = '" & Trim(cboCodigo.Text) & "'"
        'End If
        If Not String.IsNullOrEmpty(txtIdLoja.Text) Then
            sql += " AND ID_LOCAL_ESTOQUE = " & Trim(txtIdLoja.Text)
        End If
        If Not String.IsNullOrEmpty(txtIdTipoEquipamento.Text) Then
            sql += " AND ID_TIPO_EQUIPAMENTO = " & Trim(txtIdTipoEquipamento.Text)
        End If
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            sql += " AND ( DATAMOV >= '" & Trim(TextBox1.Text) & " 00:00:00' AND DATAMOV <= '" & Trim(TextBox1.Text) & " 23:59:59' ) "
        End If
        sql += " ORDER BY ID_EQUIPAMENTO "
        'MessageBox.Show(sql, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        dgvDados.AutoResizeColumns()
        Aviso()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ExportaExcel(dgvDados, "Estoque_Equipamento")
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Inicio()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        'cboLoja.Text = "<TODOS>"
        'cboDatas.Text = "TODAS"
        'cboCodigo.Text = "<TODOS>"
        txtIdLoja.Text = ""
        txtIdTipoEquipamento.Text = ""
        txtDescLoja.Text = ""
        txtDescTipoEquipamento.Text = ""
        TextBox1.Text = "" 'Data do Estoque
    End Sub

    Private Sub btnPesqTipoEquipamento_Click(sender As Object, e As EventArgs) Handles btnPesqTipoEquipamento.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_TIPO_EQUIPAMENTO"
        Me.ObjModelFk.CampoId = "ID_TIPO_EQUIPAMENTO"
        Me.ObjModelFk.CampoDesc = "DESC_TIPO_EQUIPAMENTO"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Descrição"
        Me.ObjModelFk.TituloTela = "Pesquisa de Tipo de Equipamento"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc & _
                            " From " & Me.ObjModelFk.Tabela
        Me.ObjModelFk.FiltroSQL = " where 1=1 "

        PesquisaFK(Me.ObjModelFk)

        txtIdTipoEquipamento.Text = Me.ObjModelFk.txtId.ToString
        txtDescTipoEquipamento.Text = Me.ObjModelFk.txtDesc

    End Sub
    Public Sub PesquisaFK(oPesqFk As DTO.PesquisaFK)
        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica(Me, oPesqFk)
        frm.Owner = Me
        frm.ShowDialog()

    End Sub

    Private Sub btnPesqLoja_Click(sender As Object, e As EventArgs) Handles btnPesqLoja.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "VW_BUSCA_CG_LOJA"
        Me.ObjModelFk.CampoId = "ID_LOJA"
        Me.ObjModelFk.CampoDesc = "NOME"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Loja"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc & _
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where (1 = 1) "

        PesquisaFK(Me.ObjModelFk)

        txtIdLoja.Text = Me.ObjModelFk.txtId.ToString
        txtDescLoja.Text = Me.ObjModelFk.txtDesc

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumerosData(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated
        If Not validaData(TextBox1.Text) Then
            MessageBox.Show("Data Inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Text = ""
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
        If dgvDados.Rows(e.RowIndex).Cells("TIPO_LOCAL").Value = "T" Then
            For ixx = 0 To dgvDados.ColumnCount - 1
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Green
            Next
        Else
            Dim _id_local_estoque As String = ""
            For ixx = 0 To dgvDados.ColumnCount - 1

                _id_local_estoque = Trim(dgvDados.Rows(e.RowIndex).Cells("ID_LOCAL_ESTOQUE").Value)

                If _id_local_estoque = "7" Then '--> QUARENTENA
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Red

                ElseIf _id_local_estoque = "9" Then '--> DEVOLVEU FORNECEDOR
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Blue

                ElseIf _id_local_estoque = "2" Then '--> ASSISTENCIA TECNICA
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.Black
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Yellow

                ElseIf _id_local_estoque = "8" Then '--> INATIVO
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Black

                Else ' TODOS OS OUTROS TIPOS DE LOCAL
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.Black
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.White

                End If

            Next

        End If
    End Sub
End Class