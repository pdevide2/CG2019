<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OS
    Inherits modeloCadastro

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OS))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnexarEmPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnexarEmXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnexarEmXMLToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnexarEmPDFToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnOcorrenciasLoja = New System.Windows.Forms.Button()
        Me.btnAnexa2 = New System.Windows.Forms.Button()
        Me.btnAnexa1 = New System.Windows.Forms.Button()
        Me.btnFollowUp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEmissaoNFe = New System.Windows.Forms.DateTimePicker()
        Me.txtSerieNFe = New System.Windows.Forms.TextBox()
        Me.txtNFe = New System.Windows.Forms.TextBox()
        Me.lblEmissao = New System.Windows.Forms.Label()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.lblNFe = New System.Windows.Forms.Label()
        Me.lblDadosNf = New System.Windows.Forms.Label()
        Me.btnExclui = New System.Windows.Forms.Button()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.btnPesqResponsavel = New System.Windows.Forms.Button()
        Me.txtDescResponsavel = New System.Windows.Forms.TextBox()
        Me.txtIdResponsavel = New System.Windows.Forms.TextBox()
        Me.lblResponsavel = New System.Windows.Forms.Label()
        Me.btnPesqLojaDestino = New System.Windows.Forms.Button()
        Me.txtDescFornecedor = New System.Windows.Forms.TextBox()
        Me.txtIdFornecedor = New System.Windows.Forms.TextBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.txtData = New System.Windows.Forms.DateTimePicker()
        Me.btnPesqLoja = New System.Windows.Forms.Button()
        Me.txtDescLoja = New System.Windows.Forms.TextBox()
        Me.txtIdLoja = New System.Windows.Forms.TextBox()
        Me.lblLojaOrigem = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblMensagem1 = New System.Windows.Forms.Label()
        Me.btnViewPDFNFe_TS = New System.Windows.Forms.Button()
        Me.btnViewXMLNFe_Ts = New System.Windows.Forms.Button()
        Me.btnViewPDFNFe_Transp = New System.Windows.Forms.Button()
        Me.btnViewXMLNFe_Transp = New System.Windows.Forms.Button()
        Me.ofd2 = New System.Windows.Forms.OpenFileDialog()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VincularOcorrênciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExcluirVinculoComOcorrênciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkPDF = New System.Windows.Forms.CheckBox()
        Me.Report1 = New FastReport.Report()
        Me.DbCGDataSet1 = New WinCG.dbCGDataSet()
        Me.ckOSCliente = New System.Windows.Forms.CheckBox()
        Me.PesqFK_Cliente = New WinCG.PesqFK()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCGDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnexarEmPDFToolStripMenuItem, Me.AnexarEmXMLToolStripMenuItem, Me.ToolStripMenuItem2, Me.CancelarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 76)
        '
        'AnexarEmPDFToolStripMenuItem
        '
        Me.AnexarEmPDFToolStripMenuItem.Name = "AnexarEmPDFToolStripMenuItem"
        Me.AnexarEmPDFToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AnexarEmPDFToolStripMenuItem.Text = "Anexar em PDF"
        '
        'AnexarEmXMLToolStripMenuItem
        '
        Me.AnexarEmXMLToolStripMenuItem.Name = "AnexarEmXMLToolStripMenuItem"
        Me.AnexarEmXMLToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AnexarEmXMLToolStripMenuItem.Text = "Anexar em XML"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(154, 6)
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'ofd
        '
        Me.ofd.FileName = "ofd"
        Me.ofd.Filter = "XML Files|*.xml|All files|*.*"
        Me.ofd.InitialDirectory = "C:\VBN"
        Me.ofd.Title = "Selecione um arquivo xml de NFe"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnexarEmXMLToolStripMenuItem1, Me.AnexarEmPDFToolStripMenuItem1, Me.ToolStripMenuItem3, Me.CancelarToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(158, 76)
        '
        'AnexarEmXMLToolStripMenuItem1
        '
        Me.AnexarEmXMLToolStripMenuItem1.Name = "AnexarEmXMLToolStripMenuItem1"
        Me.AnexarEmXMLToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.AnexarEmXMLToolStripMenuItem1.Text = "Anexar em XML"
        '
        'AnexarEmPDFToolStripMenuItem1
        '
        Me.AnexarEmPDFToolStripMenuItem1.Name = "AnexarEmPDFToolStripMenuItem1"
        Me.AnexarEmPDFToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.AnexarEmPDFToolStripMenuItem1.Text = "Anexar em PDF"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(154, 6)
        '
        'CancelarToolStripMenuItem1
        '
        Me.CancelarToolStripMenuItem1.Name = "CancelarToolStripMenuItem1"
        Me.CancelarToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.CancelarToolStripMenuItem1.Text = "Cancelar"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(892, 436)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PesqFK_Cliente)
        Me.TabPage1.Controls.Add(Me.ckOSCliente)
        Me.TabPage1.Controls.Add(Me.btnOcorrenciasLoja)
        Me.TabPage1.Controls.Add(Me.btnAnexa2)
        Me.TabPage1.Controls.Add(Me.btnAnexa1)
        Me.TabPage1.Controls.Add(Me.btnFollowUp)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cboStatus)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.btnExclui)
        Me.TabPage1.Controls.Add(Me.btnAdiciona)
        Me.TabPage1.Controls.Add(Me.btnPesqResponsavel)
        Me.TabPage1.Controls.Add(Me.txtDescResponsavel)
        Me.TabPage1.Controls.Add(Me.txtIdResponsavel)
        Me.TabPage1.Controls.Add(Me.lblResponsavel)
        Me.TabPage1.Controls.Add(Me.btnPesqLojaDestino)
        Me.TabPage1.Controls.Add(Me.txtDescFornecedor)
        Me.TabPage1.Controls.Add(Me.txtIdFornecedor)
        Me.TabPage1.Controls.Add(Me.lblFornecedor)
        Me.TabPage1.Controls.Add(Me.dgvDados)
        Me.TabPage1.Controls.Add(Me.txtData)
        Me.TabPage1.Controls.Add(Me.btnPesqLoja)
        Me.TabPage1.Controls.Add(Me.txtDescLoja)
        Me.TabPage1.Controls.Add(Me.txtIdLoja)
        Me.TabPage1.Controls.Add(Me.lblLojaOrigem)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.lblData)
        Me.TabPage1.Controls.Add(Me.lblCodigo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 1)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(884, 410)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados OS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnOcorrenciasLoja
        '
        Me.btnOcorrenciasLoja.Image = CType(resources.GetObject("btnOcorrenciasLoja.Image"), System.Drawing.Image)
        Me.btnOcorrenciasLoja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOcorrenciasLoja.Location = New System.Drawing.Point(528, 64)
        Me.btnOcorrenciasLoja.Name = "btnOcorrenciasLoja"
        Me.btnOcorrenciasLoja.Size = New System.Drawing.Size(148, 23)
        Me.btnOcorrenciasLoja.TabIndex = 53
        Me.btnOcorrenciasLoja.Text = "Ocorrências da Loja"
        Me.btnOcorrenciasLoja.UseVisualStyleBackColor = True
        '
        'btnAnexa2
        '
        Me.btnAnexa2.Image = Global.WinCG.My.Resources.Resources.anexo16
        Me.btnAnexa2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAnexa2.Location = New System.Drawing.Point(739, 380)
        Me.btnAnexa2.Name = "btnAnexa2"
        Me.btnAnexa2.Size = New System.Drawing.Size(135, 23)
        Me.btnAnexa2.TabIndex = 52
        Me.btnAnexa2.Text = "     Anexar NFTS"
        Me.btnAnexa2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnexa2.UseVisualStyleBackColor = True
        '
        'btnAnexa1
        '
        Me.btnAnexa1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnAnexa1.Image = Global.WinCG.My.Resources.Resources.anexo16
        Me.btnAnexa1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAnexa1.Location = New System.Drawing.Point(600, 380)
        Me.btnAnexa1.Name = "btnAnexa1"
        Me.btnAnexa1.Size = New System.Drawing.Size(135, 23)
        Me.btnAnexa1.TabIndex = 51
        Me.btnAnexa1.Text = "Anexar NF Transp."
        Me.btnAnexa1.UseVisualStyleBackColor = True
        '
        'btnFollowUp
        '
        Me.btnFollowUp.Image = Global.WinCG.My.Resources.Resources.followup16
        Me.btnFollowUp.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnFollowUp.Location = New System.Drawing.Point(461, 380)
        Me.btnFollowUp.Name = "btnFollowUp"
        Me.btnFollowUp.Size = New System.Drawing.Size(135, 23)
        Me.btnFollowUp.TabIndex = 50
        Me.btnFollowUp.Text = "Follow UP da OS"
        Me.btnFollowUp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(665, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Status da OS"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(661, 175)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(201, 21)
        Me.cboStatus.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtEmissaoNFe)
        Me.Panel1.Controls.Add(Me.txtSerieNFe)
        Me.Panel1.Controls.Add(Me.txtNFe)
        Me.Panel1.Controls.Add(Me.lblEmissao)
        Me.Panel1.Controls.Add(Me.lblSerie)
        Me.Panel1.Controls.Add(Me.lblNFe)
        Me.Panel1.Controls.Add(Me.lblDadosNf)
        Me.Panel1.Location = New System.Drawing.Point(6, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 53)
        Me.Panel1.TabIndex = 47
        '
        'txtEmissaoNFe
        '
        Me.txtEmissaoNFe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtEmissaoNFe.Location = New System.Drawing.Point(528, 26)
        Me.txtEmissaoNFe.Name = "txtEmissaoNFe"
        Me.txtEmissaoNFe.Size = New System.Drawing.Size(85, 20)
        Me.txtEmissaoNFe.TabIndex = 6
        '
        'txtSerieNFe
        '
        Me.txtSerieNFe.Location = New System.Drawing.Point(281, 26)
        Me.txtSerieNFe.Name = "txtSerieNFe"
        Me.txtSerieNFe.Size = New System.Drawing.Size(100, 20)
        Me.txtSerieNFe.TabIndex = 5
        '
        'txtNFe
        '
        Me.txtNFe.Location = New System.Drawing.Point(59, 26)
        Me.txtNFe.Name = "txtNFe"
        Me.txtNFe.Size = New System.Drawing.Size(100, 20)
        Me.txtNFe.TabIndex = 4
        '
        'lblEmissao
        '
        Me.lblEmissao.AutoSize = True
        Me.lblEmissao.Location = New System.Drawing.Point(476, 30)
        Me.lblEmissao.Name = "lblEmissao"
        Me.lblEmissao.Size = New System.Drawing.Size(46, 13)
        Me.lblEmissao.TabIndex = 3
        Me.lblEmissao.Text = "Emissão"
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(238, 30)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(31, 13)
        Me.lblSerie.TabIndex = 2
        Me.lblSerie.Text = "Série"
        '
        'lblNFe
        '
        Me.lblNFe.AutoSize = True
        Me.lblNFe.Location = New System.Drawing.Point(16, 30)
        Me.lblNFe.Name = "lblNFe"
        Me.lblNFe.Size = New System.Drawing.Size(37, 13)
        Me.lblNFe.TabIndex = 1
        Me.lblNFe.Text = "NFe #"
        '
        'lblDadosNf
        '
        Me.lblDadosNf.AutoSize = True
        Me.lblDadosNf.Location = New System.Drawing.Point(19, 5)
        Me.lblDadosNf.Name = "lblDadosNf"
        Me.lblDadosNf.Size = New System.Drawing.Size(115, 13)
        Me.lblDadosNf.TabIndex = 0
        Me.lblDadosNf.Text = "Dados NFe Transporte"
        '
        'btnExclui
        '
        Me.btnExclui.Image = CType(resources.GetObject("btnExclui.Image"), System.Drawing.Image)
        Me.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExclui.Location = New System.Drawing.Point(111, 380)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(99, 23)
        Me.btnExclui.TabIndex = 46
        Me.btnExclui.Text = "Excluir"
        Me.btnExclui.UseVisualStyleBackColor = True
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Image = CType(resources.GetObject("btnAdiciona.Image"), System.Drawing.Image)
        Me.btnAdiciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdiciona.Location = New System.Drawing.Point(12, 380)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(99, 23)
        Me.btnAdiciona.TabIndex = 45
        Me.btnAdiciona.Text = "Adicionar"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'btnPesqResponsavel
        '
        Me.btnPesqResponsavel.Enabled = False
        Me.btnPesqResponsavel.Image = Global.WinCG.My.Resources.Resources.Lupa16
        Me.btnPesqResponsavel.Location = New System.Drawing.Point(489, 33)
        Me.btnPesqResponsavel.Name = "btnPesqResponsavel"
        Me.btnPesqResponsavel.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqResponsavel.TabIndex = 44
        Me.btnPesqResponsavel.UseVisualStyleBackColor = True
        '
        'txtDescResponsavel
        '
        Me.txtDescResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescResponsavel.Enabled = False
        Me.txtDescResponsavel.Location = New System.Drawing.Point(162, 34)
        Me.txtDescResponsavel.Name = "txtDescResponsavel"
        Me.txtDescResponsavel.Size = New System.Drawing.Size(321, 20)
        Me.txtDescResponsavel.TabIndex = 43
        '
        'txtIdResponsavel
        '
        Me.txtIdResponsavel.Enabled = False
        Me.txtIdResponsavel.Location = New System.Drawing.Point(93, 35)
        Me.txtIdResponsavel.Name = "txtIdResponsavel"
        Me.txtIdResponsavel.Size = New System.Drawing.Size(64, 20)
        Me.txtIdResponsavel.TabIndex = 42
        '
        'lblResponsavel
        '
        Me.lblResponsavel.AutoSize = True
        Me.lblResponsavel.Location = New System.Drawing.Point(12, 38)
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Size = New System.Drawing.Size(76, 13)
        Me.lblResponsavel.TabIndex = 41
        Me.lblResponsavel.Text = "Resp. Transito"
        '
        'btnPesqLojaDestino
        '
        Me.btnPesqLojaDestino.Enabled = False
        Me.btnPesqLojaDestino.Image = CType(resources.GetObject("btnPesqLojaDestino.Image"), System.Drawing.Image)
        Me.btnPesqLojaDestino.Location = New System.Drawing.Point(489, 92)
        Me.btnPesqLojaDestino.Name = "btnPesqLojaDestino"
        Me.btnPesqLojaDestino.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqLojaDestino.TabIndex = 40
        Me.btnPesqLojaDestino.UseVisualStyleBackColor = True
        '
        'txtDescFornecedor
        '
        Me.txtDescFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescFornecedor.Enabled = False
        Me.txtDescFornecedor.Location = New System.Drawing.Point(162, 93)
        Me.txtDescFornecedor.Name = "txtDescFornecedor"
        Me.txtDescFornecedor.Size = New System.Drawing.Size(321, 20)
        Me.txtDescFornecedor.TabIndex = 39
        '
        'txtIdFornecedor
        '
        Me.txtIdFornecedor.Enabled = False
        Me.txtIdFornecedor.Location = New System.Drawing.Point(93, 94)
        Me.txtIdFornecedor.Name = "txtIdFornecedor"
        Me.txtIdFornecedor.Size = New System.Drawing.Size(64, 20)
        Me.txtIdFornecedor.TabIndex = 38
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(12, 97)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(61, 13)
        Me.lblFornecedor.TabIndex = 37
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(9, 217)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(865, 156)
        Me.dgvDados.TabIndex = 36
        '
        'txtData
        '
        Me.txtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtData.Location = New System.Drawing.Point(437, 5)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(85, 20)
        Me.txtData.TabIndex = 31
        '
        'btnPesqLoja
        '
        Me.btnPesqLoja.Enabled = False
        Me.btnPesqLoja.Image = CType(resources.GetObject("btnPesqLoja.Image"), System.Drawing.Image)
        Me.btnPesqLoja.Location = New System.Drawing.Point(489, 63)
        Me.btnPesqLoja.Name = "btnPesqLoja"
        Me.btnPesqLoja.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqLoja.TabIndex = 35
        Me.btnPesqLoja.UseVisualStyleBackColor = True
        '
        'txtDescLoja
        '
        Me.txtDescLoja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescLoja.Enabled = False
        Me.txtDescLoja.Location = New System.Drawing.Point(162, 64)
        Me.txtDescLoja.Name = "txtDescLoja"
        Me.txtDescLoja.Size = New System.Drawing.Size(321, 20)
        Me.txtDescLoja.TabIndex = 34
        '
        'txtIdLoja
        '
        Me.txtIdLoja.Enabled = False
        Me.txtIdLoja.Location = New System.Drawing.Point(93, 65)
        Me.txtIdLoja.Name = "txtIdLoja"
        Me.txtIdLoja.Size = New System.Drawing.Size(64, 20)
        Me.txtIdLoja.TabIndex = 33
        '
        'lblLojaOrigem
        '
        Me.lblLojaOrigem.AutoSize = True
        Me.lblLojaOrigem.Location = New System.Drawing.Point(12, 68)
        Me.lblLojaOrigem.Name = "lblLojaOrigem"
        Me.lblLojaOrigem.Size = New System.Drawing.Size(63, 13)
        Me.lblLojaOrigem.TabIndex = 32
        Me.lblLojaOrigem.Text = "Loja Origem"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(93, 5)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(98, 20)
        Me.txtCodigo.TabIndex = 29
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(392, 9)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 30
        Me.lblData.Text = "Data"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 9)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(38, 13)
        Me.lblCodigo.TabIndex = 28
        Me.lblCodigo.Text = "O.S. #"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblMensagem1)
        Me.TabPage2.Controls.Add(Me.btnViewPDFNFe_TS)
        Me.TabPage2.Controls.Add(Me.btnViewXMLNFe_Ts)
        Me.TabPage2.Controls.Add(Me.btnViewPDFNFe_Transp)
        Me.TabPage2.Controls.Add(Me.btnViewXMLNFe_Transp)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(884, 410)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Visualizar Anexos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblMensagem1
        '
        Me.lblMensagem1.AutoSize = True
        Me.lblMensagem1.Location = New System.Drawing.Point(20, 377)
        Me.lblMensagem1.Name = "lblMensagem1"
        Me.lblMensagem1.Size = New System.Drawing.Size(545, 13)
        Me.lblMensagem1.TabIndex = 4
        Me.lblMensagem1.Text = "* Os arquivos temporários são recuperados do banco de dados e extraídos para a pa" &
    "sta  D:\ControleGestao\TMP"
        '
        'btnViewPDFNFe_TS
        '
        Me.btnViewPDFNFe_TS.Image = CType(resources.GetObject("btnViewPDFNFe_TS.Image"), System.Drawing.Image)
        Me.btnViewPDFNFe_TS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewPDFNFe_TS.Location = New System.Drawing.Point(23, 215)
        Me.btnViewPDFNFe_TS.Name = "btnViewPDFNFe_TS"
        Me.btnViewPDFNFe_TS.Size = New System.Drawing.Size(113, 32)
        Me.btnViewPDFNFe_TS.TabIndex = 3
        Me.btnViewPDFNFe_TS.Text = "   NFe TS"
        Me.btnViewPDFNFe_TS.UseVisualStyleBackColor = True
        '
        'btnViewXMLNFe_Ts
        '
        Me.btnViewXMLNFe_Ts.Image = CType(resources.GetObject("btnViewXMLNFe_Ts.Image"), System.Drawing.Image)
        Me.btnViewXMLNFe_Ts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewXMLNFe_Ts.Location = New System.Drawing.Point(23, 157)
        Me.btnViewXMLNFe_Ts.Name = "btnViewXMLNFe_Ts"
        Me.btnViewXMLNFe_Ts.Size = New System.Drawing.Size(113, 32)
        Me.btnViewXMLNFe_Ts.TabIndex = 2
        Me.btnViewXMLNFe_Ts.Text = "   NFe TS"
        Me.btnViewXMLNFe_Ts.UseVisualStyleBackColor = True
        '
        'btnViewPDFNFe_Transp
        '
        Me.btnViewPDFNFe_Transp.Image = CType(resources.GetObject("btnViewPDFNFe_Transp.Image"), System.Drawing.Image)
        Me.btnViewPDFNFe_Transp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewPDFNFe_Transp.Location = New System.Drawing.Point(23, 97)
        Me.btnViewPDFNFe_Transp.Name = "btnViewPDFNFe_Transp"
        Me.btnViewPDFNFe_Transp.Size = New System.Drawing.Size(113, 32)
        Me.btnViewPDFNFe_Transp.TabIndex = 1
        Me.btnViewPDFNFe_Transp.Text = "NFe Transp."
        Me.btnViewPDFNFe_Transp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewPDFNFe_Transp.UseVisualStyleBackColor = True
        '
        'btnViewXMLNFe_Transp
        '
        Me.btnViewXMLNFe_Transp.Image = CType(resources.GetObject("btnViewXMLNFe_Transp.Image"), System.Drawing.Image)
        Me.btnViewXMLNFe_Transp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewXMLNFe_Transp.Location = New System.Drawing.Point(23, 39)
        Me.btnViewXMLNFe_Transp.Name = "btnViewXMLNFe_Transp"
        Me.btnViewXMLNFe_Transp.Size = New System.Drawing.Size(113, 32)
        Me.btnViewXMLNFe_Transp.TabIndex = 0
        Me.btnViewXMLNFe_Transp.Text = "NFe Transp."
        Me.btnViewXMLNFe_Transp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewXMLNFe_Transp.UseVisualStyleBackColor = True
        '
        'ofd2
        '
        Me.ofd2.FileName = "ofd"
        Me.ofd2.Filter = "XML Files|*.xml|All files|*.*"
        Me.ofd2.InitialDirectory = "C:\VBN"
        Me.ofd2.Title = "Selecione um arquivo xml de NFe"
        '
        'btnReport
        '
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(731, 443)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(147, 32)
        Me.btnReport.TabIndex = 27
        Me.btnReport.Text = "Relatório OS"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VincularOcorrênciaToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExcluirVinculoComOcorrênciaToolStripMenuItem, Me.ToolStripMenuItem4, Me.ConsultarToolStripMenuItem, Me.ToolStripMenuItem5, Me.CancelarToolStripMenuItem2})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(240, 110)
        '
        'VincularOcorrênciaToolStripMenuItem
        '
        Me.VincularOcorrênciaToolStripMenuItem.Image = CType(resources.GetObject("VincularOcorrênciaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VincularOcorrênciaToolStripMenuItem.Name = "VincularOcorrênciaToolStripMenuItem"
        Me.VincularOcorrênciaToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.VincularOcorrênciaToolStripMenuItem.Text = "Vincular Ocorrência"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(236, 6)
        '
        'ExcluirVinculoComOcorrênciaToolStripMenuItem
        '
        Me.ExcluirVinculoComOcorrênciaToolStripMenuItem.Image = CType(resources.GetObject("ExcluirVinculoComOcorrênciaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirVinculoComOcorrênciaToolStripMenuItem.Name = "ExcluirVinculoComOcorrênciaToolStripMenuItem"
        Me.ExcluirVinculoComOcorrênciaToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ExcluirVinculoComOcorrênciaToolStripMenuItem.Text = "Excluir Vinculo com Ocorrência"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(236, 6)
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Image = Global.WinCG.My.Resources.Resources.Lupa16
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(236, 6)
        '
        'CancelarToolStripMenuItem2
        '
        Me.CancelarToolStripMenuItem2.Image = Global.WinCG.My.Resources.Resources.Undo16
        Me.CancelarToolStripMenuItem2.Name = "CancelarToolStripMenuItem2"
        Me.CancelarToolStripMenuItem2.Size = New System.Drawing.Size(239, 22)
        Me.CancelarToolStripMenuItem2.Text = "Cancelar"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(731, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 32)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Relatório OS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkPDF
        '
        Me.chkPDF.AutoSize = True
        Me.chkPDF.Checked = True
        Me.chkPDF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPDF.Location = New System.Drawing.Point(641, 454)
        Me.chkPDF.Name = "chkPDF"
        Me.chkPDF.Size = New System.Drawing.Size(82, 17)
        Me.chkPDF.TabIndex = 29
        Me.chkPDF.Text = "Gerar PDF?"
        Me.chkPDF.UseVisualStyleBackColor = True
        '
        'Report1
        '
        Me.Report1.NeedRefresh = False
        Me.Report1.ReportResourceString = resources.GetString("Report1.ReportResourceString")
        Me.Report1.RegisterData(Me.DbCGDataSet1, "DbCGDataSet1")
        '
        'DbCGDataSet1
        '
        Me.DbCGDataSet1.DataSetName = "dbCGDataSet"
        Me.DbCGDataSet1.EnforceConstraints = False
        Me.DbCGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ckOSCliente
        '
        Me.ckOSCliente.AutoSize = True
        Me.ckOSCliente.Location = New System.Drawing.Point(12, 135)
        Me.ckOSCliente.Name = "ckOSCliente"
        Me.ckOSCliente.Size = New System.Drawing.Size(97, 17)
        Me.ckOSCliente.TabIndex = 54
        Me.ckOSCliente.Text = "OS de Cliente?"
        Me.ckOSCliente.UseVisualStyleBackColor = True
        '
        'PesqFK_Cliente
        '
        Me.PesqFK_Cliente.CampoDesc = Nothing
        Me.PesqFK_Cliente.CampoId = Nothing
        Me.PesqFK_Cliente.Clicou = "0"
        Me.PesqFK_Cliente.CodigoSelecionado = Nothing
        Me.PesqFK_Cliente.ColunasFiltro = Nothing
        Me.PesqFK_Cliente.DescricaoSelecionada = Nothing
        Me.PesqFK_Cliente.FiltroSQL = Nothing
        Me.PesqFK_Cliente.LabelBuscaDesc = Nothing
        Me.PesqFK_Cliente.LabelBuscaId = Nothing
        Me.PesqFK_Cliente.LabelPesqFK = "Cliente"
        Me.PesqFK_Cliente.ListaCampos = Nothing
        Me.PesqFK_Cliente.Location = New System.Drawing.Point(128, 127)
        Me.PesqFK_Cliente.Name = "PesqFK_Cliente"
        Me.PesqFK_Cliente.ObjModelFk = Nothing
        Me.PesqFK_Cliente.OrderByQuery = Nothing
        Me.PesqFK_Cliente.PosValida = False
        Me.PesqFK_Cliente.Size = New System.Drawing.Size(607, 25)
        Me.PesqFK_Cliente.Tabela = Nothing
        Me.PesqFK_Cliente.TabIndex = 55
        Me.PesqFK_Cliente.TituloTela = Nothing
        Me.PesqFK_Cliente.View = Nothing
        '
        'OS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 482)
        Me.Controls.Add(Me.chkPDF)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "OS"
        Me.Text = "Ordem de Serviço (Equipamentos)"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.btnReport, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.chkPDF, 0)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ContextMenuStrip3.ResumeLayout(False)
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCGDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AnexarEmPDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnexarEmXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtEmissaoNFe As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSerieNFe As System.Windows.Forms.TextBox
    Friend WithEvents txtNFe As System.Windows.Forms.TextBox
    Friend WithEvents lblEmissao As System.Windows.Forms.Label
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents lblNFe As System.Windows.Forms.Label
    Friend WithEvents lblDadosNf As System.Windows.Forms.Label
    Friend WithEvents btnExclui As System.Windows.Forms.Button
    Friend WithEvents btnAdiciona As System.Windows.Forms.Button
    Friend WithEvents btnPesqResponsavel As System.Windows.Forms.Button
    Friend WithEvents txtDescResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents txtIdResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents lblResponsavel As System.Windows.Forms.Label
    Friend WithEvents btnPesqLojaDestino As System.Windows.Forms.Button
    Friend WithEvents txtDescFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txtIdFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents txtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPesqLoja As System.Windows.Forms.Button
    Friend WithEvents txtDescLoja As System.Windows.Forms.TextBox
    Friend WithEvents txtIdLoja As System.Windows.Forms.TextBox
    Friend WithEvents lblLojaOrigem As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnAnexa2 As System.Windows.Forms.Button
    Friend WithEvents btnAnexa1 As System.Windows.Forms.Button
    Friend WithEvents btnFollowUp As System.Windows.Forms.Button
    Friend WithEvents btnViewXMLNFe_Transp As System.Windows.Forms.Button
    Friend WithEvents lblMensagem1 As System.Windows.Forms.Label
    Friend WithEvents btnViewPDFNFe_TS As System.Windows.Forms.Button
    Friend WithEvents btnViewXMLNFe_Ts As System.Windows.Forms.Button
    Friend WithEvents btnViewPDFNFe_Transp As System.Windows.Forms.Button
    Friend WithEvents AnexarEmXMLToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnexarEmPDFToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofd2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VincularOcorrênciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExcluirVinculoComOcorrênciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnOcorrenciasLoja As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents chkPDF As CheckBox
    Friend WithEvents Report1 As FastReport.Report
    Friend WithEvents DbCGDataSet1 As dbCGDataSet
    Friend WithEvents PesqFK_Cliente As PesqFK
    Friend WithEvents ckOSCliente As CheckBox
End Class
