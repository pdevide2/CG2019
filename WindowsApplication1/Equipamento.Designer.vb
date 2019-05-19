<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipamento
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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DESC_EQUIPAMENTOLabel As System.Windows.Forms.Label
        Dim SERIELabel As System.Windows.Forms.Label
        Dim MODELOLabel As System.Windows.Forms.Label
        Dim PROTOCOLOLabel As System.Windows.Forms.Label
        Dim VALORLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PesqFKTipo = New WinCG.PesqFK()
        Me.PesqFKFornecedor = New WinCG.PesqFK()
        Me.txtId_Controle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrazo_Garantia = New System.Windows.Forms.TextBox()
        Me.txtNf_Entrada = New System.Windows.Forms.TextBox()
        Me.txtData_Nf = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtProtocolo = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chkGarantiaVigente = New System.Windows.Forms.CheckBox()
        Me.txtDataTerminoGarantia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDataInicioGarantia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUltimaOS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        DESC_EQUIPAMENTOLabel = New System.Windows.Forms.Label()
        SERIELabel = New System.Windows.Forms.Label()
        MODELOLabel = New System.Windows.Forms.Label()
        PROTOCOLOLabel = New System.Windows.Forms.Label()
        VALORLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(162, 209)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(177, 13)
        Label5.TabIndex = 67
        Label5.Text = "(Equipto novo/Dias após Aquisição)"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(10, 209)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(77, 13)
        Label4.TabIndex = 65
        Label4.Text = "Prazo Garantia"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 183)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(66, 13)
        Label3.TabIndex = 63
        Label3.Text = "NFe Fornec."
        '
        'DESC_EQUIPAMENTOLabel
        '
        DESC_EQUIPAMENTOLabel.AutoSize = True
        DESC_EQUIPAMENTOLabel.Location = New System.Drawing.Point(10, 47)
        DESC_EQUIPAMENTOLabel.Name = "DESC_EQUIPAMENTOLabel"
        DESC_EQUIPAMENTOLabel.Size = New System.Drawing.Size(55, 13)
        DESC_EQUIPAMENTOLabel.TabIndex = 41
        DESC_EQUIPAMENTOLabel.Text = "Descrição"
        '
        'SERIELabel
        '
        SERIELabel.AutoSize = True
        SERIELabel.Location = New System.Drawing.Point(10, 70)
        SERIELabel.Name = "SERIELabel"
        SERIELabel.Size = New System.Drawing.Size(72, 13)
        SERIELabel.TabIndex = 43
        SERIELabel.Text = "# Série Única"
        '
        'MODELOLabel
        '
        MODELOLabel.AutoSize = True
        MODELOLabel.Location = New System.Drawing.Point(270, 70)
        MODELOLabel.Name = "MODELOLabel"
        MODELOLabel.Size = New System.Drawing.Size(42, 13)
        MODELOLabel.TabIndex = 45
        MODELOLabel.Text = "Modelo"
        '
        'PROTOCOLOLabel
        '
        PROTOCOLOLabel.AutoSize = True
        PROTOCOLOLabel.Location = New System.Drawing.Point(10, 99)
        PROTOCOLOLabel.Name = "PROTOCOLOLabel"
        PROTOCOLOLabel.Size = New System.Drawing.Size(52, 13)
        PROTOCOLOLabel.TabIndex = 47
        PROTOCOLOLabel.Text = "Protocolo"
        '
        'VALORLabel
        '
        VALORLabel.AutoSize = True
        VALORLabel.Location = New System.Drawing.Point(298, 99)
        VALORLabel.Name = "VALORLabel"
        VALORLabel.Size = New System.Drawing.Size(48, 13)
        VALORLabel.TabIndex = 49
        VALORLabel.Text = "Valor R$"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(10, 236)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 51
        OBSLabel.Text = "OBS:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(554, 373)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.txtPrecoVenda)
        Me.TabPage1.Controls.Add(Me.PesqFKTipo)
        Me.TabPage1.Controls.Add(Me.PesqFKFornecedor)
        Me.TabPage1.Controls.Add(Me.txtId_Controle)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Label5)
        Me.TabPage1.Controls.Add(Label4)
        Me.TabPage1.Controls.Add(Me.txtPrazo_Garantia)
        Me.TabPage1.Controls.Add(Label3)
        Me.TabPage1.Controls.Add(Me.txtNf_Entrada)
        Me.TabPage1.Controls.Add(Me.txtData_Nf)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(DESC_EQUIPAMENTOLabel)
        Me.TabPage1.Controls.Add(Me.txtDescricao)
        Me.TabPage1.Controls.Add(SERIELabel)
        Me.TabPage1.Controls.Add(Me.txtSerie)
        Me.TabPage1.Controls.Add(MODELOLabel)
        Me.TabPage1.Controls.Add(Me.txtModelo)
        Me.TabPage1.Controls.Add(PROTOCOLOLabel)
        Me.TabPage1.Controls.Add(Me.txtProtocolo)
        Me.TabPage1.Controls.Add(VALORLabel)
        Me.TabPage1.Controls.Add(Me.txtValor)
        Me.TabPage1.Controls.Add(OBSLabel)
        Me.TabPage1.Controls.Add(Me.txtObs)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.lblCodigo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(546, 347)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PesqFKTipo
        '
        Me.PesqFKTipo.CampoDesc = Nothing
        Me.PesqFKTipo.CampoId = Nothing
        Me.PesqFKTipo.Clicou = "0"
        Me.PesqFKTipo.CodigoSelecionado = Nothing
        Me.PesqFKTipo.ColunasFiltro = Nothing
        Me.PesqFKTipo.DescricaoSelecionada = Nothing
        Me.PesqFKTipo.FiltroSQL = Nothing
        Me.PesqFKTipo.LabelBuscaDesc = Nothing
        Me.PesqFKTipo.LabelBuscaId = Nothing
        Me.PesqFKTipo.LabelPesqFK = Nothing
        Me.PesqFKTipo.ListaCampos = Nothing
        Me.PesqFKTipo.Location = New System.Drawing.Point(10, 150)
        Me.PesqFKTipo.Name = "PesqFKTipo"
        Me.PesqFKTipo.ObjModelFk = Nothing
        Me.PesqFKTipo.PosValida = False
        Me.PesqFKTipo.Size = New System.Drawing.Size(529, 25)
        Me.PesqFKTipo.Tabela = Nothing
        Me.PesqFKTipo.TabIndex = 71
        Me.PesqFKTipo.TituloTela = Nothing
        Me.PesqFKTipo.View = Nothing
        '
        'PesqFKFornecedor
        '
        Me.PesqFKFornecedor.CampoDesc = Nothing
        Me.PesqFKFornecedor.CampoId = Nothing
        Me.PesqFKFornecedor.Clicou = "0"
        Me.PesqFKFornecedor.CodigoSelecionado = Nothing
        Me.PesqFKFornecedor.ColunasFiltro = Nothing
        Me.PesqFKFornecedor.DescricaoSelecionada = Nothing
        Me.PesqFKFornecedor.FiltroSQL = Nothing
        Me.PesqFKFornecedor.LabelBuscaDesc = Nothing
        Me.PesqFKFornecedor.LabelBuscaId = Nothing
        Me.PesqFKFornecedor.LabelPesqFK = Nothing
        Me.PesqFKFornecedor.ListaCampos = Nothing
        Me.PesqFKFornecedor.Location = New System.Drawing.Point(10, 123)
        Me.PesqFKFornecedor.Name = "PesqFKFornecedor"
        Me.PesqFKFornecedor.ObjModelFk = Nothing
        Me.PesqFKFornecedor.PosValida = False
        Me.PesqFKFornecedor.Size = New System.Drawing.Size(529, 25)
        Me.PesqFKFornecedor.Tabela = Nothing
        Me.PesqFKFornecedor.TabIndex = 70
        Me.PesqFKFornecedor.TituloTela = Nothing
        Me.PesqFKFornecedor.View = Nothing
        '
        'txtId_Controle
        '
        Me.txtId_Controle.Enabled = False
        Me.txtId_Controle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtId_Controle.Location = New System.Drawing.Point(458, 18)
        Me.txtId_Controle.Name = "txtId_Controle"
        Me.txtId_Controle.ReadOnly = True
        Me.txtId_Controle.Size = New System.Drawing.Size(74, 20)
        Me.txtId_Controle.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Código de Controle"
        '
        'txtPrazo_Garantia
        '
        Me.txtPrazo_Garantia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrazo_Garantia.Location = New System.Drawing.Point(92, 205)
        Me.txtPrazo_Garantia.Name = "txtPrazo_Garantia"
        Me.txtPrazo_Garantia.Size = New System.Drawing.Size(64, 20)
        Me.txtPrazo_Garantia.TabIndex = 66
        Me.txtPrazo_Garantia.Tag = "Prazo Garantia"
        '
        'txtNf_Entrada
        '
        Me.txtNf_Entrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNf_Entrada.Location = New System.Drawing.Point(92, 179)
        Me.txtNf_Entrada.Name = "txtNf_Entrada"
        Me.txtNf_Entrada.Size = New System.Drawing.Size(105, 20)
        Me.txtNf_Entrada.TabIndex = 64
        Me.txtNf_Entrada.Tag = "NF ENTRADA"
        '
        'txtData_Nf
        '
        Me.txtData_Nf.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtData_Nf.Location = New System.Drawing.Point(435, 179)
        Me.txtData_Nf.Name = "txtData_Nf"
        Me.txtData_Nf.Size = New System.Drawing.Size(97, 20)
        Me.txtData_Nf.TabIndex = 62
        Me.txtData_Nf.Tag = "Data Aquisição"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Data Aquisição"
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(92, 44)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(440, 20)
        Me.txtDescricao.TabIndex = 42
        Me.txtDescricao.Tag = "Descrição do Equipamento"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(92, 70)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(159, 20)
        Me.txtSerie.TabIndex = 44
        Me.txtSerie.Tag = "Série"
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Location = New System.Drawing.Point(332, 70)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(200, 20)
        Me.txtModelo.TabIndex = 46
        Me.txtModelo.Tag = "Modelo"
        '
        'txtProtocolo
        '
        Me.txtProtocolo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProtocolo.Location = New System.Drawing.Point(92, 96)
        Me.txtProtocolo.Name = "txtProtocolo"
        Me.txtProtocolo.Size = New System.Drawing.Size(200, 20)
        Me.txtProtocolo.TabIndex = 48
        Me.txtProtocolo.Tag = ""
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(350, 96)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(182, 20)
        Me.txtValor.TabIndex = 50
        Me.txtValor.Tag = "Valor"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(92, 233)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(440, 96)
        Me.txtObs.TabIndex = 52
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(92, 18)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 40
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(10, 21)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 39
        Me.lblCodigo.Text = "Código"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvDados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(546, 347)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Séries Anteriores"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(8, 9)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(530, 322)
        Me.dgvDados.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkGarantiaVigente)
        Me.TabPage3.Controls.Add(Me.txtDataTerminoGarantia)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.txtDataInicioGarantia)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.txtUltimaOS)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(546, 347)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Controle Garantia"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkGarantiaVigente
        '
        Me.chkGarantiaVigente.AutoSize = True
        Me.chkGarantiaVigente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkGarantiaVigente.Enabled = False
        Me.chkGarantiaVigente.Location = New System.Drawing.Point(43, 142)
        Me.chkGarantiaVigente.Name = "chkGarantiaVigente"
        Me.chkGarantiaVigente.Size = New System.Drawing.Size(127, 17)
        Me.chkGarantiaVigente.TabIndex = 6
        Me.chkGarantiaVigente.Text = "Garantia em Vigência"
        Me.chkGarantiaVigente.UseVisualStyleBackColor = True
        '
        'txtDataTerminoGarantia
        '
        Me.txtDataTerminoGarantia.Enabled = False
        Me.txtDataTerminoGarantia.Location = New System.Drawing.Point(116, 104)
        Me.txtDataTerminoGarantia.Name = "txtDataTerminoGarantia"
        Me.txtDataTerminoGarantia.ReadOnly = True
        Me.txtDataTerminoGarantia.Size = New System.Drawing.Size(113, 20)
        Me.txtDataTerminoGarantia.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Final vigência:"
        '
        'txtDataInicioGarantia
        '
        Me.txtDataInicioGarantia.Enabled = False
        Me.txtDataInicioGarantia.Location = New System.Drawing.Point(116, 66)
        Me.txtDataInicioGarantia.Name = "txtDataInicioGarantia"
        Me.txtDataInicioGarantia.ReadOnly = True
        Me.txtDataInicioGarantia.Size = New System.Drawing.Size(113, 20)
        Me.txtDataInicioGarantia.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Início vigência:"
        '
        'txtUltimaOS
        '
        Me.txtUltimaOS.Enabled = False
        Me.txtUltimaOS.Location = New System.Drawing.Point(116, 28)
        Me.txtUltimaOS.Name = "txtUltimaOS"
        Me.txtUltimaOS.ReadOnly = True
        Me.txtUltimaOS.Size = New System.Drawing.Size(74, 20)
        Me.txtUltimaOS.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Última OS"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(361, 209)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(69, 13)
        Label1.TabIndex = 72
        Label1.Text = "Preço Venda"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecoVenda.Location = New System.Drawing.Point(435, 205)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(97, 20)
        Me.txtPrecoVenda.TabIndex = 73
        Me.txtPrecoVenda.Tag = ""
        '
        'Equipamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 418)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Equipamento"
        Me.Text = "Cadastro de Equipamentos"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtId_Controle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrazo_Garantia As System.Windows.Forms.TextBox
    Friend WithEvents txtNf_Entrada As System.Windows.Forms.TextBox
    Friend WithEvents txtData_Nf As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtProtocolo As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents chkGarantiaVigente As System.Windows.Forms.CheckBox
    Friend WithEvents txtDataTerminoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDataInicioGarantia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUltimaOS As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PesqFKTipo As WinCG.PesqFK
    Friend WithEvents PesqFKFornecedor As WinCG.PesqFK
    Friend WithEvents txtPrecoVenda As TextBox
End Class
