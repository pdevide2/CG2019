<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailSenha
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtEmailDestino = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPalavra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.chkExibir = New System.Windows.Forms.CheckBox()
        Me.btnDica = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login CG"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(18, 27)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(144, 20)
        Me.txtLogin.TabIndex = 1
        '
        'txtEmailDestino
        '
        Me.txtEmailDestino.Location = New System.Drawing.Point(21, 78)
        Me.txtEmailDestino.Name = "txtEmailDestino"
        Me.txtEmailDestino.Size = New System.Drawing.Size(392, 20)
        Me.txtEmailDestino.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enviar para o e-mail:"
        '
        'txtPalavra
        '
        Me.txtPalavra.Location = New System.Drawing.Point(21, 151)
        Me.txtPalavra.Name = "txtPalavra"
        Me.txtPalavra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPalavra.Size = New System.Drawing.Size(392, 20)
        Me.txtPalavra.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Palavra Chave"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(338, 232)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 8
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'chkExibir
        '
        Me.chkExibir.AutoSize = True
        Me.chkExibir.Location = New System.Drawing.Point(23, 179)
        Me.chkExibir.Name = "chkExibir"
        Me.chkExibir.Size = New System.Drawing.Size(104, 17)
        Me.chkExibir.TabIndex = 9
        Me.chkExibir.Text = "Exibir caracteres"
        Me.chkExibir.UseVisualStyleBackColor = True
        '
        'btnDica
        '
        Me.btnDica.Location = New System.Drawing.Point(257, 232)
        Me.btnDica.Name = "btnDica"
        Me.btnDica.Size = New System.Drawing.Size(75, 23)
        Me.btnDica.TabIndex = 10
        Me.btnDica.Text = "Dica"
        Me.btnDica.UseVisualStyleBackColor = True
        '
        'EmailSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 263)
        Me.Controls.Add(Me.btnDica)
        Me.Controls.Add(Me.chkExibir)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtPalavra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmailDestino)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmailSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lembrete de Senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPalavra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents chkExibir As System.Windows.Forms.CheckBox
    Friend WithEvents btnDica As System.Windows.Forms.Button
End Class
