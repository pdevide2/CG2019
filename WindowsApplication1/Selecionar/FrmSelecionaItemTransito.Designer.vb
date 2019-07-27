<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelecionaItemTransito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelecionaItemTransito))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optFilter2 = New System.Windows.Forms.RadioButton()
        Me.optFilter1 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PesqFKLojaOrigem = New WinCG.PesqFK()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(527, 494)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(446, 494)
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
        Me.dgvDados.Location = New System.Drawing.Point(12, 180)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(590, 308)
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
        Me.Panel1.Location = New System.Drawing.Point(16, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 31)
        Me.Panel1.TabIndex = 8
        '
        'pesquisaNoGrid
        '
        Me.pesquisaNoGrid.Location = New System.Drawing.Point(354, 107)
        Me.pesquisaNoGrid.Name = "pesquisaNoGrid"
        Me.pesquisaNoGrid.Size = New System.Drawing.Size(167, 20)
        Me.pesquisaNoGrid.TabIndex = 9
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Location = New System.Drawing.Point(12, 494)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(101, 23)
        Me.btnSelecionar.TabIndex = 10
        Me.btnSelecionar.Text = "Marcar Todos"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(527, 105)
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
        Me.lblWait.Location = New System.Drawing.Point(150, 494)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(276, 20)
        Me.lblWait.TabIndex = 12
        Me.lblWait.Text = "Aguarde o Processamento por favor..."
        Me.lblWait.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(300, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'optFilter2
        '
        Me.optFilter2.AutoSize = True
        Me.optFilter2.Checked = True
        Me.optFilter2.Location = New System.Drawing.Point(121, 5)
        Me.optFilter2.Name = "optFilter2"
        Me.optFilter2.Size = New System.Drawing.Size(98, 17)
        Me.optFilter2.TabIndex = 1
        Me.optFilter2.TabStop = True
        Me.optFilter2.Text = "Filtrar as Linhas"
        Me.optFilter2.UseVisualStyleBackColor = True
        '
        'optFilter1
        '
        Me.optFilter1.AutoSize = True
        Me.optFilter1.Location = New System.Drawing.Point(11, 5)
        Me.optFilter1.Name = "optFilter1"
        Me.optFilter1.Size = New System.Drawing.Size(105, 17)
        Me.optFilter1.TabIndex = 0
        Me.optFilter1.Text = "Localizar apenas"
        Me.optFilter1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.optFilter2)
        Me.Panel2.Controls.Add(Me.optFilter1)
        Me.Panel2.Location = New System.Drawing.Point(16, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(264, 31)
        Me.Panel2.TabIndex = 15
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
        Me.PesqFKLojaOrigem.Location = New System.Drawing.Point(16, 57)
        Me.PesqFKLojaOrigem.Name = "PesqFKLojaOrigem"
        Me.PesqFKLojaOrigem.ObjModelFk = Nothing
        Me.PesqFKLojaOrigem.PosValida = False
        Me.PesqFKLojaOrigem.Size = New System.Drawing.Size(498, 25)
        Me.PesqFKLojaOrigem.Tabela = Nothing
        Me.PesqFKLojaOrigem.TabIndex = 32
        Me.PesqFKLojaOrigem.TituloTela = Nothing
        Me.PesqFKLojaOrigem.View = Nothing
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(237, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(149, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Selecione a Empresa de Origem do Estoque:"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(527, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 48)
        Me.Button1.TabIndex = 35
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Label3"
        '
        'frmSelecionaItemTransito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 522)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PesqFKLojaOrigem)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.btnPesquisa)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.pesquisaNoGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmSelecionaItemTransito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleção de Chip"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optFilter2 As System.Windows.Forms.RadioButton
    Friend WithEvents optFilter1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PesqFKLojaOrigem As PesqFK
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
