'**
'* Descrição: Cadastro de Transito
'* Objetivo.: Responsaveis pelo transporte de chips e pos 
'*              entre a matriz e as lojas e das lojas para a matriz
'* Autor....: PD
'* Create Dt: 03-nov-2017
'**
Public Class Cadtransito
    Private _controleInterno As Boolean
    Public Property ControleInterno() As Boolean
        Get
            Return _controleInterno
        End Get
        Set(ByVal value As Boolean)
            _controleInterno = value
        End Set
    End Property


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal objPermissaoModulo As DTO.PermissaoModulo)

        ' This call is required by the designer.
        InitializeComponent()

        arrayAcessoTela(0) = objPermissaoModulo.Pesquisa
        arrayAcessoTela(1) = objPermissaoModulo.Incluir
        arrayAcessoTela(2) = objPermissaoModulo.Alterar
        arrayAcessoTela(3) = objPermissaoModulo.Excluir

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControleInterno = False
        inicio()

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()
        Me.PkString = False
        Me.Tabela = "CG_TRANSITO" 'Nome da tabela no SQL
        Me.Modulo = 56 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_transito
        Me.ColunaId = "ID_TRANSITO"
        Habilita_Controles(False) 'modo leitura
    End Sub
    Public Overrides Sub Pesquisar()
        MyBase.Pesquisar()
        'MessageBox.Show(Me.KeyId.ToString, "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Carrega_Controles_Pesquisa()
    End Sub

    Public Overrides Sub Carrega_Controles_Pesquisa()
        MyBase.Carrega_Controles_Pesquisa()
        If Me.KeyId <> -1 Then
            txtCodigo.Text = Me.KeyId.ToString
            txtDescricao.Text = Me.LinhaGrid.Cells("nome_transito").Value.ToString
            chkInativo.Checked = CBool(Me.LinhaGrid.Cells("inativo").Value.ToString)
            Me.ControleInterno = CBool(Me.LinhaGrid.Cells("CONTROLE_INTERNO").Value.ToString)
        End If
    End Sub

    Public Overrides Sub Gravar(acao As Integer)
        If Not ValidaCampos() Then
            Exit Sub
        End If
        'MyBase.Gravar(acao)
        Dim bll As New BLL.CadtransitoBLL
        Dim objtransito As New DTO.Cg_transito
        Try
            objtransito.Id_transito = CInt(txtCodigo.Text)
            objtransito.Nome_transito = txtDescricao.Text
            objtransito.Inativo = chkInativo.Checked
            'objtransito.Id_empresa = Publico.Id_empresa


            bll.GravarBLL(acao, objtransito)
            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(False) 'modo leitura

        End Try

    End Sub
    Public Overrides Sub Alterar()
        If Me.ControleInterno = False Then
            MyBase.Alterar()
            Habilita_Controles(True) 'modo digitação
        Else
            flagAcao = Operacao.Consulta
            Me.Acao = flagAcao
            Habilita_Controles(False) 'modo Consulta
            MessageBox.Show("Alteração não permitida, Trânsito de controle interno do Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Overrides Sub Incluir()
        MyBase.Incluir()
        Dim bll As New BLL.GlobalBLL
        Me.KeyId = bll.NovaChaveBLL(Me.Tabela)
        If Me.KeyId > 0 Then
            txtCodigo.Text = Me.KeyId.ToString()
            Habilita_Controles(True) 'modo digitação

        Else
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()

        If Me.ControleInterno = True Then
            MessageBox.Show("Exclusão não permitida, Trânsito de Controle Interno do Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta
            Me.Acao = flagAcao
            Exit Sub
        End If

        MyBase.ExcluirPorId()
        Dim bll As New BLL.CadtransitoBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

End Class