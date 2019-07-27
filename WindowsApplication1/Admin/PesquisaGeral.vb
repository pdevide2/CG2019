
Imports BLL.GlobalBLL
Imports System.Collections.Generic
Imports System.IO.Directory


Public Class PesquisaGeral
    Dim linhaGrid As DataGridViewRow
    Dim _formPai As Object
    Dim _comando As String
    Dim _filtro As String
    Dim _colunaFiltro As String

    Public Property ColunaFiltro() As String
        Get
            Return _colunaFiltro
        End Get
        Set(ByVal value As String)
            _colunaFiltro = value
        End Set
    End Property

    Public Property Comando() As String
        Get
            Return _comando
        End Get
        Set(ByVal value As String)
            _comando = value
        End Set
    End Property

    Public Property Filtro() As String
        Get
            Return _filtro
        End Get
        Set(ByVal value As String)
            _filtro = value
        End Set
    End Property

    Public Property FormPai() As Object
        Get
            Return _formPai
        End Get
        Set(ByVal value As Object)
            _formPai = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef formPai As Object)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.FormPai = formPai 'Retorna a tela em Modo Consulta

        'Atribui o valor da propriedade tabela caso a propriedade view esteja vazia
        If Me.FormPai.View = "" Then
            Me.FormPai.View = Me.FormPai.Tabela
        End If

        Me.Text = "Pesquisa de " & Me.FormPai.Text
        Me.Comando = BLL.GlobalBLL.getComandoSQL(Me.FormPai.View)


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim retorno As List(Of String) = New List(Of String)
        'retorno = BLL.GlobalBLL.getPKBLL(Me.FormPai.Tabela)

        'For Each nome In retorno
        '    MessageBox.Show(nome)
        'Next
        Me.lblTabelaView.Text += Me.FormPai.View
        PreencheCombo()
        Me.ColunaFiltro = cboCampo.Text 'BLL.GlobalBLL.getColunaFiltroSQL(Me.FormPai.View)
        If Me.ColunaFiltro = vbNullString Or Me.ColunaFiltro = "" Then
            txtFiltrar.Enabled = False
        Else
            txtFiltrar.Enabled = True
        End If
        Me.Filtro = ""
        Carregar()
    End Sub

    Private Sub Carregar()
        If Me.Filtro.Equals("") Then
            Me.Filtro = FiltroPadraoEmpresa()
        End If

        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(Me.Comando & Me.Filtro).Tables(0) '.CategoriaBLL.getTodasCategoriasDS.Tables(0)
        dgvDados.AutoResizeColumns()
    End Sub

    Private Sub btnCarregar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SelecionarLinha()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.FormPai.PkString = False Then
            'if alterado em 11/nov/18 para permitir selecionar cadastros com chave primaria negativa (If Me.FormPai.KeyId > 0 Then)
            If Me.FormPai.KeyId <> -1 Then
                Me.FormPai.Acao = 4 '----> não muda nada permance a Mesma acao de antes da chamada desta tela
            Else
                Me.FormPai.Acao = 0
            End If
        Else
            If Me.FormPai.KeyIdStr <> vbNullString Then
                Me.FormPai.Acao = 4 '----> não muda nada permance a Mesma acao de antes da chamada desta tela
            Else
                Me.FormPai.Acao = 0
            End If
        End If

        ' Propriedade KeyId = -1 significa que clicou em Cancel
        If Me.FormPai.PkString = False Then
            Me.FormPai.KeyId = -1
        Else
            Me.FormPai.KeyIdStr = vbNullString
        End If
        Sair()
    End Sub


    Private Sub dgvDados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellDoubleClick

        SelecionarLinha()

    End Sub

    Private Sub Sair()
        Dim blnRet As Boolean
        If Me.FormPai.PkString = False Then
            blnRet = IIf(Me.FormPai.KeyId = -1, False, True)
        Else
            blnRet = IIf(Me.FormPai.KeyIdStr = vbNullString, False, True)
        End If

        If blnRet = True Then
            Try
                Me.FormPai.Acao = 4
                Me.FormPai.LinhaGrid = linhaGrid
            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
        Me.Close()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPesquisarTudo.Click

    End Sub

    Private Sub txtFiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtFiltrar.TextChanged
        Try
            If String.IsNullOrEmpty(txtFiltrar.Text) Then
                'messagebox.show("informe um nome para filtrar.")
                Me.Filtro = FiltroPadraoEmpresa()
                'carregar(me.comando & me.filtro)

            Else
                If optPesquisa1.Checked = True Then
                    Me.Filtro = FiltroPadraoEmpresa() & "  and " & Me.ColunaFiltro & " like '" & Trim(txtFiltrar.Text) & "%' "
                Else
                    Me.Filtro = FiltroPadraoEmpresa() & " and " & Me.ColunaFiltro & " like '%" & Trim(txtFiltrar.Text) & "%' "
                End If

                Carregar()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function FiltroPadraoEmpresa() As String
        Dim retFiltro As String = " where 1 = 1 "
        chkFiltradoEmpresa.Checked = False
        If FiltraPorEmpresa() = True Then
            retFiltro = " where id_empresa = " & Publico.Id_empresa
            chkFiltradoEmpresa.Checked = True
        End If
        Return retFiltro
    End Function

    Private Function FiltraPorEmpresa() As Boolean
        Dim retorno As Boolean = False
        Dim sql As String
        sql = "select * from CG_TABELAS_PESQUISA_DINAMICA WHERE TABELA = '" & Me.FormPai.View & "'"

        Dim bll As New BLL.GlobalBLL
        Dim dt1 = bll.SqlExecDT(sql)
        If dt1.Rows.Count > 0 Then
            retorno = dt1.Rows(0)("filtra_por_empresa")
        End If
        dt1 = Nothing
        Return retorno
    End Function

    Private Sub SelecionarLinha()
        If Me.FormPai.PkString = False Then
            Me.FormPai.KeyId = -1
        Else
            Me.FormPai.KeyIdStr = vbNullString
        End If

        If dgvDados.RowCount > 0 Then
            Try
                If Me.FormPai.PkString = False Then
                    Me.FormPai.KeyId = (CInt(dgvDados.CurrentRow().Cells(Me.FormPai.ColunaId).Value))
                Else
                    Me.FormPai.KeyIdStr = (dgvDados.CurrentRow().Cells(Me.FormPai.ColunaId).Value).ToString
                End If

                linhaGrid = dgvDados.CurrentRow
            Catch ex As Exception

                If Me.FormPai.PkString = False Then
                    Me.FormPai.KeyId = -1
                Else
                    Me.FormPai.KeyIdStr = vbNullString
                End If

                MessageBox.Show("Erro ao retornar a linha: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Sair()
    End Sub

    Private Sub dgvDados_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDados.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Ignora a funcionalidade da tecle Enter e executa a selecao da Linha
            e.SuppressKeyPress = True
            SelecionarLinha()

        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ExportaExcel(dgvDados, Me.FormPai.View)
    End Sub

    Private Sub PreencheCombo()
        Dim bll As New BLL.GlobalBLL
        Dim sql As String
        sql = "SELECT COLUNA FROM CG_PARAMETRO_PESQUISA_DINAMICA "
        sql += "WHERE TABELA = '" & Me.FormPai.View & "' AND COLUNA_FILTRO = 1 "
        sql += "ORDER BY COLUNA_FILTRO_INICIAL DESC, COLUNA "
        Dim dt As DataTable
        dt = bll.SqlExecDT(sql)

        With cboCampo

            .DataSource = dt
            .DisplayMember = "coluna"
            .ValueMember = "coluna"

        End With
    End Sub

    Private Sub cboCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCampo.SelectedIndexChanged
        Me.ColunaFiltro = cboCampo.Text.ToString
    End Sub

    Private Sub txtFiltrar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltrar.KeyPress

        'Clicou no <ENTER> no Textbox do filtro ==> SELECIONAR A LINHA E RETORNAR PARA A TELA QUE CHAMOU COM O REGISTRO SELECIONADO
        If e.KeyChar = Convert.ToChar(13) Then
            SelecionarLinha()
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim myGrid As New DataGridView
        myGrid = PreparaGridView()
        Dim oParametros As New DTO.ParametrosReportPreview
        oParametros.Titulo = Me.Text
        oParametros.Titulo = oParametros.Titulo.Replace("Pesquisa de ", "Relatório de ")
        oParametros.Usuario = UserName()
        Dim frmPrint As New WinCG.ReportPreview(myGrid, oParametros)
        frmPrint.ShowDialog()
        Carregar()
    End Sub
    Private Function PreparaGridView() As DataGridView
        Dim meuDataGridView As New DataGridView
        Dim dt1 As New DataTable
        dt1 = TryCast(Me.dgvDados.DataSource, DataTable)
        Dim dt2 = dt1.Copy()

        meuDataGridView.ColumnCount = dt2.Columns.Count
        With meuDataGridView

            .Name = "meuDataGridView"

            .DataSource = dt2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AutoResizeColumns()

        End With
        Return meuDataGridView
    End Function

End Class