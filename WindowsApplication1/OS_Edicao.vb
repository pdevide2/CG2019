

Public Class OS_Edicao
    Private _id_fornec_os As Integer
    Public Property IdFornecedorOS() As Integer
        Get
            Return _id_fornec_os
        End Get
        Set(ByVal value As Integer)
            _id_fornec_os = value
        End Set
    End Property
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

    Public Sub New(ByVal _acao As Integer, ByRef _gridDados As DataGridView, ByVal _chavePai As Integer, ByVal _linhaGrid As DataGridViewRow, ByVal _idFornecedor As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.LinhaDados = _linhaGrid
        Me.ChavePai = _chavePai.ToString
        Me.GridPai = _gridDados
        Me.Modo = "existe"
        Me.Acao = _acao
        Me.IdFornecedorOS = _idFornecedor

    End Sub
    Public Sub New(ByVal _acao As Integer, ByRef _gridDados As DataGridView, ByVal _chavePai As Integer, ByVal _idFornecedor As Integer)

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
        txtId_OS.Tag = "Número da OS"
        txtItemId.Tag = "Item Id#"
        txtIdEquipamento.Tag = "Código do Equipamento"
        txtSerie.Tag = "Série"
        txtModelo.Tag = "Modelo"
        txtDescEquipamento.Tag = "Descrição do Equipamento"
        txtPrevisaoRetorno.Tag = "Previsão de Retorno"
        txtDescDefeito.Tag = "Descrição do Defeito"

        LimpaControles()
        CarregaCombo()
        Carrega_Dados()

        HabilitaBotoesFilha(Me.Acao)


    End Sub

    Private Sub Carrega_Dados()
        'dgvDados.Columns.AddRange(New DataGridViewColumn() {colBotao, colId_OS, colItem_ID, colId_Equipamento, colDescEquipamento, _
        '                                    colSerie, colModelo, colPrevisaoRetorno, colDescDefeito, _
        '                                    colConsertoOk, colIdTipoEquipamento, colDescTipoEquipamento})
        If Me.Modo = "existe" Then
            txtId_OS.Text = Me.LinhaDados.Cells("ID_OS").Value.ToString
            txtItemId.Text = Me.LinhaDados.Cells("ITEM_ID").Value.ToString
            txtIdEquipamento.Text = Me.LinhaDados.Cells("ID_EQUIPAMENTO").Value.ToString
            txtSerie.Text = Me.LinhaDados.Cells("SERIE").Value.ToString
            txtModelo.Text = Me.LinhaDados.Cells("MODELO").Value.ToString
            txtDescEquipamento.Text = Me.LinhaDados.Cells("DESC_EQUIPAMENTO").Value.ToString
            txtPrevisaoRetorno.Text = Me.LinhaDados.Cells("PREVISAO_RETORNO").Value.ToString
            txtDescDefeito.Text = Me.LinhaDados.Cells("DESC_DEFEITO").Value.ToString
            chkGarantia.Checked = CBool(Me.LinhaDados.Cells("GARANTIA").Value)
            If Not String.IsNullOrEmpty(Me.LinhaDados.Cells("ID_TABELA").Value) Then
                cboTabelaServico.Text = Me.LinhaDados.Cells("ID_TABELA").Value.ToString
            End If
        End If
    End Sub


    Private Sub btnEditaSalva_Click(sender As Object, e As EventArgs) Handles btnEditaSalva.Click

        If EditaLinha() Then
            MessageBox.Show("Atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub PesquisaFK(oPesqFk As DTO.PesquisaFK)

        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica(Me, oPesqFk)
        frm.Owner = Me
        frm.ShowDialog()

    End Sub

    Private Function EditaLinha()
        Dim blnRetorno As Boolean = False
        If ValidaCampos() Then
            If Atualiza_Grid() Then
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

    Private Function Atualiza_Grid()
        Try

            Me.GridPai.CurrentRow.Cells("PREVISAO_RETORNO").Value = txtPrevisaoRetorno.Text.ToString
            Me.GridPai.CurrentRow.Cells("DESC_DEFEITO").Value = txtDescDefeito.Text.ToString
            Me.GridPai.CurrentRow.Cells("GARANTIA").Value = chkGarantia.Checked.ToString
            Me.GridPai.CurrentRow.Cells("ID_TABELA").Value = cboTabelaServico.Text.ToString

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

        txtPrevisaoRetorno.Enabled = blnModo
        chkGarantia.Enabled = blnModo
        txtDescDefeito.Enabled = blnModo

    End Sub

    Private Function listaIdIncluidos() As String
        Dim strLista As String = ""
        'Le todo o Grid e concatena os ID_EQUIPAMENTO numa string separado por virgula (,)
        For Each row As DataGridViewRow In Me.GridPai.Rows

            If Not row.IsNewRow Then

                'Carrega os dados no objeto Model para passagem de parametro
                strLista += row.Cells("ID_EQUIPAMENTO").Value & ","

            End If

        Next
        'Tira a última virgula (,) e adiciona os "( )"
        If Not String.IsNullOrEmpty(strLista) Then
            strLista = "(" & strLista.Substring(0, Len(strLista) - 1) & ")"
        End If

        Return strLista
    End Function
    Private Sub CarregaCombo()

        Try
            Dim bllGlobal As New BLL.GlobalBLL

            cboTabelaServico.DataSource = Nothing
            cboTabelaServico.DisplayMember = Nothing
            cboTabelaServico.Items.Clear()

            Dim sql As String
            sql = "Select id_tabela "
            sql += " From CG_TABELA_SERVICOS_FORNECEDOR where id_fornecedor = " & Me.IdFornecedorOS & " order by ID_TABELA"

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