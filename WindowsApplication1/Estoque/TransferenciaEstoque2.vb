Public Class TransferenciaEstoque2

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

    Dim listaChips As New List(Of DTO.ListaTransfChip)
    Dim listaEquipamentos As New List(Of DTO.ListaTransfEquipamento)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsNavega.Visible = False
        Me.Height -= 40
        inicio()

    End Sub
    Public Sub Carregar()
        'Carrega os dois grids das tabelas filhas
        CarregarChip()
        CarregarEquipamento()
    End Sub
    Public Sub CarregarChip()
        Dim sql As String

        sql = "select	cast(0 as bit) as SELECAO, "
        sql += " ID_CHIP, SIMID, c.ID_OPERADORA, DESC_OPERADORA, 1 as QTD, CUSTO as VALOR "
        sql += " from cg_chip c "
        sql += " inner join cg_operadora o"
        sql += " on o.ID_OPERADORA = c.ID_OPERADORA"
        sql += " where tipo_local = 'L' "
        sql += " and c.id_empresa = " & Publico.Id_empresa
        sql += " and (ID_LOCAL_ESTOQUE = 0 or"
        sql += " ID_LOCAL_ESTOQUE IN (SELECT ID_LOJA FROM CG_LOJA WHERE ID_TIPO_LOCAL_ESTOQUE = 1)) "

        Me.Comando = sql
        Me.ColunaFiltro = "ID_ROMANEIO"
        Me.Filtro = ""

        Dim dt = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        Dim strFilter = ""
        If Not String.IsNullOrEmpty(txtPesquisaSimid.Text) Then
            If optPesqSimid1.Checked Then
                strFilter = "simid like'" + Trim(txtPesquisaSimid.Text) + "%'"
            End If
            If optPesqSimid2.Checked Then
                strFilter = "simid like'%" + Trim(txtPesquisaSimid.Text) + "%'"
            End If
        End If
        dt.DefaultView.RowFilter = strFilter
        dgvDados.DataSource = dt



        'dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)

        dgvDados.Columns("selecao").HeaderText = "Selecione"
        dgvDados.Columns("id_chip").HeaderText = "Id Chip"
        dgvDados.Columns("simid").HeaderText = "SIMID"
        dgvDados.Columns("id_operadora").HeaderText = "Id Oper."
        dgvDados.Columns("desc_operadora").HeaderText = "Desc. Operadora"
        dgvDados.Columns("qtd").HeaderText = "Qtd."
        dgvDados.Columns("valor").HeaderText = "Valor R$"

        dgvDados.Columns("selecao").Width = 65
        dgvDados.Columns("id_chip").Width = 75
        dgvDados.Columns("simid").Width = 140
        dgvDados.Columns("id_operadora").Width = 110
        dgvDados.Columns("desc_operadora").Width = 185
        dgvDados.Columns("qtd").Width = 65
        dgvDados.Columns("valor").Width = 95


        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão
        For ixx = 1 To 6
            dgvDados.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        'dgvDados.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None 'DataGridViewAutoSizeColumnsMode.AllCells
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

        dgvDados.Columns(1).Visible = False

        Me.dgvDados.DefaultCellStyle.Font = New Font("Tahoma", 10.0F, GraphicsUnit.Pixel)


    End Sub
    Public Sub CarregarEquipamento()
        Dim sql As String


        sql = "select	cast(0 as bit) as SELECAO,"
        sql += " ID_EQUIPAMENTO, SERIE, MODELO, DESC_EQUIPAMENTO,   1 AS QTD, VALOR "
        sql += " from cg_equipamento"
        sql += " where tipo_local = 'L' "
        sql += " and id_empresa = " & Publico.Id_empresa
        sql += " and (ID_LOCAL_ESTOQUE = 0 or"
        sql += " ID_LOCAL_ESTOQUE IN (SELECT ID_LOJA FROM CG_LOJA WHERE ID_TIPO_LOCAL_ESTOQUE = 1)) "

        Me.Comando = sql
        Me.ColunaFiltro = "ID_ROMANEIO"
        Me.Filtro = ""

        Dim dt = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        Dim strFilter = ""
        If Not String.IsNullOrEmpty(txtPesquisaSerie.Text) Then
            If optPesqSerie1.Checked Then
                strFilter = "serie like'" + Trim(txtPesquisaSerie.Text) + "%'"
            End If
            If optPesqSerie2.Checked Then
                strFilter = "serie like'%" + Trim(txtPesquisaSerie.Text) + "%'"
            End If
        End If
        dt.DefaultView.RowFilter = strFilter
        dgvDados2.DataSource = dt

        'dgvDados2.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)

        dgvDados2.Columns("selecao").HeaderText = "Selecione"
        dgvDados2.Columns("id_equipamento").HeaderText = "Id Equip."
        dgvDados2.Columns("serie").HeaderText = "Série"
        dgvDados2.Columns("modelo").HeaderText = "Modelo"
        dgvDados2.Columns("desc_equipamento").HeaderText = "Descrição Equipamento"
        dgvDados2.Columns("qtd").HeaderText = "Qtd."
        dgvDados2.Columns("valor").HeaderText = "Valor R$"


        dgvDados2.Columns("selecao").Width = 65
        dgvDados2.Columns("id_equipamento").Width = 75
        dgvDados2.Columns("serie").Width = 100
        dgvDados2.Columns("modelo").Width = 110
        dgvDados2.Columns("desc_equipamento").Width = 285
        dgvDados2.Columns("qtd").Width = 65
        dgvDados2.Columns("valor").Width = 95

        dgvDados2.Columns(0).ReadOnly = False ' coluna do Botão
        For ixx = 1 To 6
            dgvDados2.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados2.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados2.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        'dgvDados2.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None 'DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados2.MultiSelect = False
        dgvDados2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados2.AllowUserToResizeColumns = False
        dgvDados2.EnableHeadersVisualStyles = False

        'Alinhamento dos dados nas colunas do Grid
        dgvDados2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvDados2.Columns(1).Visible = False

        Me.dgvDados2.DefaultCellStyle.Font = New Font("Tahoma", 10.0F, GraphicsUnit.Pixel)

    End Sub



    Public Overrides Sub inicio()
        'MyBase.inicio()

        Me.PkString = False
        Me.Tabela = "CG_ENTRADA_ESTOQUE" 'Nome da tabela PAI no SQL
        Me.View = "VW_CG_ENTRADA_ESTOQUE" 'Nome da View da Tabela PAI no SQL
        Me.TabelaFilha = "CG_ENTRADA_CHIP_ITEM" ' e tambem a CG_ENTRADA_EQUIPAMENTO_ITEM
        Me.Modulo = 18 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_entrada_estoque
        Me.ColunaId = "ID_ROMANEIO"
        Habilita_Controles(False) 'modo leitura

        'Monta o Grid e configura as colunas 
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
            Try
                txtCodigo.Text = Me.KeyId.ToString
                txtIdLoja.Text = Me.LinhaGrid.Cells("ID_LOJA").Value.ToString
                txtDescLoja.Text = Me.LinhaGrid.Cells("NOME").Value.ToString
                txtDataMovto.Text = Me.LinhaGrid.Cells("DATA_MOVTO").Value.ToString
                Carregar()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Public Overrides Function ValidaCampos() As Object
        Dim blnRet As Boolean
        txtCodigo.Tag = "Código Romaneio"
        txtIdLoja.Tag = "Código da Loja"
        txtDataMovto.Tag = "Data do Movimento"

        blnRet = MyBase.ValidaCampos()

        If blnRet Then
            'Se os dois grids estiverem sem dados, solicitar entrada de dados
            If dgvDados.RowCount = 0 And dgvDados2.RowCount = 0 Then
                MessageBox.Show("Obrigatório informar itens para entrada de chip ou POS.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        Dim bllPai As New BLL.Entrada_EstoqueBLL
        Dim objEntradaEstoque As New DTO.Cg_entrada_estoque

        Dim bllFilha As New BLL.Entrada_chip_itemBLL
        Dim objEntradaChipItem As New DTO.Cg_entrada_chip_item

        Dim bllFilha2 As New BLL.Entrada_equipamento_itemBLL
        Dim objEntradaEquipamentoItem As New DTO.Cg_entrada_equipamento_item


        Try
            objEntradaEstoque.Id_romaneio = CInt(txtCodigo.Text)
            objEntradaEstoque.Data_movto = CDate(txtDataMovto.Text)
            objEntradaEstoque.Id_loja = CInt(txtIdLoja.Text)

            objEntradaEstoque.User_ins = ACE_CODIGO
            objEntradaEstoque.Data_ins = Hoje()
            objEntradaEstoque.User_upd = ACE_CODIGO
            objEntradaEstoque.Data_upd = Hoje()
            objEntradaEstoque.Id_empresa = Publico.Id_empresa

            bllPai.GravarBLL(acao, objEntradaEstoque)

            'Método de Delete => Insert
            'Pesquisa pelos itens já existente e exclui tudo, para incluir os
            'itens que estão ativos no Grid
            Dim strItens As ArrayList, strItens2 As ArrayList
            Dim sqlquery As String, sqlquery2 As String
            sqlquery = "select ID_ROMANEIO, UNIQUE_KEYID, ID_CHIP, SIMID, QTD, VALOR "
            sqlquery += "FROM CG_ENTRADA_CHIP_ITEM WHERE ID_ROMANEIO = " & objEntradaEstoque.Id_romaneio.ToString

            strItens = BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

            sqlquery2 = "select ID_ROMANEIO, UNIQUE_KEYID, ID_EQUIPAMENTO, SERIE, QTD, VALOR "
            sqlquery2 += "FROM CG_ENTRADA_EQUIPAMENTO_ITEM WHERE ID_ROMANEIO = " & objEntradaEstoque.Id_romaneio.ToString

            strItens2 = BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery2)

            'Percorre o array e exclui item a item 
            objEntradaChipItem.Id_romaneio = objEntradaEstoque.Id_romaneio
            Dim intParam1 As Integer, strParam2 As String
            For ixx = 0 To strItens.Count - 1
                intParam1 = strItens(ixx)(0)
                strParam2 = strItens(ixx)(1).ToString
                bllFilha.ExcluirBLL(intParam1, strParam2)
            Next

            'Percorre todo o DataGridView e insere os dados
            'For Each row As DataGridViewRow In dgvDados.Rows

            '    If Not row.IsNewRow Then

            '        'Carrega os dados no objeto Model para passagem de parametro
            '        objEntradaChipItem.Id_chip = CInt(row.Cells(1).Value)
            '        objEntradaChipItem.Simid = row.Cells(2).Value
            '        objEntradaChipItem.Qtd = CInt(row.Cells(5).Value)
            '        objEntradaChipItem.Valor = Convert.ToDouble(Replace(row.Cells(6).Value, ".", ","))
            '        objEntradaChipItem.Id_romaneio = CInt(txtCodigo.Text)
            '        objEntradaChipItem.Unique_keyid = row.Cells(8).Value
            '        objEntradaChipItem.Id_empresa = Publico.Id_empresa


            '        'Operação de delete/insert
            '        bllFilha.GravarBLL(Operacao.Novo, objEntradaChipItem)

            '    End If

            'Next
            For Each item In listaChips


                'Carrega os dados no objeto Model para passagem de parametro
                objEntradaChipItem.Id_chip = item.IdChip 'CInt(row.Cells(1).Value)
                objEntradaChipItem.Simid = item.SIMID 'row.Cells(2).Value
                objEntradaChipItem.Qtd = item.Qtde 'CInt(row.Cells(5).Value)
                objEntradaChipItem.Valor = Convert.ToDouble(Replace(item.Valor, ".", ","))
                objEntradaChipItem.Id_romaneio = CInt(txtCodigo.Text)
                objEntradaChipItem.Unique_keyid = "" 'row.Cells(8).Value
                objEntradaChipItem.Id_empresa = Publico.Id_empresa


                'Operação de delete/insert
                bllFilha.GravarBLL(Operacao.Novo, objEntradaChipItem)


            Next

            'Percorre o array e exclui item a item 
            objEntradaEquipamentoItem.Id_romaneio = objEntradaEstoque.Id_romaneio
            Dim intParametro1 As Integer, strParametro2 As String
            For ixx = 0 To strItens2.Count - 1
                intParametro1 = strItens2(ixx)(0)
                strParametro2 = strItens2(ixx)(1).ToString
                bllFilha2.ExcluirBLL(intParametro1, strParametro2)
            Next

            'Percorre todo o DataGridView e insere os dados
            For Each row As DataGridViewRow In dgvDados2.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    objEntradaEquipamentoItem.Id_equipamento = CInt(row.Cells(1).Value)
                    objEntradaEquipamentoItem.Serie = row.Cells(2).Value
                    objEntradaEquipamentoItem.Qtd = CInt(row.Cells(5).Value)
                    objEntradaEquipamentoItem.Valor = Convert.ToDouble(Replace(row.Cells(6).Value, ".", ","))
                    objEntradaEquipamentoItem.Id_romaneio = CInt(txtCodigo.Text)
                    objEntradaEquipamentoItem.Unique_keyid = row.Cells(8).Value
                    objEntradaEquipamentoItem.Id_empresa = Publico.Id_empresa

                    'Operação de delete/insert
                    bllFilha2.GravarBLL(Operacao.Novo, objEntradaEquipamentoItem)

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
        Me.KeyId = bll.NovaChaveBLL(Me.Tabela)
        If Me.KeyId > 0 Then
            txtCodigo.Text = Me.KeyId.ToString()
            Habilita_Controles(True) 'modo digitação
            Carregar()

            Dim strLoja As ArrayList
            Dim sqlquery As String
            'sqlquery = "SELECT ID_LOJA, NOME FROM CG_LOJA WHERE dbo.CG_LOJA.ID_LOJA = 1"
            sqlquery = "SELECT ID_LOJA, NOME FROM CG_LOJA WHERE ID_TIPO_LOCAL_ESTOQUE=1 and id_empresa = " & Publico.Id_empresa
            strLoja = Global.BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

            txtIdLoja.Text = strLoja(0)(0).ToString
            txtDescLoja.Text = strLoja(0)(1).ToString
        Else
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.Entrada_EstoqueBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub



    Private Sub btnPesqLoja_Click(sender As Object, e As EventArgs) Handles btnPesqLoja.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_LOJA"
        Me.ObjModelFk.CampoId = "ID_LOJA"
        Me.ObjModelFk.CampoDesc = "NOME"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Loja"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc &
                            " From " & Me.ObjModelFk.Tabela
        Me.ObjModelFk.FiltroSQL = " where 1=0 "

        PesquisaFK(Me.ObjModelFk)

        txtIdLoja.Text = Me.ObjModelFk.txtId.ToString
        txtDescLoja.Text = Me.ObjModelFk.txtDesc

    End Sub

    'Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
    '    If e.ColumnIndex = 0 Then
    '        Edita_dados(dgvDados.CurrentRow)
    '    End If
    'End Sub

    'Private Sub Edita_dados(ByVal _linhaGrid As DataGridViewRow)

    '    'Debug.Print(_linhaGrid.Cells("ID_CHIP").Value.ToString)
    '    Dim frm As New WinCG.EntradaChip_Edicao(flagAcao, dgvDados, CInt(txtCodigo.Text), _linhaGrid)
    '    frm.ShowDialog()

    'End Sub
    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao)
        btnPesqLoja.Enabled = False
        btnAdiciona.Enabled = False
        btnExclui.Enabled = False
        btnAdicionaPOS.Enabled = False
        btnExcluiPOS.Enabled = False
        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            btnPesqLoja.Enabled = False 'A loja escolhida nesta tela é sempre 1 (Matriz)
            btnAdiciona.Enabled = True
            btnExclui.Enabled = True
            btnAdicionaPOS.Enabled = True
            btnExcluiPOS.Enabled = True
        End If
    End Sub

    Private Sub btnAdiciona_Click(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        Dim frm As New WinCG.FrmSelecionaEstoqueNaoAlocado(CInt(txtCodigo.Text), CInt(txtIdLoja.Text), dgvDados, "C")
        frm.ShowDialog()
        'Dim frm As New WinCG.EntradaChip_Edicao(flagAcao, dgvDados, CInt(txtCodigo.Text))
        'frm.ShowDialog()

    End Sub

    Private Sub ExcluiLinha(ByVal _tipoEstoque As String)
        If MessageBox.Show("Confirma a exclusão deste registro?", "Aviso",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            'verifica se a linha a ser excluida é valida
            If _tipoEstoque = "C" Then 'Grid de Chip
                If dgvDados.SelectedRows.Count > 0 AndAlso Not dgvDados.SelectedRows(0).Index = dgvDados.Rows.Count Then
                    dgvDados.Rows.RemoveAt(dgvDados.SelectedRows(0).Index)
                End If
            End If

            If _tipoEstoque = "E" Then 'Grid de POS
                If dgvDados2.SelectedRows.Count > 0 AndAlso Not dgvDados2.SelectedRows(0).Index = dgvDados2.Rows.Count Then
                    dgvDados2.Rows.RemoveAt(dgvDados2.SelectedRows(0).Index)
                End If
            End If

        End If

    End Sub

    Private Sub btnExclui_Click(sender As Object, e As EventArgs) Handles btnExclui.Click
        If dgvDados.RowCount > 0 Then
            ExcluiLinha("C")
        End If
    End Sub

    Public Overrides Sub Cancelar(acao As Integer)
        MyBase.Cancelar(acao)
        Carregar()

    End Sub

    Private Sub btnAdicionaPOS_Click(sender As Object, e As EventArgs) Handles btnAdicionaPOS.Click
        Dim frm As New WinCG.FrmSelecionaEstoqueNaoAlocado(CInt(txtCodigo.Text), CInt(txtIdLoja.Text), dgvDados2, "E")
        frm.ShowDialog()
    End Sub

    Private Sub btnExcluiPOS_Click(sender As Object, e As EventArgs) Handles btnExcluiPOS.Click
        If dgvDados2.RowCount > 0 Then
            ExcluiLinha("E")
        End If
    End Sub

    'Private Sub dgvDados2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados2.CellClick
    '    If e.ColumnIndex = 0 Then
    '        Edita_dados_POS(dgvDados2.CurrentRow)
    '    End If
    'End Sub
    'Private Sub Edita_dados_POS(ByVal _linhaGrid As DataGridViewRow)

    '    'Debug.Print(_linhaGrid.Cells("ID_CHIP").Value.ToString)
    '    Dim frm As New WinCG.EntradaEquipamento_Edicao(flagAcao, dgvDados2, CInt(txtCodigo.Text), _linhaGrid)
    '    frm.ShowDialog()

    'End Sub

    Private Sub btnProcurarSimid_Click(sender As Object, e As EventArgs) Handles btnProcurarSimid.Click
        'Dim texto As String = Nothing
        'Dim intEscolha As Integer = IIf(optPesqSimid1.Checked = True, 0, 1)

        'If txtPesquisaSimid.Text <> String.Empty Then
        '    'Percorre todas as linhas do Grid e compara o conteudo do textbox de Pesquisa
        '    'com o conteudo da coluna SIMID do grid. Se a condição for satisfeita seleciona a linha e sai da rotina
        '    For Each linha As DataGridViewRow In dgvDados.Rows
        '        texto = linha.Cells(2).Value 'Pesquisa na coluna de SIMID
        '        If PesquisaString(texto.ToLower, txtPesquisaSimid.Text.ToLower, intEscolha) Then
        '            linha.Selected = True
        '            Dim linhaAtual = dgvDados.CurrentRow.Index
        '            dgvDados.CurrentCell = dgvDados.Rows(linhaAtual).Cells(0)
        '            dgvDados.Focus()
        '            Exit Sub
        '        End If
        '    Next
        'End If
        CarregarChip()
    End Sub

    Private Sub btnProcurarSerie_Click(sender As Object, e As EventArgs) Handles btnProcurarSerie.Click
        'Dim texto As String = Nothing
        'Dim intEscolha As Integer = IIf(optPesqSerie1.Checked = True, 0, 1)

        'If txtPesquisaSerie.Text <> String.Empty Then
        '    'Percorre todas as linhas do Grid e compara o conteudo do textbox de Pesquisa
        '    'com o conteudo da coluna SIMID do grid. Se a condição for satisfeita seleciona a linha e sai da rotina
        '    For Each linha As DataGridViewRow In dgvDados2.Rows
        '        texto = linha.Cells(2).Value 'Pesquisa na coluna de SIMID
        '        If PesquisaString(texto.ToLower, txtPesquisaSerie.Text.ToLower, intEscolha) Then
        '            linha.Selected = True
        '            Dim linhaAtual = dgvDados2.CurrentRow.Index
        '            dgvDados2.CurrentCell = dgvDados2.Rows(linhaAtual).Cells(0)
        '            dgvDados2.Focus()
        '            Exit Sub
        '        End If
        '    Next
        'End If
        CarregarEquipamento()
    End Sub

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click
        TransferirEstoqueLista()
    End Sub
    Private Sub TransferirEstoqueLista()
        If Not ValidaDados() Then
            Exit Sub
        End If

        Dim bllGlobal As New BLL.GlobalBLL
        Me.KeyId = bllGlobal.NovaChaveBLL(Me.Tabela)
        If Me.KeyId > 0 Then
            txtCodigo.Text = Me.KeyId.ToString() 'Chave do Romaneio
        End If

        Dim bllPai As New BLL.Entrada_EstoqueBLL
        Dim objEntradaEstoque As New DTO.Cg_entrada_estoque

        Dim bllFilha As New BLL.Entrada_chip_itemBLL
        Dim objEntradaChipItem As New DTO.Cg_entrada_chip_item

        Dim bllFilha2 As New BLL.Entrada_equipamento_itemBLL
        Dim objEntradaEquipamentoItem As New DTO.Cg_entrada_equipamento_item

        Try
            objEntradaEstoque.Id_romaneio = CInt(txtCodigo.Text)
            objEntradaEstoque.Data_movto = ShortDate() 'CDate(txtDataMovto.Text)
            objEntradaEstoque.Id_loja = CInt(getCodigoMatriz())

            objEntradaEstoque.User_ins = ACE_CODIGO
            objEntradaEstoque.Data_ins = Hoje()
            objEntradaEstoque.User_upd = ACE_CODIGO
            objEntradaEstoque.Data_upd = Hoje()
            objEntradaEstoque.Id_empresa = CInt(PesqFKEmpresaDestino.txtId.Text)


            bllPai.GravarBLL(Operacao.Novo, objEntradaEstoque)

            'Método de Delete => Insert
            'Pesquisa pelos itens já existente e exclui tudo, para incluir os
            'itens que estão ativos no Grid
            Dim strItens As ArrayList, strItens2 As ArrayList
            Dim sqlquery As String, sqlquery2 As String
            sqlquery = "select ID_ROMANEIO, UNIQUE_KEYID, ID_CHIP, SIMID, QTD, VALOR "
            sqlquery += "FROM CG_ENTRADA_CHIP_ITEM WHERE ID_ROMANEIO = " & objEntradaEstoque.Id_romaneio.ToString

            strItens = BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

            sqlquery2 = "select ID_ROMANEIO, UNIQUE_KEYID, ID_EQUIPAMENTO, SERIE, QTD, VALOR "
            sqlquery2 += "FROM CG_ENTRADA_EQUIPAMENTO_ITEM WHERE ID_ROMANEIO = " & objEntradaEstoque.Id_romaneio.ToString

            strItens2 = BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery2)

            'Percorre o array e exclui item a item 
            objEntradaChipItem.Id_romaneio = objEntradaEstoque.Id_romaneio
            Dim intParam1 As Integer, strParam2 As String
            For ixx = 0 To strItens.Count - 1
                intParam1 = strItens(ixx)(0)
                strParam2 = strItens(ixx)(1).ToString
                bllFilha.ExcluirBLL(intParam1, strParam2)
            Next

            For Each item In listaChips


                'Carrega os dados no objeto Model para passagem de parametro
                objEntradaChipItem.Id_chip = item.IdChip 'CInt(row.Cells(1).Value)
                objEntradaChipItem.Simid = item.SIMID 'row.Cells(2).Value
                objEntradaChipItem.Qtd = item.Qtde 'CInt(row.Cells(5).Value)
                objEntradaChipItem.Valor = Convert.ToDouble(Replace(item.Valor, ".", ","))
                objEntradaChipItem.Id_romaneio = CInt(txtCodigo.Text)
                objEntradaChipItem.Unique_keyid = NovoKeyId() 'row.Cells(8).Value
                objEntradaChipItem.Id_empresa = objEntradaEstoque.Id_empresa


                'Operação de delete/insert
                bllFilha.GravarBLL(Operacao.Novo, objEntradaChipItem, True)


            Next

            'Percorre o array e exclui item a item 
            objEntradaEquipamentoItem.Id_romaneio = objEntradaEstoque.Id_romaneio
            Dim intParametro1 As Integer, strParametro2 As String
            For ixx = 0 To strItens2.Count - 1
                intParametro1 = strItens2(ixx)(0)
                strParametro2 = strItens2(ixx)(1).ToString
                bllFilha2.ExcluirBLL(intParametro1, strParametro2)
            Next

            For Each item In listaEquipamentos

                'Carrega os dados no objeto Model para passagem de parametro
                objEntradaEquipamentoItem.Id_equipamento = CInt(item.IdEquipamento)
                objEntradaEquipamentoItem.Serie = item.Serie
                objEntradaEquipamentoItem.Qtd = CInt(item.Qtde)
                objEntradaEquipamentoItem.Valor = Convert.ToDouble(Replace(item.Valor, ".", ","))
                objEntradaEquipamentoItem.Id_romaneio = CInt(txtCodigo.Text)
                objEntradaEquipamentoItem.Unique_keyid = NovoKeyId() 'row.Cells(8).Value
                objEntradaEquipamentoItem.Id_empresa = objEntradaEstoque.Id_empresa 'Publico.Id_empresa

                'Operação de delete/insert
                bllFilha2.GravarBLL(Operacao.Novo, objEntradaEquipamentoItem, True)

            Next


            'MessageBox.Show(IIf(Acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Transferência efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(False) 'modo leitura

        End Try

    End Sub
    Private Sub TransferirEstoque()

        If Not ValidaDados() Then
            Exit Sub
        End If

        Dim bllGlobal As New BLL.GlobalBLL
        Me.KeyId = bllGlobal.NovaChaveBLL(Me.Tabela)
        If Me.KeyId > 0 Then
            txtCodigo.Text = Me.KeyId.ToString() 'Chave do Romaneio
        End If

        Dim bllPai As New BLL.Entrada_EstoqueBLL
        Dim objEntradaEstoque As New DTO.Cg_entrada_estoque

        Dim bllFilha As New BLL.Entrada_chip_itemBLL
        Dim objEntradaChipItem As New DTO.Cg_entrada_chip_item

        Dim bllFilha2 As New BLL.Entrada_equipamento_itemBLL
        Dim objEntradaEquipamentoItem As New DTO.Cg_entrada_equipamento_item


        Try
            objEntradaEstoque.Id_romaneio = CInt(txtCodigo.Text)
            objEntradaEstoque.Data_movto = ShortDate() 'CDate(txtDataMovto.Text)
            objEntradaEstoque.Id_loja = CInt(getCodigoMatriz())

            objEntradaEstoque.User_ins = ACE_CODIGO
            objEntradaEstoque.Data_ins = Hoje()
            objEntradaEstoque.User_upd = ACE_CODIGO
            objEntradaEstoque.Data_upd = Hoje()
            objEntradaEstoque.Id_empresa = CInt(PesqFKEmpresaDestino.txtId.Text)


            bllPai.GravarBLL(Operacao.Novo, objEntradaEstoque)

            'Método de Delete => Insert
            'Pesquisa pelos itens já existente e exclui tudo, para incluir os
            'itens que estão ativos no Grid
            Dim strItens As ArrayList, strItens2 As ArrayList
            Dim sqlquery As String, sqlquery2 As String
            sqlquery = "select ID_ROMANEIO, UNIQUE_KEYID, ID_CHIP, SIMID, QTD, VALOR "
            sqlquery += "FROM CG_ENTRADA_CHIP_ITEM WHERE ID_ROMANEIO = " & objEntradaEstoque.Id_romaneio.ToString

            strItens = BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

            sqlquery2 = "select ID_ROMANEIO, UNIQUE_KEYID, ID_EQUIPAMENTO, SERIE, QTD, VALOR "
            sqlquery2 += "FROM CG_ENTRADA_EQUIPAMENTO_ITEM WHERE ID_ROMANEIO = " & objEntradaEstoque.Id_romaneio.ToString

            strItens2 = BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery2)

            'Percorre o array e exclui item a item 
            objEntradaChipItem.Id_romaneio = objEntradaEstoque.Id_romaneio
            Dim intParam1 As Integer, strParam2 As String
            For ixx = 0 To strItens.Count - 1
                intParam1 = strItens(ixx)(0)
                strParam2 = strItens(ixx)(1).ToString
                bllFilha.ExcluirBLL(intParam1, strParam2)
            Next

            'Percorre todo o DataGridView e insere os dados
            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then
                    If row.Cells(0).Value = True Then

                        'Carrega os dados no objeto Model para passagem de parametro
                        objEntradaChipItem.Id_chip = CInt(row.Cells(1).Value)
                        objEntradaChipItem.Simid = row.Cells(2).Value
                        objEntradaChipItem.Qtd = CInt(row.Cells(5).Value)
                        objEntradaChipItem.Valor = Convert.ToDouble(Replace(row.Cells(6).Value, ".", ","))
                        objEntradaChipItem.Id_romaneio = CInt(txtCodigo.Text)
                        objEntradaChipItem.Unique_keyid = NovoKeyId()  'row.Cells(8).Value
                        objEntradaChipItem.Id_empresa = objEntradaEstoque.Id_empresa 'Publico.Id_empresa


                        'Operação de delete/insert
                        bllFilha.GravarBLL(Operacao.Novo, objEntradaChipItem)
                    End If

                End If

            Next

            'Percorre o array e exclui item a item 
            objEntradaEquipamentoItem.Id_romaneio = objEntradaEstoque.Id_romaneio
            Dim intParametro1 As Integer, strParametro2 As String
            For ixx = 0 To strItens2.Count - 1
                intParametro1 = strItens2(ixx)(0)
                strParametro2 = strItens2(ixx)(1).ToString
                bllFilha2.ExcluirBLL(intParametro1, strParametro2)
            Next

            'Percorre todo o DataGridView e insere os dados
            For Each row As DataGridViewRow In dgvDados2.Rows

                If Not row.IsNewRow Then
                    If row.Cells(0).Value = True Then

                        'Carrega os dados no objeto Model para passagem de parametro
                        objEntradaEquipamentoItem.Id_equipamento = CInt(row.Cells(1).Value)
                        objEntradaEquipamentoItem.Serie = row.Cells(2).Value
                        objEntradaEquipamentoItem.Qtd = CInt(row.Cells(5).Value)
                        objEntradaEquipamentoItem.Valor = Convert.ToDouble(Replace(row.Cells(6).Value, ".", ","))
                        objEntradaEquipamentoItem.Id_romaneio = CInt(txtCodigo.Text)
                        objEntradaEquipamentoItem.Unique_keyid = NovoKeyId() 'row.Cells(8).Value
                        objEntradaEquipamentoItem.Id_empresa = objEntradaEstoque.Id_empresa 'Publico.Id_empresa

                        'Operação de delete/insert
                        bllFilha2.GravarBLL(Operacao.Novo, objEntradaEquipamentoItem)
                    End If

                End If

            Next

            'MessageBox.Show(IIf(Acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Transferência efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(False) 'modo leitura

        End Try

    End Sub

    Private Sub PesqFKEmpresaDestino_Load(sender As Object, e As EventArgs) Handles PesqFKEmpresaDestino.Load
        With PesqFKEmpresaDestino
            .LabelPesqFK = "Empresa Destino"
            .Tabela = "CG_EMPRESA"
            .View = "CG_EMPRESA"
            .CampoId = "ID_EMPRESA"
            .CampoDesc = "SIGLA_EMPRESA"
            .ListaCampos = "ID_EMPRESA, NOME_EMPRESA, SIGLA_EMPRESA"
            .ColunasFiltro = "NOME_EMPRESA,SIGLA_EMPRESA,ID_EMPRESA"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Empresas"
            .FiltroSQL = " WHERE ID_EMPRESA <> " & Publico.Id_empresa

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 39
            .txtId.Width -= 20
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 105
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3
        End With
    End Sub
    Private Function ValidaDados() As Boolean
        Dim ret As Boolean = True
        If String.IsNullOrEmpty(PesqFKEmpresaDestino.txtId.Text) Then
            ret = False
            MessageBox.Show("Obrigatório informar a empresa destino!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return ret
    End Function
    Private Function getCodigoMatriz() As String
        Dim strLoja As ArrayList
        Dim sqlquery As String
        Dim ret As String

        'Pega o ID da Matriz, da empresa logada. Cada empresa logada tem uma MATRIZ de estoque
        sqlquery = "SELECT ID_LOJA, NOME FROM CG_LOJA WHERE ID_TIPO_LOCAL_ESTOQUE=1 and id_empresa = " & PesqFKEmpresaDestino.txtId.Text
        strLoja = Global.BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

        ret = strLoja(0)(0).ToString
        'txtDescLoja.Text = strLoja(0)(1).ToString
        Return ret
    End Function

    Private Sub btnGuardaChip_Click(sender As Object, e As EventArgs) Handles btnGuardaChip.Click
        'Dim listaProdutos As New List(Of String)
        For Each row As DataGridViewRow In dgvDados.Rows


            If row.Cells(0).Value = True And Not row.IsNewRow Then
                Dim listOfSimid As New DTO.ListaTransfChip


                listOfSimid.IdChip = row.Cells(1).Value
                listOfSimid.SIMID = row.Cells(2).Value
                listOfSimid.IdOperadora = row.Cells(3).Value
                listOfSimid.DescOperadora = row.Cells(4).Value
                listOfSimid.Qtde = row.Cells(5).Value
                listOfSimid.Valor = row.Cells(6).Value

                listaChips.Add(listOfSimid)
                ListBox1.Items.Add(listOfSimid.SIMID)

            End If
        Next

    End Sub

    Private Sub btnGuardaPOS_Click(sender As Object, e As EventArgs) Handles btnGuardaPOS.Click
        For Each row As DataGridViewRow In dgvDados2.Rows


            If row.Cells(0).Value = True And Not row.IsNewRow Then
                Dim listOfEquip As New DTO.ListaTransfEquipamento


                listOfEquip.IdEquipamento = row.Cells(1).Value
                listOfEquip.Serie = row.Cells(2).Value
                listOfEquip.DescEquipamento = row.Cells(3).Value
                listOfEquip.Modelo = row.Cells(4).Value
                listOfEquip.Qtde = row.Cells(5).Value
                listOfEquip.Valor = row.Cells(6).Value

                listaEquipamentos.Add(listOfEquip)
                ListBox2.Items.Add(listOfEquip.Serie)

            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtPesquisaSimid.Text = ""
        CarregarChip()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtPesquisaSerie.Text = ""
        CarregarEquipamento()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        listaChips.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox2.Items.Clear()
        listaEquipamentos.Clear()

    End Sub
End Class