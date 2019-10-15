﻿Public Class frmSelecionaEquipamentoOS

    Private _comando As String
    Public Property Comando() As String
        Get
            Return _comando
        End Get
        Set(ByVal value As String)
            _comando = value
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

    Private _grid_pai As DataGridView
    Public Property GridPai() As DataGridView
        Get
            Return _grid_pai
        End Get
        Set(ByVal value As DataGridView)
            _grid_pai = value
        End Set
    End Property

    Private _chavePai As String
    Public Property ChavePai() As String
        Get
            Return _chavePai
        End Get
        Set(ByVal value As String)
            _chavePai = value
        End Set
    End Property

    Private _row As DataGridViewRow
    Public Property LinhaDados() As DataGridViewRow
        Get
            Return _row
        End Get
        Set(ByVal value As DataGridViewRow)
            _row = value
        End Set
    End Property

    Private _idLoja As String
    Public Property LojaOrigem() As String
        Get
            Return _idLoja
        End Get
        Set(ByVal value As String)
            _idLoja = value
        End Set
    End Property

    'Cria uma lista de inteiros com os valores lidos do Grid da tela Pai do campo ITEM_ID
    'Quando inclui um novo item, é feita uma pesquisa do range de 1 a 1000 e o numero não
    'encontrado é retornado na função buscaDisponivel() para ser o proximo SEQUENCIAL do campo ITEM_ID
    Dim listaCodigos As List(Of Integer)
    Dim listaEquipamentos As New List(Of DTO.ListaItensOS)

    Public Sub New(ByVal _id As Integer, ByVal _idlojaorigem As Integer, ByRef _gridDados As DataGridView)

        ' This call is required by the designer.
        InitializeComponent()


        Me.ChavePai = _id.ToString
        Me.GridPai = _gridDados
        Me.LojaOrigem = _idlojaorigem.ToString

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub Carregar()
        Dim sql As String
        sql = "EXEC spSelecionaEquipamento_OS "
        Me.Comando = sql
        'Pega todos os Equipamentos no estoque da Loja Origem selecionado na tela pai e 
        'elimina da seleção todos que já foram selecionados no grid da tela pai
        Dim txtLike As String = Trim(Me.pesquisaNoGrid.Text)
        Dim strOpt As String = IIf(optPesq1.Checked, "1", "2")
        Me.Filtro = Me.LojaOrigem & ",'" & listaIdIncluidos() & "', '" & txtLike & "', " & strOpt

        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(Me.Comando & Me.Filtro).Tables(0)

        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão

        For ixx = 1 To 9
            dgvDados.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        'dgvDados.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None 'DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados.MultiSelect = False
        'dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados.AllowUserToResizeColumns = False
        dgvDados.EnableHeadersVisualStyles = False

        dgvDados.Columns("selecao").Width = 60
        dgvDados.Columns("id_equipamento").Width = 70
        dgvDados.Columns("serie").Width = 90
        dgvDados.Columns("modelo").Width = 90
        dgvDados.Columns("desc_equipamento").Width = 200
        dgvDados.Columns("id_local_estoque").Width = 60
        dgvDados.Columns("valor").Width = 100
        dgvDados.Columns("id_tipo_equipamento").Width = 100
        dgvDados.Columns("desc_tipo_equipamento").Width = 100
        dgvDados.Columns("garantia").Width = 60


        'Alinhamento dos dados nas colunas do Grid
        dgvDados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If dgvDados.RowCount = 0 Then
            MessageBox.Show("Não existem equipamentos no estoque da loja selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub
    Public Sub Carregar_OLD()
        Dim sql As String
        sql = "EXEC spSelecionaEquipamento_OS "
        Me.Comando = sql
        'Pega todos os Equipamentos no estoque da Loja Origem selecionado na tela pai e 
        'elimina da seleção todos que já foram selecionados no grid da tela pai
        Dim txtLike As String = Trim(Me.pesquisaNoGrid.Text)
        Dim strOpt As String = IIf(optPesq1.Checked, "1", "2")
        Me.Filtro = Me.LojaOrigem & ",'" & listaIdIncluidos() & "', '" & txtLike & "', " & strOpt

        ' Definição das colunas do grid
        '================================
        ' coluna0: selecao (checkbox)
        ' coluna1: ID_EQUIPAMENTO
        ' coluna2: SERIE
        ' coluna3: MODELO
        ' coluna4: DESC_EQUIPAMENTO
        ' coluna5: ID_LOCAL_ESTOQUE
        ' coluna6: VALOR
        ' coluna7: ID_TIPO_EQUIPAMENTO
        ' coluna8: DESC_TIPO_EQUIPAMENTO

        'Declara as variáveis do Tipo Coluna
        Dim coluna0 As DataGridViewCheckBoxColumn
        Dim coluna1 As DataGridViewTextBoxColumn
        Dim coluna2 As DataGridViewTextBoxColumn
        Dim coluna3 As DataGridViewTextBoxColumn
        Dim coluna4 As DataGridViewTextBoxColumn
        Dim coluna5 As DataGridViewTextBoxColumn
        Dim coluna6 As DataGridViewTextBoxColumn
        Dim coluna7 As DataGridViewTextBoxColumn
        Dim coluna8 As DataGridViewTextBoxColumn
        Dim coluna9 As DataGridViewCheckBoxColumn 'Garantia

        '*******>> Configura as colunas
        'coluna checkbox
        coluna0 = New DataGridViewCheckBoxColumn
        coluna0.HeaderText = "Selecione"
        coluna0.Name = "selecao"
        coluna0.FlatStyle = FlatStyle.Standard
        coluna0.CellTemplate = New DataGridViewCheckBoxCell()
        coluna0.CellTemplate.Style.BackColor = Color.Beige

        'coluna coluna1
        coluna1 = New DataGridViewTextBoxColumn
        coluna1.HeaderText = "Id Equipamento"
        coluna1.Name = "ID_EQUIPAMENTO"

        'coluna coluna2
        coluna2 = New DataGridViewTextBoxColumn
        coluna2.HeaderText = "Série#"
        coluna2.Name = "SERIE"

        'coluna coluna3
        coluna3 = New DataGridViewTextBoxColumn
        coluna3.HeaderText = "Modelo"
        coluna3.Name = "MODELO"

        'coluna coluna4
        coluna4 = New DataGridViewTextBoxColumn
        coluna4.HeaderText = "Desc. Equipamento"
        coluna4.Name = "DESC_EQUIPAMENTO"

        'coluna coluna5
        coluna5 = New DataGridViewTextBoxColumn
        coluna5.HeaderText = "Id Local Estoque"
        coluna5.Name = "ID_LOCAL_ESTOQUE"

        'coluna coluna6
        coluna6 = New DataGridViewTextBoxColumn
        coluna6.HeaderText = "Custo R$"
        coluna6.Name = "VALOR"

        'coluna coluna7
        coluna7 = New DataGridViewTextBoxColumn
        coluna7.HeaderText = "Id Tipo Equipto"
        coluna7.Name = "ID_TIPO_EQUIPAMENTO"

        'coluna coluna8
        coluna8 = New DataGridViewTextBoxColumn
        coluna8.HeaderText = "Descrição Tipo Equipamento"
        coluna8.Name = "DESC_TIPO_EQUIPAMENTO"

        'coluna coluna9
        coluna9 = New DataGridViewCheckBoxColumn
        coluna9.HeaderText = "Garantia"
        coluna9.Name = "GARANTIA"

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {coluna0, coluna1, coluna2, coluna3,
                                                            coluna4, coluna5, coluna6, coluna7, coluna8, coluna9})

        'dgvDados.DataSource = myRow
        Popula_Grid()

        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão

        For ixx = 1 To 9
            dgvDados.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        'dgvDados.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None 'DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados.MultiSelect = False
        'dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados.AllowUserToResizeColumns = False
        dgvDados.EnableHeadersVisualStyles = False

        dgvDados.Columns("selecao").Width = 60
        dgvDados.Columns("id_equipamento").Width = 70
        dgvDados.Columns("serie").Width = 90
        dgvDados.Columns("modelo").Width = 90
        dgvDados.Columns("desc_equipamento").Width = 200
        dgvDados.Columns("id_local_estoque").Width = 60
        dgvDados.Columns("valor").Width = 100
        dgvDados.Columns("id_tipo_equipamento").Width = 100
        dgvDados.Columns("desc_tipo_equipamento").Width = 100
        dgvDados.Columns("garantia").Width = 60


        'Alinhamento dos dados nas colunas do Grid
        dgvDados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If dgvDados.RowCount = 0 Then
            MessageBox.Show("Não existem equipamentos no estoque da loja selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

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
                        myRow(ixx)(9).ToString}

            dgvDados.Rows.Add(strLinha)

        Next

    End Sub

    Private Sub Sair()

        Me.Close()

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Sair()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If listaEquipamentos.Count > 0 Then
            AdicionaEscolhidosLista()
        Else
            AdicionaEscolhidos()
        End If
        Sair()
    End Sub
    Private Sub AdicionaEscolhidosLista()
        Dim intReg As Integer
        Dim blnSt As Boolean = False

        Try

            For Each item In listaEquipamentos

                intReg = buscaDisponivel()
                Dim strLinha As String()
                strLinha = {"Editar",
                            "Ocorrência",
                            item.IdOS,
                            intReg.ToString,
                            item.IdEquipamento,
                            item.DescEquipamento,
                            item.Serie,
                            item.Modelo,
                            item.PrevisaoRetorno,
                            item.DescDefeito,
                            item.ConsertoOk,
                            item.IdTipoEquip,
                            item.DescTipoEquipamento,
                            item.Garantia}

                Me.GridPai.Rows.Add(strLinha)
            Next


        Catch ex As Exception
            MessageBox.Show("Erro ao selecionar item: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub
    'Alimenta o DataGridView da tela pai e fecha o form depois
    Private Sub AdicionaEscolhidos()

        Dim intReg As Integer
        Dim blnSt As Boolean = False

        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    If row.Cells(0).Value = True Then 'Verifica se o checkbox está clicado

                        Try
                            Dim strLinha As String() 'declara um array de Strings que vai armazenar uma linha de registro toda

                            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
                            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid
                            'intReg += 1
                            intReg = buscaDisponivel()

                            strLinha = {"Editar",
                                        "Ocorrência",
                                        Me.ChavePai,
                                        intReg.ToString,
                                        row.Cells(1).Value.ToString,
                                        row.Cells(4).Value.ToString,
                                        row.Cells(2).Value.ToString,
                                        row.Cells(3).Value.ToString,
                                        SomaData("D", 7, Hoje()).ToString("dd/MM/yyyy"),
                                        "Com Defeito. Enviado para assistência técnica em " & CDate(Hoje()).ToString("dd/MM/yyyy"),
                                        blnSt.ToString,
                                        row.Cells(7).Value.ToString,
                                        row.Cells(8).Value.ToString,
                                        row.Cells(9).Value.ToString}

                            Me.GridPai.Rows.Add(strLinha)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End Try

                    End If

                End If


            Next


        Catch ex As Exception
            MessageBox.Show("Erro ao selecionar chip: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try



    End Sub

    Private Function listaIdIncluidos() As String
        Dim strLista As String = ""
        'Le todo o Grid e concatena os ID_CHIP numa string separado por virgula (,)
        For Each row As DataGridViewRow In Me.GridPai.Rows

            If Not row.IsNewRow Then

                'Carrega os dados no objeto Model para passagem de parametro
                strLista += row.Cells("ID_EQUIPAMENTO").Value & ","

            End If

        Next
        'Tira a última virgula (,) 
        If Not String.IsNullOrEmpty(strLista) Then
            strLista = strLista.Substring(0, Len(strLista) - 1)
        End If

        Return strLista
    End Function

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click
        If btnSelecionar.Text = "Desmarcar Todos" Then
            Marcar_Desmarcar(False)
            btnSelecionar.Text = "Marcar Todos"
        Else
            Marcar_Desmarcar(True)
            btnSelecionar.Text = "Desmarcar Todos"
        End If
    End Sub

    Private Sub Marcar_Desmarcar(ByVal blnAcao As Boolean)
        Try

            lblWait.Visible = True
            lblWait.Refresh()

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    row.Cells(0).Value = blnAcao

                End If

            Next

            lblWait.Visible = False
            lblWait.Refresh()

        Catch ex As Exception
            MessageBox.Show("Erro ao atribui valor: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click

        Dim texto As String = Nothing
        Dim intEscolha As Integer = IIf(optPesq1.Checked = True, 0, 1)

        If pesquisaNoGrid.Text <> String.Empty Then
            'Percorre todas as linhas do Grid e compara o conteudo do textbox de Pesquisa
            'com o conteudo da coluna SIMID do grid. Se a condição for satisfeita seleciona a linha e sai da rotina
            For Each linha As DataGridViewRow In dgvDados.Rows
                texto = linha.Cells(2).Value 'Pesquisa na coluna de SIMID
                If PesquisaString(texto.ToLower, pesquisaNoGrid.Text.ToLower, intEscolha) Then
                    linha.Selected = True
                    Exit Sub
                End If
            Next
        End If

    End Sub

    Private Sub frmSelecionaEquipamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optPesq1.Checked = False
        optPesq2.Checked = True
        Carregar()
    End Sub

    Private Sub pesquisaNoGrid_TextChanged(sender As Object, e As EventArgs) Handles pesquisaNoGrid.TextChanged
        Try

            Carregar()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub criarLista()

        listaCodigos = New List(Of Integer)()

        'listaCodigos.Add(New ListOfOSItem(1))

        For Each row As DataGridViewRow In Me.GridPai.Rows

            If Not row.IsNewRow Then

                'Carrega os dados no objeto Model para passagem de parametro
                listaCodigos.Add(CInt(row.Cells("ITEM_ID").Value))

            End If

        Next

    End Sub

    Private Function buscaDisponivel() As Integer

        criarLista()

        Dim retCodigo As Integer

        For i = 1 To 1000

            retCodigo = listaCodigos.IndexOf(i)

            If retCodigo = -1 Then

                retCodigo = i

                Exit For

            End If

        Next

        Return retCodigo

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intReg As Integer
        Dim blnSt As Boolean = False

        For Each row As DataGridViewRow In dgvDados.Rows


            If row.Cells(0).Value = True And Not row.IsNewRow Then
                Dim listOfEquip As New DTO.ListaItensOS
                intReg = 0 'buscaDisponivel()

                listOfEquip.IdOS = Me.ChavePai
                listOfEquip.ItemId = intReg.ToString
                listOfEquip.IdEquipamento = row.Cells("id_equipamento").Value
                listOfEquip.DescEquipamento = row.Cells("desc_equipamento").Value
                listOfEquip.Serie = row.Cells("serie").Value
                listOfEquip.Modelo = row.Cells("modelo").Value
                listOfEquip.PrevisaoRetorno = SomaData("D", 7, Hoje()).ToString("dd/MM/yyyy")
                listOfEquip.DescDefeito = "Com Defeito. Enviado para assistência técnica em " & CDate(Hoje()).ToString("dd/MM/yyyy")
                listOfEquip.ConsertoOk = blnSt.ToString
                listOfEquip.IdTipoEquip = row.Cells("id_tipo_equipamento").Value
                listOfEquip.DescTipoEquipamento = row.Cells("desc_tipo_equipamento").Value
                listOfEquip.Garantia = row.Cells("garantia").Value


                listaEquipamentos.Add(listOfEquip)
                lstItens.Items.Add(listOfEquip.Serie)

                'Dim frm As New WaitWindow(dgvDados.CurrentRow.Cells("SIMID").Value & " adicionado...", 1)
                'frm.Show()

            End If
        Next

    End Sub
End Class