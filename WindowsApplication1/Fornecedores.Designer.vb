<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornecedores
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtSigla = New System.Windows.Forms.TextBox()
        Me.chkUtilizaNFTS = New System.Windows.Forms.CheckBox()
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
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtGarantiaNovo = New System.Windows.Forms.TextBox()
        Me.txtGarantiaAssistencia = New System.Windows.Forms.TextBox()
        Me.PesqFK1 = New WinCG.PesqFK()
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
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ID_FORNECEDORLabel
        '
        ID_FORNECEDORLabel.AutoSize = True
        ID_FORNECEDORLabel.Location = New System.Drawing.Point(11, 18)
        ID_FORNECEDORLabel.Name = "ID_FORNECEDORLabel"
        ID_FORNECEDORLabel.Size = New System.Drawing.Size(40, 13)
        ID_FORNECEDORLabel.TabIndex = 0
        ID_FORNECEDORLabel.Text = "Código"
        '
        'SIGLALabel
        '
        SIGLALabel.AutoSize = True
        SIGLALabel.Location = New System.Drawing.Point(208, 18)
        SIGLALabel.Name = "SIGLALabel"
        SIGLALabel.Size = New System.Drawing.Size(30, 13)
        SIGLALabel.TabIndex = 2
        SIGLALabel.Text = "Sigla"
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(11, 47)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(35, 13)
        NOMELabel.TabIndex = 5
        NOMELabel.Text = "Nome"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(11, 73)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(28, 13)
        CEPLabel.TabIndex = 7
        CEPLabel.Text = "CEP"
        '
        'ENDERECOLabel
        '
        ENDERECOLabel.AutoSize = True
        ENDERECOLabel.Location = New System.Drawing.Point(11, 99)
        ENDERECOLabel.Name = "ENDERECOLabel"
        ENDERECOLabel.Size = New System.Drawing.Size(53, 13)
        ENDERECOLabel.TabIndex = 9
        ENDERECOLabel.Text = "Endereço"
        '
        'COMPLEMENTOLabel
        '
        COMPLEMENTOLabel.AutoSize = True
        COMPLEMENTOLabel.Location = New System.Drawing.Point(11, 125)
        COMPLEMENTOLabel.Name = "COMPLEMENTOLabel"
        COMPLEMENTOLabel.Size = New System.Drawing.Size(71, 13)
        COMPLEMENTOLabel.TabIndex = 11
        COMPLEMENTOLabel.Text = "Complemento"
        '
        'CIDADELabel
        '
        CIDADELabel.AutoSize = True
        CIDADELabel.Location = New System.Drawing.Point(11, 152)
        CIDADELabel.Name = "CIDADELabel"
        CIDADELabel.Size = New System.Drawing.Size(40, 13)
        CIDADELabel.TabIndex = 15
        CIDADELabel.Text = "Cidade"
        '
        'BAIRROLabel
        '
        BAIRROLabel.AutoSize = True
        BAIRROLabel.Location = New System.Drawing.Point(245, 125)
        BAIRROLabel.Name = "BAIRROLabel"
        BAIRROLabel.Size = New System.Drawing.Size(34, 13)
        BAIRROLabel.TabIndex = 13
        BAIRROLabel.Text = "Bairro"
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Location = New System.Drawing.Point(492, 151)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(21, 13)
        UFLabel.TabIndex = 17
        UFLabel.Text = "UF"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(11, 177)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(35, 13)
        EMAILLabel.TabIndex = 19
        EMAILLabel.Text = "E-mail"
        '
        'TELEFONELabel
        '
        TELEFONELabel.AutoSize = True
        TELEFONELabel.Location = New System.Drawing.Point(11, 203)
        TELEFONELabel.Name = "TELEFONELabel"
        TELEFONELabel.Size = New System.Drawing.Size(49, 13)
        TELEFONELabel.TabIndex = 21
        TELEFONELabel.Text = "Telefone"
        '
        'CONTATOLabel
        '
        CONTATOLabel.AutoSize = True
        CONTATOLabel.Location = New System.Drawing.Point(298, 202)
        CONTATOLabel.Name = "CONTATOLabel"
        CONTATOLabel.Size = New System.Drawing.Size(44, 13)
        CONTATOLabel.TabIndex = 23
        CONTATOLabel.Text = "Contato"
        '
        'WHATSAPPLabel
        '
        WHATSAPPLabel.AutoSize = True
        WHATSAPPLabel.Location = New System.Drawing.Point(11, 229)
        WHATSAPPLabel.Name = "WHATSAPPLabel"
        WHATSAPPLabel.Size = New System.Drawing.Size(56, 13)
        WHATSAPPLabel.TabIndex = 25
        WHATSAPPLabel.Text = "Whatsapp"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(11, 329)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 37
        OBSLabel.Text = "OBS:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(11, 282)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 13)
        Label1.TabIndex = 31
        Label1.Text = "Garantia Novo"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(283, 282)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(103, 13)
        Label2.TabIndex = 34
        Label2.Text = "Garantia Assistência"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(163, 282)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(32, 13)
        Label3.TabIndex = 33
        Label3.Text = "(dias)"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(463, 282)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(32, 13)
        Label4.TabIndex = 36
        Label4.Text = "(dias)"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(92, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(92, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtSigla
        '
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSigla.Location = New System.Drawing.Point(256, 14)
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(155, 20)
        Me.txtSigla.TabIndex = 3
        '
        'chkUtilizaNFTS
        '
        Me.chkUtilizaNFTS.Location = New System.Drawing.Point(424, 12)
        Me.chkUtilizaNFTS.Name = "chkUtilizaNFTS"
        Me.chkUtilizaNFTS.Size = New System.Drawing.Size(140, 24)
        Me.chkUtilizaNFTS.TabIndex = 4
        Me.chkUtilizaNFTS.Text = "Utiliza NFTS?"
        Me.chkUtilizaNFTS.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(92, 44)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(467, 20)
        Me.txtNome.TabIndex = 6
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(92, 70)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(129, 20)
        Me.txtCep.TabIndex = 8
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(92, 96)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(467, 20)
        Me.txtEndereco.TabIndex = 10
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(92, 122)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(146, 20)
        Me.txtComplemento.TabIndex = 12
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(91, 148)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(373, 20)
        Me.txtCidade.TabIndex = 16
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(285, 122)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(274, 20)
        Me.txtBairro.TabIndex = 14
        '
        'txtUf
        '
        Me.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUf.Location = New System.Drawing.Point(519, 148)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(39, 20)
        Me.txtUf.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(92, 174)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(467, 20)
        Me.txtEmail.TabIndex = 20
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(92, 200)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(200, 20)
        Me.txtTelefone.TabIndex = 22
        '
        'txtContato
        '
        Me.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContato.Location = New System.Drawing.Point(359, 199)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(200, 20)
        Me.txtContato.TabIndex = 24
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(92, 226)
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(200, 20)
        Me.txtWhatsapp.TabIndex = 26
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(92, 304)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(467, 58)
        Me.txtObs.TabIndex = 38
        '
        'txtGarantiaNovo
        '
        Me.txtGarantiaNovo.Location = New System.Drawing.Point(91, 278)
        Me.txtGarantiaNovo.Name = "txtGarantiaNovo"
        Me.txtGarantiaNovo.Size = New System.Drawing.Size(64, 20)
        Me.txtGarantiaNovo.TabIndex = 32
        '
        'txtGarantiaAssistencia
        '
        Me.txtGarantiaAssistencia.Location = New System.Drawing.Point(393, 278)
        Me.txtGarantiaAssistencia.Name = "txtGarantiaAssistencia"
        Me.txtGarantiaAssistencia.Size = New System.Drawing.Size(64, 20)
        Me.txtGarantiaAssistencia.TabIndex = 35
        '
        'PesqFK1
        '
        Me.PesqFK1.CampoDesc = Nothing
        Me.PesqFK1.CampoId = Nothing
        Me.PesqFK1.Clicou = "0"
        Me.PesqFK1.ColunasFiltro = Nothing
        Me.PesqFK1.LabelBuscaDesc = Nothing
        Me.PesqFK1.LabelBuscaId = Nothing
        Me.PesqFK1.LabelPesqFK = Nothing
        Me.PesqFK1.ListaCampos = Nothing
        Me.PesqFK1.Location = New System.Drawing.Point(12, 251)
        Me.PesqFK1.Name = "PesqFK1"
        Me.PesqFK1.ObjModelFk = Nothing
        Me.PesqFK1.PosValida = False
        Me.PesqFK1.Size = New System.Drawing.Size(445, 25)
        Me.PesqFK1.Tabela = Nothing
        Me.PesqFK1.TabIndex = 39
        Me.PesqFK1.TituloTela = Nothing
        Me.PesqFK1.View = Nothing
        '
        'Fornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 415)
        Me.Controls.Add(Me.PesqFK1)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtGarantiaAssistencia)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtGarantiaNovo)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(ID_FORNECEDORLabel)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(SIGLALabel)
        Me.Controls.Add(Me.txtSigla)
        Me.Controls.Add(Me.chkUtilizaNFTS)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(CEPLabel)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(ENDERECOLabel)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(COMPLEMENTOLabel)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(CIDADELabel)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(BAIRROLabel)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(UFLabel)
        Me.Controls.Add(Me.txtUf)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(TELEFONELabel)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(CONTATOLabel)
        Me.Controls.Add(Me.txtContato)
        Me.Controls.Add(WHATSAPPLabel)
        Me.Controls.Add(Me.txtWhatsapp)
        Me.Controls.Add(OBSLabel)
        Me.Name = "Fornecedores"
        Me.Text = "Cadastro de Fornecedores"
        Me.Controls.SetChildIndex(OBSLabel, 0)
        Me.Controls.SetChildIndex(Me.txtWhatsapp, 0)
        Me.Controls.SetChildIndex(WHATSAPPLabel, 0)
        Me.Controls.SetChildIndex(Me.txtContato, 0)
        Me.Controls.SetChildIndex(CONTATOLabel, 0)
        Me.Controls.SetChildIndex(Me.txtTelefone, 0)
        Me.Controls.SetChildIndex(TELEFONELabel, 0)
        Me.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.Controls.SetChildIndex(EMAILLabel, 0)
        Me.Controls.SetChildIndex(Me.txtUf, 0)
        Me.Controls.SetChildIndex(UFLabel, 0)
        Me.Controls.SetChildIndex(Me.txtBairro, 0)
        Me.Controls.SetChildIndex(BAIRROLabel, 0)
        Me.Controls.SetChildIndex(Me.txtCidade, 0)
        Me.Controls.SetChildIndex(CIDADELabel, 0)
        Me.Controls.SetChildIndex(Me.txtComplemento, 0)
        Me.Controls.SetChildIndex(COMPLEMENTOLabel, 0)
        Me.Controls.SetChildIndex(Me.txtEndereco, 0)
        Me.Controls.SetChildIndex(ENDERECOLabel, 0)
        Me.Controls.SetChildIndex(Me.txtCep, 0)
        Me.Controls.SetChildIndex(CEPLabel, 0)
        Me.Controls.SetChildIndex(Me.txtNome, 0)
        Me.Controls.SetChildIndex(NOMELabel, 0)
        Me.Controls.SetChildIndex(Me.chkUtilizaNFTS, 0)
        Me.Controls.SetChildIndex(Me.txtSigla, 0)
        Me.Controls.SetChildIndex(SIGLALabel, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(ID_FORNECEDORLabel, 0)
        Me.Controls.SetChildIndex(Me.txtObs, 0)
        Me.Controls.SetChildIndex(Me.txtGarantiaNovo, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.Controls.SetChildIndex(Me.txtGarantiaAssistencia, 0)
        Me.Controls.SetChildIndex(Label2, 0)
        Me.Controls.SetChildIndex(Label3, 0)
        Me.Controls.SetChildIndex(Label4, 0)
        Me.Controls.SetChildIndex(Me.PesqFK1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtSigla As System.Windows.Forms.TextBox
    Friend WithEvents chkUtilizaNFTS As System.Windows.Forms.CheckBox
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
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtGarantiaNovo As System.Windows.Forms.TextBox
    Friend WithEvents txtGarantiaAssistencia As System.Windows.Forms.TextBox
    Friend WithEvents PesqFK1 As WinCG.PesqFK
End Class
