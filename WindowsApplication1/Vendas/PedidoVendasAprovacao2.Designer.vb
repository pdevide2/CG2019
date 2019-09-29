<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoVendasAprovacao2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoVendasAprovacao2))
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbReprovar = New System.Windows.Forms.RadioButton()
        Me.rbAprovar = New System.Windows.Forms.RadioButton()
        Me.rbAnalise = New System.Windows.Forms.RadioButton()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtIdEquipamento = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.txtDataCadastro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescEquipamento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescTipoEquipamento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.lblQtPedido = New System.Windows.Forms.Label()
        Me.lblQtItens = New System.Windows.Forms.Label()
        Me.btnAprovaTudo = New System.Windows.Forms.Button()
        Me.btnReprovaTudo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(167, 5)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(182, 370)
        Me.dgvDados.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOk.Image = Global.WinCG.My.Resources.Resources.save16
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(699, 375)
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
        Me.btnCancel.Location = New System.Drawing.Point(598, 375)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(358, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pedido #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(618, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(361, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Equipamento ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(621, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Modelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Série"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(568, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Preço Venda"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbReprovar)
        Me.GroupBox1.Controls.Add(Me.rbAprovar)
        Me.GroupBox1.Controls.Add(Me.rbAnalise)
        Me.GroupBox1.Location = New System.Drawing.Point(367, 240)
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
        'txtPedido
        '
        Me.txtPedido.Enabled = False
        Me.txtPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtPedido.Location = New System.Drawing.Point(451, 5)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtPedido.TabIndex = 11
        '
        'txtItem
        '
        Me.txtItem.Enabled = False
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtItem.Location = New System.Drawing.Point(697, 5)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(45, 20)
        Me.txtItem.TabIndex = 12
        '
        'txtIdEquipamento
        '
        Me.txtIdEquipamento.Enabled = False
        Me.txtIdEquipamento.Location = New System.Drawing.Point(451, 45)
        Me.txtIdEquipamento.Name = "txtIdEquipamento"
        Me.txtIdEquipamento.Size = New System.Drawing.Size(75, 20)
        Me.txtIdEquipamento.TabIndex = 13
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Location = New System.Drawing.Point(697, 45)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(199, 20)
        Me.txtModelo.TabIndex = 14
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Location = New System.Drawing.Point(451, 202)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtSerie.TabIndex = 15
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Enabled = False
        Me.txtPrecoVenda.Location = New System.Drawing.Point(644, 202)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(71, 20)
        Me.txtPrecoVenda.TabIndex = 16
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.Enabled = False
        Me.txtDataCadastro.Location = New System.Drawing.Point(778, 202)
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.Size = New System.Drawing.Size(118, 20)
        Me.txtDataCadastro.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(729, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cadastro"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(451, 87)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(445, 20)
        Me.txtCliente.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(364, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Cliente"
        '
        'txtDescEquipamento
        '
        Me.txtDescEquipamento.Enabled = False
        Me.txtDescEquipamento.Location = New System.Drawing.Point(451, 128)
        Me.txtDescEquipamento.Name = "txtDescEquipamento"
        Me.txtDescEquipamento.Size = New System.Drawing.Size(445, 20)
        Me.txtDescEquipamento.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(364, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Desc. Equipto"
        '
        'txtDescTipoEquipamento
        '
        Me.txtDescTipoEquipamento.Enabled = False
        Me.txtDescTipoEquipamento.Location = New System.Drawing.Point(451, 167)
        Me.txtDescTipoEquipamento.Name = "txtDescTipoEquipamento"
        Me.txtDescTipoEquipamento.Size = New System.Drawing.Size(445, 20)
        Me.txtDescTipoEquipamento.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(364, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Tipo Equipto"
        '
        'dgvPedido
        '
        Me.dgvPedido.AllowUserToAddRows = False
        Me.dgvPedido.AllowUserToDeleteRows = False
        Me.dgvPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Location = New System.Drawing.Point(12, 5)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.Size = New System.Drawing.Size(151, 370)
        Me.dgvPedido.TabIndex = 25
        '
        'lblQtPedido
        '
        Me.lblQtPedido.AutoSize = True
        Me.lblQtPedido.Location = New System.Drawing.Point(13, 385)
        Me.lblQtPedido.Name = "lblQtPedido"
        Me.lblQtPedido.Size = New System.Drawing.Size(80, 13)
        Me.lblQtPedido.TabIndex = 26
        Me.lblQtPedido.Text = "Qtde Pedidos 0"
        '
        'lblQtItens
        '
        Me.lblQtItens.AutoSize = True
        Me.lblQtItens.Location = New System.Drawing.Point(164, 385)
        Me.lblQtItens.Name = "lblQtItens"
        Me.lblQtItens.Size = New System.Drawing.Size(116, 13)
        Me.lblQtItens.TabIndex = 27
        Me.lblQtItens.Text = "Qtde Itens do Pedido 0"
        '
        'btnAprovaTudo
        '
        Me.btnAprovaTudo.Image = CType(resources.GetObject("btnAprovaTudo.Image"), System.Drawing.Image)
        Me.btnAprovaTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAprovaTudo.Location = New System.Drawing.Point(736, 240)
        Me.btnAprovaTudo.Name = "btnAprovaTudo"
        Me.btnAprovaTudo.Size = New System.Drawing.Size(159, 55)
        Me.btnAprovaTudo.TabIndex = 28
        Me.btnAprovaTudo.Text = "Marcar todos itens como Aprovados"
        Me.btnAprovaTudo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAprovaTudo.UseVisualStyleBackColor = True
        '
        'btnReprovaTudo
        '
        Me.btnReprovaTudo.Image = CType(resources.GetObject("btnReprovaTudo.Image"), System.Drawing.Image)
        Me.btnReprovaTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReprovaTudo.Location = New System.Drawing.Point(736, 300)
        Me.btnReprovaTudo.Name = "btnReprovaTudo"
        Me.btnReprovaTudo.Size = New System.Drawing.Size(159, 55)
        Me.btnReprovaTudo.TabIndex = 29
        Me.btnReprovaTudo.Text = "Marcar todos itens como Reprovados"
        Me.btnReprovaTudo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReprovaTudo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(800, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PedidoVendasAprovacao2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 410)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReprovaTudo)
        Me.Controls.Add(Me.btnAprovaTudo)
        Me.Controls.Add(Me.lblQtItens)
        Me.Controls.Add(Me.lblQtPedido)
        Me.Controls.Add(Me.dgvPedido)
        Me.Controls.Add(Me.txtDescTipoEquipamento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDescEquipamento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDataCadastro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPrecoVenda)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtIdEquipamento)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.txtPedido)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dgvDados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PedidoVendasAprovacao2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aprovação de Pedidos de Venda em Análise"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbReprovar As RadioButton
    Friend WithEvents rbAprovar As RadioButton
    Friend WithEvents rbAnalise As RadioButton
    Friend WithEvents txtPedido As TextBox
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtIdEquipamento As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents txtDataCadastro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescEquipamento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescTipoEquipamento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvPedido As DataGridView
    Friend WithEvents lblQtPedido As Label
    Friend WithEvents lblQtItens As Label
    Friend WithEvents btnAprovaTudo As Button
    Friend WithEvents btnReprovaTudo As Button
    Friend WithEvents Button1 As Button
End Class
