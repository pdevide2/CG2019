<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoVenda_Edicao
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
        Dim ID_ROMANEIOLabel As System.Windows.Forms.Label
        Dim UNIQUE_KEYIDLabel As System.Windows.Forms.Label
        Dim ID_CHIPLabel As System.Windows.Forms.Label
        Dim SIMIDLabel As System.Windows.Forms.Label
        Dim ID_OPERADORALabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoVenda_Edicao))
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtIdEquipamento = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.btnEditaSalva = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.chkCancelado = New System.Windows.Forms.CheckBox()
        Me.txtDataCadastro = New System.Windows.Forms.TextBox()
        Me.txtDataBaixa = New System.Windows.Forms.TextBox()
        Me.txtUltimaAlteracao = New System.Windows.Forms.TextBox()
        ID_ROMANEIOLabel = New System.Windows.Forms.Label()
        UNIQUE_KEYIDLabel = New System.Windows.Forms.Label()
        ID_CHIPLabel = New System.Windows.Forms.Label()
        SIMIDLabel = New System.Windows.Forms.Label()
        ID_OPERADORALabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ID_ROMANEIOLabel
        '
        ID_ROMANEIOLabel.AutoSize = True
        ID_ROMANEIOLabel.Location = New System.Drawing.Point(14, 19)
        ID_ROMANEIOLabel.Name = "ID_ROMANEIOLabel"
        ID_ROMANEIOLabel.Size = New System.Drawing.Size(53, 13)
        ID_ROMANEIOLabel.TabIndex = 1
        ID_ROMANEIOLabel.Text = "Pedido nº"
        '
        'UNIQUE_KEYIDLabel
        '
        UNIQUE_KEYIDLabel.AutoSize = True
        UNIQUE_KEYIDLabel.Location = New System.Drawing.Point(224, 19)
        UNIQUE_KEYIDLabel.Name = "UNIQUE_KEYIDLabel"
        UNIQUE_KEYIDLabel.Size = New System.Drawing.Size(37, 13)
        UNIQUE_KEYIDLabel.TabIndex = 3
        UNIQUE_KEYIDLabel.Text = "Status"
        '
        'ID_CHIPLabel
        '
        ID_CHIPLabel.AutoSize = True
        ID_CHIPLabel.Location = New System.Drawing.Point(14, 45)
        ID_CHIPLabel.Name = "ID_CHIPLabel"
        ID_CHIPLabel.Size = New System.Drawing.Size(49, 13)
        ID_CHIPLabel.TabIndex = 5
        ID_CHIPLabel.Text = "Id Equip."
        '
        'SIMIDLabel
        '
        SIMIDLabel.AutoSize = True
        SIMIDLabel.Location = New System.Drawing.Point(230, 45)
        SIMIDLabel.Name = "SIMIDLabel"
        SIMIDLabel.Size = New System.Drawing.Size(31, 13)
        SIMIDLabel.TabIndex = 7
        SIMIDLabel.Text = "Série"
        '
        'ID_OPERADORALabel
        '
        ID_OPERADORALabel.AutoSize = True
        ID_OPERADORALabel.Location = New System.Drawing.Point(14, 71)
        ID_OPERADORALabel.Name = "ID_OPERADORALabel"
        ID_OPERADORALabel.Size = New System.Drawing.Size(42, 13)
        ID_OPERADORALabel.TabIndex = 9
        ID_OPERADORALabel.Text = "Modelo"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(14, 98)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(30, 13)
        Label1.TabIndex = 42
        Label1.Text = "Qtde"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(305, 98)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(69, 13)
        Label2.TabIndex = 44
        Label2.Text = "Preço Venda"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(14, 124)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(75, 13)
        Label3.TabIndex = 47
        Label3.Text = "Data Cadastro"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(315, 124)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(59, 13)
        Label4.TabIndex = 49
        Label4.Text = "Data Baixa"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(14, 150)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(71, 13)
        Label5.TabIndex = 51
        Label5.Text = "Últ. Alteração"
        '
        'txtPedido
        '
        Me.txtPedido.Enabled = False
        Me.txtPedido.Location = New System.Drawing.Point(96, 16)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.ReadOnly = True
        Me.txtPedido.Size = New System.Drawing.Size(106, 20)
        Me.txtPedido.TabIndex = 2
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Location = New System.Drawing.Point(266, 16)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(44, 20)
        Me.txtStatus.TabIndex = 4
        '
        'txtIdEquipamento
        '
        Me.txtIdEquipamento.Enabled = False
        Me.txtIdEquipamento.Location = New System.Drawing.Point(96, 42)
        Me.txtIdEquipamento.Name = "txtIdEquipamento"
        Me.txtIdEquipamento.ReadOnly = True
        Me.txtIdEquipamento.Size = New System.Drawing.Size(69, 20)
        Me.txtIdEquipamento.TabIndex = 6
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Location = New System.Drawing.Point(266, 42)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(248, 20)
        Me.txtSerie.TabIndex = 8
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Location = New System.Drawing.Point(96, 68)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(419, 20)
        Me.txtModelo.TabIndex = 10
        '
        'btnEditaSalva
        '
        Me.btnEditaSalva.Image = Global.WinCG.My.Resources.Resources.save16B
        Me.btnEditaSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditaSalva.Location = New System.Drawing.Point(371, 286)
        Me.btnEditaSalva.Name = "btnEditaSalva"
        Me.btnEditaSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnEditaSalva.TabIndex = 41
        Me.btnEditaSalva.Text = "Salvar"
        Me.btnEditaSalva.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.Location = New System.Drawing.Point(447, 286)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 39
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'txtQtde
        '
        Me.txtQtde.Enabled = False
        Me.txtQtde.Location = New System.Drawing.Point(96, 95)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.ReadOnly = True
        Me.txtQtde.Size = New System.Drawing.Size(69, 20)
        Me.txtQtde.TabIndex = 43
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Enabled = False
        Me.txtPrecoVenda.Location = New System.Drawing.Point(380, 95)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.ReadOnly = True
        Me.txtPrecoVenda.Size = New System.Drawing.Size(134, 20)
        Me.txtPrecoVenda.TabIndex = 45
        '
        'chkCancelado
        '
        Me.chkCancelado.AutoSize = True
        Me.chkCancelado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCancelado.Enabled = False
        Me.chkCancelado.Location = New System.Drawing.Point(432, 18)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(83, 17)
        Me.chkCancelado.TabIndex = 46
        Me.chkCancelado.Text = "Cancelado?"
        Me.chkCancelado.UseVisualStyleBackColor = True
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.Enabled = False
        Me.txtDataCadastro.Location = New System.Drawing.Point(96, 121)
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.ReadOnly = True
        Me.txtDataCadastro.Size = New System.Drawing.Size(134, 20)
        Me.txtDataCadastro.TabIndex = 48
        '
        'txtDataBaixa
        '
        Me.txtDataBaixa.Enabled = False
        Me.txtDataBaixa.Location = New System.Drawing.Point(381, 121)
        Me.txtDataBaixa.Name = "txtDataBaixa"
        Me.txtDataBaixa.ReadOnly = True
        Me.txtDataBaixa.Size = New System.Drawing.Size(134, 20)
        Me.txtDataBaixa.TabIndex = 50
        '
        'txtUltimaAlteracao
        '
        Me.txtUltimaAlteracao.Enabled = False
        Me.txtUltimaAlteracao.Location = New System.Drawing.Point(96, 147)
        Me.txtUltimaAlteracao.Name = "txtUltimaAlteracao"
        Me.txtUltimaAlteracao.ReadOnly = True
        Me.txtUltimaAlteracao.Size = New System.Drawing.Size(134, 20)
        Me.txtUltimaAlteracao.TabIndex = 52
        '
        'PedidoVenda_Edicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 314)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.txtUltimaAlteracao)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.txtDataBaixa)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.txtDataCadastro)
        Me.Controls.Add(Me.chkCancelado)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtPrecoVenda)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.btnEditaSalva)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(ID_ROMANEIOLabel)
        Me.Controls.Add(Me.txtPedido)
        Me.Controls.Add(UNIQUE_KEYIDLabel)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(ID_CHIPLabel)
        Me.Controls.Add(Me.txtIdEquipamento)
        Me.Controls.Add(SIMIDLabel)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(ID_OPERADORALabel)
        Me.Controls.Add(Me.txtModelo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "PedidoVenda_Edicao"
        Me.Text = "Pedido Venda (Visualizar/Editar)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtIdEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnEditaSalva As System.Windows.Forms.Button
    Friend WithEvents txtQtde As TextBox
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents chkCancelado As CheckBox
    Friend WithEvents txtDataCadastro As TextBox
    Friend WithEvents txtDataBaixa As TextBox
    Friend WithEvents txtUltimaAlteracao As TextBox
End Class
