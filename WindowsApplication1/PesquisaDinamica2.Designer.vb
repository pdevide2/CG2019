<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisaDinamica2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PesquisaDinamica2))
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.optPesquisa2 = New System.Windows.Forms.RadioButton()
        Me.optPesquisa1 = New System.Windows.Forms.RadioButton()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        Me.lblFiltrar = New System.Windows.Forms.Label()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(8, 122)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(674, 279)
        Me.dgvDados.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(526, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(607, 407)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(8, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(506, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(554, 93)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Pesquisar Tudo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.optPesquisa2)
        Me.Panel1.Controls.Add(Me.optPesquisa1)
        Me.Panel1.Location = New System.Drawing.Point(13, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 23)
        Me.Panel1.TabIndex = 6
        '
        'optPesquisa2
        '
        Me.optPesquisa2.AutoSize = True
        Me.optPesquisa2.Location = New System.Drawing.Point(121, 3)
        Me.optPesquisa2.Name = "optPesquisa2"
        Me.optPesquisa2.Size = New System.Drawing.Size(133, 17)
        Me.optPesquisa2.TabIndex = 1
        Me.optPesquisa2.Text = "Em qualquer posição..."
        Me.optPesquisa2.UseVisualStyleBackColor = True
        '
        'optPesquisa1
        '
        Me.optPesquisa1.AutoSize = True
        Me.optPesquisa1.Checked = True
        Me.optPesquisa1.Location = New System.Drawing.Point(4, 3)
        Me.optPesquisa1.Name = "optPesquisa1"
        Me.optPesquisa1.Size = New System.Drawing.Size(109, 17)
        Me.optPesquisa1.TabIndex = 0
        Me.optPesquisa1.TabStop = True
        Me.optPesquisa1.Text = "Começando por..."
        Me.optPesquisa1.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNovo.Location = New System.Drawing.Point(8, 407)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(106, 23)
        Me.btnNovo.TabIndex = 7
        Me.btnNovo.Text = "Adicionar Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'cboCampo
        '
        Me.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Location = New System.Drawing.Point(91, 49)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(346, 21)
        Me.cboCampo.TabIndex = 12
        '
        'lblFiltrar
        '
        Me.lblFiltrar.AutoSize = True
        Me.lblFiltrar.Location = New System.Drawing.Point(14, 52)
        Me.lblFiltrar.Name = "lblFiltrar"
        Me.lblFiltrar.Size = New System.Drawing.Size(71, 13)
        Me.lblFiltrar.TabIndex = 11
        Me.lblFiltrar.Text = "Pesquisar por"
        '
        'PesquisaDinamica2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboCampo)
        Me.Controls.Add(Me.lblFiltrar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvDados)
        Me.Name = "PesquisaDinamica2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents optPesquisa2 As System.Windows.Forms.RadioButton
    Friend WithEvents optPesquisa1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents cboCampo As System.Windows.Forms.ComboBox
    Friend WithEvents lblFiltrar As System.Windows.Forms.Label
End Class
