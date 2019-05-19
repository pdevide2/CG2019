

Public Class Pos_vinculo

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

    Public Sub Carregar()
        Dim sql As String

        sql = "SELECT ID_CHIP, SIMID, ID_OPERADORA, DESC_OPERADORA, ID_EQUIPAMENTO "
        sql += "FROM VW_CG_EQUIPAMENTO_VS_CHIP "

        Me.Comando = sql
        Me.ColunaFiltro = "ID_EQUIPAMENTO"
        Me.Filtro = " WHERE " & Me.ColunaFiltro & " = '" & txtCodigo.Text.ToString & "'"

        'Declara as variáveis do Tipo Coluna

        Dim colId_chip As DataGridViewTextBoxColumn
        Dim colSimId As DataGridViewTextBoxColumn
        Dim colId_Operadora As DataGridViewTextBoxColumn
        Dim colDesc_Operadora As DataGridViewTextBoxColumn
        Dim colId_Equipamento As DataGridViewTextBoxColumn

        '*******>> Configura as colunas

        'coluna colId_Chip
        colId_chip = New DataGridViewTextBoxColumn
        colId_chip.HeaderText = "Chip ID"
        colId_chip.Name = "ID_CHIP"

        'coluna colSimId
        colSimId = New DataGridViewTextBoxColumn
        colSimId.HeaderText = "SIMID"
        colSimId.Name = "SIMID"

        'coluna colId_Operadora
        colId_Operadora = New DataGridViewTextBoxColumn
        colId_Operadora.HeaderText = "Operadora ID"
        colId_Operadora.Name = "ID_OPERADORA"

        'coluna colDesc_Operadora
        colDesc_Operadora = New DataGridViewTextBoxColumn
        colDesc_Operadora.HeaderText = "Descrição Operadora"
        colDesc_Operadora.Name = "DESC_OPERADORA"

        'coluna colId_Equipamento
        colId_Equipamento = New DataGridViewTextBoxColumn
        colId_Equipamento.HeaderText = "Equip. ID"
        colId_Equipamento.Name = "ID_EQUIPAMENTO"

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colId_chip, colSimId, colId_Operadora, _
                                                            colDesc_Operadora, colId_Equipamento})
        'dgvDados.DataSource = myRow
        Popula_Grid()

        dgvDados.Columns(0).ReadOnly = True ' coluna id_chip
        For ixx = 1 To 4
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

        'Alinhamento dos dados nas colunas do Grid
        dgvDados.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

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
            strLinha = {myRow(ixx)(0).ToString, _
                        myRow(ixx)(1).ToString, _
                        myRow(ixx)(2).ToString, _
                        myRow(ixx)(3).ToString, _
                        myRow(ixx)(4).ToString}

            dgvDados.Rows.Add(strLinha)

        Next

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()

        Me.PkString = False
        Me.Tabela = "CG_EQUIPAMENTO_VS_CHIP" 'Nome da tabela no SQL
        Me.View = "VW_CG_EQUIPAMENTO_VS_CHIP_AGRUPADO"
        Me.TabelaFilha = ""
        Me.Modulo = 29 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_equipamento_vs_chip
        Me.ColunaId = "ID_EQUIPAMENTO"
        Habilita_Controles(False) 'modo leitura

        'Monta o Grid e configura as colunas 
        Carregar()


    End Sub
    Public Overrides Sub Pesquisar()
        MyBase.Pesquisar()
        'MessageBox.Show(Me.KeyId.ToString, "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        flagAcao = Operacao.Consulta
        Carrega_Controles_Pesquisa()
    End Sub

    Public Overrides Sub Carrega_Controles_Pesquisa()
        MyBase.Carrega_Controles_Pesquisa()
        If Me.KeyId <> -1 Then

            txtCodigo.Text = Me.KeyId.ToString
            txtDescPOS.Text = Me.LinhaGrid.Cells("DESC_EQUIPAMENTO").Value.ToString
  
            Carregar()
            HabilitaBotoes(flagAcao)

        End If
    End Sub

    Public Overrides Function ValidaCampos() As Object
        Dim blnRet As Boolean
        txtCodigo.Tag = "Código POS"
        txtDescPOS.Tag = "Descrição POS"

        blnRet = MyBase.ValidaCampos()


        If blnRet Then
            If dgvDados.RowCount = 0 Then
                MessageBox.Show("Obrigatório informar os Chips para Vincular com POS.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnRet = False
            End If
        End If
        Return blnRet

    End Function

    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)

        If Not ValidaCampos() Then
            Exit Sub
        End If

        Dim bllDados As New BLL.Equipamento_vs_chipBLL
        Dim objEquipamento_vs_chip As New DTO.Cg_equipamento_vs_chip

        Try
            objEquipamento_vs_chip.Id_equipamento = CInt(txtCodigo.Text)


            'Dados de usuarios

            objEquipamento_vs_chip.User_upd = ACE_CODIGO
            objEquipamento_vs_chip.Data_upd = Hoje()

            'Método de Delete => Insert
            'Pesquisa pelos itens já existente e exclui tudo, para incluir os
            'itens que estão ativos no Grid
            Dim strItens As ArrayList
            Dim sqlquery As String

            sqlquery = "SELECT ID_EQUIPAMENTO, ID_CHIP FROM CG_EQUIPAMENTO_VS_CHIP "
            sqlquery += " WHERE ID_EQUIPAMENTO =  " & objEquipamento_vs_chip.Id_equipamento.ToString

            strItens = BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

            'Percorre o array e exclui item a item 

            Dim intParam1 As Integer, intParam2 As Integer
            For ixx = 0 To strItens.Count - 1
                intParam1 = strItens(ixx)(0)
                intParam2 = strItens(ixx)(1)

                bllDados.ExcluirBLL(intParam1, intParam2)
            Next

            'Percorre todo o DataGridView e insere os dados
            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    '                                                       

                    objEquipamento_vs_chip.Id_chip = CInt(row.Cells(0).Value)

                    'Operação de delete/insert
                    bllDados.GravarBLL(Operacao.Novo, objEquipamento_vs_chip)

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

    Public Overrides Sub Excluir()


        MyBase.Excluir()
        Habilita_Controles(True) 'modo digitação

    End Sub

    Public Overrides Sub Incluir()
        MyBase.Incluir()

        'If Me.KeyId > 0 Then
        '    txtCodigo.Text = Me.KeyId.ToString()
        '    Habilita_Controles(True) 'modo digitação
        '    Carregar()

        '    Dim strLoja As ArrayList
        '    Dim sqlquery As String
        '    sqlquery = "SELECT ID_LOJA, NOME FROM CG_LOJA WHERE dbo.CG_LOJA.ID_LOJA = 1"

        '    strLoja = Global.BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

        '    txtIdLoja.Text = strLoja(0)(0).ToString
        '    txtDescLoja.Text = strLoja(0)(1).ToString
        'Else
        '    Cancelar(flagAcao)
        'End If
        Carregar()
    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.Equipamento_vs_chipBLL
        Try
            Me.KeyId = CInt(txtCodigo.Text)
            bll.ExcluirTudoBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao)
        btnPesqPOS.Enabled = False

        btnAdiciona.Enabled = False
        btnExclui.Enabled = False


        If acao = Operacao.Novo Or acao = Operacao.Alterar Then

            'Somente habilita seleção de lojas na inclusão
            If acao = Operacao.Novo Then
                btnPesqPOS.Enabled = True
            End If

            btnAdiciona.Enabled = True
            btnExclui.Enabled = True

        End If
    End Sub

    Private Sub ExcluiLinha()
        If MessageBox.Show("Confirma a exclusão deste registro?", "Aviso", _
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            'verifica se a linha a ser excluida é valida
            If dgvDados.SelectedRows.Count > 0 AndAlso Not dgvDados.SelectedRows(0).Index = dgvDados.Rows.Count Then
                dgvDados.Rows.RemoveAt(dgvDados.SelectedRows(0).Index)
            End If
        End If

    End Sub

    Private Sub btnExclui_Click(sender As Object, e As EventArgs)
        ExcluiLinha()
    End Sub

    Public Overrides Sub Cancelar(acao As Integer)
        MyBase.Cancelar(acao)
        Carregar()

    End Sub

    Private Sub btnAdiciona_Click_1(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        If String.IsNullOrEmpty(txtCodigo.Text) Or txtCodigo.Text = "0" Then
            MessageBox.Show("Atenção selecione primeiro um POS antes de vincular Chips a ele", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim frm As New WinCG.FrmSelecionaChipVsPOS(CInt(txtCodigo.Text), CInt(txtCodigo.Text), dgvDados)
        frm.ShowDialog()
    End Sub

    Private Sub btnExclui_Click_1(sender As Object, e As EventArgs) Handles btnExclui.Click
        If dgvDados.RowCount > 0 Then
            ExcluiLinha()
        End If
    End Sub

    Private Sub btnPesqPOS_Click(sender As Object, e As EventArgs) Handles btnPesqPOS.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_EQUIPAMENTO"
        Me.ObjModelFk.CampoId = "ID_EQUIPAMENTO"
        Me.ObjModelFk.CampoDesc = "DESC_EQUIPAMENTO"
        Me.ObjModelFk.ListaCampos = "ID_EQUIPAMENTO, SERIE, MODELO, DESC_EQUIPAMENTO"
        Me.ObjModelFk.ColunasFiltro = "SERIE,DESC_EQUIPAMENTO,MODELO" ' ComboBox de filtros
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Equipamentos (POS)"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.ListaCampos & _
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where ID_EQUIPAMENTO NOT IN (SELECT ID_EQUIPAMENTO FROM CG_EQUIPAMENTO_VS_CHIP) "

        PesquisaFK2(Me.ObjModelFk)

        txtCodigo.Text = Me.ObjModelFk.txtId.ToString
        txtDescPOS.Text = Me.ObjModelFk.txtDesc
    End Sub

End Class