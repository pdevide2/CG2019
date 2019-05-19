<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaixaMovimentoTransito
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PesqFKTransito = New WinCG.PesqFK()
        Me.PesqFKLojaDestinoPOS = New WinCG.PesqFK()
        Me.PesqFKLojaDestino = New WinCG.PesqFK()
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
        Me.TabControl1.Size = New System.Drawing.Size(881, 501)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PesqFKTransito)
        Me.TabPage1.Controls.Add(Me.lblStatus)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(793, 475)
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
        Me.Button1.Location = New System.Drawing.Point(710, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Avançar >>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(873, 475)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PesqFKLojaDestinoPOS)
        Me.GroupBox2.Controls.Add(Me.dgvDados2)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 210)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "POS"
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(11, 19)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.ReadOnly = True
        Me.dgvDados2.Size = New System.Drawing.Size(843, 143)
        Me.dgvDados2.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PesqFKLojaDestino)
        Me.GroupBox1.Controls.Add(Me.dgvDados)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 210)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chip"
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(11, 21)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(843, 143)
        Me.dgvDados.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Etapa 2"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(792, 447)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Concluir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(711, 447)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "<< Voltar"
        Me.Button4.UseVisualStyleBackColor = True
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
        Me.PesqFKTransito.LabelPesqFK = "Trânsito"
        Me.PesqFKTransito.ListaCampos = Nothing
        Me.PesqFKTransito.Location = New System.Drawing.Point(13, 14)
        Me.PesqFKTransito.Name = "PesqFKTransito"
        Me.PesqFKTransito.ObjModelFk = Nothing
        Me.PesqFKTransito.PosValida = False
        Me.PesqFKTransito.Size = New System.Drawing.Size(577, 25)
        Me.PesqFKTransito.Tabela = Nothing
        Me.PesqFKTransito.TabIndex = 29
        Me.PesqFKTransito.TituloTela = Nothing
        Me.PesqFKTransito.View = Nothing
        '
        'PesqFKLojaDestinoPOS
        '
        Me.PesqFKLojaDestinoPOS.CampoDesc = Nothing
        Me.PesqFKLojaDestinoPOS.CampoId = Nothing
        Me.PesqFKLojaDestinoPOS.Clicou = "0"
        Me.PesqFKLojaDestinoPOS.CodigoSelecionado = Nothing
        Me.PesqFKLojaDestinoPOS.ColunasFiltro = Nothing
        Me.PesqFKLojaDestinoPOS.DescricaoSelecionada = Nothing
        Me.PesqFKLojaDestinoPOS.FiltroSQL = Nothing
        Me.PesqFKLojaDestinoPOS.LabelBuscaDesc = Nothing
        Me.PesqFKLojaDestinoPOS.LabelBuscaId = Nothing
        Me.PesqFKLojaDestinoPOS.LabelPesqFK = "Loja Destino"
        Me.PesqFKLojaDestinoPOS.ListaCampos = Nothing
        Me.PesqFKLojaDestinoPOS.Location = New System.Drawing.Point(144, 168)
        Me.PesqFKLojaDestinoPOS.Name = "PesqFKLojaDestinoPOS"
        Me.PesqFKLojaDestinoPOS.ObjModelFk = Nothing
        Me.PesqFKLojaDestinoPOS.PosValida = False
        Me.PesqFKLojaDestinoPOS.Size = New System.Drawing.Size(495, 25)
        Me.PesqFKLojaDestinoPOS.Tabela = Nothing
        Me.PesqFKLojaDestinoPOS.TabIndex = 35
        Me.PesqFKLojaDestinoPOS.TituloTela = Nothing
        Me.PesqFKLojaDestinoPOS.View = Nothing
        '
        'PesqFKLojaDestino
        '
        Me.PesqFKLojaDestino.CampoDesc = Nothing
        Me.PesqFKLojaDestino.CampoId = Nothing
        Me.PesqFKLojaDestino.Clicou = "0"
        Me.PesqFKLojaDestino.CodigoSelecionado = Nothing
        Me.PesqFKLojaDestino.ColunasFiltro = Nothing
        Me.PesqFKLojaDestino.DescricaoSelecionada = Nothing
        Me.PesqFKLojaDestino.FiltroSQL = Nothing
        Me.PesqFKLojaDestino.LabelBuscaDesc = Nothing
        Me.PesqFKLojaDestino.LabelBuscaId = Nothing
        Me.PesqFKLojaDestino.LabelPesqFK = "Loja Destino"
        Me.PesqFKLojaDestino.ListaCampos = Nothing
        Me.PesqFKLojaDestino.Location = New System.Drawing.Point(144, 172)
        Me.PesqFKLojaDestino.Name = "PesqFKLojaDestino"
        Me.PesqFKLojaDestino.ObjModelFk = Nothing
        Me.PesqFKLojaDestino.PosValida = False
        Me.PesqFKLojaDestino.Size = New System.Drawing.Size(495, 25)
        Me.PesqFKLojaDestino.Tabela = Nothing
        Me.PesqFKLojaDestino.TabIndex = 34
        Me.PesqFKLojaDestino.TituloTela = Nothing
        Me.PesqFKLojaDestino.View = Nothing
        '
        'BaixaMovimentoTransito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 504)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "BaixaMovimentoTransito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baixa Movimento Trânsito"
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
    Friend WithEvents PesqFKTransito As WinCG.PesqFK
    Friend WithEvents PesqFKLojaDestino As WinCG.PesqFK
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PesqFKLojaDestinoPOS As WinCG.PesqFK
    Friend WithEvents dgvDados2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
