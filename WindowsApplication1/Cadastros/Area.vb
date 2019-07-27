Public Class Area

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
        Me.PkString = True
        Me.Tabela = "CG_AREA" 'Nome da tabela no SQL
        Me.View = "VW_CG_AREA" 'NOME da view no SQL
        Me.Modulo = 53 'codigo do módulo de alocação
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_area
        Me.ColunaId = "ID_AREA"
        Habilita_Controles(False) 'modo leitura
    End Sub
    Public Overrides Sub Pesquisar()
        MyBase.Pesquisar()
        'MessageBox.Show(Me.KeyId.ToString, "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Carrega_Controles_Pesquisa()
    End Sub

    Public Overrides Sub Carrega_Controles_Pesquisa()
        MyBase.Carrega_Controles_Pesquisa()
        Try
            If Me.KeyId.ToString <> vbNullString Then
                txtCodigo.Text = Me.KeyIdStr
                txtDescricao.Text = Me.LinhaGrid.Cells("DESC_AREA").Value.ToString
                PesqFK1.txtId.Text = Me.LinhaGrid.Cells("ID_RESPONSAVEL").Value.ToString
                PesqFK1.txtDesc.Text = Me.LinhaGrid.Cells("nome").Value.ToString
            End If
        Catch ex As NullReferenceException
            MessageBox.Show("Pesquisa Cancelada pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodigo.Text = ""
            txtDescricao.Text = ""
            PesqFK1.txtId.Text = ""
            PesqFK1.txtDesc.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Overrides Function ValidaCampos() As Object
        Try
            If String.IsNullOrEmpty(txtCodigo.Text) Then
                Throw New Exception("Atenção Código da Area deve ser preenchido!")
            End If
            If String.IsNullOrEmpty(txtDescricao.Text) Then
                Throw New Exception("Atenção Descrição da Area deve ser preenchida!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
        'Return MyBase.ValidaCampos()
    End Function

    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)

        If Not ValidaCampos() Then
            Exit Sub
        End If

        Dim bll As New BLL.AreaBLL
        Dim objAREA As New DTO.Cg_area
        Try
            objAREA.Id_area = txtCodigo.Text
            objAREA.Desc_area = txtDescricao.Text
            objAREA.Id_responsavel = CInt(PesqFK1.txtId.Text)
            objAREA.User_ins = ACE_CODIGO
            objAREA.Data_ins = Hoje()
            objAREA.User_upd = ACE_CODIGO
            objAREA.Data_upd = Hoje()
            objAREA.Id_empresa = Publico.Id_empresa

            bll.GravarBLL(acao, objAREA)
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
        txtCodigo.Enabled = False

    End Sub
    Public Overrides Sub Incluir()
        MyBase.Incluir()
        'Dim bll As New BLL.GlobalBLL
        Me.KeyIdStr = "" 'bll.NovaChaveBLL(Me.Tabela)

        txtCodigo.Enabled = True
        txtCodigo.Text = Me.KeyIdStr.ToString()
        Habilita_Controles(True)
        txtCodigo.Focus()

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.AreaBLL
        Try
            bll.ExcluirBLL(Me.KeyId, Publico.Id_empresa)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao) 'Executa o método default da classe pai

        PesqFK1.btnPesq.Enabled = False 'Desabilita o botão 

        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            PesqFK1.btnPesq.Enabled = True 'Habilita o botão 
        End If

    End Sub

    Private Sub PesqFK1_Load(sender As Object, e As EventArgs) Handles PesqFK1.Load
        With Me.PesqFK1
            .LabelPesqFK = "Responsável"
            .Tabela = "CG_RESPONSAVEL"
            .View = "CG_RESPONSAVEL"
            .CampoId = "ID_RESPONSAVEL"
            .CampoDesc = "NOME"
            .ListaCampos = "ID_RESPONSAVEL, NOME, APELIDO, CELULAR"
            .ColunasFiltro = "NOME, APELIDO, CELULAR"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Responsáveis"
            .FiltroSQL = " where ID_EMPRESA = " & Publico.Id_empresa

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left -= 5
            .btnPesq.Left += 19
            .txtId.Left += 19
            .txtDesc.Left += 19

        End With
    End Sub
End Class