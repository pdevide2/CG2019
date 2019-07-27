<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loja
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim ID_LOJALabel As System.Windows.Forms.Label
        Dim SIGLALabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim ENDERECOLabel As System.Windows.Forms.Label
        Dim COMPLEMENTOLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim CIDADELabel As System.Windows.Forms.Label
        Dim BAIRROLabel As System.Windows.Forms.Label
        Dim UFLabel As System.Windows.Forms.Label
        Me.btnHistorico = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtVigenciaFinal = New System.Windows.Forms.TextBox()
        Me.txtVigenciaInicio = New System.Windows.Forms.TextBox()
        Me.txtUltimaAlteracao = New System.Windows.Forms.TextBox()
        Me.chkInativo = New System.Windows.Forms.CheckBox()
        Me.txtCelular6 = New System.Windows.Forms.TextBox()
        Me.txtCelular5 = New System.Windows.Forms.TextBox()
        Me.txtCelular4 = New System.Windows.Forms.TextBox()
        Me.txtCelular3 = New System.Windows.Forms.TextBox()
        Me.txtCelular2 = New System.Windows.Forms.TextBox()
        Me.txtTelefone2 = New System.Windows.Forms.TextBox()
        Me.txtUnico = New System.Windows.Forms.TextBox()
        Me.PesqFkArea = New WinCG.PesqFK()
        Me.PesqFKAlocacao = New WinCG.PesqFK()
        Me.PesqFkResponsavel = New WinCG.PesqFK()
        Me.chkParceria = New System.Windows.Forms.CheckBox()
        Me.chkLojaFisica = New System.Windows.Forms.CheckBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtSigla = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.PicFotoLoja = New System.Windows.Forms.PictureBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        ID_LOJALabel = New System.Windows.Forms.Label()
        SIGLALabel = New System.Windows.Forms.Label()
        NOMELabel = New System.Windows.Forms.Label()
        ENDERECOLabel = New System.Windows.Forms.Label()
        COMPLEMENTOLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        CIDADELabel = New System.Windows.Forms.Label()
        BAIRROLabel = New System.Windows.Forms.Label()
        UFLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PicFotoLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(16, 416)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(89, 13)
        Label6.TabIndex = 94
        Label6.Text = "Término Vigência"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(17, 374)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(76, 13)
        Label5.TabIndex = 92
        Label5.Text = "Inicio Vigência"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(16, 331)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(110, 13)
        Label2.TabIndex = 90
        Label2.Text = "Data Última Alteração"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Red
        Label1.Location = New System.Drawing.Point(17, 11)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(55, 13)
        Label1.TabIndex = 82
        Label1.Text = "CÓDIGO"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(295, 259)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(96, 13)
        Label4.TabIndex = 75
        Label4.Text = "Celular /Whatsapp"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(16, 259)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(76, 13)
        Label3.TabIndex = 73
        Label3.Text = "Telefone FIXO"
        '
        'ID_LOJALabel
        '
        ID_LOJALabel.AutoSize = True
        ID_LOJALabel.Location = New System.Drawing.Point(236, 439)
        ID_LOJALabel.Name = "ID_LOJALabel"
        ID_LOJALabel.Size = New System.Drawing.Size(41, 13)
        ID_LOJALabel.TabIndex = 54
        ID_LOJALabel.Text = "ID Loja"
        '
        'SIGLALabel
        '
        SIGLALabel.AutoSize = True
        SIGLALabel.Location = New System.Drawing.Point(190, 12)
        SIGLALabel.Name = "SIGLALabel"
        SIGLALabel.Size = New System.Drawing.Size(30, 13)
        SIGLALabel.TabIndex = 57
        SIGLALabel.Text = "Sigla"
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(17, 38)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(35, 13)
        NOMELabel.TabIndex = 59
        NOMELabel.Text = "Nome"
        '
        'ENDERECOLabel
        '
        ENDERECOLabel.AutoSize = True
        ENDERECOLabel.Location = New System.Drawing.Point(17, 64)
        ENDERECOLabel.Name = "ENDERECOLabel"
        ENDERECOLabel.Size = New System.Drawing.Size(53, 13)
        ENDERECOLabel.TabIndex = 61
        ENDERECOLabel.Text = "Endereço"
        '
        'COMPLEMENTOLabel
        '
        COMPLEMENTOLabel.AutoSize = True
        COMPLEMENTOLabel.Location = New System.Drawing.Point(17, 90)
        COMPLEMENTOLabel.Name = "COMPLEMENTOLabel"
        COMPLEMENTOLabel.Size = New System.Drawing.Size(71, 13)
        COMPLEMENTOLabel.TabIndex = 63
        COMPLEMENTOLabel.Text = "Complemento"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(295, 90)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(28, 13)
        CEPLabel.TabIndex = 65
        CEPLabel.Text = "CEP"
        '
        'CIDADELabel
        '
        CIDADELabel.AutoSize = True
        CIDADELabel.Location = New System.Drawing.Point(17, 144)
        CIDADELabel.Name = "CIDADELabel"
        CIDADELabel.Size = New System.Drawing.Size(40, 13)
        CIDADELabel.TabIndex = 69
        CIDADELabel.Text = "Cidade"
        '
        'BAIRROLabel
        '
        BAIRROLabel.AutoSize = True
        BAIRROLabel.Location = New System.Drawing.Point(17, 116)
        BAIRROLabel.Name = "BAIRROLabel"
        BAIRROLabel.Size = New System.Drawing.Size(34, 13)
        BAIRROLabel.TabIndex = 67
        BAIRROLabel.Text = "Bairro"
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Location = New System.Drawing.Point(377, 144)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(21, 13)
        UFLabel.TabIndex = 71
        UFLabel.Text = "UF"
        '
        'btnHistorico
        '
        Me.btnHistorico.Location = New System.Drawing.Point(299, 507)
        Me.btnHistorico.Name = "btnHistorico"
        Me.btnHistorico.Size = New System.Drawing.Size(140, 23)
        Me.btnHistorico.TabIndex = 54
        Me.btnHistorico.Text = "Consultar Histórico"
        Me.btnHistorico.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(482, 499)
        Me.TabControl1.TabIndex = 55
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Label6)
        Me.TabPage1.Controls.Add(Me.txtVigenciaFinal)
        Me.TabPage1.Controls.Add(Label5)
        Me.TabPage1.Controls.Add(Me.txtVigenciaInicio)
        Me.TabPage1.Controls.Add(Label2)
        Me.TabPage1.Controls.Add(Me.txtUltimaAlteracao)
        Me.TabPage1.Controls.Add(Me.chkInativo)
        Me.TabPage1.Controls.Add(Me.txtCelular6)
        Me.TabPage1.Controls.Add(Me.txtCelular5)
        Me.TabPage1.Controls.Add(Me.txtCelular4)
        Me.TabPage1.Controls.Add(Me.txtCelular3)
        Me.TabPage1.Controls.Add(Me.txtCelular2)
        Me.TabPage1.Controls.Add(Me.txtTelefone2)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.txtUnico)
        Me.TabPage1.Controls.Add(Me.PesqFkArea)
        Me.TabPage1.Controls.Add(Me.PesqFKAlocacao)
        Me.TabPage1.Controls.Add(Me.PesqFkResponsavel)
        Me.TabPage1.Controls.Add(Me.chkParceria)
        Me.TabPage1.Controls.Add(Me.chkLojaFisica)
        Me.TabPage1.Controls.Add(Label4)
        Me.TabPage1.Controls.Add(Me.txtCelular)
        Me.TabPage1.Controls.Add(Label3)
        Me.TabPage1.Controls.Add(Me.txtTelefone)
        Me.TabPage1.Controls.Add(ID_LOJALabel)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(SIGLALabel)
        Me.TabPage1.Controls.Add(Me.txtSigla)
        Me.TabPage1.Controls.Add(NOMELabel)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(ENDERECOLabel)
        Me.TabPage1.Controls.Add(Me.txtEndereco)
        Me.TabPage1.Controls.Add(COMPLEMENTOLabel)
        Me.TabPage1.Controls.Add(Me.txtComplemento)
        Me.TabPage1.Controls.Add(CEPLabel)
        Me.TabPage1.Controls.Add(Me.txtCep)
        Me.TabPage1.Controls.Add(CIDADELabel)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(BAIRROLabel)
        Me.TabPage1.Controls.Add(Me.txtBairro)
        Me.TabPage1.Controls.Add(UFLabel)
        Me.TabPage1.Controls.Add(Me.txtUf)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(474, 473)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtVigenciaFinal
        '
        Me.txtVigenciaFinal.Enabled = False
        Me.txtVigenciaFinal.Location = New System.Drawing.Point(16, 436)
        Me.txtVigenciaFinal.Name = "txtVigenciaFinal"
        Me.txtVigenciaFinal.Size = New System.Drawing.Size(141, 20)
        Me.txtVigenciaFinal.TabIndex = 95
        Me.txtVigenciaFinal.Tag = ""
        '
        'txtVigenciaInicio
        '
        Me.txtVigenciaInicio.Location = New System.Drawing.Point(16, 390)
        Me.txtVigenciaInicio.Name = "txtVigenciaInicio"
        Me.txtVigenciaInicio.Size = New System.Drawing.Size(141, 20)
        Me.txtVigenciaInicio.TabIndex = 93
        Me.txtVigenciaInicio.Tag = ""
        '
        'txtUltimaAlteracao
        '
        Me.txtUltimaAlteracao.Location = New System.Drawing.Point(16, 351)
        Me.txtUltimaAlteracao.Name = "txtUltimaAlteracao"
        Me.txtUltimaAlteracao.Size = New System.Drawing.Size(141, 20)
        Me.txtUltimaAlteracao.TabIndex = 91
        Me.txtUltimaAlteracao.Tag = ""
        '
        'chkInativo
        '
        Me.chkInativo.AutoSize = True
        Me.chkInativo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkInativo.Location = New System.Drawing.Point(378, 439)
        Me.chkInativo.Name = "chkInativo"
        Me.chkInativo.Size = New System.Drawing.Size(58, 17)
        Me.chkInativo.TabIndex = 89
        Me.chkInativo.Text = "Inativo"
        Me.chkInativo.UseVisualStyleBackColor = True
        '
        'txtCelular6
        '
        Me.txtCelular6.Location = New System.Drawing.Point(294, 412)
        Me.txtCelular6.Name = "txtCelular6"
        Me.txtCelular6.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular6.TabIndex = 88
        Me.txtCelular6.Tag = ""
        '
        'txtCelular5
        '
        Me.txtCelular5.Location = New System.Drawing.Point(294, 386)
        Me.txtCelular5.Name = "txtCelular5"
        Me.txtCelular5.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular5.TabIndex = 87
        Me.txtCelular5.Tag = ""
        '
        'txtCelular4
        '
        Me.txtCelular4.Location = New System.Drawing.Point(294, 360)
        Me.txtCelular4.Name = "txtCelular4"
        Me.txtCelular4.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular4.TabIndex = 86
        Me.txtCelular4.Tag = ""
        '
        'txtCelular3
        '
        Me.txtCelular3.Location = New System.Drawing.Point(294, 331)
        Me.txtCelular3.Name = "txtCelular3"
        Me.txtCelular3.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular3.TabIndex = 85
        Me.txtCelular3.Tag = ""
        '
        'txtCelular2
        '
        Me.txtCelular2.Location = New System.Drawing.Point(294, 305)
        Me.txtCelular2.Name = "txtCelular2"
        Me.txtCelular2.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular2.TabIndex = 84
        Me.txtCelular2.Tag = ""
        '
        'txtTelefone2
        '
        Me.txtTelefone2.Location = New System.Drawing.Point(16, 305)
        Me.txtTelefone2.Name = "txtTelefone2"
        Me.txtTelefone2.Size = New System.Drawing.Size(141, 20)
        Me.txtTelefone2.TabIndex = 83
        Me.txtTelefone2.Tag = ""
        '
        'txtUnico
        '
        Me.txtUnico.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnico.ForeColor = System.Drawing.Color.Blue
        Me.txtUnico.Location = New System.Drawing.Point(91, 6)
        Me.txtUnico.Name = "txtUnico"
        Me.txtUnico.Size = New System.Drawing.Size(93, 23)
        Me.txtUnico.TabIndex = 56
        '
        'PesqFkArea
        '
        Me.PesqFkArea.CampoDesc = Nothing
        Me.PesqFkArea.CampoId = Nothing
        Me.PesqFkArea.Clicou = "0"
        Me.PesqFkArea.CodigoSelecionado = Nothing
        Me.PesqFkArea.ColunasFiltro = Nothing
        Me.PesqFkArea.DescricaoSelecionada = Nothing
        Me.PesqFkArea.FiltroSQL = Nothing
        Me.PesqFkArea.LabelBuscaDesc = Nothing
        Me.PesqFkArea.LabelBuscaId = Nothing
        Me.PesqFkArea.LabelPesqFK = "Área"
        Me.PesqFkArea.ListaCampos = Nothing
        Me.PesqFkArea.Location = New System.Drawing.Point(19, 195)
        Me.PesqFkArea.Name = "PesqFkArea"
        Me.PesqFkArea.ObjModelFk = Nothing
        Me.PesqFkArea.PosValida = False
        Me.PesqFkArea.Size = New System.Drawing.Size(416, 25)
        Me.PesqFkArea.Tabela = Nothing
        Me.PesqFkArea.TabIndex = 81
        Me.PesqFkArea.TituloTela = Nothing
        Me.PesqFkArea.View = Nothing
        '
        'PesqFKAlocacao
        '
        Me.PesqFKAlocacao.CampoDesc = Nothing
        Me.PesqFKAlocacao.CampoId = Nothing
        Me.PesqFKAlocacao.Clicou = "0"
        Me.PesqFKAlocacao.CodigoSelecionado = Nothing
        Me.PesqFKAlocacao.ColunasFiltro = Nothing
        Me.PesqFKAlocacao.DescricaoSelecionada = Nothing
        Me.PesqFKAlocacao.FiltroSQL = Nothing
        Me.PesqFKAlocacao.LabelBuscaDesc = Nothing
        Me.PesqFKAlocacao.LabelBuscaId = Nothing
        Me.PesqFKAlocacao.LabelPesqFK = "Alocação"
        Me.PesqFKAlocacao.ListaCampos = Nothing
        Me.PesqFKAlocacao.Location = New System.Drawing.Point(19, 166)
        Me.PesqFKAlocacao.Name = "PesqFKAlocacao"
        Me.PesqFKAlocacao.ObjModelFk = Nothing
        Me.PesqFKAlocacao.PosValida = False
        Me.PesqFKAlocacao.Size = New System.Drawing.Size(416, 25)
        Me.PesqFKAlocacao.Tabela = Nothing
        Me.PesqFKAlocacao.TabIndex = 80
        Me.PesqFKAlocacao.TituloTela = Nothing
        Me.PesqFKAlocacao.View = Nothing
        '
        'PesqFkResponsavel
        '
        Me.PesqFkResponsavel.CampoDesc = Nothing
        Me.PesqFkResponsavel.CampoId = Nothing
        Me.PesqFkResponsavel.Clicou = "0"
        Me.PesqFkResponsavel.CodigoSelecionado = Nothing
        Me.PesqFkResponsavel.ColunasFiltro = Nothing
        Me.PesqFkResponsavel.DescricaoSelecionada = Nothing
        Me.PesqFkResponsavel.FiltroSQL = Nothing
        Me.PesqFkResponsavel.LabelBuscaDesc = Nothing
        Me.PesqFkResponsavel.LabelBuscaId = Nothing
        Me.PesqFkResponsavel.LabelPesqFK = "Responsável"
        Me.PesqFkResponsavel.ListaCampos = Nothing
        Me.PesqFkResponsavel.Location = New System.Drawing.Point(19, 222)
        Me.PesqFkResponsavel.Name = "PesqFkResponsavel"
        Me.PesqFkResponsavel.ObjModelFk = Nothing
        Me.PesqFkResponsavel.PosValida = False
        Me.PesqFkResponsavel.Size = New System.Drawing.Size(416, 25)
        Me.PesqFkResponsavel.Tabela = Nothing
        Me.PesqFkResponsavel.TabIndex = 79
        Me.PesqFkResponsavel.TituloTela = Nothing
        Me.PesqFkResponsavel.View = Nothing
        '
        'chkParceria
        '
        Me.chkParceria.AutoSize = True
        Me.chkParceria.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkParceria.Location = New System.Drawing.Point(212, 308)
        Me.chkParceria.Name = "chkParceria"
        Me.chkParceria.Size = New System.Drawing.Size(65, 17)
        Me.chkParceria.TabIndex = 78
        Me.chkParceria.Text = "Parceria"
        Me.chkParceria.UseVisualStyleBackColor = True
        '
        'chkLojaFisica
        '
        Me.chkLojaFisica.AutoSize = True
        Me.chkLojaFisica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLojaFisica.Location = New System.Drawing.Point(193, 279)
        Me.chkLojaFisica.Name = "chkLojaFisica"
        Me.chkLojaFisica.Size = New System.Drawing.Size(84, 17)
        Me.chkLojaFisica.TabIndex = 77
        Me.chkLojaFisica.Text = "Loja Física  "
        Me.chkLojaFisica.UseVisualStyleBackColor = True
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(295, 279)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular.TabIndex = 76
        Me.txtCelular.Tag = ""
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(16, 279)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(141, 20)
        Me.txtTelefone.TabIndex = 74
        Me.txtTelefone.Tag = ""
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(295, 436)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(65, 20)
        Me.txtCodigo.TabIndex = 55
        '
        'txtSigla
        '
        Me.txtSigla.Location = New System.Drawing.Point(237, 9)
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(200, 20)
        Me.txtSigla.TabIndex = 58
        Me.txtSigla.Tag = "Sigla"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(91, 35)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(346, 20)
        Me.txtNome.TabIndex = 60
        Me.txtNome.Tag = "Nome da Loja"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(91, 61)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(346, 20)
        Me.txtEndereco.TabIndex = 62
        Me.txtEndereco.Tag = "Endereço"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(91, 87)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(200, 20)
        Me.txtComplemento.TabIndex = 64
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(331, 87)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(106, 20)
        Me.txtCep.TabIndex = 66
        Me.txtCep.Tag = "CEP"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(91, 140)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(280, 20)
        Me.txtCidade.TabIndex = 70
        Me.txtCidade.Tag = "Cidade"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(91, 113)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(345, 20)
        Me.txtBairro.TabIndex = 68
        Me.txtBairro.Tag = "Bairro"
        '
        'txtUf
        '
        Me.txtUf.Location = New System.Drawing.Point(406, 140)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(31, 20)
        Me.txtUf.TabIndex = 72
        Me.txtUf.Tag = "UF"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.btnAddImage)
        Me.TabPage2.Controls.Add(Me.PicFotoLoja)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(474, 473)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Foto Fachada"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Normal", "StretchImage", "AutoSize", "CenterImage", "Zoom"})
        Me.ComboBox1.Location = New System.Drawing.Point(203, 440)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(261, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(118, 443)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Ajustar Imagem"
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(11, 438)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(101, 23)
        Me.btnAddImage.TabIndex = 1
        Me.btnAddImage.Text = "Alterar Imagem..."
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'PicFotoLoja
        '
        Me.PicFotoLoja.Location = New System.Drawing.Point(11, 10)
        Me.PicFotoLoja.Name = "PicFotoLoja"
        Me.PicFotoLoja.Size = New System.Drawing.Size(453, 422)
        Me.PicFotoLoja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicFotoLoja.TabIndex = 0
        Me.PicFotoLoja.TabStop = False
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'Loja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 541)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnHistorico)
        Me.Name = "Loja"
        Me.Text = "Cadastro de Lojas"
        Me.Controls.SetChildIndex(Me.btnHistorico, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PicFotoLoja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHistorico As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtVigenciaFinal As TextBox
    Friend WithEvents txtVigenciaInicio As TextBox
    Friend WithEvents txtUltimaAlteracao As TextBox
    Friend WithEvents chkInativo As CheckBox
    Friend WithEvents txtCelular6 As TextBox
    Friend WithEvents txtCelular5 As TextBox
    Friend WithEvents txtCelular4 As TextBox
    Friend WithEvents txtCelular3 As TextBox
    Friend WithEvents txtCelular2 As TextBox
    Friend WithEvents txtTelefone2 As TextBox
    Friend WithEvents txtUnico As TextBox
    Friend WithEvents PesqFkArea As PesqFK
    Friend WithEvents PesqFKAlocacao As PesqFK
    Friend WithEvents PesqFkResponsavel As PesqFK
    Friend WithEvents chkParceria As CheckBox
    Friend WithEvents chkLojaFisica As CheckBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtSigla As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents txtCep As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents txtUf As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnAddImage As Button
    Friend WithEvents PicFotoLoja As PictureBox
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
End Class
