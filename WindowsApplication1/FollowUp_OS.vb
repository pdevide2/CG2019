Public Class FollowUp_OS
    Private _lido As Boolean
    Public Property MensagemLida() As Boolean
        Get
            Return _lido
        End Get
        Set(ByVal value As Boolean)
            _lido = value
        End Set
    End Property
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

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LoginCG() 'Carrega variavel Friend ACE_CODIGO pelo Setting ID_USER
        ' Add any initialization after the InitializeComponent() call.
        'podeAbrir = permissaoTela(ACE_MODULO, ACE_CODIGO)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal _id_os As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoginCG() 'Carrega variavel Friend ACE_CODIGO pelo Setting ID_USER
        ' Add any initialization after the InitializeComponent() call.
        'podeAbrir = permissaoTela(ACE_MODULO, ACE_CODIGO)

        txtId_OS.Text = _id_os.ToString
        'Carregar()

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
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc &
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where 1=1 "

        PesquisaFK(Me.ObjModelFk)

        txtId_OS.Text = Me.ObjModelFk.txtId.ToString

        Carregar()

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

        sql = "select PROTOCOLO, DATA_HORA, TEXTO, ID_OS, LIDO"
        sql += " from CG_FOLLOW_UP "

        Me.Comando = sql
        Me.ColunaFiltro = "ID_OS"
        Me.Filtro = " WHERE " & Me.ColunaFiltro & " = '" & txtId_OS.Text.ToString & "'"

        Me.OrderBy = " ORDER BY PROTOCOLO DESC "

        'Declara as variáveis do Tipo Coluna
        Dim colBotao As DataGridViewButtonColumn
        Dim colId_OS As DataGridViewTextBoxColumn
        Dim colDataHora As DataGridViewTextBoxColumn
        Dim colTexto As DataGridViewTextBoxColumn
        Dim colLido As DataGridViewCheckBoxColumn

        '*******>> Configura as colunas
        'coluna botao
        colBotao = New DataGridViewButtonColumn
        colBotao.HeaderText = "Protocolo"
        colBotao.Name = "PROTOCOLO"

        'coluna ID_OS
        colId_OS = New DataGridViewTextBoxColumn
        colId_OS.HeaderText = "OS nº"
        colId_OS.Name = "ID_OS"

        'coluna DATA_HORA
        colDataHora = New DataGridViewTextBoxColumn
        colDataHora.HeaderText = "Data/Hora"
        colDataHora.Name = "DATA_HORA"

        'coluna TEXTO
        colTexto = New DataGridViewTextBoxColumn
        colTexto.HeaderText = "Comentário"
        colTexto.Name = "TEXTO"

        colLido = New DataGridViewCheckBoxColumn
        colLido.HeaderText = "Lido"
        colLido.Name = "LIDO"

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colBotao, colDataHora, colTexto, colId_OS, colLido})
        'dgvDados.DataSource = myRow
        Popula_Grid()

        dgvDados.Columns(0).ReadOnly = True ' coluna do Botão
        For ixx = 1 To 4
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
                        myRow(ixx)(4).ToString}

            dgvDados.Rows.Add(strLinha)

        Next

    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

        Try
            If String.IsNullOrEmpty(txtId_OS.Text) Then
                MessageBox.Show("Selecione uma OS primeiro antes de adicionar uma linha de comentário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If CInt(txtId_OS.Text) = 0 Then
                    MessageBox.Show("Selecione uma OS primeiro antes de adicionar uma linha de comentário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If
            AdicionarComentario()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub AdicionarComentario()
        Dim strLinhaNew As String()
        Dim strDataHora As String = Hoje().ToString

        Try
            strLinhaNew = {ProtocoloNumero(), strDataHora, "Comentário as " & strDataHora & " - " & UserName() & Chr(13), txtId_OS.Text.ToString}
            txtDataHora.Text = strDataHora
            txtTexto.Text = "Comentário as " & strDataHora & " - " & UserName() & Chr(13)
            dgvDados.Rows.Add(strLinhaNew)

            dgvDados.Sort(dgvDados.Columns(0), System.ComponentModel.ListSortDirection.Descending)

            If dgvDados.RowCount > 0 Then
                'Da um go top - seleciona a primeira linha
                dgvDados.CurrentCell = dgvDados.Rows(0).Cells(0)
                Edita_dados(dgvDados.CurrentRow)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
        If e.ColumnIndex = 0 Then
            Edita_dados(dgvDados.CurrentRow)
        End If
    End Sub

    Private Sub Edita_dados(ByVal _linhaGrid As DataGridViewRow)

        dgvDados.Enabled = False
        txtTexto.ReadOnly = False
        txtDataHora.ReadOnly = True
        'Editou a msg fica status = "Não Lido novamente"
        MensagemLida = False
        StatusMsg(CBool(dgvDados.CurrentRow.Cells("LIDO").Value))

        btnAdicionar.Enabled = False
        btnSalvar.Enabled = True

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        dgvDados.Enabled = True
        txtTexto.ReadOnly = True
        txtDataHora.ReadOnly = True

        btnAdicionar.Enabled = True
        btnSalvar.Enabled = False

        dgvDados.CurrentRow.Cells(2).Value = Trim(txtTexto.Text.ToString)
        dgvDados.CurrentRow.Cells("LIDO").Value = MensagemLida.ToString

        Gravar()
        Carregar()

    End Sub

    Private Sub Gravar()
        Dim bll As New BLL.Follow_upBLL
        Dim objFollowUp As New DTO.Cg_follow_up
        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    objFollowUp.Id_os = CInt(txtId_OS.Text)
                    objFollowUp.Protocolo = row.Cells(0).Value.ToString()
                    objFollowUp.Texto = row.Cells(2).Value.ToString()
                    objFollowUp.Data_hora = row.Cells(1).Value.ToString()


                    objFollowUp.User_ins = ACE_CODIGO
                    objFollowUp.Data_ins = Hoje()
                    objFollowUp.User_upd = ACE_CODIGO
                    objFollowUp.Data_upd = Hoje()
                    'objFollowUp.Id_empresa = Publico.Id_empresa
                    objFollowUp.Lido = CBool(row.Cells("LIDO").Value)
                    bll.GravarBLL(1, objFollowUp)

                End If

            Next
            'MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'flagAcao = Operacao.Consulta

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try
    End Sub


    Private Sub dgvDados_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellEnter
        txtDataHora.Text = dgvDados.CurrentRow.Cells(1).Value
        txtTexto.Text = dgvDados.CurrentRow.Cells(2).Value
        StatusMsg(CBool(dgvDados.CurrentRow.Cells("LIDO").Value))

    End Sub

    Private Sub FollowUp_OS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.MensagemLida = True
        dgvDados.CurrentRow.Cells("LIDO").Value = MensagemLida.ToString
        StatusMsg(Me.MensagemLida)
        Gravar()
        Carregar()

    End Sub

    Private Sub StatusMsg(blnStatus As Boolean)
        If blnStatus = True Then

            PictureBox1.Visible = False
            PictureBox2.Visible = True

        Else
            PictureBox1.Visible = True
            PictureBox2.Visible = False

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.MensagemLida = False
        dgvDados.CurrentRow.Cells("LIDO").Value = MensagemLida.ToString
        StatusMsg(Me.MensagemLida)
        Gravar()
        Carregar()
    End Sub
End Class