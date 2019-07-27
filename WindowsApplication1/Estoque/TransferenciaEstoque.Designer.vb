<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferenciaEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferenciaEstoque))
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnProcurarSimid = New System.Windows.Forms.Button()
        Me.optPesqSimid2 = New System.Windows.Forms.RadioButton()
        Me.optPesqSimid1 = New System.Windows.Forms.RadioButton()
        Me.txtPesquisaSimid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProcurarSerie = New System.Windows.Forms.Button()
        Me.optPesqSerie2 = New System.Windows.Forms.RadioButton()
        Me.optPesqSerie1 = New System.Windows.Forms.RadioButton()
        Me.txtPesquisaSerie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnExcluiPOS = New System.Windows.Forms.Button()
        Me.btnAdicionaPOS = New System.Windows.Forms.Button()
        Me.btnTransferir = New System.Windows.Forms.Button()
        Me.PesqFKEmpresaDestino = New WinCG.PesqFK()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnPesqLoja.Image = CType(resources.GetObject("btnPesqLoja.Image"), System.Drawing.Image)
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
        Me.btnAdiciona.Image = CType(resources.GetObject("btnAdiciona.Image"), System.Drawing.Image)
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
        Me.btnExclui.Image = CType(resources.GetObject("btnExclui.Image"), System.Drawing.Image)
        Me.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExclui.Location = New System.Drawing.Point(428, 531)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(115, 23)
        Me.btnExclui.TabIndex = 10
        Me.btnExclui.Text = "Excluir Chip"
        Me.btnExclui.UseVisualStyleBackColor = True
        Me.btnExclui.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnProcurarSimid)
        Me.GroupBox1.Controls.Add(Me.optPesqSimid2)
        Me.GroupBox1.Controls.Add(Me.optPesqSimid1)
        Me.GroupBox1.Controls.Add(Me.txtPesquisaSimid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 222)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chip"
        '
        'btnProcurarSimid
        '
        Me.btnProcurarSimid.Location = New System.Drawing.Point(569, 192)
        Me.btnProcurarSimid.Name = "btnProcurarSimid"
        Me.btnProcurarSimid.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarSimid.TabIndex = 3
        Me.btnProcurarSimid.Text = "Procurar"
        Me.btnProcurarSimid.UseVisualStyleBackColor = True
        '
        'optPesqSimid2
        '
        Me.optPesqSimid2.AutoSize = True
        Me.optPesqSimid2.Checked = True
        Me.optPesqSimid2.Location = New System.Drawing.Point(445, 192)
        Me.optPesqSimid2.Name = "optPesqSimid2"
        Me.optPesqSimid2.Size = New System.Drawing.Size(108, 17)
        Me.optPesqSimid2.TabIndex = 2
        Me.optPesqSimid2.TabStop = True
        Me.optPesqSimid2.Text = "Qualquer posição"
        Me.optPesqSimid2.UseVisualStyleBackColor = True
        '
        'optPesqSimid1
        '
        Me.optPesqSimid1.AutoSize = True
        Me.optPesqSimid1.Location = New System.Drawing.Point(330, 192)
        Me.optPesqSimid1.Name = "optPesqSimid1"
        Me.optPesqSimid1.Size = New System.Drawing.Size(100, 17)
        Me.optPesqSimid1.TabIndex = 2
        Me.optPesqSimid1.Text = "Começando por"
        Me.optPesqSimid1.UseVisualStyleBackColor = True
        '
        'txtPesquisaSimid
        '
        Me.txtPesquisaSimid.Location = New System.Drawing.Point(128, 191)
        Me.txtPesquisaSimid.Name = "txtPesquisaSimid"
        Me.txtPesquisaSimid.Size = New System.Drawing.Size(162, 20)
        Me.txtPesquisaSimid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pesquisar por SIMID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProcurarSerie)
        Me.GroupBox2.Controls.Add(Me.optPesqSerie2)
        Me.GroupBox2.Controls.Add(Me.optPesqSerie1)
        Me.GroupBox2.Controls.Add(Me.txtPesquisaSerie)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dgvDados2)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(847, 222)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "POS"
        '
        'btnProcurarSerie
        '
        Me.btnProcurarSerie.Location = New System.Drawing.Point(569, 193)
        Me.btnProcurarSerie.Name = "btnProcurarSerie"
        Me.btnProcurarSerie.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarSerie.TabIndex = 4
        Me.btnProcurarSerie.Text = "Procurar"
        Me.btnProcurarSerie.UseVisualStyleBackColor = True
        '
        'optPesqSerie2
        '
        Me.optPesqSerie2.AutoSize = True
        Me.optPesqSerie2.Checked = True
        Me.optPesqSerie2.Location = New System.Drawing.Point(451, 195)
        Me.optPesqSerie2.Name = "optPesqSerie2"
        Me.optPesqSerie2.Size = New System.Drawing.Size(108, 17)
        Me.optPesqSerie2.TabIndex = 17
        Me.optPesqSerie2.TabStop = True
        Me.optPesqSerie2.Text = "Qualquer posição"
        Me.optPesqSerie2.UseVisualStyleBackColor = True
        '
        'optPesqSerie1
        '
        Me.optPesqSerie1.AutoSize = True
        Me.optPesqSerie1.Location = New System.Drawing.Point(336, 195)
        Me.optPesqSerie1.Name = "optPesqSerie1"
        Me.optPesqSerie1.Size = New System.Drawing.Size(100, 17)
        Me.optPesqSerie1.TabIndex = 18
        Me.optPesqSerie1.Text = "Começando por"
        Me.optPesqSerie1.UseVisualStyleBackColor = True
        '
        'txtPesquisaSerie
        '
        Me.txtPesquisaSerie.Location = New System.Drawing.Point(134, 194)
        Me.txtPesquisaSerie.Name = "txtPesquisaSerie"
        Me.txtPesquisaSerie.Size = New System.Drawing.Size(162, 20)
        Me.txtPesquisaSerie.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Pesquisar por SÉRIE"
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(17, 19)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.Size = New System.Drawing.Size(822, 166)
        Me.dgvDados2.TabIndex = 14
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(36, 61)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(822, 166)
        Me.dgvDados.TabIndex = 13
        '
        'btnExcluiPOS
        '
        Me.btnExcluiPOS.Image = CType(resources.GetObject("btnExcluiPOS.Image"), System.Drawing.Image)
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
        Me.btnAdicionaPOS.Image = CType(resources.GetObject("btnAdicionaPOS.Image"), System.Drawing.Image)
        Me.btnAdicionaPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionaPOS.Location = New System.Drawing.Point(551, 531)
        Me.btnAdicionaPOS.Name = "btnAdicionaPOS"
        Me.btnAdicionaPOS.Size = New System.Drawing.Size(115, 23)
        Me.btnAdicionaPOS.TabIndex = 14
        Me.btnAdicionaPOS.Text = "Adicionar POS"
        Me.btnAdicionaPOS.UseVisualStyleBackColor = True
        Me.btnAdicionaPOS.Visible = False
        '
        'btnTransferir
        '
        Me.btnTransferir.Location = New System.Drawing.Point(791, 13)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(75, 23)
        Me.btnTransferir.TabIndex = 16
        Me.btnTransferir.Text = "Transferir"
        Me.btnTransferir.UseVisualStyleBackColor = True
        '
        'PesqFKEmpresaDestino
        '
        Me.PesqFKEmpresaDestino.CampoDesc = Nothing
        Me.PesqFKEmpresaDestino.CampoId = Nothing
        Me.PesqFKEmpresaDestino.Clicou = "0"
        Me.PesqFKEmpresaDestino.ColunasFiltro = Nothing
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
        'TransferenciaEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 534)
        Me.Controls.Add(Me.PesqFKEmpresaDestino)
        Me.Controls.Add(Me.btnTransferir)
        Me.Controls.Add(Me.btnExcluiPOS)
        Me.Controls.Add(Me.btnAdicionaPOS)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Name = "TransferenciaEstoque"
        Me.Text = "Transferência de Estoque de Chip/POS entre Empresas"
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
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.dgvDados, 0)
        Me.Controls.SetChildIndex(Me.btnAdicionaPOS, 0)
        Me.Controls.SetChildIndex(Me.btnExcluiPOS, 0)
        Me.Controls.SetChildIndex(Me.btnTransferir, 0)
        Me.Controls.SetChildIndex(Me.PesqFKEmpresaDestino, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDados2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcluiPOS As System.Windows.Forms.Button
    Friend WithEvents btnAdicionaPOS As System.Windows.Forms.Button
    Friend WithEvents btnTransferir As System.Windows.Forms.Button
    Friend WithEvents optPesqSimid2 As System.Windows.Forms.RadioButton
    Friend WithEvents optPesqSimid1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtPesquisaSimid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optPesqSerie2 As System.Windows.Forms.RadioButton
    Friend WithEvents optPesqSerie1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtPesquisaSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnProcurarSimid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarSerie As System.Windows.Forms.Button
    Friend WithEvents PesqFKEmpresaDestino As WinCG.PesqFK
End Class
