<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Responsavel
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
        Dim NOMELabel As System.Windows.Forms.Label
        Dim APELIDOLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim CELULARLabel As System.Windows.Forms.Label
        Dim WHATSAPPLabel As System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtApelido = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtWhatsapp = New System.Windows.Forms.TextBox()
        Me.PesqFK1 = New WinCG.PesqFK()
        NOMELabel = New System.Windows.Forms.Label()
        APELIDOLabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        CELULARLabel = New System.Windows.Forms.Label()
        WHATSAPPLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(11, 41)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(35, 13)
        NOMELabel.TabIndex = 4
        NOMELabel.Text = "Nome"
        '
        'APELIDOLabel
        '
        APELIDOLabel.AutoSize = True
        APELIDOLabel.Location = New System.Drawing.Point(183, 13)
        APELIDOLabel.Name = "APELIDOLabel"
        APELIDOLabel.Size = New System.Drawing.Size(42, 13)
        APELIDOLabel.TabIndex = 2
        APELIDOLabel.Text = "Apelido"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(11, 69)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(35, 13)
        EMAILLabel.TabIndex = 6
        EMAILLabel.Text = "E-mail"
        '
        'CELULARLabel
        '
        CELULARLabel.AutoSize = True
        CELULARLabel.Location = New System.Drawing.Point(11, 97)
        CELULARLabel.Name = "CELULARLabel"
        CELULARLabel.Size = New System.Drawing.Size(39, 13)
        CELULARLabel.TabIndex = 8
        CELULARLabel.Text = "Celular"
        '
        'WHATSAPPLabel
        '
        WHATSAPPLabel.AutoSize = True
        WHATSAPPLabel.Location = New System.Drawing.Point(248, 97)
        WHATSAPPLabel.Name = "WHATSAPPLabel"
        WHATSAPPLabel.Size = New System.Drawing.Size(56, 13)
        WHATSAPPLabel.TabIndex = 10
        WHATSAPPLabel.Text = "Whatsapp"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(11, 13)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(61, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(61, 37)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(453, 20)
        Me.txtNome.TabIndex = 5
        Me.txtNome.Tag = "Nome"
        '
        'txtApelido
        '
        Me.txtApelido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApelido.Location = New System.Drawing.Point(230, 9)
        Me.txtApelido.Name = "txtApelido"
        Me.txtApelido.Size = New System.Drawing.Size(284, 20)
        Me.txtApelido.TabIndex = 3
        Me.txtApelido.Tag = "Apelido"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(61, 65)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(453, 20)
        Me.txtEmail.TabIndex = 7
        Me.txtEmail.Tag = ""
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(61, 93)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(163, 20)
        Me.txtCelular.TabIndex = 9
        Me.txtCelular.Tag = "Celular"
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(314, 93)
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(200, 20)
        Me.txtWhatsapp.TabIndex = 11
        Me.txtWhatsapp.Tag = "Whatsapp"
        '
        'PesqFK1
        '
        Me.PesqFK1.CampoDesc = Nothing
        Me.PesqFK1.CampoId = Nothing
        Me.PesqFK1.ColunasFiltro = Nothing
        Me.PesqFK1.LabelBuscaDesc = Nothing
        Me.PesqFK1.LabelBuscaId = Nothing
        Me.PesqFK1.LabelPesqFK = "Cargo"
        Me.PesqFK1.ListaCampos = Nothing
        Me.PesqFK1.Location = New System.Drawing.Point(15, 121)
        Me.PesqFK1.Name = "PesqFK1"
        Me.PesqFK1.ObjModelFk = Nothing
        Me.PesqFK1.PosValida = False
        Me.PesqFK1.Size = New System.Drawing.Size(400, 25)
        Me.PesqFK1.Tabela = Nothing
        Me.PesqFK1.TabIndex = 16
        Me.PesqFK1.TituloTela = Nothing
        Me.PesqFK1.View = Nothing
        '
        'Responsavel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 206)
        Me.Controls.Add(Me.PesqFK1)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(APELIDOLabel)
        Me.Controls.Add(Me.txtApelido)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(CELULARLabel)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(WHATSAPPLabel)
        Me.Controls.Add(Me.txtWhatsapp)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Responsavel"
        Me.Text = "Cadastro de Responsáveis"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtWhatsapp, 0)
        Me.Controls.SetChildIndex(WHATSAPPLabel, 0)
        Me.Controls.SetChildIndex(Me.txtCelular, 0)
        Me.Controls.SetChildIndex(CELULARLabel, 0)
        Me.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.Controls.SetChildIndex(EMAILLabel, 0)
        Me.Controls.SetChildIndex(Me.txtApelido, 0)
        Me.Controls.SetChildIndex(APELIDOLabel, 0)
        Me.Controls.SetChildIndex(Me.txtNome, 0)
        Me.Controls.SetChildIndex(NOMELabel, 0)
        Me.Controls.SetChildIndex(Me.PesqFK1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtApelido As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtWhatsapp As System.Windows.Forms.TextBox
    Friend WithEvents PesqFK1 As WinCG.PesqFK
End Class
