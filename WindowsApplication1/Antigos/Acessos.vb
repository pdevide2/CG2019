'Pesquisa Base site: 
'http://forums.codeguru.com/showthread.php?428211.html
'PAULO EDUARDO DEVIDE
'11-AGO-16

Imports BLL.GlobalBLL
Imports System.Collections.Generic

Public Class Acessos
    Dim _comando As String
    Dim _filtro As String
    Dim _colunaFiltro As String
    Dim _objModelFk As Object
    Dim dtPermissao As DataTable
    Dim _operacao As Integer
    Dim linhaGrid As DataGridViewRow
    Public flagAcao As Integer = 0
    Dim _acesso As String
    Dim _modulo As Integer



    Public podeAbrir As Boolean = False

    Public Enum FlagAction

        Pesquisar = 0
        Modificar = 1
        Leitura = 5

    End Enum

    Public Property Modulo() As Integer
        Get
            Return _modulo
        End Get
        Set(ByVal value As Integer)
            _modulo = value
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

    Public Property Operacao() As Integer
        Get
            Return _operacao
        End Get
        Set(ByVal value As Integer)
            _operacao = value
        End Set
    End Property

    Public Property ColunaFiltro() As String
        Get
            Return _colunaFiltro
        End Get
        Set(ByVal value As String)
            _colunaFiltro = value
        End Set
    End Property

    Public Property Comando() As String
        Get
            Return _comando
        End Get
        Set(ByVal value As String)
            _comando = value
        End Set
    End Property

    Public Property Filtro() As String
        Get
            Return _filtro
        End Get
        Set(ByVal value As String)
            _filtro = value
        End Set
    End Property
    Public Overridable Property ObjModelFk() As Object
        Get
            Return _objModelFk
        End Get
        Set(ByVal value As Object)
            _objModelFk = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LoginCG() 'Carrega variavel Friend ACE_CODIGO pelo Setting ID_USER
        ' Add any initialization after the InitializeComponent() call.
        podeAbrir = True 'permissaoTela(3, ACE_CODIGO)


    End Sub

    Private Sub Acessos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ObjModelFk = New DTO.PesquisaFK


        Me.Modulo = 3 'codigo do Modulo de Permissões de Acesso

        Inicio()

    End Sub

    Private Sub Inicio()

        PreencheFkUsuario()
        Carregar()

    End Sub

    Private Sub PreencheFkUsuario()

        ObjModelFk.Tabela = "CG_USUARIO"
        ObjModelFk.CampoId = "ID_USUARIO"
        ObjModelFk.CampoDesc = "NOME"
        ObjModelFk.TxtId = ACE_CODIGO
        ObjModelFk.TxtDesc = ""

        Me.Text = "Cadastro de Permissões de Acesso de Usuários"
        With PesqFK1
            .txtId.Text = Convert.ToString(ACE_CODIGO)
        End With

        'Pesquisa Usuario por ID e preenche os TextBox da Tela
        PesquisaObjModelFkPorId(Me.ObjModelFk)
        With PesqFK1
            .txtId.Text = ObjModelFk.TxtId
            .txtDesc.Text = ObjModelFk.TxtDesc
        End With
    End Sub
    Private Sub Carregar()

        Me.Comando = "EXEC spListaAcessoUsuario "
        Me.ColunaFiltro = "ID_USUARIO"
        Me.Filtro = " @ID_USUARIO = " & PesqFK1.txtId.Text.ToString

        Dim ModuloId As DataGridViewTextBoxColumn
        Dim ModuloDesc As DataGridViewTextBoxColumn
        Dim Permissao As DataGridViewComboBoxColumn

        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()

        InitListaPermissao()

        dgvDados.ColumnCount = 0

        dgvDados.AutoGenerateColumns = False

        'Column 1: ModuloId
        ModuloId = New DataGridViewTextBoxColumn
        ModuloId.HeaderText = "Código"
        ModuloId.Name = "ModuloIdCol"


        'Column 2: ModuloDesc
        ModuloDesc = New DataGridViewTextBoxColumn
        ModuloDesc.HeaderText = "Descrição"
        ModuloDesc.Name = "ModuloDescCol"

        'Column 3: Permissao
        Permissao = New DataGridViewComboBoxColumn
        Permissao.HeaderText = "Permissão (S/L/G)"
        Permissao.Name = "PermissaoCol"
        Permissao.ValueMember = "Permissao"
        Permissao.DisplayMember = "Permissao"
        Permissao.DataSource = dtPermissao

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {ModuloId, ModuloDesc, Permissao})

        'Relacionar colunas do DataGridview com campos do DataTable/DataSet
        dgvDados.Columns("ModuloIdCol").DataPropertyName = "ID_MODULO"
        dgvDados.Columns("ModuloDescCol").DataPropertyName = "DESC_MODULO"
        dgvDados.Columns("PermissaoCol").DataPropertyName = "PERMISSAO"

        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(Me.Comando & Me.Filtro).Tables(0) '.CategoriaBLL.getTodasCategoriasDS.Tables(0)
        'dgvDados.Columns(2).CellTemplate = New DataGridViewComboBoxCell()

        dgvDados.Columns(0).ReadOnly = True
        dgvDados.Columns(1).ReadOnly = True
        dgvDados.Columns(2).ReadOnly = True

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas

        HabilitaBotoes(Me.Operacao)

        dgvDados.AutoResizeColumns()
    End Sub
    Private Sub InitListaPermissao()
        dtPermissao = New DataTable("Permissao")
        dtPermissao.Columns.Add("Permissao", GetType(String))
        'Adiciona 3 Rows na tabela Permissao
        Dim row As DataRow
        Dim strPermissao() As String = {"S", "L", "G"}

        For i As Integer = 1 To 3
            row = dtPermissao.NewRow
            row("Permissao") = strPermissao(i - 1)
            dtPermissao.Rows.Add(row)

        Next
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        HabilitaBotoes(FlagAction.Modificar)
        Fechar()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.Operacao = FlagAction.Modificar
        HabilitaBotoes(FlagAction.Modificar)
    End Sub

    Public Sub HabilitaBotoes(ByVal acao As Integer)

        dgvDados.Columns(0).ReadOnly = True
        dgvDados.Columns(1).ReadOnly = True
        dgvDados.Columns(2).ReadOnly = True

        Select Case acao
            Case FlagAction.Pesquisar
                btnModificar.Enabled = True
                btnCancelar.Enabled = False
                btnSalvar.Enabled = False
                btnSair.Enabled = True
                PesqFK1.btnPesq.Enabled = False
                btnRepetir.Enabled = False
                btnExcel.Enabled = True

            Case FlagAction.Modificar
                btnModificar.Enabled = False
                btnCancelar.Enabled = True
                btnSalvar.Enabled = True
                btnSair.Enabled = False
                PesqFK1.btnPesq.Enabled = True
                dgvDados.Columns(2).ReadOnly = False
                btnRepetir.Enabled = True
                btnExcel.Enabled = False

            Case FlagAction.Leitura
                btnModificar.Enabled = False
                btnCancelar.Enabled = False
                btnSalvar.Enabled = False
                btnSair.Enabled = True
                PesqFK1.btnPesq.Enabled = False
                btnRepetir.Enabled = False
                btnExcel.Enabled = True

            Case Else
                btnModificar.Enabled = False
                btnCancelar.Enabled = False
                btnSalvar.Enabled = False
                btnSair.Enabled = True
                PesqFK1.btnPesq.Enabled = False
                btnRepetir.Enabled = False
                btnExcel.Enabled = True

        End Select

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Operacao = FlagAction.Pesquisar
        HabilitaBotoes(FlagAction.Pesquisar)
        Carregar()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Gravar()
        Me.Operacao = FlagAction.Pesquisar
        HabilitaBotoes(FlagAction.Pesquisar)
    End Sub

    Public Sub Gravar()
        'MyBase.Gravar(acao)
        Dim bll As New BLL.AcessoBLL
        Dim objAcesso As New DTO.Cg_acesso
        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    objAcesso.Id_modulo = CInt(row.Cells(0).Value)
                    objAcesso.Id_usuario = CInt(PesqFK1.txtId.Text)
                    objAcesso.Permissao = row.Cells(2).Value.ToString()

                    objAcesso.User_ins = ACE_CODIGO
                    objAcesso.Data_ins = Hoje()
                    objAcesso.User_upd = ACE_CODIGO
                    objAcesso.Data_upd = Hoje()
                    objAcesso.Id_empresa = Publico.Id_empresa

                    bll.GravarBLL(objAcesso)

                End If

            Next
            'MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'flagAcao = Operacao.Consulta

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try

    End Sub

    Private Sub btnRepetir_Click(sender As Object, e As EventArgs) Handles btnRepetir.Click
        RepetirValor()
    End Sub

    Private Sub RepetirValor()
        Try
            Dim StrPermissao As String
            StrPermissao = Trim((dgvDados.CurrentRow().Cells(2).Value).ToString)

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    row.Cells(2).Value = StrPermissao

                End If

            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao atribui valor: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function permissaoTela(ByVal intModulo As Integer, ByVal intUsuario As Integer) As Boolean
        flagAcao = FlagAction.Leitura
        Dim strPermissao As String = ""
        strPermissao = verPermissao(intModulo, intUsuario)

        Me.Acesso = strPermissao

        If strPermissao = "S" Then
            MessageBox.Show("Usuário sem permissão de acesso neste módulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf strPermissao = "L" Then
            flagAcao = FlagAction.Leitura
            btnModificar.Visible = False
        ElseIf strPermissao = "G" Then
            flagAcao = FlagAction.Pesquisar
            btnModificar.Visible = True
        Else
            MessageBox.Show("Configurações de permissão para este módulo não encontrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        Me.Operacao = flagAcao
        Return True
    End Function

    Function verPermissao(ByVal modulo As Integer, ByVal usuario As Integer) As String

        Dim retorno As String
        Dim oBLL As New BLL.GlobalBLL

        retorno = oBLL.getPermissaoBLL(modulo, usuario)
        Return retorno

    End Function

    Public Sub Fechar()

        ' http://stackoverflow.com/questions/15697282/excel-application-not-quitting-after-calling-quit
        Me.Close()
        'Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        ExportaExcel(dgvDados, "CG_ACESSO")

    End Sub

    
    Private Sub PesqFK1_Load(sender As Object, e As EventArgs) Handles PesqFK1.Load
        With Me.PesqFK1
            .LabelPesqFK = "Usuários"
            .Tabela = "CG_USUARIO"
            .View = "CG_USUARIO"
            .CampoId = "ID_USUARIO"
            .CampoDesc = "NOME"
            .ListaCampos = "ID_USUARIO, NOME"
            .ColunasFiltro = "NOME,ID_USUARIO"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Usuários"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = True

            'Ajustes de layout
            .lblLabelFK.Left = 1
            .btnPesq.Left += 10
            .txtId.Left += 10
            .txtDesc.Left += 10

        End With

    End Sub

    Private Sub PesqFK1_Leave(sender As Object, e As EventArgs) Handles PesqFK1.Leave
        If PesqFK1.PosValida = True And PesqFK1.Clicou > 0 Then
            Carregar()
        End If
    End Sub
End Class