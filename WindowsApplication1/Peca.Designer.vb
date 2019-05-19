<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Peca
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
        Dim Label3 As System.Windows.Forms.Label
        Dim DESC_EQUIPAMENTOLabel As System.Windows.Forms.Label
        Dim SERIELabel As System.Windows.Forms.Label
        Dim PROTOCOLOLabel As System.Windows.Forms.Label
        Dim VALORLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim MODELOLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PesqFKFinalidade = New WinCG.PesqFK()
        Me.PesqFKCategoria = New WinCG.PesqFK()
        Me.PesqFKMarca = New WinCG.PesqFK()
        Me.PesqFKFornecedor = New WinCG.PesqFK()
        Me.txtEstoqueMax = New System.Windows.Forms.TextBox()
        Me.txtId_Controle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEstoqueMin = New System.Windows.Forms.TextBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.txtCusto = New System.Windows.Forms.TextBox()
        Me.txtDescricaoPeca = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.PicFotoPeca = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Label3 = New System.Windows.Forms.Label()
        DESC_EQUIPAMENTOLabel = New System.Windows.Forms.Label()
        SERIELabel = New System.Windows.Forms.Label()
        PROTOCOLOLabel = New System.Windows.Forms.Label()
        VALORLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        MODELOLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PicFotoPeca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 284)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(47, 13)
        Label3.TabIndex = 24
        Label3.Text = "Unidade"
        '
        'DESC_EQUIPAMENTOLabel
        '
        DESC_EQUIPAMENTOLabel.AutoSize = True
        DESC_EQUIPAMENTOLabel.Location = New System.Drawing.Point(10, 47)
        DESC_EQUIPAMENTOLabel.Name = "DESC_EQUIPAMENTOLabel"
        DESC_EQUIPAMENTOLabel.Size = New System.Drawing.Size(35, 13)
        DESC_EQUIPAMENTOLabel.TabIndex = 4
        DESC_EQUIPAMENTOLabel.Text = "Nome"
        '
        'SERIELabel
        '
        SERIELabel.AutoSize = True
        SERIELabel.Location = New System.Drawing.Point(234, 284)
        SERIELabel.Name = "SERIELabel"
        SERIELabel.Size = New System.Drawing.Size(71, 13)
        SERIELabel.TabIndex = 26
        SERIELabel.Text = "Estoque Mín."
        '
        'PROTOCOLOLabel
        '
        PROTOCOLOLabel.Location = New System.Drawing.Point(10, 305)
        PROTOCOLOLabel.Name = "PROTOCOLOLabel"
        PROTOCOLOLabel.Size = New System.Drawing.Size(76, 29)
        PROTOCOLOLabel.TabIndex = 30
        PROTOCOLOLabel.Text = "Referência Fornecedor"
        '
        'VALORLabel
        '
        VALORLabel.AutoSize = True
        VALORLabel.Location = New System.Drawing.Point(379, 313)
        VALORLabel.Name = "VALORLabel"
        VALORLabel.Size = New System.Drawing.Size(51, 13)
        VALORLabel.TabIndex = 32
        VALORLabel.Text = "Custo R$"
        '
        'OBSLabel
        '
        OBSLabel.Location = New System.Drawing.Point(10, 95)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(66, 32)
        OBSLabel.TabIndex = 6
        OBSLabel.Text = "Descrição da Peça"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(396, 283)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(72, 13)
        Label2.TabIndex = 28
        Label2.Text = "Estoque Máx."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(554, 415)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.txtSerie)
        Me.TabPage1.Controls.Add(MODELOLabel)
        Me.TabPage1.Controls.Add(Me.txtModelo)
        Me.TabPage1.Controls.Add(Me.PesqFKFinalidade)
        Me.TabPage1.Controls.Add(Me.PesqFKCategoria)
        Me.TabPage1.Controls.Add(Me.PesqFKMarca)
        Me.TabPage1.Controls.Add(Me.PesqFKFornecedor)
        Me.TabPage1.Controls.Add(Label2)
        Me.TabPage1.Controls.Add(Me.txtEstoqueMax)
        Me.TabPage1.Controls.Add(Me.txtId_Controle)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Label3)
        Me.TabPage1.Controls.Add(Me.txtUnidade)
        Me.TabPage1.Controls.Add(DESC_EQUIPAMENTOLabel)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(SERIELabel)
        Me.TabPage1.Controls.Add(Me.txtEstoqueMin)
        Me.TabPage1.Controls.Add(PROTOCOLOLabel)
        Me.TabPage1.Controls.Add(Me.txtReferencia)
        Me.TabPage1.Controls.Add(VALORLabel)
        Me.TabPage1.Controls.Add(Me.txtCusto)
        Me.TabPage1.Controls.Add(OBSLabel)
        Me.TabPage1.Controls.Add(Me.txtDescricaoPeca)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.lblCodigo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(546, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PesqFKFinalidade
        '
        Me.PesqFKFinalidade.CampoDesc = Nothing
        Me.PesqFKFinalidade.CampoId = Nothing
        Me.PesqFKFinalidade.Clicou = "0"
        Me.PesqFKFinalidade.CodigoSelecionado = Nothing
        Me.PesqFKFinalidade.ColunasFiltro = Nothing
        Me.PesqFKFinalidade.DescricaoSelecionada = Nothing
        Me.PesqFKFinalidade.FiltroSQL = Nothing
        Me.PesqFKFinalidade.LabelBuscaDesc = Nothing
        Me.PesqFKFinalidade.LabelBuscaId = Nothing
        Me.PesqFKFinalidade.LabelPesqFK = Nothing
        Me.PesqFKFinalidade.ListaCampos = Nothing
        Me.PesqFKFinalidade.Location = New System.Drawing.Point(10, 250)
        Me.PesqFKFinalidade.Name = "PesqFKFinalidade"
        Me.PesqFKFinalidade.ObjModelFk = Nothing
        Me.PesqFKFinalidade.PosValida = False
        Me.PesqFKFinalidade.Size = New System.Drawing.Size(522, 25)
        Me.PesqFKFinalidade.Tabela = Nothing
        Me.PesqFKFinalidade.TabIndex = 37
        Me.PesqFKFinalidade.TituloTela = Nothing
        Me.PesqFKFinalidade.View = Nothing
        '
        'PesqFKCategoria
        '
        Me.PesqFKCategoria.CampoDesc = Nothing
        Me.PesqFKCategoria.CampoId = Nothing
        Me.PesqFKCategoria.Clicou = "0"
        Me.PesqFKCategoria.CodigoSelecionado = Nothing
        Me.PesqFKCategoria.ColunasFiltro = Nothing
        Me.PesqFKCategoria.DescricaoSelecionada = Nothing
        Me.PesqFKCategoria.FiltroSQL = Nothing
        Me.PesqFKCategoria.LabelBuscaDesc = Nothing
        Me.PesqFKCategoria.LabelBuscaId = Nothing
        Me.PesqFKCategoria.LabelPesqFK = Nothing
        Me.PesqFKCategoria.ListaCampos = Nothing
        Me.PesqFKCategoria.Location = New System.Drawing.Point(10, 219)
        Me.PesqFKCategoria.Name = "PesqFKCategoria"
        Me.PesqFKCategoria.ObjModelFk = Nothing
        Me.PesqFKCategoria.PosValida = False
        Me.PesqFKCategoria.Size = New System.Drawing.Size(522, 25)
        Me.PesqFKCategoria.Tabela = Nothing
        Me.PesqFKCategoria.TabIndex = 36
        Me.PesqFKCategoria.TituloTela = Nothing
        Me.PesqFKCategoria.View = Nothing
        '
        'PesqFKMarca
        '
        Me.PesqFKMarca.CampoDesc = Nothing
        Me.PesqFKMarca.CampoId = Nothing
        Me.PesqFKMarca.Clicou = "0"
        Me.PesqFKMarca.CodigoSelecionado = Nothing
        Me.PesqFKMarca.ColunasFiltro = Nothing
        Me.PesqFKMarca.DescricaoSelecionada = Nothing
        Me.PesqFKMarca.FiltroSQL = Nothing
        Me.PesqFKMarca.LabelBuscaDesc = Nothing
        Me.PesqFKMarca.LabelBuscaId = Nothing
        Me.PesqFKMarca.LabelPesqFK = Nothing
        Me.PesqFKMarca.ListaCampos = Nothing
        Me.PesqFKMarca.Location = New System.Drawing.Point(10, 188)
        Me.PesqFKMarca.Name = "PesqFKMarca"
        Me.PesqFKMarca.ObjModelFk = Nothing
        Me.PesqFKMarca.PosValida = False
        Me.PesqFKMarca.Size = New System.Drawing.Size(522, 25)
        Me.PesqFKMarca.Tabela = Nothing
        Me.PesqFKMarca.TabIndex = 35
        Me.PesqFKMarca.TituloTela = Nothing
        Me.PesqFKMarca.View = Nothing
        '
        'PesqFKFornecedor
        '
        Me.PesqFKFornecedor.CampoDesc = Nothing
        Me.PesqFKFornecedor.CampoId = Nothing
        Me.PesqFKFornecedor.Clicou = "0"
        Me.PesqFKFornecedor.CodigoSelecionado = Nothing
        Me.PesqFKFornecedor.ColunasFiltro = Nothing
        Me.PesqFKFornecedor.DescricaoSelecionada = Nothing
        Me.PesqFKFornecedor.FiltroSQL = Nothing
        Me.PesqFKFornecedor.LabelBuscaDesc = Nothing
        Me.PesqFKFornecedor.LabelBuscaId = Nothing
        Me.PesqFKFornecedor.LabelPesqFK = Nothing
        Me.PesqFKFornecedor.ListaCampos = Nothing
        Me.PesqFKFornecedor.Location = New System.Drawing.Point(10, 157)
        Me.PesqFKFornecedor.Name = "PesqFKFornecedor"
        Me.PesqFKFornecedor.ObjModelFk = Nothing
        Me.PesqFKFornecedor.PosValida = False
        Me.PesqFKFornecedor.Size = New System.Drawing.Size(522, 25)
        Me.PesqFKFornecedor.Tabela = Nothing
        Me.PesqFKFornecedor.TabIndex = 34
        Me.PesqFKFornecedor.TituloTela = Nothing
        Me.PesqFKFornecedor.View = Nothing
        '
        'txtEstoqueMax
        '
        Me.txtEstoqueMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstoqueMax.Location = New System.Drawing.Point(474, 280)
        Me.txtEstoqueMax.Name = "txtEstoqueMax"
        Me.txtEstoqueMax.Size = New System.Drawing.Size(58, 20)
        Me.txtEstoqueMax.TabIndex = 29
        Me.txtEstoqueMax.Tag = "Série"
        '
        'txtId_Controle
        '
        Me.txtId_Controle.Enabled = False
        Me.txtId_Controle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtId_Controle.Location = New System.Drawing.Point(458, 17)
        Me.txtId_Controle.Name = "txtId_Controle"
        Me.txtId_Controle.ReadOnly = True
        Me.txtId_Controle.Size = New System.Drawing.Size(74, 20)
        Me.txtId_Controle.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Código de Controle"
        '
        'txtUnidade
        '
        Me.txtUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidade.Location = New System.Drawing.Point(92, 280)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(105, 20)
        Me.txtUnidade.TabIndex = 25
        Me.txtUnidade.Tag = "NF ENTRADA"
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(92, 43)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(440, 20)
        Me.txtNome.TabIndex = 5
        Me.txtNome.Tag = "Descrição do Equipamento"
        '
        'txtEstoqueMin
        '
        Me.txtEstoqueMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstoqueMin.Location = New System.Drawing.Point(316, 280)
        Me.txtEstoqueMin.Name = "txtEstoqueMin"
        Me.txtEstoqueMin.Size = New System.Drawing.Size(58, 20)
        Me.txtEstoqueMin.TabIndex = 27
        Me.txtEstoqueMin.Tag = "Série"
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(92, 309)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(281, 20)
        Me.txtReferencia.TabIndex = 31
        Me.txtReferencia.Tag = ""
        '
        'txtCusto
        '
        Me.txtCusto.Location = New System.Drawing.Point(435, 306)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(97, 20)
        Me.txtCusto.TabIndex = 33
        Me.txtCusto.Tag = "Valor"
        '
        'txtDescricaoPeca
        '
        Me.txtDescricaoPeca.Location = New System.Drawing.Point(92, 71)
        Me.txtDescricaoPeca.Multiline = True
        Me.txtDescricaoPeca.Name = "txtDescricaoPeca"
        Me.txtDescricaoPeca.Size = New System.Drawing.Size(440, 81)
        Me.txtDescricaoPeca.TabIndex = 7
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
        Me.lblCodigo.Text = "Código"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAddImage)
        Me.TabPage2.Controls.Add(Me.PicFotoPeca)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(546, 342)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Outras Informações"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(19, 313)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(127, 23)
        Me.btnAddImage.TabIndex = 1
        Me.btnAddImage.Text = "Adicionar foto"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'PicFotoPeca
        '
        Me.PicFotoPeca.Location = New System.Drawing.Point(19, 16)
        Me.PicFotoPeca.Name = "PicFotoPeca"
        Me.PicFotoPeca.Size = New System.Drawing.Size(405, 291)
        Me.PicFotoPeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicFotoPeca.TabIndex = 0
        Me.PicFotoPeca.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtObservacao)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(546, 342)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Observação"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(16, 14)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(515, 314)
        Me.txtObservacao.TabIndex = 5
        '
        'ofd
        '
        Me.ofd.FileName = "foto"
        Me.ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        Me.ofd.InitialDirectory = "C:\"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(10, 343)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(72, 13)
        Label1.TabIndex = 47
        Label1.Text = "# Série Única"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(92, 339)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(159, 20)
        Me.txtSerie.TabIndex = 48
        Me.txtSerie.Tag = "Série"
        '
        'MODELOLabel
        '
        MODELOLabel.AutoSize = True
        MODELOLabel.Location = New System.Drawing.Point(274, 343)
        MODELOLabel.Name = "MODELOLabel"
        MODELOLabel.Size = New System.Drawing.Size(42, 13)
        MODELOLabel.TabIndex = 49
        MODELOLabel.Text = "Modelo"
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Location = New System.Drawing.Point(332, 339)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(200, 20)
        Me.txtModelo.TabIndex = 50
        Me.txtModelo.Tag = "Modelo"
        '
        'Peca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Peca"
        Me.Text = "Cadastro de Peças para Manutenção"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PicFotoPeca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtId_Controle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUnidade As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtEstoqueMin As System.Windows.Forms.TextBox
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtCusto As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricaoPeca As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtObservacao As System.Windows.Forms.TextBox
    Friend WithEvents txtEstoqueMax As System.Windows.Forms.TextBox
    Friend WithEvents PicFotoPeca As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddImage As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PesqFKFinalidade As WinCG.PesqFK
    Friend WithEvents PesqFKCategoria As WinCG.PesqFK
    Friend WithEvents PesqFKMarca As WinCG.PesqFK
    Friend WithEvents PesqFKFornecedor As WinCG.PesqFK
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents txtModelo As TextBox
End Class
