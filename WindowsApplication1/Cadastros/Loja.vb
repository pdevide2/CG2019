Imports System.IO
Public Class Loja
    Private imagemAUsar As Image
    Private _id_tipo_local_estoque As Integer
    Public Property Id_Tipo_Local_Estoque() As Integer
        Get
            Return _id_tipo_local_estoque
        End Get
        Set(ByVal value As Integer)
            _id_tipo_local_estoque = value
        End Set
    End Property
    Private _idLoja As Integer
    Public Property IdLoja() As Integer
        Get
            Return _idLoja
        End Get
        Set(ByVal value As Integer)
            _idLoja = value
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

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_loja
        Me.ColunaId = "ID_LOJA"
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
            If TabControl1.SelectedIndex = 1 Then
                CarregarImagem()
            End If
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
        If Me.Id_Tipo_Local_Estoque < 13 Then
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
        txtVigenciaInicio.Text = Hoje().ToString
        txtUltimaAlteracao.Text = Hoje().ToString

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

        txtUltimaAlteracao.ReadOnly = True
        txtVigenciaInicio.ReadOnly = True
        txtVigenciaFinal.ReadOnly = True

        txtBairro.ReadOnly = Not blnModo
        txtCep.ReadOnly = Not blnModo
        txtCidade.ReadOnly = Not blnModo
        txtComplemento.ReadOnly = Not blnModo
        txtEndereco.ReadOnly = Not blnModo
        txtNome.ReadOnly = Not blnModo
        txtSigla.ReadOnly = Not blnModo
        txtUf.ReadOnly = Not blnModo
        txtUnico.ReadOnly = Not blnModo
        txtTelefone.ReadOnly = Not blnModo
        txtCelular.ReadOnly = Not blnModo
        chkLojaFisica.Enabled = blnModo
        chkParceria.Enabled = blnModo
        chkInativo.Enabled = blnModo

        Me.txtTelefone2.ReadOnly = Not blnModo
        Me.txtCelular2.ReadOnly = Not blnModo
        Me.txtCelular3.ReadOnly = Not blnModo
        Me.txtCelular4.ReadOnly = Not blnModo
        Me.txtCelular5.ReadOnly = Not blnModo
        Me.txtCelular6.ReadOnly = Not blnModo
        'chkInativo.Checked = Convert.ToBoolean(Me.LinhaGrid.Cells("inativo").Value)
        btnHistorico.Enabled = Not blnModo

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

    Private Sub chkInativo_CheckedChanged(sender As Object, e As EventArgs)
        If chkInativo.Checked = True Then
            txtVigenciaFinal.Text = DateTime.Now.ToString
        Else
            txtVigenciaFinal.Text = ""
        End If
    End Sub

    Private Sub btnHistorico_Click(sender As Object, e As EventArgs) Handles btnHistorico.Click
        Dim lojaSelecionada As Integer
        lojaSelecionada = 0
        If Not String.IsNullOrEmpty(txtCodigo.Text) Then
            lojaSelecionada = CInt(txtCodigo.Text)
        End If

        Dim frm As New WinCG.LojaHistorico(lojaSelecionada)
        frm.ShowDialog()

    End Sub

    Private Sub AnexarFoto()
        Dim strfilename As String = ""
        ofd.FileName = strfilename
        ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        Try
            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                strfilename = Trim(ofd.FileName)
                imagemAUsar = Image.FromFile(strfilename)
                PicFotoLoja.Image = imagemAUsar
            Else
                MessageBox.Show("Seleção de Foto cancelada pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                strfilename = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If Not String.IsNullOrEmpty(strfilename) Then

            Dim intIdLoja As Integer = CInt(txtCodigo.Text)

            Dim mensagem As String = "Confirma importação da Foto para anexar na Loja {0}?"
            mensagem = String.Format(mensagem, txtUnico.Text)

            If MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Gravar_Foto(strfilename, intIdLoja)
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        AnexarFoto()
    End Sub

    Private Sub Gravar_Foto(ByVal strfilename As String, ByVal idLoja As Integer)
        Dim objLojaFoto As New DTO.Cg_loja_foto
        Dim bll As New BLL.LojaBLL
        Try

            Dim filebyte() As Byte = Nothing
            filebyte = System.IO.File.ReadAllBytes(strfilename)

            'Carrega os dados no objeto Model para passagem de parametro
            objLojaFoto.Id_Loja = idLoja
            objLojaFoto.Foto_Loja = filebyte
            objLojaFoto.Filetype = "jpg"

            bll.GravarFotoLojaBLL(1, objLojaFoto)

            MessageBox.Show("Imagem anexada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Catch ex As Exception
            MessageBox.Show("Erro ao anexar Imagem: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try
    End Sub
    Private Sub CarregarImagem()

        Try

            'Carregar a foto
            Dim bllGlobal As New BLL.GlobalBLL
            Dim sql As String

            sql = "Select foto "
            sql += "From cg_loja where id_loja = " & txtCodigo.Text.ToString

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)


            If dt.Rows.Count > 0 Then
                Dim _bits As Byte()
                _bits = CType(dt.Rows(0)("FOTO"), Byte())
                Dim _memorybits As New MemoryStream(_bits)
                Dim _bitmap As New Bitmap(_memorybits)
                PicFotoLoja.Image = _bitmap
                PicFotoLoja.Refresh()
            End If


        Catch EX As Exception

            'se não houver fotos gravadas irá ocorrer um erro que deve ser ignorado
            'MessageBox.Show(EX.Message, "Não é possível exibir a foto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            PicFotoLoja.Image = Nothing
            PicFotoLoja.Refresh()

        End Try

    End Sub
    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        'Dim messageBoxVB As New System.Text.StringBuilder()
        'messageBoxVB.AppendFormat("{0} = {1}", "TabPage", e.TabPage)
        'messageBoxVB.AppendLine()
        'messageBoxVB.AppendFormat("{0} = {1}", "TabPageIndex", e.TabPageIndex)
        'messageBoxVB.AppendLine()
        'messageBoxVB.AppendFormat("{0} = {1}", "Action", e.Action)
        'messageBoxVB.AppendLine()
        'MessageBox.Show(messageBoxVB.ToString(), "Selected Event")
        If flagAcao = Operacao.Consulta And e.TabPageIndex = 1 Then
            btnAddImage.Enabled = IIf(Not String.IsNullOrEmpty(txtCodigo.Text), True, False)
            CarregarImagem()
        Else
            btnAddImage.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Normal" Then
            Me.PicFotoLoja.SizeMode = PictureBoxSizeMode.Normal
        End If
        If ComboBox1.Text = "StretchImage" Then
            Me.PicFotoLoja.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If ComboBox1.Text = "AutoSize" Then
            Me.PicFotoLoja.SizeMode = PictureBoxSizeMode.AutoSize
        End If
        If ComboBox1.Text = "CenterImage" Then
            Me.PicFotoLoja.SizeMode = PictureBoxSizeMode.CenterImage
        End If
        If ComboBox1.Text = "Zoom" Then
            Me.PicFotoLoja.SizeMode = PictureBoxSizeMode.Zoom
        End If
        'Me.PicFotoLoja.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class