<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pos_vinculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pos_vinculo))
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnExclui = New System.Windows.Forms.Button()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.txtDescPOS = New System.Windows.Forms.TextBox()
        Me.btnPesqPOS = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(16, 19)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(29, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "POS"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(48, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(98, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(15, 43)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(566, 131)
        Me.dgvDados.TabIndex = 11
        '
        'btnExclui
        '
        Me.btnExclui.Image = CType(resources.GetObject("btnExclui.Image"), System.Drawing.Image)
        Me.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExclui.Location = New System.Drawing.Point(114, 180)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(99, 23)
        Me.btnExclui.TabIndex = 21
        Me.btnExclui.Text = "Excluir"
        Me.btnExclui.UseVisualStyleBackColor = True
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Image = CType(resources.GetObject("btnAdiciona.Image"), System.Drawing.Image)
        Me.btnAdiciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdiciona.Location = New System.Drawing.Point(15, 180)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(99, 23)
        Me.btnAdiciona.TabIndex = 20
        Me.btnAdiciona.Text = "Adicionar"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'txtDescPOS
        '
        Me.txtDescPOS.Location = New System.Drawing.Point(149, 16)
        Me.txtDescPOS.Name = "txtDescPOS"
        Me.txtDescPOS.Size = New System.Drawing.Size(348, 20)
        Me.txtDescPOS.TabIndex = 22
        '
        'btnPesqPOS
        '
        Me.btnPesqPOS.Enabled = False
        Me.btnPesqPOS.Image = Global.WinCG.My.Resources.Resources.Lupa16
        Me.btnPesqPOS.Location = New System.Drawing.Point(500, 15)
        Me.btnPesqPOS.Name = "btnPesqPOS"
        Me.btnPesqPOS.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqPOS.TabIndex = 23
        Me.btnPesqPOS.UseVisualStyleBackColor = True
        '
        'Pos_vinculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 259)
        Me.Controls.Add(Me.btnPesqPOS)
        Me.Controls.Add(Me.txtDescPOS)
        Me.Controls.Add(Me.btnExclui)
        Me.Controls.Add(Me.btnAdiciona)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Pos_vinculo"
        Me.Text = "Vincular POS com CHIP"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.dgvDados, 0)
        Me.Controls.SetChildIndex(Me.btnAdiciona, 0)
        Me.Controls.SetChildIndex(Me.btnExclui, 0)
        Me.Controls.SetChildIndex(Me.txtDescPOS, 0)
        Me.Controls.SetChildIndex(Me.btnPesqPOS, 0)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnExclui As System.Windows.Forms.Button
    Friend WithEvents btnAdiciona As System.Windows.Forms.Button
    Friend WithEvents txtDescPOS As System.Windows.Forms.TextBox
    Friend WithEvents btnPesqPOS As System.Windows.Forms.Button
End Class
