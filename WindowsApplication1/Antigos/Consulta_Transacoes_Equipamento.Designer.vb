<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Transacoes_Equipamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_Transacoes_Equipamento))
        Me.dgvDados1 = New System.Windows.Forms.DataGridView()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.txtData1 = New System.Windows.Forms.DateTimePicker()
        Me.txtData2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvDados1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDados1
        '
        Me.dgvDados1.AllowUserToAddRows = False
        Me.dgvDados1.AllowUserToDeleteRows = False
        Me.dgvDados1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados1.Location = New System.Drawing.Point(12, 38)
        Me.dgvDados1.Name = "dgvDados1"
        Me.dgvDados1.ReadOnly = True
        Me.dgvDados1.Size = New System.Drawing.Size(1220, 150)
        Me.dgvDados1.TabIndex = 0
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(12, 201)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.ReadOnly = True
        Me.dgvDados2.Size = New System.Drawing.Size(1220, 257)
        Me.dgvDados2.TabIndex = 1
        '
        'txtData1
        '
        Me.txtData1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtData1.Location = New System.Drawing.Point(89, 10)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(97, 20)
        Me.txtData1.TabIndex = 2
        '
        'txtData2
        '
        Me.txtData2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtData2.Location = New System.Drawing.Point(230, 10)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(97, 20)
        Me.txtData2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Período (De):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "(Até):"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRefresh.Location = New System.Drawing.Point(12, 460)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(146, 35)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Atualizar"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Consulta_Transacoes_Equipamento
        '
        Me.ClientSize = New System.Drawing.Size(1244, 495)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.dgvDados2)
        Me.Controls.Add(Me.dgvDados1)
        Me.Name = "Consulta_Transacoes_Equipamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Log de Transações de Equipamentos"
        CType(Me.dgvDados1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDados1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDados2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtData1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtData2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
