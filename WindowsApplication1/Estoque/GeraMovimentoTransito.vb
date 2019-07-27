Public Class GeraMovimentoTransito

    Private blnGravouChip As Boolean = False
    Private blnGravouPOS As Boolean = False

    Private _filtro As String
    Public Property Filtro() As String
        Get
            Return _filtro
        End Get
        Set(ByVal value As String)
            _filtro = value
        End Set
    End Property

    Private _coluna_filtro As String
    Public Property ColunaFiltro() As String
        Get
            Return _coluna_filtro
        End Get
        Set(ByVal value As String)
            _coluna_filtro = value
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

    Private _view As String
    Public Property View() As String
        Get
            Return _view
        End Get
        Set(ByVal value As String)
            _view = value
        End Set
    End Property
    Private _tabela As String
    Public Property Tabela() As String
        Get
            Return _tabela
        End Get
        Set(ByVal value As String)
            _tabela = value
        End Set
    End Property

    Private _tipo_estoque As String
    Public Property TipoEstoque() As String
        Get
            Return _tipo_estoque
        End Get
        Set(ByVal value As String)
            _tipo_estoque = value
        End Set
    End Property
    Private _objModelFk As Object
    Public Property ObjModelFk() As Object
        Get
            Return _objModelFk
        End Get
        Set(ByVal value As Object)
            _objModelFk = value
        End Set
    End Property
    Public Sub New(ByVal _tipo_estoque)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.TipoEstoque = _tipo_estoque

    End Sub

    Private Sub GeraMovimentoTransito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio()
    End Sub

    Private Sub Inicio()
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed

        For Each tab As TabPage In TabControl1.TabPages

            tab.Text = ""
        Next
        Me.Text = "Geração de Movimento de Trânsito de Estoque de Chip/POS" '+= IIf(Me.TipoEstoque = "C", " - Chip", " - POS/Equipamento")
        CarregaComboEmpresa()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ValidaEtapa1() Then
            Me.TabControl1.SelectedTab = TabPage3
            Carregar()
        End If


    End Sub
    Private Sub Carregar()
        CarregarChip()
        Carregar_POS()
    End Sub
    Private Function ValidaEtapa1() As Boolean
        Dim msg As String = "", blnOk As Boolean = True
        If String.IsNullOrEmpty(PesqFKTransito.txtId.Text) Or PesqFKTransito.txtId.Text = "0" Then
            msg = "Obrigatório preencher o Transito"
            blnOk = False
        End If
        If String.IsNullOrEmpty(PesqFKLojaOrigem.txtId.Text) Or PesqFKLojaOrigem.txtId.Text = "0" Then
            msg += Chr(13) & "Obrigatório preencher a Loja De Origem"
        End If
        If Not String.IsNullOrEmpty(msg) Then
            blnOk = False
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return blnOk
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.TabControl1.SelectedTab = TabPage1
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'If Me.TipoEstoque = "C" Then
        '    GravarTransitoChip()
        'Else
        '    GravarTransitoEquipamento()
        'End If
        blnGravouChip = False
        blnGravouPOS = False
        GravarTransitoChip()
        GravarTransitoEquipamento()
        'Se passar pelos dois metodos de gravação sem Exception então Gravou com Sucesso!
        If blnGravouChip = True And blnGravouPOS = True Then
            MessageBox.Show("Gravação Concluída com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Me.Close()
    End Sub
    Private Sub GravarTransitoChip()
        Dim sql As String = ""
        Dim bllGlobal As New BLL.GlobalBLL

        Try
            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then
                    sql = "INSERT INTO [dbo].[CG_MOV_TRANSITO_CHIP] "
                    sql += "([ID_TRANSITO]"
                    sql += ",[ID_ORIGEM]"
                    sql += ",[ID_CHIP]"
                    sql += ",[QUANTIDADE]"
                    sql += ",[USER_INS]"
                    sql += ",[DATA_LANCTO]"
                    sql += ",[ID_DESTINO]"
                    sql += ",[DATA_MOV_DESTINO], [ID_EMPRESA])"
                    sql += " VALUES(" & PesqFKTransito.txtId.Text & ","
                    sql += PesqFKLojaOrigem.txtId.Text & ","
                    sql += row.Cells("ID_CHIP").Value & " ,"
                    sql += row.Cells("QTD").Value & " ,"
                    sql += ACE_CODIGO.ToString & " ,"
                    sql += "GETDATE(),"
                    sql += "NULL,"
                    sql += "NULL, " & Publico.Id_empresa & ")"

                    bllGlobal.GravarGenericoBLL(sql)

                    'Operação de insert continuo

                End If

            Next
            blnGravouChip = True
            'MessageBox.Show("Gravação Concluída com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            blnGravouChip = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Finally
            '    Me.Close()
        End Try
    End Sub

    Private Sub GravarTransitoEquipamento()
        Dim sql As String = ""
        Dim bllGlobal As New BLL.GlobalBLL

        Try
            For Each row As DataGridViewRow In dgvDados2.Rows

                If Not row.IsNewRow Then
                    sql = "INSERT INTO [dbo].[CG_MOV_TRANSITO_EQUIPAMENTO] "
                    sql += "([ID_TRANSITO]"
                    sql += ",[ID_ORIGEM]"
                    sql += ",[ID_EQUIPAMENTO]"
                    sql += ",[QUANTIDADE]"
                    sql += ",[USER_INS]"
                    sql += ",[DATA_LANCTO]"
                    sql += ",[ID_DESTINO]"
                    sql += ",[DATA_MOV_DESTINO], [ID_EMPRESA])"
                    sql += " VALUES(" & PesqFKTransito.txtId.Text & ","
                    sql += PesqFKLojaOrigem.txtId.Text & ","
                    sql += row.Cells("ID_EQUIPAMENTO").Value & " ,"
                    sql += row.Cells("QTD").Value & " ,"
                    sql += ACE_CODIGO.ToString & " ,"
                    sql += "GETDATE(),"
                    sql += "NULL,"
                    sql += "NULL, " & Publico.Id_empresa & ")"

                    bllGlobal.GravarGenericoBLL(sql)

                    'Operação de insert continuo

                End If

            Next
            blnGravouPOS = True
            'MessageBox.Show("Gravação Concluída com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            blnGravouPOS = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Finally
            '    Me.Close()
        End Try
    End Sub

    Private Sub btnAdiciona_Click(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        If String.IsNullOrEmpty(PesqFKLojaOrigem.txtId.Text) Or PesqFKLojaOrigem.txtId.Text = "0" Then
            MessageBox.Show("Atenção selecione primeiro a Loja de Origem antes de adicionar itens", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Seleciona Chip
        Me.TipoEstoque = "C"
        If Me.TipoEstoque = "C" Then
            Dim frm As New WinCG.frmSelecionaChipTransito(CInt(PesqFKLojaOrigem.txtId.Text), dgvDados, "spSelecionaEstoqueChipLoja")
            frm.ShowDialog()
        Else
            Dim frm As New WinCG.frmSelecionaChipTransito(CInt(PesqFKLojaOrigem.txtId.Text), dgvDados2, "spSelecionaEstoqueEQUIPAMENTOLoja")
            frm.ShowDialog()
        End If
    End Sub

    Public Sub CarregarChip()
        Dim sql As String

        sql = "select 'Visualizar' as botao, ID_CHIP,SIMID,ID_OPERADORA,DESC_OPERADORA,ESTOQUE AS QTD,CUSTO AS VALOR "
        sql += " from VW_CG_ESTOQUE_CHIP "

        'sql = "SELECT 'Visualizar' as botao, "
        'sql += " ID_CHIP, SIMID, ID_OPERADORA, DESC_OPERADORA, QTD, VALOR, ID_ROMANEIO, UNIQUE_KEYID "
        'sql += " FROM VW_CG_MOVIMENTO_CHIP_ITEM "
        Me.Comando = sql
        Me.ColunaFiltro = "ID_ROMANEIO"
        Me.Filtro = " WHERE TIPO_LOCAL='L' AND 1=0 " '" WHERE " & Me.ColunaFiltro & " = '" & txtCodigo.Text.ToString & "'"

        'Declara as variáveis do Tipo Coluna
        Dim colBotao As DataGridViewButtonColumn
        Dim colId_Chip As DataGridViewTextBoxColumn
        Dim colSimId As DataGridViewTextBoxColumn
        Dim colId_Operadora As DataGridViewTextBoxColumn
        Dim colDescOperadora As DataGridViewTextBoxColumn
        Dim colQtd As DataGridViewTextBoxColumn
        Dim colValor As DataGridViewTextBoxColumn


        '*******>> Configura as colunas
        'coluna botao
        colBotao = New DataGridViewButtonColumn
        colBotao.HeaderText = "Visualizar"
        colBotao.Name = "colBotao1"

        'coluna Id_chip
        colId_Chip = New DataGridViewTextBoxColumn
        colId_Chip.HeaderText = "Id Chip"
        colId_Chip.Name = "ID_CHIP"

        'coluna Simid
        colSimId = New DataGridViewTextBoxColumn
        colSimId.HeaderText = "SIMID#"
        colSimId.Name = "SIMID"

        'coluna ID_Operadora
        colId_Operadora = New DataGridViewTextBoxColumn
        colId_Operadora.HeaderText = "Id Operadora"
        colId_Operadora.Name = "ID_OPERADORA"

        'coluna Descrição Operadora
        colDescOperadora = New DataGridViewTextBoxColumn
        colDescOperadora.HeaderText = "Descrição Operadora"
        colDescOperadora.Name = "DESC_OPERADORA"

        'coluna Quantidade
        colQtd = New DataGridViewTextBoxColumn
        colQtd.HeaderText = "Quantidade"
        colQtd.Name = "QTD"

        'coluna Valor
        colValor = New DataGridViewTextBoxColumn
        colValor.HeaderText = "Valor R$"
        colValor.Name = "VALOR"



        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colBotao, colId_Chip, colSimId, colId_Operadora, _
                                                            colDescOperadora, colQtd, colValor})

        'dgvDados.DataSource = myRow
        Popula_Grid("C")

        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão
        For ixx = 1 To 6
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
        dgvDados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvDados.Columns(0).Visible = False 'botaozinho
        dgvDados.Columns(1).Visible = False 'ID Chip


    End Sub

    Private Sub Popula_Grid(_tipoEstoque As String)
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
                        myRow(ixx)(4).ToString, _
                        myRow(ixx)(5).ToString, _
                        myRow(ixx)(6).ToString}

            If _tipoEstoque = "C" Then
                dgvDados.Rows.Add(strLinha)
            Else
                dgvDados2.Rows.Add(strLinha)
            End If

        Next

    End Sub

    Private Sub btnExclui_Click(sender As Object, e As EventArgs) Handles btnExclui.Click
        If dgvDados.RowCount > 0 Then
            ExcluiLinha()
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
    Private Sub ExcluiLinha2()
        If MessageBox.Show("Confirma a exclusão deste registro?", "Aviso", _
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            'verifica se a linha a ser excluida é valida
            If dgvDados2.SelectedRows.Count > 0 AndAlso Not dgvDados2.SelectedRows(0).Index = dgvDados2.Rows.Count Then
                dgvDados2.Rows.RemoveAt(dgvDados2.SelectedRows(0).Index)
            End If
        End If
    End Sub

    Public Sub Carregar_POS()
        Dim sql As String

        sql = "select 'Visualizar' as botao, ID_EQUIPAMENTO,SERIE,DESC_EQUIPAMENTO,MODELO,"
        sql += "ESTOQUE AS QTD,VALOR "
        sql += " from VW_CG_ESTOQUE_EQUIPAMENTO "

        Me.Comando = sql
        Me.ColunaFiltro = "ID_ROMANEIO"
        Me.Filtro = " WHERE TIPO_LOCAL='L' AND 1=0 " '" WHERE " & Me.ColunaFiltro & " = '" & txtCodigo.Text.ToString & "'"

        'Declara as variáveis do Tipo Coluna
        Dim colBotao As DataGridViewButtonColumn
        Dim colId_Equipamento As DataGridViewTextBoxColumn
        Dim colSerie As DataGridViewTextBoxColumn
        Dim colDescricao As DataGridViewTextBoxColumn
        Dim colModelo As DataGridViewTextBoxColumn
        Dim colQtd As DataGridViewTextBoxColumn
        Dim colValor As DataGridViewTextBoxColumn

        '*******>> Configura as colunas
        'coluna botao
        colBotao = New DataGridViewButtonColumn
        colBotao.HeaderText = "Visualizar"
        colBotao.Name = "colBotao1"

        'coluna id_equipamento
        colId_Equipamento = New DataGridViewTextBoxColumn
        colId_Equipamento.HeaderText = "Id Equip."
        colId_Equipamento.Name = "ID_EQUIPAMENTO"

        'coluna Serie
        colSerie = New DataGridViewTextBoxColumn
        colSerie.HeaderText = "SERIE Nº"
        colSerie.Name = "SERIE"

        'coluna Descricao
        colDescricao = New DataGridViewTextBoxColumn
        colDescricao.HeaderText = "Descrição"
        colDescricao.Name = "DESC_EQUIPAMENTO"

        'coluna Modelo
        colModelo = New DataGridViewTextBoxColumn
        colModelo.HeaderText = "Modelo"
        colModelo.Name = "MODELO"

        'coluna Quantidade
        colQtd = New DataGridViewTextBoxColumn
        colQtd.HeaderText = "Quantidade"
        colQtd.Name = "QTD"

        'coluna Valor
        colValor = New DataGridViewTextBoxColumn
        colValor.HeaderText = "Valor R$"
        colValor.Name = "VALOR"

        'Reset no Grid
        dgvDados2.DataSource = Nothing
        dgvDados2.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados2.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados2.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados2.Columns.AddRange(New DataGridViewColumn() {colBotao, colId_Equipamento, colSerie, colDescricao, _
                                                            colModelo, colQtd, colValor})

        'dgvDados.DataSource = myRow
        Popula_Grid("E")

        dgvDados2.Columns(0).ReadOnly = False ' coluna do Botão
        For ixx = 1 To 6
            dgvDados2.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados2.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados2.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        dgvDados2.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados2.MultiSelect = False
        dgvDados2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados2.AllowUserToResizeColumns = False
        dgvDados2.EnableHeadersVisualStyles = False

        'Alinhamento dos dados nas colunas do Grid
        dgvDados2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvDados2.Columns(0).Visible = False 'botaozinho
        dgvDados2.Columns(1).Visible = False 'ID POS

    End Sub

    Private Sub PesqFKTransito_Load(sender As Object, e As EventArgs) Handles PesqFKTransito.Load
        With Me.PesqFKTransito
            .LabelPesqFK = "Trânsito"
            .Tabela = "CG_TRANSITO"
            .View = "CG_TRANSITO"
            .CampoId = "ID_TRANSITO"
            .CampoDesc = "NOME_TRANSITO"
            .ListaCampos = "ID_TRANSITO, NOME_TRANSITO"
            .ColunasFiltro = "NOME_TRANSITO,ID_TRANSITO"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Trânsito"
            '.FiltroSQL = " where (inativo = 0) AND ID_EMPRESA = " & Publico.Id_empresa
            .FiltroSQL = " where (inativo = 0) "
            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = True

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 9
            .txtId.Width -= 5
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 20
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With
    End Sub
    Private Sub PesqFKTransito_Leave(sender As Object, e As EventArgs) Handles PesqFKTransito.Leave
        'Muda o filtroSQL da Loja
        If PesqFKTransito.PosValida = True And PesqFKTransito.Clicou > 0 Then
            If PesqFKTransito.txtId.Text = "1" Then 'Transito interno
                PesqFKLojaOrigem.FiltroSQL = " where (id_loja in (1,7,8,9) or id_loja > 9) "
            Else 'Demais transitos
                PesqFKLojaOrigem.FiltroSQL = " where (ID_LOJA = 1 OR ID_LOJA > 9) "
            End If
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

            If TransitoInterno() = True Then 'Transito interno
                .FiltroSQL = " WHERE ID_EMPRESA = " & Publico.Id_empresa & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,7,8,9,10) "
            Else 'Demais transitos
                .FiltroSQL = " WHERE ID_EMPRESA = " & Publico.Id_empresa & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,10) "
            End If

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
    '***
    '* VERIFICA SE O TRANSITO SELECIONADO É DE CONTROLE INTERNO
    '* PARA PODER DEFINIR O FILTRO DA LOJA
    '*
    Private Function TransitoInterno() As Boolean
        Dim ret As Boolean = False
        Dim _idTransito As String = IIf(String.IsNullOrEmpty(PesqFKTransito.txtId.Text), "0", PesqFKTransito.txtId.Text)
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
    Private Sub btnAdicionaPOS_Click(sender As Object, e As EventArgs) Handles btnAdicionaPOS.Click
        If String.IsNullOrEmpty(PesqFKLojaOrigem.txtId.Text) Or PesqFKLojaOrigem.txtId.Text = "0" Then
            MessageBox.Show("Atenção selecione primeiro a Loja de Origem antes de adicionar itens", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Me.TipoEstoque = "E"
        If Me.TipoEstoque = "C" Then
            Dim frm As New WinCG.frmSelecionaChipTransito(CInt(PesqFKLojaOrigem.txtId.Text), dgvDados, "spSelecionaEstoqueChipLoja")
            frm.ShowDialog()
        Else
            Dim frm As New WinCG.frmSelecionaChipTransito(CInt(PesqFKLojaOrigem.txtId.Text), dgvDados2, "spSelecionaEstoqueEQUIPAMENTOLoja")
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnExcluiPOS_Click(sender As Object, e As EventArgs) Handles btnExcluiPOS.Click
        If dgvDados2.RowCount > 0 Then
            ExcluiLinha2()
        End If
    End Sub

    Private Sub CarregaComboEmpresa()

        Dim sql As String = "select SIGLA_EMPRESA, ID_EMPRESA from CG_EMPRESA ORDER BY ID_EMPRESA"
        Dim bllGlobal As New BLL.GlobalBLL
        Dim dt = bllGlobal.SqlExecDT(sql)
        Me.ComboBox1.DataSource = dt
        Me.ComboBox1.DisplayMember = "SIGLA_EMPRESA"
        Me.ComboBox1.ValueMember = "ID_EMPRESA"
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

End Class