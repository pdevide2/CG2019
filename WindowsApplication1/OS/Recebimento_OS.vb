Imports System.IO
Imports System.Globalization '//Para as alterações de Cultura
Imports System.Threading '//Para controle das Threads

Public Class Recebimento_OS
    Private Const EmptySpace As String = " "

    Dim _objModelFk As Object
    Public Property ObjModelFk() As Object
        Get
            Return _objModelFk
        End Get
        Set(ByVal value As Object)
            _objModelFk = value
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

    Private _orderby As String
    Public Property OrderBy() As String
        Get
            Return _orderby
        End Get
        Set(ByVal value As String)
            _orderby = value
        End Set
    End Property

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal _id_os As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtId_OS.Text = _id_os.ToString
        Carregar()

    End Sub
    Private Sub btnPesqOS_Click(sender As Object, e As EventArgs) Handles btnPesqOS.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_OS"
        Me.ObjModelFk.CampoId = "ID_OS"
        Me.ObjModelFk.CampoDesc = "DATA_MOVTO"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "DATA_MOVTO"
        Me.ObjModelFk.TituloTela = "Pesquisa de OS"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc & _
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where 1=1 "

        PesquisaFK(Me.ObjModelFk)

        txtId_OS.Text = Me.ObjModelFk.txtId.ToString

        PreencheDados_OS()
        Carregar()

        If dgvDados.RowCount > 0 Then
            btnAdicionar.Enabled = True
            btnAnexarLaudo.Enabled = True
            btnAnexarNFe.Enabled = True
            btnViewPDFLaudo.Enabled = True
            btnViewPDFNFe.Enabled = True

        Else
            btnAdicionar.Enabled = False
            btnAnexarLaudo.Enabled = False
            btnAnexarNFe.Enabled = False
            btnViewPDFLaudo.Enabled = False
            btnViewPDFNFe.Enabled = False

        End If

    End Sub
    Private Sub PreencheDados_OS()
        Try
            Dim bllGlobal As New BLL.GlobalBLL
            Dim sql As String

            sql = "select "
            sql += "ID_OS, CONVERT(VARCHAR,DATA_MOVTO,103) AS DATA_MOVTO, ID_LOJA_ORIGEM, "
            sql += "SIGLA_LOJA, NOME_LOJA, NF_TRANSP, SERIE_NF_TRANSP, CONVERT(VARCHAR,EMISSAO_NF_TRANSP,103) AS EMISSAO_NF_TRANSP, "
            sql += "ID_FORNECEDOR, SIGLA_FORNECEDOR, UTILIZA_NFTS, NOME_FORNECEDOR, ID_RESPONSAVEL_IDA, Responsavel, APELIDO_RESPONSAVEL, "
            sql += "STATUS_OS, DESC_STATUS "
            sql += "from VW_CG_OS "
            sql += "where ID_OS = " & txtId_OS.Text.ToString

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)

            If dt.Rows.Count > 0 Then

                txtDataOS.Text = dt(0)("DATA_MOVTO").ToString
                txtIdFornecedor.Text = dt(0)("ID_FORNECEDOR").ToString
                txtDescFornecedor.Text = dt(0)("NOME_FORNECEDOR").ToString

                txtNfTransp.Text = dt(0)("NF_TRANSP").ToString
                txtSerieNfTransp.Text = dt(0)("SERIE_NF_TRANSP").ToString
                txtEmissaoNfTransp.Text = dt(0)("EMISSAO_NF_TRANSP").ToString

                txtIdLojaOrigem.Text = dt(0)("ID_LOJA_ORIGEM").ToString
                txtDescLojaOrigem.Text = dt(0)("NOME_LOJA").ToString

                'Carrega combo de Tabela de Serviço de Fornecedores
                CarregaComboTabela()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub PesquisaFK(oPesqFk As DTO.PesquisaFK)
        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica(Me, oPesqFk)
        frm.Owner = Me
        frm.ShowDialog()

    End Sub

    Public Sub Carregar()
        Dim sql As String

        sql = "select PROTOCOLO, DATA_HORA, TEXTO, ID_OS"
        sql += " from CG_FOLLOW_UP "

        sql = "SELECT ITEM_ID, ID_EQUIPAMENTO, DESC_EQUIPAMENTO, SERIE, MODELO, "
        sql += "PREVISAO_RETORNO, DATA_RETORNO, DESC_DEFEITO, CONSERTO_OK, "
        sql += "NF_FORNEC, SERIE_NF_FORNEC, EMISSAO_NF_FORNEC, OBS_RETORNO, "
        sql += "ID_RESPONSAVEL_RET, Responsavel, ID_OS, GARANTIA, RECEBIDO, VALOR_CONSERTO,"
        sql += "CONFIG_GARANTIA, QTDE_DIAS_GARANTIA, DATA_INICIO_GARANTIA, DATA_TERMINO_GARANTIA, "
        sql += "LAUDO, OUTROS, MOTIVO_OUTROS, ID_TABELA "
        sql += "FROM VW_CG_OS_ITEM "

        Me.Comando = sql
        Me.ColunaFiltro = "ID_OS"
        Me.Filtro = " WHERE " & Me.ColunaFiltro & " = '" & txtId_OS.Text.ToString & "'"

        Me.OrderBy = " ORDER BY ITEM_ID ASC "

        'Declara as variáveis do Tipo Coluna
        Dim colItem_Id As DataGridViewTextBoxColumn
        Dim colId_Equipamento As DataGridViewTextBoxColumn
        Dim colDesc_Equipamento As DataGridViewTextBoxColumn
        Dim colSerie As DataGridViewTextBoxColumn
        Dim colModelo As DataGridViewTextBoxColumn
        Dim colPrevisao_Retorno As DataGridViewTextBoxColumn
        Dim colData_Retorno As DataGridViewTextBoxColumn
        Dim colDesc_Defeito As DataGridViewTextBoxColumn
        Dim colConserto_Ok As DataGridViewCheckBoxColumn
        Dim colNf_Fornec As DataGridViewTextBoxColumn
        Dim colSerie_Nf_Fornec As DataGridViewTextBoxColumn
        Dim colEmissao_Nf_Fornec As DataGridViewTextBoxColumn
        Dim colObs_Retorno As DataGridViewTextBoxColumn
        Dim colId_Responsavel_Ret As DataGridViewTextBoxColumn
        Dim colResponsavel As DataGridViewTextBoxColumn
        Dim colId_Os As DataGridViewTextBoxColumn

        Dim colGarantia As DataGridViewCheckBoxColumn
        Dim colRecebido As DataGridViewCheckBoxColumn
        Dim colValor_Conserto As DataGridViewTextBoxColumn

        Dim colConfigGarantia As DataGridViewCheckBoxColumn
        Dim colQtde_Dias_Garantia As DataGridViewTextBoxColumn
        Dim colData_Inicio_Garantia As DataGridViewTextBoxColumn
        Dim colData_Termino_Garantia As DataGridViewTextBoxColumn

        Dim colLaudo As DataGridViewCheckBoxColumn
        Dim colOutros As DataGridViewCheckBoxColumn
        Dim colMotivo_Outros As DataGridViewTextBoxColumn
        Dim colTabelaPreco As DataGridViewTextBoxColumn

        '*******>> Configura as colunas
        colItem_Id = New DataGridViewTextBoxColumn
        colItem_Id.HeaderText = "Item_Id"
        colItem_Id.Name = "Item_Id"

        colId_Equipamento = New DataGridViewTextBoxColumn
        colId_Equipamento.HeaderText = "Id_Equipamento"
        colId_Equipamento.Name = "Id_Equipamento"

        colDesc_Equipamento = New DataGridViewTextBoxColumn
        colDesc_Equipamento.HeaderText = "Desc_Equipamento"
        colDesc_Equipamento.Name = "Desc_Equipamento"

        colSerie = New DataGridViewTextBoxColumn
        colSerie.HeaderText = "Serie"
        colSerie.Name = "Serie"

        colModelo = New DataGridViewTextBoxColumn
        colModelo.HeaderText = "Modelo"
        colModelo.Name = "Modelo"

        colPrevisao_Retorno = New DataGridViewTextBoxColumn
        colPrevisao_Retorno.HeaderText = "Previsao_Retorno"
        colPrevisao_Retorno.Name = "Previsao_Retorno"

        colData_Retorno = New DataGridViewTextBoxColumn
        colData_Retorno.HeaderText = "Data_Retorno"
        colData_Retorno.Name = "Data_Retorno"

        colDesc_Defeito = New DataGridViewTextBoxColumn
        colDesc_Defeito.HeaderText = "Desc_Defeito"
        colDesc_Defeito.Name = "Desc_Defeito"

        colConserto_Ok = New DataGridViewCheckBoxColumn
        colConserto_Ok.HeaderText = "Conserto_Ok"
        colConserto_Ok.Name = "Conserto_Ok"

        colNf_Fornec = New DataGridViewTextBoxColumn
        colNf_Fornec.HeaderText = "Nf_Fornec"
        colNf_Fornec.Name = "Nf_Fornec"

        colSerie_Nf_Fornec = New DataGridViewTextBoxColumn
        colSerie_Nf_Fornec.HeaderText = "Serie_Nf_Fornec"
        colSerie_Nf_Fornec.Name = "Serie_Nf_Fornec"

        colEmissao_Nf_Fornec = New DataGridViewTextBoxColumn
        colEmissao_Nf_Fornec.HeaderText = "Emissao_Nf_Fornec"
        colEmissao_Nf_Fornec.Name = "Emissao_Nf_Fornec"

        colObs_Retorno = New DataGridViewTextBoxColumn
        colObs_Retorno.HeaderText = "Obs_Retorno"
        colObs_Retorno.Name = "Obs_Retorno"

        colId_Responsavel_Ret = New DataGridViewTextBoxColumn
        colId_Responsavel_Ret.HeaderText = "Id_Responsavel_Ret"
        colId_Responsavel_Ret.Name = "Id_Responsavel_Ret"

        colResponsavel = New DataGridViewTextBoxColumn
        colResponsavel.HeaderText = "Responsavel"
        colResponsavel.Name = "Responsavel"

        colId_Os = New DataGridViewTextBoxColumn
        colId_Os.HeaderText = "Id_Os"
        colId_Os.Name = "Id_Os"

        colGarantia = New DataGridViewCheckBoxColumn
        colGarantia.HeaderText = "Garantia"
        colGarantia.Name = "GARANTIA"

        colRecebido = New DataGridViewCheckBoxColumn
        colRecebido.HeaderText = "Recebido"
        colRecebido.Name = "RECEBIDO"

        colValor_Conserto = New DataGridViewTextBoxColumn
        colValor_Conserto.HeaderText = "Valor Conserto"
        colValor_Conserto.Name = "VALOR_CONSERTO"

        colConfigGarantia = New DataGridViewCheckBoxColumn
        colConfigGarantia.HeaderText = "Config. Garantia"
        colConfigGarantia.Name = "CONFIG_GARANTIA"

        colQtde_Dias_Garantia = New DataGridViewTextBoxColumn
        colQtde_Dias_Garantia.HeaderText = "Qtd. Dias Garantia"
        colQtde_Dias_Garantia.Name = "QTDE_DIAS_GARANTIA"

        colData_Inicio_Garantia = New DataGridViewTextBoxColumn
        colData_Inicio_Garantia.HeaderText = "Inicio Garantia"
        colData_Inicio_Garantia.Name = "DATA_INICIO_GARANTIA"

        colData_Termino_Garantia = New DataGridViewTextBoxColumn
        colData_Termino_Garantia.HeaderText = "Término Garantia"
        colData_Termino_Garantia.Name = "DATA_TERMINO_GARANTIA"

        colLaudo = New DataGridViewCheckBoxColumn
        colLaudo.HeaderText = "Laudo?"
        colLaudo.Name = "Laudo"

        colOutros = New DataGridViewCheckBoxColumn
        colOutros.HeaderText = "Outros(especificar)?"
        colOutros.Name = "Outros"

        colMotivo_Outros = New DataGridViewTextBoxColumn
        colMotivo_Outros.HeaderText = "Motivo Outros"
        colMotivo_Outros.Name = "motivo_outros"

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
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colItem_Id, colId_Equipamento, colDesc_Equipamento,
                                                            colSerie, colModelo, colPrevisao_Retorno,
                                                            colData_Retorno, colDesc_Defeito, colConserto_Ok,
                                                            colNf_Fornec, colSerie_Nf_Fornec,
                                                            colEmissao_Nf_Fornec, colObs_Retorno,
                                                            colId_Responsavel_Ret, colResponsavel, colId_Os,
                                                            colGarantia, colRecebido, colValor_Conserto,
                                                            colConfigGarantia, colQtde_Dias_Garantia,
                                                            colData_Inicio_Garantia, colData_Termino_Garantia,
                                                            colLaudo, colOutros, colMotivo_Outros, colTabelaPreco})
        'dgvDados.DataSource = myRow
        Popula_Grid()

        dgvDados.Columns(0).ReadOnly = True ' coluna do Botão
        For ixx = 1 To 26

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
        dgvDados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDados.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDados.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDados.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDados.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

    End Sub

    Private Sub Popula_Grid()
        'Faz a Query no banco e retorna uma Lista de Array do Comando SQL
        Dim myRow As ArrayList
        myRow = BLL.GlobalBLL.PesquisarFkListaBLL(Me.Comando & Me.Filtro & Me.OrderBy)

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
                        myRow(ixx)(16).ToString,
                        myRow(ixx)(17).ToString,
                        myRow(ixx)(18).ToString,
                        myRow(ixx)(19).ToString,
                        myRow(ixx)(20).ToString,
                        myRow(ixx)(21).ToString,
                        myRow(ixx)(22).ToString,
                        myRow(ixx)(23).ToString,
                        myRow(ixx)(24).ToString,
                        myRow(ixx)(25).ToString,
                        myRow(ixx)(26).ToString}

            dgvDados.Rows.Add(strLinha)

        Next

    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

        Try
            If String.IsNullOrEmpty(txtId_OS.Text) Then
                MessageBox.Show("Selecione uma OS primeiro para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If CInt(txtId_OS.Text) = 0 Then
                    MessageBox.Show("Selecione uma OS primeiro para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            dgvDados.Enabled = False
            'Me.Panel1.Enabled = True
            lblPanel.Text = "Modo Edição"

            TabControl1.TabPages(0).Enabled = True
            TabControl1.TabPages(1).Enabled = True
            TabControl1.TabPages(2).Enabled = True

            btnAdicionar.Enabled = False
            btnAnexarLaudo.Enabled = False
            btnAnexarNFe.Enabled = False
            btnViewPDFLaudo.Enabled = False
            btnViewPDFNFe.Enabled = False


            btnSalvar.Enabled = True
            btnDesfazer.Enabled = True

            btnPesqResponsavel.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
        'If e.ColumnIndex = 0 Then
        '    Edita_dados(dgvDados.CurrentRow)
        'End If
    End Sub

    Private Sub Edita_dados(ByVal _linhaGrid As DataGridViewRow)

        dgvDados.Enabled = False
        'Me.Panel1.Enabled = True
        lblPanel.Text = "Modo Edição"
        TabControl1.TabPages(0).Enabled = True
        TabControl1.TabPages(1).Enabled = True
        TabControl1.TabPages(2).Enabled = True


        btnAdicionar.Enabled = False
        btnAnexarLaudo.Enabled = False
        btnAnexarNFe.Enabled = False
        btnViewPDFLaudo.Enabled = False
        btnViewPDFNFe.Enabled = False


        btnDesfazer.Enabled = True
        btnSalvar.Enabled = True
        btnPesqResponsavel.Enabled = True

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        'dgvDados.CurrentRow.Cells(2).Value = Trim(txtTexto.Text.ToString)

        Gravar()


    End Sub

    Private Sub Gravar()
        Dim bll As New BLL.Os_retornoBLL
        Dim objRetorno_OS As New DTO.Cg_os_retorno

        Try

            If Not ValidaCampos() Then
                Exit Sub
            End If


            'Carrega os dados no objeto Model para passagem de parametro
            objRetorno_OS.Id_os = CInt(txtId_OS.Text)
            objRetorno_OS.Conserto_ok = chkConserto.Checked

            objRetorno_OS.Laudo = chkLaudo.Checked
            objRetorno_OS.Outros = chkOutros.Checked
            objRetorno_OS.Motivo_Outros = txtOutros.Text

            If String.IsNullOrEmpty(txtDataRetorno.Text) Or txtDataRetorno.Text = " " Then
                objRetorno_OS.Data_retorno = vbNullString
            Else
                objRetorno_OS.Data_retorno = CDate(txtDataRetorno.Text)
            End If

            objRetorno_OS.Desc_defeito = txtDescDefeito.Text

            If String.IsNullOrEmpty(txtEmissaoNFe.Text) Or txtEmissaoNFe.Text = " " Then
                objRetorno_OS.Emissao_nf_fornec = vbNullString
            Else
                objRetorno_OS.Emissao_nf_fornec = CDate(txtEmissaoNFe.Text)
            End If

            objRetorno_OS.Id_equipamento = CInt(txtIdEquipamento.Text)
            objRetorno_OS.Id_responsavel_ret = CInt(txtIdResponsavel.Text)
            objRetorno_OS.Item_id = CInt(txtItemId.Text)
            objRetorno_OS.Nf_fornec = txtNFe.Text
            objRetorno_OS.Obs_retorno = txtObs.Text
            objRetorno_OS.Serie_nf_fornec = txtSerieNFe.Text

            objRetorno_OS.User_upd = ACE_CODIGO
            objRetorno_OS.Data_upd = Hoje()

            objRetorno_OS.Garantia = chkGarantia.Checked

            objRetorno_OS.Valor_Conserto = Convert.ToDouble(Replace(txtValorConserto.Text, ".", ","))

            'Dados da Tabpage Controle de Garantia
            objRetorno_OS.Config_Garantia = chkConfigGarantia.Checked
            objRetorno_OS.Qtde_Dias_Garantia = spnDias.Value
            objRetorno_OS.Data_Inicio_Garantia = CDate(txtInicio.Text)
            objRetorno_OS.Data_Termino_Garantia = CDate(txtFinal.Text)
            objRetorno_OS.TabelaServicos = cboTabelaServico.Text

            bll.GravarBLL(1, objRetorno_OS)

            'Se chkSerie estiver clicado, atualiza tabela CG_EQUIPAMENTO_HISTORICO_SERIE
            GravaSerie()


            'MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'flagAcao = Operacao.Consulta
            dgvDados.Enabled = True
            btnAdicionar.Enabled = True
            btnAnexarLaudo.Enabled = True
            btnAnexarNFe.Enabled = True
            btnViewPDFLaudo.Enabled = True
            btnViewPDFNFe.Enabled = True

            btnSalvar.Enabled = False
            btnDesfazer.Enabled = False
            btnPesqResponsavel.Enabled = False

            'Se gravou tudo OK! 
            Dim linhaAtual As Integer = dgvDados.CurrentRow.Index
            Carregar()
            dgvDados.CurrentCell = dgvDados.Item(0, linhaAtual)

            TabControl1.TabPages(0).Enabled = False
            TabControl1.TabPages(1).Enabled = False
            TabControl1.TabPages(2).Enabled = False

            lblPanel.Text = "Modo Leitura"


        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dgvDados.Enabled = True
            lblPanel.Text = "Modo Leitura"

        End Try
    End Sub


    Private Sub dgvDados_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellEnter
        'dgvDados.Columns.AddRange(New DataGridViewColumn()
        ' {colItem_Id, colId_Equipamento, colDesc_Equipamento, colSerie, colModelo, colPrevisao_Retorno, colData_Retorno, colDesc_Defeito, colConserto_Ok, colNf_Fornec, colSerie_Nf_Fornec, colEmissao_Nf_Fornec, colObs_Retorno, colId_Responsavel_Ret, colResponsavel, colId_Os})
        '      0            1                     2                3        4             5                    6                7                8              9              10                   11                    12                  13               14            15     
        txtItemId.Text = dgvDados.CurrentRow.Cells(0).Value
        txtIdEquipamento.Text = dgvDados.CurrentRow.Cells(1).Value
        txtDescEquipamento.Text = dgvDados.CurrentRow.Cells(2).Value

        txtSerie.Text = dgvDados.CurrentRow.Cells(3).Value
        txtModelo.Text = dgvDados.CurrentRow.Cells(4).Value
        txtPrevisaoRetorno.Text = dgvDados.CurrentRow.Cells(5).Value

        txtDataRetorno.CustomFormat = " "
        txtDataRetorno.Format = DateTimePickerFormat.Custom
        txtDataRetorno.Text = ""



        If Not String.IsNullOrEmpty(dgvDados.CurrentRow.Cells(6).Value) Then

            txtDataRetorno.CustomFormat = "dd/MM/yyyy"

            txtDataRetorno.Text = dgvDados.CurrentRow.Cells(6).Value

        End If

        'txtDataRetorno.Enabled = Panel1.Enabled
        If TabControl1.TabPages(0).Enabled = True Then

            lblPanel.Text = "Modo Edição"
            TabControl1.TabPages(1).Enabled = True
            TabControl1.TabPages(2).Enabled = True


        Else
            lblPanel.Text = "Modo Leitura"
            TabControl1.TabPages(1).Enabled = False
            TabControl1.TabPages(2).Enabled = False

        End If

        txtDescDefeito.Text = dgvDados.CurrentRow.Cells(7).Value
        chkConserto.Checked = CBool(dgvDados.CurrentRow.Cells(8).Value)
        chkLaudo.Checked = CBool(dgvDados.CurrentRow.Cells("laudo").Value)
        chkOutros.Checked = CBool(dgvDados.CurrentRow.Cells("outros").Value)
        txtOutros.Text = dgvDados.CurrentRow.Cells("motivo_outros").Value

        If Not String.IsNullOrEmpty(dgvDados.CurrentRow.Cells("ID_TABELA").Value) Then
            cboTabelaServico.Text = dgvDados.CurrentRow.Cells("ID_TABELA").Value
        End If

        chkGarantia.Checked = CBool(dgvDados.CurrentRow.Cells(16).Value)
        chkRetorno.Checked = CBool(dgvDados.CurrentRow.Cells(17).Value)

        txtObs.Text = dgvDados.CurrentRow.Cells(12).Value
        txtIdResponsavel.Text = dgvDados.CurrentRow.Cells(13).Value
        txtDescResponsavel.Text = dgvDados.CurrentRow.Cells(14).Value

        txtNFe.Text = dgvDados.CurrentRow.Cells(9).Value
        txtSerieNFe.Text = dgvDados.CurrentRow.Cells(10).Value

        txtEmissaoNFe.CustomFormat = " "
        txtEmissaoNFe.Format = DateTimePickerFormat.Custom

        txtEmissaoNFe.Text = ""

        If Not String.IsNullOrEmpty(dgvDados.CurrentRow.Cells(11).Value) Then

            txtEmissaoNFe.CustomFormat = "dd/MM/yyyy"

            txtEmissaoNFe.Text = dgvDados.CurrentRow.Cells(11).Value

        End If


        txtValorConserto.Text = dgvDados.CurrentRow.Cells(18).Value

        If TabControl1.SelectedIndex = 1 Then 'Tab - alterar número serie
            Atualiza_Dados_Serie()
        End If

        'Carrega os dados gravados da Tabpage Controle de Garantia
        chkConfigGarantia.Checked = Convert.ToBoolean(dgvDados.CurrentRow.Cells(19).Value)
        spnDias.Value = Convert.ToInt32(dgvDados.CurrentRow.Cells(20).Value)

        If Not String.IsNullOrEmpty(dgvDados.CurrentRow.Cells(21).Value) Then
            txtInicio.Text = Mid(Trim(dgvDados.CurrentRow.Cells(21).Value.ToString), 1, 10)
        Else
            txtInicio.Text = ""
        End If

        If Not String.IsNullOrEmpty(dgvDados.CurrentRow.Cells(22).Value) Then
            txtFinal.Text = Mid(Trim(dgvDados.CurrentRow.Cells(22).Value.ToString), 1, 10)
        Else
            txtFinal.Text = ""
        End If

        'txtDataHora.Text = dgvDados.CurrentRow.Cells(1).Value
        'txtTexto.Text = dgvDados.CurrentRow.Cells(2).Value
    End Sub

    Private Sub txtDataRetorno_ValueChanged(sender As Object, e As EventArgs) Handles txtDataRetorno.ValueChanged

        ' Verifica se o texto é um espaço em branco

        If UCase(Trim(Me.ActiveControl.Name)) = "TXTDATARETORNO" And txtDataRetorno.Text = EmptySpace Then

            ' Define o formato como Shot (formato DD-MM-YYYY) e dá um
            ' enter para fechar (CloseUp) da janela que está aberta

            Me.txtDataRetorno.Format = DateTimePickerFormat.Short

            SendKeys.Send("{ENTER}")

        End If

    End Sub

    Private Sub txtEmissaoNFe_ValueChanged(sender As Object, e As EventArgs) Handles txtEmissaoNFe.ValueChanged
        ' Verifica se o texto é um espaço em branco
        If UCase(Trim(Me.ActiveControl.Name)) = "TXTEMISSAONFE" And txtEmissaoNFe.Text = EmptySpace Then

            ' Define o formato como Shot (formato DD-MM-YYYY) e dá um
            ' enter para fechar (CloseUp) da janela que está aberta

            Me.txtEmissaoNFe.Format = DateTimePickerFormat.Short

            SendKeys.Send("{ENTER}")

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
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc & _
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where 1=1 "

        PesquisaFK(Me.ObjModelFk)

        txtIdResponsavel.Text = Me.ObjModelFk.txtId.ToString
        txtDescResponsavel.Text = Me.ObjModelFk.txtDesc
    End Sub

    Private Sub btnDesfazer_Click(sender As Object, e As EventArgs) Handles btnDesfazer.Click
        'Retorna para o modo consulta
        dgvDados.Enabled = True
        btnAdicionar.Enabled = True
        btnAnexarLaudo.Enabled = True
        btnAnexarNFe.Enabled = True
        btnViewPDFLaudo.Enabled = True
        btnViewPDFNFe.Enabled = True

        btnSalvar.Enabled = False
        btnPesqResponsavel.Enabled = False
        btnDesfazer.Enabled = False
        'Me.Panel1.Enabled = False
        TabControl1.TabPages(0).Enabled = False
        TabControl1.TabPages(1).Enabled = False
        TabControl1.TabPages(2).Enabled = False

        lblPanel.Text = "Modo Leitura"

    End Sub

    Private Sub btnAnexarNFe_Click(sender As Object, e As EventArgs) Handles btnAnexarNFe.Click

        ContextMenuStrip1.Show(btnAnexarNFe, 0, btnAnexarNFe.Height)

    End Sub

    Private Sub Grava_xml_nf_fornec(_filename As String, _idOs As Integer, _itemId As Integer, _idEquipamento As Integer)
        Try
            Dim sqlEmpty As String, sql As String = ""
            sqlEmpty = "update CG_OS_ITEM SET XML_NF_FORNEC = '{0}' WHERE ID_OS={1} AND ITEM_ID={2} AND ID_EQUIPAMENTO={3}"

            Dim strXml = TxtToString(_filename)
            sql = sqlEmpty
            sql = String.Format(sql, strXml, _idOs, _itemId, _idEquipamento)

            Dim bllGlobal As New BLL.GlobalBLL
            bllGlobal.GravarGenericoBLL(sql)
            MessageBox.Show("Arquivo anexado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAnexarLaudo_Click(sender As Object, e As EventArgs) Handles btnAnexarLaudo.Click
        Dim strfilename As String = ""
        ofd2.FileName = strfilename
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

            Dim intIdOs As Integer = CInt(txtId_OS.Text)
            Dim intItemId As Integer = CInt(dgvDados.CurrentRow.Cells(0).Value)
            Dim intIdEquipamento As Integer = CInt(dgvDados.CurrentRow.Cells(1).Value)

            Dim mensagem As String = "Confirma importação do PDF de LAUDO para a OS: {0} - Item Id: {1} - Id Equipamento: {2}?"
            mensagem = String.Format(mensagem, intIdOs, intItemId, intIdEquipamento)

            If MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Grava_PDF_Laudo(strfilename, intIdOs, intItemId, intIdEquipamento)
            End If

        End If

    End Sub

    Private Sub Grava_PDF_Laudo(_filename As String, _idOs As Integer, _itemId As Integer, _idEquipamento As Integer)

        Dim bll As New BLL.Os_retornoBLL
        Dim objRetorno_OS_PDF As New DTO.Cg_os_retorno_PDF
        Try

            Dim filebyte() As Byte = Nothing
            filebyte = System.IO.File.ReadAllBytes(ofd2.FileName)

            'Carrega os dados no objeto Model para passagem de parametro
            objRetorno_OS_PDF.Id_os = _idOs
            objRetorno_OS_PDF.Id_equipamento = _idEquipamento
            objRetorno_OS_PDF.Item_id = _itemId
            objRetorno_OS_PDF.Laudo_Fornec = filebyte

            bll.GravarPDF(1, objRetorno_OS_PDF)

            MessageBox.Show("Laudo anexado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Catch ex As Exception
            MessageBox.Show("Erro ao anexar Laudo: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try

    End Sub

    Public Function ValidaCampos() As Object
        Dim msg As String = ""
        Try

            If txtDataRetorno.Text = " " Or String.IsNullOrEmpty(txtDataRetorno.Text) Then
                msg += "Campo Data do Retorno é obrigatório! " & vbCr
            End If

            If String.IsNullOrEmpty(txtDescDefeito.Text) Or Trim(txtDescDefeito.Text) = "" Then
                msg += "Campo Descrição do Defeito é obrigatório! " & vbCr
            End If

            If String.IsNullOrEmpty(txtObs.Text) Or Trim(txtObs.Text) = "" Then
                msg += "Campo Observação é obrigatório! " & vbCr
            End If

            If String.IsNullOrEmpty(txtIdResponsavel.Text) Then
                msg += "Atenção obrigatório informar o Responsável" & vbCr
            Else
                If CInt(txtIdResponsavel.Text) <= 0 Then
                    msg += "Atenção obrigatório informar o Responsável" & vbCr
                End If
            End If

            If Not String.IsNullOrEmpty(msg) Then
                Throw New Exception(msg)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    'Formatação do campo valor para aceitar somente numeros e ponto decimal
    Private Sub txtValorConserto_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumerosMoeda(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub

    Private Sub txtValorConserto_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExportaPDFLaudo()
        Try

            Dim intIdOs As Integer = CInt(txtId_OS.Text)
            Dim intItemId As Integer = CInt(dgvDados.CurrentRow.Cells(0).Value)
            Dim intIdEquipamento As Integer = CInt(dgvDados.CurrentRow.Cells(1).Value)

            Dim sqlVerifica As String, sqlEmpty As String, sql As String = "", sql2 As String = ""
            sqlEmpty = "select LAUDO_FORNEC from cg_os_item where id_os = {0} and ITEM_ID={1} and ID_EQUIPAMENTO = {2}"
            sqlVerifica = "select CAST(CASE WHEN LAUDO_FORNEC IS NULL THEN 0 ELSE 1 END AS BIT) AS EXISTE " & _
                            "from cg_os_item where id_os = {0} and ITEM_ID={1} and ID_EQUIPAMENTO = {2}"
            'Dim strXml = TxtToString(_filename)
            sql = sqlEmpty
            sql = String.Format(sql, intIdOs, intItemId, intIdEquipamento)

            sql2 = sqlVerifica
            sql2 = String.Format(sql2, intIdOs, intItemId, intIdEquipamento)

            Dim bllGlobal As New BLL.GlobalBLL

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql2)

            Dim blnRetorno As Boolean = False
            If dt.Rows.Count > 0 Then

                blnRetorno = dt(0)("EXISTE")

            End If

            If blnRetorno = True Then
                'MessageBox.Show("Gravação Concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Dim arqpdf_name As String = "pdf_laudo_" & Convert.ToString(DateTime.Now.ToFileTime) & ".pdf"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewPDFLaudo.Click
        ExportaPDFLaudo()
    End Sub

    Private Sub Botao_AnexarNFe_XML()

        Dim strfilename As String = ""
        ofd.FileName = strfilename
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

            Dim intIdOs As Integer = CInt(txtId_OS.Text)
            Dim intItemId As Integer = CInt(dgvDados.CurrentRow.Cells(0).Value)
            Dim intIdEquipamento As Integer = CInt(dgvDados.CurrentRow.Cells(1).Value)

            Dim mensagem As String = "Confirma importação do arquivo para a OS: {0} - Item Id: {1} - Id Equipamento: {2}?"
            mensagem = String.Format(mensagem, intIdOs, intItemId, intIdEquipamento)

            If MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Grava_xml_nf_fornec(strfilename, intIdOs, intItemId, intIdEquipamento)
            End If

        End If

    End Sub

    Private Sub AnexarNFeEmXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnexarNFeEmXMLToolStripMenuItem.Click
        Botao_AnexarNFe_XML()
    End Sub

    Private Sub Botao_AnexarNFe_PDF(_colunaSQL As String)
        'MessageBox.Show("Selecionou PDF", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

            Dim intIdOs As Integer = CInt(txtId_OS.Text)
            Dim intItemId As Integer = CInt(dgvDados.CurrentRow.Cells(0).Value)
            Dim intIdEquipamento As Integer = CInt(dgvDados.CurrentRow.Cells(1).Value)


            Dim mensagem As String = "Confirma importação do PDF de NFe para OS: {0}/Item ID {1}/Id Equipamento {2}?"
            mensagem = String.Format(mensagem, intIdOs, intItemId, intIdEquipamento)

            If MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Grava_PDF(_colunaSQL, strfilename, intIdOs, intItemId, intIdEquipamento)
            End If

        End If

    End Sub

    Private Sub AnexarNFeEmPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnexarNFeEmPDFToolStripMenuItem.Click
        Botao_AnexarNFe_PDF("PDF_NF_FORNEC")
    End Sub

    Private Sub ExportaPDFNFe()
        Try

            Dim intIdOs As Integer = CInt(txtId_OS.Text)
            Dim intItemId As Integer = CInt(dgvDados.CurrentRow.Cells(0).Value)
            Dim intIdEquipamento As Integer = CInt(dgvDados.CurrentRow.Cells(1).Value)

            Dim sqlVerifica As String, sqlEmpty As String, sql As String = "", sql2 As String = ""
            sqlEmpty = "select PDF_NF_FORNEC from cg_os_item where id_os = {0} and ITEM_ID={1} and ID_EQUIPAMENTO = {2}"
            sqlVerifica = "select CAST(CASE WHEN PDF_NF_FORNEC IS NULL THEN 0 ELSE 1 END AS BIT) AS EXISTE " & _
                            "from cg_os_item where id_os = {0} and ITEM_ID={1} and ID_EQUIPAMENTO = {2}"
            'Dim strXml = TxtToString(_filename)
            sql = sqlEmpty
            sql = String.Format(sql, intIdOs, intItemId, intIdEquipamento)

            sql2 = sqlVerifica
            sql2 = String.Format(sql2, intIdOs, intItemId, intIdEquipamento)

            Dim bllGlobal As New BLL.GlobalBLL

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql2)

            Dim blnRetorno As Boolean = False
            If dt.Rows.Count > 0 Then

                blnRetorno = dt(0)("EXISTE")

            End If

            If blnRetorno = True Then
                'MessageBox.Show("Gravação Concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Dim arqpdf_name As String = "pdf_nf_fornec_" & Convert.ToString(DateTime.Now.ToFileTime) & ".pdf"
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

    Private Sub btnViewPDFNFe_Click(sender As Object, e As EventArgs) Handles btnViewPDFNFe.Click
        ExportaPDFNFe()
    End Sub

    Private Sub Grava_PDF(_colunaSQL As String, _filename As String, _idOs As Integer, _
                          _idItem As Integer, _idEquipamento As Integer)

        Dim bll As New BLL.Os_retornoBLL

        If _colunaSQL = "PDF_NF_FORNEC" Then
            Dim objOS_PDF_NF_FORNEC As New DTO.Cg_os_PDF_NF_Fornec

            Try

                Dim filebyte() As Byte = Nothing
                filebyte = System.IO.File.ReadAllBytes(ofd2.FileName)

                'Carrega os dados no objeto Model para passagem de parametro
                objOS_PDF_NF_FORNEC.Id_os = _idOs
                objOS_PDF_NF_FORNEC.Item_id = _idItem
                objOS_PDF_NF_FORNEC.Id_equipamento = _idEquipamento
                objOS_PDF_NF_FORNEC.NF_Fornec = filebyte

                bll.GravarPDF_NF_FORNEC(1, objOS_PDF_NF_FORNEC)

                MessageBox.Show("PDF anexado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


            Catch ex As Exception
                MessageBox.Show("Erro ao anexar PDF: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally


            End Try
        End If

    End Sub


    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        'MessageBox.Show("selecionei pagina " & Convert.ToString(TabControl1.SelectedIndex), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If TabControl1.SelectedIndex = 1 Then 'Tab - alterar número serie
            Atualiza_Dados_Serie()
        End If
        If TabControl1.SelectedIndex = 2 Then 'Tab - controle de garantia
            Atualiza_Dados_Garantia()
        End If

    End Sub

    Private Sub Atualiza_Dados_Serie()

        If String.IsNullOrEmpty(txtId_OS.Text) Then
            Exit Sub
        End If

        Dim intIdOs As Integer = CInt(txtId_OS.Text)
        Dim intItemId As Integer = CInt(dgvDados.CurrentRow.Cells(0).Value)
        Dim intIdEquipamento As Integer = CInt(dgvDados.CurrentRow.Cells(1).Value)

        Dim sqlEmpty As String, sql As String = ""
        sqlEmpty = "EXEC spPesquisaSeriePos @id_equipamento = {0}, @id_os = {1}, @item_id = {2} "
        'Dim strXml = TxtToString(_filename)
        sql = sqlEmpty
        sql = String.Format(sql, intIdEquipamento, intIdOs, intItemId)


        Dim bllGlobal As New BLL.GlobalBLL

        Dim dt As DataTable
        dt = bllGlobal.SqlExecDT(sql)

        If dt.Rows.Count > 0 Then

            ChkSerie.Checked = dt(0)("MUDOU_SERIE")
            If ChkSerie.Checked = True Then
                ChkSerie.Text = "Série já Alterada"
            Else
                ChkSerie.Text = "Alterar Nº de Série?"
            End If
            txtDataAlteracao.Text = dt(0)("DATA_ALTERACAO")
            txtMotivo.Text = dt(0)("MOTIVO_ALTERACAO")
            txtSerieAnterior.Text = dt(0)("SERIE_ANTERIOR")
            txtSerieNova.Text = dt(0)("SERIE_NOVA")

        End If

    End Sub

    Private Sub Recebimento_OS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TabControl1.TabPages(0).Enabled = False
        TabControl1.TabPages(1).Enabled = False
        TabControl1.TabPages(2).Enabled = False


    End Sub

    Private Sub GravaSerie()
        If ChkSerie.Checked = False Then
            Exit Sub
        End If

        Try

            '** Define a Chave da Tabela CG_EQUIPAMENTO_HISTORICO_SERIE
            Dim intIdOs As Integer = CInt(txtId_OS.Text)
            Dim intItemId As Integer = CInt(dgvDados.CurrentRow.Cells(0).Value)
            Dim intIdEquipamento As Integer = CInt(dgvDados.CurrentRow.Cells(1).Value)
            '** Atributos da tabela CG_EQUIPAMENTO_HISTORICO_SERIE
            Dim dtAlteracao As Date = CDate(txtDataAlteracao.Text)
            Dim strMotivo As String = txtMotivo.Text
            Dim strSerieAnterior As String = txtSerieAnterior.Text
            Dim strSerieNova As String = txtSerieNova.Text

            Dim bll As New BLL.GlobalBLL
            Dim sql As String = ""
            Dim sqlEmpty As String = "exec spGravaCg_equipamento_historico_serie " & _
                                     "@ID_OS={0}, @ITEM_ID={1}, @ID_EQUIPAMENTO={2}, " & _
                                     "@DATA_ALTERACAO='{3}', @MOTIVO_ALTERACAO='{4}', " & _
                                     "@SERIE_ANTERIOR='{5}', @SERIE_NOVA='{6}'"

            sql = sqlEmpty
            sql = String.Format(sql, intIdOs, intItemId, intIdEquipamento, _
                                dtAlteracao, strMotivo, strSerieAnterior, strSerieNova)

            bll.GravarGenericoBLL(sql)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Atualiza_Dados_Garantia()

        If String.IsNullOrEmpty(txtId_OS.Text) Then
            Exit Sub
        End If

        If chkConfigGarantia.Checked = True Then
            Dim dtInicio As Date = CDate(txtDataRetorno.Text)
            txtInicio.Text = Mid(Trim(dtInicio.ToString), 1, 10)
            txtFinal.Text = Mid(SomaData("D", Convert.ToInt32(spnDias.Text), dtInicio).ToString, 1, 10)
        Else
            txtInicio.Text = ""
            txtFinal.Text = ""
        End If

    End Sub

    Private Sub spnDias_ValueChanged(sender As Object, e As EventArgs) Handles spnDias.ValueChanged
        Atualiza_Dados_Garantia()
    End Sub

    Private Sub chkConfigGarantia_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfigGarantia.CheckedChanged
        'Ao selecionar, verificar no cadastro do Fornecedor 
        'a quantidade de dias para OS e preencher o spinner
        If chkConfigGarantia.Checked = False Then
            Exit Sub
        End If
        Atualiza_Qtde_Dias_Fornecedor()
        Atualiza_Dados_Garantia()
    End Sub

    Private Sub Atualiza_Qtde_Dias_Fornecedor()
        Try
            Dim intIdFornecedor As Integer = Convert.ToInt32(txtIdFornecedor.Text)

            Dim sqlEmpty As String, sql As String = ""
            sqlEmpty = "select ID_FORNECEDOR, ISNULL(GARANTIA_ASSISTENCIA,0) AS GARANTIA_ASSISTENCIA, " & _
                        "ISNULL(GARANTIA_AQUISICAO,0) AS GARANTIA_AQUISICAO " & _
                        "from CG_FORNECEDOR where ID_FORNECEDOR = {0} "
            'Dim strXml = TxtToString(_filename)
            sql = sqlEmpty
            sql = String.Format(sql, intIdFornecedor)

            Dim bllGlobal As New BLL.GlobalBLL

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)

            spnDias.Value = 0
            If dt.Rows.Count > 0 Then

                spnDias.Value = dt(0)("GARANTIA_ASSISTENCIA")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkLaudo_CheckedChanged(sender As Object, e As EventArgs) Handles chkLaudo.CheckedChanged
        If chkConserto.Checked Or chkOutros.Checked Then
            chkLaudo.Checked = False
        End If
    End Sub

    Private Sub chkOutros_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutros.CheckedChanged
        If chkConserto.Checked Or chkLaudo.Checked Then
            chkOutros.Checked = False
            txtOutros.Text = ""
        End If
        If Not chkOutros.Checked Then
            txtOutros.Text = ""
        End If
    End Sub

    Private Sub chkConserto_CheckedChanged(sender As Object, e As EventArgs) Handles chkConserto.CheckedChanged
        If chkOutros.Checked Or chkLaudo.Checked Then
            chkConserto.Checked = False
        End If
    End Sub
    Private Sub CarregaComboTabela()

        Try
            Dim bllGlobal As New BLL.GlobalBLL

            cboTabelaServico.DataSource = Nothing
            cboTabelaServico.DisplayMember = Nothing
            cboTabelaServico.Items.Clear()

            Dim sql As String
            sql = "Select id_tabela "
            sql += " From CG_TABELA_SERVICOS_FORNECEDOR where id_fornecedor = " & txtIdFornecedor.Text & " order by ID_TABELA"

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)

            cboTabelaServico.DataSource = dt
            cboTabelaServico.DisplayMember = "ID_TABELA"
            cboTabelaServico.ValueMember = "ID_TABELA"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class