<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoCompraPeca
    Inherits modeloCadastro

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoCompraPeca))
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnPesqMarca = New System.Windows.Forms.Button()
        Me.txtDescMarca = New System.Windows.Forms.TextBox()
        Me.txtIdMarca = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnPesqFornec = New System.Windows.Forms.Button()
        Me.txtDescFornec = New System.Windows.Forms.TextBox()
        Me.txtIdFornec = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDataCompra = New System.Windows.Forms.DateTimePicker()
        Me.txtPrevisaoEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRecebimento = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnDelItem = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(3, 14)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 13)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Pedido nº"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(61, 10)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(102, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(721, 333)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(713, 307)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Pedido"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnDelItem)
        Me.TabPage2.Controls.Add(Me.btnAddItem)
        Me.TabPage2.Controls.Add(Me.dgvDados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(713, 307)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Itens Pedido"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnPesqMarca
        '
        Me.btnPesqMarca.Enabled = False
        Me.btnPesqMarca.Image = CType(resources.GetObject("btnPesqMarca.Image"), System.Drawing.Image)
        Me.btnPesqMarca.Location = New System.Drawing.Point(507, 55)
        Me.btnPesqMarca.Name = "btnPesqMarca"
        Me.btnPesqMarca.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqMarca.TabIndex = 23
        Me.btnPesqMarca.UseVisualStyleBackColor = True
        '
        'txtDescMarca
        '
        Me.txtDescMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescMarca.Enabled = False
        Me.txtDescMarca.Location = New System.Drawing.Point(168, 56)
        Me.txtDescMarca.Name = "txtDescMarca"
        Me.txtDescMarca.Size = New System.Drawing.Size(333, 20)
        Me.txtDescMarca.TabIndex = 22
        '
        'txtIdMarca
        '
        Me.txtIdMarca.Enabled = False
        Me.txtIdMarca.Location = New System.Drawing.Point(98, 56)
        Me.txtIdMarca.Name = "txtIdMarca"
        Me.txtIdMarca.Size = New System.Drawing.Size(64, 20)
        Me.txtIdMarca.TabIndex = 21
        Me.txtIdMarca.Tag = "Código do Tipo de Equipamento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Comprador"
        '
        'btnPesqFornec
        '
        Me.btnPesqFornec.Enabled = False
        Me.btnPesqFornec.Image = CType(resources.GetObject("btnPesqFornec.Image"), System.Drawing.Image)
        Me.btnPesqFornec.Location = New System.Drawing.Point(507, 28)
        Me.btnPesqFornec.Name = "btnPesqFornec"
        Me.btnPesqFornec.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqFornec.TabIndex = 19
        Me.btnPesqFornec.UseVisualStyleBackColor = True
        '
        'txtDescFornec
        '
        Me.txtDescFornec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescFornec.Enabled = False
        Me.txtDescFornec.Location = New System.Drawing.Point(168, 29)
        Me.txtDescFornec.Name = "txtDescFornec"
        Me.txtDescFornec.Size = New System.Drawing.Size(333, 20)
        Me.txtDescFornec.TabIndex = 18
        '
        'txtIdFornec
        '
        Me.txtIdFornec.Enabled = False
        Me.txtIdFornec.Location = New System.Drawing.Point(98, 29)
        Me.txtIdFornec.Name = "txtIdFornec"
        Me.txtIdFornec.Size = New System.Drawing.Size(64, 20)
        Me.txtIdFornec.TabIndex = 17
        Me.txtIdFornec.Tag = "Código do Fornecedor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Fornecedor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescFornec)
        Me.GroupBox1.Controls.Add(Me.btnPesqMarca)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDescMarca)
        Me.GroupBox1.Controls.Add(Me.txtIdFornec)
        Me.GroupBox1.Controls.Add(Me.txtIdMarca)
        Me.GroupBox1.Controls.Add(Me.btnPesqFornec)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 100)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificação"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtRecebimento)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtPrevisaoEntrega)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtDataCompra)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 165)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data da Compra"
        '
        'txtDataCompra
        '
        Me.txtDataCompra.CustomFormat = " "
        Me.txtDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataCompra.Location = New System.Drawing.Point(164, 25)
        Me.txtDataCompra.Name = "txtDataCompra"
        Me.txtDataCompra.Size = New System.Drawing.Size(102, 20)
        Me.txtDataCompra.TabIndex = 1
        '
        'txtPrevisaoEntrega
        '
        Me.txtPrevisaoEntrega.CustomFormat = " "
        Me.txtPrevisaoEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtPrevisaoEntrega.Location = New System.Drawing.Point(164, 61)
        Me.txtPrevisaoEntrega.Name = "txtPrevisaoEntrega"
        Me.txtPrevisaoEntrega.Size = New System.Drawing.Size(102, 20)
        Me.txtPrevisaoEntrega.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Previsão de Entrega"
        '
        'txtRecebimento
        '
        Me.txtRecebimento.CustomFormat = " "
        Me.txtRecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtRecebimento.Location = New System.Drawing.Point(164, 99)
        Me.txtRecebimento.Name = "txtRecebimento"
        Me.txtRecebimento.Size = New System.Drawing.Size(102, 20)
        Me.txtRecebimento.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data de Recebimento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Observação do Pedido"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(318, 53)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(338, 88)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(348, 10)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(74, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tipo"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(628, 10)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(95, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(584, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Status"
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(17, 10)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(675, 260)
        Me.dgvDados.TabIndex = 0
        '
        'btnAddItem
        '
        Me.btnAddItem.Image = CType(resources.GetObject("btnAddItem.Image"), System.Drawing.Image)
        Me.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddItem.Location = New System.Drawing.Point(17, 276)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(91, 26)
        Me.btnAddItem.TabIndex = 1
        Me.btnAddItem.Text = "    Adicionar"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnDelItem
        '
        Me.btnDelItem.Image = CType(resources.GetObject("btnDelItem.Image"), System.Drawing.Image)
        Me.btnDelItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelItem.Location = New System.Drawing.Point(112, 276)
        Me.btnDelItem.Name = "btnDelItem"
        Me.btnDelItem.Size = New System.Drawing.Size(91, 26)
        Me.btnDelItem.TabIndex = 2
        Me.btnDelItem.Text = "Excluir"
        Me.btnDelItem.UseVisualStyleBackColor = True
        '
        'PedidoCompraPeca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 422)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "PedidoCompraPeca"
        Me.Text = "Pedido de Compra de Peças"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TextBox3, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRecebimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrevisaoEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDataCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFornec As System.Windows.Forms.TextBox
    Friend WithEvents btnPesqMarca As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDescMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtIdFornec As System.Windows.Forms.TextBox
    Friend WithEvents txtIdMarca As System.Windows.Forms.TextBox
    Friend WithEvents btnPesqFornec As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDelItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
End Class
