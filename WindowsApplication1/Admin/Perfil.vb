Public Class Perfil
    Dim dvAcoes As DataView
    Dim dtAcoes As DataTable
    Dim blnTrava As Boolean = False
    Dim bllPesquisa As New BLL.GlobalBLL

    Dim blnPesquisar As Boolean
    Dim blnIncluir As Boolean
    Dim blnAlterar As Boolean
    Dim blnExcluir As Boolean
    Private _chaveNode As String
    Public Property ChaveNode() As String
        Get
            Return _chaveNode
        End Get
        Set(ByVal value As String)
            _chaveNode = value
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

        inicio()

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()
        Me.PkString = False
        Me.Tabela = "CG_Perfil" 'Nome da tabela no SQL
        Me.Modulo = 62 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_perfil
        Me.ColunaId = "ID_Perfil"
        Habilita_Controles(False) 'modo leitura
    End Sub
    Public Overrides Sub Pesquisar()
        MyBase.Pesquisar()
        'MessageBox.Show(Me.KeyId.ToString, "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Carrega_Controles_Pesquisa()
        blnTrava = False 'Aqui seta o valor para falso, para poder ler os dados do banco e alimentar o treeview
        CarregaTreeView()
        ChamaRecursivo(tv1, "Leitura") 'Modo Carregar - Preenche os checkbox atraves de query no banco
    End Sub

    Public Overrides Sub Carrega_Controles_Pesquisa()
        MyBase.Carrega_Controles_Pesquisa()
        If Me.KeyId <> -1 Then
            txtCodigo.Text = Me.KeyId.ToString
            txtDescricao.Text = Me.LinhaGrid.Cells("DESC_Perfil").Value.ToString
        End If
    End Sub
    Public Overrides Sub Gravar(acao As Integer)
        If Not ValidaCampos() Then
            Exit Sub
        End If
        'MyBase.Gravar(acao)
        Dim bll As New BLL.PerfilBLL
        Dim objPerfil As New DTO.Cg_perfil
        Try
            objPerfil.Id_perfil = CInt(txtCodigo.Text)
            objPerfil.Desc_perfil = txtDescricao.Text

            bll.GravarBLL(acao, objPerfil)
            ChamaRecursivo(tv1, "Gravar") 'Modo Gravar - Persiste os dados no SQL
            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(False) 'modo leitura
            blnTrava = True

        End Try

    End Sub
    Public Overrides Sub Alterar()
        MyBase.Alterar()
        Habilita_Controles(True) 'modo digitação
        blnTrava = True

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
        blnTrava = True
    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.PerfilBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub CarregaTreeView()
        Dim sql As String = "Select id_modulo, desc_modulo, convert(varchar(3),id_modulo) + ' - ' + rtrim(ltrim(desc_modulo)) as chave " & _
                                "from cg_modulo where inativo = 0 order by id_modulo"
        Dim bll As New BLL.GlobalBLL
        Dim dtModulos = bll.SqlExecDT(sql)
        InitListaAcoes()
        'definir o dataview
        dvAcoes = dtAcoes.DefaultView

        'Limpa todos os nós do Treeview
        tv1.Nodes.Clear()

        'Insere o node raiz principal
        tv1.Nodes.Add("Módulos")

        'criar objeto Node (No) do tipo TreeNode
        'definir um datarow
        Dim dr As DataRow
        Dim no As TreeNode
        tv1.BeginUpdate()
        For Each dr In dtModulos.Rows
            'preencher as categorias com o nome - CategoryName
            no = tv1.Nodes(0).Nodes.Add(dr("chave"), dr("chave"), 0, 1)

            'preencher os produtos para cada categoria
            'dvAcoes.RowFilter = "id_modulo = " & dr("id_modulo")

            'preencher os nos do treeview com o nome dos produtos
            Dim i As Integer

            For i = 0 To dvAcoes.Count - 1
                no.Nodes.Add(dvAcoes.Item(i).Row("Acoes"), dvAcoes.Item(i).Row("Acoes"), 0, 1)
            Next
        Next
        tv1.EndUpdate()
    End Sub
    Private Sub InitListaAcoes()
        dtAcoes = New DataTable("Acoes")
        dtAcoes.Columns.Add("Acoes", GetType(String))
        'Adiciona 4 Rows na tabela Acoes
        Dim row As DataRow
        Dim strPermissao() As String = {"Pesquisar", "Incluir", "Alterar", "Excluir"}

        For i As Integer = 1 To 4
            row = dtAcoes.NewRow
            row("Acoes") = strPermissao(i - 1)
            dtAcoes.Rows.Add(row)

        Next
    End Sub
    Private Sub CheckAllChildNodes(treeNode As TreeNode, nodeChecked As Boolean)
        Dim node As TreeNode
        For Each node In treeNode.Nodes
            node.Checked = nodeChecked
            If node.Nodes.Count > 0 Then
                ' If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                Me.CheckAllChildNodes(node, nodeChecked)
            End If
        Next node
    End Sub
    Private Sub tv1_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tv1.AfterCheck
        If blnTrava = False Then
            Exit Sub
        End If

        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Nodes.Count > 0 Then
                ' Calls the CheckAllChildNodes method, passing in the current 
                ' Checked value of the TreeNode whose checked state changed. 
                Me.CheckAllChildNodes(e.Node, e.Node.Checked)
            End If
        End If

        Dim childNodeCK As TreeNode = e.Node
        Dim NodeChecked As Boolean = e.Node.Checked

        For Each ChildNode As TreeNode In childNodeCK.Nodes
            If NodeChecked = True Then
                ChildNode.Checked = NodeChecked
            End If
        Next

        If childNodeCK.Checked = False Then
            If e.Node.Parent Is Nothing = False Then
                e.Node.Parent.Checked = False
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tv1.ExpandAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tv1.CollapseAll()
    End Sub

    Private Sub tv1_BeforeCheck(sender As Object, e As TreeViewCancelEventArgs) Handles tv1.BeforeCheck
        If blnTrava = False Then
            Exit Sub
        End If
        Select Case flagAcao
            Case Operacao.Consulta, Operacao.Leitura, Operacao.Limpar
                e.Cancel = True
            Case Else
                e.Cancel = False
        End Select

    End Sub
    Private Sub LerNodeRecursivo(ByVal n As TreeNode)

        'System.Diagnostics.Debug.WriteLine(n.Text)
        'System.Diagnostics.Debug.WriteLine(n.Level & " = " & n.FullPath)
        If n.Level > 0 Then ' root --> Módulos
            If n.Level = 1 Then ' node onde tem a identificação do Módulo --> Exemplo 1 - USUÁRIO

                Dim _chaveNode1 As String
                _chaveNode1 = Trim(n.Text)
                _chaveNode1 = Replace(Trim(_chaveNode1.Substring(0, 3)), "-", "")
                'System.Diagnostics.Debug.WriteLine(_chaveNode)

                Dim sql = "SELECT a.pesquisar, a.incluir, a.alterar, a.excluir, a.id_modulo FROM CG_PERFIL_MODULO a where a.id_perfil = " & _
                            CInt(txtCodigo.Text) & " and a.id_modulo = " & _chaveNode1
                Dim dt = bllPesquisa.SqlExecDT(sql)
                If dt.Rows.Count > 0 Then ' Se achou, pega o que vem do Banco de Dados
                    blnPesquisar = dt(0)("Pesquisar")
                    blnIncluir = dt(0)("Incluir")
                    blnAlterar = dt(0)("Alterar")
                    blnExcluir = dt(0)("Excluir")
                Else ' Se não achou, então setar tudo para False
                    blnPesquisar = False
                    blnIncluir = False
                    blnAlterar = False
                    blnExcluir = False
                End If
                dt = Nothing
                ' Se for tudo verdadeiro, setar o check do Node Nivel 1 para True
                If blnPesquisar And blnIncluir And blnAlterar And blnExcluir Then
                    n.Checked = True
                End If
            ElseIf n.Level = 2 Then ' node onde tem as opções Pesquisar / Incluir / Alterar / Excluir
                If n.Text.Equals("Pesquisar") Then
                    n.Checked = blnPesquisar
                End If
                If n.Text.Equals("Incluir") Then
                    n.Checked = blnIncluir
                End If
                If n.Text.Equals("Alterar") Then
                    n.Checked = blnAlterar
                End If
                If n.Text.Equals("Excluir") Then
                    n.Checked = blnExcluir
                End If
            End If
        End If

        Dim aNode As TreeNode
        For Each aNode In n.Nodes
            LerNodeRecursivo(aNode)
        Next
    End Sub

    Private Sub GravarNodeRecursivo(ByVal n As TreeNode)

        'System.Diagnostics.Debug.WriteLine(n.Text)
        'System.Diagnostics.Debug.WriteLine(n.Level & " = " & n.FullPath)
        If n.Level > 0 Then ' root --> Módulos
            If n.Level = 1 Then ' node onde tem a identificação do Módulo --> Exemplo 1 - USUÁRIO

                Me.ChaveNode = Trim(n.Text)
                Me.ChaveNode = Replace(Trim(Me.ChaveNode.Substring(0, 3)), "-", "")
                'System.Diagnostics.Debug.WriteLine(_chaveNode)

            ElseIf n.Level = 2 Then ' node onde tem as opções Pesquisar / Incluir / Alterar / Excluir
                If n.Text.Equals("Pesquisar") Then
                    blnPesquisar = n.Checked
                End If
                If n.Text.Equals("Incluir") Then
                    blnIncluir = n.Checked
                End If
                If n.Text.Equals("Alterar") Then
                    blnAlterar = n.Checked
                End If
                If n.Text.Equals("Excluir") Then
                    blnExcluir = n.Checked
                    'Depois que já leu os 4 filhos - insere os dados do novo nó no SQL
                    GravarNode(CInt(txtCodigo.Text), Me.ChaveNode, blnPesquisar, blnIncluir, blnAlterar, blnExcluir)
                End If
            End If
        Else 'Node = 0 - Exclui todos os itens para depois incluir novamente (Delete/Insert)
            'passa aqui a primeira vez apenas e exclui tudo para depois incluir novamente
            ExcluiPerfilNodes(CInt(txtCodigo.Text))
        End If

        Dim aNode As TreeNode
        For Each aNode In n.Nodes
            GravarNodeRecursivo(aNode)
        Next
    End Sub
    Private Sub ExcluiPerfilNodes(ByVal _perfil As Integer)
        Try
            Dim sqlEmpty As String, sql As String = ""
            sqlEmpty = "delete from CG_PERFIL_MODULO where ID_PERFIL={0}"

            sql = sqlEmpty
            sql = String.Format(sql, _perfil)

            Dim bllGlobal As New BLL.GlobalBLL
            bllGlobal.GravarGenericoBLL(sql)
            'MessageBox.Show("Gravação Concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub GravarNode(ByVal _perfil As Integer, ByVal _modulo As Integer, ByVal _pesquisar As Boolean, _
                           ByVal _incluir As Boolean, ByVal _alterar As Boolean, ByVal _excluir As Boolean)
        Try
            Dim sqlEmpty As String, sql As String = ""
            sqlEmpty = "insert into  CG_PERFIL_MODULO (ID_PERFIL,ID_MODULO,PESQUISAR,INCLUIR,ALTERAR,EXCLUIR) values ({0},{1},{2},{3},{4},{5})"
            'Converte o parametro booleano para 0 se falso ou 1 se True, pois o SQL não le False e True
            Dim arrayNodes() As Integer = {IIf(_pesquisar, 1, 0), _
                                           IIf(_incluir, 1, 0), _
                                           IIf(_alterar, 1, 0), _
                                           IIf(_excluir, 1, 0)}

            sql = sqlEmpty
            sql = String.Format(sql, _perfil, _modulo, arrayNodes(0), arrayNodes(1), arrayNodes(2), arrayNodes(3))
            'System.Diagnostics.Debug.WriteLine(sql)

            Dim bllGlobal As New BLL.GlobalBLL
            bllGlobal.GravarGenericoBLL(sql)
            'MessageBox.Show("Gravação Concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ChamaRecursivo(ByVal aTreeView As TreeView, ByVal pModoOperacao As String)
        Dim n As TreeNode
        For Each n In aTreeView.Nodes
            If pModoOperacao.Equals("Leitura") Then 'Leitura apenas, preenche os checkbox com o que vier do banco
                LerNodeRecursivo(n)
            Else 'Gravar ( manda para o banco as opções marcadas pelo usuário
                GravarNodeRecursivo(n)
            End If
        Next
        blnTrava = True
    End Sub

End Class