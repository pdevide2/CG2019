<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeraMovimentoTransito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeraMovimentoTransito))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExcluiPOS = New System.Windows.Forms.Button()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.btnAdicionaPOS = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExclui = New System.Windows.Forms.Button()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PesqFKLojaOrigem = New WinCG.PesqFK()
        Me.PesqFKTransito = New WinCG.PesqFK()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(705, 515)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PesqFKLojaOrigem)
        Me.TabPage1.Controls.Add(Me.PesqFKTransito)
        Me.TabPage1.Controls.Add(Me.lblStatus)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(697, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(5, 66)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(616, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Avançar >>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(697, 489)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExcluiPOS)
        Me.GroupBox2.Controls.Add(Me.dgvDados2)
        Me.GroupBox2.Controls.Add(Me.btnAdicionaPOS)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(681, 195)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "POS"
        '
        'btnExcluiPOS
        '
        Me.btnExcluiPOS.Image = CType(resources.GetObject("btnExcluiPOS.Image"), System.Drawing.Image)
        Me.btnExcluiPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluiPOS.Location = New System.Drawing.Point(105, 168)
        Me.btnExcluiPOS.Name = "btnExcluiPOS"
        Me.btnExcluiPOS.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluiPOS.TabIndex = 28
        Me.btnExcluiPOS.Text = "Excluir"
        Me.btnExcluiPOS.UseVisualStyleBackColor = True
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(6, 20)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.ReadOnly = True
        Me.dgvDados2.Size = New System.Drawing.Size(669, 144)
        Me.dgvDados2.TabIndex = 23
        '
        'btnAdicionaPOS
        '
        Me.btnAdicionaPOS.Image = CType(resources.GetObject("btnAdicionaPOS.Image"), System.Drawing.Image)
        Me.btnAdicionaPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionaPOS.Location = New System.Drawing.Point(6, 168)
        Me.btnAdicionaPOS.Name = "btnAdicionaPOS"
        Me.btnAdicionaPOS.Size = New System.Drawing.Size(97, 23)
        Me.btnAdicionaPOS.TabIndex = 27
        Me.btnAdicionaPOS.Text = "Adicionar"
        Me.btnAdicionaPOS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExclui)
        Me.GroupBox1.Controls.Add(Me.btnAdiciona)
        Me.GroupBox1.Controls.Add(Me.dgvDados)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 195)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chip"
        '
        'btnExclui
        '
        Me.btnExclui.Image = CType(resources.GetObject("btnExclui.Image"), System.Drawing.Image)
        Me.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExclui.Location = New System.Drawing.Point(105, 169)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(97, 23)
        Me.btnExclui.TabIndex = 26
        Me.btnExclui.Text = "Excluir"
        Me.btnExclui.UseVisualStyleBackColor = True
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Image = CType(resources.GetObject("btnAdiciona.Image"), System.Drawing.Image)
        Me.btnAdiciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdiciona.Location = New System.Drawing.Point(6, 169)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(97, 23)
        Me.btnAdiciona.TabIndex = 25
        Me.btnAdiciona.Text = "Adicionar"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(6, 19)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(669, 144)
        Me.dgvDados.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Etapa 2"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(616, 458)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Concluir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(540, 458)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "<< Voltar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Selecione a Empresa de Origem do Estoque:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(235, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(149, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'PesqFKLojaOrigem
        '
        Me.PesqFKLojaOrigem.CampoDesc = Nothing
        Me.PesqFKLojaOrigem.CampoId = Nothing
        Me.PesqFKLojaOrigem.Clicou = "0"
        Me.PesqFKLojaOrigem.CodigoSelecionado = Nothing
        Me.PesqFKLojaOrigem.ColunasFiltro = Nothing
        Me.PesqFKLojaOrigem.DescricaoSelecionada = Nothing
        Me.PesqFKLojaOrigem.FiltroSQL = Nothing
        Me.PesqFKLojaOrigem.LabelBuscaDesc = Nothing
        Me.PesqFKLojaOrigem.LabelBuscaId = Nothing
        Me.PesqFKLojaOrigem.LabelPesqFK = Nothing
        Me.PesqFKLojaOrigem.ListaCampos = Nothing
        Me.PesqFKLojaOrigem.Location = New System.Drawing.Point(17, 59)
        Me.PesqFKLojaOrigem.Name = "PesqFKLojaOrigem"
        Me.PesqFKLojaOrigem.ObjModelFk = Nothing
        Me.PesqFKLojaOrigem.PosValida = False
        Me.PesqFKLojaOrigem.Size = New System.Drawing.Size(498, 25)
        Me.PesqFKLojaOrigem.Tabela = Nothing
        Me.PesqFKLojaOrigem.TabIndex = 31
        Me.PesqFKLojaOrigem.TituloTela = Nothing
        Me.PesqFKLojaOrigem.View = Nothing
        '
        'PesqFKTransito
        '
        Me.PesqFKTransito.CampoDesc = Nothing
        Me.PesqFKTransito.CampoId = Nothing
        Me.PesqFKTransito.Clicou = "0"
        Me.PesqFKTransito.CodigoSelecionado = Nothing
        Me.PesqFKTransito.ColunasFiltro = Nothing
        Me.PesqFKTransito.DescricaoSelecionada = Nothing
        Me.PesqFKTransito.FiltroSQL = Nothing
        Me.PesqFKTransito.LabelBuscaDesc = Nothing
        Me.PesqFKTransito.LabelBuscaId = Nothing
        Me.PesqFKTransito.LabelPesqFK = Nothing
        Me.PesqFKTransito.ListaCampos = Nothing
        Me.PesqFKTransito.Location = New System.Drawing.Point(17, 17)
        Me.PesqFKTransito.Name = "PesqFKTransito"
        Me.PesqFKTransito.ObjModelFk = Nothing
        Me.PesqFKTransito.PosValida = False
        Me.PesqFKTransito.Size = New System.Drawing.Size(498, 25)
        Me.PesqFKTransito.Tabela = Nothing
        Me.PesqFKTransito.TabIndex = 30
        Me.PesqFKTransito.TituloTela = Nothing
        Me.PesqFKTransito.View = Nothing
        '
        'GeraMovimentoTransito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "GeraMovimentoTransito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gera Movimento Trânsito"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents PesqFKLojaOrigem As WinCG.PesqFK
    Friend WithEvents PesqFKTransito As WinCG.PesqFK
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluiPOS As System.Windows.Forms.Button
    Friend WithEvents dgvDados2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdicionaPOS As System.Windows.Forms.Button
    Friend WithEvents btnExclui As System.Windows.Forms.Button
    Friend WithEvents btnAdiciona As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
End Class
