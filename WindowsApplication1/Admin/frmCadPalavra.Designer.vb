<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadPalavra
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
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.opt3 = New System.Windows.Forms.RadioButton()
        Me.opt4 = New System.Windows.Forms.RadioButton()
        Me.opt5 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResposta = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dicas para Palavra Chave:"
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(28, 43)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(206, 17)
        Me.opt1.TabIndex = 1
        Me.opt1.TabStop = True
        Me.opt1.Text = "Qual é o nome de sua banda favorita?"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(27, 66)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(234, 17)
        Me.opt2.TabIndex = 2
        Me.opt2.TabStop = True
        Me.opt2.Text = "Qual é o nome de seu animal de estimação?"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt3
        '
        Me.opt3.AutoSize = True
        Me.opt3.Location = New System.Drawing.Point(28, 89)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(168, 17)
        Me.opt3.TabIndex = 3
        Me.opt3.TabStop = True
        Me.opt3.Text = "Qual é o time que você torce?"
        Me.opt3.UseVisualStyleBackColor = True
        '
        'opt4
        '
        Me.opt4.AutoSize = True
        Me.opt4.Location = New System.Drawing.Point(28, 112)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(153, 17)
        Me.opt4.TabIndex = 4
        Me.opt4.TabStop = True
        Me.opt4.Text = "Qual é a sua cor preferida?"
        Me.opt4.UseVisualStyleBackColor = True
        '
        'opt5
        '
        Me.opt5.AutoSize = True
        Me.opt5.Location = New System.Drawing.Point(28, 135)
        Me.opt5.Name = "opt5"
        Me.opt5.Size = New System.Drawing.Size(171, 17)
        Me.opt5.TabIndex = 5
        Me.opt5.TabStop = True
        Me.opt5.Text = "Qual é a sua comida predileta?"
        Me.opt5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Resposta:"
        '
        'txtResposta
        '
        Me.txtResposta.Location = New System.Drawing.Point(28, 184)
        Me.txtResposta.Name = "txtResposta"
        Me.txtResposta.Size = New System.Drawing.Size(387, 20)
        Me.txtResposta.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Image = Global.WinCG.My.Resources.Resources.ok16
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(339, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Confirmar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCadPalavra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 256)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtResposta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.opt5)
        Me.Controls.Add(Me.opt4)
        Me.Controls.Add(Me.opt3)
        Me.Controls.Add(Me.opt2)
        Me.Controls.Add(Me.opt1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCadPalavra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Palavra Chave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt3 As System.Windows.Forms.RadioButton
    Friend WithEvents opt4 As System.Windows.Forms.RadioButton
    Friend WithEvents opt5 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtResposta As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
