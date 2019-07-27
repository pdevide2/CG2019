Public Class Clientes

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
        Me.Tabela = "CG_CLIENTE" 'Nome da tabela no SQL
        Me.View = "CG_CLIENTE" 'Nome da view de usuários
        Me.Modulo = 74 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_cliente
        Me.ColunaId = "ID_CLIENTE"
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
            txtSigla.Text = Me.LinhaGrid.Cells("sigla").Value.ToString
            txtNome.Text = Me.LinhaGrid.Cells("nome").Value.ToString
            txtCep.Text = Me.LinhaGrid.Cells("cep").Value.ToString
            txtEndereco.Text = Me.LinhaGrid.Cells("endereco").Value.ToString
            txtComplemento.Text = Me.LinhaGrid.Cells("complemento").Value.ToString
            txtCidade.Text = Me.LinhaGrid.Cells("cidade").Value.ToString
            txtBairro.Text = Me.LinhaGrid.Cells("bairro").Value.ToString
            txtUf.Text = Me.LinhaGrid.Cells("uf").Value.ToString
            txtEmail.Text = Me.LinhaGrid.Cells("email").Value.ToString
            txtTelefone1.Text = Me.LinhaGrid.Cells("telefone1").Value.ToString
            txtContato1.Text = Me.LinhaGrid.Cells("contato1").Value.ToString
            txtTelefone2.Text = Me.LinhaGrid.Cells("telefone2").Value.ToString
            txtContato2.Text = Me.LinhaGrid.Cells("contato2").Value.ToString
            txtTelefone3.Text = Me.LinhaGrid.Cells("telefone3").Value.ToString
            txtContato3.Text = Me.LinhaGrid.Cells("contato3").Value.ToString
            txtTelefone4.Text = Me.LinhaGrid.Cells("telefone4").Value.ToString
            txtContato4.Text = Me.LinhaGrid.Cells("contato4").Value.ToString
            txtObs.Text = Me.LinhaGrid.Cells("obs").Value.ToString
            txtCadastro.Text = Me.LinhaGrid.Cells("cadastro").Value.ToString
            txtUltima_Atualizacao.Text = Me.LinhaGrid.Cells("ultima_atualizacao").Value.ToString

            If CInt(Me.LinhaGrid.Cells("pfpj").Value) = 1 Then
                optFisica.Checked = True
                optJuridica.Checked = False
            Else
                optFisica.Checked = False
                optJuridica.Checked = True
            End If

            txtCpfCnpj.Text = Me.LinhaGrid.Cells("cpf_cnpj").Value.ToString
            txtRgIe.Text = Me.LinhaGrid.Cells("rg_ie").Value.ToString

        End If
    End Sub
    Public Overrides Function ValidaCampos() As Object
        Try

            If String.IsNullOrEmpty(txtSigla.Text) Then
                Throw New Exception("Atenção obrigatório preencher a Sigla do Fornecedor")
            End If
            If String.IsNullOrEmpty(txtNome.Text) Then
                Throw New Exception("Atenção obrigatório preencher o Nome do Fornecedor")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try
        Return True

    End Function
    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)
        If Not ValidaCampos() Then
            Exit Sub
        End If
        Dim bll As New BLL.ClienteBLL
        Dim objCliente As New DTO.Cg_cliente
        Try

            objCliente.Id_cliente = CInt(txtCodigo.Text)
            objCliente.Sigla = txtSigla.Text
            objCliente.Nome = txtNome.Text
            objCliente.Cep = txtCep.Text
            objCliente.Endereco = txtEndereco.Text
            objCliente.Complemento = txtComplemento.Text
            objCliente.Cidade = txtCidade.Text
            objCliente.Bairro = txtBairro.Text
            objCliente.Uf = txtUf.Text
            objCliente.Email = txtEmail.Text
            objCliente.Telefone1 = txtTelefone1.Text
            objCliente.Contato1 = txtContato1.Text
            objCliente.Telefone2 = txtTelefone2.Text
            objCliente.Contato2 = txtContato2.Text
            objCliente.Telefone3 = txtTelefone3.Text
            objCliente.Contato3 = txtContato3.Text
            objCliente.Telefone4 = txtTelefone4.Text
            objCliente.Contato4 = txtContato4.Text
            objCliente.Obs = txtObs.Text

            If acao = Operacao.Novo Then
                objCliente.Cadastro = Hoje()
            Else
                objCliente.Cadastro = txtCadastro.Text
            End If
            objCliente.Ultima_atualizacao = Hoje()

            objCliente.Id_empresa = Publico.Id_empresa

            If optFisica.Checked Then
                objCliente.PfPj = 1
            Else
                objCliente.PfPj = 2
            End If

            objCliente.CpfCnpj = txtCpfCnpj.Text
            objCliente.RgIe = txtRgIe.Text

            bll.GravarBLL(acao, objCliente)
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
        Dim bll As New BLL.ClienteBLL
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

        txtCadastro.Enabled = False
        txtUltima_Atualizacao.Enabled = False

        optFisica.Enabled = False
        optJuridica.Enabled = False

        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            txtCadastro.ReadOnly = True
            txtUltima_Atualizacao.ReadOnly = True
            optFisica.Enabled = True
            optJuridica.Enabled = True
        End If

    End Sub
End Class