Imports FastReport.Data
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Enum ReportOption

    Alocacao = 0
    Areas = 1
    Cargos = 2
    Categorias = 3
    Chip = 4
    Clientes = 5
    Equipamentos = 6
    Finalidade = 7
    Fornecedores = 8
    Conserto = 9
    Lojas = 10
    Marcas = 11
    Modulos = 12
    Motivos = 13
    Operadoras = 14
    Pecas = 15
    Responsaveis = 16
    Sequenciais = 17
    Status = 18
    StatusOS = 19
    TabelasViews = 20
    TipoEquipamento = 21
    TipoServico = 22
    Transito = 23
    Usuarios = 24
    EmpresasVsPerfil = 25
    ParametrizacaoPesquisas = 26
    Perfil = 27
    TransitoEstoque = 28
    EstoqueChip = 29
    EstoqueEquipamentos = 30
    EstoquePontoVenda = 31
    OS = 32
    REtornoOS = 33
    FollowUP = 34
    Ocorrencias = 35
    TabelaServicos = 36

End Enum
Public Class FrTest1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '//rotina para chamar o relatorio com os parametros associados
        escolhe()
    End Sub

    Private Sub escolhe()
        Try

            '//Dim vnome As String
            Dim dsRelatorio As DataSet
            '//vnome = TvReport.SelectedNode.Index.ToString & " - " & TvReport.SelectedNode.Text.ToString
            Dim vTag As Integer = CInt(TvReport.SelectedNode.Tag)

            'MessageBox.Show(vTag.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Exit Sub
            Select Case vTag '//TvReport.SelectedNode.Index
                Case ReportOption.Alocacao '// Alocação
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(ReportOption.Alocacao), "CG_ALOCACAO")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frAlocacoes.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                Case ReportOption.Areas '// Areas
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(ReportOption.Areas), "V_AREA")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frAreas.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")

                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")
                Case ReportOption.Cargos
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(ReportOption.Cargos), "CG_CARGO")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frCargos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                Case ReportOption.Categorias
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(ReportOption.Categorias), "CG_CATEGORIA")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frCategorias.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                Case ReportOption.Chip
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(ReportOption.Chip), "V_CHIP")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frChips.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")

                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")
                Case ReportOption.Clientes
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(ReportOption.Clientes), "VW_CG_CLIENTE")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frClientes.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")
                Case ReportOption.Equipamentos
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(ReportOption.Equipamentos), "V_EQUIPAMENTO")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frEquipamentos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")
                Case ReportOption.Finalidade
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(ReportOption.Finalidade), "CG_FINALIDADE")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frFinalidades.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")
                Case ReportOption.Fornecedores
                    '// Cria dataset para substituir dentro do relatorio salvo
                    'dsRelatorio = CriaDataSet(QueryRelatorio(8), "V_FORNECEDORES")

                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frFornecedores.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_FORNECEDORES")
                    table.SelectCommand = QueryRelatorio(ReportOption.Fornecedores)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")

                Case ReportOption.Conserto
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frConsertos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("CG_CONCERTO")
                    table.SelectCommand = QueryRelatorio(ReportOption.Conserto)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Lojas

                Case ReportOption.Marcas
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frMarcas.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_MARCA")
                    table.SelectCommand = QueryRelatorio(ReportOption.Marcas)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Modulos
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frModulos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_MODULO")
                    table.SelectCommand = QueryRelatorio(ReportOption.Modulos)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Motivos
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frMotivos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_MOTIVO")
                    table.SelectCommand = QueryRelatorio(ReportOption.Motivos)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Operadoras
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frOperadoras.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_OPERADORA")
                    table.SelectCommand = QueryRelatorio(ReportOption.Operadoras)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Pecas
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frPecas.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_PECA")
                    table.SelectCommand = QueryRelatorio(ReportOption.Pecas)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Responsaveis
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frResponsaveis.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_RESPONSAVEL")
                    table.SelectCommand = QueryRelatorio(ReportOption.Responsaveis)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Sequenciais
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frSequenciais.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_SEQUENCIAL")
                    table.SelectCommand = QueryRelatorio(ReportOption.Sequenciais)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Status
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frStatus.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_STATUS")
                    table.SelectCommand = QueryRelatorio(ReportOption.Status)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.StatusOS
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frStatusOS.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_STATUS_OS")
                    table.SelectCommand = QueryRelatorio(ReportOption.StatusOS)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.TabelasViews
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frTabelasViews.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_TABELA_VIEW")
                    table.SelectCommand = QueryRelatorio(ReportOption.TabelasViews)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.TipoEquipamento
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frTipoEquipamentos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_TIPO_EQUIPAMENTO")
                    table.SelectCommand = QueryRelatorio(ReportOption.TipoEquipamento)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.TipoServico
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frTipoServicos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_TIPO_SERVICO")
                    table.SelectCommand = QueryRelatorio(ReportOption.TipoServico)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Transito
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frTransitos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_TRANSITO")
                    table.SelectCommand = QueryRelatorio(ReportOption.Transito)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Usuarios
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frUsuarios.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_USUARIO")
                    table.SelectCommand = QueryRelatorio(ReportOption.Usuarios)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                Case ReportOption.EmpresasVsPerfil '// 25
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frEmpresaVsPerfil.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_EMPRESA_PERFIL")
                    table.SelectCommand = QueryRelatorio(ReportOption.EmpresasVsPerfil)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.ParametrizacaoPesquisas '//  26
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frParameterQuerys.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_PARAMETER_QUERY")
                    table.SelectCommand = QueryRelatorio(ReportOption.ParametrizacaoPesquisas)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.Perfil '//  27
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frPefisAcesso.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_PERFIL")
                    table.SelectCommand = QueryRelatorio(ReportOption.Perfil)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.TransitoEstoque '//  28

                Case ReportOption.EstoqueChip '//  29

                Case ReportOption.EstoqueEquipamentos '//  30

                Case ReportOption.EstoquePontoVenda '//  31

                Case ReportOption.OS '//  32
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frOS_Pai_filha.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    'Dim table As TableDataSource
                    'table = Report1.GetDataSource("V_PERFIL")
                    'table.SelectCommand = QueryRelatorio(ReportOption.Perfil)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                    If Not String.IsNullOrEmpty(PesqFK4.txtId.Text) Then
                        Report1.SetParameterValue("OS_ID", CInt(PesqFK4.txtId.Text))
                    Else
                        'Report1.SetParameterValue("OS_ID", "[VW_CG_OS.ID_OS]")
                        Report1.SetParameterValue("OS_ID", 0)
                    End If

                Case ReportOption.REtornoOS '//  33

                Case ReportOption.FollowUP '// 34

                Case ReportOption.Ocorrencias '//  35
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frOcorrencias.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_OCORRENCIA")
                    table.SelectCommand = QueryRelatorio(ReportOption.Ocorrencias)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case ReportOption.TabelaServicos '//  36

                Case Else

            End Select

            If TvReport.SelectedNode.Index >= 0 Then
                Report1.Prepare()
                Report1.Show()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function CriaDataSet(sql As String, tabela_nome As String) As DataSet
        '// define a string de conexão com o banco de dados
        Dim strConn As String = StringConexao()
        '// define o objeto OledbConnection usando a string de conexão
        Dim _providerName = "System.Data.SqlClient"
        Dim conn As New SqlConnection
        conn.ConnectionString = strConn

        'Cria o DataAdapter
        Dim adaptador As New SqlDataAdapter(sql, conn)
        'Cria o DataSet
        Dim dsBD As New DataSet()
        adaptador.Fill(dsBD, tabela_nome)
        Return dsBD

    End Function

    Function StringConexao()

        Dim strconn As String = String.Empty
        If Environment.UserDomainName = "WIN-6D553OEIVVL" Then
            'strconn = "Server=VMWIN7;Database=dbCG;Trusted_Connection=True;"
            '// Conexao maquina de Desenvolvimento
            strconn = "Data Source=.\SQL2017DEV;Initial Catalog=dbCG;Persist Security Info=True;User ID=USER_CG;Password=c102030@"
        Else
            '// Conexao no Sergio
            'strconn = "Server=LISBOA;Database=dbCG;Trusted_Connection=True;"
            strconn = "Data Source=(local);Initial Catalog=dbCG;Persist Security Info=True;User ID=USER_CG;Password=c102030@"
        End If
        Return strconn
    End Function

    Private Function QueryRelatorio(idRelatorio As Integer) As String
        Dim sql As String = ""
        Select Case idRelatorio
            Case ReportOption.Alocacao
                sql = "select ID_ALOCACAO,DESC_ALOCACAO from CG_ALOCACAO order by 1"


            Case ReportOption.Areas
                sql = "select A.ID_AREA, DESC_AREA, A.ID_RESPONSAVEL, B.NOME, B.APELIDO, A.ID_EMPRESA , C.NOME_EMPRESA "
                sql = sql & " from CG_AREA A "
                sql = sql & " INNER JOIN CG_RESPONSAVEL B "
                sql = sql & "	ON B.ID_RESPONSAVEL = A.ID_RESPONSAVEL "
                sql = sql & " INNER JOIN CG_EMPRESA C "
                sql = sql & "	ON C.ID_EMPRESA = A.ID_EMPRESA "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.Areas)
                sql = sql & " ORDER BY ID_EMPRESA, ID_AREA "
            Case ReportOption.Cargos
                sql = "select ID_CARGO,DESC_CARGO from CG_CARGO order by 1"
            Case ReportOption.Categorias
                sql = "select * from CG_CATEGORIA ORDER BY ID_CATEGORIA"
            Case ReportOption.Chip
                sql = " SELECT CG_CHIP.ID_CHIP, "
                sql = sql & "        CG_CHIP.SIMID, "
                sql = sql & "        CG_CHIP.ID_OPERADORA, "
                sql = sql & "        CG_OPERADORA.DESC_OPERADORA, "
                sql = sql & "        CG_CHIP.ID_FORNECEDOR, "
                sql = sql & " 	  CG_CHIP.CUSTO, "
                sql = sql & "        CG_FORNECEDOR.NOME, "
                sql = sql & "        CG_FORNECEDOR.SIGLA, "
                sql = sql & "        CG_FORNECEDOR.UTILIZA_NFTS, "
                sql = sql & " 	  CG_CHIP.ID_LOCAL_ESTOQUE, "
                sql = sql & " 	  CG_CHIP.TIPO_LOCAL, "
                sql = sql & " 	  CG_CHIP.ID_EMPRESA "
                sql = sql & " FROM "
                sql = sql & " 	CG_CHIP (NOLOCK) "
                sql = sql & " LEFT JOIN "
                sql = sql & " 	CG_OPERADORA (NOLOCK) "
                sql = sql & " 		ON CG_CHIP.ID_OPERADORA = CG_OPERADORA.ID_OPERADORA "
                sql = sql & " LEFT JOIN "
                sql = sql & " 	CG_FORNECEDOR (NOLOCK) "
                sql = sql & " 		ON CG_CHIP.ID_FORNECEDOR = CG_FORNECEDOR.ID_FORNECEDOR "
                sql = sql & " LEFT JOIN "
                sql = sql & " 	CG_EMPRESA (NOLOCK) "
                sql = sql & " 		ON CG_CHIP.ID_EMPRESA = CG_EMPRESA.ID_EMPRESA "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.Chip)
                sql = sql & " ORDER BY CG_CHIP.ID_EMPRESA, CG_CHIP.SIMID "
            Case ReportOption.Clientes
                sql = " select [ID_CLIENTE], [SIGLA], [NOME], [CEP], [ENDERECO], [COMPLEMENTO], [CIDADE], [BAIRRO], [UF], "
                sql = sql & " [EMAIL], [TELEFONE1], [CONTATO1], [TELEFONE2], [CONTATO2], [TELEFONE3], [CONTATO3], [TELEFONE4], "
                sql = sql & " [CONTATO4], [OBS], [CADASTRO], [ULTIMA_ATUALIZACAO], [ID_EMPRESA], [PFPJ], [CPF_CNPJ], [RG_IE], "
                sql = sql & " [NOME_EMPRESA], [SIGLA_EMPRESA] "
                sql = sql & " from VW_cg_cliente "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.Clientes)
                sql = sql & " ORDER BY ID_EMPRESA, NOME "
            Case ReportOption.Equipamentos
                sql = " SELECT        VW_CG_EQUIPAMENTO.ID_EQUIPAMENTO, VW_CG_EQUIPAMENTO.DESC_EQUIPAMENTO, VW_CG_EQUIPAMENTO.SERIE, VW_CG_EQUIPAMENTO.MODELO, VW_CG_EQUIPAMENTO.ID_TIPO_EQUIPAMENTO, "
                sql = sql & "                          VW_CG_EQUIPAMENTO.DESC_TIPO_EQUIPAMENTO, VW_CG_EQUIPAMENTO.ID_FORNECEDOR, VW_CG_EQUIPAMENTO.SIGLA, VW_CG_EQUIPAMENTO.VALOR, VW_CG_EQUIPAMENTO.OBS, "
                sql = sql & "                          VW_CG_EQUIPAMENTO.NF_ENTRADA, VW_CG_EQUIPAMENTO.DATA_NF, VW_CG_EQUIPAMENTO.PRAZO_GARANTIA, VW_CG_EQUIPAMENTO.DATA_INICIO_GARANTIA, "
                sql = sql & "                          VW_CG_EQUIPAMENTO.DATA_TERMINO_GARANTIA, VW_CG_EQUIPAMENTO.ID_EMPRESA, CG_EMPRESA.NOME_EMPRESA "
                sql = sql & " FROM            VW_CG_EQUIPAMENTO INNER JOIN "
                sql = sql & "                          CG_EMPRESA AS b ON b.ID_EMPRESA = VW_CG_EQUIPAMENTO.ID_EMPRESA INNER JOIN "
                sql = sql & "                          CG_EMPRESA ON VW_CG_EQUIPAMENTO.ID_EMPRESA = CG_EMPRESA.ID_EMPRESA "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.Equipamentos)
                sql = sql & " ORDER BY VW_CG_EQUIPAMENTO.ID_TIPO_EQUIPAMENTO, VW_CG_EQUIPAMENTO.ID_EMPRESA, VW_CG_EQUIPAMENTO.SERIE "
            Case ReportOption.Finalidade
                sql = "select * from CG_FINALIDADE ORDER BY ID_FINALIDADE"
            Case ReportOption.Fornecedores
                sql = " SELECT cg_fornecedor.id_fornecedor, "
                sql = sql & "        cg_fornecedor.sigla, "
                sql = sql & "        cg_fornecedor.nome, "
                sql = sql & "        cg_fornecedor.cep, "
                sql = sql & "        cg_fornecedor.endereco, "
                sql = sql & "        cg_fornecedor.complemento, "
                sql = sql & "        cg_fornecedor.cidade, "
                sql = sql & "        cg_fornecedor.bairro, "
                sql = sql & "        cg_fornecedor.uf, "
                sql = sql & "        cg_fornecedor.email, "
                sql = sql & "        cg_fornecedor.telefone, "
                sql = sql & "        cg_fornecedor.contato, "
                sql = sql & "        cg_fornecedor.whatsapp, "
                sql = sql & "        cg_fornecedor.id_tipo_servico, "
                sql = sql & "        cg_tipo_servico.desc_tipo_servico, "
                sql = sql & "        cg_fornecedor.obs, "
                sql = sql & "        cg_fornecedor.garantia_aquisicao, "
                sql = sql & "        cg_fornecedor.garantia_assistencia, "
                sql = sql & "        cg_fornecedor.id_empresa, "
                sql = sql & "        cg_empresa.nome_empresa "
                sql = sql & " FROM   cg_fornecedor "
                sql = sql & "        INNER JOIN cg_empresa "
                sql = sql & "                ON cg_fornecedor.id_empresa = cg_empresa.id_empresa "
                sql = sql & "        INNER JOIN cg_tipo_servico "
                sql = sql & "                ON cg_fornecedor.id_tipo_servico = cg_tipo_servico.id_tipo_servico "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.Fornecedores)
                sql = sql & " ORDER BY cg_fornecedor.id_empresa, cg_fornecedor.sigla "
            Case ReportOption.Conserto
                sql = "select * from CG_CONCERTO ORDER BY DESC_CONCERTO"
            Case ReportOption.Lojas '//lojas

            Case ReportOption.Marcas '//marcas
                sql = "select ID_MARCA, DESC_MARCA, CG_MARCA.ID_EMPRESA, CG_EMPRESA.NOME_EMPRESA "
                sql = sql & " from cg_marca "
                sql = sql & " INNER JOIN CG_EMPRESA ON CG_EMPRESA.ID_EMPRESA=CG_MARCA.ID_EMPRESA "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.Marcas)
                sql = sql & " ORDER BY  CG_MARCA.ID_EMPRESA, DESC_MARCA "

            Case ReportOption.Modulos '//modulos
                sql = "select ID_MODULO,DESC_MODULO,INATIVO from cg_modulo "
                sql = sql & " ORDER BY ID_MODULO "

            Case ReportOption.Motivos '//motivos
                sql = "select ID_MOTIVO, DESC_MOTIVO from cg_motivo "
                sql = sql & " ORDER BY DESC_MOTIVO "

            Case ReportOption.Operadoras '//operadoras
                sql = "select ID_OPERADORA, DESC_OPERADORA from CG_OPERADORA "
                sql = sql & " ORDER BY DESC_OPERADORA "

            Case ReportOption.Pecas
                sql = " SELECT [id_peca], "
                sql = sql & "        [nome_peca], "
                sql = sql & "        [descricao], "
                sql = sql & "        [id_marca], "
                sql = sql & "        [desc_marca], "
                sql = sql & "        [id_categoria], "
                sql = sql & "        [desc_categoria], "
                sql = sql & "        [id_fornecedor], "
                sql = sql & "        [sigla], "
                sql = sql & "        [nome], "
                sql = sql & "        [id_finalidade], "
                sql = sql & "        [desc_finalidade], "
                sql = sql & "        [estoque], "
                sql = sql & "        [estoque_min], "
                sql = sql & "        [estoque_max], "
                sql = sql & "        [unidade], "
                sql = sql & "        [data_aquisicao], "
                sql = sql & "        [dias_garantia], "
                sql = sql & "        [custo], "
                sql = sql & "        [ref_fornec], "
                sql = sql & "        [obs], "
                sql = sql & "        [user_ins], "
                sql = sql & "        [data_ins], "
                sql = sql & "        [user_upd], "
                sql = sql & "        [data_upd], "
                sql = sql & "        [id_controle], "
                sql = sql & "        [serie], "
                sql = sql & "        [modelo] "
                sql = sql & " FROM   vw_cg_peca "
                sql = sql & " ORDER BY [nome_peca] "

            Case ReportOption.Responsaveis
                sql = " select ID_RESPONSAVEL, a.NOME, a.APELIDO, A.EMAIL, CELULAR, WHATSAPP, DESC_CARGO, A.ID_EMPRESA, B.NOME_EMPRESA "
                sql = sql & " from VW_CG_RESPONSAVEL A "
                sql = sql & " INNER JOIN CG_EMPRESA B ON B.ID_EMPRESA=A.ID_EMPRESA "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.Responsaveis)
                sql = sql & " ORDER BY A.ID_EMPRESA, A.apelido "

            Case ReportOption.Sequenciais
                sql = "select TABELA, KEYID from CG_SEQUENCIAL ORDER BY TABELA"

            Case ReportOption.Status
                sql = "select ID_STATUS, DESC_STATUS from CG_STATUS ORDER BY ID_STATUS"

            Case ReportOption.StatusOS
                sql = "select ID_STATUS, DESC_STATUS from CG_STATUS_OS ORDER BY ID_STATUS"

            Case ReportOption.TabelasViews
                sql = " SELECT	ID_TABELA, "
                sql = sql & " 		TABELA, "
                sql = sql & " 		CASE TIPO_TABELA WHEN 'T' THEN 'TABELA' ELSE 'EXIBIÇÃO' END AS TIPO_TABELA, "
                sql = sql & " 		FILTRA_POR_EMPRESA "
                sql = sql & " FROM CG_TABELAS_PESQUISA_DINAMICA "
                sql = sql & " ORDER BY TABELA "

            Case ReportOption.TipoEquipamento
                sql = " SELECT ID_TIPO_EQUIPAMENTO, DESC_TIPO_EQUIPAMENTO "
                sql = sql & " FROM CG_TIPO_EQUIPAMENTO "
                sql = sql & " ORDER BY DESC_TIPO_EQUIPAMENTO "

            Case ReportOption.TipoServico
                sql = "SELECT ID_TIPO_SERVICO, DESC_TIPO_SERVICO FROM CG_TIPO_SERVICO ORDER BY DESC_TIPO_SERVICO"

            Case ReportOption.Transito
                sql = "SELECT ID_TRANSITO, NOME_TRANSITO, INATIVO, CONTROLE_INTERNO FROM CG_TRANSITO ORDER BY NOME_TRANSITO"

            Case ReportOption.Usuarios
                sql = " select  ID_USUARIO, "
                sql = sql & " 		APELIDO, "
                sql = sql & " 		NOME, "
                sql = sql & " 		CPF, "
                sql = sql & " 		RG, "
                sql = sql & " 		EMAIL, "
                sql = sql & " 		TELEFONE, "
                sql = sql & " 		WHATSAPP, "
                sql = sql & " 		LOGIN, "
                sql = sql & " 		B.DESC_STATUS "
                sql = sql & " from CG_USUARIO A "
                sql = sql & " inner join CG_STATUS B on B.ID_STATUS = A.ID_STATUS "
                sql = sql & " ORDER BY APELIDO "

            Case ReportOption.EmpresasVsPerfil '// 25
                sql = " SELECT A.ID_EMPRESA, "
                sql = sql & "        A.ID_USUARIO, "
                sql = sql & "        A.ID_PERFIL, "
                sql = sql & "        B.NOME_EMPRESA, "
                sql = sql & "        B.SIGLA_EMPRESA, "
                sql = sql & "        C.APELIDO, "
                sql = sql & "        C.NOME, "
                sql = sql & "        D.DESC_PERFIL "
                sql = sql & " FROM   dbo.CG_EMPRESA_VS_USUARIOS AS A "
                sql = sql & "        INNER JOIN dbo.CG_EMPRESA AS B "
                sql = sql & "                ON B.ID_EMPRESA = A.ID_EMPRESA "
                sql = sql & "        INNER JOIN dbo.CG_USUARIO AS C "
                sql = sql & "                ON C.ID_USUARIO = A.ID_USUARIO "
                sql = sql & "        INNER JOIN dbo.CG_PERFIL AS D "
                sql = sql & "                ON D.ID_PERFIL = A.ID_PERFIL "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.EmpresasVsPerfil)
                sql = sql & " ORDER BY A.ID_EMPRESA, C.APELIDO "

            Case ReportOption.ParametrizacaoPesquisas '//  26
                sql = " SELECT A.TABELA "
                sql = sql & " 	  ,CASE B.TIPO_TABELA WHEN 'T' THEN 'TABELA' ELSE 'EXIBIÇÃO' END AS TABELA_VIEW "
                sql = sql & " 	  ,CASE B.FILTRA_POR_EMPRESA WHEN 1 THEN 'Sim' ELSE 'Não' END AS FILTRA_POR_EMPRESA "
                sql = sql & "       ,COLUNA "
                sql = sql & "       ,IDCOLUNA "
                sql = sql & "       ,ORDERCOL "
                sql = sql & "       ,CHAVE "
                sql = sql & "       ,TIPODADO "
                sql = sql & "       ,COLUNA_FILTRO "
                sql = sql & "       ,APELIDO_COLUNA "
                sql = sql & "       ,MOSTRA_COLUNA "
                sql = sql & "       ,MOSTRA_COLUNA "
                sql = sql & "       ,COLUNA_FILTRO_INICIAL "
                sql = sql & "   FROM CG_PARAMETRO_PESQUISA_DINAMICA A "
                sql = sql & "   INNER JOIN CG_TABELAS_PESQUISA_DINAMICA B  "
                sql = sql & " 		ON B.TABELA = A.TABELA "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.ParametrizacaoPesquisas)
                sql = sql & "   ORDER BY A.TABELA, IDCOLUNA "

            Case ReportOption.Perfil '//  27
                sql = " SELECT	A.ID_PERFIL, "
                sql = sql & " 		A.DESC_PERFIL, "
                sql = sql & " 		B.ID_MODULO, "
                sql = sql & " 		C.DESC_MODULO, "
                sql = sql & " 		B.PESQUISAR, "
                sql = sql & " 		B.INCLUIR, "
                sql = sql & " 		B.ALTERAR, "
                sql = sql & " 		B.EXCLUIR "
                sql = sql & " FROM CG_PERFIL A "
                sql = sql & " INNER JOIN CG_PERFIL_MODULO B "
                sql = sql & " 	ON B.ID_PERFIL = A.ID_PERFIL "
                sql = sql & " INNER JOIN CG_MODULO C "
                sql = sql & " 	ON C.ID_MODULO = B.ID_MODULO "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.Perfil)
                sql = sql & " ORDER BY A.ID_PERFIL, B.ID_MODULO "

            Case ReportOption.TransitoEstoque '//  28

            Case ReportOption.EstoqueChip '//  29

            Case ReportOption.EstoqueEquipamentos '//  30

            Case ReportOption.EstoquePontoVenda '//  31

            Case ReportOption.OS '//  32

            Case ReportOption.REtornoOS '//  33

            Case ReportOption.FollowUP '// 34

            Case ReportOption.Ocorrencias '//  35
                sql = " SELECT id_ocorrencia, "
                sql = sql & "        data_ocorrencia, "
                sql = sql & "        descricao, "
                sql = sql & "        id_equipamento, "
                sql = sql & "        desc_equipamento, "
                sql = sql & "        modelo, "
                sql = sql & "        serie, "
                sql = sql & "        id_loja, "
                sql = sql & "        codigo, "
                sql = sql & "        nome, "
                sql = sql & "        historico, "
                sql = sql & "        user_ins, "
                sql = sql & "        data_ins, "
                sql = sql & "        user_upd, "
                sql = sql & "        data_upd, "
                sql = sql & "        os_vinculada, "
                sql = sql & " 	   CAST(REPLACE(SUBSTRING(OS_VINCULADA,1,CHARINDEX('|',OS_VINCULADA,1)),'|','') AS INT) AS OS_ID "
                sql = sql & " FROM   vw_cg_ocorrencia "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(ReportOption.Ocorrencias)
                sql = sql & " ORDER  BY OS_ID "

            Case ReportOption.TabelaServicos '//  36


        End Select
        Return sql
    End Function

    Private Function TextoFiltro(intOpcao As Integer) As String
        Dim retorno As String = ""
        If intOpcao = ReportOption.Areas Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND  A.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = ReportOption.Chip Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND  CG_CHIP.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = ReportOption.Clientes Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND  VW_cg_cliente.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = ReportOption.Equipamentos Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND VW_CG_EQUIPAMENTO.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = ReportOption.Fornecedores Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND cg_fornecedor.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = ReportOption.Marcas Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND CG_MARCA.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = ReportOption.Responsaveis Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND  A.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = ReportOption.EmpresasVsPerfil Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND  A.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = ReportOption.ParametrizacaoPesquisas Then
            If Not String.IsNullOrEmpty(PesqFK2.txtDesc.Text) Then
                retorno = retorno & " AND  A.TABELA = '" & Trim(PesqFK2.txtDesc.Text) & "' "
            End If
        End If
        If intOpcao = ReportOption.Perfil Then
            If Not String.IsNullOrEmpty(PesqFK3.txtId.Text) Then
                retorno = retorno & " AND  A.ID_PERFIL = " & PesqFK3.txtId.Text
            End If
        End If
        If intOpcao = ReportOption.Ocorrencias Then
            If Not String.IsNullOrEmpty(PesqFK4.txtId.Text) Then
                retorno = retorno & " AND CAST(REPLACE(SUBSTRING(OS_VINCULADA,1,CHARINDEX('|',OS_VINCULADA,1)),'|','') AS INT) = " & PesqFK4.txtId.Text
            End If
        End If

        Return retorno
    End Function

    Private Sub PesqFK1_Load(sender As Object, e As EventArgs) Handles PesqFK1.Load
        With Me.PesqFK1
            .LabelPesqFK = "Empresa"
            .Tabela = "CG_EMPRESA"
            .View = "CG_EMPRESA"
            .CampoId = "ID_EMPRESA"
            .CampoDesc = "NOME_EMPRESA"
            .ListaCampos = "ID_EMPRESA, NOME_EMPRESA"
            .ColunasFiltro = "ID_EMPRESA,NOME_EMPRESA"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Empresas"
            '.FiltroSQL = " where id_empresa = " & Publico.Id_empresa
            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False
        End With

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PesqFK1.txtId.Text = ""
        Me.PesqFK1.txtDesc.Text = ""
        Me.PesqFK2.txtId.Text = ""
        Me.PesqFK2.txtDesc.Text = ""
        Me.PesqFK3.txtId.Text = ""
        Me.PesqFK3.txtDesc.Text = ""
        Me.PesqFK4.txtId.Text = ""
        Me.PesqFK4.txtDesc.Text = ""
    End Sub

    Private Sub TvReport_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TvReport.AfterSelect
        '// Habilita /Desabilita o filtro empresa
        Select Case CInt(e.Node.Tag)
            Case ReportOption.Areas, ReportOption.Chip, ReportOption.Clientes, ReportOption.Equipamentos, ReportOption.Fornecedores,
                 ReportOption.Marcas, ReportOption.Responsaveis, ReportOption.EmpresasVsPerfil
                Me.PesqFK1.Visible = True
            Case ReportOption.ParametrizacaoPesquisas
                Me.PesqFK2.Visible = True
            Case ReportOption.Perfil
                Me.PesqFK3.Visible = True
            Case ReportOption.Ocorrencias, ReportOption.OS
                Me.PesqFK4.Visible = True

            Case Else
                Me.PesqFK1.Visible = False
                Me.PesqFK2.Visible = False
                Me.PesqFK3.Visible = False
                Me.PesqFK4.Visible = False



        End Select

    End Sub

    Private Sub PesqFK2_Load(sender As Object, e As EventArgs) Handles PesqFK2.Load
        With Me.PesqFK2
            .LabelPesqFK = "Tabela"
            .Tabela = "CG_TABELAS_PESQUISA_DINAMICA"
            .View = "CG_TABELAS_PESQUISA_DINAMICA"
            .CampoId = "ID_TABELA"
            .CampoDesc = "TABELA"
            .ListaCampos = "ID_TABELA, TABELA"
            .ColunasFiltro = "TABELA"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Tabelas do Sistema"
            '.FiltroSQL = " where id_empresa = " & Publico.Id_empresa
            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False
        End With
    End Sub

    Private Sub PesqFK3_Load_1(sender As Object, e As EventArgs) Handles PesqFK3.Load
        With PesqFK3
            .LabelPesqFK = "Perfil"
            .Tabela = "CG_PERFIL"
            .View = "CG_PERFIL"
            .CampoId = "ID_PERFIL"
            .CampoDesc = "DESC_PERFIL"
            .ListaCampos = "ID_PERFIL, DESC_PERFIL"
            .ColunasFiltro = "DESC_PERFIL"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Perfis de Acesso do Sistema"
            '.FiltroSQL = " where id_empresa = " & Publico.Id_empresa
            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False
        End With
    End Sub

    Private Sub PesqFK4_Load(sender As Object, e As EventArgs) Handles PesqFK4.Load
        With PesqFK4
            .LabelPesqFK = "OS"
            .Tabela = "CG_OS"
            .View = "CG_OS"
            .CampoId = "ID_OS"
            .CampoDesc = "DATA_MOVTO"
            .ListaCampos = "ID_OS, DATA_MOVTO"
            .ColunasFiltro = "ID_OS,DATA_MOVTO"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Data OS"
            .TituloTela = "Pesquisa de OS"
            '.FiltroSQL = " where id_empresa = " & Publico.Id_empresa
            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = False
        End With
    End Sub
End Class