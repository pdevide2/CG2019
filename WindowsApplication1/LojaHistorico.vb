
Public Class LojaHistorico

    Private _idLoja As Integer
    Public Property IdLoja() As Integer
        Get
            Return _idLoja
        End Get
        Set(ByVal value As Integer)
            _idLoja = value
        End Set
    End Property
    Private _id_tipo_local_estoque As Integer
    Public Property Id_Tipo_Local_Estoque() As Integer
        Get
            Return _id_tipo_local_estoque
        End Get
        Set(ByVal value As Integer)
            _id_tipo_local_estoque = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal _idLoja As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.IdLoja = _idLoja

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
        tsNavega.Visible = False
        Me.Id_Tipo_Local_Estoque = 0
        inicio()

    End Sub
    Public Overrides Sub inicio()
        'MyBase.inicio()
        Me.PkString = False
        Me.Tabela = "CG_LOJA" 'Nome da tabela no SQL
        Me.View = "VW_CG_LOJA" 'Nome da view de Loja
        Me.Modulo = 13 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        Dim blnOk As Boolean = False
        If blnOk Then

            'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
            'Atribui o retorno da permissão na propriedade Me.Acesso
            'permissaoTela(Me.Modulo, ACE_CODIGO)
            HabilitaBotoes(flagAcao)
            'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.ObjModel = New DTO.Cg_loja
            Me.ColunaId = "ID_LOJA"
            Habilita_Controles(False) 'modo leitura

        End If
        CarregaGrid1()
    End Sub
    Private Sub CarregaGrid1()
        Dim sql As String = "select CODIGO, SIGLA, NOME, ID_LOJA, ID_EMPRESA from cg_loja ORDER BY CODIGO"
        dgvDados1.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        dgvDados1.AutoResizeColumns()
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
            txtBairro.Text = Me.LinhaGrid.Cells("bairro").Value.ToString
            txtCep.Text = Me.LinhaGrid.Cells("cep").Value.ToString
            txtCidade.Text = Me.LinhaGrid.Cells("cidade").Value.ToString
            txtComplemento.Text = Me.LinhaGrid.Cells("complemento").Value.ToString
            txtEndereco.Text = Me.LinhaGrid.Cells("endereco").Value.ToString
            txtNome.Text = Me.LinhaGrid.Cells("nome").Value.ToString
            txtSigla.Text = Me.LinhaGrid.Cells("sigla").Value.ToString
            txtUf.Text = Me.LinhaGrid.Cells("uf").Value.ToString
            txtUnico.Text = Me.LinhaGrid.Cells("codigo").Value.ToString
            txtTelefone.Text = Me.LinhaGrid.Cells("telefone").Value.ToString
            txtCelular.Text = Me.LinhaGrid.Cells("celular").Value.ToString
            chkLojaFisica.Checked = Convert.ToBoolean(Me.LinhaGrid.Cells("loja_fisica").Value)
            chkParceria.Checked = Convert.ToBoolean(Me.LinhaGrid.Cells("parceria").Value)

            '***
            '* Caso ID_TIPO_LOCAL_ESTOQUE < 10 não permitir EDIÇÃO do registro, nem exclusão. Controle Interno do Sistema
            '*
            Me.Id_Tipo_Local_Estoque = Me.LinhaGrid.Cells("ID_TIPO_LOCAL_ESTOQUE").Value
            '*************************************************************************************************************/

            With PesqFKAlocacao
                .txtDesc.Text = Me.LinhaGrid.Cells("desc_alocacao").Value.ToString
                .txtId.Text = Me.LinhaGrid.Cells("id_tipo_local").Value.ToString
            End With

            With PesqFkResponsavel
                .txtDesc.Text = Me.LinhaGrid.Cells("responsavel_area").Value.ToString
                .txtId.Text = Me.LinhaGrid.Cells("id_responsavel_area").Value.ToString
            End With

            With PesqFkArea
                .txtId.Text = Me.LinhaGrid.Cells("id_area").Value.ToString
                .txtDesc.Text = Me.LinhaGrid.Cells("desc_area").Value.ToString
            End With

            '\-Campos novos ==> 27-mai-18
            Me.txtTelefone2.Text = Me.LinhaGrid.Cells("telefone2").Value.ToString
            Me.txtCelular2.Text = Me.LinhaGrid.Cells("celular2").Value.ToString
            Me.txtCelular3.Text = Me.LinhaGrid.Cells("celular3").Value.ToString
            Me.txtCelular4.Text = Me.LinhaGrid.Cells("celular4").Value.ToString
            Me.txtCelular5.Text = Me.LinhaGrid.Cells("celular5").Value.ToString
            Me.txtCelular6.Text = Me.LinhaGrid.Cells("celular6").Value.ToString
            chkInativo.Checked = Convert.ToBoolean(Me.LinhaGrid.Cells("inativo").Value)

            Me.txtUltimaAlteracao.Text = Me.LinhaGrid.Cells("ultima_atualizacao").Value.ToString
            Me.txtVigenciaInicio.Text = Me.LinhaGrid.Cells("inicio_vigencia").Value.ToString
            Me.txtVigenciaFinal.Text = Nothing
            If Not Me.LinhaGrid.Cells("final_vigencia").Value.ToString.Equals("") Then
                Me.txtVigenciaFinal.Text = Me.LinhaGrid.Cells("final_vigencia").Value.ToString
            End If
            '\-Fim: Campos novos ==> 27-mai-18

        End If
    End Sub
    Public Overrides Sub Gravar(acao As Integer)
        'MyBase.Gravar(acao)
        If Not ValidaCampos() Then
            Exit Sub
        End If
        Dim bll As New BLL.LojaBLL
        Dim objLoja As New DTO.Cg_loja
        Dim llOK As Boolean = True

        Try

            objLoja.Id_loja = CInt(txtCodigo.Text)
            objLoja.Bairro = txtBairro.Text.ToString
            objLoja.Cep = txtCep.Text.ToString
            objLoja.Cidade = txtCidade.Text.ToString
            objLoja.Complemento = txtComplemento.Text.ToString
            objLoja.Endereco = txtEndereco.Text.ToString
            objLoja.Id_responsavel = CInt(PesqFkResponsavel.txtId.Text)
            objLoja.Id_tipo_local = CInt(PesqFKAlocacao.txtId.Text)
            objLoja.Nome = txtNome.Text.ToString
            objLoja.Sigla = txtSigla.Text.ToString
            objLoja.Uf = txtUf.Text.ToString

            objLoja.IdArea = PesqFkArea.txtId.Text
            objLoja.LojaFisica = Convert.ToBoolean(chkLojaFisica.Checked)
            objLoja.Parceria = Convert.ToBoolean(chkParceria.Checked)

            objLoja.User_ins = ACE_CODIGO
            objLoja.Data_ins = Hoje()
            objLoja.User_upd = ACE_CODIGO
            objLoja.Data_upd = Hoje()
            objLoja.Codigo = Trim(txtUnico.Text.ToString)
            objLoja.Telefone = Trim(txtTelefone.Text.ToString)
            objLoja.Celular = Trim(txtCelular.Text.ToString)
            objLoja.Id_empresa = Publico.Id_empresa
            objLoja.Id_Tipo_Local_Estoque = 10 'LOJA FISICA de USUÁRIO- normal 

            objLoja.Telefone2 = txtTelefone2.Text.ToString
            objLoja.Celular2 = txtCelular2.Text.ToString
            objLoja.Celular3 = txtCelular3.Text.ToString
            objLoja.Celular4 = txtCelular4.Text.ToString
            objLoja.Celular5 = txtCelular5.Text.ToString
            objLoja.Celular6 = txtCelular6.Text.ToString

            objLoja.Inativo = Convert.ToBoolean(chkInativo.Checked)
            objLoja.Ultima_atualizacao = DateTime.Now.ToString
            objLoja.Inicio_vigencia = txtVigenciaInicio.Text

            objLoja.Final_vigencia = Nothing
            If Not txtVigenciaFinal.Text.Equals("") Then
                objLoja.Final_vigencia = txtVigenciaFinal.Text.ToString
            End If

            bll.GravarBLL(acao, objLoja)
            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            llOK = False
        Finally

            Habilita_Controles(Not llOK) 'modo leitura

        End Try

    End Sub
    Public Overrides Sub Alterar()
        'If CInt(txtCodigo.Text) < 10 Then
        If Me.Id_Tipo_Local_Estoque < 10 Then
            MessageBox.Show("Alteração não permitida, loja utilizada na parametrização de movimento de estoque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta
            Me.Acao = flagAcao
            Exit Sub
        End If
        MyBase.Alterar()
        Habilita_Controles(True) 'modo digitação
    End Sub
    Public Overrides Sub Incluir()
        MyBase.Incluir()
        txtUnico.Text = ""
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
        'If CInt(txtCodigo.Text) < 10 Then
        If Me.Id_Tipo_Local_Estoque < 10 Then
            MessageBox.Show("Exclusão não permitida, loja utilizada na parametrização de movimento de estoque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta
            Me.Acao = flagAcao
            Exit Sub
        End If
        MyBase.ExcluirPorId()
        Dim bll As New BLL.LojaBLL
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
        Dim blnAcao As Boolean
        blnAcao = IIf(acao = Operacao.Novo Or acao = Operacao.Alterar, True, False)

        With PesqFkResponsavel
            .btnPesq.Enabled = False 'Sempre falso
        End With
        With PesqFKAlocacao
            .btnPesq.Enabled = blnAcao
        End With
        With PesqFkArea
            .btnPesq.Enabled = blnAcao
        End With

    End Sub

    Public Overrides Sub Habilita_Controles(blnModo As Boolean)
        MyBase.Habilita_Controles(blnModo)
        txtUnico.ReadOnly = Not blnModo
    End Sub



    Private Sub AtualizaResponsavel()
        If Len(Trim(PesqFkArea.txtId.Text)) = 0 Then
            Exit Sub
        End If
        Try
            Dim bllGlobal As New BLL.GlobalBLL
            Dim sql As String = "SELECT A.ID_RESPONSAVEL, B.NOME FROM CG_AREA A INNER JOIN CG_RESPONSAVEL B " &
                                "ON B.ID_RESPONSAVEL = A.ID_RESPONSAVEL WHERE A.ID_AREA  = " & PesqFkArea.txtId.Text &
                                " AND A.ID_EMPRESA = " & Publico.Id_empresa

            'Dim dt As DataTable
            Dim dt = bllGlobal.SqlExecDT(sql)

            If dt.Rows.Count > 0 Then
                With PesqFkResponsavel
                    .txtId.Text = dt(0)("ID_RESPONSAVEL")
                    .txtDesc.Text = dt(0)("NOME")
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PesqFKAlocacao_Load(sender As Object, e As EventArgs) Handles PesqFKAlocacao.Load
        With Me.PesqFKAlocacao
            .LabelPesqFK = "Alocação"
            .Tabela = "CG_ALOCACAO"
            .View = "CG_ALOCACAO"
            .CampoId = "ID_ALOCACAO"
            .CampoDesc = "DESC_ALOCACAO"
            .ListaCampos = "ID_ALOCACAO, DESC_ALOCACAO"
            .ColunasFiltro = "DESC_ALOCACAO,ID_ALOCACAO"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Alocação"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left -= 5
            .btnPesq.Left += 19
            .txtId.Left += 19
            .txtDesc.Left += 19

        End With
    End Sub

    Private Sub PesqFkArea_Load(sender As Object, e As EventArgs) Handles PesqFkArea.Load
        With Me.PesqFkArea
            .LabelPesqFK = "Área"
            .Tabela = "VW_CG_AREA"
            .View = "VW_CG_AREA"
            .CampoId = "ID_AREA"
            .CampoDesc = "DESC_AREA"
            .ListaCampos = "ID_AREA, DESC_AREA, ID_RESPONSAVEL, NOME"
            .ColunasFiltro = "DESC_AREA,NOME"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de AREA"
            .FiltroSQL = " WHERE ID_EMPRESA = " & Publico.Id_empresa

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = True

            'Ajustes de layout
            .lblLabelFK.Left -= 5
            .btnPesq.Left += 19
            .txtId.Left += 19
            .txtDesc.Left += 19

        End With

    End Sub
    'Metodo executado quando o controle PesqFkArea perde o foco
    'Propriedade PosValida tem ser True e Propriedade Clicou maior que zero
    'cada vez que clica, esta propriedade incrementa em +1
    Private Sub PesqFkArea_Leave(sender As Object, e As EventArgs) Handles PesqFkArea.Leave
        If PesqFkArea.PosValida = True And PesqFkArea.Clicou > 0 Then
            AtualizaResponsavel()
        End If
    End Sub

    Private Sub PesqFkResponsavel_Load(sender As Object, e As EventArgs) Handles PesqFkResponsavel.Load
        'Ajustes de layout
        With PesqFkResponsavel
            .lblLabelFK.Left -= 5
            .btnPesq.Left += 19
            .txtId.Left += 19
            .txtDesc.Left += 19
        End With
    End Sub

    Private Sub chkInativo_CheckedChanged(sender As Object, e As EventArgs) Handles chkInativo.CheckedChanged
        If chkInativo.Checked = True Then
            txtVigenciaFinal.Text = DateTime.Now.ToString
        Else
            txtVigenciaFinal.Text = ""
        End If
    End Sub

    Private Sub dgvDados1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados1.CellClick
        If e.ColumnIndex >= 0 And e.ColumnIndex <= dgvDados1.ColumnCount Then

            CarregaItens(ChaveFilha())

        End If
    End Sub

    Private Sub CarregaItens(ByVal _idLoja As String)

        Dim sql As String
        sql = "select ID_HISTORICO, CODIGO, SIGLA, NOME, ID_LOJA, ID_EMPRESA from cg_loja_historico "
        sql += " where ID_LOJA = " & _idLoja
        sql += " ORDER BY ID_HISTORICO DESC "
        dgvDados2.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        dgvDados2.AutoResizeColumns()

    End Sub
    Private Function ChaveFilha() As String
        Dim tRet As String = "-1"
        Try
            tRet = dgvDados1.CurrentRow.Cells(3).Value.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return tRet
    End Function

    Private Sub dgvDados2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados2.CellContentClick
        If e.ColumnIndex >= 0 And e.ColumnIndex <= dgvDados2.ColumnCount Then

            Try
                Dim bllGlobal As New BLL.GlobalBLL
                Dim sql As String

                sql = "SELECT ID_HISTORICO, "
                sql += "       ID_LOJA, "
                sql += "       SIGLA, "
                sql += "       NOME, "
                sql += "       ENDERECO, "
                sql += "       COMPLEMENTO, "
                sql += "       CEP, "
                sql += "       CIDADE, "
                sql += "       BAIRRO, "
                sql += "       UF, "
                sql += "       ID_TIPO_LOCAL, "
                sql += "       DESC_ALOCACAO, "
                sql += "       ID_RESPONSAVEL, "
                sql += "       RESPONSAVEL, "
                sql += "       APELIDO, "
                sql += "       CODIGO, "
                sql += "       TELEFONE, "
                sql += "       CELULAR, "
                sql += "       ID_AREA, "
                sql += "       DESC_AREA, "
                sql += "       LOJA_FISICA, "
                sql += "       PARCERIA, "
                sql += "       ID_RESPONSAVEL_AREA, "
                sql += "       RESPONSAVEL_AREA, "
                sql += "       ID_EMPRESA, "
                sql += "       ID_TIPO_LOCAL_ESTOQUE, "
                sql += "       TELEFONE2, "
                sql += "       CELULAR2, "
                sql += "       CELULAR3, "
                sql += "       CELULAR4, "
                sql += "       CELULAR5, "
                sql += "       CELULAR6, "
                sql += "       INATIVO, "
                sql += "       ULTIMA_ATUALIZACAO, "
                sql += "       INICIO_VIGENCIA, "
                sql += "       FINAL_VIGENCIA "
                sql += "FROM   VW_CG_LOJA_HISTORICO WHERE ID_HISTORICO = " & dgvDados2.CurrentRow.Cells(0).Value.ToString
                sql += " ORDER BY ID_HISTORICO DESC "

                Dim dt As DataTable
                dt = bllGlobal.SqlExecDT(sql)

                If dt.Rows.Count > 0 Then

                    CarregaDados(dt)

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

    Private Sub CarregaDados(dt As DataTable)

        txtIdHistorico.ReadOnly = True
        txtCodigo.ReadOnly = True
        txtBairro.ReadOnly = True
        txtCep.ReadOnly = True
        txtCidade.ReadOnly = True
        txtComplemento.ReadOnly = True
        txtEndereco.ReadOnly = True
        txtNome.ReadOnly = True
        txtSigla.ReadOnly = True
        txtUf.ReadOnly = True
        txtUnico.ReadOnly = True
        txtTelefone.ReadOnly = True
        txtCelular.ReadOnly = True
        Me.txtTelefone2.ReadOnly = True
        Me.txtCelular2.ReadOnly = True
        Me.txtCelular3.ReadOnly = True
        Me.txtCelular4.ReadOnly = True
        Me.txtCelular5.ReadOnly = True
        Me.txtCelular6.ReadOnly = True
        Me.txtUltimaAlteracao.ReadOnly = True
        Me.txtVigenciaInicio.ReadOnly = True
        Me.txtVigenciaFinal.ReadOnly = True

        txtIdHistorico.Text = dt.Rows(0)("id_historico").ToString
        txtCodigo.Text = dt.Rows(0)("id_loja").ToString
        txtBairro.Text = dt.Rows(0)("bairro").ToString
        txtCep.Text = dt.Rows(0)("cep").ToString
        txtCidade.Text = dt.Rows(0)("cidade").ToString
        txtComplemento.Text = dt.Rows(0)("complemento").ToString
        txtEndereco.Text = dt.Rows(0)("endereco").ToString
        txtNome.Text = dt.Rows(0)("nome").ToString
        txtSigla.Text = dt.Rows(0)("sigla").ToString
        txtUf.Text = dt.Rows(0)("uf").ToString
        txtUnico.Text = dt.Rows(0)("codigo").ToString
        txtTelefone.Text = dt.Rows(0)("telefone").ToString
        txtCelular.Text = dt.Rows(0)("celular").ToString
        chkLojaFisica.Enabled = False
        chkLojaFisica.Checked = Convert.ToBoolean(dt.Rows(0)("LOJA_FISICA").ToString)
        chkParceria.Enabled = False
        chkParceria.Checked = Convert.ToBoolean(dt.Rows(0)("parceria").ToString)

        '***
        '* Caso ID_TIPO_LOCAL_ESTOQUE < 10 não permitir EDIÇÃO do registro, nem exclusão. Controle Interno do Sistema
        '*
        Me.Id_Tipo_Local_Estoque = dt.Rows(0)("ID_TIPO_LOCAL_ESTOQUE").ToString
        '*************************************************************************************************************/

        With PesqFKAlocacao
            .txtDesc.Text = dt.Rows(0)("desc_alocacao").ToString
            .txtId.Text = dt.Rows(0)("id_tipo_local").ToString
        End With

        With PesqFkResponsavel
            .txtDesc.Text = dt.Rows(0)("responsavel_area").ToString
            .txtId.Text = dt.Rows(0)("id_responsavel").ToString
        End With

        With PesqFkArea
            .txtId.Text = dt.Rows(0)("id_area").ToString
            .txtDesc.Text = dt.Rows(0)("desc_area").ToString
        End With

        '\-Campos novos ==> 27-mai-18
        Me.txtTelefone2.Text = dt.Rows(0)("telefone2").ToString
        Me.txtCelular2.Text = dt.Rows(0)("celular2").ToString
        Me.txtCelular3.Text = dt.Rows(0)("celular3").ToString
        Me.txtCelular4.Text = dt.Rows(0)("celular4").ToString
        Me.txtCelular5.Text = dt.Rows(0)("celular5").ToString
        Me.txtCelular6.Text = dt.Rows(0)("celular6").ToString
        chkInativo.Enabled = False
        chkInativo.Checked = Convert.ToBoolean(dt.Rows(0)("inativo").ToString)

        Me.txtUltimaAlteracao.Text = dt.Rows(0)("ultima_atualizacao").ToString
        Me.txtVigenciaInicio.Text = dt.Rows(0)("inicio_vigencia").ToString
        Me.txtVigenciaFinal.Text = dt.Rows(0)("final_vigencia").ToString
        '\-Fim: Campos novos ==> 27-mai-18

    End Sub

    Private Sub dgvDados2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados2.CellEnter
        If e.ColumnIndex >= 0 And e.ColumnIndex <= dgvDados2.ColumnCount Then

            Try
                Dim bllGlobal As New BLL.GlobalBLL
                Dim sql As String

                sql = "SELECT ID_HISTORICO, "
                sql += "       ID_LOJA, "
                sql += "       SIGLA, "
                sql += "       NOME, "
                sql += "       ENDERECO, "
                sql += "       COMPLEMENTO, "
                sql += "       CEP, "
                sql += "       CIDADE, "
                sql += "       BAIRRO, "
                sql += "       UF, "
                sql += "       ID_TIPO_LOCAL, "
                sql += "       DESC_ALOCACAO, "
                sql += "       ID_RESPONSAVEL, "
                sql += "       RESPONSAVEL, "
                sql += "       APELIDO, "
                sql += "       CODIGO, "
                sql += "       TELEFONE, "
                sql += "       CELULAR, "
                sql += "       ID_AREA, "
                sql += "       DESC_AREA, "
                sql += "       LOJA_FISICA, "
                sql += "       PARCERIA, "
                sql += "       ID_RESPONSAVEL_AREA, "
                sql += "       RESPONSAVEL_AREA, "
                sql += "       ID_EMPRESA, "
                sql += "       ID_TIPO_LOCAL_ESTOQUE, "
                sql += "       TELEFONE2, "
                sql += "       CELULAR2, "
                sql += "       CELULAR3, "
                sql += "       CELULAR4, "
                sql += "       CELULAR5, "
                sql += "       CELULAR6, "
                sql += "       INATIVO, "
                sql += "       ULTIMA_ATUALIZACAO, "
                sql += "       INICIO_VIGENCIA, "
                sql += "       FINAL_VIGENCIA "
                sql += "FROM   VW_CG_LOJA_HISTORICO WHERE ID_HISTORICO = " & dgvDados2.CurrentRow.Cells(0).Value.ToString
                sql += " ORDER BY ID_HISTORICO DESC "

                Dim dt As DataTable
                dt = bllGlobal.SqlExecDT(sql)

                If dt.Rows.Count > 0 Then

                    CarregaDados(dt)

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim pesquisar As String
        pesquisar = TextBox1.Text.ToLower
        dgvDados1.ClearSelection()

        For Each row As DataGridViewRow In dgvDados1.Rows
            If row.Cells("CODIGO").Value IsNot Nothing Then
                If row.Cells("CODIGO").Value.ToString.ToLower.StartsWith(pesquisar) Then
                    row.Selected = True
                    dgvDados1.CurrentCell = dgvDados1.Rows(row.Index).Cells(0)
                    dgvDados1.Refresh()
                    Exit For
                End If
            End If
        Next

    End Sub

    Private Sub dgvDados1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados1.CellEnter
        If e.ColumnIndex >= 0 And e.ColumnIndex <= dgvDados1.ColumnCount Then

            CarregaItens(ChaveFilha())

        End If
    End Sub
End Class