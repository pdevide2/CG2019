<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecebimentoChip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecebimentoChip))
        Me.lblDe = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtDe = New System.Windows.Forms.DateTimePicker()
        Me.lblAte = New System.Windows.Forms.Label()
        Me.txtAte = New System.Windows.Forms.DateTimePicker()
        Me.dgvDados1 = New System.Windows.Forms.DataGridView()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.lblGrid1 = New System.Windows.Forms.Label()
        Me.lblGrid2 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        CType(Me.dgvDados1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(26, 23)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(109, 13)
        Me.lblDe.TabIndex = 0
        Me.lblDe.Text = "Data Movimento (de):"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(380, 18)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'txtDe
        '
        Me.txtDe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDe.Location = New System.Drawing.Point(139, 19)
        Me.txtDe.Name = "txtDe"
        Me.txtDe.Size = New System.Drawing.Size(98, 20)
        Me.txtDe.TabIndex = 3
        '
        'lblAte
        '
        Me.lblAte.AutoSize = True
        Me.lblAte.Location = New System.Drawing.Point(243, 23)
        Me.lblAte.Name = "lblAte"
        Me.lblAte.Size = New System.Drawing.Size(25, 13)
        Me.lblAte.TabIndex = 4
        Me.lblAte.Text = "até:"
        '
        'txtAte
        '
        Me.txtAte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtAte.Location = New System.Drawing.Point(274, 19)
        Me.txtAte.Name = "txtAte"
        Me.txtAte.Size = New System.Drawing.Size(98, 20)
        Me.txtAte.TabIndex = 5
        '
        'dgvDados1
        '
        Me.dgvDados1.AllowUserToAddRows = False
        Me.dgvDados1.AllowUserToDeleteRows = False
        Me.dgvDados1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados1.Location = New System.Drawing.Point(28, 74)
        Me.dgvDados1.Name = "dgvDados1"
        Me.dgvDados1.ReadOnly = True
        Me.dgvDados1.Size = New System.Drawing.Size(752, 150)
        Me.dgvDados1.TabIndex = 6
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(28, 247)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.Size = New System.Drawing.Size(752, 197)
        Me.dgvDados2.TabIndex = 7
        '
        'lblGrid1
        '
        Me.lblGrid1.AutoSize = True
        Me.lblGrid1.Location = New System.Drawing.Point(31, 58)
        Me.lblGrid1.Name = "lblGrid1"
        Me.lblGrid1.Size = New System.Drawing.Size(60, 13)
        Me.lblGrid1.TabIndex = 8
        Me.lblGrid1.Text = "Romaneios"
        '
        'lblGrid2
        '
        Me.lblGrid2.AutoSize = True
        Me.lblGrid2.Location = New System.Drawing.Point(31, 231)
        Me.lblGrid2.Name = "lblGrid2"
        Me.lblGrid2.Size = New System.Drawing.Size(173, 13)
        Me.lblGrid2.TabIndex = 9
        Me.lblGrid2.Text = "Detalhe Romaneio (modo consulta)"
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSair.Location = New System.Drawing.Point(705, 450)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 10
        Me.btnSair.Text = "Fechar"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'RecebimentoChip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 483)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lblGrid2)
        Me.Controls.Add(Me.lblGrid1)
        Me.Controls.Add(Me.dgvDados2)
        Me.Controls.Add(Me.dgvDados1)
        Me.Controls.Add(Me.txtAte)
        Me.Controls.Add(Me.lblAte)
        Me.Controls.Add(Me.txtDe)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.lblDe)
        Me.Name = "RecebimentoChip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recebimento Chip"
        CType(Me.dgvDados1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDe As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents txtDe As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAte As System.Windows.Forms.Label
    Friend WithEvents txtAte As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvDados1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDados2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblGrid1 As System.Windows.Forms.Label
    Friend WithEvents lblGrid2 As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
