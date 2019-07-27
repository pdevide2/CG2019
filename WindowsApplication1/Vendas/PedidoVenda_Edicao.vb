''' <summary>
''' Tela para editar/exbir linhas no pedido de venda
''' </summary>

Public Class PedidoVenda_Edicao
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
        txtPedido.Tag = "Pedido Nº"
        txtStatus.Tag = "Status"
        txtIdEquipamento.Tag = "Código do Equipamento"
        txtSerie.Tag = "Série"
        txtModelo.Tag = "Modelo"
        txtPrecoVenda.Tag = "Preço Venda"
        LimpaControles()
        Carrega_Dados()

        HabilitaBotoesFilha(Me.Acao)


    End Sub

    Private Sub Carrega_Dados()
        'dgvDados.Columns.AddRange(New DataGridViewColumn() {colBotao, colId_OS, colItem_ID, colId_Equipamento, colDescEquipamento, _
        '                                    colSerie, colModelo, colPrevisaoRetorno, colDescDefeito, _
        '                                    colConsertoOk, colIdTipoEquipamento, colDescTipoEquipamento})
        If Me.Modo = "existe" Then
            txtPedido.Text = Me.LinhaDados.Cells("ID_PEDIDO").Value.ToString
            txtStatus.Text = Me.LinhaDados.Cells("STATUS_ITEM").Value.ToString
            txtIdEquipamento.Text = Me.LinhaDados.Cells("ID_EQUIPAMENTO").Value.ToString
            txtSerie.Text = Me.LinhaDados.Cells("SERIE").Value.ToString
            txtModelo.Text = Me.LinhaDados.Cells("MODELO").Value.ToString
            txtQtde.Text = Me.LinhaDados.Cells("QTDE").Value.ToString
            txtPrecoVenda.Text = Me.LinhaDados.Cells("PRECO_VENDA").Value.ToString
            txtDataCadastro.Text = Me.LinhaDados.Cells("DATA_CADASTRO").Value.ToString


            If String.IsNullOrEmpty(Me.LinhaDados.Cells("DATA_BAIXA").Value) Then
                txtDataBaixa.Text = Nothing
            Else
                txtDataBaixa.Text = Me.LinhaDados.Cells("DATA_BAIXA").Value.ToString
            End If

            txtUltimaAlteracao.Text = Me.LinhaDados.Cells("ULTIMA_ALTERACAO").Value.ToString
            If CBool(Me.LinhaDados.Cells("CANCEL").Value) = True Then
                chkCancelado.Checked = True
            Else
                chkCancelado.Checked = False
            End If
        End If
    End Sub


    Private Sub btnEditaSalva_Click(sender As Object, e As EventArgs) Handles btnEditaSalva.Click

        If EditaLinha() Then
            MessageBox.Show("Atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
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

            'Me.GridPai.CurrentRow.Cells("PREVISAO_RETORNO").Value = txtPrevisaoRetorno.Text.ToString
            'Me.GridPai.CurrentRow.Cells("DESC_DEFEITO").Value = txtDescDefeito.Text.ToString
            'Me.GridPai.CurrentRow.Cells("GARANTIA").Value = chkGarantia.Checked.ToString
            'Me.GridPai.CurrentRow.Cells("ID_TABELA").Value = cboTabelaServico.Text.ToString

            Me.GridPai.CurrentRow.Cells("PRECO_VENDA").Value = txtPrecoVenda.Text.ToString

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
        txtPrecoVenda.Enabled = blnModo
        txtPrecoVenda.ReadOnly = Not blnModo
        btnFechar.Enabled = True

        'txtPrevisaoRetorno.Enabled = blnModo
        'chkGarantia.Enabled = blnModo
        'txtDescDefeito.Enabled = blnModo

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

End Class