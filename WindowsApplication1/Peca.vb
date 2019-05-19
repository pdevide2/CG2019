Imports System.IO

Public Class Peca

    Private imagemAUsar As Image

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
        Me.Tabela = "CG_PECA" 'Nome da tabela no SQL
        Me.Modulo = 17 'codigo do módulo 
        LoginCG() 'retorna o id do usuário
        Me.View = "VW_CG_PECA"
        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_peca
        Me.ColunaId = "ID_PECA"
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
            txtNome.Text = Me.LinhaGrid.Cells("nome_peca").Value.ToString
            PesqFKCategoria.txtDesc.Text = Me.LinhaGrid.Cells("desc_categoria").Value.ToString
            PesqFKCategoria.txtId.Text = Me.LinhaGrid.Cells("id_categoria").Value.ToString
            PesqFKMarca.txtId.Text = Me.LinhaGrid.Cells("id_marca").Value.ToString
            PesqFKMarca.txtDesc.Text = Me.LinhaGrid.Cells("desc_marca").Value.ToString
            PesqFKFornecedor.txtId.Text = Me.LinhaGrid.Cells("id_fornecedor").Value.ToString
            PesqFKFornecedor.txtDesc.Text = Me.LinhaGrid.Cells("nome").Value.ToString

            PesqFKFinalidade.txtId.Text = Me.LinhaGrid.Cells("id_finalidade").Value.ToString
            PesqFKFinalidade.txtDesc.Text = Me.LinhaGrid.Cells("desc_finalidade").Value.ToString

            txtObservacao.Text = Me.LinhaGrid.Cells("OBS").Value.ToString
            txtReferencia.Text = Me.LinhaGrid.Cells("ref_fornec").Value.ToString
            txtCusto.Text = Me.LinhaGrid.Cells("custo").Value.ToString
            txtEstoqueMin.Text = Me.LinhaGrid.Cells("estoque_min").Value.ToString
            txtEstoqueMax.Text = Me.LinhaGrid.Cells("estoque_max").Value.ToString
            txtId_Controle.Text = Me.LinhaGrid.Cells("ID_CONTROLE").Value.ToString
            txtUnidade.Text = Me.LinhaGrid.Cells("unidade").Value.ToString

            txtSerie.Text = Me.LinhaGrid.Cells("serie").Value.ToString
            txtModelo.Text = Me.LinhaGrid.Cells("modelo").Value.ToString

            txtDescricaoPeca.Text = Me.LinhaGrid.Cells("descricao").Value.ToString
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

        Dim bll As New BLL.PecaBLL
        Dim objPECA As New DTO.Cg_peca
        Dim llErro As Boolean = True

        Try
            objPECA.Id_peca = CInt(txtCodigo.Text)
            objPECA.Nome_peca = txtNome.Text
            objPECA.Descricao = txtDescricaoPeca.Text
            objPECA.Id_marca = PesqFKMarca.txtId.Text
            objPECA.Id_fornecedor = PesqFKFornecedor.txtId.Text
            objPECA.Id_finalidade = PesqFKFinalidade.txtId.Text
            objPECA.Id_categoria = PesqFKCategoria.txtId.Text
            objPECA.Unidade = txtUnidade.Text
            objPECA.Estoque_min = txtEstoqueMin.Text
            objPECA.Estoque_max = txtEstoqueMax.Text

            objPECA.Custo = Convert.ToDouble(Replace(txtCusto.Text, ".", ","))
            objPECA.Ref_fornec = txtReferencia.Text

            objPECA.User_ins = ACE_CODIGO
            objPECA.Data_ins = Hoje()
            objPECA.User_upd = ACE_CODIGO
            objPECA.Data_upd = Hoje()

            objPECA.Data_aquisicao = CDate(ShortDate())
            objPECA.Dias_garantia = 0

            objPECA.Obs = txtObservacao.Text

            objPECA.Id_empresa = Publico.Id_empresa

            objPECA.Serie = txtSerie.Text
            objPECA.Modelo = txtModelo.Text

            bll.GravarBLL(acao, objPECA)
            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta
            llErro = False
        Catch ex As SqlClient.SqlException
            llErro = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            llErro = True
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Habilita_Controles(llErro) 'modo leitura

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
        Dim strId_Controle As String
        If Me.KeyId > 0 Then
            txtCodigo.Text = Me.KeyId.ToString()

            strId_Controle = "0000" & Trim(txtCodigo.Text)
            'implementando função right() - cria codigo de 5 posições com zeros a esquerda
            txtId_Controle.Text = "PC" & strId_Controle.Substring(strId_Controle.Length - 4, 4)

            Habilita_Controles(True) 'modo digitação

        Else
            Cancelar(flagAcao)
        End If

    End Sub

    Public Overrides Sub ExcluirPorId()
        MyBase.ExcluirPorId()
        Dim bll As New BLL.PecaBLL
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

        PesqFKFornecedor.btnPesq.Enabled = False
        PesqFKCategoria.btnPesq.Enabled = False
        PesqFKFinalidade.btnPesq.Enabled = False
        PesqFKMarca.btnPesq.Enabled = False

        TabControl1.TabPages(0).Enabled = False
        TabControl1.TabPages(1).Enabled = True
        TabControl1.TabPages(2).Enabled = False

        If acao = Operacao.Consulta Then
            btnAddImage.Enabled = IIf(Not String.IsNullOrEmpty(txtCodigo.Text), True, False)
        Else
            btnAddImage.Enabled = False
        End If


        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            PesqFKFornecedor.btnPesq.Enabled = True
            PesqFKCategoria.btnPesq.Enabled = True
            PesqFKFinalidade.btnPesq.Enabled = True
            PesqFKMarca.btnPesq.Enabled = True

            TabControl1.TabPages(0).Enabled = True
            TabControl1.TabPages(1).Enabled = True
            TabControl1.TabPages(2).Enabled = True

        End If

    End Sub


    Private Sub AnexarFoto()
        Dim strfilename As String = ""
        ofd.FileName = strfilename
        ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        Try
            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                strfilename = Trim(ofd.FileName)
                imagemAUsar = Image.FromFile(strfilename)
                PicFotoPeca.Image = imagemAUsar
            Else
                MessageBox.Show("Seleção de Foto cancelada pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                strfilename = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If Not String.IsNullOrEmpty(strfilename) Then

            Dim intIdPeca As Integer = CInt(txtCodigo.Text)

            Dim mensagem As String = "Confirma importação da Foto para anexar na peça {0}?"
            mensagem = String.Format(mensagem, txtId_Controle.Text)

            If MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Gravar_Foto(strfilename, intIdPeca)
            End If

        End If
    End Sub

    Private Sub Gravar_Foto(ByVal strfilename As String, ByVal idPeca As Integer)
        Dim objPecaFoto As New DTO.Cg_peca_foto
        Dim bll As New BLL.PecaBLL
        Try

            Dim filebyte() As Byte = Nothing
            filebyte = System.IO.File.ReadAllBytes(strfilename)

            'Carrega os dados no objeto Model para passagem de parametro
            objPecaFoto.Id_peca = idPeca
            objPecaFoto.Foto_peca = filebyte
            objPecaFoto.Filetype = "jpg"

            bll.GravarFotoPecaBLL(1, objPecaFoto)

            MessageBox.Show("PDF anexado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Catch ex As Exception
            MessageBox.Show("Erro ao anexar PDF: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        AnexarFoto()
    End Sub


    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        If Acao = Operacao.Consulta Then
            btnAddImage.Enabled = IIf(Not String.IsNullOrEmpty(txtCodigo.Text), True, False)
        Else
            btnAddImage.Enabled = False
        End If
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

    Private Sub CarregarImagem()

        Try

            'Carregar a foto
            Dim bllGlobal As New BLL.GlobalBLL
            Dim sql As String

            sql = "Select foto "
            sql += "From cg_peca where id_peca = " & txtCodigo.Text.ToString

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)


            If dt.Rows.Count > 0 Then
                Dim _bits As Byte()
                _bits = CType(dt.Rows(0)("FOTO"), Byte())
                Dim _memorybits As New MemoryStream(_bits)
                Dim _bitmap As New Bitmap(_memorybits)
                PicFotoPeca.Image = _bitmap
                PicFotoPeca.Refresh()
            End If


        Catch EX As Exception

            'se não houver fotos gravadas irá ocorrer um erro que deve ser ignorado
            'MessageBox.Show(EX.Message, "Não é possível exibir a foto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            PicFotoPeca.Image = Nothing
            PicFotoPeca.Refresh()

        End Try

    End Sub

    Private Sub PesqFKFornecedor_Load(sender As Object, e As EventArgs) Handles PesqFKFornecedor.Load
        With Me.PesqFKFornecedor
            .LabelPesqFK = "Fornecedor"
            .Tabela = "CG_FORNECEDOR"
            .View = "CG_FORNECEDOR"
            .CampoId = "ID_FORNECEDOR"
            .CampoDesc = "NOME"
            .ListaCampos = "ID_FORNECEDOR, NOME, SIGLA"
            .ColunasFiltro = "NOME,SIGLA,ID_FORNECEDOR"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Fornecedores"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 29
            .txtId.Width -= 20
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 111
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With
    End Sub

    Private Sub PesqFKMarca_Load(sender As Object, e As EventArgs) Handles PesqFKMarca.Load
        With Me.PesqFKMarca
            .LabelPesqFK = "Marca"
            .Tabela = "CG_MARCA"
            .View = "CG_MARCA"
            .CampoId = "ID_MARCA"
            .CampoDesc = "DESC_MARCA"
            .ListaCampos = "ID_MARCA, DESC_MARCA"
            .ColunasFiltro = "DESC_MARCA,ID_MARCA"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Marcas"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 29
            .txtId.Width -= 20
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 111
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With

    End Sub

    Private Sub PesqFKCategoria_Load(sender As Object, e As EventArgs) Handles PesqFKCategoria.Load
        With Me.PesqFKCategoria
            .LabelPesqFK = "Categoria"
            .Tabela = "CG_CATEGORIA"
            .View = "CG_CATEGORIA"
            .CampoId = "ID_CATEGORIA"
            .CampoDesc = "DESC_CATEGORIA"
            .ListaCampos = "ID_CATEGORIA, DESC_CATEGORIA"
            .ColunasFiltro = "DESC_CATEGORIA,ID_CATEGORIA"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Categorias"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 29
            .txtId.Width -= 20
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 111
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With

    End Sub

    Private Sub PesqFKFinalidade_Load(sender As Object, e As EventArgs) Handles PesqFKFinalidade.Load
        With Me.PesqFKFinalidade
            .LabelPesqFK = "Finalidade"
            .Tabela = "CG_FINALIDADE"
            .View = "CG_FINALIDADE"
            .CampoId = "ID_FINALIDADE"
            .CampoDesc = "DESC_FINALIDADE"
            .ListaCampos = "ID_FINALIDADE, DESC_FINALIDADE"
            .ColunasFiltro = "DESC_FINALIDADE,ID_FINALIDADE"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Finalidades"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 29
            .txtId.Width -= 20
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 111
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 3

        End With

    End Sub
End Class