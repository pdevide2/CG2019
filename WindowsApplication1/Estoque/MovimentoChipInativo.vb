

Public Class MovimentoChipInativo
    Public _formPai As Object = Me

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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub

    Public Sub Carregar()
        Dim sql As String
        sql = "SELECT 'Visualizar' as botao, "
        sql += " ID_CHIP, SIMID, ID_OPERADORA, DESC_OPERADORA, QTD, VALOR, ID_ROMANEIO, UNIQUE_KEYID "
        sql += " FROM VW_CG_MOVIMENTO_CHIP_INATIVO_ITEM "
        Me.Comando = sql
        Me.ColunaFiltro = "ID_ROMANEIO"
        Me.Filtro = " WHERE " & Me.ColunaFiltro & " = '" & txtCodigo.Text.ToString & "'"

        'Declara as variáveis do Tipo Coluna
        Dim colBotao As DataGridViewButtonColumn
        Dim colId_Romaneio As DataGridViewTextBoxColumn
        Dim colUnique_KeyId As DataGridViewTextBoxColumn
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

        'coluna Id_romaneio
        colId_Romaneio = New DataGridViewTextBoxColumn
        colId_Romaneio.HeaderText = "Romaneio nº"
        colId_Romaneio.Name = "ID_ROMANEIO"

        'coluna Unique_Keyid
        colUnique_KeyId = New DataGridViewTextBoxColumn
        colUnique_KeyId.HeaderText = "Unique #Id"
        colUnique_KeyId.Name = "UNIQUE_KEYID"

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
                                                            colDescOperadora, colQtd, colValor, colId_Romaneio, colUnique_KeyId})

        'dgvDados.DataSource = myRow
        Popula_Grid()

        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão
        For ixx = 1 To 8
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
                        myRow(ixx)(4).ToString, _
                        myRow(ixx)(5).ToString, _
                        myRow(ixx)(6).ToString, _
                        myRow(ixx)(7).ToString, _
                        myRow(ixx)(8).ToString()}

            dgvDados.Rows.Add(strLinha)

        Next

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()

        Me.PkString = False
        Me.Tabela = "CG_MOVIMENTO_CHIP_INATIVO" 'Nome da tabela no SQL
        Me.View = "VW_CG_MOVIMENTO_CHIP_INATIVO"
        Me.TabelaFilha = "CG_MOVIMENTO_CHIP_INATIVO_ITEM"
        Me.Modulo = 43 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_movimento_chip_inativo
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

            txtCodigo.Text = Me.KeyId.ToString
            txtIdLoja.Text = Me.LinhaGrid.Cells("ID_LOJA_ORIGEM").Value.ToString
            txtDescLoja.Text = Me.LinhaGrid.Cells("NOME_ORIGEM").Value.ToString
            txtIdLojaDestino.Text = Me.LinhaGrid.Cells("ID_LOJA_DESTINO").Value.ToString
            txtDescLojaDestino.Text = Me.LinhaGrid.Cells("NOME_DESTINO").Value.ToString
            txtIdResponsavel.Text = Me.LinhaGrid.Cells("ID_RESPONSAVEL").Value.ToString
            txtDescResponsavel.Text = Me.LinhaGrid.Cells("RESPONSAVEL").Value.ToString
            txtDataMovto.Text = Me.LinhaGrid.Cells("DATA_MOVTO").Value.ToString

            Carregar()
        End If
    End Sub

    Public Overrides Function ValidaCampos() As Object
        Dim blnRet As Boolean
        txtCodigo.Tag = "Código Romaneio"
        txtIdLoja.Tag = "Código da Loja"
        txtDataMovto.Tag = "Data do Movimento"

        blnRet = MyBase.ValidaCampos()

        If blnRet Then
            If dgvDados.RowCount = 0 Then
                MessageBox.Show("Obrigatório informar Chip para entrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        Dim bllPai As New BLL.Movimento_chip_inativoBLL
        Dim objMovimentoChipInativo As New DTO.Cg_movimento_chip_inativo

        Dim bllFilha As New BLL.Movimento_chip_inativo_itemBLL
        Dim objMovimentoChipInativoItem As New DTO.Cg_movimento_chip_inativo_item

        Try
            objMovimentoChipInativo.Id_romaneio = CInt(txtCodigo.Text)
            objMovimentoChipInativo.Data_movto = CDate(txtDataMovto.Text)
            objMovimentoChipInativo.Id_loja_origem = CInt(txtIdLoja.Text)
            objMovimentoChipInativo.Id_loja_destino = CInt(txtIdLojaDestino.Text)
            objMovimentoChipInativo.Id_responsavel = CInt(txtIdResponsavel.Text)
            objMovimentoChipInativo.Tipo_op = IIf(flagAcao = Operacao.Novo, "I", "A")

            objMovimentoChipInativo.Qtd_recebida = 0 'Nesta tela entra tudo em Transito
            objMovimentoChipInativo.Qtd_total = dgvDados.RowCount 'Quantidade de itens no Grid

            'Dados de usuarios
            objMovimentoChipInativo.User_ins = ACE_CODIGO
            objMovimentoChipInativo.Data_ins = Hoje()
            objMovimentoChipInativo.User_upd = ACE_CODIGO
            objMovimentoChipInativo.Data_upd = Hoje()

            bllPai.GravarBLL(acao, objMovimentoChipInativo)

            'Método de Delete => Insert
            'Pesquisa pelos itens já existente e exclui tudo, para incluir os
            'itens que estão ativos no Grid
            Dim strItens As ArrayList
            Dim sqlquery As String
            sqlquery = "select ID_ROMANEIO, UNIQUE_KEYID, ID_CHIP, SIMID, QTD, VALOR "
            sqlquery += "FROM CG_MOVIMENTO_CHIP_INATIVO_ITEM WHERE ID_ROMANEIO = " & objMovimentoChipInativo.Id_romaneio.ToString

            strItens = BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

            'Percorre o array e exclui item a item 
            objMovimentoChipInativoItem.Id_romaneio = objMovimentoChipInativo.Id_romaneio

            Dim intParam1 As Integer, strParam2 As String
            For ixx = 0 To strItens.Count - 1
                intParam1 = strItens(ixx)(0)
                strParam2 = strItens(ixx)(1).ToString
                bllFilha.ExcluirBLL(intParam1, strParam2)
            Next

            'Percorre todo o DataGridView e insere os dados
            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    objMovimentoChipInativoItem.Id_chip = CInt(row.Cells(1).Value)
                    objMovimentoChipInativoItem.Simid = row.Cells(2).Value
                    objMovimentoChipInativoItem.Qtd = CInt(row.Cells(5).Value)
                    objMovimentoChipInativoItem.Valor = Convert.ToDouble(Replace(row.Cells(6).Value, ".", ","))
                    objMovimentoChipInativoItem.Id_romaneio = CInt(txtCodigo.Text)
                    objMovimentoChipInativoItem.Unique_keyid = row.Cells(8).Value

                    'Operação de delete/insert
                    bllFilha.GravarBLL(Operacao.Novo, objMovimentoChipInativoItem)

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

        If Verifica_Recebimento(CInt(txtCodigo.Text), "A") Then
            MyBase.Alterar()
            Habilita_Controles(True) 'modo digitação

            'Desabilita botão de Pesquisar Loja Destino - Loja 8 - INATIVO - FIXO
            btnPesqLojaDestino.Enabled = False

        Else
            Exit Sub
        End If
    End Sub
    Public Overrides Sub Excluir()

        If Verifica_Recebimento(CInt(txtCodigo.Text), "E") Then
            MyBase.Excluir()
            Habilita_Controles(True) 'modo digitação
        Else
            Exit Sub
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
            sqlquery = "SELECT ID_LOJA, NOME FROM CG_LOJA WHERE dbo.CG_LOJA.ID_LOJA = 8"

            strLoja = Global.BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

            txtIdLojaDestino.Text = strLoja(0)(0).ToString
            txtDescLojaDestino.Text = strLoja(0)(1).ToString
            'Desabilita botão de Pesquisar Loja Destino - Loja 8 - INATIVO - FIXO
            btnPesqLojaDestino.Enabled = False

        Else
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.Movimento_chipBLL
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
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc & _
                            " From " & Me.ObjModelFk.Tabela

        If String.IsNullOrEmpty(txtIdLojaDestino.Text) Then
            Me.ObjModelFk.FiltroSQL = " where (ID_LOJA = 1 OR ID_LOJA > 9) "
        Else
            Me.ObjModelFk.FiltroSQL = " where (ID_LOJA = 1 OR ID_LOJA > 9) AND ID_LOJA <> " & txtIdLojaDestino.Text
        End If

        PesquisaFK(Me.ObjModelFk)
        txtIdLoja.Text = Me.ObjModelFk.txtId.ToString
        txtDescLoja.Text = Me.ObjModelFk.txtDesc

    End Sub

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = 0 Then
            Edita_dados(dgvDados.CurrentRow)
        End If
    End Sub

    Private Sub Edita_dados(ByVal _linhaGrid As DataGridViewRow)

        'Debug.Print(_linhaGrid.Cells("ID_CHIP").Value.ToString)
        Dim frm As New WinCG.EntradaChip_Edicao(flagAcao, dgvDados, CInt(txtCodigo.Text), _linhaGrid)
        frm.ShowDialog()

    End Sub
    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao)
        btnPesqLoja.Enabled = False
        btnPesqLojaDestino.Enabled = False
        btnPesqResponsavel.Enabled = False

        btnAdiciona.Enabled = False
        btnExclui.Enabled = False
        If acao = Operacao.Novo Or acao = Operacao.Alterar Then

            'Somente habilita seleção de lojas na inclusão
            If acao = Operacao.Novo Then
                btnPesqLoja.Enabled = True
                btnPesqLojaDestino.Enabled = True
            End If

            btnPesqResponsavel.Enabled = True
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

    Private Sub btnPesqLojaDestino_Click(sender As Object, e As EventArgs) Handles btnPesqLojaDestino.Click
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
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc & _
                            " From " & Me.ObjModelFk.Tabela

        If String.IsNullOrEmpty(txtIdLoja.Text) Then
            Me.ObjModelFk.FiltroSQL = " where (ID_LOJA = 1 OR ID_LOJA > 9) "
        Else
            Me.ObjModelFk.FiltroSQL = " where (ID_LOJA = 1 OR ID_LOJA > 9) AND ID_LOJA <> " & txtIdLoja.Text
        End If

        PesquisaFK(Me.ObjModelFk)

        txtIdLojaDestino.Text = Me.ObjModelFk.txtId.ToString
        txtDescLojaDestino.Text = Me.ObjModelFk.txtDesc
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

    Private Sub btnAdiciona_Click_1(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        If String.IsNullOrEmpty(txtIdLoja.Text) Or txtIdLoja.Text = "0" Then
            MessageBox.Show("Atenção selecione primeiro a Loja de Origem antes de adicionar chips", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim frm As New WinCG.frmSelecionaChip(CInt(txtCodigo.Text), CInt(txtIdLoja.Text), dgvDados, "spSelecionaChipMovimentoInativo")
        frm.ShowDialog()
    End Sub

    Private Sub btnExclui_Click_1(sender As Object, e As EventArgs) Handles btnExclui.Click
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
            sql = "SELECT QTD_TOTAL, QTD_RECEBIDA FROM CG_MOVIMENTO_CHIP_INATIVO WHERE ID_ROMANEIO = {0}"
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
End Class