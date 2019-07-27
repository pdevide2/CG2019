'PAULO EDUARDO DEVIDE
'09-JUL-17

Imports BLL.GlobalBLL
Imports System.Collections.Generic

Public Class ParametrosPesquisaDinamica
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


        Me.Modulo = 51 'codigo do Modulo
        Inicio()

    End Sub

    Private Sub Inicio()

        Carregar()

    End Sub


    Private Sub Carregar()

        Me.Comando = "EXEC spSelecionaColunasTabelaDinamica "
        Me.ColunaFiltro = "ID_TABELA"
        Me.Filtro = " @TABELA = '" & Trim(PesqFK1.txtDesc.Text.ToString) & "'"


        Dim colTabela As DataGridViewTextBoxColumn
        Dim colColuna As DataGridViewTextBoxColumn
        Dim colIdcoluna As DataGridViewTextBoxColumn
        Dim colOrdercol As DataGridViewTextBoxColumn
        Dim colChave As DataGridViewCheckBoxColumn
        Dim colTipodado As DataGridViewTextBoxColumn
        Dim colColuna_Filtro As DataGridViewCheckBoxColumn
        Dim colApelido_Coluna As DataGridViewTextBoxColumn
        Dim colMostra_Coluna As DataGridViewCheckBoxColumn
        Dim colColuna_Filtro_Inicial As DataGridViewCheckBoxColumn

        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()

        dgvDados.ColumnCount = 0

        dgvDados.AutoGenerateColumns = False

        colTabela = New DataGridViewTextBoxColumn
        colTabela.HeaderText = "tabela"
        colTabela.Name = "colTabela"

        colColuna = New DataGridViewTextBoxColumn
        colColuna.HeaderText = "coluna"
        colColuna.Name = "colColuna"

        colIdcoluna = New DataGridViewTextBoxColumn
        colIdcoluna.HeaderText = "idcoluna"
        colIdcoluna.Name = "colIdcoluna"

        colOrdercol = New DataGridViewTextBoxColumn
        colOrdercol.HeaderText = "ordercol"
        colOrdercol.Name = "colOrdercol"

        colChave = New DataGridViewCheckBoxColumn
        colChave.HeaderText = "chave"
        colChave.Name = "colChave"

        colTipodado = New DataGridViewTextBoxColumn
        colTipodado.HeaderText = "tipodado"
        colTipodado.Name = "colTipodado"

        colColuna_Filtro = New DataGridViewCheckBoxColumn
        colColuna_Filtro.HeaderText = "coluna_filtro"
        colColuna_Filtro.Name = "colColuna_Filtro"

        colApelido_Coluna = New DataGridViewTextBoxColumn
        colApelido_Coluna.HeaderText = "apelido_coluna"
        colApelido_Coluna.Name = "colApelido_Coluna"

        colMostra_Coluna = New DataGridViewCheckBoxColumn
        colMostra_Coluna.HeaderText = "mostra_coluna"
        colMostra_Coluna.Name = "colMostra_Coluna"

        colColuna_Filtro_Inicial = New DataGridViewCheckBoxColumn
        colColuna_Filtro_Inicial.HeaderText = "coluna_filtro_inicial"
        colColuna_Filtro_Inicial.Name = "colColuna_Filtro_Inicial"


        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colTabela, colColuna, colIdcoluna, colOrdercol, _
                                                            colChave, colTipodado, colColuna_Filtro, _
                                                            colApelido_Coluna, colMostra_Coluna, _
                                                            colColuna_Filtro_Inicial})

        'Relacionar colunas do DataGridview com campos do DataTable/DataSet
        dgvDados.Columns("colTabela").DataPropertyName = "TABELA"
        dgvDados.Columns("colColuna").DataPropertyName = "COLUNA"
        dgvDados.Columns("colIdcoluna").DataPropertyName = "IDCOLUNA"
        dgvDados.Columns("colOrdercol").DataPropertyName = "ORDERCOL"
        dgvDados.Columns("colChave").DataPropertyName = "CHAVE"
        dgvDados.Columns("colTipodado").DataPropertyName = "TIPODADO"
        dgvDados.Columns("colColuna_Filtro").DataPropertyName = "COLUNA_FILTRO"
        dgvDados.Columns("colApelido_Coluna").DataPropertyName = "APELIDO_COLUNA"
        dgvDados.Columns("colMostra_Coluna").DataPropertyName = "MOSTRA_COLUNA"
        dgvDados.Columns("colColuna_Filtro_Inicial").DataPropertyName = "COLUNA_FILTRO_INICIAL"


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

                btnExcel.Enabled = True

            Case FlagAction.Modificar
                btnModificar.Enabled = False
                btnCancelar.Enabled = True
                btnSalvar.Enabled = True
                btnSair.Enabled = False
                PesqFK1.btnPesq.Enabled = True
                dgvDados.Columns(2).ReadOnly = False

                btnExcel.Enabled = False

            Case FlagAction.Leitura
                btnModificar.Enabled = False
                btnCancelar.Enabled = False
                btnSalvar.Enabled = False
                btnSair.Enabled = True
                PesqFK1.btnPesq.Enabled = False

                btnExcel.Enabled = True

            Case Else
                btnModificar.Enabled = False
                btnCancelar.Enabled = False
                btnSalvar.Enabled = False
                btnSair.Enabled = True
                PesqFK1.btnPesq.Enabled = False

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

    Public Sub PesquisaFK(oPesqFk As DTO.PesquisaFK)
        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica(Me, oPesqFk)
        frm.Owner = Me
        frm.ShowDialog()

    End Sub

    Public Sub Gravar()
        'MyBase.Gravar(acao)
        Dim bll As New BLL.Parametro_pesquisa_dinamicaBLL
        Dim oPesq As New DTO.Cg_parametro_pesquisa_dinamica
        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    oPesq.Tabela = row.Cells(0).Value
                    oPesq.Coluna = row.Cells(1).Value
                    oPesq.Idcoluna = CInt(row.Cells(2).Value)
                    oPesq.Ordercol = CInt(row.Cells(3).Value)
                    oPesq.Chave = CDbl(row.Cells(4).Value)
                    oPesq.Tipodado = row.Cells(5).Value
                    oPesq.Coluna_filtro = CDbl(row.Cells(6).Value)
                    oPesq.Apelido_coluna = row.Cells(7).Value
                    oPesq.Mostra_coluna = CDbl(row.Cells(8).Value)
                    oPesq.Coluna_filtro_inicial = CDbl(row.Cells(9).Value)


                    bll.GravarBLL(1, oPesq)

                End If

            Next
            'MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'flagAcao = Operacao.Consulta
            MessageBox.Show("Gravação concluída com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


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

        Me.Close()
        'Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        ExportaExcel(dgvDados, "CG_PARAMETRO_PESQUISA_DINAMICA")

    End Sub


    Private Sub PesqFK1_Load(sender As Object, e As EventArgs) Handles PesqFK1.Load
        With Me.PesqFK1
            .LabelPesqFK = "Tabela"
            .Tabela = "CG_TABELAS_PESQUISA_DINAMICA"
            .View = "CG_TABELAS_PESQUISA_DINAMICA"
            .CampoId = "ID_TABELA"
            .CampoDesc = "TABELA"
            .ListaCampos = "ID_TABELA, TABELA"
            .ColunasFiltro = "TABELA,ID_TABELA"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de TABELAS"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = True

            'Ajustes de layout
            .lblLabelFK.Left -= 0
            .txtId.Left += 19
            .txtDesc.Left += 19
            .txtDesc.Width += 80
            .btnPesq.Left += 99
        End With

    End Sub

    Private Sub PesqFK1_Leave_1(sender As Object, e As EventArgs) Handles PesqFK1.Leave
        If PesqFK1.PosValida = True And PesqFK1.Clicou > 0 Then
            Carregar()
        End If
    End Sub
End Class