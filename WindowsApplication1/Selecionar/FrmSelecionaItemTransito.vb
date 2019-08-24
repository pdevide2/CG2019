Public Class frmSelecionaItemTransito

    Dim _id_Empresa_Selecionada As String

    Private _transito As String
    Public Property Transito() As String
        Get
            Return _transito
        End Get
        Set(ByVal value As String)
            _transito = value
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

    Private _proc_sql As String
    Public Property ProcSQL() As String
        Get
            Return _proc_sql
        End Get
        Set(ByVal value As String)
            _proc_sql = value
        End Set
    End Property

    Private _comando As String
    Public Property Comando() As String
        Get
            Return _comando
        End Get
        Set(ByVal value As String)
            _comando = value
        End Set
    End Property

    Private _filtro As String
    Public Property Filtro() As String
        Get
            Return _filtro
        End Get
        Set(ByVal value As String)
            _filtro = value
        End Set
    End Property

    Private _grid_pai As DataGridView
    Public Property GridPai() As DataGridView
        Get
            Return _grid_pai
        End Get
        Set(ByVal value As DataGridView)
            _grid_pai = value
        End Set
    End Property

    Private _row As DataGridViewRow
    Public Property LinhaDados() As DataGridViewRow
        Get
            Return _row
        End Get
        Set(ByVal value As DataGridViewRow)
            _row = value
        End Set
    End Property

    Private _idLoja As String
    Public Property LojaOrigem() As String
        Get
            Return _idLoja
        End Get
        Set(ByVal value As String)
            _idLoja = value
        End Set
    End Property


    Public Sub New(ByVal _transito As String, ByRef _gridDados As DataGridView, _procSQL As String)

        ' This call is required by the designer.
        InitializeComponent()



        Me.GridPai = _gridDados
        Me.LojaOrigem = "0"
        Me.ProcSQL = _procSQL
        Me.Transito = _transito
        CarregaComboEmpresa()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    'Construtor para selecionar somente itens aprovados de Pedidos de Venda
    Public Sub New(ByVal _transito As String, ByRef _gridDados As DataGridView, _procSQL As String, ByVal blnSelecionaPedidoVenda As Boolean)

        ' This call is required by the designer.
        InitializeComponent()



        Me.GridPai = _gridDados
        Me.LojaOrigem = "1"
        Me.ProcSQL = _procSQL
        Me.Transito = _transito
        CarregaComboEmpresa()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub Carregar()
        Dim sql As String
        sql = "EXEC " & Me.ProcSQL & " "
        Me.Comando = sql
        Me.LojaOrigem = IIf(String.IsNullOrEmpty(PesqFKLojaOrigem.txtId.Text), "0", PesqFKLojaOrigem.txtId.Text)

        'Pega todos os chips no estoque da Loja Origem selecionado na tela pai e 
        'elimina da seleção todos que já foram selecionados no grid da tela pai
        Me.Filtro = Me.LojaOrigem '& ",'" & listaIdIncluidos() & "'"

        If Len(Trim(pesquisaNoGrid.Text)) > 0 Then
            Me.Filtro = Me.LojaOrigem & ", " & IIf(optPesq1.Checked = True, 1, 2) &
                            ", '" & Trim(pesquisaNoGrid.Text) & "'"
        End If

        ' Definição das colunas do grid
        '================================
        ' coluna0: selecao (checkbox)
        ' coluna1: ID_CHIP
        ' coluna2: SIMID
        ' coluna3: ID_OPERADORA
        ' coluna4: DESC_OPERADORA
        ' coluna5: ID_LOCAL_ESTOQUE
        ' coluna6: CUSTO

        'Declara as variáveis do Tipo Coluna
        Dim coluna0 As DataGridViewCheckBoxColumn
        Dim coluna1 As DataGridViewTextBoxColumn
        Dim coluna2 As DataGridViewTextBoxColumn
        Dim coluna3 As DataGridViewTextBoxColumn
        Dim coluna4 As DataGridViewTextBoxColumn
        Dim coluna5 As DataGridViewTextBoxColumn
        Dim coluna6 As DataGridViewTextBoxColumn


        '*******>> Configura as colunas
        'coluna checkbox
        coluna0 = New DataGridViewCheckBoxColumn
        coluna0.HeaderText = "Selecione"
        coluna0.Name = "selecao"
        coluna0.FlatStyle = FlatStyle.Standard
        coluna0.CellTemplate = New DataGridViewCheckBoxCell()
        coluna0.CellTemplate.Style.BackColor = Color.Beige

        'coluna coluna1
        coluna1 = New DataGridViewTextBoxColumn
        coluna1.HeaderText = "Id Chip"
        coluna1.Name = "ID_CHIP"

        'coluna coluna2
        coluna2 = New DataGridViewTextBoxColumn
        coluna2.HeaderText = "SIMID"
        coluna2.Name = "SIMID"

        'coluna coluna3
        coluna3 = New DataGridViewTextBoxColumn
        coluna3.HeaderText = "Id Operadora"
        coluna3.Name = "ID_OPERADORA"

        'coluna coluna4
        coluna4 = New DataGridViewTextBoxColumn
        coluna4.HeaderText = "Desc. Operadora"
        coluna4.Name = "DESC_OPERADORA"

        'coluna coluna5
        coluna5 = New DataGridViewTextBoxColumn
        coluna5.HeaderText = "Id Local Estoque"
        coluna5.Name = "ID_LOCAL_ESTOQUE"

        'coluna coluna6
        coluna6 = New DataGridViewTextBoxColumn
        coluna6.HeaderText = "Custo R$"
        coluna6.Name = "CUSTO"

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {coluna0, coluna1, coluna2, coluna3,
                                                            coluna4, coluna5, coluna6})

        'dgvDados.DataSource = myRow
        Popula_Grid()

        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão

        For ixx = 1 To 6
            dgvDados.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        dgvDados.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados.MultiSelect = False
        'dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados.AllowUserToResizeColumns = False
        dgvDados.EnableHeadersVisualStyles = False

        'Alinhamento dos dados nas colunas do Grid
        dgvDados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight



    End Sub

    Private Sub Popula_Grid()
        'Faz a Query no banco e retorna uma Lista de Array do Comando SQL
        Dim myRow As ArrayList
        'MessageBox.Show(Me.Comando & Me.Filtro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        myRow = BLL.GlobalBLL.PesquisarFkListaBLL(Me.Comando & Me.Filtro)

        Dim ixx As Integer
        Dim strLinha As String() 'declara um array de Strings que vai armazenar uma linha de registro toda
        For ixx = 0 To myRow.Count - 1

            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid
            strLinha = {myRow(ixx)(0).ToString,
                        myRow(ixx)(1).ToString,
                        myRow(ixx)(2).ToString,
                        myRow(ixx)(3).ToString,
                        myRow(ixx)(4).ToString,
                        myRow(ixx)(5).ToString,
                        myRow(ixx)(6).ToString}

            dgvDados.Rows.Add(strLinha)

        Next

    End Sub



    Private Sub Sair()

        Me.Close()

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Sair()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        AdicionaEscolhidos()
        Sair()
    End Sub

    'Alimenta o DataGridView da tela pai e fecha o form depois
    Private Sub AdicionaEscolhidos()

        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    If row.Cells(0).Value = True Then 'Verifica se o checkbox está clicado

                        Try
                            Dim strLinha As String() 'declara um array de Strings que vai armazenar uma linha de registro toda

                            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
                            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid
                            strLinha = {"Visualizar",
                                        row.Cells(1).Value.ToString,
                                        row.Cells(2).Value.ToString,
                                        row.Cells(3).Value.ToString,
                                        row.Cells(4).Value.ToString,
                                        "1",
                                        row.Cells(6).Value.ToString,
                                        PesqFKLojaOrigem.txtId.Text,
                                        Label3.Text}

                            If validaDuplicidade(row.Cells(1).Value.ToString) = False Then
                                Me.GridPai.Rows.Add(strLinha)
                            Else
                                MessageBox.Show(IIf(Me.TipoEstoque = "C", "SIMID ", "POS Série ") &
                                                row.Cells(2).Value.ToString & " não incluído, pois já " &
                                                "está inserido!", "Aviso", MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End Try

                    End If

                End If


            Next


        Catch ex As Exception
            MessageBox.Show("Erro ao selecionar chip: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try



    End Sub
    Private Function validaDuplicidade(_id As String) As Boolean
        Dim blnRet As Boolean = False
        For Each row As DataGridViewRow In Me.GridPai.Rows

            If Not row.IsNewRow Then

                'Carrega os dados no objeto Model para passagem de parametro
                If _id = row.Cells(1).Value Then
                    blnRet = True 'duplicado
                End If

            End If

        Next

        Return blnRet
    End Function
    Private Function listaIdIncluidos() As String
        Dim strLista As String = ""
        'Le todo o Grid e concatena os ID_CHIP numa string separado por virgula (,)
        For Each row As DataGridViewRow In Me.GridPai.Rows

            If Not row.IsNewRow Then

                'Carrega os dados no objeto Model para passagem de parametro
                strLista += row.Cells(1).Value & ","

            End If

        Next
        'Tira a última virgula (,) 
        If Not String.IsNullOrEmpty(strLista) Then
            strLista = strLista.Substring(0, Len(strLista) - 1)
        End If

        Return strLista
    End Function

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click
        If btnSelecionar.Text = "Desmarcar Todos" Then
            Marcar_Desmarcar(False)
            btnSelecionar.Text = "Marcar Todos"
        Else
            Marcar_Desmarcar(True)
            btnSelecionar.Text = "Desmarcar Todos"
        End If
    End Sub

    Private Sub Marcar_Desmarcar(ByVal blnAcao As Boolean)
        Try

            lblWait.Visible = True
            lblWait.Refresh()

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    row.Cells(0).Value = blnAcao

                End If

            Next

            lblWait.Visible = False
            lblWait.Refresh()

        Catch ex As Exception
            MessageBox.Show("Erro ao atribui valor: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        If optFilter1.Checked = True Then

            Dim texto As String = Nothing
            Dim intEscolha As Integer = IIf(optPesq1.Checked = True, 0, 1)

            If pesquisaNoGrid.Text <> String.Empty Then
                'Percorre todas as linhas do Grid e compara o conteudo do textbox de Pesquisa
                'com o conteudo da coluna SIMID do grid. Se a condição for satisfeita seleciona a linha e sai da rotina
                For Each linha As DataGridViewRow In dgvDados.Rows
                    texto = linha.Cells(2).Value 'Pesquisa na coluna de SIMID
                    If PesquisaString(texto.ToLower, pesquisaNoGrid.Text.ToLower, intEscolha) Then
                        linha.Selected = True
                        Exit Sub
                    End If
                Next
            End If
        Else
            Carregar()
        End If

    End Sub
    Private Sub CarregaComboEmpresa()

        Dim sql As String = "select CONVERT(VARCHAR(4), ID_EMPRESA)+'|'+SIGLA_EMPRESA AS SIGLA, ID_EMPRESA from CG_EMPRESA ORDER BY ID_EMPRESA"
        Dim bllGlobal As New BLL.GlobalBLL
        Dim dt = bllGlobal.SqlExecDT(sql)
        Me.ComboBox1.DataSource = dt
        Me.ComboBox1.DisplayMember = "SIGLA"
        Me.ComboBox1.ValueMember = "ID_EMPRESA"
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

        If ComboBox1.Items.Count > 0 Then
            Me.ComboBox1.SelectedIndex = (ComboBox1.Items.Count - 1)
            Me.ComboBox1.SelectedIndex = 0 'primeira opção - default
        End If

    End Sub

    Private Sub PesqFKLojaOrigem_Load(sender As Object, e As EventArgs) Handles PesqFKLojaOrigem.Load
        With Me.PesqFKLojaOrigem

            .LabelPesqFK = "Loja Origem"
            .Tabela = "VW_CG_LOJA"
            .View = "VW_CG_LOJA"
            .CampoId = "ID_LOJA"
            .CampoDesc = "NOME"
            .ListaCampos = "CODIGO,ID_LOJA,NOME"
            .ColunasFiltro = "CODIGO,NOME,ID_LOJA"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Tipo de Equipamento"

            'If TransitoInterno() = True Then 'Transito interno
            '    .FiltroSQL = " WHERE ID_EMPRESA = " & Label3.Text & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,7,8,9,10) "
            'Else 'Demais transitos
            '    .FiltroSQL = " WHERE ID_EMPRESA = " & Label3.Text & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,10) "
            'End If

            FiltroLojaEmpresa()

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 9
            .txtId.Width -= 5
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 20
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With

    End Sub

    Private Sub FiltroLojaEmpresa()
        If TransitoInterno() = True Then 'Transito interno
            'Me.PesqFKLojaOrigem.FiltroSQL = " WHERE ID_EMPRESA = " & Label3.Text & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,7,8,9,10) "
            Me.PesqFKLojaOrigem.FiltroSQL = " WHERE ID_EMPRESA = " & Label3.Text & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,10) "
        Else 'Demais transitos
            Me.PesqFKLojaOrigem.FiltroSQL = " WHERE ID_EMPRESA = " & Label3.Text & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,10) "
        End If
    End Sub
    '***
    '* VERIFICA SE O TRANSITO SELECIONADO É DE CONTROLE INTERNO
    '* PARA PODER DEFINIR O FILTRO DA LOJA
    '*
    Private Function TransitoInterno() As Boolean
        Dim ret As Boolean = False
        Dim _idTransito As String = IIf(String.IsNullOrEmpty(Me.Transito), "0", Me.Transito)
        Try
            Dim bllGlobal As New BLL.GlobalBLL
            Dim sql As String = "select * from CG_TRANSITO WHERE ID_TRANSITO = " & _idTransito

            'Dim dt As DataTable
            Dim dt = bllGlobal.SqlExecDT(sql)

            If dt.Rows.Count > 0 Then
                ret = dt(0)("CONTROLE_INTERNO")
            End If
            Return ret
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ret
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Carregar()
    End Sub

    Private Sub frmSelecionaItemTransito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optPesq1.Checked = False
        optPesq2.Checked = True
        Me.TipoEstoque = IIf(Me.ProcSQL = "spSelecionaEstoqueChipLoja", "C", "E")
        If Me.TipoEstoque = "C" Then
            Me.Text = "Seleção de Chip"
            Label1.Text = "SIMID"
        Else
            Me.Text = "Seleção de Equipamento (POS)"
            Label1.Text = "Série#"
        End If
        'CarregaComboEmpresa()
        Carregar()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        _id_Empresa_Selecionada = Trim(ComboBox1.Text)
        Dim arr1 = _id_Empresa_Selecionada.Split("|")
        _id_Empresa_Selecionada = arr1(0)
        Label3.Text = _id_Empresa_Selecionada
        FiltroLojaEmpresa()
    End Sub
End Class