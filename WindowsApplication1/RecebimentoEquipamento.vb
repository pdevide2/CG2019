Public Class RecebimentoEquipamento
    Private _modulo As Integer
    Public Property Modulo() As Integer
        Get
            Return _modulo
        End Get
        Set(ByVal value As Integer)
            _modulo = value
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

    Private _ordem As String
    Public Property Ordem() As String
        Get
            Return _ordem
        End Get
        Set(ByVal value As String)
            _ordem = value
        End Set
    End Property

    Public podeAbrir As Boolean = False
    'variavel flagAcao o Default é readonly, após verificar permissão no módulo pode mudar para Limpar (0)
    Public flagAcao As Integer = Operacao.Leitura
    Dim _acao As Integer
    Dim _acesso As String
    Public Enum Operacao

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum
    Public Property Acao() As Integer
        Get
            Return _acao
        End Get
        Set(ByVal value As Integer)
            _acao = value
        End Set
    End Property
    Public Property Acesso() As String
        Get
            Return _acesso
        End Get
        Set(ByVal value As String)
            _acesso = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LoginCG() 'Carrega variavel Friend ACE_CODIGO pelo Setting ID_USER
        ' Add any initialization after the InitializeComponent() call.
        podeAbrir = permissaoTela(ACE_MODULO, ACE_CODIGO)


    End Sub
    Public Function permissaoTela(ByVal intModulo As Integer, ByVal intUsuario As Integer) As Boolean
        flagAcao = Operacao.Limpar
        Dim strPermissao As String = ""
        strPermissao = verPermissao(intModulo, intUsuario)

        Me.Acesso = strPermissao

        If strPermissao = "S" Then
            MessageBox.Show("Usuário sem permissão de acesso neste módulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf strPermissao = "L" Then
            flagAcao = Operacao.Leitura
        ElseIf strPermissao = "G" Then
            flagAcao = Operacao.Limpar
        Else
            MessageBox.Show("Configurações de permissão para este módulo não encontrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        Me.Acao = flagAcao
        Return True
    End Function
    Function verPermissao(ByVal modulo As Integer, ByVal usuario As Integer) As String

        Dim retorno As String
        Dim oBLL As New BLL.GlobalBLL

        retorno = oBLL.getPermissaoBLL(modulo, usuario)
        Return retorno

    End Function


    Public Sub inicio()
        'MyBase.inicio()


        Me.Modulo = 24 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        'HabilitaBotoes(flagAcao)
        ''MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Me.ObjModel = New DTO.Cg_entrada_chip
        'Me.ColunaId = "ID_ROMANEIO"
        'Habilita_Controles(False) 'modo leitura

        'Monta o Grid e configura as colunas 
        Carregar()

    End Sub

    Public Sub Carregar()
        Dim sql As String

        sql = "select 'EDITAR' AS COLBOTAO,ID_ROMANEIO,DATA_MOVTO,ID_LOJA_ORIGEM,NOME_ORIGEM,ID_LOJA_DESTINO,"
        sql += "NOME_DESTINO,ID_RESPONSAVEL,APELIDO from VW_CG_MOVIMENTO_EQUIPAMENTO WHERE 1 = 1 AND (QTD_RECEBIDA <> QTD_TOTAL) AND "

        Me.Comando = sql
        Me.ColunaFiltro = "DATA_MOVTO"
        Me.Filtro = "(DATA_MOVTO BETWEEN '" & Dtos(txtDe.Text) & "' AND '" & Dtos(txtAte.Text) & "')"
        Me.Ordem = " ORDER BY ID_ROMANEIO DESC "

        'Declara as variáveis do Tipo Coluna
        Dim colBotao As DataGridViewButtonColumn
        Dim colId_Romaneio As DataGridViewTextBoxColumn
        Dim colData_Movto As DataGridViewTextBoxColumn
        Dim colId_Loja_Origem As DataGridViewTextBoxColumn
        Dim colNome_Origem As DataGridViewTextBoxColumn
        Dim colId_Loja_Destino As DataGridViewTextBoxColumn
        Dim colNome_Destino As DataGridViewTextBoxColumn
        Dim colId_Responsavel As DataGridViewTextBoxColumn
        Dim colApelido As DataGridViewTextBoxColumn

        '*******>> Configura as colunas
        'coluna botao
        colBotao = New DataGridViewButtonColumn
        colBotao.HeaderText = "EDITAR"
        colBotao.Name = "colBotao1"

        'coluna Id_romaneio
        colId_Romaneio = New DataGridViewTextBoxColumn
        colId_Romaneio.HeaderText = "Romaneio nº"
        colId_Romaneio.Name = "ID_ROMANEIO"

        'coluna DATA
        colData_Movto = New DataGridViewTextBoxColumn
        colData_Movto.HeaderText = "Data Movto."
        colData_Movto.Name = "DATA_MOVTO"

        'coluna ID_ORIGEM
        colId_Loja_Origem = New DataGridViewTextBoxColumn
        colId_Loja_Origem.HeaderText = "ID Origem"
        colId_Loja_Origem.Name = "ID_LOJA_ORIGEM"

        'coluna NOME_ORIGEM
        colNome_Origem = New DataGridViewTextBoxColumn
        colNome_Origem.HeaderText = "Loja Origem"
        colNome_Origem.Name = "NOME_ORIGEM"

        'coluna ID_LOJA_DESTINO
        colId_Loja_Destino = New DataGridViewTextBoxColumn
        colId_Loja_Destino.HeaderText = "Id Destino"
        colId_Loja_Destino.Name = "ID_LOJA_DESTINO"

        'coluna NOME_DESTINO
        colNome_Destino = New DataGridViewTextBoxColumn
        colNome_Destino.HeaderText = "Loja Destino"
        colNome_Destino.Name = "NOME_DESTINO"

        'coluna ID_RESPONSAVEL
        colId_Responsavel = New DataGridViewTextBoxColumn
        colId_Responsavel.HeaderText = "Cód. Resp."
        colId_Responsavel.Name = "ID_RESPONSAVEL"

        'coluna APELIDO
        colApelido = New DataGridViewTextBoxColumn
        colApelido.HeaderText = "Responsável"
        colApelido.Name = "APELIDO"

        'Reset no Grid
        dgvDados1.DataSource = Nothing
        dgvDados1.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados1.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados1.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados1.Columns.AddRange(New DataGridViewColumn() {colBotao, colId_Romaneio, colData_Movto, colId_Loja_Origem, _
                                                     colNome_Origem, colId_Loja_Destino, colNome_Destino, colId_Responsavel, colApelido})

        'dgvdados1.DataSource = myRow
        Popula_Grid()

        dgvDados1.Columns(0).ReadOnly = False ' coluna do Botão
        For ixx = 1 To 8
            dgvDados1.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados1.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados1.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        dgvDados1.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados1.MultiSelect = False
        dgvDados1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados1.AllowUserToResizeColumns = False
        dgvDados1.EnableHeadersVisualStyles = False

        'Alinhamento dos dados nas colunas do Grid
        dgvDados1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


    End Sub

    Private Sub Popula_Grid()
        'Faz a Query no banco e retorna uma Lista de Array do Comando SQL
        Dim myRow As ArrayList
        myRow = BLL.GlobalBLL.PesquisarFkListaBLL(Me.Comando & Me.Filtro & Me.Ordem)

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

            dgvDados1.Rows.Add(strLinha)

        Next

    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub RecebimentoChip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicio()
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Carregar()
    End Sub

    Public Sub CarregarItens(ByVal _linhaGrid As DataGridViewRow, ByVal blnEditar As Boolean)

        Dim sql As String
        Dim _id_romaneio As String

        lblGrid2.Text = IIf(blnEditar = False, "Detalhe Romaneio (modo consulta)", "Detalhe Romaneio (modo edição)")

        If blnEditar = True Then
            _linhaGrid.Cells("colBotao1").Value = "SALVAR"
        End If

        sql = "SELECT "
        sql += "CAST(CASE TRANSITO WHEN 1 THEN 0 ELSE 1 END AS BIT) RECEBIDO, "
        sql += "ID_EQUIPAMENTO, SERIE, MODELO, DESC_EQUIPAMENTO, QTD, VALOR, ID_ROMANEIO, UNIQUE_KEYID, TRANSITO "
        sql += "FROM VW_CG_MOVIMENTO_EQUIPAMENTO_ITEM "
        Me.Comando = sql
        'Pega todos os equipamentos no estoque da Loja Origem selecionado na tela pai e 
        'elimina da seleção todos que já foram selecionados no grid da tela pai

        _id_romaneio = _linhaGrid.Cells("ID_ROMANEIO").Value.ToString()
        Me.Filtro = " WHERE ID_ROMANEIO = " & _id_romaneio
        Me.Filtro += " AND TRANSITO = 1 "

        ' Definição das colunas do grid
        '================================
        ' coluna0: RECEBIDO (checkbox)
        ' coluna1: ID_EQUIPAMENTO
        ' coluna2: SERIE
        ' coluna3: MODELO
        ' coluna4: DESC_EQUIPAMENTO
        ' coluna5: QTD
        ' coluna6: VALOR
        ' coluna7: ID_ROMANEIO
        ' coluna8: UNIQUE_KEYID
        ' coluna9: TRANSITO


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
        Dim coluna9 As DataGridViewTextBoxColumn

        '*******>> Configura as colunas
        'coluna checkbox
        coluna0 = New DataGridViewCheckBoxColumn
        coluna0.HeaderText = "Rebebido?"
        coluna0.Name = "RECEBIDO"
        coluna0.FlatStyle = FlatStyle.Standard
        coluna0.CellTemplate = New DataGridViewCheckBoxCell()
        coluna0.CellTemplate.Style.BackColor = Color.Beige

        'coluna coluna1
        coluna1 = New DataGridViewTextBoxColumn
        coluna1.HeaderText = "Id Equipamento"
        coluna1.Name = "ID_EQUIPAMENTO"

        'coluna coluna2
        coluna2 = New DataGridViewTextBoxColumn
        coluna2.HeaderText = "SERIE"
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
        coluna5.HeaderText = "QTD"
        coluna5.Name = "QTD"

        'coluna coluna6
        coluna6 = New DataGridViewTextBoxColumn
        coluna6.HeaderText = "Valor R$"
        coluna6.Name = "VALOR"

        'coluna coluna7
        coluna7 = New DataGridViewTextBoxColumn
        coluna7.HeaderText = "ID Romaneio"
        coluna7.Name = "ID_ROMANEIO"

        'coluna coluna8
        coluna8 = New DataGridViewTextBoxColumn
        coluna8.HeaderText = "CHAVE ID"
        coluna8.Name = "UNIQUE_KEYID"

        'coluna coluna9
        coluna9 = New DataGridViewTextBoxColumn
        coluna9.HeaderText = "Em Transito?"
        coluna9.Name = "TRANSITO"


        'Reset no Grid
        dgvDados2.DataSource = Nothing
        dgvDados2.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados2.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados2.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados2.Columns.AddRange(New DataGridViewColumn() {coluna0, coluna1, coluna2, coluna3, _
                                                            coluna4, coluna5, coluna6, coluna7, coluna8, coluna9})

        'dgvDados.DataSource = myRow
        Popula_Grid_Itens()

        dgvDados2.Columns(0).ReadOnly = Not blnEditar ' coluna do Botão

        For ixx = 1 To 9
            dgvDados2.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados2.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados2.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        dgvDados2.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados2.MultiSelect = False
        'dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados2.AllowUserToResizeColumns = False
        dgvDados2.EnableHeadersVisualStyles = False

        'Alinhamento dos dados nas colunas do Grid
        dgvDados2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados2.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

    End Sub

    Private Sub Popula_Grid_Itens()
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
                        myRow(ixx)(9).ToString}

            dgvDados2.Rows.Add(strLinha)

        Next

    End Sub

    Private Sub dgvDados1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados1.CellClick
        If e.ColumnIndex = 0 Then
            If dgvDados1.CurrentCell.Value = "EDITAR" Then
                CarregarItens(dgvDados1.CurrentRow, True)
            Else
                GravarRomaneio(dgvDados1.CurrentRow)
                dgvDados1.CurrentCell.Value = "EDITAR"
                Carregar() 'Refresh no Grid Pai
            End If

        ElseIf e.ColumnIndex > 0 And e.ColumnIndex <= dgvDados1.ColumnCount Then
            CarregarItens(dgvDados1.CurrentRow, False)
        End If
    End Sub

    Private Sub dgvDados1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados1.CellEnter
        If e.ColumnIndex >= 0 And e.ColumnIndex <= dgvDados1.ColumnCount Then
            If dgvDados1.CurrentRow.Cells(0).Value = "EDITAR" Then
                CarregarItens(dgvDados1.CurrentRow, False)
            End If
        End If

    End Sub

    Private Sub GravarRomaneio(ByVal _linhaGrid As DataGridViewRow)
        Dim intTransito As Integer
        Dim intRomaneio As Integer
        Dim strChave As String
        Dim intTotal As Integer = 0
        Dim intRecebido As Integer = 0


        Dim listaSQL As New ArrayList()

        Dim sqlEmpty As String, sql As String = ""
        sqlEmpty = "update CG_MOVIMENTO_EQUIPAMENTO_ITEM SET TRANSITO = {0} WHERE ID_ROMANEIO={1} AND UNIQUE_KEYID = '{2}'"

        Dim bllGlobal As New BLL.GlobalBLL

        Try

            For Each row As DataGridViewRow In dgvDados2.Rows

                If Not row.IsNewRow Then

                    intTransito = IIf(CBool(row.Cells(0).Value) = True, 0, 1)
                    intRomaneio = CInt(row.Cells(7).Value)
                    strChave = CStr(row.Cells(8).Value)

                    intTotal += 1
                    intRecebido += IIf(CBool(row.Cells(0).Value) = True, 1, 0)

                    sql = sqlEmpty
                    sql = String.Format(sql, intTransito, intRomaneio, strChave)

                    listaSQL.Add(sql) 'array para armazenar comandos sql para executar posteriormente
                    'bllGlobal.GravarGenericoBLL(sql)
                    'Armazena comando num array, para executar após a atualização da tabela pai, 
                    'Pois a tabela pai gera um codigo de romaneio de estoque pela trigger e deve 
                    'utilizar o mesmo código para os itens

                End If

            Next
            'Atualiza a tabela pai com a quantidade de itens e itens recebidos
            sql = "UPDATE CG_MOVIMENTO_EQUIPAMENTO SET QTD_RECEBIDA = QTD_RECEBIDA + {0} WHERE ID_ROMANEIO = {1}"
            sql = String.Format(sql, intRecebido, intRomaneio)
            bllGlobal.GravarGenericoBLL(sql)

            'Atualiza os itens
            For ixx As Integer = 0 To listaSQL.Count - 1
                bllGlobal.GravarGenericoBLL(listaSQL(ixx))
            Next

            MessageBox.Show("Gravação Concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try
    End Sub
End Class