<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradaEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntradaEstoque))
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnPesqLoja = New System.Windows.Forms.Button()
        Me.txtDescLoja = New System.Windows.Forms.TextBox()
        Me.txtIdLoja = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtDataMovto = New System.Windows.Forms.DateTimePicker()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.btnExclui = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnExcluiPOS = New System.Windows.Forms.Button()
        Me.btnAdicionaPOS = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnPesqLoja
        '
        Me.btnPesqLoja.Enabled = False
        Me.btnPesqLoja.Image = CType(resources.GetObject("btnPesqLoja.Image"), System.Drawing.Image)
        Me.btnPesqLoja.Location = New System.Drawing.Point(488, 42)
        Me.btnPesqLoja.Name = "btnPesqLoja"
        Me.btnPesqLoja.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqLoja.TabIndex = 7
        Me.btnPesqLoja.UseVisualStyleBackColor = True
        '
        'txtDescLoja
        '
        Me.txtDescLoja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescLoja.Enabled = False
        Me.txtDescLoja.Location = New System.Drawing.Point(161, 43)
        Me.txtDescLoja.Name = "txtDescLoja"
        Me.txtDescLoja.Size = New System.Drawing.Size(321, 20)
        Me.txtDescLoja.TabIndex = 6
        '
        'txtIdLoja
        '
        Me.txtIdLoja.Enabled = False
        Me.txtIdLoja.Location = New System.Drawing.Point(91, 43)
        Me.txtIdLoja.Name = "txtIdLoja"
        Me.txtIdLoja.Size = New System.Drawing.Size(64, 20)
        Me.txtIdLoja.TabIndex = 5
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(57, 47)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(27, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Loja"
        '
        'txtDataMovto
        '
        Me.txtDataMovto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataMovto.Location = New System.Drawing.Point(436, 15)
        Me.txtDataMovto.Name = "txtDataMovto"
        Me.txtDataMovto.Size = New System.Drawing.Size(85, 20)
        Me.txtDataMovto.TabIndex = 3
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Image = CType(resources.GetObject("btnAdiciona.Image"), System.Drawing.Image)
        Me.btnAdiciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdiciona.Location = New System.Drawing.Point(17, 146)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(115, 23)
        Me.btnAdiciona.TabIndex = 9
        Me.btnAdiciona.Text = "Adicionar Chip"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'btnExclui
        '
        Me.btnExclui.Image = CType(resources.GetObject("btnExclui.Image"), System.Drawing.Image)
        Me.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExclui.Location = New System.Drawing.Point(134, 146)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(115, 23)
        Me.btnExclui.TabIndex = 10
        Me.btnExclui.Text = "Excluir Chip"
        Me.btnExclui.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdiciona)
        Me.GroupBox1.Controls.Add(Me.btnExclui)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 173)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chip"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExcluiPOS)
        Me.GroupBox2.Controls.Add(Me.btnAdicionaPOS)
        Me.GroupBox2.Controls.Add(Me.dgvDados2)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(847, 173)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "POS"
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(17, 19)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.ReadOnly = True
        Me.dgvDados2.Size = New System.Drawing.Size(822, 121)
        Me.dgvDados2.TabIndex = 14
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(36, 90)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(822, 121)
        Me.dgvDados.TabIndex = 13
        '
        'btnExcluiPOS
        '
        Me.btnExcluiPOS.Image = CType(resources.GetObject("btnExcluiPOS.Image"), System.Drawing.Image)
        Me.btnExcluiPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluiPOS.Location = New System.Drawing.Point(134, 144)
        Me.btnExcluiPOS.Name = "btnExcluiPOS"
        Me.btnExcluiPOS.Size = New System.Drawing.Size(115, 23)
        Me.btnExcluiPOS.TabIndex = 15
        Me.btnExcluiPOS.Text = "Excluir POS"
        Me.btnExcluiPOS.UseVisualStyleBackColor = True
        '
        'btnAdicionaPOS
        '
        Me.btnAdicionaPOS.Image = CType(resources.GetObject("btnAdicionaPOS.Image"), System.Drawing.Image)
        Me.btnAdicionaPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionaPOS.Location = New System.Drawing.Point(17, 144)
        Me.btnAdicionaPOS.Name = "btnAdicionaPOS"
        Me.btnAdicionaPOS.Size = New System.Drawing.Size(115, 23)
        Me.btnAdicionaPOS.TabIndex = 14
        Me.btnAdicionaPOS.Text = "Adicionar POS"
        Me.btnAdicionaPOS.UseVisualStyleBackColor = True
        '
        'EntradaEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 484)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDataMovto)
        Me.Controls.Add(Me.btnPesqLoja)
        Me.Controls.Add(Me.txtDescLoja)
        Me.Controls.Add(Me.txtIdLoja)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "EntradaEstoque"
        Me.Text = "Entrada de Estoque de Chip/POS"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblDescricao, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.txtIdLoja, 0)
        Me.Controls.SetChildIndex(Me.txtDescLoja, 0)
        Me.Controls.SetChildIndex(Me.btnPesqLoja, 0)
        Me.Controls.SetChildIndex(Me.txtDataMovto, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.dgvDados, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnPesqLoja As System.Windows.Forms.Button
    Friend WithEvents txtDescLoja As System.Windows.Forms.TextBox
    Friend WithEvents txtIdLoja As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtDataMovto As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdiciona As System.Windows.Forms.Button
    Friend WithEvents btnExclui As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDados2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcluiPOS As System.Windows.Forms.Button
    Friend WithEvents btnAdicionaPOS As System.Windows.Forms.Button
End Class
