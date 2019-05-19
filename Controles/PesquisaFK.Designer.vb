<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisaFK
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PesquisaFK))
        Me.txtIdPesqFK = New System.Windows.Forms.TextBox()
        Me.txtDescPesqFK = New System.Windows.Forms.TextBox()
        Me.btnPesquisaFK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIdPesqFK
        '
        Me.txtIdPesqFK.Location = New System.Drawing.Point(0, 0)
        Me.txtIdPesqFK.Name = "txtIdPesqFK"
        Me.txtIdPesqFK.Size = New System.Drawing.Size(67, 20)
        Me.txtIdPesqFK.TabIndex = 0
        '
        'txtDescPesqFK
        '
        Me.txtDescPesqFK.Location = New System.Drawing.Point(69, 0)
        Me.txtDescPesqFK.Name = "txtDescPesqFK"
        Me.txtDescPesqFK.Size = New System.Drawing.Size(258, 20)
        Me.txtDescPesqFK.TabIndex = 1
        '
        'btnPesquisaFK
        '
        Me.btnPesquisaFK.Image = CType(resources.GetObject("btnPesquisaFK.Image"), System.Drawing.Image)
        Me.btnPesquisaFK.Location = New System.Drawing.Point(328, 0)
        Me.btnPesquisaFK.Name = "btnPesquisaFK"
        Me.btnPesquisaFK.Size = New System.Drawing.Size(24, 20)
        Me.btnPesquisaFK.TabIndex = 2
        Me.btnPesquisaFK.UseVisualStyleBackColor = True
        '
        'PesquisaFK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnPesquisaFK)
        Me.Controls.Add(Me.txtDescPesqFK)
        Me.Controls.Add(Me.txtIdPesqFK)
        Me.Name = "PesquisaFK"
        Me.Size = New System.Drawing.Size(353, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdPesqFK As System.Windows.Forms.TextBox
    Friend WithEvents txtDescPesqFK As System.Windows.Forms.TextBox
    Friend WithEvents btnPesquisaFK As System.Windows.Forms.Button

End Class
