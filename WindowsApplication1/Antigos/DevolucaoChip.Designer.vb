<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevolucaoChip
    Inherits modeloCadastro

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevolucaoChip))
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDataMovto = New System.Windows.Forms.DateTimePicker()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.btnExclui = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(16, 19)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(68, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Romaneio nº"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(396, 19)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(30, 13)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Data"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(91, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtDataMovto
        '
        Me.txtDataMovto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataMovto.Location = New System.Drawing.Point(436, 15)
        Me.txtDataMovto.Name = "txtDataMovto"
        Me.txtDataMovto.Size = New System.Drawing.Size(85, 20)
        Me.txtDataMovto.TabIndex = 3
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(19, 45)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(710, 252)
        Me.dgvDados.TabIndex = 8
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Image = CType(resources.GetObject("btnAdiciona.Image"), System.Drawing.Image)
        Me.btnAdiciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdiciona.Location = New System.Drawing.Point(19, 302)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(99, 23)
        Me.btnAdiciona.TabIndex = 9
        Me.btnAdiciona.Text = "Adicionar"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'btnExclui
        '
        Me.btnExclui.Image = CType(resources.GetObject("btnExclui.Image"), System.Drawing.Image)
        Me.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExclui.Location = New System.Drawing.Point(118, 302)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(99, 23)
        Me.btnExclui.TabIndex = 10
        Me.btnExclui.Text = "Excluir"
        Me.btnExclui.UseVisualStyleBackColor = True
        '
        'DevolucaoChip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 383)
        Me.Controls.Add(Me.btnExclui)
        Me.Controls.Add(Me.btnAdiciona)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.txtDataMovto)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "DevolucaoChip"
        Me.Text = "Devolução de Chip para Fornecedor"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblDescricao, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtDataMovto, 0)
        Me.Controls.SetChildIndex(Me.dgvDados, 0)
        Me.Controls.SetChildIndex(Me.btnAdiciona, 0)
        Me.Controls.SetChildIndex(Me.btnExclui, 0)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDataMovto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdiciona As System.Windows.Forms.Button
    Friend WithEvents btnExclui As System.Windows.Forms.Button
End Class
