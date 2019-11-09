Public Class Principal

    Public Enum Modulo
        Usuarios = 1
        Modulos = 2
        Permissoes_de_acesso = 3
        Sequenciais_de_chaves_das_tabelas = 4
        Status = 5
        Status_de_os = 6
        Responsaveis = 7
        Alocacao = 8
        Cargos = 9
        Tipo_de_servico = 10
        Tipo_de_equipamento = 11
        Motivo = 12
        Lojas = 13
        Fornecedores = 14
        Operadoras = 15
        Chip = 16
        Equipamentos_pos = 17
        Entrada_de_chip = 18
        Movimentacao_de_chip = 19
        Recebimento_de_chip = 20
        Devolucao_chip_para_fornecedor = 21
        Entrada_de_equipamentos = 22
        Movimentacao_de_equipamentos = 23
        Recebimento_de_equipamentos = 24
        Devolucao_equipamentos_para_fornecedor = 25
        Cadastro_de_os = 26
        Follow_up_de_os = 27
        Retorno_de_os = 28
        Vincular_chip_com_pos = 29
        Modelos = 30
        Consulta_estoque_chip = 31
        Log_transacoes_chip = 32
        Consulta_estoque_pos = 33
        Log_transacoes_pos = 34
        Importar_cadastro_chip = 35
        Importar_cadastro_equipamento = 36
        Importar_entrada_chip = 37
        Importar_entrada_equipamento = 38
        Relatorio_geral_estoque_chip = 39
        Relatorio_geral_estoque_equipamento = 40
        Relatorio_POS_x_Chip = 41
        Importar_cadastro_loja = 42
        Movimentar_chip_inativo = 43
        Movimentar_equipamento_inativo = 44
        Marcas = 45
        Categorias = 46
        Finalidades = 47
        Pecas = 48
        Pedido_compras_peca = 49
        Baixa_pedido_compra_peca = 50
        Parametrizacao_Pesquisa = 51
        CadTabelasViews = 52
        CadArea = 53
        Ocorrencia = 54
        Quarentena = 55
        Transito = 56
        Movimento_transito_chip = 57
        Baixa_transito_chip = 58
        Movimento_transito_equipamento = 59
        Baixa_transito_equipamento = 60
        Empresa = 61
        Perfil = 62
        Entrada_estoque = 64
        Gerar_transito_estoque = 65
        Baixar_transito_estoque = 66
        Consulta_transito_estoque_unificado = 67
        Consulta_geral_estoque_unificado = 68
        Transferencia_entre_empresas = 69
        Transferencia_cadastros = 70
        Concerto = 71
        TabelaPrecos = 72
        MovEstoque = 73
        Clientes = 74
        PedidoVenda = 75
        AprovacaoPedidoVenda = 76
        DevolucaoPedidoVenda = 77
        AprovacaoTransferencia = 78

    End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = UserName()
        lblEmpresaLogada.Text = "Empresa Login: " & Publico.Id_empresa & " - " & Publico.Nome_empresa
        PictureBox1.Left = Me.Width - 250
        lblUser.Left = Me.Width - 190
        lblEmpresaLogada.Left = lblUser.Left
        MenuStrip1.Visible = False

        Dim blnVerMenu As Boolean = False
        ToolStripDropDownButton1.Visible = blnVerMenu
        ToolStripDropDownButton2.Visible = blnVerMenu
        tsSeparator01.Visible = blnVerMenu
        tsSeparator02.Visible = blnVerMenu
        tsSeparator03.Visible = blnVerMenu

        'me.BackColor = Color.Black
    End Sub
    Public Sub ChangeAndPersistSettingsModulo(ByVal _modulo As Integer)
        My.Settings.ID_MODULO = _modulo
        My.Settings.Save()
    End Sub
    Public Sub ChangeAndPersistSettingsAcesso(ByVal _permissao As String)
        My.Settings.PERMISSAO = _permissao
        My.Settings.Save()
    End Sub
    Public Sub ChamaMenu(ByVal _modulo As Integer)

        'Verifica a permissão de acesso ao módulo. Caso seja igual ao "S", nem carrega a tela
        ChangeAndPersistSettingsModulo(_modulo)
        ACE_MODULO = ModuloID()
        ACE_CODIGO = LoginCG()

        Dim _permissao As String

        _permissao = AcessoTela(ACE_MODULO, ACE_CODIGO)
        ChangeAndPersistSettingsAcesso(_permissao)

        ACE_PERMISSAO = PermissaoModulo()

        If ACE_PERMISSAO = "S" Then
            MessageBox.Show("Usuário não tem permissão de acesso para este módulo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim oPermissao As New DTO.PermissaoModulo
        DefineAcessoBotao(ACE_MODULO, oPermissao)

        Dim frm As Object = Nothing

        '  1 - USUÁRIOS
        If ACE_MODULO = 1 Then
            frm = New WinCG.Usuarios(oPermissao)
        End If
        '  2 - MÓDULOS
        If ACE_MODULO = 2 Then
            frm = New WinCG.Modulo(oPermissao)
        End If
        '  3 - PERMISSÕES DE ACESSO
        If ACE_MODULO = 3 Then
            frm = New WinCG.Acessos
        End If
        '  4 - SEQUENCIAIS DE CHAVES DAS TABELAS
        If ACE_MODULO = 4 Then
            frm = New WinCG.Sequencial(oPermissao)
        End If
        '  5 - STATUS
        If ACE_MODULO = 5 Then
            frm = New WinCG.Status(oPermissao)
        End If
        '  6 - STATUS DE OS
        If ACE_MODULO = 6 Then
            frm = New WinCG.StatusOs(oPermissao)
        End If
        '  7 - RESPONSAVEIS
        If ACE_MODULO = 7 Then
            frm = New WinCG.Responsavel(oPermissao)
        End If
        '  8 - ALOCAÇÃO
        If ACE_MODULO = 8 Then
            frm = New WinCG.Alocacao(oPermissao)
        End If
        '  9 - CARGOS
        If ACE_MODULO = 9 Then
            frm = New WinCG.Cargo(oPermissao)
        End If
        ' 10 - TIPO DE SERVIÇO
        If ACE_MODULO = 10 Then
            frm = New WinCG.TipoServico(oPermissao)
        End If
        ' 11 - TIPO DE EQUIPAMENTO
        If ACE_MODULO = 11 Then
            frm = New WinCG.TipoEquipamento(oPermissao)
        End If
        ' 12 - MOTIVO
        If ACE_MODULO = 12 Then
            frm = New WinCG.Motivos(oPermissao)
        End If
        ' 13 - LOJAS
        If ACE_MODULO = 13 Then
            frm = New WinCG.Loja(oPermissao)
        End If
        ' 14 - FORNECEDORES
        If ACE_MODULO = 14 Then
            frm = New WinCG.Fornecedores(oPermissao)
        End If
        ' 15 - OPERADORAS
        If ACE_MODULO = 15 Then
            frm = New WinCG.Operadora(oPermissao)
        End If
        ' 16 - CHIP
        If ACE_MODULO = 16 Then
            frm = New WinCG.Chip(oPermissao)
        End If
        ' 17 - EQUIPAMENTOS (POS)
        If ACE_MODULO = 17 Then
            frm = New WinCG.Equipamento(oPermissao)
        End If
        ' 18 - ENTRADA DE CHIP
        If ACE_MODULO = 18 Then
            frm = New WinCG.EntradaChip(oPermissao)
        End If
        ' 19 - MOVIMENTAÇÃO DE CHIP
        If ACE_MODULO = 19 Then
            frm = New WinCG.MovimentoChip(oPermissao)
        End If
        ' 20 - RECEBIMENTO DE CHIP
        If ACE_MODULO = 20 Then
            frm = New WinCG.RecebimentoChip
        End If
        ' 21 - DEVOLUÇÃO CHIP PARA FORNECEDOR
        If ACE_MODULO = 21 Then
            frm = New WinCG.DevolucaoChip
        End If
        ' 22 - ENTRADA DE EQUIPAMENTOS
        If ACE_MODULO = 22 Then
            frm = New WinCG.EntradaEquipamento(oPermissao)
        End If
        ' 23 - MOVIMENTAÇÃO DE EQUIPAMENTOS
        If ACE_MODULO = 23 Then
            frm = New WinCG.MovimentoEquipamento
        End If
        ' 24 - RECEBIMENTO DE EQUIPAMENTOS
        If ACE_MODULO = 24 Then
            frm = New WinCG.RecebimentoEquipamento
        End If
        ' 25 - DEVOLUÇÃO EQUIPAMENTOS PARA FORNECEDOR
        If ACE_MODULO = 25 Then
            frm = New WinCG.DevolucaoEquipamento
        End If
        ' 26 - CADASTRO DE OS
        If ACE_MODULO = 26 Then
            frm = New WinCG.OS(oPermissao)
        End If
        ' 27 - FOLLOW UP DE OS
        If ACE_MODULO = 27 Then
            frm = New WinCG.FollowUp_OS
        End If
        ' 28 - RETORNO DE OS
        If ACE_MODULO = 28 Then
            frm = New WinCG.Recebimento_OS
        End If
        ' 29 - VINCULAR CHIP COM POS
        If ACE_MODULO = 29 Then
            frm = New WinCG.Pos_vinculo(oPermissao)
        End If
        ' 30 - MODELOS
        If ACE_MODULO = 30 Then
            frm = New WinCG.Modelos(oPermissao)
        End If
        ' 31 - CONSULTA ESTOQUE CHIP
        If ACE_MODULO = 31 Then
            'frm = New WinCG.Estoque_chip
            frm = New WinCG.ConsultaEstoque("C")
        End If
        ' 32 - LOG TRANSACOES CHIP
        If ACE_MODULO = 32 Then
            'frm = New WinCG.ConsultaMovimentoTransitoChip 'WinCG.Consulta_Transacoes_Chip
            frm = New WinCG.ConsultaMovimentoTransito("C")
        End If
        ' 33 - CONSULTA ESTOQUE POS
        If ACE_MODULO = 33 Then
            frm = New WinCG.ConsultaEstoque("E")
        End If
        ' 34 - LOG TRANSACOES POS
        If ACE_MODULO = 34 Then
            frm = New WinCG.ConsultaMovimentoTransito("E")
        End If
        ' 35 - IMPORTAR CADASTRO CHIP
        If ACE_MODULO = 35 Then
            frm = New WinCG.ImportarCadastroChip
        End If
        ' 36 - IMPORTAR CADASTRO EQUIPAMENTO
        If ACE_MODULO = 36 Then
            frm = New WinCG.ImportarCadastroEquipamento
        End If
        ' 37 - IMPORTAR ENTRADA CHIP
        If ACE_MODULO = 37 Then
            frm = New WinCG.ImportarEntradaChip
        End If
        ' 38 - IMPORTAR ENTRADA EQUIPAMENTO
        If ACE_MODULO = 38 Then
            frm = New WinCG.ImportarEntradaEquipamento
        End If
        ' 39 - RELATORIO GERAL ESTOQUE CHIP
        If ACE_MODULO = 39 Then
            frm = New WinCG.rptEstoqueGeralChipPorLoja
        End If
        If ACE_MODULO = 40 Then
            frm = New WinCG.rptEstoqueGeralEquipamentoPorLoja
        End If
        'If ACE_MODULO = 41 Then
        '    frm = New WinCG.rptPOSxChip_Viewer
        'End If
        ' 42 - IMPORTAR CADASTRO DE LOJAS
        If ACE_MODULO = 42 Then
            frm = New WinCG.ImportarCadastroLoja
        End If
        ' 43 - MOVIMENTAR CHIP PARA ESTOQUE INATIVO
        If ACE_MODULO = 43 Then
            frm = New WinCG.MovimentoChipInativo
        End If
        ' 44 - MOVIMENTAR EQUIPAMENTO PARA ESTOQUE INATIVO
        If ACE_MODULO = 44 Then
            frm = New WinCG.MovimentoEquipamentoInativo
        End If
        ' 45 - CADASTRO DE MARCAS
        If ACE_MODULO = 45 Then
            frm = New WinCG.Marca(oPermissao)
        End If
        ' 46 - CADASTRO DE CATEGORIAS
        If ACE_MODULO = 46 Then
            frm = New WinCG.Categoria(oPermissao)
        End If
        ' 47 - CADASTRO DE FINALIDADES
        If ACE_MODULO = 47 Then
            frm = New WinCG.Finalidade(oPermissao)
        End If
        ' 48 - CADASTRO DE PECAS
        If ACE_MODULO = 48 Then
            frm = New WinCG.Peca(oPermissao)
        End If
        ' 49 - PEDIDO DE COMPRAS DE PECAS
        If ACE_MODULO = 49 Then
            frm = New WinCG.PedidoCompraPeca(oPermissao)
        End If
        ' 50 - BAIXA DE PEDIDO DE COMPRA DE PECAS
        If ACE_MODULO = 50 Then
            frm = New WinCG.Peca(oPermissao)
        End If
        ' 51 - PARAMETRIZAÇÃO DE PESQUISA DINAMICA
        If ACE_MODULO = 51 Then
            frm = New WinCG.ParametrosPesquisaDinamica
        End If
        ' 52 - CADASTRO DE TABELAS/VIEWS
        If ACE_MODULO = 52 Then
            frm = New WinCG.TabelasPesquisaDinamica(oPermissao)
        End If
        ' 53 - CADASTRO DE AREAS
        If ACE_MODULO = 53 Then
            frm = New WinCG.Area(oPermissao)
        End If
        ' 54 - CADASTRO DE OCORRENCIAS
        If ACE_MODULO = 54 Then
            frm = New WinCG.Ocorrencia(oPermissao)
        End If
        ' 55 - MOVIMENTAR PARA QUARENTENA
        If ACE_MODULO = 55 Then
            frm = New WinCG.MovimentoEquipamentoQuarentena
        End If
        ' 56 - CADASTRO DE TRANSITO
        If ACE_MODULO = 56 Then
            frm = New WinCG.Cadtransito(oPermissao)
        End If
        ' 57 - MOVIMENTO TRANSITO CHIP
        If ACE_MODULO = 57 Then
            frm = New WinCG.GeraMovimentoTransito("C") 'Parametro "C" ==> Chip
        End If
        ' 58 - BAIXA TRANSITO CHIP
        If ACE_MODULO = 58 Then
            frm = New WinCG.BaixaMovimentoTransito("C") 'Parametro "C" ==> Chip
        End If
        ' 59 - MOVIMENTO TRANSITO EQUIPAMENTO
        If ACE_MODULO = 59 Then
            frm = New WinCG.GeraMovimentoTransito("E") 'Parametro "E" ==> Equipamento
        End If
        ' 60 - BAIXA TRANSITO POS
        If ACE_MODULO = 60 Then
            frm = New WinCG.BaixaMovimentoTransito("E") 'Parametro "E" ==> EQUIPAMENTO
        End If
        ' 61 - CADASTRO DE EMPRESAS
        If ACE_MODULO = 61 Then
            frm = New WinCG.Empresa(oPermissao)
        End If
        ' 62 - CADASTRO DE PERFIL DE USUARIOS
        If ACE_MODULO = 62 Then
            frm = New WinCG.Perfil(oPermissao)
        End If

        ' 64 - ENTRADA DE ESTOQUE
        If ACE_MODULO = 64 Then
            frm = New WinCG.EntradaEstoque(oPermissao)
        End If
        ' 65 - MOVIMENTO TRANSITO ESTOQUE
        If ACE_MODULO = 65 Then
            'frm = New WinCG.GeraMovimentoTransito("C") 'MOVIMENTO TRANSITO ESTOQUE UNIFICADO (CHIP E POS)
            frm = New WinCG.GeraTransitoGeral(oPermissao)
        End If
        ' 66 - BAIXA TRANSITO ESTOQUE
        If ACE_MODULO = 66 Then
            frm = New WinCG.BaixaMovimentoTransito("C") 'BAIXA TRANSITO ESTOQUE UNIFICADO (CHIP E POS)
        End If
        ' 67 - LOG TRANSACOES CHIP/POS (Unificado)
        If ACE_MODULO = 67 Then
            'frm = New WinCG.ConsultaMovimentoTransitoChip 'WinCG.Consulta_Transacoes_Chip
            frm = New WinCG.ConsultaMovimentoTransito("C")
        End If
        ' 68 - CONSULTA ESTOQUE GERAL UNIFICADO (CHIP/POS)
        If ACE_MODULO = 68 Then
            'frm = New WinCG.Estoque_chip
            frm = New WinCG.ConsultaEstoque("C")
        End If
        ' 69 - TRANSFERENCIA DE ESTOQUE
        If ACE_MODULO = 69 Then
            frm = New WinCG.TransferenciaEstoque2(oPermissao)
        End If
        ' 70 - TRANSFERENCIA DE CADASTROS BASICOS ENTRE EMPRESAS
        If ACE_MODULO = 70 Then
            frm = New WinCG.TransferenciaCadastros(oPermissao)
        End If
        ' 71 - CADASTRO DE ITENS DE CONCERTO/REPARO
        If ACE_MODULO = 71 Then
            frm = New WinCG.Concertos(oPermissao)
        End If
        ' 72 - TABELA DE PREÇOS DE SERVIÇOS
        If ACE_MODULO = 72 Then
            frm = New WinCG.TabelaPrecos(oPermissao)
        End If
        ' 73 - MOVIMENTAÇÃO DE ESTOQUE DE POS
        If ACE_MODULO = 73 Then
            frm = New WinCG.MovEstoquePOS
        End If
        ' 74 - CADASTRO DE CLIENTES
        If ACE_MODULO = 74 Then
            frm = New WinCG.Clientes(oPermissao)
        End If
        ' 74 - CADASTRO DE CLIENTES
        If ACE_MODULO = 75 Then
            frm = New WinCG.PedidoVenda(oPermissao)
        End If
        ' 76 - aprovação de pedidos de venda
        If ACE_MODULO = 76 Then
            frm = New WinCG.PedidoVendasAprovacao2()
        End If
        ' 77 - devolução de pedidos de venda
        If ACE_MODULO = 77 Then
            frm = New WinCG.PedidoVendaDevolucao()
        End If
        ' 78 - devolução de pedidos de venda
        If ACE_MODULO = 78 Then
            frm = New WinCG.TransferenciaEmpresasAprovacao()
        End If

        frm.MdiParent = Me
        frm.Show()

    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        ChamaMenu(Modulo.Movimentacao_de_chip)
    End Sub

    Private Sub CargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem.Click
        ChamaMenu(Modulo.Cargos)
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        'Me.Close()
        Environment.Exit(0)
    End Sub

    Private Sub SairDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDoSistemaToolStripMenuItem.Click
        'Me.Close()
        Environment.Exit(0)
    End Sub

    Private Sub AlocaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlocaçãoToolStripMenuItem.Click
        ChamaMenu(Modulo.Alocacao)
    End Sub

    Private Sub OperadorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperadorasToolStripMenuItem.Click
        ChamaMenu(Modulo.Operadoras)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ChamaMenu(Modulo.Modulos)
    End Sub

    Private Sub SequenciaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SequenciaisToolStripMenuItem.Click
        ChamaMenu(Modulo.Sequenciais_de_chaves_das_tabelas)
    End Sub

    Private Sub StatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem.Click
        ChamaMenu(Modulo.Status)
    End Sub

    Private Sub StatusToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem1.Click
        ChamaMenu(Modulo.Status_de_os)
    End Sub

    Private Sub TipoDeEquipamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeEquipamentoToolStripMenuItem.Click
        ChamaMenu(Modulo.Tipo_de_equipamento)
    End Sub

    Private Sub TipoDeServiçoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeServiçoToolStripMenuItem.Click
        ChamaMenu(Modulo.Tipo_de_servico)
    End Sub

    Private Sub MotivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotivosToolStripMenuItem.Click
        ChamaMenu(Modulo.Motivo)
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        ChamaMenu(Modulo.Usuarios)
    End Sub

    Private Sub ChipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChipToolStripMenuItem.Click
        ChamaMenu(Modulo.Chip)
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        ChamaMenu(Modulo.Fornecedores)
    End Sub

    Private Sub LojaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LojaToolStripMenuItem.Click
        ChamaMenu(Modulo.Lojas)
    End Sub

    Private Sub PermissõesDeAcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermissõesDeAcessoToolStripMenuItem.Click
        ChamaMenu(Modulo.Permissoes_de_acesso)
    End Sub

    Private Sub ResponsáveisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResponsáveisToolStripMenuItem.Click
        ChamaMenu(Modulo.Responsaveis)
    End Sub

    Private Sub EquipamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipamentosToolStripMenuItem.Click
        ChamaMenu(Modulo.Equipamentos_pos)
    End Sub

    Private Sub EntradaDeChipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeChipToolStripMenuItem.Click
        ChamaMenu(Modulo.Entrada_de_chip)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        ChamaMenu(Modulo.Entrada_de_chip)
    End Sub

    Private Sub MovimentaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentaçãoToolStripMenuItem.Click
        ChamaMenu(Modulo.Movimentacao_de_chip)
    End Sub

    Private Sub RecebimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecebimentoToolStripMenuItem.Click
        ChamaMenu(Modulo.Recebimento_de_chip)
    End Sub

    Private Sub EntradaDeChipToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntradaDeChipToolStripMenuItem1.Click
        ChamaMenu(Modulo.Entrada_de_chip)
    End Sub

    Private Sub MovimentaçãoDeChipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentaçãoDeChipToolStripMenuItem.Click
        'ChamaMenu(Modulo.Movimentacao_de_chip)
        ChamaMenu(Modulo.Movimento_transito_chip)
    End Sub

    Private Sub RecebimentoDeChipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecebimentoDeChipToolStripMenuItem.Click
        ChamaMenu(Modulo.Baixa_transito_chip)
    End Sub

    Private Sub ConsultaEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaEstoqueToolStripMenuItem.Click
        ChamaMenu(Modulo.Consulta_estoque_chip)
    End Sub


    Private Sub LogTransaçõesChipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogTransaçõesChipToolStripMenuItem.Click
        ChamaMenu(Modulo.Log_transacoes_chip)
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        'Usuarios
        ChamaMenu(Modulo.Usuarios)
    End Sub

    Private Sub MódulosDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MódulosDoSistemaToolStripMenuItem.Click
        'Módulos
        ChamaMenu(Modulo.Modulos)
    End Sub

    Private Sub PermissõesDeAcessoToolStripMenuItem1_Click(sender As Object, e As EventArgs) 
        ChamaMenu(Modulo.Permissoes_de_acesso)
    End Sub

    Private Sub SequenciaisToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SequenciaisToolStripMenuItem1.Click
        'Chaves Sequenciais
        ChamaMenu(Modulo.Sequenciais_de_chaves_das_tabelas)
    End Sub

    Private Sub StatusToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem2.Click
        'Status
        ChamaMenu(Modulo.Status)
    End Sub

    Private Sub StatusOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusOSToolStripMenuItem.Click
        'Status OS
        ChamaMenu(Modulo.Status_de_os)
    End Sub

    Private Sub ResponsáveisToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResponsáveisToolStripMenuItem1.Click
        'Responsáveis
        ChamaMenu(Modulo.Responsaveis)
    End Sub

    Private Sub AlocaçãoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlocaçãoToolStripMenuItem1.Click
        'Alocação
        ChamaMenu(Modulo.Alocacao)

    End Sub

    Private Sub CargosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem1.Click
        'Cargos
        ChamaMenu(Modulo.Cargos)
    End Sub

    Private Sub TipoDeServiçoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeServiçoToolStripMenuItem1.Click
        'Tipo de Serviço
        ChamaMenu(Modulo.Tipo_de_servico)
    End Sub

    Private Sub TipoDeEquipamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeEquipamentoToolStripMenuItem1.Click
        'Tipo de Equipamento
        ChamaMenu(Modulo.Tipo_de_equipamento)
    End Sub

    Private Sub MotivosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MotivosToolStripMenuItem1.Click
        'Motivos
        ChamaMenu(Modulo.Motivo)
    End Sub

    Private Sub LojasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LojasToolStripMenuItem.Click
        'Lojas
        ChamaMenu(Modulo.Lojas)
    End Sub

    Private Sub FornecedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem1.Click
        'Fornecedores
        ChamaMenu(Modulo.Fornecedores)
    End Sub

    Private Sub OperadorasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OperadorasToolStripMenuItem1.Click
        'Operadoras
        ChamaMenu(Modulo.Operadoras)
    End Sub

    Private Sub ChipToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChipToolStripMenuItem1.Click
        'Chip
        ChamaMenu(Modulo.Chip)
    End Sub

    Private Sub EquipamentosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EquipamentosToolStripMenuItem1.Click
        'Equipamentos
        ChamaMenu(Modulo.Equipamentos_pos)
    End Sub

    Private Sub DevoluçãoPFornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Devolução de Chip p/Fornecedor
        ChamaMenu(Modulo.Devolucao_chip_para_fornecedor)
    End Sub

    Private Sub DevoluçãoParaFornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluçãoParaFornecedorToolStripMenuItem.Click
        'Devolução de Chip p/Fornecedor
        ChamaMenu(Modulo.Devolucao_chip_para_fornecedor)
    End Sub

    Private Sub EntradaDePOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDePOSToolStripMenuItem.Click
        'Entrada de Equipamento
        ChamaMenu(Modulo.Entrada_de_equipamentos)
    End Sub

    Private Sub EntradaDeEquipamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeEquipamentosToolStripMenuItem.Click
        'Entrada de Equipamento
        ChamaMenu(Modulo.Entrada_de_equipamentos)
    End Sub

    Private Sub MovimentaçãoDePOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentaçãoDePOSToolStripMenuItem.Click
        'Movimentação de Equipamento
        ChamaMenu(Modulo.Movimento_transito_equipamento)
    End Sub

    Private Sub MovimentaçãoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MovimentaçãoToolStripMenuItem1.Click
        'Movimentação de Equipamento
        ChamaMenu(Modulo.Movimento_transito_chip)
    End Sub

    Private Sub RecebimentoPOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecebimentoPOSToolStripMenuItem.Click
        'Recebimento de Equipamento
        ChamaMenu(Modulo.Baixa_transito_equipamento)
    End Sub

    Private Sub RecebimentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecebimentoToolStripMenuItem1.Click
        'Recebimento de Equipamento
        ChamaMenu(Modulo.Recebimento_de_equipamentos)
    End Sub

    Private Sub DevoluçãoPFornecedorToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'Recebimento de Equipamento
        ChamaMenu(Modulo.Devolucao_equipamentos_para_fornecedor)
    End Sub

    Private Sub DevoluçãoParaFornecedorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DevoluçãoParaFornecedorToolStripMenuItem1.Click
        ChamaMenu(Modulo.Devolucao_equipamentos_para_fornecedor)
    End Sub

    Private Sub LogTransaçõesPOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogTransaçõesPOSToolStripMenuItem.Click
        ChamaMenu(Modulo.Log_transacoes_pos)

    End Sub

    Private Sub ConsultaEstoquePOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaEstoquePOSToolStripMenuItem.Click
        ChamaMenu(Modulo.Consulta_estoque_pos)

    End Sub

    Private Sub CadastroDeOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroDeOSToolStripMenuItem1.Click
        ChamaMenu(Modulo.Cadastro_de_os)
    End Sub

    Private Sub CadastroDeOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeOSToolStripMenuItem.Click
        ChamaMenu(Modulo.Cadastro_de_os)
    End Sub

    Private Sub FollowUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FollowUpToolStripMenuItem.Click
        ChamaMenu(Modulo.Follow_up_de_os)
    End Sub

    Private Sub FollowUpDeOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FollowUpDeOSToolStripMenuItem.Click
        ChamaMenu(Modulo.Follow_up_de_os)
    End Sub

    Private Sub RetornoDeOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RetornoDeOSToolStripMenuItem1.Click
        ChamaMenu(Modulo.Retorno_de_os)
    End Sub

    Private Sub RetornoDeOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetornoDeOSToolStripMenuItem.Click
        ChamaMenu(Modulo.Retorno_de_os)
    End Sub

    Private Sub VincularCHIPComPOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VincularCHIPComPOSToolStripMenuItem.Click
        ChamaMenu(Modulo.Vincular_chip_com_pos)
    End Sub

    Private Sub CadastroDeChipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeChipToolStripMenuItem.Click
        'Importação de Chip para BASE SQL
        ChamaMenu(Modulo.Importar_cadastro_chip)

    End Sub

    Private Sub CadastroDeEquipamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeEquipamentosToolStripMenuItem.Click
        'Importação de Equipamento para BASE SQL
        ChamaMenu(Modulo.Importar_cadastro_equipamento)

    End Sub

    Private Sub EntradaDeChipNaMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeChipNaMatrizToolStripMenuItem.Click
        'Importação de planilha para Entrada de Chip na Matriz
        ChamaMenu(Modulo.Importar_entrada_chip)

    End Sub

    Private Sub EntradaDeEquipamentoNaMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeEquipamentoNaMatrizToolStripMenuItem.Click
        'Importação de planilha para Entrada de Equipamento na Matriz
        ChamaMenu(Modulo.Importar_entrada_equipamento)

    End Sub

    Private Sub ModelosDeDocumentosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModelosDeDocumentosToolStripMenuItem1.Click
        ChamaMenu(Modulo.Modelos)
    End Sub

    Private Sub ModelosDeDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelosDeDocumentosToolStripMenuItem.Click
        ChamaMenu(Modulo.Modelos)
    End Sub

    Private Sub EstoqueGeralPorLojaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstoqueGeralPorLojaToolStripMenuItem.Click
        ChamaMenu(Modulo.Relatorio_geral_estoque_chip)

    End Sub

    Private Sub EstoqueGeralPorLojaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstoqueGeralPorLojaToolStripMenuItem1.Click
        ChamaMenu(Modulo.Relatorio_geral_estoque_equipamento)
    End Sub

    Private Sub POSXChipToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ChamaMenu(Modulo.Relatorio_POS_x_Chip)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frm As Object
        frm = New WinCG.TrocaSenha
        'frm.MdiParent = Me
        frm.ShowDialog()
    End Sub

    Private Sub CadastroDeLojasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeLojasToolStripMenuItem.Click
        ChamaMenu(Modulo.Importar_cadastro_loja)
    End Sub

    Private Sub MovimentarParaInativoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ChamaMenu(Modulo.Movimentar_chip_inativo)
    End Sub

    Private Sub MovimentarParaInativoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ChamaMenu(Modulo.Movimentar_equipamento_inativo)
    End Sub

    Private Sub CadastroDeMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeMarcasToolStripMenuItem.Click
        ChamaMenu(Modulo.Marcas)
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        ChamaMenu(Modulo.Categorias)
    End Sub

    Private Sub FinalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalidadesToolStripMenuItem.Click
        ChamaMenu(Modulo.Finalidades)
    End Sub

    Private Sub PeçasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeçasToolStripMenuItem.Click
        ChamaMenu(Modulo.Pecas)
    End Sub

    Private Sub PedidoDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoDeCompraToolStripMenuItem.Click
        ChamaMenu(Modulo.Pedido_compras_peca)
    End Sub

    Private Sub BaixaDePedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaixaDePedidoToolStripMenuItem.Click
        ChamaMenu(Modulo.Baixa_pedido_compra_peca)
    End Sub

    Private Sub ParametrizaçãoDePesquisasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametrizaçãoDePesquisasToolStripMenuItem.Click
        ChamaMenu(Modulo.Parametrizacao_Pesquisa)
    End Sub

    Private Sub CadastroDeTabelasViewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeTabelasViewsToolStripMenuItem.Click
        ChamaMenu(Modulo.CadTabelasViews)
    End Sub

    Private Sub ÁreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreasToolStripMenuItem.Click
        ChamaMenu(Modulo.CadArea)
    End Sub

    Private Sub OcorrênciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OcorrênciasToolStripMenuItem.Click
        ChamaMenu(Modulo.Ocorrencia)
    End Sub

    Private Sub MovimentarParaQuarentenaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ChamaMenu(Modulo.Quarentena)
    End Sub

    Private Sub TransitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransitoToolStripMenuItem.Click
        ChamaMenu(Modulo.Transito)
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click
        ChamaMenu(Modulo.Empresa)
    End Sub

    Private Sub PerfilDeAcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilDeAcessoToolStripMenuItem.Click
        ChamaMenu(Modulo.Perfil)
    End Sub

    Private Sub EntradaDeEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeEstoqueToolStripMenuItem.Click
        'Menu unificado - entrada de estoque
        ChamaMenu(Modulo.Entrada_estoque)
    End Sub

    Private Sub GerarTransitoEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerarTransitoEstoqueToolStripMenuItem.Click
        'Menu unificado - gerar transito
        ChamaMenu(Modulo.Gerar_transito_estoque)
    End Sub

    Private Sub BaixarTransitoEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaixarTransitoEstoqueToolStripMenuItem.Click
        'Menu unificado - baixar transito
        ChamaMenu(Modulo.Baixar_transito_estoque)
    End Sub

    Private Sub ConsultarTransitoEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarTransitoEstoqueToolStripMenuItem.Click
        'Menu unificado - consultar log de transito
        ChamaMenu(Modulo.Consulta_transito_estoque_unificado)
    End Sub

    Private Sub ConsultaDeEstoqueGeralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeEstoqueGeralToolStripMenuItem.Click
        'Menu unificado - consulta geral de estoque
        ChamaMenu(Modulo.Consulta_geral_estoque_unificado)
    End Sub

    Private Sub TransferênciaDeEstoqueEntreEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferênciaDeEstoqueEntreEmpresasToolStripMenuItem.Click
        'Menu unificado - transferencia de estoque entre empresas
        ChamaMenu(Modulo.Transferencia_entre_empresas)
    End Sub

    Private Sub TransferênciaDeCadastrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferênciaDeCadastrosToolStripMenuItem.Click
        ChamaMenu(Modulo.Transferencia_cadastros)
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim frmTrocar = New AlternarEmpresaLogin
        frmTrocar.ShowDialog()
    End Sub

    Private Sub Principal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Refresh no label que indica em que empresa o usuário esta Logado.
        'Este valor pode ser mudado se utilizado a tela para alternar entre empresas
        'Atualiza a classe de objeto Publico com os dados do login e da empresa
        lblEmpresaLogada.Text = "Empresa Login: " & Publico.Id_empresa & " - " & Publico.Nome_empresa
    End Sub

    Private Sub ItensDeConcertoReparoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItensDeConcertoReparoToolStripMenuItem.Click
        ChamaMenu(Modulo.Concerto)
    End Sub

    Private Sub TabelaDeServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabelaDeServiçosToolStripMenuItem.Click
        ChamaMenu(Modulo.TabelaPrecos)
    End Sub

    Private Sub MovimentaçãoDoEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentaçãoDoEstoqueToolStripMenuItem.Click
        ChamaMenu(Modulo.MovEstoque)
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        ChamaMenu(Modulo.Clientes)
    End Sub

    Private Sub PedidoDeVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoDeVendaToolStripMenuItem.Click
        ChamaMenu(Modulo.PedidoVenda)
    End Sub

    Private Sub RelatóriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosToolStripMenuItem.Click
        Dim frm As Object = Nothing
        frm = New WinCG.FrTest1
        'frm.MdiParent = Me
        frm.ShowDialog()
    End Sub

    Private Sub AprovaçãoDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AprovaçãoDePedidosToolStripMenuItem.Click
        ChamaMenu(Modulo.AprovacaoPedidoVenda)
    End Sub

    Private Sub DevoluçãoDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluçãoDePedidosToolStripMenuItem.Click
        ChamaMenu(Modulo.DevolucaoPedidoVenda)
    End Sub

    Private Sub AprovaçãoDeTransferênciaEntreEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AprovaçãoDeTransferênciaEntreEmpresasToolStripMenuItem.Click
        ChamaMenu(Modulo.AprovacaoTransferencia)
    End Sub
End Class
