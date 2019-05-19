<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estoque_equipamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estoque_equipamento))
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPesqLoja = New System.Windows.Forms.Button()
        Me.txtDescLoja = New System.Windows.Forms.TextBox()
        Me.txtIdLoja = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDescArea = New System.Windows.Forms.TextBox()
        Me.txtIdArea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMatriz = New System.Windows.Forms.CheckBox()
        Me.chkQuarentena = New System.Windows.Forms.CheckBox()
        Me.chkInativo = New System.Windows.Forms.CheckBox()
        Me.chkDevolveu = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDescTransito = New System.Windows.Forms.TextBox()
        Me.txtIdTransito = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radFisica = New System.Windows.Forms.RadioButton()
        Me.radAmbos = New System.Windows.Forms.RadioButton()
        Me.radNaoFisica = New System.Windows.Forms.RadioButton()
        Me.radLoja = New System.Windows.Forms.RadioButton()
        Me.radLojaTransito = New System.Windows.Forms.RadioButton()
        Me.radTransito = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkAssistencia = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblTotalRegistros = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PesqFK1 = New WinCG.PesqFK()
        Me.PesqFK2 = New WinCG.PesqFK()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(9, 12)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(1284, 440)
        Me.dgvDados.TabIndex = 0
        '
        'btnExcel
        '
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcel.Location = New System.Drawing.Point(10, 511)
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
        Me.btnRefresh.Location = New System.Drawing.Point(12, 556)
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
        Me.btnLimpar.Location = New System.Drawing.Point(10, 465)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(108, 40)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "        Limpar Filtro"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(182, 488)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 20)
        Me.TextBox1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Data"
        '
        'btnPesqLoja
        '
        Me.btnPesqLoja.Image = CType(resources.GetObject("btnPesqLoja.Image"), System.Drawing.Image)
        Me.btnPesqLoja.Location = New System.Drawing.Point(494, 512)
        Me.btnPesqLoja.Name = "btnPesqLoja"
        Me.btnPesqLoja.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqLoja.TabIndex = 39
        Me.btnPesqLoja.UseVisualStyleBackColor = True
        '
        'txtDescLoja
        '
        Me.txtDescLoja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescLoja.Enabled = False
        Me.txtDescLoja.Location = New System.Drawing.Point(259, 513)
        Me.txtDescLoja.Name = "txtDescLoja"
        Me.txtDescLoja.Size = New System.Drawing.Size(233, 20)
        Me.txtDescLoja.TabIndex = 38
        '
        'txtIdLoja
        '
        Me.txtIdLoja.Enabled = False
        Me.txtIdLoja.Location = New System.Drawing.Point(182, 514)
        Me.txtIdLoja.Name = "txtIdLoja"
        Me.txtIdLoja.Size = New System.Drawing.Size(74, 20)
        Me.txtIdLoja.TabIndex = 37
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(134, 517)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(27, 13)
        Me.lblStatus.TabIndex = 36
        Me.lblStatus.Text = "Loja"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(494, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDescArea
        '
        Me.txtDescArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescArea.Enabled = False
        Me.txtDescArea.Location = New System.Drawing.Point(259, 541)
        Me.txtDescArea.Name = "txtDescArea"
        Me.txtDescArea.Size = New System.Drawing.Size(233, 20)
        Me.txtDescArea.TabIndex = 44
        '
        'txtIdArea
        '
        Me.txtIdArea.Enabled = False
        Me.txtIdArea.Location = New System.Drawing.Point(182, 541)
        Me.txtIdArea.Name = "txtIdArea"
        Me.txtIdArea.Size = New System.Drawing.Size(74, 20)
        Me.txtIdArea.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 545)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Área"
        '
        'chkMatriz
        '
        Me.chkMatriz.AutoSize = True
        Me.chkMatriz.Location = New System.Drawing.Point(6, 23)
        Me.chkMatriz.Name = "chkMatriz"
        Me.chkMatriz.Size = New System.Drawing.Size(54, 17)
        Me.chkMatriz.TabIndex = 46
        Me.chkMatriz.Text = "Matriz"
        Me.chkMatriz.UseVisualStyleBackColor = True
        '
        'chkQuarentena
        '
        Me.chkQuarentena.AutoSize = True
        Me.chkQuarentena.Location = New System.Drawing.Point(6, 43)
        Me.chkQuarentena.Name = "chkQuarentena"
        Me.chkQuarentena.Size = New System.Drawing.Size(82, 17)
        Me.chkQuarentena.TabIndex = 47
        Me.chkQuarentena.Text = "Quarentena"
        Me.chkQuarentena.UseVisualStyleBackColor = True
        '
        'chkInativo
        '
        Me.chkInativo.AutoSize = True
        Me.chkInativo.Location = New System.Drawing.Point(6, 63)
        Me.chkInativo.Name = "chkInativo"
        Me.chkInativo.Size = New System.Drawing.Size(58, 17)
        Me.chkInativo.TabIndex = 48
        Me.chkInativo.Text = "Inativo"
        Me.chkInativo.UseVisualStyleBackColor = True
        '
        'chkDevolveu
        '
        Me.chkDevolveu.AutoSize = True
        Me.chkDevolveu.Location = New System.Drawing.Point(6, 83)
        Me.chkDevolveu.Name = "chkDevolveu"
        Me.chkDevolveu.Size = New System.Drawing.Size(129, 17)
        Me.chkDevolveu.TabIndex = 49
        Me.chkDevolveu.Text = "Devolveu Fornecedor"
        Me.chkDevolveu.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(494, 565)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 23)
        Me.Button2.TabIndex = 56
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDescTransito
        '
        Me.txtDescTransito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescTransito.Enabled = False
        Me.txtDescTransito.Location = New System.Drawing.Point(259, 566)
        Me.txtDescTransito.Name = "txtDescTransito"
        Me.txtDescTransito.Size = New System.Drawing.Size(233, 20)
        Me.txtDescTransito.TabIndex = 55
        '
        'txtIdTransito
        '
        Me.txtIdTransito.Enabled = False
        Me.txtIdTransito.Location = New System.Drawing.Point(182, 567)
        Me.txtIdTransito.Name = "txtIdTransito"
        Me.txtIdTransito.Size = New System.Drawing.Size(74, 20)
        Me.txtIdTransito.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 570)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Transito"
        '
        'radFisica
        '
        Me.radFisica.AutoSize = True
        Me.radFisica.Location = New System.Drawing.Point(130, 19)
        Me.radFisica.Name = "radFisica"
        Me.radFisica.Size = New System.Drawing.Size(77, 17)
        Me.radFisica.TabIndex = 51
        Me.radFisica.Text = "Loja Física"
        Me.radFisica.UseVisualStyleBackColor = True
        '
        'radAmbos
        '
        Me.radAmbos.AutoSize = True
        Me.radAmbos.Checked = True
        Me.radAmbos.Location = New System.Drawing.Point(14, 19)
        Me.radAmbos.Name = "radAmbos"
        Me.radAmbos.Size = New System.Drawing.Size(111, 17)
        Me.radAmbos.TabIndex = 50
        Me.radAmbos.TabStop = True
        Me.radAmbos.Text = "Física/Não Física"
        Me.radAmbos.UseVisualStyleBackColor = True
        '
        'radNaoFisica
        '
        Me.radNaoFisica.AutoSize = True
        Me.radNaoFisica.Location = New System.Drawing.Point(212, 19)
        Me.radNaoFisica.Name = "radNaoFisica"
        Me.radNaoFisica.Size = New System.Drawing.Size(77, 17)
        Me.radNaoFisica.TabIndex = 52
        Me.radNaoFisica.Text = "Não Física"
        Me.radNaoFisica.UseVisualStyleBackColor = True
        '
        'radLoja
        '
        Me.radLoja.AutoSize = True
        Me.radLoja.Location = New System.Drawing.Point(131, 18)
        Me.radLoja.Name = "radLoja"
        Me.radLoja.Size = New System.Drawing.Size(45, 17)
        Me.radLoja.TabIndex = 58
        Me.radLoja.Text = "Loja"
        Me.radLoja.UseVisualStyleBackColor = True
        '
        'radLojaTransito
        '
        Me.radLojaTransito.AutoSize = True
        Me.radLojaTransito.Checked = True
        Me.radLojaTransito.Location = New System.Drawing.Point(15, 18)
        Me.radLojaTransito.Name = "radLojaTransito"
        Me.radLojaTransito.Size = New System.Drawing.Size(88, 17)
        Me.radLojaTransito.TabIndex = 57
        Me.radLojaTransito.TabStop = True
        Me.radLojaTransito.Text = "Loja/Transito"
        Me.radLojaTransito.UseVisualStyleBackColor = True
        '
        'radTransito
        '
        Me.radTransito.AutoSize = True
        Me.radTransito.Location = New System.Drawing.Point(213, 18)
        Me.radTransito.Name = "radTransito"
        Me.radTransito.Size = New System.Drawing.Size(63, 17)
        Me.radTransito.TabIndex = 59
        Me.radTransito.Text = "Transito"
        Me.radTransito.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radAmbos)
        Me.GroupBox1.Controls.Add(Me.radNaoFisica)
        Me.GroupBox1.Controls.Add(Me.radFisica)
        Me.GroupBox1.Location = New System.Drawing.Point(563, 488)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 43)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Loja"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radTransito)
        Me.GroupBox2.Controls.Add(Me.radLoja)
        Me.GroupBox2.Controls.Add(Me.radLojaTransito)
        Me.GroupBox2.Location = New System.Drawing.Point(563, 549)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 43)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Local de Estoque"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkAssistencia)
        Me.GroupBox3.Controls.Add(Me.chkMatriz)
        Me.GroupBox3.Controls.Add(Me.chkQuarentena)
        Me.GroupBox3.Controls.Add(Me.chkInativo)
        Me.GroupBox3.Controls.Add(Me.chkDevolveu)
        Me.GroupBox3.Location = New System.Drawing.Point(904, 492)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 103)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Exibir"
        '
        'chkAssistencia
        '
        Me.chkAssistencia.AutoSize = True
        Me.chkAssistencia.Location = New System.Drawing.Point(142, 23)
        Me.chkAssistencia.Name = "chkAssistencia"
        Me.chkAssistencia.Size = New System.Drawing.Size(121, 17)
        Me.chkAssistencia.TabIndex = 50
        Me.chkAssistencia.Text = "Assistência Tecnica"
        Me.chkAssistencia.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(1185, 552)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 40)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Fechar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.AutoSize = True
        Me.lblTotalRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRegistros.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTotalRegistros.Location = New System.Drawing.Point(1069, 457)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(12, 17)
        Me.lblTotalRegistros.TabIndex = 64
        Me.lblTotalRegistros.Text = "."
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(551, 457)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 66
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PesqFK1
        '
        Me.PesqFK1.CampoDesc = "DESC_CARGO"
        Me.PesqFK1.CampoId = "ID_CARGO"
        Me.PesqFK1.ColunasFiltro = "DESC_CARGO"
        Me.PesqFK1.LabelBuscaDesc = "Descrição"
        Me.PesqFK1.LabelBuscaId = "Código"
        Me.PesqFK1.LabelPesqFK = "Usuário"
        Me.PesqFK1.ListaCampos = "DESC_CARGO,ID_CARGO"
        Me.PesqFK1.Location = New System.Drawing.Point(135, 457)
        Me.PesqFK1.Name = "PesqFK1"
        Me.PesqFK1.ObjModelFk = Nothing
        Me.PesqFK1.Size = New System.Drawing.Size(399, 28)
        Me.PesqFK1.Tabela = "CG_CARGO"
        Me.PesqFK1.TabIndex = 65
        Me.PesqFK1.TituloTela = "Pesquisa de Cargos"
        Me.PesqFK1.View = "CG_CARGO"
        '
        'PesqFK2
        '
        Me.PesqFK2.CampoDesc = "DESC_CARGO"
        Me.PesqFK2.CampoId = "ID_CARGO"
        Me.PesqFK2.ColunasFiltro = "DESC_CARGO"
        Me.PesqFK2.LabelBuscaDesc = "Descrição"
        Me.PesqFK2.LabelBuscaId = "Código"
        Me.PesqFK2.LabelPesqFK = "Usuário"
        Me.PesqFK2.ListaCampos = "DESC_CARGO,ID_CARGO"
        Me.PesqFK2.Location = New System.Drawing.Point(632, 458)
        Me.PesqFK2.Name = "PesqFK2"
        Me.PesqFK2.ObjModelFk = Nothing
        Me.PesqFK2.Size = New System.Drawing.Size(399, 28)
        Me.PesqFK2.Tabela = "CG_CARGO"
        Me.PesqFK2.TabIndex = 67
        Me.PesqFK2.TituloTela = "Pesquisa de Cargos"
        Me.PesqFK2.View = "CG_CARGO"
        '
        'Estoque_equipamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 598)
        Me.Controls.Add(Me.PesqFK2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PesqFK1)
        Me.Controls.Add(Me.lblTotalRegistros)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtDescTransito)
        Me.Controls.Add(Me.txtIdTransito)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDescArea)
        Me.Controls.Add(Me.txtIdArea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
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
        Me.Text = "Consulta de Estoque de Equipamento (POS)"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPesqLoja As System.Windows.Forms.Button
    Friend WithEvents txtDescLoja As System.Windows.Forms.TextBox
    Friend WithEvents txtIdLoja As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtDescArea As System.Windows.Forms.TextBox
    Friend WithEvents txtIdArea As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkMatriz As System.Windows.Forms.CheckBox
    Friend WithEvents chkQuarentena As System.Windows.Forms.CheckBox
    Friend WithEvents chkInativo As System.Windows.Forms.CheckBox
    Friend WithEvents chkDevolveu As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDescTransito As System.Windows.Forms.TextBox
    Friend WithEvents txtIdTransito As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radFisica As System.Windows.Forms.RadioButton
    Friend WithEvents radAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents radNaoFisica As System.Windows.Forms.RadioButton
    Friend WithEvents radLoja As System.Windows.Forms.RadioButton
    Friend WithEvents radLojaTransito As System.Windows.Forms.RadioButton
    Friend WithEvents radTransito As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents chkAssistencia As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotalRegistros As System.Windows.Forms.Label
    Friend WithEvents PesqFK1 As WinCG.PesqFK
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PesqFK2 As WinCG.PesqFK
End Class
