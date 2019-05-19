Public Class TabelaPrecos

    Private _coluna_filtro As String
    Public Property ColunaFiltro() As String
        Get
            Return _coluna_filtro
        End Get
        Set(ByVal value As String)
            _coluna_filtro = value
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

    Private _comando As String
    Public Property Comando() As String
        Get
            Return _comando
        End Get
        Set(ByVal value As String)
            _comando = value
        End Set
    End Property

    Private _tabela_filha As String
    Public Property TabelaFilha() As String
        Get
            Return _tabela_filha
        End Get
        Set(ByVal value As String)
            _tabela_filha = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal objPermissaoModulo As DTO.PermissaoModulo)

        ' This call is required by the designer.
        InitializeComponent()

        arrayAcessoTela(0) = objPermissaoModulo.Pesquisa
        arrayAcessoTela(1) = objPermissaoModulo.Incluir
        arrayAcessoTela(2) = objPermissaoModulo.Alterar
        arrayAcessoTela(3) = objPermissaoModulo.Excluir

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()
        Me.PkString = True
        Me.Tabela = "CG_TABELA_SERVICOS_FORNECEDOR" 'Nome da tabela no SQL
        Me.View = "VW_CG_TABELA_SERVICOS_FORNECEDOR"
        Me.Modulo = 72 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_tabela_servicos_fornecedor
        Me.ColunaId = "ID_ITEM"
        Habilita_Controles(False) 'modo leitura
        Carregar()
    End Sub
    Public Overrides Sub Pesquisar()
        MyBase.Pesquisar()
        'MessageBox.Show(Me.KeyId.ToString, "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Carrega_Controles_Pesquisa()
    End Sub

    Public Overrides Sub Carrega_Controles_Pesquisa()
        MyBase.Carrega_Controles_Pesquisa()
        If Me.KeyId <> -1 Then
            'Na consulta alimenta os campos da tabela Pai
            lblIdItem.Text = Me.LinhaGrid.Cells("id_item").Value.ToString.ToUpper 'Chave PK da tabela 

            PesqFKFornecedor.txtId.Text = Me.LinhaGrid.Cells("id_fornecedor").Value.ToString
            PesqFKFornecedor.txtDesc.Text = Me.LinhaGrid.Cells("nome").Value.ToString
            txtTabela.Text = Me.LinhaGrid.Cells("id_tabela").Value.ToString 'Me.KeyId.ToString
            txtPreco.Text = Me.LinhaGrid.Cells("preco").Value.ToString
            Carregar()
        End If
    End Sub
    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)
        If Not ValidaCampos() Then
            Exit Sub
        End If

        Dim bllPai As New BLL.Tabela_servicos_fornecedorBLL
        Dim objTabela As New DTO.Cg_tabela_servicos_fornecedor

        Dim bllFilha As New BLL.Tabela_servicos_fornecedor_itemBLL
        Dim objTabelaItem As New DTO.Cg_tabela_servicos_fornecedor_item

        Try
            objTabela.Id_fornecedor = CInt(PesqFKFornecedor.txtId.Text)
            objTabela.Id_tabela = txtTabela.Text
            objTabela.Preco = txtPreco.Text
            objTabela.Id_item = lblIdItem.Text

            bllPai.GravarBLL(acao, objTabela)

            'Método delete/insert - Exclui todas as filhas e depois inclui o que estiver no Grid
            ExcluiFilha()

            'Percorre todo o DataGridView e insere os dados
            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    objTabelaItem.Id_item = lblIdItem.Text
                    objTabelaItem.Id_concerto = CInt(row.Cells(1).Value)
                    objTabelaItem.Id_fornecedor = objTabela.Id_fornecedor

                    'Operação de delete/insert
                    bllFilha.GravarBLL(Operacao.Novo, objTabelaItem)

                End If

            Next


            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(False) 'modo leitura

        End Try

    End Sub
    Public Overrides Sub Alterar()
        MyBase.Alterar()
        Habilita_Controles(True) 'modo digitação


    End Sub
    Public Overrides Sub Incluir()
        MyBase.Incluir()
        Dim bll As New BLL.GlobalBLL
        Me.KeyId = 1 'bll.NovaChaveBLL(Me.Tabela)
        Me.KeyIdStr = NovoKeyId()

        lblIdItem.Text = Me.KeyIdStr

        'If Me.KeyId > 0 Then
        If lblIdItem.Text <> "" Then
            'txtTabela.Text = Me.KeyId.ToString()
            Habilita_Controles(True) 'modo digitação
            Carregar()
        Else
            lblIdItem.Text = ""
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.MotivoBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub PesqFKFornecedor_Load(sender As Object, e As EventArgs) Handles PesqFKFornecedor.Load
        With Me.PesqFKFornecedor
            .LabelPesqFK = "Fornecedor"
            .Tabela = "CG_FORNECEDOR"
            .View = "CG_FORNECEDOR"
            .CampoId = "ID_FORNECEDOR"
            .CampoDesc = "NOME"
            .ListaCampos = "ID_FORNECEDOR, NOME, SIGLA"
            .ColunasFiltro = "NOME,SIGLA,ID_FORNECEDOR"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Fornecedores"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = True

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 29
            .txtId.Width -= 20
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 55
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With
    End Sub

    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao)
        PesqFKFornecedor.btnPesq.Enabled = False
        'Botões de manutenção do Grid
        btnAdd.Enabled = False
        btnRemove.Enabled = False
        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            PesqFKFornecedor.btnPesq.Enabled = True
            btnAdd.Enabled = True
            btnRemove.Enabled = True
        End If
    End Sub

    Public Overrides Sub Habilita_Controles(blnModo As Boolean)
        MyBase.Habilita_Controles(blnModo)
        txtTabela.Enabled = blnModo
        txtPreco.Enabled = blnModo
    End Sub

    Public Overrides Sub Limpar_Controles()
        MyBase.Limpar_Controles()
        PesqFKFornecedor.txtId.Text = ""
        PesqFKFornecedor.txtDesc.Text = ""
        txtTabela.Text = ""
        txtPreco.Text = ""

    End Sub
    Public Sub Carregar()
        Dim sql As String
        sql = "SELECT ID, ID_CONCERTO, DESC_CONCERTO, ID_TABELA, PRECO, ID_FORNECEDOR, NOME, SIGLA, ID_ITEM "
        sql += " From VW_CG_TABELA_SERVICOS_FORNECEDOR_ITEM "

        Me.Comando = sql
        Me.ColunaFiltro = "ID_ITEM"
        Me.Filtro = " WHERE " & Me.ColunaFiltro & " = '" & lblIdItem.Text & "'"

        'Declara as variáveis do Tipo Coluna
        Dim colId As DataGridViewTextBoxColumn
        Dim colIdConcerto As DataGridViewTextBoxColumn
        Dim colDescConcerto As DataGridViewTextBoxColumn
        Dim colIdTabela As DataGridViewTextBoxColumn
        Dim colPreco As DataGridViewTextBoxColumn
        Dim colIdFornecedor As DataGridViewTextBoxColumn
        Dim colNomeFornecedor As DataGridViewTextBoxColumn
        Dim colSiglaFornecedor As DataGridViewTextBoxColumn
        Dim colIdItem As DataGridViewTextBoxColumn

        '*******>> Configura as colunas
        'coluna Id Preço da peça (PK tabela filha)
        colId = New DataGridViewTextBoxColumn
        colId.HeaderText = "id"
        colId.Name = "ID"

        'coluna colIdConcerto
        colIdConcerto = New DataGridViewTextBoxColumn
        colIdConcerto.HeaderText = "Id Concerto"
        colIdConcerto.Name = "ID_CONCERTO"

        'coluna colDescConcerto
        colDescConcerto = New DataGridViewTextBoxColumn
        colDescConcerto.HeaderText = "Descrição do Concerto"
        colDescConcerto.Name = "DESC_CONCERTO"

        'coluna colIdTabela
        colIdTabela = New DataGridViewTextBoxColumn
        colIdTabela.HeaderText = "Tabela"
        colIdTabela.Name = "ID_TABELA"

        'coluna colPreco
        colPreco = New DataGridViewTextBoxColumn
        colPreco.HeaderText = "Preço R$"
        colPreco.Name = "PRECO"

        'coluna colIdFornecedor
        colIdFornecedor = New DataGridViewTextBoxColumn
        colIdFornecedor.HeaderText = "Id Fornecedor"
        colIdFornecedor.Name = "ID_FORNECEDOR"

        'coluna colNomeFornecedor
        colNomeFornecedor = New DataGridViewTextBoxColumn
        colNomeFornecedor.HeaderText = "Nome Fornecedor"
        colNomeFornecedor.Name = "NOME"

        'coluna colSiglaFornecedor
        colSiglaFornecedor = New DataGridViewTextBoxColumn
        colSiglaFornecedor.HeaderText = "Sigla"
        colSiglaFornecedor.Name = "SIGLA"

        'coluna colIdItem
        colIdItem = New DataGridViewTextBoxColumn
        colIdItem.HeaderText = "KEY"
        colIdItem.Name = "ID_ITEM"

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colId, colIdConcerto, colDescConcerto, colIdTabela, colPreco,
                                  colIdFornecedor, colNomeFornecedor, colSiglaFornecedor, colIdItem})

        'dgvDados.DataSource = myRow
        Popula_Grid()

        'dgvDados.Columns(0).ReadOnly = True ' coluna do Botão
        For ixx = 0 To 8
            dgvDados.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        dgvDados.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados.MultiSelect = False
        dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados.AllowUserToResizeColumns = False
        dgvDados.EnableHeadersVisualStyles = False

        'Alinhamento dos dados nas colunas do Grid e visibilidade
        'As colunas invisiveis server somente para armazenar informações para gravar depois
        dgvDados.Columns(0).Visible = False
        dgvDados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(3).Visible = False
        dgvDados.Columns(4).Visible = False
        dgvDados.Columns(5).Visible = False
        dgvDados.Columns(6).Visible = False
        dgvDados.Columns(7).Visible = False
        dgvDados.Columns(8).Visible = False


    End Sub


    Private Sub Popula_Grid()
        'Faz a Query no banco e retorna uma Lista de Array do Comando SQL
        Dim myRow As ArrayList
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
                        myRow(ixx)(6).ToString,
                        myRow(ixx)(7).ToString,
                        myRow(ixx)(8).ToString()}

            dgvDados.Rows.Add(strLinha)

        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim objTabela As New DTO.Cg_tabela_servicos_fornecedor
        objTabela.Id_fornecedor = CInt(PesqFKFornecedor.txtId.Text)
        objTabela.Id_item = lblIdItem.Text
        objTabela.Id_tabela = txtTabela.Text
        objTabela.Preco = txtPreco.Text
        Dim frm As New WinCG.FrmSelecionaItemTabelaNaoAlocado(objTabela, dgvDados)
        frm.ShowDialog()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvDados.RowCount > 0 Then
            ExcluiLinha()
        End If
    End Sub
    Private Sub ExcluiLinha()
        If MessageBox.Show("Confirma a exclusão deste registro?", "Aviso",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            'verifica se a linha a ser excluida é valida
            If dgvDados.SelectedRows.Count > 0 AndAlso Not dgvDados.SelectedRows(0).Index = dgvDados.Rows.Count Then
                dgvDados.Rows.RemoveAt(dgvDados.SelectedRows(0).Index)
            End If
        End If

    End Sub
    Private Sub ExcluiFilha()
        Dim bllglobal As New BLL.GlobalBLL
        Dim cmdsql As String

        cmdsql = "DELETE FROM CG_TABELA_SERVICOS_FORNECEDOR_ITEM WHERE ID_ITEM = '" & lblIdItem.Text & "'"

        Try
            bllglobal.GravarGenericoBLL(cmdsql)
            'MessageBox.Show("Registros excluidos com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub txtPreco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPreco.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumerosMoeda(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub
End Class