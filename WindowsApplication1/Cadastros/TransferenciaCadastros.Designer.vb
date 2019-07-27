<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferenciaCadastros
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnPesqLoja = New System.Windows.Forms.Button()
        Me.txtDescLoja = New System.Windows.Forms.TextBox()
        Me.txtIdLoja = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtDataMovto = New System.Windows.Forms.DateTimePicker()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.btnExclui = New System.Windows.Forms.Button()
        Me.btnExcluiPOS = New System.Windows.Forms.Button()
        Me.btnAdicionaPOS = New System.Windows.Forms.Button()
        Me.PesqFKEmpresaDestino = New WinCG.PesqFK()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDados4 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDados3 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.optPesqSimid2 = New System.Windows.Forms.RadioButton()
        Me.optPesqSimid1 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProcurarSimid = New System.Windows.Forms.Button()
        Me.txtPesquisaSimid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvDados4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDados3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(534, 499)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(68, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Romaneio nº"
        Me.lblCodigo.Visible = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(689, 498)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(30, 13)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Data"
        Me.lblDescricao.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(609, 495)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Visible = False
        '
        'btnPesqLoja
        '
        Me.btnPesqLoja.Enabled = False
        Me.btnPesqLoja.Location = New System.Drawing.Point(488, 496)
        Me.btnPesqLoja.Name = "btnPesqLoja"
        Me.btnPesqLoja.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqLoja.TabIndex = 7
        Me.btnPesqLoja.UseVisualStyleBackColor = True
        Me.btnPesqLoja.Visible = False
        '
        'txtDescLoja
        '
        Me.txtDescLoja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescLoja.Enabled = False
        Me.txtDescLoja.Location = New System.Drawing.Point(161, 497)
        Me.txtDescLoja.Name = "txtDescLoja"
        Me.txtDescLoja.Size = New System.Drawing.Size(321, 20)
        Me.txtDescLoja.TabIndex = 6
        Me.txtDescLoja.Visible = False
        '
        'txtIdLoja
        '
        Me.txtIdLoja.Enabled = False
        Me.txtIdLoja.Location = New System.Drawing.Point(91, 497)
        Me.txtIdLoja.Name = "txtIdLoja"
        Me.txtIdLoja.Size = New System.Drawing.Size(64, 20)
        Me.txtIdLoja.TabIndex = 5
        Me.txtIdLoja.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(57, 501)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(27, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Loja"
        Me.lblStatus.Visible = False
        '
        'txtDataMovto
        '
        Me.txtDataMovto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataMovto.Location = New System.Drawing.Point(729, 494)
        Me.txtDataMovto.Name = "txtDataMovto"
        Me.txtDataMovto.Size = New System.Drawing.Size(85, 20)
        Me.txtDataMovto.TabIndex = 3
        Me.txtDataMovto.Visible = False
        '
        'btnAdiciona
        '
        Me.btnAdiciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdiciona.Location = New System.Drawing.Point(311, 531)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(115, 23)
        Me.btnAdiciona.TabIndex = 9
        Me.btnAdiciona.Text = "Adicionar Chip"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        Me.btnAdiciona.Visible = False
        '
        'btnExclui
        '
        Me.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExclui.Location = New System.Drawing.Point(428, 531)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(115, 23)
        Me.btnExclui.TabIndex = 10
        Me.btnExclui.Text = "Excluir Chip"
        Me.btnExclui.UseVisualStyleBackColor = True
        Me.btnExclui.Visible = False
        '
        'btnExcluiPOS
        '
        Me.btnExcluiPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluiPOS.Location = New System.Drawing.Point(668, 531)
        Me.btnExcluiPOS.Name = "btnExcluiPOS"
        Me.btnExcluiPOS.Size = New System.Drawing.Size(115, 23)
        Me.btnExcluiPOS.TabIndex = 15
        Me.btnExcluiPOS.Text = "Excluir POS"
        Me.btnExcluiPOS.UseVisualStyleBackColor = True
        Me.btnExcluiPOS.Visible = False
        '
        'btnAdicionaPOS
        '
        Me.btnAdicionaPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionaPOS.Location = New System.Drawing.Point(551, 531)
        Me.btnAdicionaPOS.Name = "btnAdicionaPOS"
        Me.btnAdicionaPOS.Size = New System.Drawing.Size(115, 23)
        Me.btnAdicionaPOS.TabIndex = 14
        Me.btnAdicionaPOS.Text = "Adicionar POS"
        Me.btnAdicionaPOS.UseVisualStyleBackColor = True
        Me.btnAdicionaPOS.Visible = False
        '
        'PesqFKEmpresaDestino
        '
        Me.PesqFKEmpresaDestino.CampoDesc = Nothing
        Me.PesqFKEmpresaDestino.CampoId = Nothing
        Me.PesqFKEmpresaDestino.Clicou = "0"
        Me.PesqFKEmpresaDestino.CodigoSelecionado = Nothing
        Me.PesqFKEmpresaDestino.ColunasFiltro = Nothing
        Me.PesqFKEmpresaDestino.DescricaoSelecionada = Nothing
        Me.PesqFKEmpresaDestino.FiltroSQL = Nothing
        Me.PesqFKEmpresaDestino.LabelBuscaDesc = Nothing
        Me.PesqFKEmpresaDestino.LabelBuscaId = Nothing
        Me.PesqFKEmpresaDestino.LabelPesqFK = Nothing
        Me.PesqFKEmpresaDestino.ListaCampos = Nothing
        Me.PesqFKEmpresaDestino.Location = New System.Drawing.Point(19, 11)
        Me.PesqFKEmpresaDestino.Name = "PesqFKEmpresaDestino"
        Me.PesqFKEmpresaDestino.ObjModelFk = Nothing
        Me.PesqFKEmpresaDestino.PosValida = False
        Me.PesqFKEmpresaDestino.Size = New System.Drawing.Size(583, 25)
        Me.PesqFKEmpresaDestino.Tabela = Nothing
        Me.PesqFKEmpresaDestino.TabIndex = 18
        Me.PesqFKEmpresaDestino.TituloTela = Nothing
        Me.PesqFKEmpresaDestino.View = Nothing
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 42)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(850, 469)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dgvDados4)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(842, 443)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Loja"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(14, 410)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Loja"
        '
        'dgvDados4
        '
        Me.dgvDados4.AllowUserToAddRows = False
        Me.dgvDados4.AllowUserToDeleteRows = False
        Me.dgvDados4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados4.Location = New System.Drawing.Point(17, 18)
        Me.dgvDados4.Name = "dgvDados4"
        Me.dgvDados4.Size = New System.Drawing.Size(793, 324)
        Me.dgvDados4.TabIndex = 21
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dgvDados3)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(842, 443)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Trânsito"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(13, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Trânsito"
        '
        'dgvDados3
        '
        Me.dgvDados3.AllowUserToAddRows = False
        Me.dgvDados3.AllowUserToDeleteRows = False
        Me.dgvDados3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados3.Location = New System.Drawing.Point(17, 18)
        Me.dgvDados3.Name = "dgvDados3"
        Me.dgvDados3.Size = New System.Drawing.Size(793, 324)
        Me.dgvDados3.TabIndex = 20
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.optPesqSimid2)
        Me.TabPage3.Controls.Add(Me.optPesqSimid1)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.dgvDados2)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(842, 443)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Área"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(13, 410)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Área"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(580, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Procurar"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'optPesqSimid2
        '
        Me.optPesqSimid2.AutoSize = True
        Me.optPesqSimid2.Checked = True
        Me.optPesqSimid2.Location = New System.Drawing.Point(456, 359)
        Me.optPesqSimid2.Name = "optPesqSimid2"
        Me.optPesqSimid2.Size = New System.Drawing.Size(133, 20)
        Me.optPesqSimid2.TabIndex = 22
        Me.optPesqSimid2.TabStop = True
        Me.optPesqSimid2.Text = "Qualquer posição"
        Me.optPesqSimid2.UseVisualStyleBackColor = True
        Me.optPesqSimid2.Visible = False
        '
        'optPesqSimid1
        '
        Me.optPesqSimid1.AutoSize = True
        Me.optPesqSimid1.Location = New System.Drawing.Point(341, 359)
        Me.optPesqSimid1.Name = "optPesqSimid1"
        Me.optPesqSimid1.Size = New System.Drawing.Size(123, 20)
        Me.optPesqSimid1.TabIndex = 23
        Me.optPesqSimid1.Text = "Começando por"
        Me.optPesqSimid1.UseVisualStyleBackColor = True
        Me.optPesqSimid1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 358)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 22)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Pesquisar por SIMID"
        Me.Label2.Visible = False
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(17, 18)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.Size = New System.Drawing.Size(793, 324)
        Me.dgvDados2.TabIndex = 19
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.btnProcurarSimid)
        Me.TabPage4.Controls.Add(Me.txtPesquisaSimid)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.dgvDados)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(842, 443)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Responsável"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(18, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Responsável"
        '
        'btnProcurarSimid
        '
        Me.btnProcurarSimid.Location = New System.Drawing.Point(288, 358)
        Me.btnProcurarSimid.Name = "btnProcurarSimid"
        Me.btnProcurarSimid.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarSimid.TabIndex = 23
        Me.btnProcurarSimid.Text = "Procurar"
        Me.btnProcurarSimid.UseVisualStyleBackColor = True
        Me.btnProcurarSimid.Visible = False
        '
        'txtPesquisaSimid
        '
        Me.txtPesquisaSimid.Location = New System.Drawing.Point(160, 359)
        Me.txtPesquisaSimid.Name = "txtPesquisaSimid"
        Me.txtPesquisaSimid.Size = New System.Drawing.Size(126, 22)
        Me.txtPesquisaSimid.TabIndex = 20
        Me.txtPesquisaSimid.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Pesquisa por Código da Loja"
        Me.Label1.Visible = False
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(17, 18)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(793, 324)
        Me.dgvDados.TabIndex = 18
        '
        'TransferenciaCadastros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 534)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PesqFKEmpresaDestino)
        Me.Controls.Add(Me.btnExcluiPOS)
        Me.Controls.Add(Me.btnAdicionaPOS)
        Me.Controls.Add(Me.btnExclui)
        Me.Controls.Add(Me.btnAdiciona)
        Me.Controls.Add(Me.txtDataMovto)
        Me.Controls.Add(Me.btnPesqLoja)
        Me.Controls.Add(Me.txtDescLoja)
        Me.Controls.Add(Me.txtIdLoja)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "TransferenciaCadastros"
        Me.Text = "Transferência de Cadastros Básicos entre Empresas"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblDescricao, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.txtIdLoja, 0)
        Me.Controls.SetChildIndex(Me.txtDescLoja, 0)
        Me.Controls.SetChildIndex(Me.btnPesqLoja, 0)
        Me.Controls.SetChildIndex(Me.txtDataMovto, 0)
        Me.Controls.SetChildIndex(Me.btnAdiciona, 0)
        Me.Controls.SetChildIndex(Me.btnExclui, 0)
        Me.Controls.SetChildIndex(Me.btnAdicionaPOS, 0)
        Me.Controls.SetChildIndex(Me.btnExcluiPOS, 0)
        Me.Controls.SetChildIndex(Me.PesqFKEmpresaDestino, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvDados4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDados3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnPesqLoja As System.Windows.Forms.Button
    Friend WithEvents txtDescLoja As System.Windows.Forms.TextBox
    Friend WithEvents txtIdLoja As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtDataMovto As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdiciona As System.Windows.Forms.Button
    Friend WithEvents btnExclui As System.Windows.Forms.Button
    Friend WithEvents btnExcluiPOS As System.Windows.Forms.Button
    Friend WithEvents btnAdicionaPOS As System.Windows.Forms.Button
    Friend WithEvents PesqFKEmpresaDestino As WinCG.PesqFK
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvDados4 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvDados3 As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvDados2 As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents btnProcurarSimid As Button
    Friend WithEvents txtPesquisaSimid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents optPesqSimid2 As RadioButton
    Friend WithEvents optPesqSimid1 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
