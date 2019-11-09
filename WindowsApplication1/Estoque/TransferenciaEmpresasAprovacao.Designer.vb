<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferenciaEmpresasAprovacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferenciaEmpresasAprovacao))
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbReprovar = New System.Windows.Forms.RadioButton()
        Me.rbAprovar = New System.Windows.Forms.RadioButton()
        Me.rbAnalise = New System.Windows.Forms.RadioButton()
        Me.txtRomaneio = New System.Windows.Forms.TextBox()
        Me.txtSimid = New System.Windows.Forms.TextBox()
        Me.txtOperadora = New System.Windows.Forms.TextBox()
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.lblQtPedido = New System.Windows.Forms.Label()
        Me.lblQtItens = New System.Windows.Forms.Label()
        Me.btnAprovaTudo = New System.Windows.Forms.Button()
        Me.btnReprovaTudo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescEquip = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbReprovar2 = New System.Windows.Forms.RadioButton()
        Me.rbAprovar2 = New System.Windows.Forms.RadioButton()
        Me.rbAnalise2 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(171, 33)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(182, 177)
        Me.dgvDados.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOk.Image = Global.WinCG.My.Resources.Resources.save16
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(699, 427)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Confirmar"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Image = Global.WinCG.My.Resources.Resources.Undo16
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(598, 427)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Romaneio nº"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SIMID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(621, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Operadora"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbReprovar)
        Me.GroupBox1.Controls.Add(Me.rbAprovar)
        Me.GroupBox1.Controls.Add(Me.rbAnalise)
        Me.GroupBox1.Location = New System.Drawing.Point(362, 326)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 63)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status do Item"
        '
        'rbReprovar
        '
        Me.rbReprovar.AutoSize = True
        Me.rbReprovar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbReprovar.Location = New System.Drawing.Point(223, 28)
        Me.rbReprovar.Name = "rbReprovar"
        Me.rbReprovar.Size = New System.Drawing.Size(93, 21)
        Me.rbReprovar.TabIndex = 2
        Me.rbReprovar.TabStop = True
        Me.rbReprovar.Text = "Reprovar"
        Me.rbReprovar.UseVisualStyleBackColor = True
        '
        'rbAprovar
        '
        Me.rbAprovar.AutoSize = True
        Me.rbAprovar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAprovar.Location = New System.Drawing.Point(124, 28)
        Me.rbAprovar.Name = "rbAprovar"
        Me.rbAprovar.Size = New System.Drawing.Size(83, 21)
        Me.rbAprovar.TabIndex = 1
        Me.rbAprovar.TabStop = True
        Me.rbAprovar.Text = "Aprovar"
        Me.rbAprovar.UseVisualStyleBackColor = True
        '
        'rbAnalise
        '
        Me.rbAnalise.AutoSize = True
        Me.rbAnalise.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAnalise.Location = New System.Drawing.Point(6, 28)
        Me.rbAnalise.Name = "rbAnalise"
        Me.rbAnalise.Size = New System.Drawing.Size(106, 21)
        Me.rbAnalise.TabIndex = 0
        Me.rbAnalise.TabStop = True
        Me.rbAnalise.Text = "Em Análise"
        Me.rbAnalise.UseVisualStyleBackColor = True
        '
        'txtRomaneio
        '
        Me.txtRomaneio.Enabled = False
        Me.txtRomaneio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRomaneio.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtRomaneio.Location = New System.Drawing.Point(449, 29)
        Me.txtRomaneio.Name = "txtRomaneio"
        Me.txtRomaneio.Size = New System.Drawing.Size(100, 20)
        Me.txtRomaneio.TabIndex = 11
        '
        'txtSimid
        '
        Me.txtSimid.Enabled = False
        Me.txtSimid.Location = New System.Drawing.Point(449, 69)
        Me.txtSimid.Name = "txtSimid"
        Me.txtSimid.Size = New System.Drawing.Size(136, 20)
        Me.txtSimid.TabIndex = 13
        '
        'txtOperadora
        '
        Me.txtOperadora.Enabled = False
        Me.txtOperadora.Location = New System.Drawing.Point(695, 69)
        Me.txtOperadora.Name = "txtOperadora"
        Me.txtOperadora.Size = New System.Drawing.Size(199, 20)
        Me.txtOperadora.TabIndex = 14
        '
        'dgvPedido
        '
        Me.dgvPedido.AllowUserToAddRows = False
        Me.dgvPedido.AllowUserToDeleteRows = False
        Me.dgvPedido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Location = New System.Drawing.Point(12, 33)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.Size = New System.Drawing.Size(151, 389)
        Me.dgvPedido.TabIndex = 25
        '
        'lblQtPedido
        '
        Me.lblQtPedido.AutoSize = True
        Me.lblQtPedido.Location = New System.Drawing.Point(10, 432)
        Me.lblQtPedido.Name = "lblQtPedido"
        Me.lblQtPedido.Size = New System.Drawing.Size(95, 13)
        Me.lblQtPedido.TabIndex = 26
        Me.lblQtPedido.Text = "Qtde Romaneios 0"
        '
        'lblQtItens
        '
        Me.lblQtItens.AutoSize = True
        Me.lblQtItens.Location = New System.Drawing.Point(171, 225)
        Me.lblQtItens.Name = "lblQtItens"
        Me.lblQtItens.Size = New System.Drawing.Size(134, 13)
        Me.lblQtItens.TabIndex = 27
        Me.lblQtItens.Text = "Qtde Chips do Romaneio 0"
        '
        'btnAprovaTudo
        '
        Me.btnAprovaTudo.Image = CType(resources.GetObject("btnAprovaTudo.Image"), System.Drawing.Image)
        Me.btnAprovaTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAprovaTudo.Location = New System.Drawing.Point(734, 299)
        Me.btnAprovaTudo.Name = "btnAprovaTudo"
        Me.btnAprovaTudo.Size = New System.Drawing.Size(159, 55)
        Me.btnAprovaTudo.TabIndex = 28
        Me.btnAprovaTudo.Text = "Aprovar Todos       Equipamentos"
        Me.btnAprovaTudo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAprovaTudo.UseVisualStyleBackColor = True
        '
        'btnReprovaTudo
        '
        Me.btnReprovaTudo.Image = CType(resources.GetObject("btnReprovaTudo.Image"), System.Drawing.Image)
        Me.btnReprovaTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReprovaTudo.Location = New System.Drawing.Point(734, 360)
        Me.btnReprovaTudo.Name = "btnReprovaTudo"
        Me.btnReprovaTudo.Size = New System.Drawing.Size(159, 55)
        Me.btnReprovaTudo.TabIndex = 29
        Me.btnReprovaTudo.Text = "Reprovar todos      Equipamentos"
        Me.btnReprovaTudo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReprovaTudo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(800, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(171, 245)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.Size = New System.Drawing.Size(182, 177)
        Me.dgvDados2.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(168, 432)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Qtde Equiptos do Romaneio 0"
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Location = New System.Drawing.Point(694, 245)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(199, 20)
        Me.txtModelo.TabIndex = 36
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Location = New System.Drawing.Point(448, 245)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(136, 20)
        Me.txtSerie.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(620, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Modelo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(358, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Série Equipto."
        '
        'txtDescEquip
        '
        Me.txtDescEquip.Enabled = False
        Me.txtDescEquip.Location = New System.Drawing.Point(448, 273)
        Me.txtDescEquip.Name = "txtDescEquip"
        Me.txtDescEquip.Size = New System.Drawing.Size(445, 20)
        Me.txtDescEquip.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(358, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Descr. Equipto."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbReprovar2)
        Me.GroupBox2.Controls.Add(Me.rbAprovar2)
        Me.GroupBox2.Controls.Add(Me.rbAnalise2)
        Me.GroupBox2.Location = New System.Drawing.Point(361, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 63)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status do Item"
        '
        'rbReprovar2
        '
        Me.rbReprovar2.AutoSize = True
        Me.rbReprovar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbReprovar2.Location = New System.Drawing.Point(223, 28)
        Me.rbReprovar2.Name = "rbReprovar2"
        Me.rbReprovar2.Size = New System.Drawing.Size(93, 21)
        Me.rbReprovar2.TabIndex = 2
        Me.rbReprovar2.TabStop = True
        Me.rbReprovar2.Text = "Reprovar"
        Me.rbReprovar2.UseVisualStyleBackColor = True
        '
        'rbAprovar2
        '
        Me.rbAprovar2.AutoSize = True
        Me.rbAprovar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAprovar2.Location = New System.Drawing.Point(124, 28)
        Me.rbAprovar2.Name = "rbAprovar2"
        Me.rbAprovar2.Size = New System.Drawing.Size(83, 21)
        Me.rbAprovar2.TabIndex = 1
        Me.rbAprovar2.TabStop = True
        Me.rbAprovar2.Text = "Aprovar"
        Me.rbAprovar2.UseVisualStyleBackColor = True
        '
        'rbAnalise2
        '
        Me.rbAnalise2.AutoSize = True
        Me.rbAnalise2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAnalise2.Location = New System.Drawing.Point(6, 28)
        Me.rbAnalise2.Name = "rbAnalise2"
        Me.rbAnalise2.Size = New System.Drawing.Size(106, 21)
        Me.rbAnalise2.TabIndex = 0
        Me.rbAnalise2.TabStop = True
        Me.rbAnalise2.Text = "Em Análise"
        Me.rbAnalise2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(734, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 55)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Reprovar Todos                 SIMID"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(734, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 55)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Aprovar Todos                 SIMID"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TransferenciaEmpresasAprovacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 453)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtDescEquip)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvDados2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReprovaTudo)
        Me.Controls.Add(Me.btnAprovaTudo)
        Me.Controls.Add(Me.lblQtItens)
        Me.Controls.Add(Me.lblQtPedido)
        Me.Controls.Add(Me.dgvPedido)
        Me.Controls.Add(Me.txtOperadora)
        Me.Controls.Add(Me.txtSimid)
        Me.Controls.Add(Me.txtRomaneio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dgvDados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransferenciaEmpresasAprovacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aprovação de Transferência de Estoques entre Empresas"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbReprovar As RadioButton
    Friend WithEvents rbAprovar As RadioButton
    Friend WithEvents rbAnalise As RadioButton
    Friend WithEvents txtRomaneio As TextBox
    Friend WithEvents txtSimid As TextBox
    Friend WithEvents txtOperadora As TextBox
    Friend WithEvents dgvPedido As DataGridView
    Friend WithEvents lblQtPedido As Label
    Friend WithEvents lblQtItens As Label
    Friend WithEvents btnAprovaTudo As Button
    Friend WithEvents btnReprovaTudo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvDados2 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescEquip As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbReprovar2 As RadioButton
    Friend WithEvents rbAprovar2 As RadioButton
    Friend WithEvents rbAnalise2 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
