<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.lbDados = New System.Windows.Forms.ListBox()
        Me.btnCarregar = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(24, 84)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(374, 224)
        Me.dgvDados.TabIndex = 0
        '
        'lbDados
        '
        Me.lbDados.FormattingEnabled = True
        Me.lbDados.Location = New System.Drawing.Point(405, 84)
        Me.lbDados.Name = "lbDados"
        Me.lbDados.Size = New System.Drawing.Size(324, 225)
        Me.lbDados.TabIndex = 1
        '
        'btnCarregar
        '
        Me.btnCarregar.Location = New System.Drawing.Point(24, 315)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(135, 23)
        Me.btnCarregar.TabIndex = 2
        Me.btnCarregar.Text = "Carregar Dados"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 381)
        Me.Controls.Add(Me.btnCarregar)
        Me.Controls.Add(Me.lbDados)
        Me.Controls.Add(Me.dgvDados)
        Me.Name = "Form1"
        Me.Text = "Teste SQL Server"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents lbDados As System.Windows.Forms.ListBox
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
End Class
