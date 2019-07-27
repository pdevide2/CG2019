<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa
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
        Dim Label1 As System.Windows.Forms.Label
        Dim ID_FORNECEDORLabel As System.Windows.Forms.Label
        Dim SIGLALabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim ENDERECOLabel As System.Windows.Forms.Label
        Dim COMPLEMENTOLabel As System.Windows.Forms.Label
        Dim CIDADELabel As System.Windows.Forms.Label
        Dim BAIRROLabel As System.Windows.Forms.Label
        Dim UFLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim TELEFONELabel As System.Windows.Forms.Label
        Dim CONTATOLabel As System.Windows.Forms.Label
        Dim WHATSAPPLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtSigla = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtContato = New System.Windows.Forms.TextBox()
        Me.txtWhatsapp = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Label1 = New System.Windows.Forms.Label()
        ID_FORNECEDORLabel = New System.Windows.Forms.Label()
        SIGLALabel = New System.Windows.Forms.Label()
        NOMELabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        ENDERECOLabel = New System.Windows.Forms.Label()
        COMPLEMENTOLabel = New System.Windows.Forms.Label()
        CIDADELabel = New System.Windows.Forms.Label()
        BAIRROLabel = New System.Windows.Forms.Label()
        UFLabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        TELEFONELabel = New System.Windows.Forms.Label()
        CONTATOLabel = New System.Windows.Forms.Label()
        WHATSAPPLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(9, 172)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 13)
        Label1.TabIndex = 69
        Label1.Text = "Referência"
        '
        'ID_FORNECEDORLabel
        '
        ID_FORNECEDORLabel.AutoSize = True
        ID_FORNECEDORLabel.Location = New System.Drawing.Point(9, 11)
        ID_FORNECEDORLabel.Name = "ID_FORNECEDORLabel"
        ID_FORNECEDORLabel.Size = New System.Drawing.Size(40, 13)
        ID_FORNECEDORLabel.TabIndex = 41
        ID_FORNECEDORLabel.Text = "Código"
        '
        'SIGLALabel
        '
        SIGLALabel.AutoSize = True
        SIGLALabel.Location = New System.Drawing.Point(400, 12)
        SIGLALabel.Name = "SIGLALabel"
        SIGLALabel.Size = New System.Drawing.Size(30, 13)
        SIGLALabel.TabIndex = 43
        SIGLALabel.Text = "Sigla"
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(9, 40)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(35, 13)
        NOMELabel.TabIndex = 45
        NOMELabel.Text = "Nome"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(9, 66)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(28, 13)
        CEPLabel.TabIndex = 47
        CEPLabel.Text = "CEP"
        '
        'ENDERECOLabel
        '
        ENDERECOLabel.AutoSize = True
        ENDERECOLabel.Location = New System.Drawing.Point(9, 92)
        ENDERECOLabel.Name = "ENDERECOLabel"
        ENDERECOLabel.Size = New System.Drawing.Size(53, 13)
        ENDERECOLabel.TabIndex = 49
        ENDERECOLabel.Text = "Endereço"
        '
        'COMPLEMENTOLabel
        '
        COMPLEMENTOLabel.AutoSize = True
        COMPLEMENTOLabel.Location = New System.Drawing.Point(9, 118)
        COMPLEMENTOLabel.Name = "COMPLEMENTOLabel"
        COMPLEMENTOLabel.Size = New System.Drawing.Size(71, 13)
        COMPLEMENTOLabel.TabIndex = 51
        COMPLEMENTOLabel.Text = "Complemento"
        '
        'CIDADELabel
        '
        CIDADELabel.AutoSize = True
        CIDADELabel.Location = New System.Drawing.Point(9, 145)
        CIDADELabel.Name = "CIDADELabel"
        CIDADELabel.Size = New System.Drawing.Size(40, 13)
        CIDADELabel.TabIndex = 55
        CIDADELabel.Text = "Cidade"
        '
        'BAIRROLabel
        '
        BAIRROLabel.AutoSize = True
        BAIRROLabel.Location = New System.Drawing.Point(290, 118)
        BAIRROLabel.Name = "BAIRROLabel"
        BAIRROLabel.Size = New System.Drawing.Size(34, 13)
        BAIRROLabel.TabIndex = 53
        BAIRROLabel.Text = "Bairro"
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Location = New System.Drawing.Point(537, 144)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(21, 13)
        UFLabel.TabIndex = 57
        UFLabel.Text = "UF"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(9, 224)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(35, 13)
        EMAILLabel.TabIndex = 59
        EMAILLabel.Text = "E-mail"
        '
        'TELEFONELabel
        '
        TELEFONELabel.AutoSize = True
        TELEFONELabel.Location = New System.Drawing.Point(9, 250)
        TELEFONELabel.Name = "TELEFONELabel"
        TELEFONELabel.Size = New System.Drawing.Size(49, 13)
        TELEFONELabel.TabIndex = 61
        TELEFONELabel.Text = "Telefone"
        '
        'CONTATOLabel
        '
        CONTATOLabel.AutoSize = True
        CONTATOLabel.Location = New System.Drawing.Point(342, 276)
        CONTATOLabel.Name = "CONTATOLabel"
        CONTATOLabel.Size = New System.Drawing.Size(44, 13)
        CONTATOLabel.TabIndex = 63
        CONTATOLabel.Text = "Contato"
        '
        'WHATSAPPLabel
        '
        WHATSAPPLabel.AutoSize = True
        WHATSAPPLabel.Location = New System.Drawing.Point(9, 276)
        WHATSAPPLabel.Name = "WHATSAPPLabel"
        WHATSAPPLabel.Size = New System.Drawing.Size(39, 13)
        WHATSAPPLabel.TabIndex = 65
        WHATSAPPLabel.Text = "Celular"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(9, 329)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 67
        OBSLabel.Text = "OBS:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(621, 419)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.txtReferencia)
        Me.TabPage1.Controls.Add(Me.txtObs)
        Me.TabPage1.Controls.Add(ID_FORNECEDORLabel)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(SIGLALabel)
        Me.TabPage1.Controls.Add(Me.txtSigla)
        Me.TabPage1.Controls.Add(NOMELabel)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(CEPLabel)
        Me.TabPage1.Controls.Add(Me.txtCep)
        Me.TabPage1.Controls.Add(ENDERECOLabel)
        Me.TabPage1.Controls.Add(Me.txtEndereco)
        Me.TabPage1.Controls.Add(COMPLEMENTOLabel)
        Me.TabPage1.Controls.Add(Me.txtComplemento)
        Me.TabPage1.Controls.Add(CIDADELabel)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(BAIRROLabel)
        Me.TabPage1.Controls.Add(Me.txtBairro)
        Me.TabPage1.Controls.Add(UFLabel)
        Me.TabPage1.Controls.Add(Me.txtUf)
        Me.TabPage1.Controls.Add(EMAILLabel)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(TELEFONELabel)
        Me.TabPage1.Controls.Add(Me.txtTelefone)
        Me.TabPage1.Controls.Add(CONTATOLabel)
        Me.TabPage1.Controls.Add(Me.txtContato)
        Me.TabPage1.Controls.Add(WHATSAPPLabel)
        Me.TabPage1.Controls.Add(Me.txtWhatsapp)
        Me.TabPage1.Controls.Add(OBSLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(613, 393)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Empresa"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(89, 168)
        Me.txtReferencia.Multiline = True
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(514, 47)
        Me.txtReferencia.TabIndex = 70
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(90, 304)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(513, 81)
        Me.txtObs.TabIndex = 68
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(90, 8)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(92, 20)
        Me.txtCodigo.TabIndex = 42
        '
        'txtSigla
        '
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSigla.Location = New System.Drawing.Point(448, 8)
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(155, 20)
        Me.txtSigla.TabIndex = 44
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(90, 37)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(513, 20)
        Me.txtNome.TabIndex = 46
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(90, 63)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(129, 20)
        Me.txtCep.TabIndex = 48
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(90, 89)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(513, 20)
        Me.txtEndereco.TabIndex = 50
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(90, 115)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(146, 20)
        Me.txtComplemento.TabIndex = 52
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(89, 141)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(373, 20)
        Me.txtCidade.TabIndex = 56
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(330, 115)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(274, 20)
        Me.txtBairro.TabIndex = 54
        '
        'txtUf
        '
        Me.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUf.Location = New System.Drawing.Point(564, 141)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(39, 20)
        Me.txtUf.TabIndex = 58
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(90, 221)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(513, 20)
        Me.txtEmail.TabIndex = 60
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(90, 247)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(200, 20)
        Me.txtTelefone.TabIndex = 62
        '
        'txtContato
        '
        Me.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContato.Location = New System.Drawing.Point(403, 273)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(200, 20)
        Me.txtContato.TabIndex = 64
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(90, 273)
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(200, 20)
        Me.txtWhatsapp.TabIndex = 66
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvDados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(613, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Permissões de Usuários"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(6, 6)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(599, 381)
        Me.dgvDados.TabIndex = 0
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 465)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Empresa"
        Me.Text = "Cadastro de Empresas"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtSigla As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCep As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtUf As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents txtContato As System.Windows.Forms.TextBox
    Friend WithEvents txtWhatsapp As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
End Class
