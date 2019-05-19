<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelecionaEquipamentoDisponivelDevolucao
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
        Me.optPesq1 = New System.Windows.Forms.RadioButton()
        Me.optPesq2 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pesquisaNoGrid = New System.Windows.Forms.TextBox()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.lblWait = New System.Windows.Forms.Label()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(527, 363)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(446, 363)
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
        Me.dgvDados.Location = New System.Drawing.Point(12, 72)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(590, 285)
        Me.dgvDados.TabIndex = 5
        '
        'optPesq1
        '
        Me.optPesq1.AutoSize = True
        Me.optPesq1.Location = New System.Drawing.Point(8, 7)
        Me.optPesq1.Name = "optPesq1"
        Me.optPesq1.Size = New System.Drawing.Size(109, 17)
        Me.optPesq1.TabIndex = 6
        Me.optPesq1.TabStop = True
        Me.optPesq1.Text = "Começando por..."
        Me.optPesq1.UseVisualStyleBackColor = True
        '
        'optPesq2
        '
        Me.optPesq2.AutoSize = True
        Me.optPesq2.Location = New System.Drawing.Point(122, 7)
        Me.optPesq2.Name = "optPesq2"
        Me.optPesq2.Size = New System.Drawing.Size(133, 17)
        Me.optPesq2.TabIndex = 7
        Me.optPesq2.TabStop = True
        Me.optPesq2.Text = "Em qualquer posição..."
        Me.optPesq2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.optPesq2)
        Me.Panel1.Controls.Add(Me.optPesq1)
        Me.Panel1.Location = New System.Drawing.Point(16, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 31)
        Me.Panel1.TabIndex = 8
        '
        'pesquisaNoGrid
        '
        Me.pesquisaNoGrid.Location = New System.Drawing.Point(286, 17)
        Me.pesquisaNoGrid.Name = "pesquisaNoGrid"
        Me.pesquisaNoGrid.Size = New System.Drawing.Size(235, 20)
        Me.pesquisaNoGrid.TabIndex = 9
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Location = New System.Drawing.Point(12, 363)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(101, 23)
        Me.btnSelecionar.TabIndex = 10
        Me.btnSelecionar.Text = "Marcar Todos"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(527, 15)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisa.TabIndex = 11
        Me.btnPesquisa.Text = "Procurar"
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'lblWait
        '
        Me.lblWait.AutoSize = True
        Me.lblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblWait.Location = New System.Drawing.Point(150, 363)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(276, 20)
        Me.lblWait.TabIndex = 12
        Me.lblWait.Text = "Aguarde o Processamento por favor..."
        Me.lblWait.Visible = False
        '
        'frmSelecionaEquipamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 398)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.btnPesquisa)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.pesquisaNoGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmSelecionaEquipamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleção de Equipamentos/POS"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents optPesq1 As System.Windows.Forms.RadioButton
    Friend WithEvents optPesq2 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pesquisaNoGrid As System.Windows.Forms.TextBox
    Friend WithEvents btnSelecionar As System.Windows.Forms.Button
    Friend WithEvents btnPesquisa As System.Windows.Forms.Button
    Friend WithEvents lblWait As System.Windows.Forms.Label
End Class
