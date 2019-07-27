Public Class frmSelecionaEquipamentoDisponivelDevolucao

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


    Public Sub New(ByVal _id As Integer, ByVal _idlojaorigem As Integer, ByRef _gridDados As DataGridView)

        ' This call is required by the designer.
        InitializeComponent()


        Me.ChavePai = _id.ToString
        Me.GridPai = _gridDados
        '==> LOJA ORIGEM = 1 (MATRIZ)
        Me.LojaOrigem = "1" '_idlojaorigem.ToString

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub Carregar()
        Dim sql As String
        sql = "EXEC spSelecionaEquipamentoDisponivelDevolucao "
        Me.Comando = sql
        'Pega todos os Equipamentos no estoque da Loja Origem selecionado na tela pai e 
        'elimina da seleção todos que já foram selecionados no grid da tela pai
        Me.Filtro = Me.LojaOrigem & ",'" & listaIdIncluidos() & "'"

        ' Definição das colunas do grid
        '================================
        ' coluna0: selecao (checkbox)
        ' coluna1: ID_EQUIPAMENTO
        ' coluna2: SERIE
        ' coluna3: MODELO
        ' coluna4: DESC_EQUIPAMENTO
        ' coluna5: ID_LOCAL_ESTOQUE
        ' coluna6: VALOR

        'Declara as variáveis do Tipo Coluna
        Dim coluna0 As DataGridViewCheckBoxColumn
        Dim coluna1 As DataGridViewTextBoxColumn
        Dim coluna2 As DataGridViewTextBoxColumn
        Dim coluna3 As DataGridViewTextBoxColumn
        Dim coluna4 As DataGridViewTextBoxColumn
        Dim coluna5 As DataGridViewTextBoxColumn
        Dim coluna6 As DataGridViewTextBoxColumn


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

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {coluna0, coluna1, coluna2, coluna3, _
                                                            coluna4, coluna5, coluna6})

        'dgvDados.DataSource = myRow
        Popula_Grid()

        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão

        For ixx = 1 To 6
            dgvDados.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        dgvDados.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados.MultiSelect = False
        'dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados.AllowUserToResizeColumns = False
        dgvDados.EnableHeadersVisualStyles = False

        'Alinhamento dos dados nas colunas do Grid
        dgvDados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight



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
                        myRow(ixx)(6).ToString}

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
        AdicionaEscolhidos()
        Sair()
    End Sub

    'Alimenta o DataGridView da tela pai e fecha o form depois
    Private Sub AdicionaEscolhidos()

        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    If row.Cells(0).Value = True Then 'Verifica se o checkbox está clicado

                        Try
                            Dim strLinha As String() 'declara um array de Strings que vai armazenar uma linha de registro toda

                            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
                            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid

                            strLinha = {"Editar/Ver", _
                                        row.Cells(1).Value.ToString, _
                                        row.Cells(2).Value.ToString, _
                                        row.Cells(3).Value.ToString, _
                                        row.Cells(4).Value.ToString, _
                                        "1", _
                                        "NÃO UTILIZA MAIS", _
                                        Me.ChavePai, _
                                        NovoKeyId(), _
                                        "1", _
                                        row.Cells(6).Value.ToString}


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
                strLista += row.Cells(1).Value & ","

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
End Class