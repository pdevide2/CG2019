<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesqFK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PesqFK))
        Me.btnPesq = New System.Windows.Forms.Button()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblLabelFK = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPesq
        '
        Me.btnPesq.Image = CType(resources.GetObject("btnPesq.Image"), System.Drawing.Image)
        Me.btnPesq.Location = New System.Drawing.Point(365, 1)
        Me.btnPesq.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.btnPesq.Name = "btnPesq"
        Me.btnPesq.Size = New System.Drawing.Size(33, 23)
        Me.btnPesq.TabIndex = 60
        Me.btnPesq.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(130, 2)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(233, 20)
        Me.txtDesc.TabIndex = 59
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(53, 2)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(74, 20)
        Me.txtId.TabIndex = 58
        '
        'lblLabelFK
        '
        Me.lblLabelFK.AutoSize = True
        Me.lblLabelFK.Location = New System.Drawing.Point(5, 6)
        Me.lblLabelFK.Name = "lblLabelFK"
        Me.lblLabelFK.Size = New System.Drawing.Size(34, 13)
        Me.lblLabelFK.TabIndex = 57
        Me.lblLabelFK.Text = "Texto"
        '
        'PesqFK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnPesq)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblLabelFK)
        Me.Name = "PesqFK"
        Me.Size = New System.Drawing.Size(400, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPesq As System.Windows.Forms.Button
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblLabelFK As System.Windows.Forms.Label

End Class
