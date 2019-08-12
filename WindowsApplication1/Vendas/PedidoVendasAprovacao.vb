Public Class PedidoVendasAprovacao

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

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim rb = DirectCast(sender, RadioButton)

        If rb.Checked Then
            rb.BackColor = Color.Red
        Else
            rb.BackColor = Color.Green
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim rb = DirectCast(sender, RadioButton)

        If rb.Checked Then
            rb.BackColor = Color.Red
        Else
            rb.BackColor = Color.Green
        End If
    End Sub

    Public Sub CarregaGrid()
        Dim sql As String

        sql = "SELECT SIGLA, ID_PEDIDO, DESC_EQUIPAMENTO, SERIE, QTDE, PRECO_VENDA, STATUS_ITEM, "
        sql += "ID_EQUIPAMENTO, DATA_CADASTRO, DATA_BAIXA, ULTIMA_ALTERACAO, CANCEL, ID_CLIENTE, "
        sql += "NOME, ID_TIPO_EQUIPAMENTO, MODELO, DESC_TIPO_EQUIPAMENTO "
        sql += "FROM VW_CG_PEDIDOS_APROVACAO "

        Me.Comando = sql
        Me.ColunaFiltro = "STATUS_ITEM"
        Me.Filtro = " WHERE " & Me.ColunaFiltro & " = " & IIf(rbAnalise.Checked, 1, "STATUS_ITEM")

        'Declara as variáveis do Tipo Coluna
        Dim colBotao As DataGridViewButtonColumn
        Dim colId_Pedido As DataGridViewTextBoxColumn
        Dim colId_Equipamento As DataGridViewTextBoxColumn
        Dim colModelo As DataGridViewTextBoxColumn
        Dim colSerie As DataGridViewTextBoxColumn
        Dim colQtde As DataGridViewTextBoxColumn
        Dim colPreco_Venda As DataGridViewTextBoxColumn
        Dim colStatus_Item As DataGridViewTextBoxColumn
        Dim colData_Cadastro As DataGridViewTextBoxColumn
        Dim colData_Baixa As DataGridViewTextBoxColumn
        Dim colUltima_Alteracao As DataGridViewTextBoxColumn
        Dim colCancel As DataGridViewCheckBoxColumn



        '*******>> Configura as colunas
        'coluna botao
        colBotao = New DataGridViewButtonColumn
        colBotao.HeaderText = "Visualizar/Editar"
        colBotao.Name = "colBotao1"

        colId_Pedido = New DataGridViewTextBoxColumn
        colId_Pedido.HeaderText = "ID_PEDIDO"
        colId_Pedido.Name = "ID_PEDIDO"

        colId_Equipamento = New DataGridViewTextBoxColumn
        colId_Equipamento.HeaderText = "ID_EQUIPAMENTO"
        colId_Equipamento.Name = "ID_EQUIPAMENTO"

        colModelo = New DataGridViewTextBoxColumn
        colModelo.HeaderText = "MODELO"
        colModelo.Name = "MODELO"

        colSerie = New DataGridViewTextBoxColumn
        colSerie.HeaderText = "SERIE"
        colSerie.Name = "SERIE"

        colQtde = New DataGridViewTextBoxColumn
        colQtde.HeaderText = "QTDE"
        colQtde.Name = "QTDE"

        colPreco_Venda = New DataGridViewTextBoxColumn
        colPreco_Venda.HeaderText = "PRECO_VENDA"
        colPreco_Venda.Name = "PRECO_VENDA"

        colStatus_Item = New DataGridViewTextBoxColumn
        colStatus_Item.HeaderText = "STATUS_ITEM"
        colStatus_Item.Name = "STATUS_ITEM"

        colData_Cadastro = New DataGridViewTextBoxColumn
        colData_Cadastro.HeaderText = "DATA_CADASTRO"
        colData_Cadastro.Name = "DATA_CADASTRO"

        colData_Baixa = New DataGridViewTextBoxColumn
        colData_Baixa.HeaderText = "DATA_BAIXA"
        colData_Baixa.Name = "DATA_BAIXA"

        colUltima_Alteracao = New DataGridViewTextBoxColumn
        colUltima_Alteracao.HeaderText = "ULTIMA_ALTERACAO"
        colUltima_Alteracao.Name = "ULTIMA_ALTERACAO"

        colCancel = New DataGridViewCheckBoxColumn
        colCancel.HeaderText = "CANCEL"
        colCancel.Name = "CANCEL"

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colBotao, colId_Pedido, colId_Equipamento, colModelo,
                                                            colSerie, colQtde, colPreco_Venda, colStatus_Item,
                                                            colData_Cadastro, colData_Baixa, colUltima_Alteracao,
                                                            colCancel})

        'dgvDados.DataSource = myRow
        Popula_Grid("E")

        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão
        For ixx = 1 To 10
            dgvDados.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next
        dgvDados.Columns(11).ReadOnly = False ' coluna cancel

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
        dgvDados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvDados.Columns(1).Visible = False
        dgvDados.Columns(2).Visible = False

        Me.dgvDados.DefaultCellStyle.Font = New Font("Tahoma", 10.0F, GraphicsUnit.Pixel)

    End Sub


    Private Sub Popula_Grid(ByVal _tipoEstoque As String)
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
                        myRow(ixx)(8).ToString,
                        myRow(ixx)(9).ToString,
                        myRow(ixx)(10).ToString,
                        myRow(ixx)(11).ToString()}

            If _tipoEstoque = "C" Then
                dgvDados.Rows.Add(strLinha)
            Else
                dgvDados.Rows.Add(strLinha)
            End If


        Next

    End Sub
End Class