<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblApelido = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.txtApelido = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtRg = New System.Windows.Forms.TextBox()
        Me.txtCpf = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtWhatsapp = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.lblWhatsapp = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.btnDuplicar = New System.Windows.Forms.Button()
        Me.PesqFK1 = New WinCG.PesqFK()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(21, 16)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(186, 16)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(91, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(60, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(227, 12)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(322, 20)
        Me.txtNome.TabIndex = 3
        Me.txtNome.Tag = "Nome"
        '
        'lblApelido
        '
        Me.lblApelido.AutoSize = True
        Me.lblApelido.Location = New System.Drawing.Point(21, 42)
        Me.lblApelido.Name = "lblApelido"
        Me.lblApelido.Size = New System.Drawing.Size(42, 13)
        Me.lblApelido.TabIndex = 4
        Me.lblApelido.Text = "Apelido"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(389, 42)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(33, 13)
        Me.lblLogin.TabIndex = 6
        Me.lblLogin.Text = "Login"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(21, 68)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(23, 13)
        Me.lblRg.TabIndex = 8
        Me.lblRg.Text = "RG"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(389, 68)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 10
        Me.lblCpf.Text = "CPF"
        '
        'txtApelido
        '
        Me.txtApelido.Location = New System.Drawing.Point(91, 38)
        Me.txtApelido.Name = "txtApelido"
        Me.txtApelido.Size = New System.Drawing.Size(234, 20)
        Me.txtApelido.TabIndex = 5
        Me.txtApelido.Tag = "Apelido"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(428, 38)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(121, 20)
        Me.txtLogin.TabIndex = 7
        Me.txtLogin.Tag = "Login"
        '
        'txtRg
        '
        Me.txtRg.Location = New System.Drawing.Point(91, 64)
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(130, 20)
        Me.txtRg.TabIndex = 9
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(428, 64)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(121, 20)
        Me.txtCpf.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Location = New System.Drawing.Point(91, 90)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(458, 20)
        Me.txtEmail.TabIndex = 13
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(21, 94)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "E-mail"
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(428, 116)
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(121, 20)
        Me.txtWhatsapp.TabIndex = 17
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(91, 116)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(130, 20)
        Me.txtTelefone.TabIndex = 15
        '
        'lblWhatsapp
        '
        Me.lblWhatsapp.AutoSize = True
        Me.lblWhatsapp.Location = New System.Drawing.Point(366, 120)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(56, 13)
        Me.lblWhatsapp.TabIndex = 16
        Me.lblWhatsapp.Text = "Whatsapp"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(21, 120)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefone.TabIndex = 14
        Me.lblTelefone.Text = "Telefone"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(91, 142)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(115, 20)
        Me.txtCep.TabIndex = 19
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(21, 149)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(28, 13)
        Me.lblCep.TabIndex = 18
        Me.lblCep.Text = "CEP"
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(91, 168)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(458, 20)
        Me.txtEndereco.TabIndex = 21
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(21, 175)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lblEndereco.TabIndex = 20
        Me.lblEndereco.Text = "Endereço"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(91, 194)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(130, 20)
        Me.txtComplemento.TabIndex = 23
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(21, 201)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(71, 13)
        Me.lblComplemento.TabIndex = 22
        Me.lblComplemento.Text = "Complemento"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(91, 220)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(247, 20)
        Me.txtCidade.TabIndex = 25
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(21, 227)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 24
        Me.lblCidade.Text = "Cidade"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(91, 249)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(247, 20)
        Me.txtBairro.TabIndex = 29
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(21, 252)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(34, 13)
        Me.lblBairro.TabIndex = 28
        Me.lblBairro.Text = "Bairro"
        '
        'txtUf
        '
        Me.txtUf.Location = New System.Drawing.Point(499, 216)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(50, 20)
        Me.txtUf.TabIndex = 27
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(466, 223)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(21, 13)
        Me.lblUf.TabIndex = 26
        Me.lblUf.Text = "UF"
        '
        'btnDuplicar
        '
        Me.btnDuplicar.Location = New System.Drawing.Point(392, 314)
        Me.btnDuplicar.Name = "btnDuplicar"
        Me.btnDuplicar.Size = New System.Drawing.Size(175, 23)
        Me.btnDuplicar.TabIndex = 34
        Me.btnDuplicar.Text = "Copiar Perfil deste Usuário"
        Me.btnDuplicar.UseVisualStyleBackColor = True
        '
        'PesqFK1
        '
        Me.PesqFK1.CampoDesc = Nothing
        Me.PesqFK1.CampoId = Nothing
        Me.PesqFK1.ColunasFiltro = Nothing
        Me.PesqFK1.LabelBuscaDesc = Nothing
        Me.PesqFK1.LabelBuscaId = Nothing
        Me.PesqFK1.LabelPesqFK = "Status"
        Me.PesqFK1.ListaCampos = Nothing
        Me.PesqFK1.Location = New System.Drawing.Point(24, 277)
        Me.PesqFK1.Name = "PesqFK1"
        Me.PesqFK1.ObjModelFk = Nothing
        Me.PesqFK1.PosValida = False
        Me.PesqFK1.Size = New System.Drawing.Size(413, 25)
        Me.PesqFK1.Tabela = Nothing
        Me.PesqFK1.TabIndex = 35
        Me.PesqFK1.TituloTela = Nothing
        Me.PesqFK1.View = Nothing
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 402)
        Me.Controls.Add(Me.PesqFK1)
        Me.Controls.Add(Me.btnDuplicar)
        Me.Controls.Add(Me.txtUf)
        Me.Controls.Add(Me.lblUf)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(Me.lblComplemento)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.lblCep)
        Me.Controls.Add(Me.txtWhatsapp)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.lblWhatsapp)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.txtRg)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtApelido)
        Me.Controls.Add(Me.lblCpf)
        Me.Controls.Add(Me.lblRg)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblApelido)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Usuarios"
        Me.Text = "Cadastro de Usuários"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblNome, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtNome, 0)
        Me.Controls.SetChildIndex(Me.lblApelido, 0)
        Me.Controls.SetChildIndex(Me.lblLogin, 0)
        Me.Controls.SetChildIndex(Me.lblRg, 0)
        Me.Controls.SetChildIndex(Me.lblCpf, 0)
        Me.Controls.SetChildIndex(Me.txtApelido, 0)
        Me.Controls.SetChildIndex(Me.txtLogin, 0)
        Me.Controls.SetChildIndex(Me.txtRg, 0)
        Me.Controls.SetChildIndex(Me.txtCpf, 0)
        Me.Controls.SetChildIndex(Me.lblEmail, 0)
        Me.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.Controls.SetChildIndex(Me.lblTelefone, 0)
        Me.Controls.SetChildIndex(Me.lblWhatsapp, 0)
        Me.Controls.SetChildIndex(Me.txtTelefone, 0)
        Me.Controls.SetChildIndex(Me.txtWhatsapp, 0)
        Me.Controls.SetChildIndex(Me.lblCep, 0)
        Me.Controls.SetChildIndex(Me.txtCep, 0)
        Me.Controls.SetChildIndex(Me.lblEndereco, 0)
        Me.Controls.SetChildIndex(Me.txtEndereco, 0)
        Me.Controls.SetChildIndex(Me.lblComplemento, 0)
        Me.Controls.SetChildIndex(Me.txtComplemento, 0)
        Me.Controls.SetChildIndex(Me.lblCidade, 0)
        Me.Controls.SetChildIndex(Me.txtCidade, 0)
        Me.Controls.SetChildIndex(Me.lblBairro, 0)
        Me.Controls.SetChildIndex(Me.txtBairro, 0)
        Me.Controls.SetChildIndex(Me.lblUf, 0)
        Me.Controls.SetChildIndex(Me.txtUf, 0)
        Me.Controls.SetChildIndex(Me.btnDuplicar, 0)
        Me.Controls.SetChildIndex(Me.PesqFK1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblApelido As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblRg As System.Windows.Forms.Label
    Friend WithEvents lblCpf As System.Windows.Forms.Label
    Friend WithEvents txtApelido As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtRg As System.Windows.Forms.TextBox
    Friend WithEvents txtCpf As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtWhatsapp As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents lblWhatsapp As System.Windows.Forms.Label
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents txtCep As System.Windows.Forms.TextBox
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents txtUf As System.Windows.Forms.TextBox
    Friend WithEvents lblUf As System.Windows.Forms.Label
    Friend WithEvents btnDuplicar As System.Windows.Forms.Button
    Friend WithEvents PesqFK1 As WinCG.PesqFK
End Class
