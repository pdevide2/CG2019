Imports DTO
Imports BLL

Public Class modeloCadastro

    'Dim arrayAcessoTela = DefineAcessoBotao(ACE_MODULO)
    Public arrayAcessoTela() As Boolean = {False, False, False, False}

    Private acessoPesquisa As Boolean
    Public Overridable Property BotaoPesquisa() As Boolean
        Get
            Return acessoPesquisa
        End Get
        Set(ByVal value As Boolean)
            acessoPesquisa = value
        End Set
    End Property
    Private acessoIncluir As Boolean
    Public Overridable Property BotaoIncluir() As Boolean
        Get
            Return acessoIncluir
        End Get
        Set(ByVal value As Boolean)
            acessoIncluir = value
        End Set
    End Property
    Private acessoAlterar As Boolean
    Public Overridable Property BotaoAlterar() As Boolean
        Get
            Return acessoAlterar
        End Get
        Set(ByVal value As Boolean)
            acessoAlterar = value
        End Set
    End Property
    Private acessoExcluir As Boolean
    Public Overridable Property BotaoExcluir() As Boolean
        Get
            Return acessoExcluir
        End Get
        Set(ByVal value As Boolean)
            acessoExcluir = value
        End Set
    End Property

    Public Enum Operacao

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum

    'variavel flagAcao o Default é readonly, após verificar permissão no módulo pode mudar para Limpar (0)
    Public flagAcao As Integer = Operacao.Limpar
    Public _objModelFk As Object

    'variavel com visibilidade apenas dentro do form, indica qual tabela de cadastro. 
    'variavel tabela serve para indicar tambem qual é a tabela de sequenciais
    Dim _acesso As String
    Dim _modulo As Integer
    Dim _tabela As String
    Dim _view As String
    Dim _acao As Integer
    Dim _objModel As Object
    Dim _keyId As Integer
    Dim _keyIdStr As String
    Dim _colunaId As String
    Dim _linhaGrid As DataGridViewRow
    Dim _pkString As Boolean

    Public podeAbrir As Boolean = False

    Public Sub New(ByVal objPermissaoModulo As DTO.PermissaoModulo)

        ' This call is required by the designer.
        InitializeComponent()

        arrayAcessoTela(0) = objPermissaoModulo.Pesquisa
        arrayAcessoTela(1) = objPermissaoModulo.Incluir
        arrayAcessoTela(2) = objPermissaoModulo.Alterar
        arrayAcessoTela(3) = objPermissaoModulo.Excluir

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Overridable Property View() As String
        Get
            Return _view
        End Get
        Set(ByVal value As String)
            _view = value
        End Set
    End Property

    Public Overridable Property PkString() As Boolean
        Get
            Return _pkString
        End Get
        Set(ByVal value As Boolean)
            _pkString = value
        End Set
    End Property


    Public Overridable Property LinhaGrid() As DataGridViewRow
        Get
            Return _linhaGrid
        End Get
        Set(ByVal value As DataGridViewRow)
            _linhaGrid = value
        End Set
    End Property

    Public Overridable Property ColunaId() As String 'Preenchido no método inicio() do form 
        Get                                             'é o nome da coluna chave da tabela
            Return _colunaId
        End Get
        Set(ByVal value As String)
            _colunaId = value
        End Set
    End Property
    Public Overridable Property KeyId() As Integer 'Preenchido no retorno da pesquisa geral
        Get
            Return _keyId
        End Get
        Set(ByVal value As Integer)
            _keyId = value
        End Set
    End Property
    Public Overridable Property KeyIdStr() As String 'Preenchido no retorno da pesquisa geral
        Get
            Return _keyIdStr
        End Get
        Set(ByVal value As String)
            _keyIdStr = value
        End Set
    End Property
    Public Overridable Property ObjModel() As Object
        Get
            Return _objModel
        End Get
        Set(ByVal value As Object)
            _objModel = value
        End Set
    End Property

    Public Overridable Property ObjModelFk() As Object
        Get
            Return _objModelFk
        End Get
        Set(ByVal value As Object)
            _objModelFk = value
        End Set
    End Property

    Public Overridable Property Acao() As Integer
        Get
            Return _acao
        End Get
        Set(ByVal value As Integer)
            _acao = value
        End Set
    End Property
    Public Overridable Property Modulo() As Integer
        Get
            Return _modulo
        End Get
        Set(ByVal value As Integer)
            _modulo = value
        End Set
    End Property
    Public Overridable Property Tabela() As String
        Get
            Return _tabela
        End Get
        Set(ByVal value As String)
            _tabela = value
        End Set
    End Property
    Public Overridable Property Acesso() As String
        Get
            Return _acesso
        End Get
        Set(ByVal value As String)
            _acesso = value
        End Set
    End Property


    Private Sub tsBtnNovo_Click(sender As Object, e As EventArgs) Handles tsBtnNovo.Click
        flagAcao = Operacao.Novo
        Me.Acao = flagAcao
        Incluir()
    End Sub


    Private Sub tsBtnFechar_Click(sender As Object, e As EventArgs) Handles tsBtnFechar.Click
        flagAcao = Operacao.Limpar
        Me.Acao = flagAcao
        Fechar()
    End Sub


    Private Sub tsBtnAlterar_Click(sender As Object, e As EventArgs) Handles tsBtnAlterar.Click
        flagAcao = Operacao.Alterar
        Me.Acao = flagAcao
        Alterar()
    End Sub

    Private Sub tsBtnExcluir_Click(sender As Object, e As EventArgs) Handles tsBtnExcluir.Click
        flagAcao = Operacao.Excluir
        Me.Acao = flagAcao
        Excluir()
    End Sub
    Public Overridable Sub Apos_Incluir()
        'Este método serve para carrega o valor default para alguns controles na operação de Incluir
        HabilitaBotoes(Operacao.Novo)
    End Sub
    
    Public Overridable Sub FocoInicial()

    End Sub

    Public Overridable Sub Incluir()
        HabilitaBotoes(flagAcao) 'Habilita/Desabilita os botões da toolstrip de Navegação
        Limpar_Controles() 'Limpa os textbox e demais controles da tela para nova inclusão
        FocoInicial() 'Setar o foco padrão para algum objeto da tela

    End Sub

    Public Overridable Sub Alterar()
        HabilitaBotoes(Operacao.Alterar)
    End Sub

    Public Overridable Sub Consultar()

    End Sub

    Public Overridable Sub Excluir()
        If MessageBox.Show("Confirma a Exclusão?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
            ExcluirPorId()
        End If

    End Sub
    Public Overridable Sub ExcluirPorId()
        'MessageBox.Show("Excluído", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Public Overridable Sub Gravar(ByVal acao As Integer)

    End Sub

    
    Public Overridable Function ValidaCampos() As Object
        Dim msg As String = ""
        Try

            For Each c In Me.Controls
                Select Case c.GetType()
                    Case GetType(TextBox)

                        If Not String.IsNullOrEmpty(CType(c, TextBox).Tag) Then
                            If String.IsNullOrEmpty(CType(c, TextBox).Text) Then
                                msg += "Campo " & CType(c, TextBox).Tag & " deve ser preenchido!" & vbCr
                            End If
                        End If
                End Select
            Next
            If Not String.IsNullOrEmpty(msg) Then
                Throw New Exception(msg)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function


    Public Overridable Sub Cancelar(ByVal acao As Integer)
        If acao = Operacao.Novo Or acao = Operacao.Excluir Then
            Me.KeyId = 0
            Limpar_Controles()
        End If

        If acao = Operacao.Alterar Then
            Carrega_Controles_Pesquisa()
        End If

        If BotaoPesquisa = True And BotaoIncluir = False And BotaoAlterar = False And BotaoExcluir = False Then
            flagAcao = Operacao.Limpar 'Esta variavel tem que ser setada dentro do metodo cancelar
        Else
            flagAcao = Operacao.Consulta
        End If
        'If Me.Acesso = "L" Then
        '    flagAcao = Operacao.Limpar 'Esta variavel tem que ser setada dentro do metodo cancelar
        '    'ElseIf Me.Acesso = "G" Then
        'Else
        '    flagAcao = Operacao.Consulta
        'End If

        If Me.KeyId = 0 Then
            flagAcao = Operacao.Limpar
        End If

        HabilitaBotoes(flagAcao)
        Habilita_Controles(False) 'modo leitura

    End Sub
    Public Overridable Sub Fechar()
        Me.Close()
        'Me.Dispose()
    End Sub
    Public Overridable Sub Limpar_Controles()
        'Este método é utilizado para limpar os controles antes da Inclusão
        For Each c In Me.Controls
            Select Case c.GetType()
                Case GetType(TextBox)
                    CType(c, TextBox).Text = String.Empty
                Case GetType(ComboBox)
                    CType(c, ComboBox).Text = String.Empty
                Case GetType(CheckBox)
                    CType(c, CheckBox).Checked = False
                Case GetType(MaskedTextBox)
                    CType(c, MaskedTextBox).Text = String.Empty
                Case GetType(ProgressBar)
                    CType(c, ProgressBar).Value = 0
            End Select
        Next
    End Sub
    Public Overridable Sub Habilita_Controles(blnModo As Boolean)
        'Este método é utilizado para limpar os controles antes da Inclusão
        Dim blnAcao As Boolean
        blnAcao = (Not blnModo)

        For Each c In Me.Controls
            Select Case c.GetType()
                Case GetType(TextBox)
                    CType(c, TextBox).ReadOnly = blnAcao
                Case GetType(DateTimePicker)
                    CType(c, DateTimePicker).Enabled = Not (blnAcao)
                Case GetType(ComboBox)
                    CType(c, ComboBox).Enabled = Not (blnAcao)
                Case GetType(CheckBox)
                    CType(c, CheckBox).Enabled = (Not blnAcao)
                Case GetType(MaskedTextBox)
                    CType(c, MaskedTextBox).ReadOnly = blnAcao
                Case GetType(ProgressBar)
                    CType(c, ProgressBar).Enabled = Not (blnAcao)
            End Select
        Next

    End Sub
    Public Overridable Sub HabilitaBotoes(ByVal acao As Integer)
        'MessageBox.Show(flagAcao.ToString)
        tsLblModulo.Text = Me.Modulo.ToString

        Me.BotaoPesquisa = arrayAcessoTela(0)
        Me.BotaoIncluir = arrayAcessoTela(1)
        Me.BotaoAlterar = arrayAcessoTela(2)
        Me.BotaoExcluir = arrayAcessoTela(3)

        Select Case acao
            Case Operacao.Limpar
                tsBtnNovo.Enabled = IIf(Me.BotaoIncluir = True, True, False)
                tsBtnAlterar.Enabled = False
                tsBtnExcluir.Enabled = False
                tsBtnSalvar.Enabled = False
                tsBtnDesfazer.Enabled = False
                tsBtnFechar.Enabled = True
                tsBtnPesquisar.Enabled = IIf(Me.BotaoPesquisa = True, True, False)

            Case Operacao.Novo
                tsBtnNovo.Enabled = False
                tsBtnAlterar.Enabled = False
                tsBtnExcluir.Enabled = False
                tsBtnSalvar.Enabled = True
                tsBtnDesfazer.Enabled = True
                tsBtnFechar.Enabled = False
                tsBtnPesquisar.Enabled = False


            Case Operacao.Alterar
                tsBtnNovo.Enabled = False
                tsBtnAlterar.Enabled = False
                tsBtnExcluir.Enabled = False
                tsBtnSalvar.Enabled = True
                tsBtnDesfazer.Enabled = True
                tsBtnFechar.Enabled = False
                tsBtnPesquisar.Enabled = False

            Case Operacao.Excluir
                tsBtnNovo.Enabled = False
                tsBtnAlterar.Enabled = False
                tsBtnExcluir.Enabled = False
                tsBtnSalvar.Enabled = False
                tsBtnDesfazer.Enabled = False
                tsBtnFechar.Enabled = False
                tsBtnPesquisar.Enabled = False

            Case Operacao.Consulta
                tsBtnNovo.Enabled = IIf(Me.BotaoIncluir = True, True, False)
                tsBtnAlterar.Enabled = IIf(Me.BotaoAlterar = True, True, False)
                tsBtnExcluir.Enabled = IIf(Me.BotaoExcluir = True, True, False)
                tsBtnSalvar.Enabled = False
                tsBtnDesfazer.Enabled = False
                tsBtnFechar.Enabled = True
                tsBtnPesquisar.Enabled = IIf(Me.BotaoPesquisa = True, True, False)

            Case Operacao.Leitura
                tsBtnNovo.Enabled = False
                tsBtnAlterar.Enabled = False
                tsBtnExcluir.Enabled = False
                tsBtnSalvar.Enabled = False
                tsBtnDesfazer.Enabled = False
                tsBtnFechar.Enabled = True
                tsBtnPesquisar.Enabled = IIf(Me.BotaoPesquisa = True, True, False)


            Case Else
                tsBtnNovo.Enabled = IIf(Me.BotaoIncluir = True, True, False)
                tsBtnAlterar.Enabled = False
                tsBtnExcluir.Enabled = False
                tsBtnSalvar.Enabled = False
                tsBtnDesfazer.Enabled = False
                tsBtnFechar.Enabled = True
                tsBtnPesquisar.Enabled = IIf(Me.BotaoPesquisa = True, True, False)

        End Select

    End Sub


    Private Sub tsBtnDesfazer_Click(sender As Object, e As EventArgs) Handles tsBtnDesfazer.Click

        Cancelar(flagAcao)
   

    End Sub

    Private Sub tsBtnSalvar_Click(sender As Object, e As EventArgs) Handles tsBtnSalvar.Click

        Gravar(flagAcao)
        '       flagAcao = Operacao.Limpar 'Esta variavel tem que ser setada dentro do metodo gravar
        HabilitaBotoes(flagAcao)

    End Sub


    Public Overridable Sub inicio()
        Me.PkString = False
        Me.Tabela = ""
        Me.View = ""
        Me.Modulo = 11
        LoginCG()
        'AcessoTela(Me.Modulo, ACE_CODIGO) 'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação)


        HabilitaBotoes(flagAcao)
    End Sub
    'Private Function AcessoTela(ByVal intModulo As Integer, ByVal intUsuario As Integer) As String
    '    'flagAcao = Operacao.Limpar
    '    Dim strPermissao As String = "S"

    '    'strPermissao = verificaPermissao(intModulo, intUsuario)

    '    'Me.Acesso = strPermissao

    '    'If strPermissao = "S" Then
    '    '    MessageBox.Show("Usuário sem permissão de acesso neste módulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    '    Return False
    '    'ElseIf strPermissao = "L" Then
    '    '    flagAcao = Operacao.Leitura
    '    'ElseIf strPermissao = "G" Then
    '    '    flagAcao = Operacao.Limpar
    '    'Else
    '    '    MessageBox.Show("Configurações de permissão para este módulo não encontrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    '    Return False

    '    'End If
    '    'Me.Acao = flagAcao
    '    Dim myRow As ArrayList, comandoSQL As String

    '    comandoSQL = "EXEC spVer_Permissao @ID_MODULO = " & intModulo.ToString
    '    comandoSQL += ", @ID_USUARIO = " & intUsuario.ToString


    '    myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)

    '    If myRow.Count > 0 Then

    '        strPermissao = myRow(0)(0).ToString

    '    End If

    '    Return strPermissao

    'End Function

    Private Function verificaPermissao(ByVal modulo As Integer, ByVal usuario As Integer) As String

        Dim retorno As String
        Dim oBLL As New BLL.GlobalBLL

        retorno = oBLL.getPermissaoBLL(modulo, usuario)
        Return retorno

    End Function

    Private Sub tsBtnPesquisar_Click(sender As Object, e As EventArgs) Handles tsBtnPesquisar.Click
        Pesquisar()
    End Sub

    Public Overridable Sub Pesquisar()
        'Chama um form de pesquisa para filtrar os registros que retorna um DataTable
        'O usuario pode selecionar um registro para Alterar, Visualizar ou Excluir, retornando o objeto Model (DTO) 
        'preenchido, para popular os controles da tela de cadastro
        Dim frm As New PesquisaGeral(Me)

        frm.Owner = Me
        frm.ShowDialog()
        'DefineAcesso()
        If flagAcao = Operacao.Limpar Then
            flagAcao = Operacao.Consulta
        End If
        Me.Acao = flagAcao
        HabilitaBotoes(Me.Acao)
    End Sub

    Public Overridable Sub PesquisaFK(oPesqFk As DTO.PesquisaFK)
        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica(Me, oPesqFk)
        frm.Owner = Me
        frm.ShowDialog()

    End Sub

    Public Overridable Sub PesquisaFK2(oPesqFk As DTO.PesquisaFK)
        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica2(Me, oPesqFk)
        frm.Owner = Me
        frm.ShowDialog()

    End Sub

    Public Overridable Sub Carrega_Controles_Pesquisa()
        'alimenta os txt da tela com a linhaGrid datagridviewrow
    End Sub


    Public Overridable Sub modeloCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginCG() 'Carrega variavel Friend ACE_CODIGO pelo Setting ID_USER
        ' Add any initialization after the InitializeComponent() call.
        'DefineAcesso()

    End Sub


End Class
