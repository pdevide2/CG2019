Public Class Fornecedores

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
        Me.Tabela = "CG_FORNECEDOR" 'Nome da tabela no SQL
        Me.View = "VW_CG_FORNECEDOR" 'Nome da view de usuários
        Me.Modulo = 14 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_fornecedor
        Me.ColunaId = "ID_FORNECEDOR"
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
            chkUtilizaNFTS.Checked = CBool(Me.LinhaGrid.Cells("utiliza_nfts").Value)
            txtNome.Text = Me.LinhaGrid.Cells("nome").Value.ToString
            txtCep.Text = Me.LinhaGrid.Cells("cep").Value.ToString
            txtEndereco.Text = Me.LinhaGrid.Cells("endereco").Value.ToString
            txtComplemento.Text = Me.LinhaGrid.Cells("complemento").Value.ToString
            txtCidade.Text = Me.LinhaGrid.Cells("cidade").Value.ToString
            txtBairro.Text = Me.LinhaGrid.Cells("bairro").Value.ToString
            txtUf.Text = Me.LinhaGrid.Cells("uf").Value.ToString
            txtEmail.Text = Me.LinhaGrid.Cells("email").Value.ToString
            txtTelefone.Text = Me.LinhaGrid.Cells("telefone").Value.ToString
            txtContato.Text = Me.LinhaGrid.Cells("contato").Value.ToString
            txtWhatsapp.Text = Me.LinhaGrid.Cells("whatsapp").Value.ToString
            PesqFK1.txtId.Text = Me.LinhaGrid.Cells("id_tipo_servico").Value.ToString
            PesqFK1.txtDesc.Text = Me.LinhaGrid.Cells("desc_tipo_servico").Value.ToString
            txtObs.Text = Me.LinhaGrid.Cells("obs").Value.ToString

            txtGarantiaNovo.Text = Me.LinhaGrid.Cells("GARANTIA_AQUISICAO").Value.ToString
            txtGarantiaAssistencia.Text = Me.LinhaGrid.Cells("GARANTIA_ASSISTENCIA").Value.ToString

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
            If String.IsNullOrEmpty(PesqFK1.txtId.Text) Then
                Throw New Exception("Atenção obrigatório informar o tipo de serviço")
            Else
                If CInt(PesqFK1.txtId.Text) <= 0 Then
                    Throw New Exception("Atenção obrigatório informar o tipo de serviço")
                End If
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
        Dim bll As New BLL.FornecedorBLL
        Dim objFornecedor As New DTO.Cg_fornecedor
        Try

            objFornecedor.Id_fornecedor = CInt(txtCodigo.Text)
            objFornecedor.Sigla = txtSigla.Text
            objFornecedor.Utiliza_nfts = IIf(chkUtilizaNFTS.Checked, True, False)
            objFornecedor.Nome = txtNome.Text
            objFornecedor.Cep = txtCep.Text
            objFornecedor.Endereco = txtEndereco.Text
            objFornecedor.Complemento = txtComplemento.Text
            objFornecedor.Cidade = txtCidade.Text
            objFornecedor.Bairro = txtBairro.Text
            objFornecedor.Uf = txtUf.Text
            objFornecedor.Email = txtEmail.Text
            objFornecedor.Telefone = txtTelefone.Text
            objFornecedor.Contato = txtContato.Text
            objFornecedor.Whatsapp = txtWhatsapp.Text
            objFornecedor.Id_tipo_servico = CInt(PesqFK1.txtId.Text)
            objFornecedor.Obs = txtObs.Text

            objFornecedor.User_ins = ACE_CODIGO
            objFornecedor.Data_ins = Hoje()
            objFornecedor.User_upd = ACE_CODIGO
            objFornecedor.Data_upd = Hoje()

            objFornecedor.Garantia_Aquisicao = CInt(txtGarantiaNovo.Text)
            objFornecedor.Garantia_Assistencia = CInt(txtGarantiaAssistencia.Text)
            objFornecedor.Id_empresa = Publico.Id_empresa


            bll.GravarBLL(acao, objFornecedor)
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
        Dim bll As New BLL.FornecedorBLL
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
        With Me.PesqFK1
            .LabelPesqFK = "Tipo de Serviço"
            .Tabela = "CG_TIPO_SERVICO"
            .View = "CG_TIPO_SERVICO"
            .CampoId = "ID_TIPO_SERVICO"
            .CampoDesc = "DESC_TIPO_SERVICO"
            .ListaCampos = "ID_TIPO_SERVICO, DESC_TIPO_SERVICO"
            .ColunasFiltro = "DESC_TIPO_SERVICO,ID_TIPO_SERVICO"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Tipo de Serviço"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .btnPesq.Left += 26
            .txtId.Left += 26
            .txtDesc.Left += 26

        End With

    End Sub
End Class