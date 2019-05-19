Public Class Equipamento

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal objPermissaoModulo As DTO.PermissaoModulo)

        ' This call is required by the designer.
        InitializeComponent()

        arrayAcessoTela(0) = objPermissaoModulo.Pesquisa
        arrayAcessoTela(1) = objPermissaoModulo.Incluir
        arrayAcessoTela(2) = objPermissaoModulo.Alterar
        arrayAcessoTela(3) = objPermissaoModulo.Excluir

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()
        Me.PkString = False
        Me.Tabela = "CG_EQUIPAMENTO" 'Nome da tabela no SQL
        Me.Modulo = 17 'codigo do módulo 
        LoginCG() 'retorna o id do usuário
        Me.View = "VW_CG_EQUIPAMENTO"
        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_equipamento
        Me.ColunaId = "ID_EQUIPAMENTO"
        Habilita_Controles(False) 'modo leitura
    End Sub
    Public Overrides Sub Pesquisar()
        MyBase.Pesquisar()
        'MessageBox.Show(Me.KeyId.ToString, "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Carrega_Controles_Pesquisa()
    End Sub

    Public Overrides Sub Carrega_Controles_Pesquisa()
        MyBase.Carrega_Controles_Pesquisa()
        If Me.KeyId <> -1 Then

            txtCodigo.Text = Me.KeyId.ToString
            txtDescricao.Text = Me.LinhaGrid.Cells("DESC_EQUIPAMENTO").Value.ToString
            PesqFKFornecedor.txtDesc.Text = Me.LinhaGrid.Cells("NOME").Value.ToString
            PesqFKFornecedor.txtId.Text = Me.LinhaGrid.Cells("ID_FORNECEDOR").Value.ToString
            PesqFKTipo.txtId.Text = Me.LinhaGrid.Cells("ID_TIPO_EQUIPAMENTO").Value.ToString
            PesqFKTipo.txtDesc.Text = Me.LinhaGrid.Cells("DESC_TIPO_EQUIPAMENTO").Value.ToString
            txtModelo.Text = Me.LinhaGrid.Cells("MODELO").Value.ToString
            txtObs.Text = Me.LinhaGrid.Cells("OBS").Value.ToString
            txtProtocolo.Text = Me.LinhaGrid.Cells("PROTOCOLO").Value.ToString
            txtValor.Text = Me.LinhaGrid.Cells("VALOR").Value.ToString
            txtSerie.Text = Me.LinhaGrid.Cells("SERIE").Value.ToString
            txtId_Controle.Text = Me.LinhaGrid.Cells("ID_CONTROLE").Value.ToString
            txtNf_Entrada.Text = Me.LinhaGrid.Cells("NF_ENTRADA").Value.ToString
            txtData_Nf.Text = Me.LinhaGrid.Cells("DATA_NF").Value.ToString
            txtPrazo_Garantia.Text = Me.LinhaGrid.Cells("PRAZO_GARANTIA").Value.ToString
            txtUltimaOS.Text = Me.LinhaGrid.Cells("ID_ULTIMA_OS").Value.ToString
            txtDataInicioGarantia.Text = Me.LinhaGrid.Cells("DATA_INICIO_GARANTIA").Value.ToString
            txtDataTerminoGarantia.Text = Me.LinhaGrid.Cells("DATA_TERMINO_GARANTIA").Value.ToString
            txtPrecoVenda.Text = Me.LinhaGrid.Cells("PRECO_VENDA").Value.ToString

            chkGarantiaVigente.Checked = False
            If Not String.IsNullOrEmpty(txtDataTerminoGarantia.Text) Then
                Dim dtHoje As Date = ShortDate()
                Dim dtTerminoGarantia As Date = CDate(txtDataTerminoGarantia.Text)
                If dtTerminoGarantia >= dtHoje Then
                    chkGarantiaVigente.Checked = True
                End If
            End If

            AtualizaGridSeries()
        End If
    End Sub

    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)

        If Not ValidaCampos() Then
            Exit Sub
        End If

        Dim bll As New BLL.EquipamentoBLL
        Dim objEquipamento As New DTO.Cg_equipamento
        Dim llErro As Boolean = True

        Try
            objEquipamento.Id_equipamento = CInt(txtCodigo.Text)
            objEquipamento.Desc_equipamento = txtDescricao.Text
            objEquipamento.Id_fornecedor = CInt(PesqFKFornecedor.txtId.Text)
            objEquipamento.Id_tipo_equipamento = CInt(PesqFKTipo.txtId.Text)
            objEquipamento.Modelo = txtModelo.Text
            objEquipamento.Obs = txtObs.Text
            objEquipamento.Protocolo = txtProtocolo.Text
            objEquipamento.Serie = txtSerie.Text
            objEquipamento.Valor = Convert.ToDouble(Replace(txtValor.Text, ".", ","))
            objEquipamento.PrecoVenda = Convert.ToDouble(Replace(txtPrecoVenda.Text, ".", ","))

            objEquipamento.User_ins = ACE_CODIGO
            objEquipamento.Data_ins = Hoje()
            objEquipamento.User_upd = ACE_CODIGO
            objEquipamento.Data_upd = Hoje()

            objEquipamento.NF_Entrada = txtNf_Entrada.Text.ToString
            objEquipamento.Data_NF = txtData_Nf.Text
            If String.IsNullOrEmpty(txtPrazo_Garantia.Text) Then
                objEquipamento.Prazo_garantia = 0
            Else
                objEquipamento.Prazo_garantia = CInt(txtPrazo_Garantia.Text)
            End If
            objEquipamento.Id_empresa = Publico.Id_empresa


            bll.GravarBLL(acao, objEquipamento)
            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta
            llErro = False
        Catch ex As SqlClient.SqlException
            llErro = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            llErro = True
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(llErro) 'modo leitura

        End Try

    End Sub
    Public Overrides Sub Alterar()
        MyBase.Alterar()
        Habilita_Controles(True) 'modo digitação


    End Sub
    Public Overrides Sub Incluir()
        MyBase.Incluir()
        Dim bll As New BLL.GlobalBLL
        Me.KeyId = bll.NovaChaveBLL(Me.Tabela)
        Dim strId_Controle As String
        If Me.KeyId > 0 Then
            txtCodigo.Text = Me.KeyId.ToString()

            strId_Controle = "00000" & Trim(txtCodigo.Text)
            'implementando função right() - cria codigo de 5 posições com zeros a esquerda
            txtId_Controle.Text = "SR" & strId_Controle.Substring(strId_Controle.Length - 5, 5)

            Habilita_Controles(True) 'modo digitação

        Else
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.EquipamentoBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao) 'Executa o método default da classe pai

        PesqFKFornecedor.btnPesq.Enabled = False
        PesqFKTipo.btnPesq.Enabled = False
        TabControl1.TabPages(0).Enabled = False
        TabControl1.TabPages(1).Enabled = True

        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            PesqFKFornecedor.btnPesq.Enabled = True
            PesqFKTipo.btnPesq.Enabled = True
            TabControl1.TabPages(0).Enabled = True
            TabControl1.TabPages(1).Enabled = True
        End If

    End Sub
    Private Sub AtualizaGridSeries()
        Dim sql As String
        sql = "select DATA_ALTERACAO,ID_OS,ITEM_ID,MOTIVO_ALTERACAO,SERIE_ANTERIOR,SERIE_NOVA "
        sql += "from CG_EQUIPAMENTO_HISTORICO_SERIE WHERE ID_EQUIPAMENTO = " & txtCodigo.Text
        sql += " order by ID_OS,ITEM_ID "

        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        dgvDados.ReadOnly = True

        'Caption das colunas do Grid
        dgvDados.Columns(0).HeaderText = "Alterado em"
        dgvDados.Columns(1).HeaderText = "OS nº"
        dgvDados.Columns(2).HeaderText = "ID Item OS"
        dgvDados.Columns(3).HeaderText = "Motivo"
        dgvDados.Columns(4).HeaderText = "Série Anterior"
        dgvDados.Columns(5).HeaderText = "Série Nova"

        'Largura das colunas do Grid
        dgvDados.Columns(0).Width = 70
        dgvDados.Columns(1).Width = 60
        dgvDados.Columns(2).Width = 65
        dgvDados.Columns(3).Width = 275
        dgvDados.Columns(4).Width = 130
        dgvDados.Columns(5).Width = 130

        'dgvDados.AutoResizeColumns()

    End Sub
    Public Overrides Sub Limpar_Controles()
        'Este método é utilizado para limpar os controles antes da Inclusão
        'Limpa os controles de cada tabpage
        For Each c In Me.TabPage1.Controls
            Select Case c.GetType()
                Case GetType(TextBox)
                    CType(c, TextBox).Text = String.Empty
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
        For Each c In Me.TabPage2.Controls
            Select Case c.GetType()
                Case GetType(TextBox)
                    CType(c, TextBox).Text = String.Empty
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
        For Each c In Me.TabPage3.Controls
            Select Case c.GetType()
                Case GetType(TextBox)
                    CType(c, TextBox).Text = String.Empty
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

    Private Sub PesqFKFornecedor_Load(sender As Object, e As EventArgs) Handles PesqFKFornecedor.Load
        With Me.PesqFKFornecedor
            .LabelPesqFK = "Fornecedor"
            .Tabela = "CG_FORNECEDOR"
            .View = "CG_FORNECEDOR"
            .CampoId = "ID_FORNECEDOR"
            .CampoDesc = "NOME"
            .ListaCampos = "ID_FORNECEDOR, NOME, SIGLA"
            .ColunasFiltro = "NOME,SIGLA,ID_FORNECEDOR"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Fornecedores"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = True

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 29
            .txtId.Width -= 20
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 105
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With
    End Sub
    Private Sub PesqFKFornecedor_Leave(sender As Object, e As EventArgs) Handles PesqFKFornecedor.Leave
        If PesqFKFornecedor.PosValida = True And PesqFKFornecedor.Clicou > 0 Then
            'Pesquisa o cadastro do Fornecedor e traz a coluna GARANTIA_AQUISICAO
            Dim dt As DataTable
            Dim bll As New BLL.GlobalBLL

            dt = bll.SqlExecDT("select isnull(GARANTIA_AQUISICAO,0) as GARANTIA_AQUISICAO, " & _
                               "ISNULL(GARANTIA_ASSISTENCIA,0) AS GARANTIA_ASSISTENCIA  " & _
                               "from cg_fornecedor where id_fornecedor = " & PesqFKFornecedor.txtId.Text)

            If dt.Rows.Count > 0 Then
                txtPrazo_Garantia.Text = dt(0)("GARANTIA_AQUISICAO")
                Dim form1 As New WaitWindow("Campo Prazo de Garantia Atualizado!", 1)
                form1.ShowDialog()
                form1.Dispose()
                form1 = Nothing
            End If
        End If
    End Sub

    Private Sub PesqFKTipo_Load(sender As Object, e As EventArgs) Handles PesqFKTipo.Load
        With Me.PesqFKTipo
            .LabelPesqFK = "Tipo"
            .Tabela = "CG_TIPO_EQUIPAMENTO"
            .View = "CG_TIPO_EQUIPAMENTO"
            .CampoId = "ID_TIPO_EQUIPAMENTO"
            .CampoDesc = "DESC_TIPO_EQUIPAMENTO"
            .ListaCampos = "ID_TIPO_EQUIPAMENTO, DESC_TIPO_EQUIPAMENTO"
            .ColunasFiltro = "DESC_TIPO_EQUIPAMENTO,ID_TIPO_EQUIPAMENTO"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Tipo de Equipamento"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 29
            .txtId.Width -= 20
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 105
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With
    End Sub

End Class