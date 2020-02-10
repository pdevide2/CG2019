<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaEstoque
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaEstoque))
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkMatriz = New System.Windows.Forms.CheckBox()
        Me.chkQuarentena = New System.Windows.Forms.CheckBox()
        Me.chkInativo = New System.Windows.Forms.CheckBox()
        Me.chkDevolveu = New System.Windows.Forms.CheckBox()
        Me.radFisica = New System.Windows.Forms.RadioButton()
        Me.radAmbos = New System.Windows.Forms.RadioButton()
        Me.radNaoFisica = New System.Windows.Forms.RadioButton()
        Me.radLoja = New System.Windows.Forms.RadioButton()
        Me.radLojaTransito = New System.Windows.Forms.RadioButton()
        Me.radTransito = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkAssistencia = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblTotalRegistros = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ckOperadora = New System.Windows.Forms.CheckBox()
        Me.ckModelo = New System.Windows.Forms.CheckBox()
        Me.cboOperadora = New System.Windows.Forms.ComboBox()
        Me.cboModelo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PesqFKTransito = New WinCG.PesqFK()
        Me.PesqFKLoja = New WinCG.PesqFK()
        Me.PesqFKArea = New WinCG.PesqFK()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnProcurarSimid = New System.Windows.Forms.Button()
        Me.optPesqSimid2 = New System.Windows.Forms.RadioButton()
        Me.optPesqSimid1 = New System.Windows.Forms.RadioButton()
        Me.txtPesquisaSimid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProcurarSerie = New System.Windows.Forms.Button()
        Me.optPesqSerie2 = New System.Windows.Forms.RadioButton()
        Me.optPesqSerie1 = New System.Windows.Forms.RadioButton()
        Me.txtPesquisaSerie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTotalChips = New System.Windows.Forms.Label()
        Me.lblTotalPOS = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExcel
        '
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcel.Location = New System.Drawing.Point(1196, 413)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(108, 40)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRefresh.Location = New System.Drawing.Point(1196, 459)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(108, 40)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "  Atualizar"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLimpar.Location = New System.Drawing.Point(1196, 367)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(108, 40)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "        Limpar Filtro"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 20)
        Me.TextBox1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Data"
        '
        'chkMatriz
        '
        Me.chkMatriz.AutoSize = True
        Me.chkMatriz.Location = New System.Drawing.Point(6, 23)
        Me.chkMatriz.Name = "chkMatriz"
        Me.chkMatriz.Size = New System.Drawing.Size(54, 17)
        Me.chkMatriz.TabIndex = 46
        Me.chkMatriz.Text = "Matriz"
        Me.chkMatriz.UseVisualStyleBackColor = True
        '
        'chkQuarentena
        '
        Me.chkQuarentena.AutoSize = True
        Me.chkQuarentena.Location = New System.Drawing.Point(6, 43)
        Me.chkQuarentena.Name = "chkQuarentena"
        Me.chkQuarentena.Size = New System.Drawing.Size(82, 17)
        Me.chkQuarentena.TabIndex = 47
        Me.chkQuarentena.Text = "Quarentena"
        Me.chkQuarentena.UseVisualStyleBackColor = True
        '
        'chkInativo
        '
        Me.chkInativo.AutoSize = True
        Me.chkInativo.Location = New System.Drawing.Point(6, 63)
        Me.chkInativo.Name = "chkInativo"
        Me.chkInativo.Size = New System.Drawing.Size(58, 17)
        Me.chkInativo.TabIndex = 48
        Me.chkInativo.Text = "Inativo"
        Me.chkInativo.UseVisualStyleBackColor = True
        '
        'chkDevolveu
        '
        Me.chkDevolveu.AutoSize = True
        Me.chkDevolveu.Location = New System.Drawing.Point(6, 86)
        Me.chkDevolveu.Name = "chkDevolveu"
        Me.chkDevolveu.Size = New System.Drawing.Size(111, 17)
        Me.chkDevolveu.TabIndex = 49
        Me.chkDevolveu.Text = "Devolveu Fornec."
        Me.chkDevolveu.UseVisualStyleBackColor = True
        '
        'radFisica
        '
        Me.radFisica.AutoSize = True
        Me.radFisica.Location = New System.Drawing.Point(14, 43)
        Me.radFisica.Name = "radFisica"
        Me.radFisica.Size = New System.Drawing.Size(77, 17)
        Me.radFisica.TabIndex = 51
        Me.radFisica.Text = "Loja Física"
        Me.radFisica.UseVisualStyleBackColor = True
        '
        'radAmbos
        '
        Me.radAmbos.AutoSize = True
        Me.radAmbos.Checked = True
        Me.radAmbos.Location = New System.Drawing.Point(14, 25)
        Me.radAmbos.Name = "radAmbos"
        Me.radAmbos.Size = New System.Drawing.Size(111, 17)
        Me.radAmbos.TabIndex = 50
        Me.radAmbos.TabStop = True
        Me.radAmbos.Text = "Física/Não Física"
        Me.radAmbos.UseVisualStyleBackColor = True
        '
        'radNaoFisica
        '
        Me.radNaoFisica.AutoSize = True
        Me.radNaoFisica.Location = New System.Drawing.Point(14, 63)
        Me.radNaoFisica.Name = "radNaoFisica"
        Me.radNaoFisica.Size = New System.Drawing.Size(77, 17)
        Me.radNaoFisica.TabIndex = 52
        Me.radNaoFisica.Text = "Não Física"
        Me.radNaoFisica.UseVisualStyleBackColor = True
        '
        'radLoja
        '
        Me.radLoja.AutoSize = True
        Me.radLoja.Location = New System.Drawing.Point(16, 55)
        Me.radLoja.Name = "radLoja"
        Me.radLoja.Size = New System.Drawing.Size(45, 17)
        Me.radLoja.TabIndex = 58
        Me.radLoja.Text = "Loja"
        Me.radLoja.UseVisualStyleBackColor = True
        '
        'radLojaTransito
        '
        Me.radLojaTransito.AutoSize = True
        Me.radLojaTransito.Checked = True
        Me.radLojaTransito.Location = New System.Drawing.Point(16, 36)
        Me.radLojaTransito.Name = "radLojaTransito"
        Me.radLojaTransito.Size = New System.Drawing.Size(88, 17)
        Me.radLojaTransito.TabIndex = 57
        Me.radLojaTransito.TabStop = True
        Me.radLojaTransito.Text = "Loja/Transito"
        Me.radLojaTransito.UseVisualStyleBackColor = True
        '
        'radTransito
        '
        Me.radTransito.AutoSize = True
        Me.radTransito.Location = New System.Drawing.Point(16, 75)
        Me.radTransito.Name = "radTransito"
        Me.radTransito.Size = New System.Drawing.Size(63, 17)
        Me.radTransito.TabIndex = 59
        Me.radTransito.Text = "Transito"
        Me.radTransito.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radAmbos)
        Me.GroupBox1.Controls.Add(Me.radNaoFisica)
        Me.GroupBox1.Controls.Add(Me.radFisica)
        Me.GroupBox1.Location = New System.Drawing.Point(1182, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 93)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Loja"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radTransito)
        Me.GroupBox2.Controls.Add(Me.radLoja)
        Me.GroupBox2.Controls.Add(Me.radLojaTransito)
        Me.GroupBox2.Location = New System.Drawing.Point(1185, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 117)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Local de Estoque"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkAssistencia)
        Me.GroupBox3.Controls.Add(Me.chkMatriz)
        Me.GroupBox3.Controls.Add(Me.chkQuarentena)
        Me.GroupBox3.Controls.Add(Me.chkInativo)
        Me.GroupBox3.Controls.Add(Me.chkDevolveu)
        Me.GroupBox3.Location = New System.Drawing.Point(1185, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(122, 131)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Exibir"
        '
        'chkAssistencia
        '
        Me.chkAssistencia.AutoSize = True
        Me.chkAssistencia.Location = New System.Drawing.Point(6, 109)
        Me.chkAssistencia.Name = "chkAssistencia"
        Me.chkAssistencia.Size = New System.Drawing.Size(98, 17)
        Me.chkAssistencia.TabIndex = 50
        Me.chkAssistencia.Text = "Assist. Tecnica"
        Me.chkAssistencia.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(1196, 552)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 40)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Fechar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.AutoSize = True
        Me.lblTotalRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRegistros.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTotalRegistros.Location = New System.Drawing.Point(1069, 457)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(12, 17)
        Me.lblTotalRegistros.TabIndex = 64
        Me.lblTotalRegistros.Text = "."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ckOperadora)
        Me.Panel1.Controls.Add(Me.ckModelo)
        Me.Panel1.Controls.Add(Me.cboOperadora)
        Me.Panel1.Controls.Add(Me.cboModelo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.PesqFKTransito)
        Me.Panel1.Controls.Add(Me.PesqFKLoja)
        Me.Panel1.Controls.Add(Me.PesqFKArea)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(10, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1166, 135)
        Me.Panel1.TabIndex = 68
        '
        'ckOperadora
        '
        Me.ckOperadora.AutoSize = True
        Me.ckOperadora.Location = New System.Drawing.Point(587, 46)
        Me.ckOperadora.Name = "ckOperadora"
        Me.ckOperadora.Size = New System.Drawing.Size(122, 17)
        Me.ckOperadora.TabIndex = 73
        Me.ckOperadora.Text = "Filtrar por Operadora"
        Me.ckOperadora.UseVisualStyleBackColor = True
        '
        'ckModelo
        '
        Me.ckModelo.AutoSize = True
        Me.ckModelo.Location = New System.Drawing.Point(587, 9)
        Me.ckModelo.Name = "ckModelo"
        Me.ckModelo.Size = New System.Drawing.Size(107, 17)
        Me.ckModelo.TabIndex = 51
        Me.ckModelo.Text = "Filtrar por Modelo"
        Me.ckModelo.UseVisualStyleBackColor = True
        '
        'cboOperadora
        '
        Me.cboOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperadora.Enabled = False
        Me.cboOperadora.FormattingEnabled = True
        Me.cboOperadora.Location = New System.Drawing.Point(715, 44)
        Me.cboOperadora.Name = "cboOperadora"
        Me.cboOperadora.Size = New System.Drawing.Size(185, 21)
        Me.cboOperadora.TabIndex = 72
        '
        'cboModelo
        '
        Me.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModelo.Enabled = False
        Me.cboModelo.FormattingEnabled = True
        Me.cboModelo.Location = New System.Drawing.Point(712, 7)
        Me.cboModelo.Name = "cboModelo"
        Me.cboModelo.Size = New System.Drawing.Size(188, 21)
        Me.cboModelo.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Até"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(74, 20)
        Me.TextBox2.TabIndex = 69
        '
        'PesqFKTransito
        '
        Me.PesqFKTransito.CampoDesc = "DESC_CARGO"
        Me.PesqFKTransito.CampoId = "ID_CARGO"
        Me.PesqFKTransito.Clicou = "0"
        Me.PesqFKTransito.CodigoSelecionado = Nothing
        Me.PesqFKTransito.ColunasFiltro = "DESC_CARGO"
        Me.PesqFKTransito.DescricaoSelecionada = Nothing
        Me.PesqFKTransito.FiltroSQL = Nothing
        Me.PesqFKTransito.LabelBuscaDesc = "Descrição"
        Me.PesqFKTransito.LabelBuscaId = "Código"
        Me.PesqFKTransito.LabelPesqFK = "Transito"
        Me.PesqFKTransito.ListaCampos = "DESC_CARGO,ID_CARGO"
        Me.PesqFKTransito.Location = New System.Drawing.Point(101, 69)
        Me.PesqFKTransito.Name = "PesqFKTransito"
        Me.PesqFKTransito.ObjModelFk = Nothing
        Me.PesqFKTransito.OrderByQuery = Nothing
        Me.PesqFKTransito.PosValida = False
        Me.PesqFKTransito.Size = New System.Drawing.Size(399, 28)
        Me.PesqFKTransito.Tabela = "CG_CARGO"
        Me.PesqFKTransito.TabIndex = 68
        Me.PesqFKTransito.TituloTela = "Pesquisa de Cargos"
        Me.PesqFKTransito.View = "CG_CARGO"
        '
        'PesqFKLoja
        '
        Me.PesqFKLoja.CampoDesc = "DESC_CARGO"
        Me.PesqFKLoja.CampoId = "ID_CARGO"
        Me.PesqFKLoja.Clicou = "0"
        Me.PesqFKLoja.CodigoSelecionado = Nothing
        Me.PesqFKLoja.ColunasFiltro = "DESC_CARGO"
        Me.PesqFKLoja.DescricaoSelecionada = Nothing
        Me.PesqFKLoja.FiltroSQL = Nothing
        Me.PesqFKLoja.LabelBuscaDesc = "Descrição"
        Me.PesqFKLoja.LabelBuscaId = "Código"
        Me.PesqFKLoja.LabelPesqFK = "Loja"
        Me.PesqFKLoja.ListaCampos = "DESC_CARGO,ID_CARGO"
        Me.PesqFKLoja.Location = New System.Drawing.Point(101, 4)
        Me.PesqFKLoja.Name = "PesqFKLoja"
        Me.PesqFKLoja.ObjModelFk = Nothing
        Me.PesqFKLoja.OrderByQuery = Nothing
        Me.PesqFKLoja.PosValida = False
        Me.PesqFKLoja.Size = New System.Drawing.Size(399, 28)
        Me.PesqFKLoja.Tabela = "CG_CARGO"
        Me.PesqFKLoja.TabIndex = 65
        Me.PesqFKLoja.TituloTela = "Pesquisa de Cargos"
        Me.PesqFKLoja.View = "CG_CARGO"
        '
        'PesqFKArea
        '
        Me.PesqFKArea.CampoDesc = "DESC_CARGO"
        Me.PesqFKArea.CampoId = "ID_CARGO"
        Me.PesqFKArea.Clicou = "0"
        Me.PesqFKArea.CodigoSelecionado = Nothing
        Me.PesqFKArea.ColunasFiltro = "DESC_CARGO"
        Me.PesqFKArea.DescricaoSelecionada = Nothing
        Me.PesqFKArea.FiltroSQL = Nothing
        Me.PesqFKArea.LabelBuscaDesc = "Descrição"
        Me.PesqFKArea.LabelBuscaId = "Código"
        Me.PesqFKArea.LabelPesqFK = "Área"
        Me.PesqFKArea.ListaCampos = "DESC_CARGO,ID_CARGO"
        Me.PesqFKArea.Location = New System.Drawing.Point(101, 38)
        Me.PesqFKArea.Name = "PesqFKArea"
        Me.PesqFKArea.ObjModelFk = Nothing
        Me.PesqFKArea.OrderByQuery = Nothing
        Me.PesqFKArea.PosValida = False
        Me.PesqFKArea.Size = New System.Drawing.Size(399, 28)
        Me.PesqFKArea.Tabela = "CG_CARGO"
        Me.PesqFKArea.TabIndex = 67
        Me.PesqFKArea.TituloTela = "Pesquisa de Cargos"
        Me.PesqFKArea.View = "CG_CARGO"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1178, 450)
        Me.TabControl1.TabIndex = 69
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblTotalChips)
        Me.TabPage1.Controls.Add(Me.btnProcurarSimid)
        Me.TabPage1.Controls.Add(Me.optPesqSimid2)
        Me.TabPage1.Controls.Add(Me.optPesqSimid1)
        Me.TabPage1.Controls.Add(Me.txtPesquisaSimid)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dgvDados)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1170, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Chip"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnProcurarSimid
        '
        Me.btnProcurarSimid.Location = New System.Drawing.Point(524, 6)
        Me.btnProcurarSimid.Name = "btnProcurarSimid"
        Me.btnProcurarSimid.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarSimid.TabIndex = 6
        Me.btnProcurarSimid.Text = "Procurar"
        Me.btnProcurarSimid.UseVisualStyleBackColor = True
        '
        'optPesqSimid2
        '
        Me.optPesqSimid2.AutoSize = True
        Me.optPesqSimid2.Checked = True
        Me.optPesqSimid2.Location = New System.Drawing.Point(400, 9)
        Me.optPesqSimid2.Name = "optPesqSimid2"
        Me.optPesqSimid2.Size = New System.Drawing.Size(108, 17)
        Me.optPesqSimid2.TabIndex = 4
        Me.optPesqSimid2.TabStop = True
        Me.optPesqSimid2.Text = "Qualquer posição"
        Me.optPesqSimid2.UseVisualStyleBackColor = True
        '
        'optPesqSimid1
        '
        Me.optPesqSimid1.AutoSize = True
        Me.optPesqSimid1.Location = New System.Drawing.Point(285, 9)
        Me.optPesqSimid1.Name = "optPesqSimid1"
        Me.optPesqSimid1.Size = New System.Drawing.Size(100, 17)
        Me.optPesqSimid1.TabIndex = 5
        Me.optPesqSimid1.Text = "Começando por"
        Me.optPesqSimid1.UseVisualStyleBackColor = True
        '
        'txtPesquisaSimid
        '
        Me.txtPesquisaSimid.Location = New System.Drawing.Point(50, 7)
        Me.txtPesquisaSimid.Name = "txtPesquisaSimid"
        Me.txtPesquisaSimid.Size = New System.Drawing.Size(229, 20)
        Me.txtPesquisaSimid.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SIMID"
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(8, 36)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(1134, 380)
        Me.dgvDados.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblTotalPOS)
        Me.TabPage2.Controls.Add(Me.txtOS)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.btnProcurarSerie)
        Me.TabPage2.Controls.Add(Me.optPesqSerie2)
        Me.TabPage2.Controls.Add(Me.optPesqSerie1)
        Me.TabPage2.Controls.Add(Me.txtPesquisaSerie)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.dgvDados2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1170, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "POS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(1046, 8)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.ReadOnly = True
        Me.txtOS.Size = New System.Drawing.Size(100, 20)
        Me.txtOS.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1001, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "OS nº.:"
        '
        'btnProcurarSerie
        '
        Me.btnProcurarSerie.Location = New System.Drawing.Point(525, 7)
        Me.btnProcurarSerie.Name = "btnProcurarSerie"
        Me.btnProcurarSerie.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarSerie.TabIndex = 19
        Me.btnProcurarSerie.Text = "Procurar"
        Me.btnProcurarSerie.UseVisualStyleBackColor = True
        '
        'optPesqSerie2
        '
        Me.optPesqSerie2.AutoSize = True
        Me.optPesqSerie2.Checked = True
        Me.optPesqSerie2.Location = New System.Drawing.Point(407, 10)
        Me.optPesqSerie2.Name = "optPesqSerie2"
        Me.optPesqSerie2.Size = New System.Drawing.Size(108, 17)
        Me.optPesqSerie2.TabIndex = 20
        Me.optPesqSerie2.TabStop = True
        Me.optPesqSerie2.Text = "Qualquer posição"
        Me.optPesqSerie2.UseVisualStyleBackColor = True
        '
        'optPesqSerie1
        '
        Me.optPesqSerie1.AutoSize = True
        Me.optPesqSerie1.Location = New System.Drawing.Point(292, 10)
        Me.optPesqSerie1.Name = "optPesqSerie1"
        Me.optPesqSerie1.Size = New System.Drawing.Size(100, 17)
        Me.optPesqSerie1.TabIndex = 21
        Me.optPesqSerie1.Text = "Começando por"
        Me.optPesqSerie1.UseVisualStyleBackColor = True
        '
        'txtPesquisaSerie
        '
        Me.txtPesquisaSerie.Location = New System.Drawing.Point(57, 8)
        Me.txtPesquisaSerie.Name = "txtPesquisaSerie"
        Me.txtPesquisaSerie.Size = New System.Drawing.Size(229, 20)
        Me.txtPesquisaSerie.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nº. Série"
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(8, 36)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.ReadOnly = True
        Me.dgvDados2.Size = New System.Drawing.Size(1134, 380)
        Me.dgvDados2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1196, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 40)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "    Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblTotalChips
        '
        Me.lblTotalChips.AutoSize = True
        Me.lblTotalChips.Location = New System.Drawing.Point(761, 11)
        Me.lblTotalChips.Name = "lblTotalChips"
        Me.lblTotalChips.Size = New System.Drawing.Size(87, 13)
        Me.lblTotalChips.TabIndex = 7
        Me.lblTotalChips.Text = "Total de Chips: 0"
        '
        'lblTotalPOS
        '
        Me.lblTotalPOS.AutoSize = True
        Me.lblTotalPOS.Location = New System.Drawing.Point(742, 13)
        Me.lblTotalPOS.Name = "lblTotalPOS"
        Me.lblTotalPOS.Size = New System.Drawing.Size(128, 13)
        Me.lblTotalPOS.TabIndex = 24
        Me.lblTotalPOS.Text = "Total de Equipamentos: 0"
        '
        'ConsultaEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 598)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTotalRegistros)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExcel)
        Me.Name = "ConsultaEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Estoque de Equipamento (POS)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkMatriz As System.Windows.Forms.CheckBox
    Friend WithEvents chkQuarentena As System.Windows.Forms.CheckBox
    Friend WithEvents chkInativo As System.Windows.Forms.CheckBox
    Friend WithEvents chkDevolveu As System.Windows.Forms.CheckBox
    Friend WithEvents radFisica As System.Windows.Forms.RadioButton
    Friend WithEvents radAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents radNaoFisica As System.Windows.Forms.RadioButton
    Friend WithEvents radLoja As System.Windows.Forms.RadioButton
    Friend WithEvents radLojaTransito As System.Windows.Forms.RadioButton
    Friend WithEvents radTransito As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents chkAssistencia As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotalRegistros As System.Windows.Forms.Label
    Friend WithEvents PesqFKLoja As WinCG.PesqFK
    Friend WithEvents PesqFKArea As WinCG.PesqFK
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PesqFKTransito As WinCG.PesqFK
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvDados2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPesquisaSimid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPesquisaSerie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnProcurarSimid As Button
    Friend WithEvents optPesqSimid2 As RadioButton
    Friend WithEvents optPesqSimid1 As RadioButton
    Friend WithEvents btnProcurarSerie As Button
    Friend WithEvents optPesqSerie2 As RadioButton
    Friend WithEvents optPesqSerie1 As RadioButton
    Friend WithEvents txtOS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cboOperadora As ComboBox
    Friend WithEvents cboModelo As ComboBox
    Friend WithEvents ckOperadora As CheckBox
    Friend WithEvents ckModelo As CheckBox
    Friend WithEvents lblTotalChips As Label
    Friend WithEvents lblTotalPOS As Label
End Class
