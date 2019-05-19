
Public Class Chip

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
        Me.Tabela = "CG_CHIP" 'Nome da tabela no SQL
        Me.View = "VW_CG_CHIP" 'Nome da view de CHIP
        Me.Modulo = 16 'codigo do módulo 
        LoginCG() 'retorna o id do usuário

        'Define a permissão para navegar do Usuário (Leitura/Sem Acesso ou Gravação) 
        'Atribui o retorno da permissão na propriedade Me.Acesso
        'permissaoTela(Me.Modulo, ACE_CODIGO)
        HabilitaBotoes(flagAcao)
        'MessageBox.Show(ACE_CODIGO.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.ObjModel = New DTO.Cg_chip
        Me.ColunaId = "ID_CHIP"
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

            txtCodigo.Text = Me.LinhaGrid.Cells("id_chip").Value.ToString
            txtSIMId.Text = Me.LinhaGrid.Cells("simid").Value.ToString
            PesqFKOperadora.txtId.Text = Me.LinhaGrid.Cells("id_operadora").Value.ToString
            PesqFKOperadora.txtDesc.Text = Me.LinhaGrid.Cells("desc_operadora").Value.ToString
            PesqFKFornecedor.txtId.Text = Me.LinhaGrid.Cells("id_fornecedor").Value.ToString
            PesqFKFornecedor.txtDesc.Text = Me.LinhaGrid.Cells("nome").Value.ToString
            txtCusto.Text = Me.LinhaGrid.Cells("CUSTO").Value.ToString

        End If
    End Sub
    Public Overrides Sub Gravar(acao As Integer)

        If Not ValidaCampos() Then
            Exit Sub
        End If
        'MyBase.Gravar(acao)
        Dim bll As New BLL.ChipBLL
        Dim objChip As New DTO.Cg_chip
        Dim blnErro As Boolean
        blnErro = True
        Try
            objChip.Id_chip = CInt(txtCodigo.Text)
            objChip.Simid = txtSIMId.Text
            objChip.Id_operadora = CInt(PesqFKOperadora.txtId.Text)
            objChip.Id_fornecedor = CInt(PesqFKFornecedor.txtId.Text)

            If String.IsNullOrEmpty(txtCusto.Text) Then
                objChip.Custo = 0
            Else
                objChip.Custo = Convert.ToDouble(Replace(txtCusto.Text, ".", ","))
            End If

            objChip.User_ins = ACE_CODIGO
            objChip.Data_ins = Hoje()
            objChip.User_upd = ACE_CODIGO
            objChip.Data_upd = Hoje()
            objChip.Id_empresa = Publico.Id_empresa

            bll.GravarBLL(acao, objChip)
            MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flagAcao = Operacao.Consulta
            blnErro = False

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            Habilita_Controles(blnErro) 'modo leitura

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
        Dim bll As New BLL.ChipBLL
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

        PesqFKOperadora.btnPesq.Enabled = False 'Desabilita o botão de pesquisar Operadora
        PesqFKFornecedor.btnPesq.Enabled = False 'Desabilita o botão de pesquisar Fornecedor

        If acao = Operacao.Novo Or acao = Operacao.Alterar Then
            PesqFKOperadora.btnPesq.Enabled = True 'Habilita o botão de pesquisar Operadora
            PesqFKFornecedor.btnPesq.Enabled = True 'Habilita o botão de pesquisar Fornecedor
        End If

    End Sub

    Public Overrides Function ValidaCampos() As Object
        Try
            If String.IsNullOrEmpty(txtSIMId.Text) Then
                Throw New Exception("Atenção SIMID do Chip deve ser informado!")
            End If
            If String.IsNullOrEmpty(PesqFKOperadora.txtId.Text.ToString) Then
                Throw New Exception("Obrigatório informar a Operadora!")
            Else
                If CInt(PesqFKOperadora.txtId.Text) <= 0 Then
                    Throw New Exception("Obrigatório informar uma Operadora válida!")
                End If
            End If
            If String.IsNullOrEmpty(PesqFKFornecedor.txtId.Text.ToString) Then
                Throw New Exception("Obrigatório informar o Fornecedor!")
            Else
                If CInt(PesqFKFornecedor.txtId.Text) <= 0 Then
                    Throw New Exception("Obrigatório informar um Fornecedor válido!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
        'Return MyBase.ValidaCampos()
    End Function
    Private Sub txtSIMId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSIMId.KeyPress
        '!' A rotina abaixo permite a digitação apenas de números de 0 a 9 e não aceita outro 
        '!' tipo de caracter
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PesqFKOperadora_Load(sender As Object, e As EventArgs) Handles PesqFKOperadora.Load
        With Me.PesqFKOperadora
            .LabelPesqFK = "Operadora"
            .Tabela = "CG_OPERADORA"
            .View = "CG_OPERADORA"
            .CampoId = "ID_OPERADORA"
            .CampoDesc = "DESC_OPERADORA"
            .ListaCampos = "ID_OPERADORA, DESC_OPERADORA"
            .ColunasFiltro = "DESC_OPERADORA,ID_OPERADORA"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Operadoras"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .btnPesq.Left += 24
            .txtId.Left += 19
            .txtId.Width -= 20
            .txtDesc.Left += 2
            .txtDesc.Width += 20

        End With
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
            .btnPesq.Left += 24
            .txtId.Left += 19
            .txtId.Width -= 20
            .txtDesc.Left += 2
            .txtDesc.Width += 20

        End With
    End Sub
End Class