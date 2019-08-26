Imports BLL.GlobalBLL
Imports System.Collections.Generic
Imports System.IO.Directory

Public Class ConsultaEstoque

    Const ID_LOJA As Integer = 0
    Const ID_AREA As Integer = 1
    Const ID_TRANSITO As Integer = 2

    Public podeAbrir As Boolean = False
    'variavel flagAcao o Default é readonly, após verificar permissão no módulo pode mudar para Limpar (0)
    Public flagAcao As Integer = Operacao.Leitura
    Dim _acao As Integer
    Dim _acesso As String
    Dim _objModelFk As Object

    Private ar_filtro() As String

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
    Private _tipoEstoque As String
    Public Property TipoEstoque() As String
        Get
            Return _tipoEstoque
        End Get
        Set(ByVal value As String)
            _tipoEstoque = value
        End Set
    End Property

    Public Sub New(ByVal _tipoEstoque As String)

        ' This call is required by the designer.
        InitializeComponent()
        LoginCG() 'Carrega variavel Friend ACE_CODIGO pelo Setting ID_USER
        ' Add any initialization after the InitializeComponent() call.

        Me.TipoEstoque = _tipoEstoque 'Parametro _tipoEstoque: (C) Chip ou (E) Equipamento

        podeAbrir = permissaoTela(ACE_MODULO, ACE_CODIGO)

    End Sub
    Public Function permissaoTela(ByVal intModulo As Integer, ByVal intUsuario As Integer) As Boolean
        flagAcao = Operacao.Limpar
        Dim strPermissao As String = ""
        Return True
        'strPermissao = verPermissao(intModulo, intUsuario)

        'Me.Acesso = strPermissao

        'If strPermissao = "S" Then
        '    MessageBox.Show("Usuário sem permissão de acesso neste módulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'ElseIf strPermissao = "L" Then
        '    flagAcao = Operacao.Leitura
        'ElseIf strPermissao = "G" Then
        '    flagAcao = Operacao.Limpar
        'Else
        '    MessageBox.Show("Configurações de permissão para este módulo não encontrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False

        'End If
        'Me.Acao = flagAcao
        'Return True
    End Function
    Function verPermissao(ByVal modulo As Integer, ByVal usuario As Integer) As String

        Dim retorno As String
        Dim oBLL As New BLL.GlobalBLL

        retorno = oBLL.getPermissaoBLL(modulo, usuario)
        Return retorno

    End Function

    Private Sub Estoque_chip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Me.TipoEstoque = "C" Then
        '    Me.Text = "Consulta de Estoque de Chip"
        'ElseIf Me.TipoEstoque = "E" Then
        '    Me.Text = "Consulta de Estoque de Equipamento (POS)"
        'End If
        Me.Text = "Consulta Geral de Estoque de Chip/POS"
        LimpaControles()
        Inicio()
    End Sub


    Private Sub Inicio()
        Dim sql As String = ""
        'sql = "SELECT ID_EQUIPAMENTO, SERIE, MODELO, DESC_EQUIPAMENTO, ESTOQUE, TRANSITO, VALOR, ID_LOCAL, NOME, SIGLA, DATAMOV, ID_LOCAL_ESTOQUE, ID_TIPO_EQUIPAMENTO, TIPO_LOCAL "
        'sql += " FROM VW_CG_ESTOQUE_EQUIPAMENTO WHERE 1=1 "
        Dim iqq As Integer
        For iqq = 1 To 2

            If iqq = 1 Then
                Me.TipoEstoque = "C"
            Else
                Me.TipoEstoque = "E"
            End If

            If Me.TipoEstoque = "E" Then
                sql = "SELECT ID_EQUIPAMENTO, SERIE, MODELO, DESC_EQUIPAMENTO, ESTOQUE, TRANSITO, "
                sql += "VALOR, CODIGO, NOME, LOJA_FISICA, ID_AREA, TIPO_LOCAL, DATAMOV, SIGLA,  "
                sql += "ID_LOCAL_ESTOQUE, ID_LOCAL, ID_OS  "
                sql += " FROM VW_CG_ESTOQUE_EQUIPAMENTO WHERE ID_EMPRESA = " & Publico.Id_empresa
                sql += FiltroSQL() 'Pega a String de filtro e concatena 
                sql += " ORDER BY ID_EQUIPAMENTO "

            ElseIf Me.TipoEstoque = "C" Then
                sql = "SELECT ID_CHIP, SIMID, DESC_OPERADORA, ESTOQUE, TRANSITO, "
                sql += "CUSTO, CODIGO, NOME, LOJA_FISICA, ID_AREA, TIPO_LOCAL, DATAMOV, SIGLA,  "
                sql += "ID_LOCAL_ESTOQUE, ID_LOCAL, ID_OPERADORA, '' AS ID_OS  "
                sql += " FROM VW_CG_ESTOQUE_CHIP WHERE ID_EMPRESA = " & Publico.Id_empresa
                sql += FiltroSQL() 'Pega a String de filtro e concatena 
                sql += " ORDER BY ID_CHIP "

            End If

            'Copia conteudo da query para a Clipboard (Area de Transferência)
            'My.Computer.Clipboard.SetText(sql)
            If iqq = 1 Then
                dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
                dgvDados.Columns(0).Visible = False
                dgvDados.Columns(14).Visible = False
                dgvDados.Columns(15).Visible = False
                dgvDados.AutoResizeColumns()
            Else
                dgvDados2.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
                dgvDados2.Columns(0).Visible = False
                dgvDados2.Columns(15).Visible = False
                dgvDados2.AutoResizeColumns()
            End If
            'lblTotalRegistros.Text = "A pesquisa retornou " & dgvDados.RowCount & " linhas..."
            'Troca fonte e atualiza os headertext
            UpdateFont()

            'Aviso()
        Next

    End Sub

    Private Function FiltroSQL() As String
        Dim strFiltro As String = "", strChkFiltro As String = ""
        Dim strLocalFiltro(4) As String
        Dim strTipoFiltro As String = ""

        ar_filtro(ID_LOJA) = IIf(String.IsNullOrEmpty(PesqFKLoja.txtId.Text.ToString), "", PesqFKLoja.txtId.Text.ToString)
        ar_filtro(ID_AREA) = IIf(String.IsNullOrEmpty(PesqFKArea.txtId.Text.ToString), "", PesqFKArea.txtId.Text.ToString)
        ar_filtro(ID_TRANSITO) = IIf(String.IsNullOrEmpty(PesqFKTransito.txtId.Text.ToString), "", PesqFKTransito.txtId.Text.ToString)

        'Filtro de Data 
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            'strFiltro += " AND ( DATAMOV >= '" & Trim(TextBox1.Text) & " 00:00:00' AND DATAMOV <= '" & Trim(TextBox1.Text) & " 23:59:59' ) "
            strFiltro += " AND ( DATAMOV >= '" & Dtos(SomaData("D", 0, Trim(TextBox1.Text))) & "' AND DATAMOV < '" & Dtos(SomaData("D", 1, Trim(TextBox2.Text))) & "') "
        End If

        'Filtro de Loja/Local de Estoque
        If Len(Trim(ar_filtro(ID_LOJA))) > 0 Then
            strFiltro += " AND ID_LOCAL_ESTOQUE = " & Trim(ar_filtro(ID_LOJA))
        End If

        'Filtro de Area
        If Len(Trim(ar_filtro(ID_AREA))) > 0 Then
            strFiltro += " AND ID_AREA = '" & Trim(ar_filtro(ID_AREA)) & "' "
        End If

        'Filtro de Local de Transito 
        If Len(Trim(ar_filtro(ID_TRANSITO))) > 0 Then
            strFiltro += " AND ID_LOCAL_ESTOQUE = " & Trim(ar_filtro(ID_TRANSITO))
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
        If Len(strFiltro) = 0 Then
            MessageBox.Show("Atenção! Preencha os filtros com pelo menos algum valor, consulta lenta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return strFiltro & strChkFiltro
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ExportaExcel2(dgvDados, dgvDados2, "Estoque", "Estoque_Chip", "Estoque_POS")
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Inicio()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimpaControles()

    End Sub
    Private Sub LimpaControles()
        ' Volta para o Default - Traz tudo 
        '**********************************
        TextBox1.Text = SomaData("D", -30, Trim(ShortDate()))  'Data de Hoje - 30 dias
        TextBox2.Text = ShortDate() 'Data de hoje

        With PesqFKArea
            .txtId.Text = ""
            .txtDesc.Text = ""
        End With
        With PesqFKLoja
            .txtId.Text = ""
            .txtDesc.Text = ""
        End With
        With PesqFKTransito
            .txtId.Text = ""
            .txtDesc.Text = ""
        End With

        ar_filtro = {"", "", ""}

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
        Else
            If String.IsNullOrEmpty(TextBox2.Text) Then
                TextBox2.Text = TextBox1.Text
            End If
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
        'Exit Sub
        Try
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

        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvDados2_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvDados2.RowPrePaint
        'Exit Sub
        Try
            If dgvDados2.Rows(e.RowIndex).Cells("TIPO_LOCAL").Value = "T" Then
                For ixx = 0 To dgvDados2.ColumnCount - 1
                    dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                    dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Green
                Next
            Else
                Dim _id_local_estoque As String = ""
                For ixx = 0 To dgvDados2.ColumnCount - 1

                    _id_local_estoque = Trim(dgvDados2.Rows(e.RowIndex).Cells("ID_LOCAL_ESTOQUE").Value)

                    If _id_local_estoque = "7" Then '--> QUARENTENA
                        dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                        dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Red

                    ElseIf _id_local_estoque = "2" Then '--> ASSISTENCIA TECNICA
                        dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                        dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Brown

                    ElseIf _id_local_estoque = "9" Then '--> DEVOLVEU FORNECEDOR
                        dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                        dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Blue

                    ElseIf _id_local_estoque = "8" Then '--> INATIVO
                        dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.White
                        dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.Black

                    Else ' TODOS OS OUTROS TIPOS DE LOCAL
                        dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.ForeColor = Color.Black
                        dgvDados2.Rows(e.RowIndex).Cells(ixx).Style.BackColor = Color.White

                    End If

                Next

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub UpdateFont()


        Dim colHeader() As String
        If Me.TipoEstoque = "C" Then 'TextHeaders para Chip
            Me.dgvDados.DefaultCellStyle.Font = New Font("Tahoma", 10.0F, GraphicsUnit.Pixel)
            colHeader = {"Id Chip", "SIMID", "Operadora", "Estoque",
                         "Transito", "Custo", "Codigo", "Nome Local", "Loja Física",
                         "Área", "Tipo Local", "Dt. Movto", "Sigla",
                          "Id Local Estoque", "Id Local", "Id Operadora", "ID_OS"}
            For ixx = 0 To dgvDados.ColumnCount - 1
                dgvDados.Columns(ixx).HeaderText = colHeader(ixx)
            Next

        Else 'TextHeaders para POS
            Me.dgvDados2.DefaultCellStyle.Font = New Font("Tahoma", 10.0F, GraphicsUnit.Pixel)
            colHeader = {"Id Equipto", "Série", "Modelo", "Descrição Equipamento", "Estoque",
                         "Transito", "Custo", "Codigo", "Nome Local", "Loja Física",
                         "Área", "Tipo Local", "Dt. Movto", "Sigla",
                          "Id Local Estoque", "Id Local", "ID_OS"}
            For ixx = 0 To dgvDados2.ColumnCount - 1
                dgvDados2.Columns(ixx).HeaderText = colHeader(ixx)
            Next

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim codigo As String
        Dim descricao As String
        codigo = Me.PesqFKLoja.txtId.Text
        descricao = Me.PesqFKLoja.txtDesc.Text

        MessageBox.Show("Codigo = " & codigo & Chr(13) & "Descricao = " & descricao, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub

    Private Sub PesqFK1_Load(sender As Object, e As EventArgs) Handles PesqFKLoja.Load
        With Me.PesqFKLoja
            .LabelPesqFK = "Loja"
            .Tabela = "CG_LOJA"
            .View = "CG_LOJA"
            .CampoId = "ID_LOJA"
            .CampoDesc = "NOME"

            .ListaCampos = "CODIGO,NOME,SIGLA,ID_LOJA,LOJA_FISICA"
            .ColunasFiltro = "CODIGO,NOME,SIGLA,ID_LOJA" ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Lojas"

            .lblLabelFK.Text = .LabelPesqFK

        End With
    End Sub

    Private Sub PesqFK2_Load(sender As Object, e As EventArgs) Handles PesqFKArea.Load
        With Me.PesqFKArea
            .LabelPesqFK = "Área"
            .Tabela = "CG_AREA"
            .View = "CG_AREA"
            .CampoId = "ID_AREA"
            .CampoDesc = "DESC_AREA"

            .ListaCampos = "ID_AREA, DESC_AREA"
            .ColunasFiltro = "DESC_AREA,ID_AREA" ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Áreas"

            .lblLabelFK.Text = .LabelPesqFK

        End With

    End Sub

    Private Sub PesqFKTransito_Load(sender As Object, e As EventArgs) Handles PesqFKTransito.Load
        With Me.PesqFKTransito
            .LabelPesqFK = "Trânsito"
            .Tabela = "CG_TRANSITO"
            .View = "CG_TRANSITO"
            .CampoId = "ID_TRANSITO"
            .CampoDesc = "NOME_TRANSITO"

            .ListaCampos = "ID_TRANSITO, NOME_TRANSITO"
            .ColunasFiltro = "NOME_TRANSITO,ID_TRANSITO" ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Trânsito"

            .lblLabelFK.Text = .LabelPesqFK

        End With
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub
    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myGrid As New DataGridView
        Dim pagAtiva = TabControl1.SelectedIndex

        myGrid = PreparaGrid(pagAtiva + 1)
        Dim oParametros As New DTO.ParametrosReportPreview
        oParametros.Titulo = Me.Text
        oParametros.Usuario = UserName()
        Dim frmPrint As New WinCG.ReportPreview(myGrid, oParametros)
        frmPrint.ShowDialog()
        'Carregar()
        'Inicio()
    End Sub

    Private Function PreparaGrid(ByVal qGrid As Integer) As DataGridView
        Dim meuDataGridView As New DataGridView

        Dim colunasGrid As String = IIf(qGrid = 1, "SIMID,DESC_OPERADORA,CODIGO,DATAMOV,SIGLA",
                                        "SERIE,MODELO,CODIGO,DATAMOV,SIGLA")

        Dim coluna As String
        Dim dt1 As New DataTable
        If qGrid = 1 Then
            dt1 = TryCast(Me.dgvDados.DataSource, DataTable)
        Else
            dt1 = TryCast(Me.dgvDados2.DataSource, DataTable)
        End If
        Dim dt2 = dt1.Copy()

        For Each column As DataColumn In dt1.Columns
            coluna = column.ColumnName
            If Not colunasGrid.Contains(coluna) Then
                dt2.Columns.Remove(coluna)
            End If
        Next

        meuDataGridView.ColumnCount = 5
        With meuDataGridView

            .Name = "meuDataGridView"

            .DataSource = dt2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False

        End With
        Return meuDataGridView
    End Function

    Private Sub btnProcurarSimid_Click(sender As Object, e As EventArgs) Handles btnProcurarSimid.Click
        Dim texto As String = Nothing
        Dim intEscolha As Integer = IIf(optPesqSimid1.Checked = True, 0, 1)

        If txtPesquisaSimid.Text <> String.Empty Then
            'Percorre todas as linhas do Grid e compara o conteudo do textbox de Pesquisa
            'com o conteudo da coluna SIMID do grid. Se a condição for satisfeita seleciona a linha e sai da rotina
            For Each linha As DataGridViewRow In dgvDados.Rows
                texto = linha.Cells(1).Value 'Pesquisa na coluna de SIMID
                If PesquisaString(texto.ToLower, txtPesquisaSimid.Text.ToLower, intEscolha) Then
                    Dim linhaAtual = dgvDados.CurrentRow.Index
                    dgvDados.CurrentCell = dgvDados.Rows(linhaAtual).Cells(1)
                    dgvDados.FirstDisplayedScrollingRowIndex = linha.Index
                    dgvDados.Rows(linhaAtual).Selected = True
                    dgvDados.Focus()
                    linha.Selected = True
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub btnProcurarSerie_Click(sender As Object, e As EventArgs) Handles btnProcurarSerie.Click
        Dim texto As String = Nothing
        Dim intEscolha As Integer = IIf(optPesqSerie1.Checked = True, 0, 1)

        If txtPesquisaSerie.Text <> String.Empty Then
            'Percorre todas as linhas do Grid e compara o conteudo do textbox de Pesquisa
            'com o conteudo da coluna SIMID do grid. Se a condição for satisfeita seleciona a linha e sai da rotina
            For Each linha As DataGridViewRow In dgvDados2.Rows
                texto = linha.Cells(1).Value 'Pesquisa na coluna de SIMID
                If PesquisaString(texto.ToLower, txtPesquisaSerie.Text.ToLower, intEscolha) Then
                    linha.Selected = True
                    Dim linhaAtual = dgvDados2.CurrentRow.Index
                    dgvDados2.CurrentCell = dgvDados2.Rows(linhaAtual).Cells(1)
                    dgvDados2.FirstDisplayedScrollingRowIndex = linha.Index
                    dgvDados2.Rows(linhaAtual).Selected = True
                    dgvDados2.Focus()
                    Exit Sub
                End If
            Next
        End If

    End Sub

    Private Sub dgvDados2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados2.CellEnter
        Dim linhaAtual = dgvDados2.CurrentRow.Index
        Dim strOSNum As String
        Try
            If dgvDados2.Rows(linhaAtual).Cells("TIPO_LOCAL").Value = "L" And CInt(dgvDados2.Rows(linhaAtual).Cells("ID_LOCAL_ESTOQUE").Value) = 2 Then
                strOSNum = IIf(String.IsNullOrEmpty(dgvDados2.Rows(linhaAtual).Cells("ID_OS").Value), "", dgvDados2.Rows(linhaAtual).Cells("ID_OS").Value)
                txtOS.Text = strOSNum
            Else
                txtOS.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub TextBox2_Validated(sender As Object, e As EventArgs) Handles TextBox2.Validated
        If Not validaData(TextBox2.Text) Then
            MessageBox.Show("Data Inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Text = ""
        Else

            If String.IsNullOrEmpty(TextBox2.Text) Then
                TextBox1.Text = TextBox2.Text
            End If

        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumerosData(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub
End Class