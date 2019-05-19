<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OLD_Estoque_equipamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OLD_Estoque_equipamento))
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnPesqLoja = New System.Windows.Forms.Button()
        Me.txtDescLoja = New System.Windows.Forms.TextBox()
        Me.txtIdLoja = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnPesqTipoEquipamento = New System.Windows.Forms.Button()
        Me.txtDescTipoEquipamento = New System.Windows.Forms.TextBox()
        Me.txtIdTipoEquipamento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(10, 11)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(1222, 432)
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
        Me.btnLimpar.TabIndex = 3
        Me.btnLimpar.Text = "        Limpar Filtro"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnPesqLoja
        '
        Me.btnPesqLoja.Image = CType(resources.GetObject("btnPesqLoja.Image"), System.Drawing.Image)
        Me.btnPesqLoja.Location = New System.Drawing.Point(782, 465)
        Me.btnPesqLoja.Name = "btnPesqLoja"
        Me.btnPesqLoja.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqLoja.TabIndex = 13
        Me.btnPesqLoja.UseVisualStyleBackColor = True
        '
        'txtDescLoja
        '
        Me.txtDescLoja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescLoja.Enabled = False
        Me.txtDescLoja.Location = New System.Drawing.Point(458, 466)
        Me.txtDescLoja.Name = "txtDescLoja"
        Me.txtDescLoja.Size = New System.Drawing.Size(321, 20)
        Me.txtDescLoja.TabIndex = 12
        '
        'txtIdLoja
        '
        Me.txtIdLoja.Enabled = False
        Me.txtIdLoja.Location = New System.Drawing.Point(389, 467)
        Me.txtIdLoja.Name = "txtIdLoja"
        Me.txtIdLoja.Size = New System.Drawing.Size(64, 20)
        Me.txtIdLoja.TabIndex = 11
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(360, 470)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(27, 13)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "Loja"
        '
        'btnPesqTipoEquipamento
        '
        Me.btnPesqTipoEquipamento.Image = CType(resources.GetObject("btnPesqTipoEquipamento.Image"), System.Drawing.Image)
        Me.btnPesqTipoEquipamento.Location = New System.Drawing.Point(782, 498)
        Me.btnPesqTipoEquipamento.Name = "btnPesqTipoEquipamento"
        Me.btnPesqTipoEquipamento.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqTipoEquipamento.TabIndex = 33
        Me.btnPesqTipoEquipamento.UseVisualStyleBackColor = True
        '
        'txtDescTipoEquipamento
        '
        Me.txtDescTipoEquipamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescTipoEquipamento.Enabled = False
        Me.txtDescTipoEquipamento.Location = New System.Drawing.Point(458, 501)
        Me.txtDescTipoEquipamento.Name = "txtDescTipoEquipamento"
        Me.txtDescTipoEquipamento.Size = New System.Drawing.Size(321, 20)
        Me.txtDescTipoEquipamento.TabIndex = 32
        '
        'txtIdTipoEquipamento
        '
        Me.txtIdTipoEquipamento.Enabled = False
        Me.txtIdTipoEquipamento.Location = New System.Drawing.Point(389, 501)
        Me.txtIdTipoEquipamento.Name = "txtIdTipoEquipamento"
        Me.txtIdTipoEquipamento.Size = New System.Drawing.Size(64, 20)
        Me.txtIdTipoEquipamento.TabIndex = 31
        Me.txtIdTipoEquipamento.Tag = "Código do Tipo de Equipamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(359, 505)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tipo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(879, 500)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(93, 20)
        Me.TextBox1.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(839, 503)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Data"
        '
        'Estoque_equipamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 522)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPesqTipoEquipamento)
        Me.Controls.Add(Me.txtDescTipoEquipamento)
        Me.Controls.Add(Me.txtIdTipoEquipamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPesqLoja)
        Me.Controls.Add(Me.txtDescLoja)
        Me.Controls.Add(Me.txtIdLoja)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.dgvDados)
        Me.Name = "Estoque_equipamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Estoque de Equipamentos"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnPesqLoja As System.Windows.Forms.Button
    Friend WithEvents txtDescLoja As System.Windows.Forms.TextBox
    Friend WithEvents txtIdLoja As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnPesqTipoEquipamento As System.Windows.Forms.Button
    Friend WithEvents txtDescTipoEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents txtIdTipoEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
