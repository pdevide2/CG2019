
Imports System.IO
Imports System.Reflection

Public Class OS

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

        sql = "select 'Editar' as botao, 'Ocorrência' as botao1, "
        sql += "a.ID_OS, a.ITEM_ID, a.ID_EQUIPAMENTO, a.DESC_EQUIPAMENTO, "
        sql += "a.SERIE, a.MODELO, convert(VARCHAR, a.previsao_retorno, 103) AS PREVISAO_RETORNO, "
        sql += "a.DESC_DEFEITO, a.CONSERTO_OK, a.ID_TIPO_EQUIPAMENTO, "
        sql += "a.DESC_TIPO_EQUIPAMENTO, a.GARANTIA, a.ID_OCORRENCIA, A.DESC_OCORRENCIA, A.ID_TABELA "
        sql += " from VW_CG_OS_ITEM a "

        Me.Comando = sql
        Me.ColunaFiltro = "ID_OS"
        Me.Filtro = " WHERE " & Me.ColunaFiltro & " = '" & txtCodigo.Text.ToString & "'"

        'Declara as variáveis do Tipo Coluna
        Dim colBotao As DataGridViewButtonColumn
        Dim colBotao2 As DataGridViewButtonColumn
        Dim colId_OS As DataGridViewTextBoxColumn
        Dim colItem_ID As DataGridViewTextBoxColumn
        Dim colId_Equipamento As DataGridViewTextBoxColumn
        Dim colSerie As DataGridViewTextBoxColumn
        Dim colModelo As DataGridViewTextBoxColumn
        Dim colDescEquipamento As DataGridViewTextBoxColumn
        Dim colPrevisaoRetorno As DataGridViewTextBoxColumn
        Dim colDescDefeito As DataGridViewTextBoxColumn
        Dim colIdTipoEquipamento As DataGridViewTextBoxColumn
        Dim colDescTipoEquipamento As DataGridViewTextBoxColumn
        Dim colConsertoOk As DataGridViewCheckBoxColumn
        Dim colGarantia As DataGridViewCheckBoxColumn
        Dim colIdOcorrencia As DataGridViewTextBoxColumn
        Dim colDescOcorrencia As DataGridViewTextBoxColumn
        Dim colTabelaPreco As DataGridViewTextBoxColumn

        '*******>> Configura as colunas
        'coluna botao
        colBotao = New DataGridViewButtonColumn
        colBotao.HeaderText = "Editar"
        colBotao.Name = "colBotao1"

        'coluna botao
        colBotao2 = New DataGridViewButtonColumn
        colBotao2.HeaderText = "Ocorrência"
        colBotao2.Name = "colBotao2"

        'coluna Id_romaneio
        colId_OS = New DataGridViewTextBoxColumn
        colId_OS.HeaderText = "OS nº"
        colId_OS.Name = "ID_OS"

        'coluna Unique_Keyid
        colItem_ID = New DataGridViewTextBoxColumn
        colItem_ID.HeaderText = "Item #Id"
        colItem_ID.Name = "ITEM_ID"

        'coluna Id_equipamento
        colId_Equipamento = New DataGridViewTextBoxColumn
        colId_Equipamento.HeaderText = "Id Equipamento"
        colId_Equipamento.Name = "ID_EQUIPAMENTO"

        'coluna Simid
        colSerie = New DataGridViewTextBoxColumn
        colSerie.HeaderText = "Série#"
        colSerie.Name = "SERIE"

        'coluna ID_Operadora
        colModelo = New DataGridViewTextBoxColumn
        colModelo.HeaderText = "Modelo"
        colModelo.Name = "MODELO"

        'coluna Descrição Operadora
        colDescEquipamento = New DataGridViewTextBoxColumn
        colDescEquipamento.HeaderText = "Descrição Equipamento"
        colDescEquipamento.Name = "DESC_EQUIPAMENTO"

        'coluna Quantidade
        colPrevisaoRetorno = New DataGridViewTextBoxColumn
        colPrevisaoRetorno.HeaderText = "Prev. Retorno"
        colPrevisaoRetorno.Name = "PREVISAO_RETORNO"

        'coluna Valor
        colDescDefeito = New DataGridViewTextBoxColumn
        colDescDefeito.HeaderText = "Descrição Defeito"
        colDescDefeito.Name = "DESC_DEFEITO"

        'coluna Valor
        colIdTipoEquipamento = New DataGridViewTextBoxColumn
        colIdTipoEquipamento.HeaderText = "Id Tipo Equipto"
        colIdTipoEquipamento.Name = "ID_TIPO_EQUIPAMENTO"

        'coluna DESC_TIPO_EQUIPAMENTO
        colDescTipoEquipamento = New DataGridViewTextBoxColumn
        colDescTipoEquipamento.HeaderText = "Descrição Tipo Equipto"
        colDescTipoEquipamento.Name = "DESC_TIPO_EQUIPAMENTO"

        'coluna CONSERTO_OK
        colConsertoOk = New DataGridViewCheckBoxColumn
        colConsertoOk.HeaderText = "Conserto OK?"
        colConsertoOk.Name = "CONSERTO_OK"

        colGarantia = New DataGridViewCheckBoxColumn
        colGarantia.HeaderText = "Garantia?"
        colGarantia.Name = "GARANTIA"

        'coluna iD ocorrencia
        colIdOcorrencia = New DataGridViewTextBoxColumn
        colIdOcorrencia.HeaderText = "Id Ocorrência"
        colIdOcorrencia.Name = "ID_OCORRENCIA"

        'coluna Descrição Ocorrencia
        colDescOcorrencia = New DataGridViewTextBoxColumn
        colDescOcorrencia.HeaderText = "Descrição Defeito Ocorrência"
        colDescOcorrencia.Name = "DESC_OCORRENCIA"

        'coluna colTabelaPreco
        colTabelaPreco = New DataGridViewTextBoxColumn
        colTabelaPreco.HeaderText = "Tabela Preço"
        colTabelaPreco.Name = "ID_TABELA"

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colBotao, colBotao2, colId_OS, colItem_ID,
                                                            colId_Equipamento, colDescEquipamento,
                                                            colSerie, colModelo, colPrevisaoRetorno,
                                                            colDescDefeito, colConsertoOk,
                                                            colIdTipoEquipamento, colDescTipoEquipamento,
                                                            colGarantia, colIdOcorrencia, colDescOcorrencia,
                                                            colTabelaPreco})
        'dgvDados.DataSource = myRow
        Popula_Grid()

        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão
        For ixx = 2 To 16
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
        dgvDados.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

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
                        myRow(ixx)(8).ToString,
                        myRow(ixx)(9).ToString,
                        myRow(ixx)(10).ToString,
                        myRow(ixx)(11).ToString,
                        myRow(ixx)(12).ToString,
                        myRow(ixx)(13).ToString,
                        myRow(ixx)(14).ToString,
                        myRow(ixx)(15).ToString,
                        myRow(ixx)(16).ToString}

            dgvDados.Rows.Add(strLinha)

        Next

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()

        Me.PkString = False
        Me.Tabela = "CG_OS" 'Nome da tabela no SQL
        Me.View = "VW_CG_OS"
        Me.TabelaFilha = "CG_OS_ITEM"
        Me.Modulo = 26 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_os
        Me.ColunaId = "ID_OS"
        Habilita_Controles(False) 'modo leitura
        cboStatus.Enabled = False
        txtData.Enabled = False
        'Monta o Grid e configura as colunas 
        Carregar()
        'Alimenta o combo de Status
        CarregaComboStatus()

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
            txtIdLoja.Text = Me.LinhaGrid.Cells("ID_LOJA_ORIGEM").Value.ToString
            txtDescLoja.Text = Me.LinhaGrid.Cells("NOME_LOJA").Value.ToString
            txtIdFornecedor.Text = Me.LinhaGrid.Cells("ID_FORNECEDOR").Value.ToString
            txtDescFornecedor.Text = Me.LinhaGrid.Cells("NOME_FORNECEDOR").Value.ToString
            txtIdResponsavel.Text = Me.LinhaGrid.Cells("ID_RESPONSAVEL_IDA").Value.ToString
            txtDescResponsavel.Text = Me.LinhaGrid.Cells("RESPONSAVEL").Value.ToString
            txtData.Text = Me.LinhaGrid.Cells("DATA_MOVTO").Value.ToString

            txtNFe.Text = Me.LinhaGrid.Cells("NF_TRANSP").Value.ToString
            txtSerieNFe.Text = Me.LinhaGrid.Cells("SERIE_NF_TRANSP").Value.ToString
            txtEmissaoNFe.Text = Me.LinhaGrid.Cells("EMISSAO_NF_TRANSP").Value.ToString

            cboStatus.SelectedValue = CInt(Me.LinhaGrid.Cells("STATUS_OS").Value)

            Carregar()
            HabilitaBotoes(flagAcao)

        End If
    End Sub

    Public Overrides Function ValidaCampos() As Object
        Dim blnRet As Boolean
        txtCodigo.Tag = "Nº O.S."
        txtIdLoja.Tag = "Código da Loja"
        txtData.Tag = "Data do Movimento"
        txtIdResponsavel.Tag = "Código do Responsável pelo trânsito"
        txtDescResponsavel.Tag = "Descrição do Responsável pelo trânsito"
        txtData.Tag = "Data da OS"
        txtIdFornecedor.Tag = "Código Fornecedor Serviço"
        txtDescFornecedor.Tag = "Desc. Fornecedor Serviço"


        blnRet = MyBase.ValidaCampos()
        If cboStatus.Text = "" Then
            MessageBox.Show("Selecione um Status para a OS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnRet = False
        End If

        If blnRet Then
            If dgvDados.RowCount = 0 Then
                MessageBox.Show("Obrigatório informar os  Equipamentos para Assistência Técnica.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnRet = False
            End If

            'Percorre todo o DataGridView e insere os dados
            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    '                                                       
                    If String.IsNullOrEmpty(row.Cells("ID_TABELA").Value) Then
                        blnRet = False
                        MessageBox.Show("Obrigatório informar Tabela de Serviços em todos os itens da OS.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit For
                    End If

                End If

            Next

        End If
        Return blnRet

    End Function

    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)

        If Not ValidaCampos() Then
            Exit Sub
        End If

        Dim bllPai As New BLL.OsBLL
        Dim objOS As New DTO.Cg_os

        Dim bllFilha As New BLL.Os_itemBLL
        Dim objOSItem As New DTO.Cg_os_item

        Try
            objOS.Id_os = CInt(txtCodigo.Text)
            objOS.Data_movto = CDate(txtData.Text)
            objOS.Id_loja_origem = CInt(txtIdLoja.Text)
            objOS.Id_fornecedor = CInt(txtIdFornecedor.Text)
            objOS.Id_responsavel_ida = CInt(txtIdResponsavel.Text)
            objOS.Status_os = False

            objOS.Nf_transp = txtNFe.Text
            objOS.Serie_nf_transp = txtSerieNFe.Text
            objOS.Emissao_nf_transp = CDate(txtEmissaoNFe.Text)
            objOS.Status_os = CInt(cboStatus.SelectedValue)

            'Dados de usuarios
            objOS.User_ins = ACE_CODIGO
            objOS.Data_ins = Hoje()
            objOS.User_upd = ACE_CODIGO
            objOS.Data_upd = Hoje()
            objOS.Id_empresa = Publico.Id_empresa

            bllPai.GravarBLL(acao, objOS)

            'Método de Delete => Insert
            'Pesquisa pelos itens já existente e exclui tudo, para incluir os
            'itens que estão ativos no Grid
            Dim strItens As ArrayList
            Dim sqlquery As String

            sqlquery = "SELECT ID_OS, ITEM_ID, ID_EQUIPAMENTO, DESC_EQUIPAMENTO, SERIE, MODELO"
            sqlquery += " FROM CG_OS_ITEM WHERE ID_OS = " & objOS.Id_os.ToString

            strItens = BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

            'Percorre o array e exclui item a item 
            objOSItem.Id_os = objOS.Id_os

            Dim intParam1 As Integer, intParam2 As Integer, intParam3 As Integer
            For ixx = 0 To strItens.Count - 1
                intParam1 = strItens(ixx)(0)
                intParam2 = strItens(ixx)(1)
                intParam3 = strItens(ixx)(2)
                bllFilha.ExcluirBLL(intParam1, intParam2, intParam3)
            Next

            'Percorre todo o DataGridView e insere os dados
            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    '                                                       

                    objOSItem.Id_os = CInt(txtCodigo.Text)
                    objOSItem.Item_id = CInt(row.Cells("ITEM_ID").Value)
                    objOSItem.Id_equipamento = CInt(row.Cells("ID_EQUIPAMENTO").Value)

                    objOSItem.Desc_equipamento = row.Cells("DESC_EQUIPAMENTO").Value
                    objOSItem.Serie = row.Cells("SERIE").Value
                    objOSItem.Modelo = row.Cells("MODELO").Value
                    objOSItem.Previsao_retorno = CDate(row.Cells("PREVISAO_RETORNO").Value)
                    objOSItem.Desc_defeito = row.Cells("DESC_DEFEITO").Value

                    objOSItem.User_ins = ACE_CODIGO
                    objOSItem.Data_ins = Hoje()
                    objOSItem.User_upd = ACE_CODIGO
                    objOSItem.Data_upd = Hoje()

                    objOSItem.Garantia = CBool(row.Cells("GARANTIA").Value)
                    If String.IsNullOrEmpty(row.Cells("ID_OCORRENCIA").Value) Then
                        objOSItem.Id_Ocorrencia = 0
                    Else
                        objOSItem.Id_Ocorrencia = CInt(row.Cells("ID_OCORRENCIA").Value)
                    End If
                    objOSItem.Id_empresa = Publico.Id_empresa
                    objOSItem.Id_Tabela = row.Cells("ID_TABELA").Value
                    'Operação de delete/insert
                    bllFilha.GravarBLL(Operacao.Novo, objOSItem)

                End If

            Next

            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta
            Me.Acao = flagAcao

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(False) 'modo leitura

        End Try

    End Sub

    Public Overrides Sub Alterar()

        If Not ((cboStatus.Text = "ABERTA") Or (cboStatus.Text = "EM PROCESSO")) Then
            MessageBox.Show("Atenção OS não pode mais ser modificada, pois o STATUS é diferente de [ABERTA] ou [EM PROCESSO]", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        MyBase.Alterar()
        Habilita_Controles(True) 'modo digitação

    End Sub

    Public Overrides Sub Excluir()


        MyBase.Excluir()
        Habilita_Controles(True) 'modo digitação

    End Sub

    Public Overrides Sub Habilita_Controles(blnModo As Boolean)
        MyBase.Habilita_Controles(blnModo)
        chkPDF.Enabled = Not blnModo
        If (cboStatus.Text.Equals("EM PROCESSO")) Then
            btnAdiciona.Enabled = False
            btnExclui.Enabled = False
            btnPesqResponsavel.Enabled = False
            btnPesqLoja.Enabled = False
            btnPesqLojaDestino.Enabled = False
            txtData.Enabled = False
            cboStatus.Enabled = False
        End If
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
            sqlquery = "SELECT ID_LOJA, NOME FROM CG_LOJA WHERE dbo.CG_LOJA.ID_LOJA = 1"

            strLoja = Global.BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

            txtIdLoja.Text = strLoja(0)(0).ToString
            txtDescLoja.Text = strLoja(0)(1).ToString
        Else
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.OsBLL
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

        Me.ObjModelFk.Tabela = "VW_BUSCA_CG_LOJA"
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

        'If String.IsNullOrEmpty(txtIdFornecedor.Text) Then
        'Me.ObjModelFk.FiltroSQL = " where (ID_LOJA = 1 OR ID_LOJA > 9) "
        Me.ObjModelFk.FiltroSQL = " where (ID_LOJA IN (1,3,4,5)) "

        'Else
        'Me.ObjModelFk.FiltroSQL = " where ID_LOJA <> " & txtIdFornecedor.Text
        'End If

        PesquisaFK(Me.ObjModelFk)

        txtIdLoja.Text = Me.ObjModelFk.txtId.ToString
        txtDescLoja.Text = Me.ObjModelFk.txtDesc

    End Sub

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
        If e.ColumnIndex = 0 Then
            Edita_dados(dgvDados.CurrentRow)
        End If
        If e.ColumnIndex = 1 Then
            'Chama_Ocorrencia(dgvDados.CurrentRow)
            'ContextMenuStrip3.Show(dgvDados, New Point(e.RowIndex, e.ColumnIndex))
        End If

    End Sub
    Private Sub Chama_Ocorrencia(ByVal _modo As String, ByVal _linhaGrid As DataGridViewRow)
        'Acao >>>>>>>
        '============
        'Limpar = 0
        'Novo = 1
        'Alterar = 2
        'Excluir = 3
        'Consulta = 4
        'Leitura = 5
        Dim _id_ocorrencia1 As Integer
        Dim _chave_os_item As String

        _chave_os_item = _linhaGrid.Cells("ID_OS").Value & "|" &
                        _linhaGrid.Cells("ITEM_ID").Value & "|" &
                        _linhaGrid.Cells("ID_EQUIPAMENTO").Value


        _id_ocorrencia1 = CInt(IIf(String.IsNullOrEmpty(_linhaGrid.Cells("ID_OCORRENCIA").Value), "-2", _linhaGrid.Cells("ID_OCORRENCIA").Value))

        If _modo = "edit" Then

            If _id_ocorrencia1 <= 0 Then

                'Inclui nova ocorrência
                Dim form1 As New WinCG.Ocorrencia(Operacao.Novo, _id_ocorrencia1, CInt(_linhaGrid.Cells("ID_EQUIPAMENTO").Value), CInt(txtIdLoja.Text), _chave_os_item)
                form1.ShowDialog()

            Else


                'Chama a ocorrência vinculada para modo alteração
                Dim form1 As New WinCG.Ocorrencia(Operacao.Alterar, _id_ocorrencia1, CInt(_linhaGrid.Cells("ID_EQUIPAMENTO").Value), CInt(txtIdLoja.Text), _chave_os_item)
                form1.ShowDialog()

            End If

        Else

            If _id_ocorrencia1 <= 0 Then
                MessageBox.Show("Este item não possui ocorrência vinculada para consultar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim form1 As New WinCG.Ocorrencia(Operacao.Consulta, _id_ocorrencia1, CInt(_linhaGrid.Cells("ID_EQUIPAMENTO").Value), CInt(txtIdLoja.Text), _chave_os_item)
            form1.ShowDialog()

        End If
    End Sub
    Private Sub Edita_dados(ByVal _linhaGrid As DataGridViewRow)

        Dim _modoedicao As Integer = flagAcao
        If cboStatus.Text.Equals("EM PROCESSO") Then
            _modoedicao = Operacao.Consulta
        End If
        Dim frm As New WinCG.OS_Edicao(_modoedicao, dgvDados, CInt(txtCodigo.Text), _linhaGrid, CInt(txtIdFornecedor.Text))
        frm.ShowDialog()

    End Sub
    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao)
        btnPesqLoja.Enabled = False
        btnPesqLojaDestino.Enabled = False
        btnPesqResponsavel.Enabled = False

        btnAdiciona.Enabled = False
        btnExclui.Enabled = False

        txtNFe.Enabled = False
        txtSerieNFe.Enabled = False
        txtEmissaoNFe.Enabled = False

        btnAnexa1.Enabled = IIf(acao = Operacao.Consulta And dgvDados.RowCount > 0, True, False)
        btnAnexa2.Enabled = IIf(acao = Operacao.Consulta And dgvDados.RowCount > 0, True, False)
        btnFollowUp.Enabled = IIf(acao = Operacao.Consulta And dgvDados.RowCount > 0, True, False)

        cboStatus.Enabled = False
        txtData.Enabled = False

        If acao = Operacao.Novo Or acao = Operacao.Alterar Then

            'Somente habilita seleção de lojas na inclusão
            If acao = Operacao.Novo Then
                btnPesqLoja.Enabled = True
                btnPesqLojaDestino.Enabled = True

                cboStatus.Enabled = True
                txtData.Enabled = True
            End If

            btnPesqResponsavel.Enabled = True
            btnAdiciona.Enabled = True
            btnExclui.Enabled = True

            txtNFe.Enabled = True
            txtSerieNFe.Enabled = True
            txtEmissaoNFe.Enabled = True

            btnAnexa1.Enabled = False
            btnAnexa2.Enabled = False
            btnFollowUp.Enabled = False

            cboStatus.Enabled = True
            txtData.Enabled = True

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

    Private Sub btnExclui_Click(sender As Object, e As EventArgs) Handles btnExclui.Click
        ExcluiLinha()
    End Sub

    Public Overrides Sub Cancelar(acao As Integer)
        MyBase.Cancelar(acao)
        Carregar()

    End Sub

    Private Sub btnPesqLojaDestino_Click(sender As Object, e As EventArgs) Handles btnPesqLojaDestino.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_FORNECEDOR"
        Me.ObjModelFk.CampoId = "ID_FORNECEDOR"
        Me.ObjModelFk.CampoDesc = "NOME"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Fornecedor"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc &
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where 1=1 "

        PesquisaFK(Me.ObjModelFk)

        txtIdFornecedor.Text = Me.ObjModelFk.txtId.ToString
        txtDescFornecedor.Text = Me.ObjModelFk.txtDesc

        If Not ExisteTabelaServico() Then
            Me.KeyId = 0
            Limpar_Controles()
            Cancelar(flagAcao)
        End If

    End Sub

    Private Sub btnPesqResponsavel_Click(sender As Object, e As EventArgs) Handles btnPesqResponsavel.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_RESPONSAVEL"
        Me.ObjModelFk.CampoId = "ID_RESPONSAVEL"
        Me.ObjModelFk.CampoDesc = "NOME"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Responsáveis"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc &
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where 1=1 "

        PesquisaFK(Me.ObjModelFk)

        txtIdResponsavel.Text = Me.ObjModelFk.txtId.ToString
        txtDescResponsavel.Text = Me.ObjModelFk.txtDesc
    End Sub

    Private Sub btnAdiciona_Click_1(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        If String.IsNullOrEmpty(txtIdLoja.Text) Or txtIdLoja.Text = "0" Then
            MessageBox.Show("Atenção selecione primeiro a Loja de Origem antes de adicionar Equipamentos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim frm As New WinCG.frmSelecionaEquipamentoOS(CInt(txtCodigo.Text), CInt(txtIdLoja.Text), dgvDados)
        frm.ShowDialog()
    End Sub

    Private Sub btnExclui_Click_1(sender As Object, e As EventArgs)
        If dgvDados.RowCount > 0 Then
            ExcluiLinha()
        End If
    End Sub

    Private Function Verifica_Recebimento(ByVal _id_romaneio As Integer, ByVal _modo As String) As Boolean
        Dim blnRet As Boolean = True
        Dim listaRecebimento As ArrayList
        Dim sql As String = ""
        Dim strModoRecebe As String = ""
        Dim strOperacao As String = ""

        Try
            sql = "SELECT QTD_TOTAL, QTD_RECEBIDA FROM CG_MOVIMENTO_EQUIPAMENTO WHERE ID_ROMANEIO = {0}"
            sql = String.Format(sql, _id_romaneio)
            listaRecebimento = BLL.GlobalBLL.PesquisarFkListaBLL(sql)
            If listaRecebimento(0)(1) > 0 Then
                blnRet = False
                strModoRecebe = IIf(listaRecebimento(0)(1) = listaRecebimento(0)(0), "totalmente!", "parcialmente!")
                strOperacao = IIf(_modo = "A", "Alteração", "Exclusão")
                MessageBox.Show(strOperacao & " não permitida! Este romaneio já foi recebido " & strModoRecebe, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnRet = False
        End Try

        Return blnRet
    End Function

    Private Sub CarregaComboStatus()

        Dim sql As String
        sql = "SELECT ID_STATUS, DESC_STATUS "
        sql += "FROM CG_STATUS_OS ORDER BY ID_STATUS "
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        cboStatus.DisplayMember = "DESC_STATUS"
        cboStatus.ValueMember = "ID_STATUS"

    End Sub

    Private Sub btnFollowUp_Click(sender As Object, e As EventArgs) Handles btnFollowUp.Click
        Dim frm As New FollowUp_OS(CInt(txtCodigo.Text))
        frm.Owner = Me
        frm.ShowDialog()
    End Sub


    Private Sub btnAnexa1_Click(sender As Object, e As EventArgs) Handles btnAnexa1.Click
        ContextMenuStrip1.Show(btnAnexa1, 0, btnAnexa1.Height)
        'UploadAnexo1()
    End Sub

    Private Sub UploadAnexo1()
        Dim strfilename As String = ""
        ofd.FileName = strfilename
        ofd.Filter = "XML Files|*.xml|All files|*.*"
        Try
            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                strfilename = Trim(ofd.FileName)
                MessageBox.Show(strfilename, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Seleção de arquivo xml cancelado pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                strfilename = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If Not String.IsNullOrEmpty(strfilename) Then
            Grava_xml_nf_transp(strfilename)
        End If
    End Sub

    Private Sub Grava_xml_nf_transp(_filename As String)
        Try
            Dim sqlEmpty As String, sql As String = ""
            sqlEmpty = "update CG_OS SET XML_NF_TRANSP = '{0}' WHERE ID_OS={1}"

            Dim strXml = TxtToString(_filename)
            sql = sqlEmpty
            sql = String.Format(sql, strXml, CInt(txtCodigo.Text))

            Dim bllGlobal As New BLL.GlobalBLL
            bllGlobal.GravarGenericoBLL(sql)
            MessageBox.Show("Gravação Concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAnexa2_Click(sender As Object, e As EventArgs) Handles btnAnexa2.Click
        ContextMenuStrip2.Show(btnAnexa2, 0, btnAnexa2.Height)

    End Sub

    Private Sub BotaoAnexa2()

        Try
            Dim bllGlobal As New BLL.GlobalBLL
            Dim sql As String
            Dim blnUtiliza_NFTS As Boolean = False

            sql = "Select ID_FORNECEDOR, SIGLA, NOME, UTILIZA_NFTS "
            sql += "From cg_fornecedor where id_fornecedor = " & txtIdFornecedor.Text.ToString

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)

            If dt.Rows.Count > 0 Then
                blnUtiliza_NFTS = CBool(dt.Rows(0)("UTILIZA_NFTS"))

                If Not blnUtiliza_NFTS Then
                    Throw New System.Exception("Fornecedor " & Trim(dt(0)("NOME")) & " NÃO utliza NFTS.")
                End If

                UploadAnexo2()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub UploadAnexo2()
        Dim strfilename As String = ""
        ofd.FileName = strfilename
        ofd.Filter = "XML Files|*.xml|All files|*.*"

        Try
            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                strfilename = Trim(ofd.FileName)
                MessageBox.Show(strfilename, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Seleção de arquivo xml cancelado pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                strfilename = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If Not String.IsNullOrEmpty(strfilename) Then
            Grava_xml_nfts(strfilename)
        End If
    End Sub

    Private Sub Grava_xml_nfts(_filename As String)
        Try
            Dim sqlEmpty As String, sql As String = ""
            sqlEmpty = "update CG_OS SET XML_NF_TS = '{0}' WHERE ID_OS={1}"

            Dim strXml = TxtToString(_filename)
            sql = sqlEmpty
            sql = String.Format(sql, strXml, CInt(txtCodigo.Text))

            Dim bllGlobal As New BLL.GlobalBLL
            bllGlobal.GravarGenericoBLL(sql)
            MessageBox.Show("Gravação Concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AnexarEmXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnexarEmXMLToolStripMenuItem.Click
        UploadAnexo1()
    End Sub

    Private Sub AnexarEmPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnexarEmPDFToolStripMenuItem.Click
        'MessageBox.Show("Anexar NF-e em PDF!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        AnexarPDF("PDF_NF_TRANSP")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewXMLNFe_Transp.Click
        'ExportaPDF()
        ExportaXML("XML_NF_TRANSP")
    End Sub

    Private Sub ExportaXML(ByVal _colunaSQL As String)
        Try

            Dim intIdOs As Integer = CInt(txtCodigo.Text)

            Dim sqlVerifica As String, sqlEmpty As String, sql As String = "", sql2 As String = ""
            sqlEmpty = "select " & _colunaSQL & " from cg_os where id_os = {0} "
            sqlVerifica = "select CAST(CASE WHEN " & _colunaSQL & " IS NULL THEN 0 ELSE 1 END AS BIT) AS EXISTE " &
                            "from cg_os where id_os = {0} "
            'Dim strXml = TxtToString(_filename)
            sql = sqlEmpty
            sql = String.Format(sql, intIdOs)

            sql2 = sqlVerifica
            sql2 = String.Format(sql2, intIdOs)

            Dim bllGlobal As New BLL.GlobalBLL

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql2)

            Dim blnRetorno As Boolean = False
            If dt.Rows.Count > 0 Then

                blnRetorno = dt(0)("EXISTE")

            End If

            If blnRetorno = True Then
                'MessageBox.Show("Gravação Concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Dim arqXML_name As String = _colunaSQL & Convert.ToString(DateTime.Now.ToFileTime) & ".xml"
                Dim fileXML As String, colunaXML As String
                fileXML = My.Settings.DIRHOME & "tmp\" & arqXML_name

                Dim dt2 As DataTable
                dt2 = bllGlobal.SqlExecDT(sql)

                If dt2.Rows.Count > 0 Then

                    colunaXML = dt2(0)(0)

                    Dim objStream As New FileStream(fileXML, IO.FileMode.OpenOrCreate)
                    Dim arq As New StreamWriter(objStream)

                    arq.Write(colunaXML)
                    arq.Close()
                    VisualizarArquivo("XML", fileXML)

                End If

            Else
                MessageBox.Show("Campo anexo está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnViewXMLNFe_Ts_Click(sender As Object, e As EventArgs) Handles btnViewXMLNFe_Ts.Click
        ExportaXML("XML_NF_TS")
    End Sub

    Private Sub ExportaPDF(ByVal _colunaSQL As String)
        Try

            Dim intIdOs As Integer = CInt(txtCodigo.Text)

            Dim sqlVerifica As String, sqlEmpty As String, sql As String = "", sql2 As String = ""
            sqlEmpty = "select " & _colunaSQL & " from cg_os where id_os = {0} "
            sqlVerifica = "select CAST(CASE WHEN " & _colunaSQL & " IS NULL THEN 0 ELSE 1 END AS BIT) AS EXISTE " &
                            "from cg_os where id_os = {0} "
            'Dim strXml = TxtToString(_filename)
            sql = sqlEmpty
            sql = String.Format(sql, intIdOs)

            sql2 = sqlVerifica
            sql2 = String.Format(sql2, intIdOs)

            Dim bllGlobal As New BLL.GlobalBLL

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql2)

            Dim blnRetorno As Boolean = False
            If dt.Rows.Count > 0 Then

                blnRetorno = dt(0)("EXISTE")

            End If

            If blnRetorno = True Then
                'MessageBox.Show("Gravação Concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Dim arqpdf_name As String = "pdf_" & _colunaSQL & "_" & Convert.ToString(DateTime.Now.ToFileTime) & ".pdf"
                Dim filepdf As String
                filepdf = My.Settings.DIRHOME & "tmp\" & arqpdf_name
                Dim fs As FileStream = New FileStream(filepdf, FileMode.CreateNew, FileAccess.Write)

                Dim vetorImagem As Byte() = bllGlobal.SqlLoadImage(sql)
                fs.Write(vetorImagem, 0, vetorImagem.Length)
                fs.Flush()
                fs.Close()

                VisualizarArquivo("PDF", filepdf)
            Else
                MessageBox.Show("Campo anexo está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AnexarEmXMLToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnexarEmXMLToolStripMenuItem1.Click
        BotaoAnexa2()
    End Sub

    Private Sub AnexarEmPDFToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnexarEmPDFToolStripMenuItem1.Click
        'anexar nfe- TS em pdf
        'MessageBox.Show("Anexar NF-e em PDF!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        AnexarPDF("PDF_NF_TS")

    End Sub

    Private Sub AnexarPDF(ByVal _colunaSQL As String)
        Dim strfilename As String = ""
        ofd2.FileName = strfilename
        ofd2.Filter = "PDF Files|*.PDF|All files|*.*"
        Try
            If ofd2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                strfilename = Trim(ofd2.FileName)
                If IsPDFHeader(strfilename) = True Then
                    MessageBox.Show(strfilename, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Arquivo selecionado não é um PDF! Operação Cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If

            Else
                MessageBox.Show("Seleção de arquivo PDF cancelado pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                strfilename = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If Not String.IsNullOrEmpty(strfilename) Then

            Dim intIdOs As Integer = CInt(txtCodigo.Text)

            Dim mensagem As String = "Confirma importação do PDF de NFe para OS: {0} ?"
            mensagem = String.Format(mensagem, intIdOs)

            If MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Grava_PDF(_colunaSQL, strfilename, intIdOs)
            End If

        End If

    End Sub

    Private Sub Grava_PDF(_colunaSQL As String, _filename As String, _idOs As Integer)

        Dim bll As New BLL.OsBLL
        If _colunaSQL = "PDF_NF_TRANSP" Then
            Dim objOS_PDF_NF_TRANSP As New DTO.Cg_os_PDF_NF_TRANSP

            Try

                Dim filebyte() As Byte = Nothing
                filebyte = System.IO.File.ReadAllBytes(ofd2.FileName)

                'Carrega os dados no objeto Model para passagem de parametro
                objOS_PDF_NF_TRANSP.Id_os = _idOs
                objOS_PDF_NF_TRANSP.PDF_NF_TRANSP = filebyte

                bll.GravarPDF_NF_TRANSP(1, objOS_PDF_NF_TRANSP)

                MessageBox.Show("PDF anexado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


            Catch ex As Exception
                MessageBox.Show("Erro ao anexar PDF: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally


            End Try
        Else
            Dim objOS_PDF_NF_TS As New DTO.Cg_os_PDF_NF_TS
            Try

                Dim filebyte() As Byte = Nothing
                filebyte = System.IO.File.ReadAllBytes(ofd2.FileName)

                'Carrega os dados no objeto Model para passagem de parametro
                objOS_PDF_NF_TS.Id_os = _idOs
                objOS_PDF_NF_TS.PDF_NF_TS = filebyte

                bll.GravarPDF_NF_TS(1, objOS_PDF_NF_TS)

                MessageBox.Show("PDF anexado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


            Catch ex As Exception
                MessageBox.Show("Erro ao anexar PDF: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally


            End Try
        End If


    End Sub

    Private Sub btnViewPDFNFe_Transp_Click(sender As Object, e As EventArgs) Handles btnViewPDFNFe_Transp.Click
        ExportaPDF("PDF_NF_TRANSP")
    End Sub

    Private Sub btnViewPDFNFe_TS_Click(sender As Object, e As EventArgs) Handles btnViewPDFNFe_TS.Click
        ExportaPDF("PDF_NF_TS")
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ReportOS(1, Me.chkPDF.Checked)
    End Sub

    Private Sub ReportOS(ByVal _orientacao As Integer, ByVal _gerarPDF As Boolean)
        Try
            Dim dirReport As String

            dirReport = My.Settings.DIRHOME & "Saida\"

            If Not Directory.Exists(dirReport) Then
                Directory.CreateDirectory(dirReport)
            End If

            Dim arqOrigem As String = My.Settings.DIRHOME & "CG\CG\Modelos\RELATORIO_OS.docx"
            Dim arqDestino As String = dirReport & "RELATORIO_OS_" & ProtocoloNumero() & ".docx"

            If _orientacao = 2 Then
                arqOrigem = My.Settings.DIRHOME & "CG\CG\Modelos\RELATORIO_OS_PAISAGEM.docx"
                arqDestino = dirReport & "RELATORIO_OS_P_" & ProtocoloNumero() & ".docx"
            End If

            My.Computer.FileSystem.CopyFile(arqOrigem, arqDestino)

            Dim objParam As New DTO.Parametros_report_os
            objParam.Data = txtData.Text.ToString
            objParam.Emissao = txtEmissaoNFe.Text.ToString
            objParam.Fornecedor = txtIdFornecedor.Text.ToString & " - " & txtDescFornecedor.Text.ToString
            objParam.Loja = txtIdLoja.Text.ToString & " - " & txtDescLoja.Text.ToString
            objParam.NF = txtNFe.Text.ToString
            objParam.OS_Id = txtCodigo.Text.ToString
            objParam.Responsavel = txtIdResponsavel.Text.ToString & " - " & txtDescResponsavel.Text.ToString
            objParam.SerieNF = txtSerieNFe.Text.ToString
            objParam.GerarPDF = _gerarPDF

            If _orientacao = 2 Then
                ReportOSWordPaisagem(arqDestino, objParam, dgvDados)
            Else
                ReportOSWord(arqDestino, objParam, dgvDados)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvDados_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDados.CellMouseClick
        'Se a celula clicada for o botão Ocorrência, apresenta o menu de contexto
        If dgvDados.CurrentCell.Value = "Ocorrência" Then
            'Habilita todos os itens do menu
            For Each it As ToolStripItem In Me.ContextMenuStrip3.Items
                it.Enabled = True
            Next

            'Desabilita os itens de Edição de dados para modo consulta
            If (Me.Acao = Operacao.Consulta Or cboStatus.Text.Equals("EM PROCESSO")) Then
                For Each it As ToolStripItem In Me.ContextMenuStrip3.Items
                    If it.Text = "Vincular Ocorrência" Then
                        it.Enabled = False
                    End If

                    If it.Text = "Excluir Vinculo com Ocorrência" Then
                        it.Enabled = False
                    End If

                    If it.Text = "Consultar" Then
                        it.Enabled = True
                    End If

                Next
            End If
            ContextMenuStrip3.Show(dgvDados, New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub VincularOcorrênciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VincularOcorrênciaToolStripMenuItem.Click
        Chama_Ocorrencia("edit", dgvDados.CurrentRow)
        Carregar()
    End Sub

    Private Sub ExcluirVinculoComOcorrênciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirVinculoComOcorrênciaToolStripMenuItem.Click
        Exclui_Ocorrencia(dgvDados.CurrentRow)
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Chama_Ocorrencia("view", dgvDados.CurrentRow)
    End Sub
    Private Sub Exclui_Ocorrencia(ByVal _Linhagrid As DataGridViewRow)
        dgvDados.CurrentRow.Cells("ID_OCORRENCIA").Value = ""
        MessageBox.Show("Vinculo Excluído, clique no botão <Gravar> para confirmar a operação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub btnOcorrenciasLoja_Click(sender As Object, e As EventArgs) Handles btnOcorrenciasLoja.Click
        'Chama tela de consulta de Ocorrências Vinculadas
        'Chama tela de consulta de Ocorrências Vinculadas
        If String.IsNullOrEmpty(txtIdLoja.Text) Then
            Exit Sub
        End If
        Dim frm As New OcorrenciaVsLoja(CInt(txtIdLoja.Text))
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ReportOS(2, Me.chkPDF.Checked)
    End Sub

    Private Function ExisteTabelaServico() As Boolean

        Try
            Dim bllGlobal As New BLL.GlobalBLL
            Dim sql As String
            Dim blnExiste As Boolean = False

            sql = "Select ID_TABELA "
            sql += "From CG_TABELA_SERVICOS_FORNECEDOR where id_fornecedor = " & txtIdFornecedor.Text.ToString

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)

            If dt.Rows.Count > 0 Then
                blnExiste = True
            End If
            If Not blnExiste Then
                MessageBox.Show("Tabela de Serviços do fornecedor não Cadastrada!" & Chr(13) &
                                "Para Continuar, cadastre primeiro a Tabela de Serviços.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return blnExiste
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    Public Overrides Sub Limpar_Controles()
        'Este método é utilizado para limpar os controles antes da Inclusão
        'Limpa os controles de cada tabpage
        For Each c In Me.TabPage1.Controls
            Select Case c.GetType()
                Case GetType(TextBox)
                    CType(c, TextBox).Text = String.Empty
                Case GetType(ComboBox)
                    CType(c, ComboBox).Text = String.Empty
                Case GetType(CheckBox)
                    CType(c, CheckBox).Checked = False
                Case GetType(MaskedTextBox)
                    CType(c, MaskedTextBox).Text = String.Empty
                Case GetType(ProgressBar)
                    CType(c, ProgressBar).Value = 0
            End Select
        Next

        For Each c In Me.TabPage2.Controls
            Select Case c.GetType()
                Case GetType(TextBox)
                    CType(c, TextBox).Text = String.Empty
                Case GetType(ComboBox)
                    CType(c, ComboBox).Text = String.Empty
                Case GetType(CheckBox)
                    CType(c, CheckBox).Checked = False
                Case GetType(MaskedTextBox)
                    CType(c, MaskedTextBox).Text = String.Empty
                Case GetType(ProgressBar)
                    CType(c, ProgressBar).Value = 0
            End Select
        Next

    End Sub
End Class