Imports BLL.GlobalBLL
Imports System.Collections.Generic

Public Class PesquisaDinamica2
    Dim linhaGrid As DataGridViewRow
    Dim _formPai As Object
    Dim _codigo_fk As Integer
    Dim _descricao_fk As String
    Dim _tabelafk_ As String
    Dim _comando As String
    Dim _filtro As String
    Dim _colunas_filtro As String

    Public Property ColunasFiltro() As String
        Get
            Return _colunas_filtro
        End Get
        Set(ByVal value As String)
            _colunas_filtro = value
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

    Public Property Tabela_fk() As String
        Get
            Return _tabelafk_
        End Get
        Set(ByVal value As String)
            _tabelafk_ = value
        End Set
    End Property

    Public Property Codigo_fk() As Integer
        Get
            Return _codigo_fk
        End Get
        Set(ByVal value As Integer)
            _codigo_fk = value
        End Set
    End Property

    Public Property Descricao_fk() As String
        Get
            Return _descricao_fk
        End Get
        Set(ByVal value As String)
            _descricao_fk = value
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


    Private _orderByQuery As String
    Public Property OrderByQuery() As String
        Get
            Return _orderByQuery
        End Get
        Set(ByVal value As String)
            _orderByQuery = value
        End Set
    End Property
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef formPai As Object, oPesquisa As DTO.PesquisaFK)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.FormPai = formPai 'Retorna a tela em Modo Consulta
        Me.Text = oPesquisa.TituloTela

        'Me.Codigo_fk = oPesquisa.CampoId
        'Me.Descricao_fk = oPesquisa.CampoDesc

        Me.Tabela_fk = oPesquisa.Tabela
        Me.Comando = oPesquisa.ComandoSQL
        Me.Filtro = oPesquisa.FiltroSQL
        Me.ColunasFiltro = oPesquisa.ColunasFiltro
        Me.OrderByQuery = IIf(String.IsNullOrEmpty(oPesquisa.OrderByQuery), "", oPesquisa.OrderByQuery)

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim retorno As List(Of String) = New List(Of String)
        'retorno = BLL.GlobalBLL.getPKBLL(Me.FormPai.Tabela)

        'For Each nome In retorno
        '    MessageBox.Show(nome)
        'Next
        If Len(Trim(Me.Filtro)) = 0 Then
            Me.Filtro = " Where 1 = 0 " 'Traz a estrutura apenas
        End If
        Carregar(Me.Comando & Me.Filtro & Me.OrderByQuery)
        PreencheCombo()
        TextBox1.Focus()

    End Sub

    Private Sub Carregar(_querySQL)
        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(_querySQL).Tables(0) '.CategoriaBLL.getTodasCategoriasDS.Tables(0)
        dgvDados.AutoResizeColumns()
    End Sub

    Private Sub btnCarregar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If dgvDados.RowCount > 0 Then
            Try

                'Me.FormPai.ObjModelFk.txtId = (CInt(dgvDados.CurrentRow().Cells(Me.FormPai.ObjModelFk.CampoId).Value))
                Me.FormPai.ObjModelFk.txtId = dgvDados.CurrentRow().Cells(Me.FormPai.ObjModelFk.CampoId).Value
                Me.FormPai.ObjModelFk.txtDesc = dgvDados.CurrentRow().Cells(Me.FormPai.ObjModelFk.CampoDesc).Value


                'linhaGrid = dgvDados.CurrentRow
            Catch ex As Exception

                Me.FormPai.ObjModelFk.txtId = -1

                MessageBox.Show("Erro ao retornar a linha: " & ex.HResult.ToString & " --> " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Sair()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Sair()
    End Sub


    Private Sub dgvDados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellDoubleClick

        If dgvDados.RowCount > 0 Then
            Try

                'Me.FormPai.ObjModelFk.txtId = (CInt(dgvDados.CurrentRow().Cells(Me.FormPai.ObjModelFk.CampoId).Value))
                Me.FormPai.ObjModelFk.txtId = dgvDados.CurrentRow().Cells(Me.FormPai.ObjModelFk.CampoId).Value
                Me.FormPai.ObjModelFk.txtDesc = dgvDados.CurrentRow().Cells(Me.FormPai.ObjModelFk.CampoDesc).Value


                'linhaGrid = dgvDados.CurrentRow
            Catch ex As Exception

                Me.FormPai.ObjModelFk.txtId = -1

                MessageBox.Show("Erro ao retornar a linha: " & ex.HResult.ToString & " --> " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Sair()
    End Sub

    Private Sub Sair()

        Me.Close()

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If String.IsNullOrEmpty(TextBox1.Text) Then
                'MessageBox.Show("Informe um nome para filtrar.")
                Me.Filtro = " where 1 = 1 "
                Carregar(Me.Comando & Me.Filtro)

            Else
                'If optPesquisa1.Checked = True Then
                '    Me.Filtro = " where 1 = 1 and " & Me.FormPai.ObjModelFk.CampoDesc & " like '" & Trim(TextBox1.Text) & "%' "
                'Else
                '    Me.Filtro = " where 1 = 1 and " & Me.FormPai.ObjModelFk.CampoDesc & " like '%" & Trim(TextBox1.Text) & "%' "
                'End If

                If optPesquisa1.Checked = True Then
                    Me.Filtro = " where 1 = 1 and " & cboCampo.Text & " like '" & Trim(TextBox1.Text) & "%' "
                Else
                    Me.Filtro = " where 1 = 1 and " & cboCampo.Text & " like '%" & Trim(TextBox1.Text) & "%' "
                End If

                Carregar(Me.Comando & Me.Filtro)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Filtro = " where 1 = 1 "
            Carregar(Me.Comando & Me.Filtro)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Chamatela(Me.Tabela_fk)
    End Sub

    Public Sub Chamatela(_tabela As String)
        Dim frm As Object
        Select Case _tabela
            Case "CG_STATUS"
                frm = New WinCG.Status
                frm.ShowDialog()
            Case "CG_USUARIO"
                frm = New WinCG.Usuarios
                frm.ShowDialog()
            Case "CG_CARGO"
                frm = New WinCG.Cargo
                frm.ShowDialog()
            Case "CG_ALOCACAO"
                frm = New WinCG.Alocacao
                frm.ShowDialog()
            Case "CG_RESPONSAVEL"
                frm = New WinCG.Responsavel
                frm.ShowDialog()
            Case "CG_TIPO_SERVICO"
                frm = New WinCG.TipoServico
                frm.ShowDialog()
            Case "CG_OPERADORA"
                frm = New WinCG.Operadora
                frm.ShowDialog()
            Case "CG_FORNECEDOR"
                frm = New WinCG.Fornecedores
                frm.ShowDialog()
            Case "CG_TIPO_EQUIPAMENTO"
                frm = New WinCG.TipoEquipamento
                frm.ShowDialog()
        End Select
        frm = Nothing
    End Sub
    Private Sub PreencheCombo()
        Dim bll As New BLL.GlobalBLL
        Dim sql As String
        sql = "SELECT COLUNA FROM CG_PARAMETRO_PESQUISA_DINAMICA "
        sql += "WHERE TABELA = '" & Me.FormPai.View & "' AND COLUNA_FILTRO = 1 "
        sql += "ORDER BY COLUNA_FILTRO_INICIAL DESC, COLUNA "

        Dim listaColunas As String() = Me.ColunasFiltro.Split(",")


        With cboCampo

            .DataSource = listaColunas
            '.DisplayMember = "coluna"
            '.ValueMember = "coluna"
            .SelectedIndex = 0

        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show(Me.Filtro)
    End Sub
End Class