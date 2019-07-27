<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelecionaChipVsPOS
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.pesquisaNoGrid = New System.Windows.Forms.TextBox()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.lblWait = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(527, 404)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(446, 404)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(12, 70)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(590, 328)
        Me.dgvDados.TabIndex = 5
        '
        'pesquisaNoGrid
        '
        Me.pesquisaNoGrid.Location = New System.Drawing.Point(13, 33)
        Me.pesquisaNoGrid.Name = "pesquisaNoGrid"
        Me.pesquisaNoGrid.Size = New System.Drawing.Size(235, 20)
        Me.pesquisaNoGrid.TabIndex = 9
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Location = New System.Drawing.Point(12, 404)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(101, 23)
        Me.btnSelecionar.TabIndex = 10
        Me.btnSelecionar.Text = "Marcar Todos"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(527, 30)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisa.TabIndex = 11
        Me.btnPesquisa.Text = "Procurar"
        Me.btnPesquisa.UseVisualStyleBackColor = True
        Me.btnPesquisa.Visible = False
        '
        'lblWait
        '
        Me.lblWait.AutoSize = True
        Me.lblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblWait.Location = New System.Drawing.Point(150, 404)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(276, 20)
        Me.lblWait.TabIndex = 12
        Me.lblWait.Text = "Aguarde o Processamento por favor..."
        Me.lblWait.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Informe o SIMID"
        '
        'FrmSelecionaChipVsPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 433)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.btnPesquisa)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.pesquisaNoGrid)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "FrmSelecionaChipVsPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleção de Chip  para vincular com POS"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents pesquisaNoGrid As System.Windows.Forms.TextBox
    Friend WithEvents btnSelecionar As System.Windows.Forms.Button
    Friend WithEvents btnPesquisa As System.Windows.Forms.Button
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
