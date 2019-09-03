Public Class BaixaMovimentoTransito
    Private blnSalvouChip As Boolean = False
    Private blnSalvouPOS As Boolean = False
    Private strFiltroLoja As String = "= ID_LOJA"

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
        Me.Text = "Baixa de Trânsito de Estoque" '+= IIf(Me.TipoEstoque = "C", " - Chip", " - POS/Equipamento")
        If Me.TipoEstoque = "E" Then

            Me.Width += 150
            Me.TabControl1.Width += 140
            Me.dgvDados.Width += 140
            'Me.Panel1.Width += 140
            Me.Button1.Left += 110
            Me.Button4.Left += 110
            Me.Button5.Left += 110
            Me.Left -= 80
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ValidaEtapa1() Then
            Me.TabControl1.SelectedTab = TabPage3
            'Define o Filtro de Pesquisa de Loja conforme Transito selecionado
            PesqFKLojaDestino.FiltroSQL = IIf(TransitoInterno() = True, _
                                              " WHERE ID_EMPRESA = " & Publico.Id_empresa & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,7,8,9,10) ", _
                                              " WHERE ID_EMPRESA = " & Publico.Id_empresa & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,10) ")

            PesqFKLojaDestinoPOS.FiltroSQL = IIf(TransitoInterno() = True, _
                                              " WHERE ID_EMPRESA = " & Publico.Id_empresa & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,7,8,9,10) ", _
                                              " WHERE ID_EMPRESA = " & Publico.Id_empresa & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,10) ")
            'If Me.TipoEstoque = "C" Then
                Carregar()
            'Else
            'Carregar_POS()
            'End If
        End If


    End Sub
    '***
    '* VERIFICA SE O TRANSITO SELECIONADO É DE CONTROLE INTERNO
    '* PARA PODER DEFINIR O FILTRO DA LOJA
    '*
    Private Function TransitoInterno() As Boolean
        Dim ret As Boolean = False
        Try
            Dim bllGlobal As New BLL.GlobalBLL
            Dim sql As String = "select * from CG_TRANSITO WHERE ID_TRANSITO = " & PesqFKTransito.txtId.Text

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

    Private Sub Carregar()
        Me.TipoEstoque = "C"
        Carregar_Chip()
        Me.TipoEstoque = "E"
        Carregar_POS()
    End Sub

    Private Function ValidaEtapa1() As Boolean
        Dim msg As String = "", blnOk As Boolean = True
        If String.IsNullOrEmpty(PesqFKTransito.txtId.Text) Or PesqFKTransito.txtId.Text = "0" Then
            msg = "Obrigatório preencher o Transito"
            blnOk = False
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
        blnSalvouChip = False
        blnSalvouPOS = False
        GravarTransitoChip()
        GravarTransitoEquipamento()
        'Se passar pelos dois metodos de gravação sem Exception então Gravou com Sucesso!
        If blnSalvouChip = True And blnSalvouPOS = True Then
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
                    '// 
                    '// VERIFICA SE ID_DESTINO FOI PREENCHIDO, SE SIM, DA BAIXA 
                    '// SENÃO, NÃO FAZ NADA
                    If Len(Trim(row.Cells("ID_DESTINO").Value)) > 0 Then

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
                        sql += row.Cells("ID_DESTINO").Value & ","
                        sql += row.Cells("ID_CHIP").Value & " ,"
                        sql += row.Cells("QTD").Value & " ,"
                        sql += ACE_CODIGO.ToString & " ,"
                        sql += "GETDATE(),"
                        sql += row.Cells("ID_DESTINO").Value & " ,"
                        sql += "GETDATE(), " & row.Cells("ID_EMPRESA").Value & ")"

                        bllGlobal.GravarGenericoBLL(sql)

                        'Operação de insert continuo
                    End If

                End If

            Next
            'MessageBox.Show("Gravação Concluída com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            blnSalvouChip = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnSalvouChip = False
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
                    '// 
                    '// VERIFICA SE ID_DESTINO FOI PREENCHIDO, SE SIM, DA BAIXA 
                    '// SENÃO, NÃO FAZ NADA
                    If Len(Trim(row.Cells("ID_DESTINO").Value)) > 0 Then
                        sql = "INSERT INTO [dbo].[CG_MOV_TRANSITO_EQUIPAMENTO] "
                        sql += "([ID_TRANSITO]"
                        sql += ",[ID_ORIGEM]"
                        sql += ",[ID_EQUIPAMENTO]"
                        sql += ",[QUANTIDADE]"
                        sql += ",[USER_INS]"
                        sql += ",[DATA_LANCTO]"
                        sql += ",[ID_DESTINO]"
                        sql += ",[DATA_MOV_DESTINO] "
                        sql += ",[ID_EMPRESA] "
                        sql += ",[PEDIDO_VENDA])"
                        sql += " VALUES(" & PesqFKTransito.txtId.Text & ","
                        sql += row.Cells("ID_DESTINO").Value & ","
                        sql += row.Cells("ID_EQUIPAMENTO").Value & " ,"
                        sql += row.Cells("QTD").Value & " ,"
                        sql += ACE_CODIGO.ToString & " ,"
                        sql += "GETDATE(),"
                        sql += row.Cells("ID_DESTINO").Value & " ,"
                        sql += "GETDATE(), "
                        sql += row.Cells("ID_EMPRESA").Value
                        sql += ", " & IIf(CBool(row.Cells("PEDIDO_VENDA").Value) = True, "1", "0") & ")"

                        bllGlobal.GravarGenericoBLL(sql)

                        'Operação de insert continuo
                    End If

                End If

            Next
            'MessageBox.Show("Gravação Concluída com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            blnSalvouPOS = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnSalvouPOS = False
            'Finally
            '    Me.Close()
        End Try
    End Sub
    Public Sub Carregar_Chip()
        Dim sql As String

        sql = "select ID_CHIP,SIMID,ID_OPERADORA,DESC_OPERADORA, 1 AS QTD, "
        sql += " CUSTO AS VALOR, ID_LOCAL_ESTOQUE AS ID_TRANSITO, TIPO_LOCAL, ID_EMPRESA, "
        sql += " SPACE(10) as ID_DESTINO "
        sql += " from VW_CG_CHIP "

        Me.Comando = sql
        Me.ColunaFiltro = "ID_ROMANEIO"
        Me.Filtro = " WHERE TIPO_LOCAL = 'T' AND ID_LOCAL_ESTOQUE = " & PesqFKTransito.txtId.Text

        'Declara as variáveis do Tipo Coluna
        Dim colId_Chip As DataGridViewTextBoxColumn
        Dim colSimId As DataGridViewTextBoxColumn
        Dim colId_Operadora As DataGridViewTextBoxColumn
        Dim colDescOperadora As DataGridViewTextBoxColumn
        Dim colQtd As DataGridViewTextBoxColumn
        Dim colValor As DataGridViewTextBoxColumn
        Dim colEmpresaOrigem As DataGridViewTextBoxColumn
        Dim colDestino As DataGridViewTextBoxColumn

        '*******>> Configura as colunas

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

        'coluna Empresa Origem
        colEmpresaOrigem = New DataGridViewTextBoxColumn
        colEmpresaOrigem.HeaderText = "Empresa Origem"
        colEmpresaOrigem.Name = "ID_EMPRESA"

        'coluna id destino
        colDestino = New DataGridViewTextBoxColumn
        colDestino.HeaderText = "ID Destino"
        colDestino.Name = "ID_DESTINO"

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colId_Chip, colSimId, colId_Operadora,
                                                            colDescOperadora, colQtd, colValor, colEmpresaOrigem, colDestino})

        'dgvDados.DataSource = myRow
        Me.TipoEstoque = "C"
        Popula_Grid()

        dgvDados.Columns(0).ReadOnly = True ' coluna do Botão
        For ixx = 1 To 7
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
        dgvDados.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvDados.Columns(0).Visible = False

    End Sub

    Private Sub Popula_Grid()
        'Faz a Query no banco e retorna uma Lista de Array do Comando SQL
        Dim myRow As ArrayList
        myRow = BLL.GlobalBLL.PesquisarFkListaBLL(Me.Comando & Me.Filtro)

        Dim ixx As Integer
        Dim strLinha As String() 'declara um array de Strings que vai armazenar uma linha de registro toda

        If Me.TipoEstoque = "C" Then
            dgvDados.RowHeadersVisible = False
        Else
            dgvDados2.RowHeadersVisible = False
        End If
        For ixx = 0 To myRow.Count - 1

            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid
            If Me.TipoEstoque = "C" Then

                strLinha = {myRow(ixx)("id_chip").ToString,
                            myRow(ixx)("simid").ToString,
                            myRow(ixx)("id_operadora").ToString,
                            myRow(ixx)("desc_operadora").ToString,
                            myRow(ixx)("qtd").ToString,
                            myRow(ixx)("valor").ToString,
                            myRow(ixx)("id_empresa").ToString,
                            myRow(ixx)("id_destino").ToString}
            Else
                strLinha = {myRow(ixx)("id_equipamento").ToString,
                            myRow(ixx)("serie").ToString,
                            myRow(ixx)("desc_equipamento").ToString,
                            myRow(ixx)("modelo").ToString,
                            myRow(ixx)("qtd").ToString,
                            myRow(ixx)("valor").ToString,
                            myRow(ixx)("id_empresa").ToString,
                            myRow(ixx)("id_destino").ToString,
                            myRow(ixx)("pedido_venda")}

            End If
            If Me.TipoEstoque = "C" Then
                dgvDados.Rows.Add(strLinha)
            Else
                dgvDados2.Rows.Add(strLinha)
            End If

        Next
        If Me.TipoEstoque = "C" Then
            dgvDados.RowHeadersVisible = True
        Else
            dgvDados2.RowHeadersVisible = True
        End If

    End Sub

    Private Sub btnExclui_Click(sender As Object, e As EventArgs)
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

    Public Sub Carregar_POS()
        Dim sql As String

        sql = "select a.ID_EQUIPAMENTO,a.SERIE,a.DESC_EQUIPAMENTO,MODELO,"
        sql += "1 AS QTD, a.VALOR , a.ID_LOCAL_ESTOQUE AS ID_TRANSITO, a.TIPO_LOCAL, a.ID_EMPRESA, "
        sql += " SPACE(10) as ID_DESTINO, B.PEDIDO_VENDA "
        sql += " from VW_CG_EQUIPAMENTO A "
        sql += " INNER Join CG_ESTOQUE_EQUIPAMENTO B ON B.ID_EQUIPAMENTO = A.ID_EQUIPAMENTO "


        Me.Comando = sql
        Me.ColunaFiltro = "ID_ROMANEIO"
        Me.Filtro = " WHERE a.TIPO_LOCAL = 'T' AND a.ID_LOCAL_ESTOQUE = " & PesqFKTransito.txtId.Text

        'Declara as variáveis do Tipo Coluna
        Dim colId_Equipamento As DataGridViewTextBoxColumn
        Dim colSerie As DataGridViewTextBoxColumn
        Dim colDescricao As DataGridViewTextBoxColumn
        Dim colModelo As DataGridViewTextBoxColumn
        Dim colQtd As DataGridViewTextBoxColumn
        Dim colValor As DataGridViewTextBoxColumn
        Dim colEmpresaOrigem As DataGridViewTextBoxColumn
        Dim colDestino As DataGridViewTextBoxColumn
        Dim colPedidoVenda As DataGridViewCheckBoxColumn

        '*******>> Configura as colunas

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

        'coluna Empresa Origem
        colEmpresaOrigem = New DataGridViewTextBoxColumn
        colEmpresaOrigem.HeaderText = "Empresa Origem"
        colEmpresaOrigem.Name = "ID_EMPRESA"

        'coluna id destino
        colDestino = New DataGridViewTextBoxColumn
        colDestino.HeaderText = "ID Destino"
        colDestino.Name = "ID_DESTINO"

        colPedidoVenda = New DataGridViewCheckBoxColumn
        colPedidoVenda.HeaderText = "Pedido Venda"
        colPedidoVenda.Name = "pedido_venda"

        'Reset no Grid
        dgvDados2.DataSource = Nothing
        dgvDados2.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados2.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados2.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados2.Columns.AddRange(New DataGridViewColumn() {colId_Equipamento, colSerie, colDescricao,
                                                            colModelo, colQtd, colValor, colEmpresaOrigem, colDestino, colPedidoVenda})

        'dgvDados.DataSource = myRow
        Me.TipoEstoque = "E"
        Popula_Grid()

        dgvDados2.Columns(0).ReadOnly = True ' coluna do Botão
        For ixx = 1 To 7
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
        dgvDados2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvDados2.Columns(0).Visible = False
        dgvDados2.Columns(4).Width = 60

    End Sub

    Private Sub AtualizaPanelLoja()
        Dim _idLoja As String = dgvDados.CurrentRow.Cells("id_destino").Value
        Try
            If Len(Trim(_idLoja)) = 0 Then
                _idLoja = "-1"
            End If
            Dim bllGlobal As New BLL.GlobalBLL
            Dim sql As String = "SELECT CODIGO,ID_LOJA,NOME " & _
                                "FROM CG_LOJA  WHERE ID_LOJA = " & _idLoja
            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)

            If dt.Rows.Count > 0 Then

                PesqFKLojaDestino.txtId.Text = dt(0)("ID_LOJA")
                PesqFKLojaDestino.txtDesc.Text = dt(0)("CODIGO") & " - " & dt(0)("NOME")
            Else
                PesqFKLojaDestino.txtId.Text = ""
                PesqFKLojaDestino.txtDesc.Text = ""

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub AtualizaPanelLoja2()
        Dim _idLoja As String = dgvDados2.CurrentRow.Cells("id_destino").Value
        Try
            'Define se vai trazer todas as lojas ou somente a loja ESTOQUE NO CLIENTE
            strFiltroLoja = IIf(CBool(dgvDados2.CurrentRow.Cells("pedido_venda").Value) = True, "in (1,10)", " = ID_LOJA")
            Me.PesqFKLojaDestinoPOS.FiltroSQL = " where id_empresa = " & Publico.Id_empresa & " and id_loja " & strFiltroLoja

            If Len(Trim(_idLoja)) = 0 Then
                _idLoja = "-1"
            End If
            Dim bllGlobal As New BLL.GlobalBLL
            Dim sql As String = "SELECT CODIGO,ID_LOJA,NOME " &
                                "FROM CG_LOJA  WHERE ID_LOJA = " & _idLoja
            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)

            If dt.Rows.Count > 0 Then

                PesqFKLojaDestinoPOS.txtId.Text = dt(0)("ID_LOJA")
                PesqFKLojaDestinoPOS.txtDesc.Text = dt(0)("CODIGO") & " - " & dt(0)("NOME")
            Else
                PesqFKLojaDestinoPOS.txtId.Text = ""
                PesqFKLojaDestinoPOS.txtDesc.Text = ""

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgvDados_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellEnter
        AtualizaPanelLoja()
    End Sub

    'Private Sub dgvDados_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDados.CellFormatting
    '    Try
    '        If dgvDados.RowCount > 0 Then
    '            If Not String.IsNullOrWhiteSpace(dgvDados.CurrentRow.Cells("id_destino").Value) Then
    '                'Or Len(Trim(dgvDados.CurrentRow.Cells("id_destino").Value)) > 0 Then
    '                dgvDados.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow
    '            End If
    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub

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
            '.FiltroSQL = " where (inativo = 0) AND id_empresa = " & Publico.Id_empresa
            .FiltroSQL = " where (inativo = 0) "
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


    Private Sub PesqFKLojaDestino_Load(sender As Object, e As EventArgs) Handles PesqFKLojaDestino.Load
        With Me.PesqFKLojaDestino
            .LabelPesqFK = "Loja Destino"
            .Tabela = "VW_CG_LOJA"
            .View = "VW_CG_LOJA"
            .CampoId = "ID_LOJA"
            .CampoDesc = "NOME"
            .ListaCampos = "CODIGO, ID_LOJA, NOME, SIGLA"
            .ColunasFiltro = "CODIGO,NOME,SIGLA,ID_LOJA"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Lojas"
            .FiltroSQL = " where id_empresa = " & Publico.Id_empresa
            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = True

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 19
            .txtId.Width -= 5
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 20
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With
    End Sub

    Private Sub getLojaDestinoChip(ByRef dgvDados As DataGridView)
        Me.PesqFKLojaDestino.PosValida = False
        Me.PesqFKLojaDestino.btnPesq.PerformClick()
        If PesqFKLojaDestino.Clicou > 0 Then
            Dim _codigo As String
            _codigo = PesqFKLojaDestino.CodigoSelecionado
            dgvDados.CurrentRow.Cells("id_destino").Value = _codigo
            AtualizaPanelLoja()
            PesqFKLojaDestino.Clicou = 0
            Me.PesqFKLojaDestino.PosValida = True
            dgvDados.Focus()
        End If

    End Sub
    Private Sub getLojaDestinoPOS(ByRef dgvDados2 As DataGridView)
        Me.PesqFKLojaDestinoPOS.PosValida = False
        Me.PesqFKLojaDestinoPOS.btnPesq.PerformClick()
        If PesqFKLojaDestinoPOS.Clicou > 0 Then
            Dim _codigo As String
            _codigo = PesqFKLojaDestinoPOS.CodigoSelecionado
            dgvDados2.CurrentRow.Cells("id_destino").Value = _codigo
            AtualizaPanelLoja2()
            PesqFKLojaDestinoPOS.Clicou = 0
            Me.PesqFKLojaDestinoPOS.PosValida = True
            dgvDados2.Focus()
        End If

    End Sub
    Private Sub PesqFKLojaDestino_Leave(sender As Object, e As EventArgs) Handles PesqFKLojaDestino.Leave
        If PesqFKLojaDestino.PosValida = True And PesqFKLojaDestino.Clicou > 0 Then
            dgvDados.CurrentRow.Cells("id_destino").Value = PesqFKLojaDestino.txtId.Text
            AtualizaPanelLoja()
            PesqFKLojaDestino.Clicou = 0
            dgvDados.Focus()
        End If
    End Sub

    Private Sub PesqFKLojaDestinoPOS_Load(sender As Object, e As EventArgs) Handles PesqFKLojaDestinoPOS.Load
        With Me.PesqFKLojaDestinoPOS
            .LabelPesqFK = "Loja Destino"
            .Tabela = "VW_CG_LOJA"
            .View = "VW_CG_LOJA"
            .CampoId = "ID_LOJA"
            .CampoDesc = "NOME"
            .ListaCampos = "CODIGO, ID_LOJA, NOME, SIGLA"
            .ColunasFiltro = "CODIGO,NOME,SIGLA,ID_LOJA"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Lojas"
            .FiltroSQL = " where id_empresa = " & Publico.Id_empresa & " and id_loja " & strFiltroLoja
            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = True

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 19
            .txtId.Width -= 5
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 20
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With
    End Sub
    Private Sub PesqFKLojaDestinoPOS_Leave(sender As Object, e As EventArgs) Handles PesqFKLojaDestinoPOS.Leave
        If PesqFKLojaDestinoPOS.PosValida = True And PesqFKLojaDestinoPOS.Clicou > 0 Then
            dgvDados2.CurrentRow.Cells("id_destino").Value = PesqFKLojaDestinoPOS.txtId.Text
            AtualizaPanelLoja2()
            PesqFKLojaDestinoPOS.Clicou = 0
            dgvDados2.Focus()
        End If
    End Sub

    Private Sub dgvDados2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados2.CellEnter
        AtualizaPanelLoja2()
    End Sub

    'Private Sub dgvDados2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDados2.CellFormatting
    '    Try
    '        If dgvDados2.RowCount > 0 Then
    '            If Not String.IsNullOrWhiteSpace(dgvDados2.CurrentRow.Cells("id_destino").Value) Then
    '                'Or Len(Trim(dgvDados.CurrentRow.Cells("id_destino").Value)) > 0 Then
    '                dgvDados2.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow
    '            End If
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub dgvDados_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDados.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Left And e.ColumnIndex = 7 Then
            'MessageBox.Show(e.ColumnIndex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'Se nao conseguir pegar o numero da linha corrente, cai fora e nao executa 
            Try
                Dim _rowindex As Integer
                Dim blnChamar As Boolean = True
                _rowindex = dgvDados.CurrentRow.Index

                PesqFKLojaDestino.FiltroSQL = IIf(TransitoInterno() = True,
                                              " WHERE ID_EMPRESA = " & dgvDados.CurrentRow.Cells("id_empresa").Value & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,7,8,9,10) ",
                                              " WHERE ID_EMPRESA = " & dgvDados.CurrentRow.Cells("id_empresa").Value & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,10) ")

                If Not String.IsNullOrWhiteSpace(dgvDados.CurrentRow.Cells("id_destino").Value.ToString) Then

                    If MessageBox.Show("Deseja substituir a Loja Destino?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        blnChamar = False
                    End If

                End If
                If blnChamar = True Then
                    getLojaDestinoChip(dgvDados)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub dgvDados2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDados2.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Left And e.ColumnIndex = 7 Then
            'MessageBox.Show(e.ColumnIndex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'Se nao conseguir pegar o numero da linha corrente, cai fora e nao executa
            Try
                Dim _rowindex As Integer
                Dim blnChamar As Boolean = True
                _rowindex = dgvDados2.CurrentRow.Index


                'strFiltroLoja = IIf(CBool(dgvDados2.CurrentRow.Cells("pedido_venda").Value) = True, "10", "ID_LOJA")
                strFiltroLoja = IIf(CBool(dgvDados2.CurrentRow.Cells("pedido_venda").Value) = True, "in (1,10)", " = ID_LOJA")


                If strFiltroLoja = "in (1,10)" Then
                    Me.PesqFKLojaDestinoPOS.FiltroSQL = " where id_empresa = " & Publico.Id_empresa & " and id_loja  " & strFiltroLoja

                Else
                    PesqFKLojaDestinoPOS.FiltroSQL = IIf(TransitoInterno() = True,
                                                  " WHERE ID_EMPRESA = " & dgvDados2.CurrentRow.Cells("id_empresa").Value & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,7,8,9,10) ",
                                                  " WHERE ID_EMPRESA = " & dgvDados2.CurrentRow.Cells("id_empresa").Value & " AND ID_TIPO_LOCAL_ESTOQUE IN (1,10) ")
                End If

                If Not String.IsNullOrWhiteSpace(dgvDados2.CurrentRow.Cells("id_destino").Value.ToString) Then

                    If MessageBox.Show("Deseja substituir a Loja Destino?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        blnChamar = False
                    End If

                End If
                If blnChamar = True Then
                    getLojaDestinoPOS(dgvDados2)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class