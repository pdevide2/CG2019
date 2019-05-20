Imports FastReport.Data
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class FrTest1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '//rotina para chamar o relatorio com os parametros associados
        escolhe()
    End Sub

    Private Sub escolhe()
        Try

            Dim vnome As String
            Dim dsRelatorio As DataSet
            vnome = TvReport.SelectedNode.Index.ToString & " - " & TvReport.SelectedNode.Text.ToString
            'MessageBox.Show(vnome, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Select Case TvReport.SelectedNode.Index
                Case 0 '// Alocação
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(0), "CG_ALOCACAO")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frAlocacoes.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                Case 1 '// Areas
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(1), "V_AREA")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frAreas.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")

                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")
                Case 2
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(2), "CG_CARGO")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frCargos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                Case 3
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(3), "CG_CATEGORIA")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frCategorias.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                Case 4
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(4), "V_CHIP")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frChips.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")

                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")
                Case 5
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(5), "VW_CG_CLIENTE")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frClientes.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")
                Case 6
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(6), "V_EQUIPAMENTO")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frEquipamentos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")
                Case 7
                    '// Cria dataset para substituir dentro do relatorio salvo
                    dsRelatorio = CriaDataSet(QueryRelatorio(7), "CG_FINALIDADE")
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frFinalidades.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")
                Case 8
                    '// Cria dataset para substituir dentro do relatorio salvo
                    'dsRelatorio = CriaDataSet(QueryRelatorio(8), "V_FORNECEDORES")

                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frFornecedores.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("V_FORNECEDORES")
                    table.SelectCommand = QueryRelatorio(8)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())
                '// Passa o parametro de grupo para quebra de banda do relatorio
                'Report1.SetParameterValue("grupo", "[V_AREA.ID_EMPRESA]")

                Case 9
                    '// Carrega o template salvo do relatorio
                    Report1.Load(My.Settings.DIRHOME & "CG\CG\FastReport\frConsertos.frx")
                    '// Troca o dataset original do relatorio pelo criado em código 
                    Dim table As TableDataSource
                    table = Report1.GetDataSource("CG_CONCERTO")
                    table.SelectCommand = QueryRelatorio(9)

                    'Report1.RegisterData(dsRelatorio, "DbCGDataSet1")
                    '// Passa o parametro do usuario logado pra imprimir no rodapé do relatorio
                    Report1.SetParameterValue("usuario", UserName())

                Case 10

                Case 11

                Case 12

                Case 13

                Case 14

                Case 15

                Case 16

                Case 17

                Case 18

                Case 19

                Case 20

                Case 21

                Case 22

                Case 23

                Case 24

                Case 25

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
            Case 0
                sql = "select ID_ALOCACAO,DESC_ALOCACAO from CG_ALOCACAO order by 1"


            Case 1
                sql = "select A.ID_AREA, DESC_AREA, A.ID_RESPONSAVEL, B.NOME, B.APELIDO, A.ID_EMPRESA , C.NOME_EMPRESA "
                sql = sql & " from CG_AREA A "
                sql = sql & " INNER JOIN CG_RESPONSAVEL B "
                sql = sql & "	ON B.ID_RESPONSAVEL = A.ID_RESPONSAVEL "
                sql = sql & " INNER JOIN CG_EMPRESA C "
                sql = sql & "	ON C.ID_EMPRESA = A.ID_EMPRESA "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(1)
                sql = sql & " ORDER BY ID_EMPRESA, ID_AREA "
            Case 2
                sql = "select ID_CARGO,DESC_CARGO from CG_CARGO order by 1"
            Case 3
                sql = "select * from CG_CATEGORIA ORDER BY ID_CATEGORIA"
            Case 4
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
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(4)
                sql = sql & " ORDER BY CG_CHIP.ID_EMPRESA, CG_CHIP.SIMID "
            Case 5
                sql = " select [ID_CLIENTE], [SIGLA], [NOME], [CEP], [ENDERECO], [COMPLEMENTO], [CIDADE], [BAIRRO], [UF], "
                sql = sql & " [EMAIL], [TELEFONE1], [CONTATO1], [TELEFONE2], [CONTATO2], [TELEFONE3], [CONTATO3], [TELEFONE4], "
                sql = sql & " [CONTATO4], [OBS], [CADASTRO], [ULTIMA_ATUALIZACAO], [ID_EMPRESA], [PFPJ], [CPF_CNPJ], [RG_IE], "
                sql = sql & " [NOME_EMPRESA], [SIGLA_EMPRESA] "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(5)
                sql = sql & " from VW_cg_cliente ORDER BY ID_EMPRESA, NOME "
            Case 6
                sql = " SELECT        VW_CG_EQUIPAMENTO.ID_EQUIPAMENTO, VW_CG_EQUIPAMENTO.DESC_EQUIPAMENTO, VW_CG_EQUIPAMENTO.SERIE, VW_CG_EQUIPAMENTO.MODELO, VW_CG_EQUIPAMENTO.ID_TIPO_EQUIPAMENTO, "
                sql = sql & "                          VW_CG_EQUIPAMENTO.DESC_TIPO_EQUIPAMENTO, VW_CG_EQUIPAMENTO.ID_FORNECEDOR, VW_CG_EQUIPAMENTO.SIGLA, VW_CG_EQUIPAMENTO.VALOR, VW_CG_EQUIPAMENTO.OBS, "
                sql = sql & "                          VW_CG_EQUIPAMENTO.NF_ENTRADA, VW_CG_EQUIPAMENTO.DATA_NF, VW_CG_EQUIPAMENTO.PRAZO_GARANTIA, VW_CG_EQUIPAMENTO.DATA_INICIO_GARANTIA, "
                sql = sql & "                          VW_CG_EQUIPAMENTO.DATA_TERMINO_GARANTIA, VW_CG_EQUIPAMENTO.ID_EMPRESA, CG_EMPRESA.NOME_EMPRESA "
                sql = sql & " FROM            VW_CG_EQUIPAMENTO INNER JOIN "
                sql = sql & "                          CG_EMPRESA AS b ON b.ID_EMPRESA = VW_CG_EQUIPAMENTO.ID_EMPRESA INNER JOIN "
                sql = sql & "                          CG_EMPRESA ON VW_CG_EQUIPAMENTO.ID_EMPRESA = CG_EMPRESA.ID_EMPRESA "
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(6)
                sql = sql & " ORDER BY VW_CG_EQUIPAMENTO.ID_TIPO_EQUIPAMENTO, VW_CG_EQUIPAMENTO.ID_EMPRESA, VW_CG_EQUIPAMENTO.SERIE "
            Case 7
                sql = "select * from CG_FINALIDADE ORDER BY ID_FINALIDADE"
            Case 8
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
                sql = sql & " WHERE 1 = 1 " & TextoFiltro(8)
                sql = sql & " ORDER BY cg_fornecedor.id_empresa, cg_fornecedor.sigla "
            Case 9
                sql = "select * from CG_CONCERTO ORDER BY DESC_CONCERTO"

        End Select
        Return sql
    End Function

    Private Function TextoFiltro(intOpcao As Integer) As String
        Dim retorno As String = ""
        If intOpcao = 1 Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND  A.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = 4 Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND  CG_CHIP.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = 5 Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND  VW_cg_cliente.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = 6 Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND VW_CG_EQUIPAMENTO.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
            End If
        End If
        If intOpcao = 8 Then
            If Not String.IsNullOrEmpty(Me.PesqFK1.txtId.Text) Then
                retorno = retorno & " AND cg_fornecedor.ID_EMPRESA = " & Me.PesqFK1.txtId.Text
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
    End Sub

    Private Sub TvReport_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TvReport.AfterSelect
        '// Habilita /Desabilita o filtro empresa
        Select Case e.Node.Index
            Case 1, 4, 5, 6, 8
                Me.PesqFK1.Visible = True

            Case Else
                Me.PesqFK1.Visible = False


        End Select
    End Sub
End Class