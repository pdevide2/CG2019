

Public Class EntradaEquipamento_Edicao

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
        txtIdEquipamento.Tag = "Código do Chip"
        txtSerie.Tag = "SIMID"
        txtModelo.Tag = "Código Operadora"
        txtDescEquipamento.Tag = "Descrição da Operadora"
        txtQuantidade.Tag = "Quantidade"
        txtValor.Tag = "Valor"

        LimpaControles()
        Carrega_Dados()

        HabilitaBotoesFilha(Me.Acao)


    End Sub

    Private Sub Carrega_Dados()
        If Me.Modo = "existe" Then
            txtRomaneio.Text = Me.LinhaDados.Cells("ID_ROMANEIO").Value.ToString
            txtUniqueId.Text = Me.LinhaDados.Cells("UNIQUE_KEYID").Value.ToString
            txtIdEquipamento.Text = Me.LinhaDados.Cells("ID_EQUIPAMENTO").Value.ToString
            txtSerie.Text = Me.LinhaDados.Cells("SERIE").Value.ToString
            txtModelo.Text = Me.LinhaDados.Cells("MODELO").Value.ToString
            txtDescEquipamento.Text = Me.LinhaDados.Cells("DESC_EQUIPAMENTO").Value.ToString
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

        Me.ObjModelFk.Tabela = "VW_CG_EQUIPAMENTO_DISPONIVEIS_ENTRADA_MATRIZ"
        Me.ObjModelFk.CampoId = "ID_EQUIPAMENTO"
        Me.ObjModelFk.CampoDesc = "DESC_EQUIPAMENTO"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Descrição"
        Me.ObjModelFk.TituloTela = "Pesquisa de Equipamento"
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
            strFiltro = " where 1=1 and ID_EQUIPAMENTO not in " & strFiltro
        End If
        Me.ObjModelFk.FiltroSQL = strFiltro

        PesquisaFK(Me.ObjModelFk)

        txtIdEquipamento.Text = Me.ObjModelFk.txtId.ToString
        txtDescEquipamento.Text = Me.ObjModelFk.txtDesc

        'Se código do chip selecionado for valido, traz o resto dos campos 
        If (txtIdEquipamento.Text <> "" And txtIdEquipamento.Text <> "0") Then

            'Faz a Query no banco e retorna uma Lista de Array do Comando SQL
            Dim myRow As ArrayList, comandoSQL As String

            comandoSQL = "SELECT ID_EQUIPAMENTO, SERIE, DESC_EQUIPAMENTO, MODELO, CAST(1 AS INT) AS QTD, VALOR "
            comandoSQL += "FROM CG_EQUIPAMENTO(NOLOCK) "
            comandoSQL += "WHERE CG_EQUIPAMENTO.ID_EQUIPAMENTO = " & txtIdEquipamento.Text

            myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)

            If myRow.Count > 0 Then

                txtModelo.Text = myRow(0)(3).ToString
                txtSerie.Text = myRow(0)(1).ToString
                txtQuantidade.Text = myRow(0)(4).ToString
                txtValor.Text = myRow(0)(5).ToString

            Else

                txtModelo.Text = String.Empty
                txtSerie.Text = String.Empty
                txtQuantidade.Text = String.Empty
                txtValor.Text = String.Empty

            End If

        Else

            txtModelo.Text = String.Empty
            txtSerie.Text = String.Empty
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

            strLinha = {"Editar/Visualizar", _
                        txtIdEquipamento.Text.ToString, _
                        txtSerie.Text.ToString, _
                        txtModelo.Text.ToString, _
                        txtDescEquipamento.Text.ToString, _
                        txtQuantidade.Text.ToString, _
                        txtValor.Text.ToString, _
                        txtRomaneio.Text.ToString, _
                        txtUniqueId.Text.ToString}

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

    End Sub

    Private Function listaIdIncluidos() As String
        Dim strLista As String = ""
        'Le todo o Grid e concatena os ID_EQUIPAMENTO numa string separado por virgula (,)
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




End Class