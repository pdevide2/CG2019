<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recebimento_OS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label23 As System.Windows.Forms.Label
        Me.lblOS = New System.Windows.Forms.Label()
        Me.txtId_OS = New System.Windows.Forms.TextBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDataOS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdFornecedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescFornecedor = New System.Windows.Forms.TextBox()
        Me.txtNfTransp = New System.Windows.Forms.TextBox()
        Me.txtSerieNfTransp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmissaoNfTransp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescLojaOrigem = New System.Windows.Forms.TextBox()
        Me.txtIdLojaOrigem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAnexarLaudo = New System.Windows.Forms.Button()
        Me.btnAnexarNFe = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnexarNFeEmXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnexarNFeEmPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPesqOS = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnDesfazer = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.ofd2 = New System.Windows.Forms.OpenFileDialog()
        Me.btnViewPDFLaudo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboTabelaServico = New System.Windows.Forms.ComboBox()
        Me.txtOutros = New System.Windows.Forms.TextBox()
        Me.chkOutros = New System.Windows.Forms.CheckBox()
        Me.chkLaudo = New System.Windows.Forms.CheckBox()
        Me.lblPanel = New System.Windows.Forms.Label()
        Me.chkRetorno = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtValorConserto = New System.Windows.Forms.TextBox()
        Me.chkGarantia = New System.Windows.Forms.CheckBox()
        Me.txtEmissaoNFe = New System.Windows.Forms.DateTimePicker()
        Me.txtSerieNFe = New System.Windows.Forms.TextBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtNFe = New System.Windows.Forms.TextBox()
        Me.lblNFe = New System.Windows.Forms.Label()
        Me.chkConserto = New System.Windows.Forms.CheckBox()
        Me.btnPesqResponsavel = New System.Windows.Forms.Button()
        Me.txtDescResponsavel = New System.Windows.Forms.TextBox()
        Me.txtIdResponsavel = New System.Windows.Forms.TextBox()
        Me.lblResponsavel = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDescDefeito = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDataRetorno = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrevisaoRetorno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescEquipamento = New System.Windows.Forms.TextBox()
        Me.txtIdEquipamento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblEmissao = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChkSerie = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSerieNova = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSerieAnterior = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDataAlteracao = New System.Windows.Forms.DateTimePicker()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.spnDias = New System.Windows.Forms.NumericUpDown()
        Me.chkConfigGarantia = New System.Windows.Forms.CheckBox()
        Me.btnViewPDFNFe = New System.Windows.Forms.Button()
        Label23 = New System.Windows.Forms.Label()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.spnDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(19, 312)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(99, 13)
        Label23.TabIndex = 47
        Label23.Text = "Tabela de Serviços"
        '
        'lblOS
        '
        Me.lblOS.AutoSize = True
        Me.lblOS.Location = New System.Drawing.Point(10, 17)
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Size = New System.Drawing.Size(44, 13)
        Me.lblOS.TabIndex = 0
        Me.lblOS.Text = "O.S. n º"
        '
        'txtId_OS
        '
        Me.txtId_OS.Enabled = False
        Me.txtId_OS.Location = New System.Drawing.Point(81, 13)
        Me.txtId_OS.Name = "txtId_OS"
        Me.txtId_OS.ReadOnly = True
        Me.txtId_OS.Size = New System.Drawing.Size(96, 20)
        Me.txtId_OS.TabIndex = 1
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(13, 137)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(443, 397)
        Me.dgvDados.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data OS"
        '
        'txtDataOS
        '
        Me.txtDataOS.Enabled = False
        Me.txtDataOS.Location = New System.Drawing.Point(81, 42)
        Me.txtDataOS.Name = "txtDataOS"
        Me.txtDataOS.ReadOnly = True
        Me.txtDataOS.Size = New System.Drawing.Size(132, 20)
        Me.txtDataOS.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fornecedor"
        '
        'txtIdFornecedor
        '
        Me.txtIdFornecedor.Enabled = False
        Me.txtIdFornecedor.Location = New System.Drawing.Point(279, 42)
        Me.txtIdFornecedor.Name = "txtIdFornecedor"
        Me.txtIdFornecedor.ReadOnly = True
        Me.txtIdFornecedor.Size = New System.Drawing.Size(63, 20)
        Me.txtIdFornecedor.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "NFe Transp."
        '
        'txtDescFornecedor
        '
        Me.txtDescFornecedor.Enabled = False
        Me.txtDescFornecedor.Location = New System.Drawing.Point(348, 42)
        Me.txtDescFornecedor.Name = "txtDescFornecedor"
        Me.txtDescFornecedor.ReadOnly = True
        Me.txtDescFornecedor.Size = New System.Drawing.Size(278, 20)
        Me.txtDescFornecedor.TabIndex = 7
        '
        'txtNfTransp
        '
        Me.txtNfTransp.Enabled = False
        Me.txtNfTransp.Location = New System.Drawing.Point(81, 71)
        Me.txtNfTransp.Name = "txtNfTransp"
        Me.txtNfTransp.ReadOnly = True
        Me.txtNfTransp.Size = New System.Drawing.Size(100, 20)
        Me.txtNfTransp.TabIndex = 9
        '
        'txtSerieNfTransp
        '
        Me.txtSerieNfTransp.Enabled = False
        Me.txtSerieNfTransp.Location = New System.Drawing.Point(279, 75)
        Me.txtSerieNfTransp.Name = "txtSerieNfTransp"
        Me.txtSerieNfTransp.ReadOnly = True
        Me.txtSerieNfTransp.Size = New System.Drawing.Size(63, 20)
        Me.txtSerieNfTransp.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Série"
        '
        'txtEmissaoNfTransp
        '
        Me.txtEmissaoNfTransp.Enabled = False
        Me.txtEmissaoNfTransp.Location = New System.Drawing.Point(526, 71)
        Me.txtEmissaoNfTransp.Name = "txtEmissaoNfTransp"
        Me.txtEmissaoNfTransp.ReadOnly = True
        Me.txtEmissaoNfTransp.Size = New System.Drawing.Size(100, 20)
        Me.txtEmissaoNfTransp.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(475, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Emissão"
        '
        'txtDescLojaOrigem
        '
        Me.txtDescLojaOrigem.Enabled = False
        Me.txtDescLojaOrigem.Location = New System.Drawing.Point(148, 101)
        Me.txtDescLojaOrigem.Name = "txtDescLojaOrigem"
        Me.txtDescLojaOrigem.ReadOnly = True
        Me.txtDescLojaOrigem.Size = New System.Drawing.Size(249, 20)
        Me.txtDescLojaOrigem.TabIndex = 16
        '
        'txtIdLojaOrigem
        '
        Me.txtIdLojaOrigem.Enabled = False
        Me.txtIdLojaOrigem.Location = New System.Drawing.Point(81, 101)
        Me.txtIdLojaOrigem.Name = "txtIdLojaOrigem"
        Me.txtIdLojaOrigem.ReadOnly = True
        Me.txtIdLojaOrigem.Size = New System.Drawing.Size(63, 20)
        Me.txtIdLojaOrigem.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Loja Origem"
        '
        'btnAnexarLaudo
        '
        Me.btnAnexarLaudo.Enabled = False
        Me.btnAnexarLaudo.Image = Global.WinCG.My.Resources.Resources.anexo16
        Me.btnAnexarLaudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnexarLaudo.Location = New System.Drawing.Point(420, 546)
        Me.btnAnexarLaudo.Name = "btnAnexarLaudo"
        Me.btnAnexarLaudo.Size = New System.Drawing.Size(134, 23)
        Me.btnAnexarLaudo.TabIndex = 22
        Me.btnAnexarLaudo.Text = "      Anexar PDF Laudo"
        Me.btnAnexarLaudo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnexarLaudo.UseVisualStyleBackColor = True
        '
        'btnAnexarNFe
        '
        Me.btnAnexarNFe.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnAnexarNFe.Enabled = False
        Me.btnAnexarNFe.Image = Global.WinCG.My.Resources.Resources.anexo16
        Me.btnAnexarNFe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnexarNFe.Location = New System.Drawing.Point(148, 546)
        Me.btnAnexarNFe.Name = "btnAnexarNFe"
        Me.btnAnexarNFe.Size = New System.Drawing.Size(134, 23)
        Me.btnAnexarNFe.TabIndex = 20
        Me.btnAnexarNFe.Text = "     Anexar NFe Fornec."
        Me.btnAnexarNFe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnexarNFe.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnexarNFeEmXMLToolStripMenuItem, Me.AnexarNFeEmPDFToolStripMenuItem, Me.ToolStripMenuItem1, Me.CancelarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(187, 76)
        '
        'AnexarNFeEmXMLToolStripMenuItem
        '
        Me.AnexarNFeEmXMLToolStripMenuItem.Name = "AnexarNFeEmXMLToolStripMenuItem"
        Me.AnexarNFeEmXMLToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AnexarNFeEmXMLToolStripMenuItem.Text = "Anexar NF-e em XML"
        '
        'AnexarNFeEmPDFToolStripMenuItem
        '
        Me.AnexarNFeEmPDFToolStripMenuItem.Name = "AnexarNFeEmPDFToolStripMenuItem"
        Me.AnexarNFeEmPDFToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AnexarNFeEmPDFToolStripMenuItem.Text = "Anexar NF-e em PDF"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 6)
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'btnPesqOS
        '
        Me.btnPesqOS.Image = Global.WinCG.My.Resources.Resources.Lupa16
        Me.btnPesqOS.Location = New System.Drawing.Point(179, 13)
        Me.btnPesqOS.Name = "btnPesqOS"
        Me.btnPesqOS.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqOS.TabIndex = 2
        Me.btnPesqOS.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.Image = Global.WinCG.My.Resources.Resources.save16
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(911, 546)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(90, 23)
        Me.btnSalvar.TabIndex = 25
        Me.btnSalvar.Text = "      Gravar item"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Enabled = False
        Me.btnAdicionar.Image = Global.WinCG.My.Resources.Resources.Edit16
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionar.Location = New System.Drawing.Point(12, 546)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(134, 23)
        Me.btnAdicionar.TabIndex = 19
        Me.btnAdicionar.Text = "      Editar este item"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnDesfazer
        '
        Me.btnDesfazer.Enabled = False
        Me.btnDesfazer.Image = Global.WinCG.My.Resources.Resources.Undo16
        Me.btnDesfazer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDesfazer.Location = New System.Drawing.Point(817, 546)
        Me.btnDesfazer.Name = "btnDesfazer"
        Me.btnDesfazer.Size = New System.Drawing.Size(90, 23)
        Me.btnDesfazer.TabIndex = 24
        Me.btnDesfazer.Text = "      Desfazer"
        Me.btnDesfazer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDesfazer.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.FileName = "ofd"
        Me.ofd.Filter = "XML Files|*.xml|All files|*.*"
        Me.ofd.InitialDirectory = "C:\VBN"
        Me.ofd.Title = "Selecione um arquivo xml de NFe"
        '
        'ofd2
        '
        Me.ofd2.FileName = "ofd2"
        Me.ofd2.Filter = "PDF Files|*.PDF|All files|*.*"
        Me.ofd2.InitialDirectory = "C:\VBN"
        Me.ofd2.Title = "Selecione um arquivo xml de NFe"
        '
        'btnViewPDFLaudo
        '
        Me.btnViewPDFLaudo.Enabled = False
        Me.btnViewPDFLaudo.Image = Global.WinCG.My.Resources.Resources.Lupa16
        Me.btnViewPDFLaudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewPDFLaudo.Location = New System.Drawing.Point(556, 546)
        Me.btnViewPDFLaudo.Name = "btnViewPDFLaudo"
        Me.btnViewPDFLaudo.Size = New System.Drawing.Size(134, 23)
        Me.btnViewPDFLaudo.TabIndex = 23
        Me.btnViewPDFLaudo.Text = "      Visualizar PDF Laudo"
        Me.btnViewPDFLaudo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewPDFLaudo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(462, 137)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(540, 397)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(532, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados do Item"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cboTabelaServico)
        Me.Panel1.Controls.Add(Label23)
        Me.Panel1.Controls.Add(Me.txtOutros)
        Me.Panel1.Controls.Add(Me.chkOutros)
        Me.Panel1.Controls.Add(Me.chkLaudo)
        Me.Panel1.Controls.Add(Me.lblPanel)
        Me.Panel1.Controls.Add(Me.chkRetorno)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtValorConserto)
        Me.Panel1.Controls.Add(Me.chkGarantia)
        Me.Panel1.Controls.Add(Me.txtEmissaoNFe)
        Me.Panel1.Controls.Add(Me.txtSerieNFe)
        Me.Panel1.Controls.Add(Me.lblSerie)
        Me.Panel1.Controls.Add(Me.txtNFe)
        Me.Panel1.Controls.Add(Me.lblNFe)
        Me.Panel1.Controls.Add(Me.chkConserto)
        Me.Panel1.Controls.Add(Me.btnPesqResponsavel)
        Me.Panel1.Controls.Add(Me.txtDescResponsavel)
        Me.Panel1.Controls.Add(Me.txtIdResponsavel)
        Me.Panel1.Controls.Add(Me.lblResponsavel)
        Me.Panel1.Controls.Add(Me.txtObs)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtDescDefeito)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtDataRetorno)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtPrevisaoRetorno)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtModelo)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtSerie)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtDescEquipamento)
        Me.Panel1.Controls.Add(Me.txtIdEquipamento)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtItemId)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblEmissao)
        Me.Panel1.Location = New System.Drawing.Point(7, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 359)
        Me.Panel1.TabIndex = 36
        '
        'cboTabelaServico
        '
        Me.cboTabelaServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTabelaServico.FormattingEnabled = True
        Me.cboTabelaServico.Location = New System.Drawing.Point(124, 308)
        Me.cboTabelaServico.Name = "cboTabelaServico"
        Me.cboTabelaServico.Size = New System.Drawing.Size(219, 21)
        Me.cboTabelaServico.TabIndex = 48
        '
        'txtOutros
        '
        Me.txtOutros.Location = New System.Drawing.Point(210, 196)
        Me.txtOutros.Name = "txtOutros"
        Me.txtOutros.Size = New System.Drawing.Size(300, 20)
        Me.txtOutros.TabIndex = 38
        '
        'chkOutros
        '
        Me.chkOutros.AutoSize = True
        Me.chkOutros.Location = New System.Drawing.Point(92, 198)
        Me.chkOutros.Name = "chkOutros"
        Me.chkOutros.Size = New System.Drawing.Size(123, 17)
        Me.chkOutros.TabIndex = 37
        Me.chkOutros.Text = "Outros? (especificar)"
        Me.chkOutros.UseVisualStyleBackColor = True
        '
        'chkLaudo
        '
        Me.chkLaudo.AutoSize = True
        Me.chkLaudo.Location = New System.Drawing.Point(27, 198)
        Me.chkLaudo.Name = "chkLaudo"
        Me.chkLaudo.Size = New System.Drawing.Size(62, 17)
        Me.chkLaudo.TabIndex = 36
        Me.chkLaudo.Text = "Laudo?"
        Me.chkLaudo.UseVisualStyleBackColor = True
        '
        'lblPanel
        '
        Me.lblPanel.AutoSize = True
        Me.lblPanel.ForeColor = System.Drawing.Color.Red
        Me.lblPanel.Location = New System.Drawing.Point(443, 342)
        Me.lblPanel.Name = "lblPanel"
        Me.lblPanel.Size = New System.Drawing.Size(69, 13)
        Me.lblPanel.TabIndex = 35
        Me.lblPanel.Text = "Modo Leitura"
        '
        'chkRetorno
        '
        Me.chkRetorno.AutoSize = True
        Me.chkRetorno.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRetorno.Enabled = False
        Me.chkRetorno.Location = New System.Drawing.Point(391, 10)
        Me.chkRetorno.Name = "chkRetorno"
        Me.chkRetorno.Size = New System.Drawing.Size(120, 17)
        Me.chkRetorno.TabIndex = 34
        Me.chkRetorno.Text = "Retorno Confirmado"
        Me.chkRetorno.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(165, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Valor Conserto"
        '
        'txtValorConserto
        '
        Me.txtValorConserto.Location = New System.Drawing.Point(244, 161)
        Me.txtValorConserto.Name = "txtValorConserto"
        Me.txtValorConserto.Size = New System.Drawing.Size(100, 20)
        Me.txtValorConserto.TabIndex = 32
        '
        'chkGarantia
        '
        Me.chkGarantia.AutoSize = True
        Me.chkGarantia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkGarantia.Location = New System.Drawing.Point(22, 163)
        Me.chkGarantia.Name = "chkGarantia"
        Me.chkGarantia.Size = New System.Drawing.Size(72, 17)
        Me.chkGarantia.TabIndex = 31
        Me.chkGarantia.Text = "Garantia?"
        Me.chkGarantia.UseVisualStyleBackColor = True
        '
        'txtEmissaoNFe
        '
        Me.txtEmissaoNFe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtEmissaoNFe.Location = New System.Drawing.Point(427, 134)
        Me.txtEmissaoNFe.Name = "txtEmissaoNFe"
        Me.txtEmissaoNFe.Size = New System.Drawing.Size(85, 20)
        Me.txtEmissaoNFe.TabIndex = 30
        '
        'txtSerieNFe
        '
        Me.txtSerieNFe.Location = New System.Drawing.Point(244, 134)
        Me.txtSerieNFe.Name = "txtSerieNFe"
        Me.txtSerieNFe.Size = New System.Drawing.Size(100, 20)
        Me.txtSerieNFe.TabIndex = 28
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(189, 138)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(54, 13)
        Me.lblSerie.TabIndex = 27
        Me.lblSerie.Text = "Série NFe"
        '
        'txtNFe
        '
        Me.txtNFe.Location = New System.Drawing.Point(71, 134)
        Me.txtNFe.Name = "txtNFe"
        Me.txtNFe.Size = New System.Drawing.Size(113, 20)
        Me.txtNFe.TabIndex = 26
        '
        'lblNFe
        '
        Me.lblNFe.AutoSize = True
        Me.lblNFe.Location = New System.Drawing.Point(24, 138)
        Me.lblNFe.Name = "lblNFe"
        Me.lblNFe.Size = New System.Drawing.Size(37, 13)
        Me.lblNFe.TabIndex = 25
        Me.lblNFe.Text = "NFe #"
        '
        'chkConserto
        '
        Me.chkConserto.AutoSize = True
        Me.chkConserto.Location = New System.Drawing.Point(421, 87)
        Me.chkConserto.Name = "chkConserto"
        Me.chkConserto.Size = New System.Drawing.Size(91, 17)
        Me.chkConserto.TabIndex = 24
        Me.chkConserto.Text = "Conserto Ok?"
        Me.chkConserto.UseVisualStyleBackColor = True
        '
        'btnPesqResponsavel
        '
        Me.btnPesqResponsavel.Enabled = False
        Me.btnPesqResponsavel.Image = Global.WinCG.My.Resources.Resources.Lupa16
        Me.btnPesqResponsavel.Location = New System.Drawing.Point(480, 108)
        Me.btnPesqResponsavel.Name = "btnPesqResponsavel"
        Me.btnPesqResponsavel.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqResponsavel.TabIndex = 23
        Me.btnPesqResponsavel.UseVisualStyleBackColor = True
        '
        'txtDescResponsavel
        '
        Me.txtDescResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescResponsavel.Enabled = False
        Me.txtDescResponsavel.Location = New System.Drawing.Point(161, 109)
        Me.txtDescResponsavel.Name = "txtDescResponsavel"
        Me.txtDescResponsavel.Size = New System.Drawing.Size(315, 20)
        Me.txtDescResponsavel.TabIndex = 22
        Me.txtDescResponsavel.Tag = "Nome do Responsável"
        '
        'txtIdResponsavel
        '
        Me.txtIdResponsavel.Enabled = False
        Me.txtIdResponsavel.Location = New System.Drawing.Point(100, 109)
        Me.txtIdResponsavel.Name = "txtIdResponsavel"
        Me.txtIdResponsavel.Size = New System.Drawing.Size(54, 20)
        Me.txtIdResponsavel.TabIndex = 21
        Me.txtIdResponsavel.Tag = "Id Responsável"
        '
        'lblResponsavel
        '
        Me.lblResponsavel.AutoSize = True
        Me.lblResponsavel.Location = New System.Drawing.Point(21, 113)
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Size = New System.Drawing.Size(76, 13)
        Me.lblResponsavel.TabIndex = 20
        Me.lblResponsavel.Text = "Resp. Transito"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(271, 239)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObs.Size = New System.Drawing.Size(239, 63)
        Me.txtObs.TabIndex = 16
        Me.txtObs.Tag = "Observação"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(271, 223)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Observação"
        '
        'txtDescDefeito
        '
        Me.txtDescDefeito.Location = New System.Drawing.Point(20, 239)
        Me.txtDescDefeito.Multiline = True
        Me.txtDescDefeito.Name = "txtDescDefeito"
        Me.txtDescDefeito.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescDefeito.Size = New System.Drawing.Size(239, 63)
        Me.txtDescDefeito.TabIndex = 14
        Me.txtDescDefeito.Tag = "Descrição do Defeito"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 223)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Descr. Defeito"
        '
        'txtDataRetorno
        '
        Me.txtDataRetorno.CustomFormat = "yyyy-MM-dd"
        Me.txtDataRetorno.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataRetorno.Location = New System.Drawing.Point(284, 83)
        Me.txtDataRetorno.Name = "txtDataRetorno"
        Me.txtDataRetorno.Size = New System.Drawing.Size(95, 20)
        Me.txtDataRetorno.TabIndex = 12
        Me.txtDataRetorno.Tag = "Data de Retorno"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(207, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Data Retorno"
        '
        'txtPrevisaoRetorno
        '
        Me.txtPrevisaoRetorno.Enabled = False
        Me.txtPrevisaoRetorno.Location = New System.Drawing.Point(100, 83)
        Me.txtPrevisaoRetorno.Name = "txtPrevisaoRetorno"
        Me.txtPrevisaoRetorno.ReadOnly = True
        Me.txtPrevisaoRetorno.Size = New System.Drawing.Size(100, 20)
        Me.txtPrevisaoRetorno.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Prev. Retorno"
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Location = New System.Drawing.Point(284, 57)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(228, 20)
        Me.txtModelo.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(236, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Modelo"
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Location = New System.Drawing.Point(100, 57)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(117, 20)
        Me.txtSerie.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Série"
        '
        'txtDescEquipamento
        '
        Me.txtDescEquipamento.Enabled = False
        Me.txtDescEquipamento.Location = New System.Drawing.Point(158, 32)
        Me.txtDescEquipamento.Name = "txtDescEquipamento"
        Me.txtDescEquipamento.ReadOnly = True
        Me.txtDescEquipamento.Size = New System.Drawing.Size(354, 20)
        Me.txtDescEquipamento.TabIndex = 4
        '
        'txtIdEquipamento
        '
        Me.txtIdEquipamento.Enabled = False
        Me.txtIdEquipamento.Location = New System.Drawing.Point(100, 32)
        Me.txtIdEquipamento.Name = "txtIdEquipamento"
        Me.txtIdEquipamento.ReadOnly = True
        Me.txtIdEquipamento.Size = New System.Drawing.Size(52, 20)
        Me.txtIdEquipamento.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Id Equipamento"
        '
        'txtItemId
        '
        Me.txtItemId.Enabled = False
        Me.txtItemId.Location = New System.Drawing.Point(100, 8)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.ReadOnly = True
        Me.txtItemId.Size = New System.Drawing.Size(52, 20)
        Me.txtItemId.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Item Id"
        '
        'lblEmissao
        '
        Me.lblEmissao.AutoSize = True
        Me.lblEmissao.Location = New System.Drawing.Point(352, 138)
        Me.lblEmissao.Name = "lblEmissao"
        Me.lblEmissao.Size = New System.Drawing.Size(69, 13)
        Me.lblEmissao.TabIndex = 29
        Me.lblEmissao.Text = "Emissão NFe"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(532, 371)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Trocar Nº. Série"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ChkSerie)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txtSerieNova)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.txtSerieAnterior)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txtMotivo)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.txtDataAlteracao)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 359)
        Me.Panel2.TabIndex = 0
        '
        'ChkSerie
        '
        Me.ChkSerie.AutoSize = True
        Me.ChkSerie.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkSerie.Location = New System.Drawing.Point(30, 27)
        Me.ChkSerie.Name = "ChkSerie"
        Me.ChkSerie.Size = New System.Drawing.Size(105, 17)
        Me.ChkSerie.TabIndex = 8
        Me.ChkSerie.Text = "Trocar Nº Série?"
        Me.ChkSerie.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(27, 263)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Nº Série Novo"
        '
        'txtSerieNova
        '
        Me.txtSerieNova.Location = New System.Drawing.Point(118, 260)
        Me.txtSerieNova.Name = "txtSerieNova"
        Me.txtSerieNova.Size = New System.Drawing.Size(147, 20)
        Me.txtSerieNova.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(27, 228)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Nº Série Anterior"
        '
        'txtSerieAnterior
        '
        Me.txtSerieAnterior.Enabled = False
        Me.txtSerieAnterior.Location = New System.Drawing.Point(118, 225)
        Me.txtSerieAnterior.Name = "txtSerieAnterior"
        Me.txtSerieAnterior.ReadOnly = True
        Me.txtSerieAnterior.Size = New System.Drawing.Size(147, 20)
        Me.txtSerieAnterior.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Motivo da Alteração"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(30, 118)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(374, 90)
        Me.txtMotivo.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(27, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Data Alteração"
        '
        'txtDataAlteracao
        '
        Me.txtDataAlteracao.CustomFormat = "yyyy-MM-dd"
        Me.txtDataAlteracao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataAlteracao.Location = New System.Drawing.Point(113, 59)
        Me.txtDataAlteracao.Name = "txtDataAlteracao"
        Me.txtDataAlteracao.Size = New System.Drawing.Size(105, 20)
        Me.txtDataAlteracao.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.txtFinal)
        Me.TabPage3.Controls.Add(Me.txtInicio)
        Me.TabPage3.Controls.Add(Me.spnDias)
        Me.TabPage3.Controls.Add(Me.chkConfigGarantia)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(532, 371)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Controle de Garantia"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(51, 172)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Término"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(51, 116)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Início"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(51, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Qtde Dias"
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(51, 192)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.ReadOnly = True
        Me.txtFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtFinal.TabIndex = 6
        '
        'txtInicio
        '
        Me.txtInicio.Location = New System.Drawing.Point(51, 136)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.ReadOnly = True
        Me.txtInicio.Size = New System.Drawing.Size(100, 20)
        Me.txtInicio.TabIndex = 4
        '
        'spnDias
        '
        Me.spnDias.Location = New System.Drawing.Point(116, 68)
        Me.spnDias.Name = "spnDias"
        Me.spnDias.Size = New System.Drawing.Size(67, 20)
        Me.spnDias.TabIndex = 2
        '
        'chkConfigGarantia
        '
        Me.chkConfigGarantia.AutoSize = True
        Me.chkConfigGarantia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkConfigGarantia.Location = New System.Drawing.Point(51, 35)
        Me.chkConfigGarantia.Name = "chkConfigGarantia"
        Me.chkConfigGarantia.Size = New System.Drawing.Size(123, 17)
        Me.chkConfigGarantia.TabIndex = 0
        Me.chkConfigGarantia.Text = "Configurar Garantia?"
        Me.chkConfigGarantia.UseVisualStyleBackColor = True
        '
        'btnViewPDFNFe
        '
        Me.btnViewPDFNFe.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnViewPDFNFe.Enabled = False
        Me.btnViewPDFNFe.Image = Global.WinCG.My.Resources.Resources.Lupa16
        Me.btnViewPDFNFe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewPDFNFe.Location = New System.Drawing.Point(284, 546)
        Me.btnViewPDFNFe.Name = "btnViewPDFNFe"
        Me.btnViewPDFNFe.Size = New System.Drawing.Size(134, 23)
        Me.btnViewPDFNFe.TabIndex = 21
        Me.btnViewPDFNFe.Text = "     Visualizar NFe Fornec."
        Me.btnViewPDFNFe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewPDFNFe.UseVisualStyleBackColor = True
        '
        'Recebimento_OS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 573)
        Me.Controls.Add(Me.btnViewPDFNFe)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnViewPDFLaudo)
        Me.Controls.Add(Me.btnDesfazer)
        Me.Controls.Add(Me.btnAnexarLaudo)
        Me.Controls.Add(Me.btnAnexarNFe)
        Me.Controls.Add(Me.txtDescLojaOrigem)
        Me.Controls.Add(Me.txtIdLojaOrigem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmissaoNfTransp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSerieNfTransp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNfTransp)
        Me.Controls.Add(Me.txtDescFornecedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdFornecedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDataOS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPesqOS)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.txtId_OS)
        Me.Controls.Add(Me.lblOS)
        Me.Name = "Recebimento_OS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retorno de Ordem de Serviço "
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.spnDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOS As System.Windows.Forms.Label
    Friend WithEvents txtId_OS As System.Windows.Forms.TextBox
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnPesqOS As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDataOS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txtNfTransp As System.Windows.Forms.TextBox
    Friend WithEvents txtSerieNfTransp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmissaoNfTransp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescLojaOrigem As System.Windows.Forms.TextBox
    Friend WithEvents txtIdLojaOrigem As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAnexarNFe As System.Windows.Forms.Button
    Friend WithEvents btnAnexarLaudo As System.Windows.Forms.Button
    Friend WithEvents btnDesfazer As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofd2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnViewPDFLaudo As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtValorConserto As System.Windows.Forms.TextBox
    Friend WithEvents chkGarantia As System.Windows.Forms.CheckBox
    Friend WithEvents txtEmissaoNFe As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEmissao As System.Windows.Forms.Label
    Friend WithEvents txtSerieNFe As System.Windows.Forms.TextBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtNFe As System.Windows.Forms.TextBox
    Friend WithEvents lblNFe As System.Windows.Forms.Label
    Friend WithEvents chkConserto As System.Windows.Forms.CheckBox
    Friend WithEvents btnPesqResponsavel As System.Windows.Forms.Button
    Friend WithEvents txtDescResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents txtIdResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents lblResponsavel As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDescDefeito As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDataRetorno As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPrevisaoRetorno As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents txtIdEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtItemId As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents chkRetorno As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AnexarNFeEmXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnexarNFeEmPDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPanel As System.Windows.Forms.Label
    Friend WithEvents btnViewPDFNFe As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtSerieNova As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSerieAnterior As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDataAlteracao As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkSerie As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtInicio As System.Windows.Forms.TextBox
    Friend WithEvents spnDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkConfigGarantia As System.Windows.Forms.CheckBox
    Friend WithEvents txtOutros As TextBox
    Friend WithEvents chkOutros As CheckBox
    Friend WithEvents chkLaudo As CheckBox
    Friend WithEvents cboTabelaServico As ComboBox
End Class
