﻿

Public Class DevolucaoChip

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
        sql = "SELECT 'Editar/Ver' as botao, "
        sql += " ID_CHIP, SIMID, ID_OPERADORA, DESC_OPERADORA, ID_MOTIVO, DESC_MOTIVO, ID_ROMANEIO, UNIQUE_KEYID, QTD, VALOR "
        sql += " FROM VW_CG_DEVOLUCAO_CHIP_ITEM "
        Me.Comando = sql
        Me.ColunaFiltro = "ID_ROMANEIO"
        Me.Filtro = " WHERE " & Me.ColunaFiltro & " = '" & txtCodigo.Text.ToString & "'"

        'Declara as variáveis do Tipo Coluna
        Dim colBotao As DataGridViewButtonColumn
        Dim colId_Chip As DataGridViewTextBoxColumn
        Dim colSimId As DataGridViewTextBoxColumn
        Dim colId_Operadora As DataGridViewTextBoxColumn
        Dim colDescOperadora As DataGridViewTextBoxColumn
        Dim colIdMotivo As DataGridViewTextBoxColumn
        Dim colDescMotivo As DataGridViewTextBoxColumn
        Dim colIdRomaneio As DataGridViewTextBoxColumn
        Dim colUniqueKey As DataGridViewTextBoxColumn
        Dim colQuantidade As DataGridViewTextBoxColumn
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

        'coluna Id_motivo
        colIdMotivo = New DataGridViewTextBoxColumn
        colIdMotivo.HeaderText = "Cód. Motivo"
        colIdMotivo.Name = "ID_MOTIVO"

        'coluna Desc_motivo
        colIdMotivo = New DataGridViewTextBoxColumn
        colIdMotivo.HeaderText = "Cód. Motivo"
        colIdMotivo.Name = "ID_MOTIVO"

        'coluna Valor
        colDescMotivo = New DataGridViewTextBoxColumn
        colDescMotivo.HeaderText = "Descrição Motivo"
        colDescMotivo.Name = "DESC_MOTIVO"

        'coluna iD_ROMANEIO
        colIdRomaneio = New DataGridViewTextBoxColumn
        colIdRomaneio.HeaderText = "Id Romaneio"
        colIdRomaneio.Name = "ID_ROMANEIO"

        'coluna Valor
        colUniqueKey = New DataGridViewTextBoxColumn
        colUniqueKey.HeaderText = "Key Id#"
        colUniqueKey.Name = "UNIQUE_KEYID"

        'coluna quantidade
        colQuantidade = New DataGridViewTextBoxColumn
        colQuantidade.HeaderText = "Qtd"
        colQuantidade.Name = "QTD"

        'coluna valor
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
                                                            colDescOperadora, colIdMotivo, colDescMotivo, _
                                                            colIdRomaneio, colUniqueKey, colQuantidade, colValor})

        'dgvDados.DataSource = myRow
        Popula_Grid()

        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão
        For ixx = 1 To 10
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
        dgvDados.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


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
                        myRow(ixx)(8).ToString, _
                        myRow(ixx)(9).ToString, _
                        myRow(ixx)(10).ToString()}

            dgvDados.Rows.Add(strLinha)

        Next

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()

        Me.PkString = False
        Me.Tabela = "CG_DEVOLUCAO_CHIP" 'Nome da tabela no SQL
        Me.View = "CG_DEVOLUCAO_CHIP"
        Me.TabelaFilha = "CG_ENTRADA_CHIP_ITEM"
        Me.Modulo = 21 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_devolucao_chip
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
            txtDataMovto.Text = Me.LinhaGrid.Cells("DATA_MOVTO").Value.ToString

            Carregar()
        End If
    End Sub

    Public Overrides Function ValidaCampos() As Object
        Dim blnRet As Boolean
        txtCodigo.Tag = "Código Romaneio"
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

        Dim bllPai As New BLL.Devolucao_chipBLL
        Dim objDevolucaoChip As New DTO.Cg_devolucao_chip

        Dim bllFilha As New BLL.Devolucao_chip_itemBLL
        Dim objDevolucaoChipItem As New DTO.Cg_devolucao_chip_item

        Try
            objDevolucaoChip.Id_romaneio = CInt(txtCodigo.Text)
            objDevolucaoChip.Data_movto = CDate(txtDataMovto.Text)


            objDevolucaoChip.User_ins = ACE_CODIGO
            objDevolucaoChip.Data_ins = Hoje()
            objDevolucaoChip.User_upd = ACE_CODIGO
            objDevolucaoChip.Data_upd = Hoje()

            bllPai.GravarBLL(acao, objDevolucaoChip)

            'Método de Delete => Insert
            'Pesquisa pelos itens já existente e exclui tudo, para incluir os
            'itens que estão ativos no Grid
            Dim strItens As ArrayList
            Dim sqlquery As String
            sqlquery = "select ID_ROMANEIO, UNIQUE_KEYID, ID_CHIP, SIMID, QTD, VALOR, ID_MOTIVO "
            sqlquery += "FROM CG_DEVOLUCAO_CHIP_ITEM WHERE ID_ROMANEIO = " & objDevolucaoChip.Id_romaneio.ToString

            strItens = BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

            'Percorre o array e exclui item a item 
            objDevolucaoChipItem.Id_romaneio = objDevolucaoChip.Id_romaneio
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
                    objDevolucaoChipItem.Id_chip = CInt(row.Cells(1).Value)
                    objDevolucaoChipItem.Simid = CStr(row.Cells(2).Value)
                    objDevolucaoChipItem.Qtd = CInt(row.Cells(9).Value)
                    objDevolucaoChipItem.Valor = Convert.ToDouble(Replace(row.Cells(10).Value, ".", ","))
                    objDevolucaoChipItem.Id_romaneio = CInt(txtCodigo.Text)
                    objDevolucaoChipItem.Unique_keyid = CStr(row.Cells(8).Value)
                    objDevolucaoChipItem.Id_motivo = CInt(row.Cells(5).Value)

                    'Operação de delete/insert
                    bllFilha.GravarBLL(Operacao.Novo, objDevolucaoChipItem)

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
            sqlquery = "SELECT ID_LOJA, NOME FROM CG_LOJA WHERE dbo.CG_LOJA.ID_LOJA = 1"

            strLoja = Global.BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)


        Else
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.Entrada_chipBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub



    Private Sub btnPesqLoja_Click(sender As Object, e As EventArgs)
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_MOTIVO"
        Me.ObjModelFk.CampoId = "ID_MOTIVO"
        Me.ObjModelFk.CampoDesc = "DESC_MOTIVO"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Descrição"
        Me.ObjModelFk.TituloTela = "Pesquisa de Motivos"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc & _
                            " From " & Me.ObjModelFk.Tabela
        Me.ObjModelFk.FiltroSQL = " where 1=0 "

        PesquisaFK(Me.ObjModelFk)



    End Sub

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
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

        btnAdiciona.Enabled = False
        btnExclui.Enabled = False
        If acao = Operacao.Novo Or acao = Operacao.Alterar Then

            btnAdiciona.Enabled = True
            btnExclui.Enabled = True
        End If
    End Sub

    Private Sub btnAdiciona_Click(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        Dim frm As New WinCG.frmSelecionaChipDisponivelDevolucao(CInt(txtCodigo.Text), 1, dgvDados)
        frm.ShowDialog()
        'Dim frm As New WinCG.DevolucaoChip_Edicao(flagAcao, dgvDados, CInt(txtCodigo.Text))
        'frm.ShowDialog()

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

    Private Sub btnExclui_Click(sender As Object, e As EventArgs) Handles btnExclui.Click
        If dgvDados.RowCount > 0 Then
            ExcluiLinha()
        End If
    End Sub

    Public Overrides Sub Cancelar(acao As Integer)
        MyBase.Cancelar(acao)
        Carregar()

    End Sub

    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick

    End Sub
End Class