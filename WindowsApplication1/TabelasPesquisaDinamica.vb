
Public Class TabelasPesquisaDinamica

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
        Me.Tabela = "CG_TABELAS_PESQUISA_DINAMICA" 'Nome da tabela no SQL
        Me.Modulo = 52 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_tabelas_pesquisa_dinamica
        Me.ColunaId = "ID_TABELA"
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
            txtDescricao.Text = Me.LinhaGrid.Cells("TABELA").Value.ToString
            chkFiltraEmpresa.Checked = CBool(Me.LinhaGrid.Cells("FILTRA_POR_EMPRESA").Value)
            If Me.LinhaGrid.Cells("TIPO_TABELA").Value = "T" Then
                optTipo1.Checked = True
                optTipo2.Checked = False
            Else
                optTipo1.Checked = False
                optTipo2.Checked = True
            End If
        End If
    End Sub
    Public Overrides Sub Gravar(acao As Integer)

        If Not ValidaCampos() Then
            Exit Sub
        End If

        'MyBase.Gravar(acao)
        Dim bll As New BLL.Tabelas_pesquisa_dinamicaBLL
        Dim objTabelas As New DTO.Cg_tabelas_pesquisa_dinamica
        Try
            objTabelas.Id_tabela = CInt(txtCodigo.Text)
            objTabelas.Tabela = txtDescricao.Text
            objTabelas.Filtra_por_empresa = chkFiltraEmpresa.Checked

            If optTipo1.Checked = True Then
                objTabelas.Tipo_tabela = "T"
            Else
                objTabelas.Tipo_tabela = "V"
            End If

            bll.GravarBLL(acao, objTabelas)
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
        Dim bll As New BLL.Tabelas_pesquisa_dinamicaBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Overrides Function ValidaCampos() As Object
        Try
            If String.IsNullOrEmpty(txtDescricao.Text) Then
                Throw New Exception("Atenção Nome da Tabela deve ser preenchido!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
        'Return MyBase.ValidaCampos()
    End Function

End Class