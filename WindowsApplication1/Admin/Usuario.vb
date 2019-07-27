Public Class Usuarios
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
        Me.Tabela = "CG_USUARIO" 'Nome da tabela no SQL
        Me.View = "VW_CG_USUARIO" 'Nome da view de usuários
        Me.Modulo = 1 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_usuario
        Me.ColunaId = "ID_USUARIO"
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
            txtBairro.Text = Me.LinhaGrid.Cells("bairro").Value.ToString
            txtCep.Text = Me.LinhaGrid.Cells("cep").Value.ToString
            txtCidade.Text = Me.LinhaGrid.Cells("cidade").Value.ToString
            txtComplemento.Text = Me.LinhaGrid.Cells("complemento").Value.ToString
            txtCpf.Text = Me.LinhaGrid.Cells("cpf").Value.ToString
            txtEmail.Text = Me.LinhaGrid.Cells("email").Value.ToString
            txtEndereco.Text = Me.LinhaGrid.Cells("endereco").Value.ToString
            txtLogin.Text = Me.LinhaGrid.Cells("login").Value.ToString
            txtRg.Text = Me.LinhaGrid.Cells("rg").Value.ToString
            txtTelefone.Text = Me.LinhaGrid.Cells("telefone").Value.ToString
            txtUf.Text = Me.LinhaGrid.Cells("uf").Value.ToString
            txtWhatsapp.Text = Me.LinhaGrid.Cells("whatsapp").Value.ToString
            With PesqFK1
                .txtId.Text = Me.LinhaGrid.Cells("id_status").Value.ToString
                .txtDesc.Text = Me.LinhaGrid.Cells("desc_status").Value.ToString
            End With
        End If
    End Sub
    Public Overrides Sub Gravar(acao As Integer)
        If Not ValidaCampos() Then
            Exit Sub
        End If
        'MyBase.Gravar(acao)
        Dim bll As New BLL.UsuarioBLL
        Dim objUsuario As New DTO.Cg_usuario
        Try
            objUsuario.Id_usuario = CInt(txtCodigo.Text)
            objUsuario.Nome = txtNome.Text
            objUsuario.Apelido = txtApelido.Text
            objUsuario.Bairro = txtBairro.Text
            objUsuario.Cep = txtCep.Text
            objUsuario.Cidade = txtCidade.Text
            objUsuario.Complemento = txtComplemento.Text
            objUsuario.Cpf = txtCpf.Text
            objUsuario.Email = txtEmail.Text
            objUsuario.Endereco = txtEndereco.Text
            objUsuario.Id_status = CInt(PesqFK1.txtId.Text)
            objUsuario.Login = txtLogin.Text
            objUsuario.Rg = txtRg.Text
            objUsuario.Telefone = txtTelefone.Text
            objUsuario.Uf = txtUf.Text
            objUsuario.Whatsapp = txtWhatsapp.Text


            objUsuario.User_ins = ACE_CODIGO
            objUsuario.Data_ins = Hoje()
            objUsuario.User_upd = ACE_CODIGO
            objUsuario.Data_upd = Hoje()
            objUsuario.Id_empresa = Publico.Id_empresa

            bll.GravarBLL(acao, objUsuario)
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
        Dim bll As New BLL.UsuarioBLL
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
        With PesqFK1
            .btnPesq.Enabled = False
        End With
        btnDuplicar.Enabled = True

        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            With PesqFK1
                .btnPesq.Enabled = True
            End With
            btnDuplicar.Enabled = False
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDuplicar.Click
        If String.IsNullOrEmpty(txtCodigo.Text) Then
            MessageBox.Show("Selecione um usuário de origem primeiro antes de clicar neste botão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim frm As New WinCG.UsuarioDuplicaPerfil(CInt(txtCodigo.Text))
        'frm.MdiParent = Me.MdiParent
        frm.ShowDialog()
    End Sub

    Private Sub PesqFK1_Load(sender As Object, e As EventArgs) Handles PesqFK1.Load
        With Me.PesqFK1
            .LabelPesqFK = "Status"
            .Tabela = "CG_STATUS"
            .View = "CG_STATUS"
            .CampoId = "ID_STATUS"
            .CampoDesc = "DESC_STATUS"
            .ListaCampos = "ID_STATUS, DESC_STATUS"
            .ColunasFiltro = "DESC_STATUS,ID_STATUS"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Status"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left -= 5
            .btnPesq.Left += 12
            .txtId.Left += 12
            .txtDesc.Left += 12

        End With

    End Sub
End Class