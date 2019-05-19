Public Class Empresa
    Private _comandoSQL As String
    Public Property ComandoSQL() As String
        Get
            Return _comandoSQL
        End Get
        Set(ByVal value As String)
            _comandoSQL = value
        End Set
    End Property
    Dim dtPerfil As DataTable


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
        Me.Tabela = "CG_EMPRESA" 'Nome da tabela no SQL
        Me.View = "CG_EMPRESA" 'Nome da view de usuários
        Me.Modulo = 14 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_EMPRESA
        Me.ColunaId = "ID_EMPRESA"
        Habilita_Controles(False) 'modo leitura
        CarregarDadosUsuarios(0)
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
            txtSigla.Text = Me.LinhaGrid.Cells("sigla_empresa").Value.ToString

            txtNome.Text = Me.LinhaGrid.Cells("nome_empresa").Value.ToString
            txtCep.Text = Me.LinhaGrid.Cells("cep_empresa").Value.ToString
            txtEndereco.Text = Me.LinhaGrid.Cells("endereco_empresa").Value.ToString
            txtComplemento.Text = Me.LinhaGrid.Cells("complemento_empresa").Value.ToString
            txtCidade.Text = Me.LinhaGrid.Cells("cidade_empresa").Value.ToString
            txtBairro.Text = Me.LinhaGrid.Cells("bairro_empresa").Value.ToString
            txtUf.Text = Me.LinhaGrid.Cells("uf_empresa").Value.ToString
            txtEmail.Text = Me.LinhaGrid.Cells("email").Value.ToString
            txtTelefone.Text = Me.LinhaGrid.Cells("telefone_empresa").Value.ToString
            txtContato.Text = Me.LinhaGrid.Cells("contato_empresa").Value.ToString
            txtWhatsapp.Text = Me.LinhaGrid.Cells("celular_empresa").Value.ToString
            txtReferencia.Text = Me.LinhaGrid.Cells("referencia_endereco").Value.ToString

            txtObs.Text = Me.LinhaGrid.Cells("observacao").Value.ToString
            CarregarDadosUsuarios(CInt(txtCodigo.Text))

        End If
    End Sub
    Public Overrides Function ValidaCampos() As Object
        Try

            If String.IsNullOrEmpty(txtSigla.Text) Then
                Throw New Exception("Atenção obrigatório preencher a Sigla do EMPRESA")
            End If

            If String.IsNullOrEmpty(txtNome.Text) Then
                Throw New Exception("Atenção obrigatório preencher o Nome do EMPRESA")
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
        Dim bll As New BLL.EMPRESABLL
        Dim objEmpresa As New DTO.Cg_empresa
        Try
            objEmpresa.Id_empresa = CInt(txtCodigo.Text)

            objEmpresa.Bairro_empresa = txtBairro.Text
            objEmpresa.Celular_empresa = txtWhatsapp.Text
            objEmpresa.Cep_empresa = txtCep.Text
            objEmpresa.Cidade_empresa = txtCidade.Text
            objEmpresa.Complemento_empresa = txtComplemento.Text
            objEmpresa.Contato_empresa = txtContato.Text
            objEmpresa.Endereco_empresa = txtEndereco.Text
            objEmpresa.Nome_empresa = txtNome.Text
            objEmpresa.Observacao = txtObs.Text
            objEmpresa.Referencia_endereco = txtReferencia.Text
            objEmpresa.Sigla_empresa = txtSigla.Text
            objEmpresa.Telefone_empresa = txtTelefone.Text
            objEmpresa.Uf_empresa = txtUf.Text
            objEmpresa.Email = txtEmail.Text

            bll.GravarBLL(acao, objEmpresa)
            RefreshGrid()
            GravarPermissoes()
            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta
            CarregarDadosUsuarios(objEmpresa.Id_empresa)

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(False) 'modo leitura

        End Try

    End Sub

    Private Sub RefreshGrid()
        'Gambiarra para fixar as opções escolhidas e não ficar em cache
        'Go Bottom no Grid - para fixar a selecao escolhida nas pontas, primeiro e ultimo registro
        dgvDados.CurrentCell = dgvDados.Rows(dgvDados.RowCount - 1).Cells(0)
        dgvDados.Rows(dgvDados.RowCount - 1).Selected = True

        'Go Top no Grid - para fixar a selecao escolhida nas pontas, primeiro e ultimo registro
        dgvDados.CurrentCell = dgvDados.Rows(0).Cells(0)
        dgvDados.Rows(0).Selected = True
    End Sub

    Public Sub GravarPermissoes()
        Dim _idEmpresa As Integer = CInt(txtCodigo.Text)
        Dim _idUsuario As Integer = 0
        Dim _idPerfil As Integer = 0
        Dim _selecionado As Boolean = False

        Dim sql = ""
        Dim bllGlobal As New BLL.GlobalBLL

        ExcluiTodasPermissoesDaEmpresa()
        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    _selecionado = CBool(row.Cells(0).Value)
                    If _selecionado = True Then
                        _idUsuario = CInt(row.Cells(1).Value)
                        _idPerfil = CInt(row.Cells(4).Value)
                        sql = "insert into CG_EMPRESA_VS_USUARIOS values (" & _idEmpresa & ", " & _idUsuario & ", " & _idPerfil & ")"
                        bllGlobal.GravarGenericoBLL(sql)
                    End If

                End If

            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try

    End Sub
    Public Sub ExcluiTodasPermissoesDaEmpresa()
        Try
            Dim sqlEmpty As String, sql As String = ""
            sqlEmpty = "delete from CG_EMPRESA_VS_USUARIOS where ID_EMPRESA = {0}"

            sql = sqlEmpty
            sql = String.Format(sql, CInt(txtCodigo.Text))

            Dim bllGlobal As New BLL.GlobalBLL
            bllGlobal.GravarGenericoBLL(sql)
            'MessageBox.Show("Gravação Concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Overrides Sub Alterar()
        MyBase.Alterar()
        Habilita_Controles(True) 'modo digitação
        Try
            dgvDados.Columns(0).ReadOnly = False
            dgvDados.Columns(4).ReadOnly = False
        Catch ex As Exception

        End Try

    End Sub
    Public Overrides Sub Incluir()
        MyBase.Incluir()
        Dim bll As New BLL.GlobalBLL
        Me.KeyId = bll.NovaChaveBLL(Me.Tabela)
        If Me.KeyId > 0 Then
            txtCodigo.Text = Me.KeyId.ToString()
            Habilita_Controles(True) 'modo digitação
            Try
                dgvDados.Columns(0).ReadOnly = False
                dgvDados.Columns(4).ReadOnly = False
            Catch ex As Exception

            End Try

        Else
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.EMPRESABLL
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
    End Sub

    Private Sub CarregarDadosUsuarios(ByVal _idEmpresa As Integer)
        dgvDados.DataSource = Nothing

        dgvDados.ColumnCount = 0
        dgvDados.AutoGenerateColumns = False

        Me.ComandoSQL = "exec sp_Busca_Usuario_vs_Empresa " & _idEmpresa
        Dim coluna0 As DataGridViewCheckBoxColumn
        Dim coluna1 As DataGridViewTextBoxColumn
        Dim coluna2 As DataGridViewTextBoxColumn
        Dim coluna3 As DataGridViewTextBoxColumn
        Dim coluna4 As DataGridViewComboBoxColumn

        dgvDados.Rows.Clear()
        InitListaPerfil()

        coluna0 = New DataGridViewCheckBoxColumn
        coluna0.HeaderText = "Selecionar"
        coluna0.Name = "SELECAO"

        coluna1 = New DataGridViewTextBoxColumn
        coluna1.HeaderText = "ID"
        coluna1.Name = "ID_USUARIO"

        coluna2 = New DataGridViewTextBoxColumn
        coluna2.HeaderText = "Apelido"
        coluna2.Name = "APELIDO"

        coluna3 = New DataGridViewTextBoxColumn
        coluna3.HeaderText = "Nome"
        coluna3.Name = "NOME"

        coluna4 = New DataGridViewComboBoxColumn
        coluna4.HeaderText = "Perfil"
        coluna4.Name = "ID_PERFIL"
        coluna4.ValueMember = "ID_PERFIL"
        coluna4.DisplayMember = "DESC_PERFIL"
        coluna4.DataSource = dtPerfil

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {coluna0, coluna1, coluna2, coluna3, coluna4})
        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(Me.ComandoSQL).Tables(0)

        'Relacionar colunas do DataGridview com campos do DataTable/DataSet
        dgvDados.Columns("selecao").DataPropertyName = "SELECAO"
        dgvDados.Columns("id_usuario").DataPropertyName = "ID_USUARIO"
        dgvDados.Columns("apelido").DataPropertyName = "APELIDO"
        dgvDados.Columns("nome").DataPropertyName = "NOME"
        dgvDados.Columns("id_perfil").DataPropertyName = "ID_PERFIL"

        dgvDados.Columns(0).ReadOnly = True
        dgvDados.Columns(1).ReadOnly = True
        dgvDados.Columns(2).ReadOnly = True
        dgvDados.Columns(3).ReadOnly = True
        dgvDados.Columns(4).ReadOnly = True

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas

        dgvDados.AutoResizeColumns()

    End Sub
    Private Sub InitListaPerfil()
        Dim bll As New BLL.GlobalBLL
        dtPerfil = New DataTable("Permissao")
        dtPerfil = bll.SqlExecDT("SELECT DESC_PERFIL,ID_PERFIL FROM CG_PERFIL ORDER BY DESC_PERFIL")
    End Sub
End Class