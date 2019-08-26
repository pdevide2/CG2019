Public Class GeraTransitoGeral

    Private blnGravouChip As Boolean = False
    Private blnGravouPOS As Boolean = False

    Private _tipoEstoque As String
    Public Property TipoEstoque() As String
        Get
            Return _tipoEstoque
        End Get
        Set(ByVal value As String)
            _tipoEstoque = value
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

    Private _filtroSQLLoja As String
    Public Property FiltroSQLLoja() As String
        Get
            Return _filtroSQLLoja
        End Get
        Set(ByVal value As String)
            _filtroSQLLoja = value
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
        'Me.PkString = True
        'Me.Tabela = "CG_GeraTransitoGeral" 'Nome da tabela no SQL
        'Me.View = "VW_CG_GeraTransitoGeral" 'NOME da view no SQL
        'Me.Modulo = 65 'codigo do módulo de alocação
        'LoginCG() 'retorna o id do usuário

        ''Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        ''Atribui o retorno da permissão na propriedade Me.Acesso
        ''permissaoTela(Me.Modulo, ACE_CODIGO)
        'HabilitaBotoes(flagAcao)
        ''MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ''Me.ObjModel = New DTO.Cg_GeraTransitoGeral
        'Me.ColunaId = "ID_GeraTransitoGeral"
        'Habilita_Controles(False) 'modo leitura
        tsNavega.Visible = False
        Carregar()

    End Sub
    Public Overrides Sub Pesquisar()
        MyBase.Pesquisar()
        'MessageBox.Show(Me.KeyId.ToString, "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Carrega_Controles_Pesquisa()
    End Sub

    Public Overrides Sub Carrega_Controles_Pesquisa()
        'MyBase.Carrega_Controles_Pesquisa()
        'Try
        '    If Me.KeyId.ToString <> vbNullString Then
        '        txtCodigo.Text = Me.KeyIdStr
        '        txtDescricao.Text = Me.LinhaGrid.Cells("DESC_GeraTransitoGeral").Value.ToString
        '        PesqFkTransito.txtId.Text = Me.LinhaGrid.Cells("ID_RESPONSAVEL").Value.ToString
        '        PesqFkTransito.txtDesc.Text = Me.LinhaGrid.Cells("nome").Value.ToString
        '    End If
        'Catch ex As NullReferenceException
        '    MessageBox.Show("Pesquisa Cancelada pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtCodigo.Text = ""
        '    txtDescricao.Text = ""
        '    PesqFkTransito.txtId.Text = ""
        '    PesqFkTransito.txtDesc.Text = ""

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Public Overrides Function ValidaCampos() As Object
        'Try
        '    If String.IsNullOrEmpty(txtCodigo.Text) Then
        '        Throw New Exception("Atenção Código da GeraTransitoGeral deve ser preenchido!")
        '    End If
        '    If String.IsNullOrEmpty(txtDescricao.Text) Then
        '        Throw New Exception("Atenção Descrição da GeraTransitoGeral deve ser preenchida!")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'End Try
        'Return True
        'Return MyBase.ValidaCampos()
    End Function

    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)

        'If Not ValidaCampos() Then
        '    Exit Sub
        'End If

        'Dim bll As New BLL.GeraTransitoGeralBLL
        'Dim objGeraTransitoGeral As New DTO.Cg_GeraTransitoGeral
        'Try
        '    objGeraTransitoGeral.Id_GeraTransitoGeral = txtCodigo.Text
        '    objGeraTransitoGeral.Desc_GeraTransitoGeral = txtDescricao.Text
        '    objGeraTransitoGeral.Id_responsavel = CInt(PesqFkTransito.txtId.Text)
        '    objGeraTransitoGeral.User_ins = ACE_CODIGO
        '    objGeraTransitoGeral.Data_ins = Hoje()
        '    objGeraTransitoGeral.User_upd = ACE_CODIGO
        '    objGeraTransitoGeral.Data_upd = Hoje()
        '    objGeraTransitoGeral.Id_empresa = Publico.Id_empresa

        '    bll.GravarBLL(acao, objGeraTransitoGeral)
        '    MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    flagAcao = Operacao.Consulta

        'Catch ex As Exception
        '    MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally

        '    Habilita_Controles(False) 'modo leitura

        'End Try

    End Sub
    Public Overrides Sub Alterar()
        'MyBase.Alterar()
        'Habilita_Controles(True) 'modo digitação
        'txtCodigo.Enabled = False

    End Sub
    Public Overrides Sub Incluir()
        'MyBase.Incluir()
        ''Dim bll As New BLL.GlobalBLL
        'Me.KeyIdStr = "" 'bll.NovaChaveBLL(Me.Tabela)

        'txtCodigo.Enabled = True
        'txtCodigo.Text = Me.KeyIdStr.ToString()
        'Habilita_Controles(True)
        'txtCodigo.Focus()

    End Sub

    Public Overrides Sub ExcluirPorId()
        'MyBase.ExcluirPorId()
        'Dim bll As New BLL.GeraTransitoGeralBLL
        'Try
        '    bll.ExcluirBLL(Me.KeyId, Publico.Id_empresa)
        '    Cancelar(flagAcao)

        '    MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Catch ex As Exception
        '    MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End Try

    End Sub

    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao) 'Executa o método default da classe pai

        PesqFkTransito.btnPesq.Enabled = False 'Desabilita o botão 

        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            PesqFkTransito.btnPesq.Enabled = True 'Habilita o botão 
        End If

    End Sub

    Private Sub PesqFK1_Load(sender As Object, e As EventArgs) Handles PesqFkTransito.Load
        With Me.PesqFkTransito
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

    Private Sub PesqFkTransito_Leave(sender As Object, e As EventArgs) Handles PesqFkTransito.Leave
        'Muda o filtroSQL da Loja
        If PesqFkTransito.PosValida = True And PesqFkTransito.Clicou > 0 Then
            If PesqFkTransito.txtId.Text = "1" Then 'Transito interno
                Me.FiltroSQLLoja = " where (id_loja in (1,7,8,9) or id_loja > 9) "
            Else 'Demais transitos
                Me.FiltroSQLLoja = " where (ID_LOJA = 1 OR ID_LOJA > 9) "
            End If
        End If
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
                    sql += " VALUES(" & PesqFkTransito.txtId.Text & ","
                    sql += row.Cells("ID_LOJA").Value & ","
                    sql += row.Cells("ID_CHIP").Value & " ,"
                    sql += row.Cells("QTD").Value & " ,"
                    sql += ACE_CODIGO.ToString & " ,"
                    sql += "GETDATE(),"
                    sql += "NULL,"
                    sql += "NULL, " & row.Cells("ID_EMPRESA").Value & ")"

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
                    sql += ",[DATA_MOV_DESTINO], [ID_EMPRESA], [PEDIDO_VENDA])"
                    sql += " VALUES(" & PesqFkTransito.txtId.Text & ","
                    sql += row.Cells("ID_LOJA").Value & ","
                    sql += row.Cells("ID_EQUIPAMENTO").Value & " ,"
                    sql += row.Cells("QTD").Value & " ,"
                    sql += ACE_CODIGO.ToString & " ,"
                    sql += "GETDATE(),"
                    sql += "NULL,"
                    sql += "NULL, " & row.Cells("ID_EMPRESA").Value & ", " & IIf(CBool(row.Cells("sales_order").Value) = True, "1", "0") & ")"

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
    Private Sub Carregar()
        CarregarChip()
        Carregar_POS()
    End Sub
    Public Sub CarregarChip()
        Dim sql As String

        sql = "select 'Visualizar' as botao, ID_CHIP,SIMID,ID_OPERADORA,DESC_OPERADORA,ESTOQUE AS QTD,CUSTO AS VALOR, ID_LOCAL_ESTOQUE AS ID_LOJA, ID_EMPRESA "
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
        Dim colLoja As DataGridViewTextBoxColumn
        Dim colEmpresa As DataGridViewTextBoxColumn

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

        'coluna Loja
        colLoja = New DataGridViewTextBoxColumn
        colLoja.HeaderText = "Loja"
        colLoja.Name = "ID_LOJA"

        'coluna Empresa
        colEmpresa = New DataGridViewTextBoxColumn
        colEmpresa.HeaderText = "Empresa"
        colEmpresa.Name = "ID_EMPRESA"

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colBotao, colId_Chip, colSimId, colId_Operadora,
                                                            colDescOperadora, colQtd, colValor, colLoja, colEmpresa})

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
        dgvDados.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

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
            strLinha = {myRow(ixx)(0).ToString,
                        myRow(ixx)(1).ToString,
                        myRow(ixx)(2).ToString,
                        myRow(ixx)(3).ToString,
                        myRow(ixx)(4).ToString,
                        myRow(ixx)(5).ToString,
                        myRow(ixx)(6).ToString,
                        myRow(ixx)(7).ToString,
                        myRow(ixx)(8).ToString}

            If _tipoEstoque = "C" Then
                dgvDados.Rows.Add(strLinha)
            Else
                dgvDados2.Rows.Add(strLinha)
            End If

        Next

    End Sub
    Public Sub Carregar_POS()
        Dim sql As String

        sql = "select 'Visualizar' as botao, ID_EQUIPAMENTO,SERIE,DESC_EQUIPAMENTO,MODELO,"
        sql += "ESTOQUE AS QTD,VALOR, ID_LOCAL_ESTOQUE AS ID_LOJA, ID_EMPRESA, CAST(0 AS BIT) AS SALES_ORDER "
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
        Dim colLoja As DataGridViewTextBoxColumn
        Dim colEmpresa As DataGridViewTextBoxColumn
        Dim colSalesOrder As DataGridViewCheckBoxColumn

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

        'coluna Loja
        colLoja = New DataGridViewTextBoxColumn
        colLoja.HeaderText = "Loja"
        colLoja.Name = "ID_LOJA"

        'coluna Empresa
        colEmpresa = New DataGridViewTextBoxColumn
        colEmpresa.HeaderText = "Empresa"
        colEmpresa.Name = "ID_EMPRESA"

        colSalesOrder = New DataGridViewCheckBoxColumn
        colSalesOrder.HeaderText = "Pedido Venda"
        colSalesOrder.Name = "sales_order"


        'Reset no Grid
        dgvDados2.DataSource = Nothing
        dgvDados2.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados2.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados2.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados2.Columns.AddRange(New DataGridViewColumn() {colBotao, colId_Equipamento, colSerie, colDescricao,
                                                            colModelo, colQtd, colValor, colLoja, colEmpresa, colSalesOrder})

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
        dgvDados2.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvDados2.Columns(0).Visible = False 'botaozinho
        dgvDados2.Columns(1).Visible = False 'ID POS

    End Sub

    Private Sub btnExclui_Click(sender As Object, e As EventArgs) Handles btnExclui.Click
        If dgvDados.RowCount > 0 Then
            ExcluiLinha()
        End If
    End Sub

    Private Sub btnExcluiPOS_Click(sender As Object, e As EventArgs) Handles btnExcluiPOS.Click
        If dgvDados2.RowCount > 0 Then
            ExcluiLinha2()
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
    Private Sub ExcluiLinha2()
        If MessageBox.Show("Confirma a exclusão deste registro?", "Aviso",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            'verifica se a linha a ser excluida é valida
            If dgvDados2.SelectedRows.Count > 0 AndAlso Not dgvDados2.SelectedRows(0).Index = dgvDados2.Rows.Count Then
                dgvDados2.Rows.RemoveAt(dgvDados2.SelectedRows(0).Index)
            End If
        End If
    End Sub

    Private Sub btnAdiciona_Click(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        'Seleciona Chip
        Me.TipoEstoque = "C"
        If Me.TipoEstoque = "C" Then
            Dim frm As New WinCG.frmSelecionaItemTransito(PesqFkTransito.txtId.Text, dgvDados, "spSelecionaEstoqueChipLoja")
            frm.ShowDialog()
        Else
            Dim frm As New WinCG.frmSelecionaItemTransito(PesqFkTransito.txtId.Text, dgvDados2, "spSelecionaEstoqueEQUIPAMENTOLoja")
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnAdicionaPOS_Click(sender As Object, e As EventArgs) Handles btnAdicionaPOS.Click
        Me.TipoEstoque = "E"
        If Me.TipoEstoque = "C" Then
            Dim frm As New WinCG.frmSelecionaItemTransito(PesqFkTransito.txtId.Text, dgvDados, "spSelecionaEstoqueChipLoja")
            frm.ShowDialog()
        Else
            Dim frm As New WinCG.frmSelecionaItemTransito(PesqFkTransito.txtId.Text, dgvDados2, "spSelecionaEstoqueEQUIPAMENTOLoja")
            frm.ShowDialog()
        End If
    End Sub
    'Método Confirmar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Adiciona item de pedido de vendas com Status = 2 (aprovado pela gerencia)
        Dim frm As New WinCG.frmSelecionaItemTransito(PesqFkTransito.txtId.Text, dgvDados2, "spSelecionaEstoqueEquipPedidoVenda", True)
        frm.ShowDialog()

    End Sub
End Class