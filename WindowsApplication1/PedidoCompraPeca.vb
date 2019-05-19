Public Class PedidoCompraPeca

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

        inicio()

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()
        Me.PkString = False
        Me.Tabela = "CG_PEDIDO_COMPRA_PECA" 'Nome da tabela no SQL
        Me.View = "VW_CG_PEDIDO_COMPRA_PECA"
        Me.Modulo = 49 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_pedido_compra_peca
        Me.ColunaId = "ID_PEDIDO"
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
            'txtDescricao.Text = Me.LinhaGrid.Cells("DESC_ALOCACAO").Value.ToString
        End If
    End Sub

    Public Overrides Function ValidaCampos() As Object
        'Try
        '    If String.IsNullOrEmpty(txtDescricao.Text) Then
        '        Throw New Exception("Atenção Descrição da Alocação deve ser preenchida!")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'End Try
        Return True
        'Return MyBase.ValidaCampos()
    End Function

    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)

        If Not ValidaCampos() Then
            Exit Sub
        End If

        'Dim bll As New BLL.AlocacaoBLL
        'Dim objAlocacao As New DTO.Cg_alocacao
        'Try
        '    objAlocacao.Id_alocacao = CInt(txtCodigo.Text)
        '    objAlocacao.Desc_alocacao = txtDescricao.Text
        '    objAlocacao.User_ins = ACE_CODIGO
        '    objAlocacao.Data_ins = Hoje()
        '    objAlocacao.User_upd = ACE_CODIGO
        '    objAlocacao.Data_upd = Hoje()

        '    bll.GravarBLL(acao, objAlocacao)
        '    MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    flagAcao = Operacao.Consulta

        'Catch ex As Exception
        '    MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally

        '    Habilita_Controles(False) 'modo leitura

        'End Try

    End Sub
    Public Overrides Sub Alterar()
        MyBase.Alterar()
        Habilita_Controles(True) 'modo digitação


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
        MyBase.ExcluirPorId()
        Dim bll As New BLL.AlocacaoBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim obj As New BLL.CargoBLL

    '    ObjModel = obj.PesquisaPorIdModelBLL(CInt(txtCodigo.Text), Me.Tabela, Me.ColunaId)
    '    Debug.Print(ObjModel.id_cargo)
    '    Debug.Print(ObjModel.desc_cargo)
    'End Sub


End Class