<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoVenda
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
        Me.components = New System.ComponentModel.Container()
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoVenda))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtUltimaAlteracao = New System.Windows.Forms.TextBox()
        Me.txtDataBaixa = New System.Windows.Forms.TextBox()
        Me.txtPrevisaoEntrega = New System.Windows.Forms.TextBox()
        Me.PesqFKCliente = New WinCG.PesqFK()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnExclui = New System.Windows.Forms.Button()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.txtQtdeEntregue = New System.Windows.Forms.TextBox()
        Me.txtQtdePedida = New System.Windows.Forms.TextBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRecibo = New System.Windows.Forms.Button()
        Me.Report1 = New FastReport.Report()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 78)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(30, 13)
        Label3.TabIndex = 24
        Label3.Text = "Data"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(385, 78)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(88, 13)
        Label4.TabIndex = 51
        Label4.Text = "Previsão Entrega"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(385, 104)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(84, 13)
        Label5.TabIndex = 55
        Label5.Text = "Última Alteração"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(10, 104)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(74, 13)
        Label7.TabIndex = 53
        Label7.Text = "Data da Baixa"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(381, 14)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(82, 13)
        Label1.TabIndex = 63
        Label1.Text = "Qtde a Entregar"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(6, 14)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 13)
        Label2.TabIndex = 61
        Label2.Text = "Qtde Pedida"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(722, 415)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Label5)
        Me.TabPage1.Controls.Add(Me.txtUltimaAlteracao)
        Me.TabPage1.Controls.Add(Label7)
        Me.TabPage1.Controls.Add(Me.txtDataBaixa)
        Me.TabPage1.Controls.Add(Label4)
        Me.TabPage1.Controls.Add(Me.txtPrevisaoEntrega)
        Me.TabPage1.Controls.Add(Me.PesqFKCliente)
        Me.TabPage1.Controls.Add(Me.txtStatus)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Label3)
        Me.TabPage1.Controls.Add(Me.txtData)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.lblCodigo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(714, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Principal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtUltimaAlteracao
        '
        Me.txtUltimaAlteracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUltimaAlteracao.Enabled = False
        Me.txtUltimaAlteracao.Location = New System.Drawing.Point(480, 100)
        Me.txtUltimaAlteracao.Name = "txtUltimaAlteracao"
        Me.txtUltimaAlteracao.Size = New System.Drawing.Size(120, 20)
        Me.txtUltimaAlteracao.TabIndex = 56
        Me.txtUltimaAlteracao.Tag = "NF ENTRADA"
        '
        'txtDataBaixa
        '
        Me.txtDataBaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataBaixa.Enabled = False
        Me.txtDataBaixa.Location = New System.Drawing.Point(92, 100)
        Me.txtDataBaixa.Name = "txtDataBaixa"
        Me.txtDataBaixa.Size = New System.Drawing.Size(120, 20)
        Me.txtDataBaixa.TabIndex = 54
        Me.txtDataBaixa.Tag = "NF ENTRADA"
        '
        'txtPrevisaoEntrega
        '
        Me.txtPrevisaoEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrevisaoEntrega.Location = New System.Drawing.Point(480, 74)
        Me.txtPrevisaoEntrega.Name = "txtPrevisaoEntrega"
        Me.txtPrevisaoEntrega.Size = New System.Drawing.Size(120, 20)
        Me.txtPrevisaoEntrega.TabIndex = 52
        Me.txtPrevisaoEntrega.Tag = "Previsão de Entrega"
        Me.ToolTip1.SetToolTip(Me.txtPrevisaoEntrega, "Preencher no formato dd/mm/AAAA")
        '
        'PesqFKCliente
        '
        Me.PesqFKCliente.CampoDesc = Nothing
        Me.PesqFKCliente.CampoId = Nothing
        Me.PesqFKCliente.Clicou = "0"
        Me.PesqFKCliente.CodigoSelecionado = Nothing
        Me.PesqFKCliente.ColunasFiltro = Nothing
        Me.PesqFKCliente.DescricaoSelecionada = Nothing
        Me.PesqFKCliente.FiltroSQL = Nothing
        Me.PesqFKCliente.LabelBuscaDesc = Nothing
        Me.PesqFKCliente.LabelBuscaId = Nothing
        Me.PesqFKCliente.LabelPesqFK = Nothing
        Me.PesqFKCliente.ListaCampos = Nothing
        Me.PesqFKCliente.Location = New System.Drawing.Point(13, 43)
        Me.PesqFKCliente.Name = "PesqFKCliente"
        Me.PesqFKCliente.ObjModelFk = Nothing
        Me.PesqFKCliente.PosValida = False
        Me.PesqFKCliente.Size = New System.Drawing.Size(598, 25)
        Me.PesqFKCliente.Tabela = Nothing
        Me.PesqFKCliente.TabIndex = 34
        Me.PesqFKCliente.TituloTela = Nothing
        Me.PesqFKCliente.View = Nothing
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStatus.Location = New System.Drawing.Point(495, 17)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(105, 20)
        Me.txtStatus.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Status"
        '
        'txtData
        '
        Me.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData.Enabled = False
        Me.txtData.Location = New System.Drawing.Point(92, 74)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(120, 20)
        Me.txtData.TabIndex = 25
        Me.txtData.Tag = "NF ENTRADA"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(92, 17)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(10, 21)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Pedido"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnExclui)
        Me.TabPage2.Controls.Add(Me.btnAdiciona)
        Me.TabPage2.Controls.Add(Label1)
        Me.TabPage2.Controls.Add(Me.txtQtdeEntregue)
        Me.TabPage2.Controls.Add(Label2)
        Me.TabPage2.Controls.Add(Me.txtQtdePedida)
        Me.TabPage2.Controls.Add(Me.dgvDados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(714, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Itens do Pedido"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnExclui
        '
        Me.btnExclui.Image = CType(resources.GetObject("btnExclui.Image"), System.Drawing.Image)
        Me.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExclui.Location = New System.Drawing.Point(105, 336)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(97, 23)
        Me.btnExclui.TabIndex = 66
        Me.btnExclui.Text = "Cancelar"
        Me.btnExclui.UseVisualStyleBackColor = True
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Image = CType(resources.GetObject("btnAdiciona.Image"), System.Drawing.Image)
        Me.btnAdiciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdiciona.Location = New System.Drawing.Point(6, 336)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(97, 23)
        Me.btnAdiciona.TabIndex = 65
        Me.btnAdiciona.Text = "Adicionar"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'txtQtdeEntregue
        '
        Me.txtQtdeEntregue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQtdeEntregue.Enabled = False
        Me.txtQtdeEntregue.Location = New System.Drawing.Point(476, 10)
        Me.txtQtdeEntregue.Name = "txtQtdeEntregue"
        Me.txtQtdeEntregue.Size = New System.Drawing.Size(120, 20)
        Me.txtQtdeEntregue.TabIndex = 64
        Me.txtQtdeEntregue.Tag = "NF ENTRADA"
        '
        'txtQtdePedida
        '
        Me.txtQtdePedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQtdePedida.Enabled = False
        Me.txtQtdePedida.Location = New System.Drawing.Point(88, 10)
        Me.txtQtdePedida.Name = "txtQtdePedida"
        Me.txtQtdePedida.Size = New System.Drawing.Size(120, 20)
        Me.txtQtdePedida.TabIndex = 62
        Me.txtQtdePedida.Tag = "NF ENTRADA"
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(6, 40)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(700, 290)
        Me.dgvDados.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtObservacao)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(714, 389)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Observação"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(16, 14)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(690, 314)
        Me.txtObservacao.TabIndex = 5
        '
        'ofd
        '
        Me.ofd.FileName = "foto"
        Me.ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        Me.ofd.InitialDirectory = "C:\"
        '
        'btnRecibo
        '
        Me.btnRecibo.Image = CType(resources.GetObject("btnRecibo.Image"), System.Drawing.Image)
        Me.btnRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecibo.Location = New System.Drawing.Point(603, 425)
        Me.btnRecibo.Name = "btnRecibo"
        Me.btnRecibo.Size = New System.Drawing.Size(119, 32)
        Me.btnRecibo.TabIndex = 2
        Me.btnRecibo.Text = "Recibo"
        Me.btnRecibo.UseVisualStyleBackColor = True
        '
        'Report1
        '
        Me.Report1.NeedRefresh = False
        Me.Report1.ReportResourceString = resources.GetString("Report1.ReportResourceString")
        '
        'PedidoVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 461)
        Me.Controls.Add(Me.btnRecibo)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "PedidoVenda"
        Me.Text = "Pedido de Vendas de POS"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.btnRecibo, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtObservacao As System.Windows.Forms.TextBox
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PesqFKCliente As WinCG.PesqFK
    Friend WithEvents txtUltimaAlteracao As TextBox
    Friend WithEvents txtDataBaixa As TextBox
    Friend WithEvents txtPrevisaoEntrega As TextBox
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents txtQtdeEntregue As TextBox
    Friend WithEvents txtQtdePedida As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnExclui As Button
    Friend WithEvents btnAdiciona As Button
    Friend WithEvents btnRecibo As Button
    Friend WithEvents Report1 As FastReport.Report
End Class
