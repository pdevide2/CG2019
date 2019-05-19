Imports BLL.GlobalBLL
Imports System.Collections.Generic
Imports System.IO.Directory

Public Class Estoque_equipamento

    Public podeAbrir As Boolean = False
    'variavel flagAcao o Default é readonly, após verificar permissão no módulo pode mudar para Limpar (0)
    Public flagAcao As Integer = Operacao.Leitura
    Dim _acao As Integer
    Dim _acesso As String
    Dim _objModelFk As Object

    Public Enum Operacao

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum
    Property ObjModelFk() As Object
        Get
            Return _objModelFk
        End Get
        Set(ByVal value As Object)
            _objModelFk = value
        End Set
    End Property

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
    Private _view As String
    Public Property View() As String
        Get
            Return _view
        End Get
        Set(ByVal value As String)
            _view = value
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

    Private Sub Estoque_chip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio()
    End Sub


    Private Sub Inicio()
        Dim sql As String
        'sql = "SELECT ID_EQUIPAMENTO, SERIE, MODELO, DESC_EQUIPAMENTO, ESTOQUE, TRANSITO, VALOR, ID_LOCAL, NOME, SIGLA, DATAMOV, ID_LOCAL_ESTOQUE, ID_TIPO_EQUIPAMENTO, TIPO_LOCAL "
        'sql += " FROM VW_CG_ESTOQUE_EQUIPAMENTO WHERE 1=1 "

        sql = "SELECT ID_EQUIPAMENTO, SERIE, MODELO, DESC_EQUIPAMENTO, ESTOQUE, TRANSITO, "
        sql += "VALOR, CODIGO, NOME, LOJA_FISICA, ID_AREA, TIPO_LOCAL, DATAMOV, SIGLA,  "
        sql += "ID_LOCAL_ESTOQUE, ID_LOCAL  "
        sql += " FROM VW_CG_ESTOQUE_EQUIPAMENTO WHERE 1=1 "
        sql += FiltroSQL() 'Pega a String de filtro e concatena 
        sql += " ORDER BY ID_EQUIPAMENTO "

        'Copia conteudo da query para a Clipboard (Area de Transferência)
        'My.Computer.Clipboard.SetText(sql)

        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        dgvDados.AutoResizeColumns()
        lblTotalRegistros.Text = "A pesquisa retornou " & dgvDados.RowCount & " linhas..."
        'Troca fonte e atualiza os headertext
        UpdateFont()

        Aviso()
    End Sub

    Private Function FiltroSQL() As String
        Dim strFiltro As String = "", strChkFiltro As String = ""
        Dim strLocalFiltro(4) As String
        Dim strTipoFiltro As String = ""
        'Filtro de Data 
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            strFiltro += " AND ( DATAMOV >= '" & Trim(TextBox1.Text) & " 00:00:00' AND DATAMOV <= '" & Trim(TextBox1.Text) & " 23:59:59' ) "
        End If

        'Filtro de Loja/Local de Estoque
        If Len(Trim(txtIdLoja.Text)) > 0 Then
            strFiltro += " AND ID_LOCAL_ESTOQUE = " & Trim(txtIdLoja.Text)
        End If

        'Filtro de Area
        If Len(Trim(txtIdArea.Text)) > 0 Then
            strFiltro += " AND ID_AREA = '" & Trim(txtIdArea.Text) & "' "
        End If

        'Filtro de Local de Transito 
        If Len(Trim(txtIdTransito.Text)) > 0 Then
            strFiltro += " AND ID_LOCAL_ESTOQUE = " & Trim(txtIdTransito.Text)
        End If

        'RadioButton Tipo de Local de Estoque
        '------------------------------------
        If radTransito.Checked = True Then
            strFiltro += " AND TIPO_LOCAL = 'T' AND TRANSITO = 1 "
        End If

        If radLoja.Checked = True Then
            strFiltro += " AND TIPO_LOCAL = 'L' AND TRANSITO = 0 "
        End If
        '==========================================================

        'RadioButton Tipo de Loja
        '------------------------------------
        If radFisica.Checked = True Then
            strFiltro += " AND LOJA_FISICA = 1 "
        End If

        If radNaoFisica.Checked = True Then
            strFiltro += " AND LOJA_FISICA = 0 "
        End If
        '==========================================================
        strLocalFiltro(0) = IIf(chkMatriz.Checked = True, "1", "")
        strLocalFiltro(1) = IIf(chkAssistencia.Checked = True, "2", "")
        strLocalFiltro(2) = IIf(chkQuarentena.Checked = True, "7", "")
        strLocalFiltro(3) = IIf(chkInativo.Checked = True, "8", "")
        strLocalFiltro(4) = IIf(chkDevolveu.Checked = True, "9", "")

        strTipoFiltro = IIf(Len(Trim(strFiltro)) > 0, " OR ", " AND ")
        For ixx = 0 To 4
            If Len(Trim(strChkFiltro)) = 0 And Len(Trim(strLocalFiltro(ixx))) > 0 Then
                strChkFiltro += strTipoFiltro & " (TIPO_LOCAL = 'L' AND ID_LOCAL_ESTOQUE IN (" & strLocalFiltro(ixx)
            Else
                If Len(Trim(strLocalFiltro(ixx))) > 0 Then
                    strChkFiltro += "," & strLocalFiltro(ixx)
                End If
            End If
        Next
        If Len(Trim(strChkFiltro)) > 0 Then
            strChkFiltro += ")) "
        End If


        Return strFiltro & strChkFiltro
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ExportaExcel(dgvDados, "Estoque_Chip")
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Inicio()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        ' Volta para o Default - Traz tudo 
        '**********************************
        txtIdLoja.Text = ""
        txtDescLoja.Text = ""

        TextBox1.Text = "" 'Data do Estoque

        txtIdTransito.Text = ""
        txtDescTransito.Text = ""

        txtIdArea.Text = ""
        txtDescArea.Text = ""


        radAmbos.Checked = True
        radFisica.Checked = False
        radNaoFisica.Checked = False

        radLojaTransito.Checked = True
        radLoja.Checked = False
        radTransito.Checked = False

        chkDevolveu.Checked = False
        chkInativo.Checked = False
        chkMatriz.Checked = False
        chkQuarentena.Checked = False
        chkAssistencia.Checked = False

    End Sub

    Public Sub PesquisaFK(oPesqFk As DTO.PesquisaFK)
        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica(Me, oPesqFk)
        frm.Owner = Me
        frm.ShowDialog()

    End Sub
    Public Sub PesquisaFK2(oPesqFk As DTO.PesquisaFK)
        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica2(Me, oPesqFk)
        frm.Owner = Me
        frm.ShowDialog()

    End Sub
    Private Sub btnPesqLoja_Click(sender As Object, e As EventArgs) Handles btnPesqLoja.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "VW_BUSCA_CG_LOJA"
        Me.ObjModelFk.CampoId = "ID_LOJA"
        Me.ObjModelFk.CampoDesc = "NOME"
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Loja"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.CampoId & ", " & Me.ObjModelFk.CampoDesc & _
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where (1 = 1) "

        PesquisaFK(Me.ObjModelFk)

        txtIdLoja.Text = Me.ObjModelFk.txtId.ToString
        txtDescLoja.Text = Me.ObjModelFk.txtDesc

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumerosData(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated
        If Not validaData(TextBox1.Text) Then
            MessageBox.Show("Data Inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Aviso()
        Dim frm As Object
        Try
            frm = New WaitWindow("A pesquisa retornou " & dgvDados.RowCount.ToString & " registros", 2)

            frm.Show()   'frm is object of WaitForm
            'Perform the process for databinding, etc
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgvDados_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvDados.RowPrePaint
        If dgvDados.Rows(e.RowIndex).Cells("TIPO_LOCAL").Value = "T" Then
            For ixx = 0 To dgvDados.ColumnCount - 1
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Green
            Next
        Else
            Dim _id_local_estoque As String = ""
            For ixx = 0 To dgvDados.ColumnCount - 1

                _id_local_estoque = Trim(dgvDados.Rows(e.RowIndex).Cells("ID_LOCAL_ESTOQUE").Value)

                If _id_local_estoque = "7" Then '--> QUARENTENA
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Red

                ElseIf _id_local_estoque = "2" Then '--> ASSISTENCIA TECNICA
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Brown

                ElseIf _id_local_estoque = "9" Then '--> DEVOLVEU FORNECEDOR
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Blue

                ElseIf _id_local_estoque = "8" Then '--> INATIVO
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Black

                Else ' TODOS OS OUTROS TIPOS DE LOCAL
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.Black
                    dgvDados.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.White

                End If

            Next

        End If
    End Sub

    Private Sub UpdateFont()


        Me.dgvDados.DefaultCellStyle.Font = New Font("Tahoma", 10.0F, GraphicsUnit.Pixel)
        Dim colHeader() As String

        colHeader = {"Id Equipto", "Série", "Modelo", "Descrição Equipamento", "Estoque", _
                     "Transito", "Custo", "Codigo", "Nome Local", "Loja Física", _
                     "Área", "Tipo Local", "Dt. Movto", "Sigla", _
                      "Id Local Estoque", "Id Local"}

        For ixx = 0 To dgvDados.ColumnCount - 1
            dgvDados.Columns(ixx).HeaderText = colHeader(ixx)
        Next
        'For Each c As DataGridViewColumn In dgvDados.Columns

        '    c.DefaultCellStyle.Font = New Font("Arial", 8.5F, GraphicsUnit.Pixel)
        'Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "VW_CG_AREA"
        Me.ObjModelFk.CampoId = "ID_AREA"
        Me.ObjModelFk.CampoDesc = "DESC_AREA"
        Me.ObjModelFk.ListaCampos = "ID_AREA, DESC_AREA, ID_RESPONSAVEL, NOME"
        Me.ObjModelFk.ColunasFiltro = "DESC_AREA,NOME" ' ComboBox de filtros
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Áreas"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.ListaCampos & _
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where 1=1 "

        PesquisaFK2(Me.ObjModelFk)

        txtIdArea.Text = Me.ObjModelFk.txtId.ToString
        txtDescArea.Text = Me.ObjModelFk.txtDesc

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_TRANSITO"
        Me.ObjModelFk.CampoId = "ID_TRANSITO"
        Me.ObjModelFk.CampoDesc = "NOME_TRANSITO"
        Me.ObjModelFk.ListaCampos = "ID_TRANSITO, NOME_TRANSITO"
        Me.ObjModelFk.ColunasFiltro = "NOME_TRANSITO,ID_TRANSITO" ' ComboBox de filtros
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Transitos"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.ListaCampos & _
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where (INATIVO=0) "

        PesquisaFK2(Me.ObjModelFk)

        txtIdTransito.Text = Me.ObjModelFk.txtId.ToString
        txtDescTransito.Text = Me.ObjModelFk.txtDesc

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim codigo As String
        Dim descricao As String
        codigo = Me.PesqFK1.txtId.Text
        descricao = Me.PesqFK1.txtDesc.Text

        MessageBox.Show("Codigo = " & codigo & Chr(13) & "Descricao = " & descricao, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub

    Private Sub PesqFK1_Load(sender As Object, e As EventArgs) Handles PesqFK1.Load
        With Me.PesqFK1
            .LabelPesqFK = "Usuário"
            .Tabela = "CG_USUARIO"
            .View = "CG_USUARIO"
            .CampoId = "ID_USUARIO"
            .CampoDesc = "NOME"

            .ListaCampos = "ID_USUARIO, NOME"
            .ColunasFiltro = "NOME,ID_USUARIO" ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de USUÁRIOS"

            .lblLabelFK.Text = .LabelPesqFK

            .txtId.Width = 54
            .txtDesc.Left -= 20
            .txtDesc.Width += 20
            .Width += 10
            '.btnPesq.Left -= 20
        End With
    End Sub

    Private Sub PesqFK2_Load(sender As Object, e As EventArgs) Handles PesqFK2.Load
        With Me.PesqFK2
            .LabelPesqFK = "Modulo"
            .Tabela = "CG_MODULO"
            .View = "CG_MODULO"
            .CampoId = "ID_MODULO"
            .CampoDesc = "DESC_MODULO"

            .ListaCampos = "ID_MODULO, DESC_MODULO"
            .ColunasFiltro = "DESC_MODULO,ID_MODULO" ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Módulos"

            .lblLabelFK.Text = .LabelPesqFK
            '.txtId.Width = 54
            '.txtDesc.Left -= 20
            '.txtDesc.Width += 20
            '.Width += 10
            '.btnPesq.Left -= 20
        End With

    End Sub
End Class