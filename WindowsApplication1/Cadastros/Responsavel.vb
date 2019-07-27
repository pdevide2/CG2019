Public Class Responsavel

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
        Me.Tabela = "CG_RESPONSAVEL" 'Nome da tabela no SQL
        Me.Modulo = 7 'codigo do módulo 
        LoginCG() 'retorna o id do usuário
        Me.View = "VW_CG_RESPONSAVEL"

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_responsavel
        Me.ColunaId = "ID_RESPONSAVEL"
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
            txtNome.Text = Me.LinhaGrid.Cells("nome").Value.ToString
            txtApelido.Text = Me.LinhaGrid.Cells("apelido").Value.ToString
            txtCelular.Text = Me.LinhaGrid.Cells("celular").Value.ToString
            PesqFK1.txtDesc.Text = Me.LinhaGrid.Cells("desc_cargo").Value.ToString
            txtEmail.Text = Me.LinhaGrid.Cells("email").Value.ToString
            PesqFK1.txtId.Text = Me.LinhaGrid.Cells("id_cargo").Value.ToString
            txtNome.Text = Me.LinhaGrid.Cells("nome").Value.ToString
            txtWhatsapp.Text = Me.LinhaGrid.Cells("whatsapp").Value.ToString
        End If
    End Sub

    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)

        If Not ValidaCampos() Then
            Exit Sub
        End If

        Dim bll As New BLL.ResponsavelBLL
        Dim objResponsavel As New DTO.Cg_responsavel
        Try
            objResponsavel.Id_responsavel = CInt(txtCodigo.Text)
            objResponsavel.Apelido = txtApelido.Text
            objResponsavel.Celular = txtCelular.Text
            objResponsavel.Email = txtEmail.Text
            objResponsavel.Id_cargo = CInt(PesqFK1.txtId.Text)
            objResponsavel.Nome = txtNome.Text
            objResponsavel.Whatsapp = txtWhatsapp.Text

            objResponsavel.User_ins = ACE_CODIGO
            objResponsavel.Data_ins = Hoje()
            objResponsavel.User_upd = ACE_CODIGO
            objResponsavel.Data_upd = Hoje()
            objResponsavel.Id_empresa = Publico.Id_empresa

            bll.GravarBLL(acao, objResponsavel)
            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(False) 'modo leitura

        End Try

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
        Dim bll As New BLL.ResponsavelBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao) 'Executa o método default da classe pai

        PesqFK1.btnPesq.Enabled = False 'Desabilita o botão de pesquisar status

        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            PesqFK1.btnPesq.Enabled = True 'Habilita o botão para pesquisar Status
        End If

    End Sub

    Private Sub PesqFK1_Load(sender As Object, e As EventArgs) Handles PesqFK1.Load
        With PesqFK1
            .LabelPesqFK = "Cargo"
            .Tabela = "CG_CARGO"
            .View = "CG_CARGO"
            .CampoId = "ID_CARGO"
            .CampoDesc = "DESC_CARGO"
            .ListaCampos = "ID_CARGO, DESC_CARGO"
            .ColunasFiltro = "DESC_CARGO,ID_CARGO"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Cargo"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .btnPesq.Left -= 9
            .txtId.Left -= 9
            .txtDesc.Left -= 9
        End With
    End Sub
End Class