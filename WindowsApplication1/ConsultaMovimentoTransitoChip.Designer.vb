<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaMovimentoTransitoChip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaMovimentoTransitoChip))
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.txtData1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPesqTransito = New System.Windows.Forms.Button()
        Me.txtDescTransito = New System.Windows.Forms.TextBox()
        Me.txtIdTransito = New System.Windows.Forms.TextBox()
        Me.lblTransito = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtData2 = New System.Windows.Forms.TextBox()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(9, 8)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(1284, 467)
        Me.dgvDados.TabIndex = 0
        '
        'btnExcel
        '
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcel.Location = New System.Drawing.Point(10, 481)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(108, 40)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRefresh.Location = New System.Drawing.Point(124, 481)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(108, 40)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "  Atualizar"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLimpar.Location = New System.Drawing.Point(238, 481)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(108, 40)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "        Limpar Filtro"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'txtData1
        '
        Me.txtData1.Location = New System.Drawing.Point(899, 492)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(93, 20)
        Me.txtData1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(859, 495)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Data"
        '
        'btnPesqTransito
        '
        Me.btnPesqTransito.Image = CType(resources.GetObject("btnPesqTransito.Image"), System.Drawing.Image)
        Me.btnPesqTransito.Location = New System.Drawing.Point(802, 491)
        Me.btnPesqTransito.Name = "btnPesqTransito"
        Me.btnPesqTransito.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqTransito.TabIndex = 39
        Me.btnPesqTransito.UseVisualStyleBackColor = True
        '
        'txtDescTransito
        '
        Me.txtDescTransito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescTransito.Enabled = False
        Me.txtDescTransito.Location = New System.Drawing.Point(478, 492)
        Me.txtDescTransito.Name = "txtDescTransito"
        Me.txtDescTransito.Size = New System.Drawing.Size(321, 20)
        Me.txtDescTransito.TabIndex = 38
        '
        'txtIdTransito
        '
        Me.txtIdTransito.Enabled = False
        Me.txtIdTransito.Location = New System.Drawing.Point(409, 493)
        Me.txtIdTransito.Name = "txtIdTransito"
        Me.txtIdTransito.Size = New System.Drawing.Size(64, 20)
        Me.txtIdTransito.TabIndex = 37
        '
        'lblTransito
        '
        Me.lblTransito.AutoSize = True
        Me.lblTransito.Location = New System.Drawing.Point(360, 496)
        Me.lblTransito.Name = "lblTransito"
        Me.lblTransito.Size = New System.Drawing.Size(45, 13)
        Me.lblTransito.TabIndex = 36
        Me.lblTransito.Text = "Transito"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(998, 496)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Até"
        '
        'txtData2
        '
        Me.txtData2.Location = New System.Drawing.Point(1027, 492)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(93, 20)
        Me.txtData2.TabIndex = 43
        '
        'ConsultaMovimentoTransitoChip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 522)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPesqTransito)
        Me.Controls.Add(Me.txtDescTransito)
        Me.Controls.Add(Me.txtIdTransito)
        Me.Controls.Add(Me.lblTransito)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.dgvDados)
        Me.Name = "ConsultaMovimentoTransitoChip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Transito de Estoque de Chip"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents txtData1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPesqTransito As System.Windows.Forms.Button
    Friend WithEvents txtDescTransito As System.Windows.Forms.TextBox
    Friend WithEvents txtIdTransito As System.Windows.Forms.TextBox
    Friend WithEvents lblTransito As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtData2 As System.Windows.Forms.TextBox
End Class
