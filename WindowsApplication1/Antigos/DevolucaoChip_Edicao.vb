

Public Class DevolucaoChip_Edicao

    Private _action As Integer
    Public Property Acao() As Integer
        Get
            Return _action
        End Get
        Set(ByVal value As Integer)
            _action = value
        End Set
    End Property

    Private _modo As String
    Public Property Modo() As String
        Get
            Return _modo
        End Get
        Set(ByVal value As String)
            _modo = value
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

    Private _objModelFk As Object
    Public Property ObjModelFk() As Object
        Get
            Return _objModelFk
        End Get
        Set(ByVal value As Object)
            _objModelFk = value
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

    Public Sub New(ByVal _acao As Integer, ByRef _gridDados As DataGridView, ByVal _chavePai As Integer, ByVal _linhaGrid As DataGridViewRow)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.LinhaDados = _linhaGrid
        Me.ChavePai = _chavePai.ToString
        Me.GridPai = _gridDados
        Me.Modo = "existe"
        Me.Acao = _acao

    End Sub
    Public Sub New(ByVal _acao As Integer, ByRef _gridDados As DataGridView, ByVal _chavePai As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ChavePai = _chavePai.ToString
        Me.GridPai = _gridDados
        Me.Modo = "novo"
        Me.Acao = _acao

    End Sub

    Private Sub EntradaChip_Edicao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        'Coloca na propriedade TAG, a mensagem que será exibida, para validar campos obrigatórios
        'Na função ValidaCampos()
        txtRomaneio.Tag = "Romaneio"
        txtUniqueId.Tag = "Unique ID"
        txtIdChip.Tag = "Código do Chip"
        txtSimId.Tag = "SIMID"
        txtIdOperadora.Tag = "Código Operadora"
        txtDescOperadora.Tag = "Descrição da Operadora"
        txtQuantidade.Tag = "Quantidade"
        txtValor.Tag = "Valor"

        txtIdMotivo.Tag = "Código do Motivo"
        txtDescMotivo.Tag = "Descrição do Motivo"

        LimpaControles()
        Carrega_Dados()

        HabilitaBotoesFilha(Me.Acao)


    End Sub

    Private Sub Carrega_Dados()
        If Me.Modo = "existe" Then
            txtRomaneio.Text = Me.LinhaDados.Cells("ID_ROMANEIO").Value.ToString
            txtUniqueId.Text = Me.LinhaDados.Cells("UNIQUE_KEYID").Value.ToString
            txtIdChip.Text = Me.LinhaDados.Cells("ID_CHIP").Value.ToString
            txtSimId.Text = Me.LinhaDados.Cells("SIMID").Value.ToString
            txtIdOperadora.Text = Me.LinhaDados.Cells("ID_OPERADORA").Value.ToString
            txtDescOperadora.Text = Me.LinhaDados.Cells("DESC_OPERADORA").Value.ToString
            txtQuantidade.Text = Me.LinhaDados.Cells("QTD").Value.ToString
            txtValor.Text = Me.LinhaDados.Cells("VALOR").Value.ToString
        End If
    End Sub


    Private Sub btnEditaSalva_Click(sender As Object, e As EventArgs) Handles btnEditaSalva.Click
        If btnEditaSalva.Text = "Novo" Then
            LimpaControles()
            txtRomaneio.Text = Me.ChavePai
            txtUniqueId.Text = NovoKeyId()

            btnEditaSalva.Text = "Salvar"
            Dim arqSave As String = My.Settings.DIRHOME & "CG\CG\Image\save16(2).png"
            btnEditaSalva.Image = System.Drawing.Image.FromFile(arqSave)
        Else
            If AdicionaLinha() Then
                btnEditaSalva.Text = "Novo"
                Dim arqNovo As String = My.Settings.DIRHOME & "CG\CG\Image\file-add-filha16.png"
                btnEditaSalva.Image = System.Drawing.Image.FromFile(arqNovo)
            End If
        End If
    End Sub

    Private Sub LimpaControles()
        'Este método é utilizado para limpar os controles antes da Inclusão
        For Each c In Me.Controls
            Select Case c.GetType()
                Case GetType(TextBox)
                    CType(c, TextBox).Text = String.Empty
                    CType(c, TextBox).BackColor = Color.WhiteSmoke

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

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub


    Private Sub btnPesqChip_Click(sender As Object, e As EventArgs) Handles btnPesqChip.Click
        If btnEditaSalva.Text = "Novo" Then
            MessageBox.Show("Para incluir uma nova linha, clique no botão novo primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "VW_CG_CHIP_DISPONIVEIS_DEVOLUCAO_MATRIZ"
        Me.ObjModelFk.CampoId = "ID_CHIP"
        Me.ObjModelFk.CampoDesc = "SIMID"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "SIMID"
        Me.ObjModelFk.TituloTela = "Pesquisa de CHIP"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc & _
                            " From " & Me.ObjModelFk.Tabela

        Dim strFiltro As String

        strFiltro = listaIdIncluidos()
        If String.IsNullOrEmpty(strFiltro) Then
            strFiltro = " where 1=1 "
        Else
            strFiltro = " where 1=1 and ID_CHIP not in " & strFiltro
        End If
        Me.ObjModelFk.FiltroSQL = strFiltro

        PesquisaFK(Me.ObjModelFk)

        txtIdChip.Text = Me.ObjModelFk.txtId.ToString
        txtSimId.Text = Me.ObjModelFk.txtDesc

        'Se código do chip selecionado for valido, traz o resto dos campos 
        If (txtIdChip.Text <> "" And txtIdChip.Text <> "0") Then

            'Faz a Query no banco e retorna uma Lista de Array do Comando SQL
            Dim myRow As ArrayList, comandoSQL As String

            comandoSQL = "SELECT CG_CHIP.ID_CHIP,"
            comandoSQL += "CG_CHIP.SIMID,CG_CHIP.ID_OPERADORA,CG_OPERADORA.DESC_OPERADORA,"
            comandoSQL += "CG_CHIP.CUSTO,CAST(1 AS INT) AS QTD "
            comandoSQL += "FROM CG_CHIP(NOLOCK) "
            comandoSQL += "Left Join CG_OPERADORA (NOLOCK) "
            comandoSQL += "ON CG_CHIP.ID_OPERADORA = CG_OPERADORA.ID_OPERADORA "
            comandoSQL += "WHERE CG_CHIP.ID_CHIP = " & txtIdChip.Text

            myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)

            If myRow.Count > 0 Then

                txtIdOperadora.Text = myRow(0)(2).ToString
                txtDescOperadora.Text = myRow(0)(3).ToString
                txtQuantidade.Text = myRow(0)(5).ToString
                txtValor.Text = myRow(0)(4).ToString

            Else

                txtIdOperadora.Text = String.Empty
                txtDescOperadora.Text = String.Empty
                txtQuantidade.Text = String.Empty
                txtValor.Text = String.Empty

            End If

        Else

            txtIdOperadora.Text = String.Empty
            txtDescOperadora.Text = String.Empty
            txtQuantidade.Text = String.Empty
            txtValor.Text = String.Empty

        End If

    End Sub

    Private Sub PesquisaFK(oPesqFk As DTO.PesquisaFK)

        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica(Me, oPesqFk)
        frm.Owner = Me
        frm.ShowDialog()

    End Sub

    Private Function AdicionaLinha()
        Dim blnRetorno As Boolean = False
        If ValidaCampos() Then
            If Popula_Grid() Then
                blnRetorno = True
            End If
        End If
        Return blnRetorno
    End Function

    Private Function ValidaCampos()
        Dim msg As String = ""
        Try

            For Each c In Me.Controls
                Select Case c.GetType()
                    Case GetType(TextBox)

                        If Not String.IsNullOrEmpty(CType(c, TextBox).Tag) Then
                            If String.IsNullOrEmpty(CType(c, TextBox).Text) Then
                                msg += "Campo " & CType(c, TextBox).Tag & " deve ser preenchido!" & vbCr
                            End If
                        End If
                End Select
            Next
            If Not String.IsNullOrEmpty(msg) Then
                Throw New Exception(msg)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Private Function Popula_Grid()
        Try
            Dim strLinha As String() 'declara um array de Strings que vai armazenar uma linha de registro toda

            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid
            strLinha = {"Editar/Ver", _
                        txtIdChip.Text.ToString, _
                        txtSimId.Text.ToString, _
                        txtIdOperadora.Text.ToString, _
                        txtDescOperadora.Text.ToString, _
                        txtIdMotivo.Text.ToString, _
                        txtDescMotivo.Text.ToString, _
                        txtRomaneio.Text.ToString, _
                        txtUniqueId.Text.ToString, _
                        txtQuantidade.Text.ToString, _
                        txtValor.Text.ToString}

            Me.GridPai.Rows.Add(strLinha)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Private Sub HabilitaBotoesFilha(ByVal _acao As Integer)
        Dim blnModo As Boolean = True
        If _acao <> 1 And _acao <> 2 Then
            blnModo = False
        End If

        btnEditaSalva.Enabled = blnModo
        btnFechar.Enabled = True
        btnPesqChip.Enabled = blnModo
        btnPesqMotivo.Enabled = blnModo

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
        'Tira a última virgula (,) e adiciona os "( )"
        If Not String.IsNullOrEmpty(strLista) Then
            strLista = "(" & strLista.Substring(0, Len(strLista) - 1) & ")"
        End If

        Return strLista
    End Function





    Private Sub btnPesqMotivo_Click(sender As Object, e As EventArgs) Handles btnPesqMotivo.Click
        If btnEditaSalva.Text = "Novo" Then
            MessageBox.Show("Para selecionar um motivo, clique no botão novo primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

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

        txtIdMotivo.Text = Me.ObjModelFk.txtId.ToString
        txtDescMotivo.Text = Me.ObjModelFk.txtDesc
    End Sub
End Class