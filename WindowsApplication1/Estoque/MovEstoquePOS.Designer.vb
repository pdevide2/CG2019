<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovEstoquePOS
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optInativo = New System.Windows.Forms.RadioButton()
        Me.optEstqPeca = New System.Windows.Forms.RadioButton()
        Me.optLaudo = New System.Windows.Forms.RadioButton()
        Me.optDefeito = New System.Windows.Forms.RadioButton()
        Me.optMatriz = New System.Windows.Forms.RadioButton()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnProcurarSerie = New System.Windows.Forms.Button()
        Me.optPesqSerie2 = New System.Windows.Forms.RadioButton()
        Me.optPesqSerie1 = New System.Windows.Forms.RadioButton()
        Me.txtPesquisaSerie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrigem = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optInativo)
        Me.GroupBox1.Controls.Add(Me.optEstqPeca)
        Me.GroupBox1.Controls.Add(Me.optLaudo)
        Me.GroupBox1.Controls.Add(Me.optDefeito)
        Me.GroupBox1.Controls.Add(Me.optMatriz)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecione a Origem do Estoque:"
        '
        'optInativo
        '
        Me.optInativo.AutoSize = True
        Me.optInativo.Location = New System.Drawing.Point(419, 22)
        Me.optInativo.Name = "optInativo"
        Me.optInativo.Size = New System.Drawing.Size(57, 17)
        Me.optInativo.TabIndex = 4
        Me.optInativo.TabStop = True
        Me.optInativo.Text = "Inativo"
        Me.optInativo.UseVisualStyleBackColor = True
        '
        'optEstqPeca
        '
        Me.optEstqPeca.AutoSize = True
        Me.optEstqPeca.Location = New System.Drawing.Point(281, 22)
        Me.optEstqPeca.Name = "optEstqPeca"
        Me.optEstqPeca.Size = New System.Drawing.Size(112, 17)
        Me.optEstqPeca.TabIndex = 3
        Me.optEstqPeca.TabStop = True
        Me.optEstqPeca.Text = "Estoque de Peças"
        Me.optEstqPeca.UseVisualStyleBackColor = True
        '
        'optLaudo
        '
        Me.optLaudo.AutoSize = True
        Me.optLaudo.Location = New System.Drawing.Point(200, 22)
        Me.optLaudo.Name = "optLaudo"
        Me.optLaudo.Size = New System.Drawing.Size(55, 17)
        Me.optLaudo.TabIndex = 2
        Me.optLaudo.TabStop = True
        Me.optLaudo.Text = "Laudo"
        Me.optLaudo.UseVisualStyleBackColor = True
        '
        'optDefeito
        '
        Me.optDefeito.AutoSize = True
        Me.optDefeito.Location = New System.Drawing.Point(91, 22)
        Me.optDefeito.Name = "optDefeito"
        Me.optDefeito.Size = New System.Drawing.Size(83, 17)
        Me.optDefeito.TabIndex = 1
        Me.optDefeito.TabStop = True
        Me.optDefeito.Text = "Com Defeito"
        Me.optDefeito.UseVisualStyleBackColor = True
        '
        'optMatriz
        '
        Me.optMatriz.AutoSize = True
        Me.optMatriz.Location = New System.Drawing.Point(12, 22)
        Me.optMatriz.Name = "optMatriz"
        Me.optMatriz.Size = New System.Drawing.Size(53, 17)
        Me.optMatriz.TabIndex = 0
        Me.optMatriz.TabStop = True
        Me.optMatriz.Text = "Matriz"
        Me.optMatriz.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(12, 91)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(600, 308)
        Me.dgvDados.TabIndex = 1
        '
        'btnProcurarSerie
        '
        Me.btnProcurarSerie.Location = New System.Drawing.Point(421, 62)
        Me.btnProcurarSerie.Name = "btnProcurarSerie"
        Me.btnProcurarSerie.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarSerie.TabIndex = 24
        Me.btnProcurarSerie.Text = "Procurar"
        Me.btnProcurarSerie.UseVisualStyleBackColor = True
        '
        'optPesqSerie2
        '
        Me.optPesqSerie2.AutoSize = True
        Me.optPesqSerie2.Checked = True
        Me.optPesqSerie2.Location = New System.Drawing.Point(301, 65)
        Me.optPesqSerie2.Name = "optPesqSerie2"
        Me.optPesqSerie2.Size = New System.Drawing.Size(108, 17)
        Me.optPesqSerie2.TabIndex = 25
        Me.optPesqSerie2.TabStop = True
        Me.optPesqSerie2.Text = "Qualquer posição"
        Me.optPesqSerie2.UseVisualStyleBackColor = True
        '
        'optPesqSerie1
        '
        Me.optPesqSerie1.AutoSize = True
        Me.optPesqSerie1.Location = New System.Drawing.Point(186, 65)
        Me.optPesqSerie1.Name = "optPesqSerie1"
        Me.optPesqSerie1.Size = New System.Drawing.Size(100, 17)
        Me.optPesqSerie1.TabIndex = 26
        Me.optPesqSerie1.Text = "Começando por"
        Me.optPesqSerie1.UseVisualStyleBackColor = True
        '
        'txtPesquisaSerie
        '
        Me.txtPesquisaSerie.Location = New System.Drawing.Point(58, 63)
        Me.txtPesquisaSerie.Name = "txtPesquisaSerie"
        Me.txtPesquisaSerie.Size = New System.Drawing.Size(121, 20)
        Me.txtPesquisaSerie.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nº. Série"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Origem"
        '
        'txtOrigem
        '
        Me.txtOrigem.Enabled = False
        Me.txtOrigem.Location = New System.Drawing.Point(54, 411)
        Me.txtOrigem.Name = "txtOrigem"
        Me.txtOrigem.ReadOnly = True
        Me.txtOrigem.Size = New System.Drawing.Size(127, 20)
        Me.txtOrigem.TabIndex = 28
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Location = New System.Drawing.Point(222, 411)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(137, 20)
        Me.txtSerie.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Série"
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Location = New System.Drawing.Point(423, 411)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(189, 20)
        Me.txtModelo.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 415)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Modelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Destino"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(54, 444)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(302, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Transferir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MovEstoquePOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 479)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOrigem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProcurarSerie)
        Me.Controls.Add(Me.optPesqSerie2)
        Me.Controls.Add(Me.optPesqSerie1)
        Me.Controls.Add(Me.txtPesquisaSerie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MovEstoquePOS"
        Me.Text = "Movimentação de Estoque de POS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optInativo As RadioButton
    Friend WithEvents optEstqPeca As RadioButton
    Friend WithEvents optLaudo As RadioButton
    Friend WithEvents optDefeito As RadioButton
    Friend WithEvents optMatriz As RadioButton
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents btnProcurarSerie As Button
    Friend WithEvents optPesqSerie2 As RadioButton
    Friend WithEvents optPesqSerie1 As RadioButton
    Friend WithEvents txtPesquisaSerie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrigem As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
