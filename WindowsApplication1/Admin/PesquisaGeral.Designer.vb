<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisaGeral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PesquisaGeral))
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.optPesquisa1 = New System.Windows.Forms.RadioButton()
        Me.optPesquisa2 = New System.Windows.Forms.RadioButton()
        Me.btnPesquisarTudo = New System.Windows.Forms.Button()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.lblFiltrar = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        Me.lblTabelaView = New System.Windows.Forms.Label()
        Me.chkFiltradoEmpresa = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(8, 89)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(804, 287)
        Me.dgvDados.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(656, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(737, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'optPesquisa1
        '
        Me.optPesquisa1.AutoSize = True
        Me.optPesquisa1.Checked = True
        Me.optPesquisa1.Location = New System.Drawing.Point(8, 5)
        Me.optPesquisa1.Name = "optPesquisa1"
        Me.optPesquisa1.Size = New System.Drawing.Size(109, 17)
        Me.optPesquisa1.TabIndex = 3
        Me.optPesquisa1.TabStop = True
        Me.optPesquisa1.Text = "Começando por..."
        Me.optPesquisa1.UseVisualStyleBackColor = True
        '
        'optPesquisa2
        '
        Me.optPesquisa2.AutoSize = True
        Me.optPesquisa2.Location = New System.Drawing.Point(134, 5)
        Me.optPesquisa2.Name = "optPesquisa2"
        Me.optPesquisa2.Size = New System.Drawing.Size(133, 17)
        Me.optPesquisa2.TabIndex = 4
        Me.optPesquisa2.Text = "Em qualquer posição..."
        Me.optPesquisa2.UseVisualStyleBackColor = True
        '
        'btnPesquisarTudo
        '
        Me.btnPesquisarTudo.Image = CType(resources.GetObject("btnPesquisarTudo.Image"), System.Drawing.Image)
        Me.btnPesquisarTudo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPesquisarTudo.Location = New System.Drawing.Point(684, 61)
        Me.btnPesquisarTudo.Name = "btnPesquisarTudo"
        Me.btnPesquisarTudo.Size = New System.Drawing.Size(128, 23)
        Me.btnPesquisarTudo.TabIndex = 8
        Me.btnPesquisarTudo.Text = "Pesquisar Tudo"
        Me.btnPesquisarTudo.UseVisualStyleBackColor = True
        '
        'txtFiltrar
        '
        Me.txtFiltrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltrar.Location = New System.Drawing.Point(16, 61)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(500, 20)
        Me.txtFiltrar.TabIndex = 7
        '
        'lblFiltrar
        '
        Me.lblFiltrar.AutoSize = True
        Me.lblFiltrar.Location = New System.Drawing.Point(13, 35)
        Me.lblFiltrar.Name = "lblFiltrar"
        Me.lblFiltrar.Size = New System.Drawing.Size(71, 13)
        Me.lblFiltrar.TabIndex = 6
        Me.lblFiltrar.Text = "Pesquisar por"
        '
        'btnExcel
        '
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(8, 383)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(37, 23)
        Me.btnExcel.TabIndex = 9
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'cboCampo
        '
        Me.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Location = New System.Drawing.Point(90, 32)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(346, 21)
        Me.cboCampo.TabIndex = 10
        '
        'lblTabelaView
        '
        Me.lblTabelaView.AutoSize = True
        Me.lblTabelaView.Location = New System.Drawing.Point(51, 387)
        Me.lblTabelaView.Name = "lblTabelaView"
        Me.lblTabelaView.Size = New System.Drawing.Size(74, 13)
        Me.lblTabelaView.TabIndex = 11
        Me.lblTabelaView.Text = "Tabela/View: "
        '
        'chkFiltradoEmpresa
        '
        Me.chkFiltradoEmpresa.AutoSize = True
        Me.chkFiltradoEmpresa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFiltradoEmpresa.Enabled = False
        Me.chkFiltradoEmpresa.Location = New System.Drawing.Point(460, 385)
        Me.chkFiltradoEmpresa.Name = "chkFiltradoEmpresa"
        Me.chkFiltradoEmpresa.Size = New System.Drawing.Size(122, 17)
        Me.chkFiltradoEmpresa.TabIndex = 12
        Me.chkFiltradoEmpresa.Text = "Filtrado por Empresa"
        Me.chkFiltradoEmpresa.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(764, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(48, 48)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PesquisaGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.chkFiltradoEmpresa)
        Me.Controls.Add(Me.lblTabelaView)
        Me.Controls.Add(Me.cboCampo)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnPesquisarTudo)
        Me.Controls.Add(Me.txtFiltrar)
        Me.Controls.Add(Me.lblFiltrar)
        Me.Controls.Add(Me.optPesquisa2)
        Me.Controls.Add(Me.optPesquisa1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvDados)
        Me.Name = "PesquisaGeral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents optPesquisa1 As System.Windows.Forms.RadioButton
    Friend WithEvents optPesquisa2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnPesquisarTudo As System.Windows.Forms.Button
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents lblFiltrar As System.Windows.Forms.Label
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents cboCampo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTabelaView As System.Windows.Forms.Label
    Friend WithEvents chkFiltradoEmpresa As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As Button
End Class
