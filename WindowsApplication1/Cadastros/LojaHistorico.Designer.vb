<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LojaHistorico
    Inherits modeloCadastro

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ID_LOJALabel As System.Windows.Forms.Label
        Dim SIGLALabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim ENDERECOLabel As System.Windows.Forms.Label
        Dim COMPLEMENTOLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim CIDADELabel As System.Windows.Forms.Label
        Dim BAIRROLabel As System.Windows.Forms.Label
        Dim UFLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtSigla = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.txtUnico = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.chkLojaFisica = New System.Windows.Forms.CheckBox()
        Me.chkParceria = New System.Windows.Forms.CheckBox()
        Me.PesqFkResponsavel = New WinCG.PesqFK()
        Me.PesqFKAlocacao = New WinCG.PesqFK()
        Me.PesqFkArea = New WinCG.PesqFK()
        Me.txtTelefone2 = New System.Windows.Forms.TextBox()
        Me.txtCelular2 = New System.Windows.Forms.TextBox()
        Me.txtCelular3 = New System.Windows.Forms.TextBox()
        Me.txtCelular4 = New System.Windows.Forms.TextBox()
        Me.txtCelular5 = New System.Windows.Forms.TextBox()
        Me.txtCelular6 = New System.Windows.Forms.TextBox()
        Me.chkInativo = New System.Windows.Forms.CheckBox()
        Me.txtUltimaAlteracao = New System.Windows.Forms.TextBox()
        Me.txtVigenciaInicio = New System.Windows.Forms.TextBox()
        Me.txtVigenciaFinal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.dgvDados1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIdHistorico = New System.Windows.Forms.TextBox()
        ID_LOJALabel = New System.Windows.Forms.Label()
        SIGLALabel = New System.Windows.Forms.Label()
        NOMELabel = New System.Windows.Forms.Label()
        ENDERECOLabel = New System.Windows.Forms.Label()
        COMPLEMENTOLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        CIDADELabel = New System.Windows.Forms.Label()
        BAIRROLabel = New System.Windows.Forms.Label()
        UFLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDados1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_LOJALabel
        '
        ID_LOJALabel.AutoSize = True
        ID_LOJALabel.Location = New System.Drawing.Point(628, 476)
        ID_LOJALabel.Name = "ID_LOJALabel"
        ID_LOJALabel.Size = New System.Drawing.Size(41, 13)
        ID_LOJALabel.TabIndex = 0
        ID_LOJALabel.Text = "ID Loja"
        '
        'SIGLALabel
        '
        SIGLALabel.AutoSize = True
        SIGLALabel.Location = New System.Drawing.Point(582, 49)
        SIGLALabel.Name = "SIGLALabel"
        SIGLALabel.Size = New System.Drawing.Size(30, 13)
        SIGLALabel.TabIndex = 2
        SIGLALabel.Text = "Sigla"
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(409, 75)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(35, 13)
        NOMELabel.TabIndex = 4
        NOMELabel.Text = "Nome"
        '
        'ENDERECOLabel
        '
        ENDERECOLabel.AutoSize = True
        ENDERECOLabel.Location = New System.Drawing.Point(409, 101)
        ENDERECOLabel.Name = "ENDERECOLabel"
        ENDERECOLabel.Size = New System.Drawing.Size(53, 13)
        ENDERECOLabel.TabIndex = 6
        ENDERECOLabel.Text = "Endereço"
        '
        'COMPLEMENTOLabel
        '
        COMPLEMENTOLabel.AutoSize = True
        COMPLEMENTOLabel.Location = New System.Drawing.Point(409, 127)
        COMPLEMENTOLabel.Name = "COMPLEMENTOLabel"
        COMPLEMENTOLabel.Size = New System.Drawing.Size(71, 13)
        COMPLEMENTOLabel.TabIndex = 8
        COMPLEMENTOLabel.Text = "Complemento"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(687, 127)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(28, 13)
        CEPLabel.TabIndex = 10
        CEPLabel.Text = "CEP"
        '
        'CIDADELabel
        '
        CIDADELabel.AutoSize = True
        CIDADELabel.Location = New System.Drawing.Point(409, 181)
        CIDADELabel.Name = "CIDADELabel"
        CIDADELabel.Size = New System.Drawing.Size(40, 13)
        CIDADELabel.TabIndex = 14
        CIDADELabel.Text = "Cidade"
        '
        'BAIRROLabel
        '
        BAIRROLabel.AutoSize = True
        BAIRROLabel.Location = New System.Drawing.Point(409, 153)
        BAIRROLabel.Name = "BAIRROLabel"
        BAIRROLabel.Size = New System.Drawing.Size(34, 13)
        BAIRROLabel.TabIndex = 12
        BAIRROLabel.Text = "Bairro"
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Location = New System.Drawing.Point(769, 181)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(21, 13)
        UFLabel.TabIndex = 16
        UFLabel.Text = "UF"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(408, 296)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(76, 13)
        Label3.TabIndex = 31
        Label3.Text = "Telefone FIXO"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(687, 296)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(96, 13)
        Label4.TabIndex = 33
        Label4.Text = "Celular /Whatsapp"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Red
        Label1.Location = New System.Drawing.Point(409, 48)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(55, 13)
        Label1.TabIndex = 40
        Label1.Text = "CÓDIGO"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(408, 368)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(110, 13)
        Label2.TabIndex = 48
        Label2.Text = "Data Última Alteração"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(409, 411)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(76, 13)
        Label5.TabIndex = 50
        Label5.Text = "Inicio Vigência"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(408, 453)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(89, 13)
        Label6.TabIndex = 52
        Label6.Text = "Término Vigência"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(687, 473)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(65, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtSigla
        '
        Me.txtSigla.Location = New System.Drawing.Point(629, 46)
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(200, 20)
        Me.txtSigla.TabIndex = 3
        Me.txtSigla.Tag = "Sigla"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(483, 72)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(346, 20)
        Me.txtNome.TabIndex = 5
        Me.txtNome.Tag = "Nome da Loja"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(483, 98)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(346, 20)
        Me.txtEndereco.TabIndex = 7
        Me.txtEndereco.Tag = "Endereço"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(483, 124)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(200, 20)
        Me.txtComplemento.TabIndex = 9
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(723, 124)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(106, 20)
        Me.txtCep.TabIndex = 11
        Me.txtCep.Tag = "CEP"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(483, 177)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(280, 20)
        Me.txtCidade.TabIndex = 15
        Me.txtCidade.Tag = "Cidade"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(483, 150)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(345, 20)
        Me.txtBairro.TabIndex = 13
        Me.txtBairro.Tag = "Bairro"
        '
        'txtUf
        '
        Me.txtUf.Location = New System.Drawing.Point(798, 177)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(31, 20)
        Me.txtUf.TabIndex = 17
        Me.txtUf.Tag = "UF"
        '
        'txtUnico
        '
        Me.txtUnico.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnico.ForeColor = System.Drawing.Color.Blue
        Me.txtUnico.Location = New System.Drawing.Point(483, 43)
        Me.txtUnico.Name = "txtUnico"
        Me.txtUnico.Size = New System.Drawing.Size(93, 23)
        Me.txtUnico.TabIndex = 1
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(408, 316)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(141, 20)
        Me.txtTelefone.TabIndex = 32
        Me.txtTelefone.Tag = ""
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(687, 316)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular.TabIndex = 34
        Me.txtCelular.Tag = ""
        '
        'chkLojaFisica
        '
        Me.chkLojaFisica.AutoSize = True
        Me.chkLojaFisica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLojaFisica.Location = New System.Drawing.Point(585, 316)
        Me.chkLojaFisica.Name = "chkLojaFisica"
        Me.chkLojaFisica.Size = New System.Drawing.Size(84, 17)
        Me.chkLojaFisica.TabIndex = 35
        Me.chkLojaFisica.Text = "Loja Física  "
        Me.chkLojaFisica.UseVisualStyleBackColor = True
        '
        'chkParceria
        '
        Me.chkParceria.AutoSize = True
        Me.chkParceria.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkParceria.Location = New System.Drawing.Point(604, 345)
        Me.chkParceria.Name = "chkParceria"
        Me.chkParceria.Size = New System.Drawing.Size(65, 17)
        Me.chkParceria.TabIndex = 36
        Me.chkParceria.Text = "Parceria"
        Me.chkParceria.UseVisualStyleBackColor = True
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
        Me.PesqFkResponsavel.Location = New System.Drawing.Point(411, 259)
        Me.PesqFkResponsavel.Name = "PesqFkResponsavel"
        Me.PesqFkResponsavel.ObjModelFk = Nothing
        Me.PesqFkResponsavel.PosValida = False
        Me.PesqFkResponsavel.Size = New System.Drawing.Size(416, 25)
        Me.PesqFkResponsavel.Tabela = Nothing
        Me.PesqFkResponsavel.TabIndex = 37
        Me.PesqFkResponsavel.TituloTela = Nothing
        Me.PesqFkResponsavel.View = Nothing
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
        Me.PesqFKAlocacao.Location = New System.Drawing.Point(411, 203)
        Me.PesqFKAlocacao.Name = "PesqFKAlocacao"
        Me.PesqFKAlocacao.ObjModelFk = Nothing
        Me.PesqFKAlocacao.PosValida = False
        Me.PesqFKAlocacao.Size = New System.Drawing.Size(416, 25)
        Me.PesqFKAlocacao.Tabela = Nothing
        Me.PesqFKAlocacao.TabIndex = 38
        Me.PesqFKAlocacao.TituloTela = Nothing
        Me.PesqFKAlocacao.View = Nothing
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
        Me.PesqFkArea.Location = New System.Drawing.Point(411, 232)
        Me.PesqFkArea.Name = "PesqFkArea"
        Me.PesqFkArea.ObjModelFk = Nothing
        Me.PesqFkArea.PosValida = False
        Me.PesqFkArea.Size = New System.Drawing.Size(416, 25)
        Me.PesqFkArea.Tabela = Nothing
        Me.PesqFkArea.TabIndex = 39
        Me.PesqFkArea.TituloTela = Nothing
        Me.PesqFkArea.View = Nothing
        '
        'txtTelefone2
        '
        Me.txtTelefone2.Location = New System.Drawing.Point(408, 342)
        Me.txtTelefone2.Name = "txtTelefone2"
        Me.txtTelefone2.Size = New System.Drawing.Size(141, 20)
        Me.txtTelefone2.TabIndex = 41
        Me.txtTelefone2.Tag = ""
        '
        'txtCelular2
        '
        Me.txtCelular2.Location = New System.Drawing.Point(686, 342)
        Me.txtCelular2.Name = "txtCelular2"
        Me.txtCelular2.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular2.TabIndex = 42
        Me.txtCelular2.Tag = ""
        '
        'txtCelular3
        '
        Me.txtCelular3.Location = New System.Drawing.Point(686, 368)
        Me.txtCelular3.Name = "txtCelular3"
        Me.txtCelular3.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular3.TabIndex = 43
        Me.txtCelular3.Tag = ""
        '
        'txtCelular4
        '
        Me.txtCelular4.Location = New System.Drawing.Point(686, 397)
        Me.txtCelular4.Name = "txtCelular4"
        Me.txtCelular4.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular4.TabIndex = 44
        Me.txtCelular4.Tag = ""
        '
        'txtCelular5
        '
        Me.txtCelular5.Location = New System.Drawing.Point(686, 423)
        Me.txtCelular5.Name = "txtCelular5"
        Me.txtCelular5.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular5.TabIndex = 45
        Me.txtCelular5.Tag = ""
        '
        'txtCelular6
        '
        Me.txtCelular6.Location = New System.Drawing.Point(686, 449)
        Me.txtCelular6.Name = "txtCelular6"
        Me.txtCelular6.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular6.TabIndex = 46
        Me.txtCelular6.Tag = ""
        '
        'chkInativo
        '
        Me.chkInativo.AutoSize = True
        Me.chkInativo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkInativo.Location = New System.Drawing.Point(770, 476)
        Me.chkInativo.Name = "chkInativo"
        Me.chkInativo.Size = New System.Drawing.Size(58, 17)
        Me.chkInativo.TabIndex = 47
        Me.chkInativo.Text = "Inativo"
        Me.chkInativo.UseVisualStyleBackColor = True
        '
        'txtUltimaAlteracao
        '
        Me.txtUltimaAlteracao.Location = New System.Drawing.Point(408, 388)
        Me.txtUltimaAlteracao.Name = "txtUltimaAlteracao"
        Me.txtUltimaAlteracao.Size = New System.Drawing.Size(141, 20)
        Me.txtUltimaAlteracao.TabIndex = 49
        Me.txtUltimaAlteracao.Tag = ""
        '
        'txtVigenciaInicio
        '
        Me.txtVigenciaInicio.Location = New System.Drawing.Point(408, 427)
        Me.txtVigenciaInicio.Name = "txtVigenciaInicio"
        Me.txtVigenciaInicio.Size = New System.Drawing.Size(141, 20)
        Me.txtVigenciaInicio.TabIndex = 51
        Me.txtVigenciaInicio.Tag = ""
        '
        'txtVigenciaFinal
        '
        Me.txtVigenciaFinal.Enabled = False
        Me.txtVigenciaFinal.Location = New System.Drawing.Point(408, 473)
        Me.txtVigenciaFinal.Name = "txtVigenciaFinal"
        Me.txtVigenciaFinal.Size = New System.Drawing.Size(141, 20)
        Me.txtVigenciaFinal.TabIndex = 53
        Me.txtVigenciaFinal.Tag = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dgvDados2)
        Me.GroupBox1.Controls.Add(Me.dgvDados1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 497)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(291, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(148, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Localizar por código da Loja"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Históricos da Loja Selecionada"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Lojas"
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(6, 314)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.ReadOnly = True
        Me.dgvDados2.Size = New System.Drawing.Size(384, 171)
        Me.dgvDados2.TabIndex = 1
        '
        'dgvDados1
        '
        Me.dgvDados1.AllowUserToAddRows = False
        Me.dgvDados1.AllowUserToDeleteRows = False
        Me.dgvDados1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados1.Location = New System.Drawing.Point(6, 41)
        Me.dgvDados1.Name = "dgvDados1"
        Me.dgvDados1.ReadOnly = True
        Me.dgvDados1.Size = New System.Drawing.Size(384, 241)
        Me.dgvDados1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(401, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "ID Histórico"
        '
        'txtIdHistorico
        '
        Me.txtIdHistorico.Enabled = False
        Me.txtIdHistorico.Location = New System.Drawing.Point(483, 16)
        Me.txtIdHistorico.Name = "txtIdHistorico"
        Me.txtIdHistorico.ReadOnly = True
        Me.txtIdHistorico.Size = New System.Drawing.Size(93, 20)
        Me.txtIdHistorico.TabIndex = 56
        '
        'LojaHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 541)
        Me.Controls.Add(Me.txtIdHistorico)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.txtVigenciaFinal)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.txtVigenciaInicio)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtUltimaAlteracao)
        Me.Controls.Add(Me.chkInativo)
        Me.Controls.Add(Me.txtCelular6)
        Me.Controls.Add(Me.txtCelular5)
        Me.Controls.Add(Me.txtCelular4)
        Me.Controls.Add(Me.txtCelular3)
        Me.Controls.Add(Me.txtCelular2)
        Me.Controls.Add(Me.txtTelefone2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtUnico)
        Me.Controls.Add(Me.PesqFkArea)
        Me.Controls.Add(Me.PesqFKAlocacao)
        Me.Controls.Add(Me.PesqFkResponsavel)
        Me.Controls.Add(Me.chkParceria)
        Me.Controls.Add(Me.chkLojaFisica)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(ID_LOJALabel)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(SIGLALabel)
        Me.Controls.Add(Me.txtSigla)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(ENDERECOLabel)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(COMPLEMENTOLabel)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(CEPLabel)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(CIDADELabel)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(BAIRROLabel)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(UFLabel)
        Me.Controls.Add(Me.txtUf)
        Me.Name = "LojaHistorico"
        Me.Text = "Histórico do Cadastro de Lojas"
        Me.Controls.SetChildIndex(Me.txtUf, 0)
        Me.Controls.SetChildIndex(UFLabel, 0)
        Me.Controls.SetChildIndex(Me.txtBairro, 0)
        Me.Controls.SetChildIndex(BAIRROLabel, 0)
        Me.Controls.SetChildIndex(Me.txtCidade, 0)
        Me.Controls.SetChildIndex(CIDADELabel, 0)
        Me.Controls.SetChildIndex(Me.txtCep, 0)
        Me.Controls.SetChildIndex(CEPLabel, 0)
        Me.Controls.SetChildIndex(Me.txtComplemento, 0)
        Me.Controls.SetChildIndex(COMPLEMENTOLabel, 0)
        Me.Controls.SetChildIndex(Me.txtEndereco, 0)
        Me.Controls.SetChildIndex(ENDERECOLabel, 0)
        Me.Controls.SetChildIndex(Me.txtNome, 0)
        Me.Controls.SetChildIndex(NOMELabel, 0)
        Me.Controls.SetChildIndex(Me.txtSigla, 0)
        Me.Controls.SetChildIndex(SIGLALabel, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(ID_LOJALabel, 0)
        Me.Controls.SetChildIndex(Me.txtTelefone, 0)
        Me.Controls.SetChildIndex(Label3, 0)
        Me.Controls.SetChildIndex(Me.txtCelular, 0)
        Me.Controls.SetChildIndex(Label4, 0)
        Me.Controls.SetChildIndex(Me.chkLojaFisica, 0)
        Me.Controls.SetChildIndex(Me.chkParceria, 0)
        Me.Controls.SetChildIndex(Me.PesqFkResponsavel, 0)
        Me.Controls.SetChildIndex(Me.PesqFKAlocacao, 0)
        Me.Controls.SetChildIndex(Me.PesqFkArea, 0)
        Me.Controls.SetChildIndex(Me.txtUnico, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.Controls.SetChildIndex(Me.txtTelefone2, 0)
        Me.Controls.SetChildIndex(Me.txtCelular2, 0)
        Me.Controls.SetChildIndex(Me.txtCelular3, 0)
        Me.Controls.SetChildIndex(Me.txtCelular4, 0)
        Me.Controls.SetChildIndex(Me.txtCelular5, 0)
        Me.Controls.SetChildIndex(Me.txtCelular6, 0)
        Me.Controls.SetChildIndex(Me.chkInativo, 0)
        Me.Controls.SetChildIndex(Me.txtUltimaAlteracao, 0)
        Me.Controls.SetChildIndex(Label2, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaInicio, 0)
        Me.Controls.SetChildIndex(Label5, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaFinal, 0)
        Me.Controls.SetChildIndex(Label6, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.txtIdHistorico, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDados1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtSigla As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtCep As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtUf As System.Windows.Forms.TextBox
    Friend WithEvents txtUnico As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents chkLojaFisica As System.Windows.Forms.CheckBox
    Friend WithEvents chkParceria As System.Windows.Forms.CheckBox
    Friend WithEvents PesqFkResponsavel As WinCG.PesqFK
    Friend WithEvents PesqFKAlocacao As WinCG.PesqFK
    Friend WithEvents PesqFkArea As WinCG.PesqFK
    Friend WithEvents txtTelefone2 As TextBox
    Friend WithEvents txtCelular2 As TextBox
    Friend WithEvents txtCelular3 As TextBox
    Friend WithEvents txtCelular4 As TextBox
    Friend WithEvents txtCelular5 As TextBox
    Friend WithEvents txtCelular6 As TextBox
    Friend WithEvents chkInativo As CheckBox
    Friend WithEvents txtUltimaAlteracao As TextBox
    Friend WithEvents txtVigenciaInicio As TextBox
    Friend WithEvents txtVigenciaFinal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDados2 As DataGridView
    Friend WithEvents dgvDados1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIdHistorico As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
End Class
