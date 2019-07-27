<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modeloCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modeloCadastro))
        Me.tsNavega = New System.Windows.Forms.ToolStrip()
        Me.tsBtnNovo = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnDesfazer = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnFechar = New System.Windows.Forms.ToolStripButton()
        Me.tsLblModulo = New System.Windows.Forms.ToolStripLabel()
        Me.tsNavega.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsNavega
        '
        Me.tsNavega.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsNavega.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsNavega.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnNovo, Me.tsBtnAlterar, Me.tsBtnExcluir, Me.ToolStripSeparator1, Me.tsBtnDesfazer, Me.tsBtnSalvar, Me.ToolStripSeparator2, Me.tsBtnPesquisar, Me.tsBtnFechar, Me.tsLblModulo})
        Me.tsNavega.Location = New System.Drawing.Point(0, 256)
        Me.tsNavega.Name = "tsNavega"
        Me.tsNavega.Size = New System.Drawing.Size(459, 39)
        Me.tsNavega.TabIndex = 0
        Me.tsNavega.Text = "ToolStrip1"
        '
        'tsBtnNovo
        '
        Me.tsBtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnNovo.Image = CType(resources.GetObject("tsBtnNovo.Image"), System.Drawing.Image)
        Me.tsBtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnNovo.Name = "tsBtnNovo"
        Me.tsBtnNovo.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnNovo.Text = "Adicionar novo"
        '
        'tsBtnAlterar
        '
        Me.tsBtnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnAlterar.Enabled = False
        Me.tsBtnAlterar.Image = CType(resources.GetObject("tsBtnAlterar.Image"), System.Drawing.Image)
        Me.tsBtnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnAlterar.Name = "tsBtnAlterar"
        Me.tsBtnAlterar.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnAlterar.Text = "Modificar registro"
        '
        'tsBtnExcluir
        '
        Me.tsBtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnExcluir.Enabled = False
        Me.tsBtnExcluir.Image = CType(resources.GetObject("tsBtnExcluir.Image"), System.Drawing.Image)
        Me.tsBtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnExcluir.Name = "tsBtnExcluir"
        Me.tsBtnExcluir.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnExcluir.Text = "Excluir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsBtnDesfazer
        '
        Me.tsBtnDesfazer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnDesfazer.Enabled = False
        Me.tsBtnDesfazer.Image = CType(resources.GetObject("tsBtnDesfazer.Image"), System.Drawing.Image)
        Me.tsBtnDesfazer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnDesfazer.Name = "tsBtnDesfazer"
        Me.tsBtnDesfazer.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnDesfazer.Text = "Desfazer"
        '
        'tsBtnSalvar
        '
        Me.tsBtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnSalvar.Enabled = False
        Me.tsBtnSalvar.Image = CType(resources.GetObject("tsBtnSalvar.Image"), System.Drawing.Image)
        Me.tsBtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnSalvar.Name = "tsBtnSalvar"
        Me.tsBtnSalvar.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnSalvar.Text = "Salvar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'tsBtnPesquisar
        '
        Me.tsBtnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnPesquisar.Image = CType(resources.GetObject("tsBtnPesquisar.Image"), System.Drawing.Image)
        Me.tsBtnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnPesquisar.Name = "tsBtnPesquisar"
        Me.tsBtnPesquisar.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnPesquisar.Text = "Pesquisar"
        '
        'tsBtnFechar
        '
        Me.tsBtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnFechar.Image = CType(resources.GetObject("tsBtnFechar.Image"), System.Drawing.Image)
        Me.tsBtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnFechar.Name = "tsBtnFechar"
        Me.tsBtnFechar.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnFechar.Text = "Fechar"
        '
        'tsLblModulo
        '
        Me.tsLblModulo.Name = "tsLblModulo"
        Me.tsLblModulo.Size = New System.Drawing.Size(13, 36)
        Me.tsLblModulo.Text = "0"
        '
        'modeloCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 295)
        Me.Controls.Add(Me.tsNavega)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "modeloCadastro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de ..."
        Me.tsNavega.ResumeLayout(False)
        Me.tsNavega.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents tsNavega As System.Windows.Forms.ToolStrip
    Public WithEvents tsBtnNovo As System.Windows.Forms.ToolStripButton
    Public WithEvents tsBtnAlterar As System.Windows.Forms.ToolStripButton
    Public WithEvents tsBtnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsBtnDesfazer As System.Windows.Forms.ToolStripButton
    Public WithEvents tsBtnSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsBtnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnPesquisar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsLblModulo As System.Windows.Forms.ToolStripLabel
End Class
