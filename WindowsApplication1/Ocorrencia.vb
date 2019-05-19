Public Class Ocorrencia
    Private _chave_item As String
    Public Property ChaveItem() As String
        Get
            Return _chave_item
        End Get
        Set(ByVal value As String)
            _chave_item = value
        End Set
    End Property

    Private _cd_equipamento As Integer
    Public Property CodigoEquipamento() As Integer
        Get
            Return _cd_equipamento
        End Get
        Set(ByVal value As Integer)
            _cd_equipamento = value
        End Set
    End Property
    Private _cd_loja As Integer
    Public Property IdLoja() As Integer
        Get
            Return _cd_loja
        End Get
        Set(ByVal value As Integer)
            _cd_loja = value
        End Set
    End Property
    Private _acao_tela As Integer
    Public Property AcaoTela() As Integer
        Get
            Return _acao_tela
        End Get
        Set(ByVal value As Integer)
            _acao_tela = value
        End Set
    End Property
    Private _id_ocorrencia As Integer
    Public Property IdOcorrencia() As Integer
        Get
            Return _id_ocorrencia
        End Get
        Set(ByVal value As Integer)
            _id_ocorrencia = value
        End Set
    End Property

    Public Sub New(ByVal objPermissaoModulo As DTO.PermissaoModulo)

        ' This call is required by the designer.
        InitializeComponent()

        arrayAcessoTela(0) = objPermissaoModulo.Pesquisa
        arrayAcessoTela(1) = objPermissaoModulo.Incluir
        arrayAcessoTela(2) = objPermissaoModulo.Alterar
        arrayAcessoTela(3) = objPermissaoModulo.Excluir

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.CodigoEquipamento = 0
        Me.IdLoja = 0
    End Sub
    Public Sub New(ByVal _acao As Integer, ByVal _id_ocorrencia As Integer, ByVal _idEquipamento As Integer, ByVal _idLoja As Integer, ByVal _chave_os_item As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IdOcorrencia = _id_ocorrencia
        Me.CodigoEquipamento = _idEquipamento
        Me.IdLoja = _idLoja
        Me.AcaoTela = _acao
        Me.ChaveItem = _chave_os_item

        flagAcao = _acao

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()
        Me.PkString = False
        Me.Tabela = "CG_OCORRENCIA" 'Nome da tabela no SQL
        Me.View = "VW_CG_OCORRENCIA" 'NOME da view no SQL
        Me.Modulo = 54 'codigo do módulo de alocação
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)

        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_ocorrencia
        Me.ColunaId = "ID_OCORRENCIA"
        Habilita_Controles(False) 'modo leitura
        If Me.AcaoTela = Operacao.Novo Then
            flagAcao = Operacao.Novo
            Me.Acao = flagAcao
            Incluir()
            If Me.CodigoEquipamento > 0 Then
                txtIdEquipamento.Text = Me.CodigoEquipamento.ToString
                txtIdLoja.Text = Me.IdLoja.ToString
                txtChaveOS.Text = Me.ChaveItem.ToString
                Atualiza_FKs()
            End If
        End If
        If Me.AcaoTela = Operacao.Consulta Or Me.AcaoTela = Operacao.Alterar Then
            Me.KeyId = Me.IdOcorrencia
            Carrega_Dados_Ocorrencia()
        End If
        lblChave.Text = "ID_OS | ITEM_ID | ID_EQUIPAMENTO"
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

            txtData.CustomFormat = " "
            If Not String.IsNullOrEmpty(Me.LinhaGrid.Cells("DATA_OCORRENCIA").Value.ToString) Then
                txtData.CustomFormat = "dd/MM/yyyy"
            End If
            txtData.Text = Me.LinhaGrid.Cells("DATA_OCORRENCIA").Value.ToString

            txtDescricao.Text = Me.LinhaGrid.Cells("DESCRICAO").Value.ToString
            txtIdEquipamento.Text = Me.LinhaGrid.Cells("ID_EQUIPAMENTO").Value.ToString
            txtDescEquipamento.Text = Me.LinhaGrid.Cells("DESC_EQUIPAMENTO").Value.ToString
            txtSerie.Text = Me.LinhaGrid.Cells("SERIE").Value.ToString
            txtIdLoja.Text = Me.LinhaGrid.Cells("ID_LOJA").Value.ToString
            txtDescLoja.Text = Me.LinhaGrid.Cells("NOME").Value.ToString
            txtCodigoLoja.Text = Me.LinhaGrid.Cells("CODIGO").Value.ToString
            txtHistorico.Text = Me.LinhaGrid.Cells("HISTORICO").Value.ToString
            txtChaveOS.Text = Me.LinhaGrid.Cells("OS_VINCULADA").Value.ToString

            'Não permitir alteração em loja e equipamento se tiver OS vinculada
            If Not String.IsNullOrEmpty(txtChaveOS.Text) Then
                btnPesqEquipamento.Enabled = False
                Button1.Enabled = False
            End If

        End If
    End Sub
    Private Sub Carrega_Dados_Ocorrencia()

        Dim sql As String
        sql = "select  "
        sql += "ID_OCORRENCIA, DATA_OCORRENCIA, DESCRICAO, ID_EQUIPAMENTO, DESC_EQUIPAMENTO, MODELO, SERIE, ID_LOJA, CODIGO, NOME, HISTORICO, USER_INS, DATA_INS, USER_UPD, DATA_UPD"
        sql += " from VW_CG_OCORRENCIA where ID_OCORRENCIA = " & Me.KeyId.ToString
        Dim bll As New BLL.GlobalBLL
        Dim dt As DataTable
        dt = bll.SqlExecDT(sql)

        If dt.Rows.Count > 0 Then
            txtCodigo.Text = Me.KeyId.ToString

            txtData.CustomFormat = " "
            If Not String.IsNullOrEmpty(dt(0)("DATA_OCORRENCIA").ToString) Then
                txtData.CustomFormat = "dd/MM/yyyy"
            End If
            txtData.Text = dt(0)("DATA_OCORRENCIA").ToString

            txtDescricao.Text = dt(0)("DESCRICAO").ToString
            txtIdEquipamento.Text = dt(0)("ID_EQUIPAMENTO").ToString
            txtDescEquipamento.Text = dt(0)("DESC_EQUIPAMENTO").ToString
            txtSerie.Text = dt(0)("SERIE").ToString
            txtIdLoja.Text = dt(0)("ID_LOJA").ToString
            txtDescLoja.Text = dt(0)("NOME").ToString
            txtCodigoLoja.Text = dt(0)("CODIGO").ToString
            txtHistorico.Text = dt(0)("HISTORICO").ToString
            txtChaveOS.Text = Me.ChaveItem.ToString

            Me.tsBtnNovo.Enabled = False
            Me.tsBtnPesquisar.Enabled = False
            Me.tsBtnExcluir.Enabled = False
            Me.tsBtnAlterar.Enabled = False

            If Me.AcaoTela = Operacao.Alterar Then
                Habilita_Controles(True) 'modo edit
            End If

        End If
    End Sub
    Public Overrides Function ValidaCampos() As Object
        Try
            If String.IsNullOrEmpty(txtDescricao.Text) Then
                Throw New Exception("Atenção Descrição da Alocação deve ser preenchida!")
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

        Dim bll As New BLL.OcorrenciaBLL
        Dim objOcorrencia As New DTO.Cg_ocorrencia
        Try

            objOcorrencia.Id_ocorrencia = CInt(txtCodigo.Text)
            objOcorrencia.Data_ocorrencia = CDate(txtData.Text)
            objOcorrencia.Descricao = txtDescricao.Text
            objOcorrencia.Id_equipamento = CInt(txtIdEquipamento.Text)
            objOcorrencia.Serie = txtSerie.Text
            objOcorrencia.Id_loja = CInt(txtIdLoja.Text)
            objOcorrencia.Historico = txtHistorico.Text


            objOcorrencia.User_ins = ACE_CODIGO
            objOcorrencia.Data_ins = Hoje()
            objOcorrencia.User_upd = ACE_CODIGO
            objOcorrencia.Data_upd = Hoje()

            If Not String.IsNullOrEmpty(txtChaveOS.Text) Then
                objOcorrencia.OS_Vinculada = txtChaveOS.Text
            Else
                objOcorrencia.OS_Vinculada = ""
            End If

            bll.GravarBLL(acao, objOcorrencia)
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
            txtData.CustomFormat = "dd/MM/yyyy"
            txtData.Value = ShortDate()
        Else
            txtData.CustomFormat = " "
            txtData.Value = Nothing
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.OcorrenciaBLL
        Try
            bll.ExcluirBLL(Me.KeyId)
            Cancelar(flagAcao)

            MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub


    Private Sub btnPesqResponsavel_Click(sender As Object, e As EventArgs) Handles btnPesqEquipamento.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_EQUIPAMENTO"
        Me.ObjModelFk.CampoId = "ID_EQUIPAMENTO"
        Me.ObjModelFk.CampoDesc = "DESC_EQUIPAMENTO"
        Me.ObjModelFk.ListaCampos = "ID_EQUIPAMENTO, DESC_EQUIPAMENTO, SERIE, MODELO"
        Me.ObjModelFk.ColunasFiltro = "SERIE,DESC_EQUIPAMENTO" ' ComboBox de filtros
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Equipamentos"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.ListaCampos & _
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where 1=1 "

        PesquisaFK2(Me.ObjModelFk)

        txtIdEquipamento.Text = Me.ObjModelFk.txtId.ToString
        txtDescEquipamento.Text = Me.ObjModelFk.txtDesc

        'Pesquisa o cadastro do Fornecedor e traz a coluna GARANTIA_AQUISICAO
        Dim dt As DataTable
        Dim bll As New BLL.GlobalBLL

        dt = bll.SqlExecDT("select SERIE  " & _
                           "from CG_EQUIPAMENTO where ID_EQUIPAMENTO = " & txtIdEquipamento.Text)

        If dt.Rows.Count > 0 Then
            txtSerie.Text = dt(0)("SERIE")
            'Dim form1 As New WaitWindow("Campo Prazo de Garantia Atualizado!", 1)
            'form1.ShowDialog()
            'form1.Dispose()
            'form1 = Nothing
        End If

    End Sub

    Public Overrides Sub HabilitaBotoes(acao As Integer)
        MyBase.HabilitaBotoes(acao) 'Executa o método default da classe pai

        btnPesqEquipamento.Enabled = False 'Desabilita o botão 
        Button1.Enabled = False
        If Me.CodigoEquipamento = 0 And Me.IdLoja = 0 Then

            If acao = Operacao.Novo Or acao = Operacao.Alterar Then
                If String.IsNullOrEmpty(txtChaveOS.Text) Then
                    btnPesqEquipamento.Enabled = True 'Habilita o botão 
                    Button1.Enabled = True
                End If
            End If
        Else
            'Operação de Inclusão, chamada da tela de OS
            If acao = Operacao.Novo Then
                txtIdEquipamento.Text = Me.CodigoEquipamento.ToString
                txtIdLoja.Text = Me.IdLoja.ToString
            End If

        End If

    End Sub
    Public Overrides Sub Cancelar(ByVal acao As Integer)
        txtData.CustomFormat = " "
        txtData.Value = "01/01/1900"
        MyBase.Cancelar(acao)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = "CG_LOJA"
        Me.ObjModelFk.CampoId = "ID_LOJA"
        Me.ObjModelFk.CampoDesc = "NOME"
        Me.ObjModelFk.ListaCampos = "ID_LOJA, NOME, SIGLA, CODIGO"
        Me.ObjModelFk.ColunasFiltro = "CODIGO,NOME,SIGLA" ' ComboBox de filtros
        Me.ObjModelFk.LabelBuscaId = "Código"
        Me.ObjModelFk.LabelBuscaDesc = "Nome"
        Me.ObjModelFk.TituloTela = "Pesquisa de Lojas"
        Me.ObjModelFk.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
        Me.ObjModelFk.TxtDesc = ""
        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.ListaCampos & _
                            " From " & Me.ObjModelFk.Tabela

        Me.ObjModelFk.FiltroSQL = " where 1=1 "

        PesquisaFK2(Me.ObjModelFk)

        txtIdLoja.Text = Me.ObjModelFk.txtId.ToString
        txtDescLoja.Text = Me.ObjModelFk.txtDesc

        'Pesquisa o cadastro do Fornecedor e traz a coluna GARANTIA_AQUISICAO
        Dim dt As DataTable
        Dim bll As New BLL.GlobalBLL

        dt = bll.SqlExecDT("select CODIGO  " & _
                           "from CG_LOJA where ID_LOJA = " & txtIdLoja.Text)

        If dt.Rows.Count > 0 Then
            txtCodigoLoja.Text = dt(0)("CODIGO")
            'Dim form1 As New WaitWindow("Campo Prazo de Garantia Atualizado!", 1)
            'form1.ShowDialog()
            'form1.Dispose()
            'form1 = Nothing
        End If

    End Sub

    Private Sub Atualiza_FKs()
        'Pesquisa o cadastro do Fornecedor e traz a coluna GARANTIA_AQUISICAO
        Dim dt As DataTable
        Dim bll As New BLL.GlobalBLL

        dt = bll.SqlExecDT("select SERIE, ID_EQUIPAMENTO, DESC_EQUIPAMENTO  " & _
                           "from CG_EQUIPAMENTO where ID_EQUIPAMENTO = " & txtIdEquipamento.Text)

        If dt.Rows.Count > 0 Then
            txtSerie.Text = dt(0)("SERIE")
            txtDescEquipamento.Text = dt(0)("DESC_EQUIPAMENTO")
        End If

        Dim dt2 As DataTable

        dt2 = bll.SqlExecDT("select CODIGO, ID_LOJA, NOME  " & _
                           "from CG_LOJA where ID_LOJA = " & txtIdLoja.Text)

        If dt2.Rows.Count > 0 Then
            txtCodigoLoja.Text = dt2(0)("CODIGO")
            txtDescLoja.Text = dt2(0)("NOME")
        End If

        dt = Nothing
        dt2 = Nothing
        bll = Nothing

    End Sub

End Class