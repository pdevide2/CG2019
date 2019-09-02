Imports System.IO

Public Class PedidoVenda

    Private imagemAUsar As Image
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
        Me.PkString = False
        Me.Tabela = "CG_PedidoVenda" 'Nome da tabela no SQL
        Me.Modulo = 75 'codigo do módulo 
        LoginCG() 'retorna o id do usuário
        Me.View = "VW_CG_PedidoVenda"
        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_pedidovenda
        Me.ColunaId = "ID_PEDIDO"
        CarregaGrid()
        Habilita_Controles(False) 'modo leitura
    End Sub
    Public Overrides Sub Pesquisar()
        MyBase.Pesquisar()
        'MessageBox.Show(Me.KeyId.ToString, "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Carrega_Controles_Pesquisa()
    End Sub

    Public Overrides Sub Carrega_Controles_Pesquisa()
        MyBase.Carrega_Controles_Pesquisa()
        If Me.KeyId <> -1 Then

            txtCodigo.Text = Me.KeyId.ToString
            PesqFKCliente.txtId.Text = Me.LinhaGrid.Cells("id_cliente").Value.ToString
            PesqFKCliente.txtDesc.Text = Me.LinhaGrid.Cells("nome").Value.ToString
            txtStatus.Text = Me.LinhaGrid.Cells("status_pedido").Value.ToString
            txtData.Text = Me.LinhaGrid.Cells("data").Value.ToString
            txtPrevisaoEntrega.Text = Me.LinhaGrid.Cells("previsao_entrega").Value.ToString
            txtDataBaixa.Text = Me.LinhaGrid.Cells("data_baixa").Value.ToString
            txtUltimaAlteracao.Text = Me.LinhaGrid.Cells("ultima_alteracao").Value.ToString
            txtQtdePedida.Text = Me.LinhaGrid.Cells("tot_qtde_original").Value.ToString
            txtQtdeEntregue.Text = Me.LinhaGrid.Cells("tot_qtde_entregar").Value.ToString

            CarregaGrid()

            If TabControl1.SelectedIndex = 1 Then
                'CarregarImagem()
            End If

        End If
    End Sub
    Public Overrides Function ValidaCampos() As Object
        Dim blnRet As Boolean
        Dim msgErro As String = ""
        blnRet = MyBase.ValidaCampos()

        If blnRet Then
            'Se os dois grids estiverem sem dados, solicitar entrada de dados
            If dgvDados.RowCount = 0 Then
                msgErro += "Obrigatório informar itens no Pedido de Venda!" & Chr(13)
                blnRet = False
            End If
        End If

        'Verifica itens
        Dim precoVenda As Double
        For Each row As DataGridViewRow In dgvDados.Rows

            If Not row.IsNewRow Then
                If Convert.ToBoolean(row.Cells("CANCEL").Value) = False Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    precoVenda = Convert.ToDouble(Replace(row.Cells("preco_venda").Value, ".", ","))
                    If precoVenda = 0 Then
                        msgErro += "Preco de Venda não informado!" & Chr(13) & "Gravação não Permitida!"
                        blnRet = False
                        Exit For
                    End If
                    'Operação de delete/insert/update

                End If
            End If

        Next

        If Len(msgErro) > 0 Then
            MessageBox.Show(msgErro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return blnRet

    End Function

    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)
        'Grava somente os itens com Status = 1
        If Not ValidaCampos() Then
            Exit Sub
        End If

        Dim bll As New BLL.PedidovendaBLL
        Dim objPedidoVenda As New DTO.Cg_pedidovenda

        Dim bllFilha As New BLL.Pedidovenda_itensBLL
        Dim objPedidoVendaItem As New DTO.Cg_pedidovenda_itens

        Dim llErro As Boolean = True
        Dim intStatus_Item As Integer = 1

        Try

            objPedidoVenda.Data_baixa = Nothing
            objPedidoVenda.Id_cliente = CInt(PesqFKCliente.txtId.Text)
            objPedidoVenda.Id_pedido = CInt(txtCodigo.Text)
            objPedidoVenda.Previsao_entrega = CDate(txtPrevisaoEntrega.Text)
            objPedidoVenda.Status_pedido = txtStatus.Text

            If String.IsNullOrEmpty(txtQtdePedida.Text) Then
                objPedidoVenda.Tot_qtde_entregar = 0
                objPedidoVenda.Tot_qtde_original = 0
            Else
                objPedidoVenda.Tot_qtde_entregar = CInt(txtQtdeEntregue.Text)
                objPedidoVenda.Tot_qtde_original = CInt(txtQtdePedida.Text)
            End If


            bll.GravarBLL(acao, objPedidoVenda)

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    If String.IsNullOrEmpty(row.Cells("STATUS_ITEM").Value) Then
                        intStatus_Item = 1
                    Else
                        intStatus_Item = CInt(row.Cells("STATUS_ITEM").Value)
                    End If
                    'Carrega os dados no objeto Model para passagem de parametro
                    objPedidoVendaItem.Id_pedido = CInt(txtCodigo.Text)
                    objPedidoVendaItem.Id_equipamento = CInt(row.Cells("id_equipamento").Value)
                    objPedidoVendaItem.Qtde = 1
                    objPedidoVendaItem.Preco_venda = Convert.ToDouble(Replace(row.Cells("preco_venda").Value, ".", ","))
                    objPedidoVendaItem.Status_item = intStatus_Item  '1
                    objPedidoVendaItem.Data_baixa = Nothing
                    objPedidoVendaItem.Cancel = CBool(row.Cells("cancel").Value)
                    'Operação de delete/insert/update
                    bllFilha.GravarBLL(Operacao.Novo, objPedidoVendaItem)

                End If

            Next


            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta
            llErro = False
        Catch ex As SqlClient.SqlException
            llErro = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            llErro = True
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(llErro) 'modo leitura

        End Try

    End Sub
    Public Overrides Sub Alterar()
        If Not String.IsNullOrEmpty(txtDataBaixa.Text) Then
            MessageBox.Show("Alteração não permitida, Pedido já baixado totalmente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        MyBase.Alterar()
        Habilita_Controles(True) 'modo digitação
        CarregaGrid()
    End Sub
    Public Overrides Sub Incluir()
        MyBase.Incluir()
        Dim bll As New BLL.GlobalBLL
        Me.KeyId = bll.NovaChaveBLL(Me.Tabela)
        'Dim strId_Controle As String
        If Me.KeyId > 0 Then
            txtCodigo.Text = Me.KeyId.ToString()

            'strId_Controle = "0000" & Trim(txtCodigo.Text)
            'implementando função right() - cria codigo de 5 posições com zeros a esquerda
            txtStatus.Text = "EM ABERTO" '& strId_Controle.Substring(strId_Controle.Length - 4, 4)
            txtData.Text = ShortDate()
            txtUltimaAlteracao.Text = Hoje()
            txtPrevisaoEntrega.Text = SomaData("D", 1, ShortDate())
            Habilita_Controles(True) 'modo digitação
            CarregaGrid()

        Else
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.PedidovendaBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao) 'Executa o método default da classe pai

        PesqFKCliente.btnPesq.Enabled = False

        TabControl1.TabPages(0).Enabled = False
        TabControl1.TabPages(1).Enabled = True
        TabControl1.TabPages(2).Enabled = False



        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            PesqFKCliente.btnPesq.Enabled = True

            TabControl1.TabPages(0).Enabled = True
            TabControl1.TabPages(1).Enabled = True
            TabControl1.TabPages(2).Enabled = True

        End If

    End Sub


    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        If Acao = Operacao.Consulta Then
            'btnAddImage.Enabled = IIf(Not String.IsNullOrEmpty(txtCodigo.Text), True, False)
        Else
            'btnAddImage.Enabled = False
        End If
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        'Dim messageBoxVB As New System.Text.StringBuilder()
        'messageBoxVB.AppendFormat("{0} = {1}", "TabPage", e.TabPage)
        'messageBoxVB.AppendLine()
        'messageBoxVB.AppendFormat("{0} = {1}", "TabPageIndex", e.TabPageIndex)
        'messageBoxVB.AppendLine()
        'messageBoxVB.AppendFormat("{0} = {1}", "Action", e.Action)
        'messageBoxVB.AppendLine()
        'MessageBox.Show(messageBoxVB.ToString(), "Selected Event")
        If flagAcao = Operacao.Consulta And e.TabPageIndex = 1 Then
            'btnAddImage.Enabled = IIf(Not String.IsNullOrEmpty(txtCodigo.Text), True, False)
        Else
            'btnAddImage.Enabled = False
        End If
    End Sub



    Private Sub PesqFKFornecedor_Load(sender As Object, e As EventArgs) Handles PesqFKCliente.Load
        With Me.PesqFKCliente
            .LabelPesqFK = "Cliente"
            .Tabela = "CG_CLIENTE"
            .View = "CG_CLIENTE"
            .CampoId = "ID_CLIENTE"
            .CampoDesc = "NOME"
            .ListaCampos = "ID_CLIENTE, NOME, SIGLA"
            .ColunasFiltro = "NOME,SIGLA,ID_CLIENTE"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Clientes"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 26
            .txtId.Width -= 0
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 162
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 2

        End With
    End Sub

    Public Sub CarregaGrid()
        Dim sql As String

        sql = "SELECT '...' as botao, ID_PEDIDO, ID_EQUIPAMENTO, MODELO, SERIE, QTDE, PRECO_VENDA, STATUS_ITEM, "
        sql += "DATA_CADASTRO, DATA_BAIXA, ULTIMA_ALTERACAO, CANCEL "
        sql += " From VW_CG_PEDIDOVENDA_ITENS "
        Me.Comando = sql
        Me.ColunaFiltro = "ID_PEDIDO"
        Me.Filtro = " WHERE " & Me.ColunaFiltro & " = '" & txtCodigo.Text.ToString & "'"

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
        dgvDados.Columns(11).ReadOnly = True ' coluna cancel

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

    Private Sub Edita_dados(ByVal _linhaGrid As DataGridViewRow)

        Dim _modoedicao As Integer = flagAcao
        'If cboStatus.Text.Equals("EM PROCESSO") Then
        '    _modoedicao = Operacao.Consulta
        'End If
        If _modoedicao = Operacao.Alterar Then
            If CInt(dgvDados.CurrentRow.Cells("status_item").Value) > 1 Then
                MessageBox.Show("Alteração não permitida para este item!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                _modoedicao = Operacao.Consulta
            End If
        End If
        Dim frm As New WinCG.PedidoVenda_Edicao(_modoedicao, dgvDados, CInt(txtCodigo.Text), _linhaGrid)
        frm.ShowDialog()

    End Sub

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
        If Convert.ToBoolean(dgvDados.CurrentRow.Cells("cancel").Value) = True Then
            Dim msgErro As String
            msgErro = "Este item está marcado para ser excluído e não pode ser editado!"
            MessageBox.Show(msgErro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If e.ColumnIndex = 0 Then
            Edita_dados(dgvDados.CurrentRow)
        End If
        If e.ColumnIndex = 1 Then
            'Chama_Ocorrencia(dgvDados.CurrentRow)
            'ContextMenuStrip3.Show(dgvDados, New Point(e.RowIndex, e.ColumnIndex))
        End If

    End Sub
    ''' <summary>
    ''' Validação para aceitar somente numeros e "/" no controle
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtPrevisaoEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrevisaoEntrega.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumerosData(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' Verifica se a data digitada é valida
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtPrevisaoEntrega_Validated(sender As Object, e As EventArgs) Handles txtPrevisaoEntrega.Validated
        If Not validaData(txtPrevisaoEntrega.Text) Then
            MessageBox.Show("Data com formato inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrevisaoEntrega.Text = ""
        End If
    End Sub

    Private Sub btnAdiciona_Click(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        'Parametros:
        '***********
        'Id do Pedido
        'Grid de Dados
        'Nome da Stored Procedure que seleciona os dados

        Dim frm As New WinCG.frmSelecionaItemPedidoVenda(txtCodigo.Text, dgvDados, "spSelecionaItemPedidoVenda")
        frm.ShowDialog()

    End Sub

    Private Sub btnExclui_Click(sender As Object, e As EventArgs) Handles btnExclui.Click
        If dgvDados.RowCount > 0 Then

            If dgvDados.SelectedRows.Count > 0 AndAlso Not dgvDados.SelectedRows(0).Index = dgvDados.Rows.Count Then
                dgvDados.CurrentRow.Cells("cancel").Value = True
            End If

        End If

    End Sub

    Private Sub dgvDados_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvDados.RowPrePaint
        If Convert.ToBoolean(dgvDados.Rows(e.RowIndex).Cells("CANCEL").Value) = True Then
            For ixx = 0 To dgvDados.ColumnCount - 1
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Red
            Next
        Else
            For ixx = 0 To dgvDados.ColumnCount - 1
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.Black
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.LightGray
            Next

        End If
    End Sub
End Class