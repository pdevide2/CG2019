Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ImportarCadastroEquipamento
    Public podeAbrir As Boolean = False
    'variavel flagAcao o Default é readonly, após verificar permissão no módulo pode mudar para Limpar (0)
    Public flagAcao As Integer = Operacao.Leitura
    Dim _acao As Integer
    Dim _acesso As String
    Public Enum Operacao

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum
    Public Property Acao() As Integer
        Get
            Return _acao
        End Get
        Set(ByVal value As Integer)
            _acao = value
        End Set
    End Property
    Public Property Acesso() As String
        Get
            Return _acesso
        End Get
        Set(ByVal value As String)
            _acesso = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LoginCG() 'Carrega variavel Friend ACE_CODIGO pelo Setting ID_USER
        ' Add any initialization after the InitializeComponent() call.
        podeAbrir = permissaoTela(ACE_MODULO, ACE_CODIGO)


    End Sub
    Public Function permissaoTela(ByVal intModulo As Integer, ByVal intUsuario As Integer) As Boolean
        flagAcao = Operacao.Limpar
        'Dim strPermissao As String = ""
        'strPermissao = verPermissao(intModulo, intUsuario)

        'Me.Acesso = strPermissao

        'If strPermissao = "S" Then
        '    MessageBox.Show("Usuário sem permissão de acesso neste módulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'ElseIf strPermissao = "L" Then
        '    flagAcao = Operacao.Leitura
        'ElseIf strPermissao = "G" Then
        '    flagAcao = Operacao.Limpar
        'Else
        '    MessageBox.Show("Configurações de permissão para este módulo não encontrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False

        'End If
        Me.Acao = flagAcao
        Return True
    End Function
    Function verPermissao(ByVal modulo As Integer, ByVal usuario As Integer) As String

        Dim retorno As String
        Dim oBLL As New BLL.GlobalBLL

        retorno = oBLL.getPermissaoBLL(modulo, usuario)
        Return retorno

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strfilename As String = ""
        ofd.FileName = strfilename
        Try
            If Not Directory.Exists("C:\TEMP2\") Then
                Directory.CreateDirectory("C:\TEMP2")
            End If

            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                strfilename = Trim(ofd.FileName)
                MessageBox.Show(strfilename, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Seleção de Planilha Excel cancelado pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                strfilename = ""
                txtFile.Text = ""
            End If
            If Not String.IsNullOrEmpty(strfilename) Then
                txtFile.Text = strfilename
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFile.Text = ""
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ExportarPlanilha()

    End Sub

    Private Sub ExportarPlanilha()
        Try
            If Not Directory.Exists("C:\TEMP2\") Then
                Directory.CreateDirectory("C:\TEMP2")
            End If

            Dim arqOrigem As String = My.Settings.DIRHOME & "CG\CG\Modelos\MODELO_CADASTRO_EQUIPAMENTO.xlsx"
            Dim arqDestino As String = "C:\TEMP2\MODELO_CADASTRO_EQUIPAMENTO_" & ProtocoloNumero() & ".xlsx"
            My.Computer.FileSystem.CopyFile(arqOrigem, arqDestino)

            'Abre a planilha Excel gerada para o usuário preencher
            Process.Start("Excel.exe", arqDestino)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ImportarPlanilha()
        Try

            If Not Directory.Exists("C:\TEMP2\") Then
                Directory.CreateDirectory("C:\TEMP2")
            End If

            If String.IsNullOrEmpty(Trim(txtFile.Text)) Then
                MessageBox.Show("Selecione uma planilha para importar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim xl As New Excel.Application
            Dim xlw As Excel.Workbook

            xlw = xl.Workbooks.Open(Trim(txtFile.Text))
            xlw.Application.Visible = True
            xlw.Worksheets.Select(1)


            Dim strDados As New ArrayList

            Dim celulas(9) As String
            'col    conteudo  
            '====   ===================
            'A	    ID_TIPO_EQUIPAMENTO
            'B	    DESC_EQUIPAMENTO
            'C	    SERIE
            'D	    MODELO
            'E	    ID_FORNECEDOR
            'F	    VALOR
            'G	    NF FORNEC
            'H	    DATA AQUISIÇÃO
            'I	    GARANTIA (DIAS)


            '*****
            '* Le a Planilha Excel até encontrar um SIMID nulo
            '* carrega para um ArrayList e depois valida e popula 
            '* o DataGridView, se não encontrar importa, caso
            '* contrário da mensagem de erro e não importa a Linha
            '*/
            Dim linha As Integer = 2

            Dim ixx As Integer = 0
            For ixx = 1 To 9
                If String.IsNullOrEmpty(xlw.Application.Cells(linha, ixx).Value) Then
                    celulas(ixx - 1) = ""
                Else
                    celulas(ixx - 1) = xlw.Application.Cells(linha, ixx).Value.ToString
                End If
            Next

            While Len(Trim(celulas(2))) > 0

                strDados.Add({celulas(0), _
                              celulas(1), _
                              celulas(2), _
                              celulas(3), _
                              celulas(4), _
                              celulas(5), _
                              celulas(6), _
                              celulas(7), _
                              celulas(8)})


                linha = linha + 1

                If String.IsNullOrEmpty(xlw.Application.Cells(linha, 2).Value) Then
                    celulas(2) = ""
                Else
                    lblMensagem.Text = "Lendo linha " & linha & " Série#: " & celulas(2)

                    For ixx = 1 To 9
                        If String.IsNullOrEmpty(xlw.Application.Cells(linha, ixx).Value) Then
                            celulas(ixx - 1) = ""
                        Else
                            celulas(ixx - 1) = xlw.Application.Cells(linha, ixx).Value.ToString
                        End If
                    Next

                End If


            End While


            lblMensagem.Text = "."

            xlw.Close(False)
            xl.Quit()

            'Kill Process
            MataProcessoExcel()

            xl = Nothing
            xlw = Nothing

            GC.Collect()

            Popula_Grid(strDados)
            'Persiste os dados no banco de dados SQL
            Gravar()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub FormataGrid()

        Dim colId_Equipamento As DataGridViewTextBoxColumn
        Dim colDesc_Equipamento As DataGridViewTextBoxColumn
        Dim colSerie As DataGridViewTextBoxColumn
        Dim colModelo As DataGridViewTextBoxColumn
        Dim colId_Tipo_Equipamento As DataGridViewTextBoxColumn
        Dim colDesc_Tipo_Equipamento As DataGridViewTextBoxColumn
        Dim colId_Fornecedor As DataGridViewTextBoxColumn
        Dim colNome As DataGridViewTextBoxColumn
        Dim colValor As DataGridViewTextBoxColumn
        Dim colNF As DataGridViewTextBoxColumn
        Dim colDataAquisicao As DataGridViewTextBoxColumn
        Dim colPrazo As DataGridViewTextBoxColumn
        Dim colObs As DataGridViewTextBoxColumn
        Dim colStatus As DataGridViewTextBoxColumn


        'coluna colId_Equipamento
        colId_Equipamento = New DataGridViewTextBoxColumn
        colId_Equipamento.HeaderText = "ID Equipamento"
        colId_Equipamento.Name = "ID_Equipamento"
        colId_Equipamento.Width = 60

        'coluna colDesc_Equipamento
        colDesc_Equipamento = New DataGridViewTextBoxColumn
        colDesc_Equipamento.HeaderText = "Descrição do Equipamento"
        colDesc_Equipamento.Name = "Desc_Equipamento"
        colDesc_Equipamento.Width = 260

        'coluna colSerie
        colSerie = New DataGridViewTextBoxColumn
        colSerie.HeaderText = "Serie"
        colSerie.Name = "Serie"
        colSerie.Width = 60

        'coluna colModelo
        colModelo = New DataGridViewTextBoxColumn
        colModelo.HeaderText = "Modelo"
        colModelo.Name = "Modelo"
        colModelo.Width = 120

        'coluna colId_Tipo_Equipamento
        colId_Tipo_Equipamento = New DataGridViewTextBoxColumn
        colId_Tipo_Equipamento.HeaderText = "ID Tipo Equip."
        colId_Tipo_Equipamento.Name = "Id_Tipo_Equipamento"
        colId_Tipo_Equipamento.Width = 60

        'coluna colDesc_Tipo_Equipamento
        colDesc_Tipo_Equipamento = New DataGridViewTextBoxColumn
        colDesc_Tipo_Equipamento.HeaderText = "Desc. Tipo Equipamento"
        colDesc_Tipo_Equipamento.Name = "Desc_Tipo_Equipamento"
        colDesc_Tipo_Equipamento.Width = 200

        'coluna colId_Fornecedor
        colId_Fornecedor = New DataGridViewTextBoxColumn
        colId_Fornecedor.HeaderText = "Fornecedor ID"
        colId_Fornecedor.Name = "Id_Fornecedor"
        colId_Fornecedor.Width = 90

        'coluna colNome
        colNome = New DataGridViewTextBoxColumn
        colNome.HeaderText = "Nome Fornecedor"
        colNome.Name = "NOME"
        colNome.Width = 200

        'coluna colValor
        colValor = New DataGridViewTextBoxColumn
        colValor.HeaderText = "Valor R$"
        colValor.Name = "Valor"
        colValor.Width = 100

        'coluna colNF
        colNF = New DataGridViewTextBoxColumn
        colNF.HeaderText = "NF Fornec."
        colNF.Name = "NF_ENTRADA"
        colNF.Width = 60

        'coluna colDataAquisicao
        colDataAquisicao = New DataGridViewTextBoxColumn
        colDataAquisicao.HeaderText = "Dt. Aquisição"
        colDataAquisicao.Name = "DATA_NF"
        colDataAquisicao.Width = 75

        'coluna colPrazo
        colPrazo = New DataGridViewTextBoxColumn
        colPrazo.HeaderText = "Prazo Garantia"
        colPrazo.Name = "PRAZO_GARANTIA"
        colPrazo.Width = 90

        'coluna colObs
        colObs = New DataGridViewTextBoxColumn
        colObs.HeaderText = "Observação"
        colObs.Name = "OBS"
        colObs.Width = 300

        'coluna colStatus
        colStatus = New DataGridViewTextBoxColumn
        colStatus.HeaderText = "Status"
        colStatus.Name = "STATUS"
        colStatus.Width = 50

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colId_Equipamento _
                                                            , colDesc_Equipamento _
                                                            , colSerie _
                                                            , colModelo _
                                                            , colId_Tipo_Equipamento _
                                                            , colDesc_Tipo_Equipamento _
                                                            , colId_Fornecedor _
                                                            , colNome _
                                                            , colValor _
                                                            , colNF _
                                                            , colDataAquisicao _
                                                            , colPrazo _
                                                            , colObs _
                                                            , colStatus _
                                                            })
        'A	    ID_TIPO_EQUIPAMENTO
        'B	    DESC_EQUIPAMENTO
        'C	    SERIE
        'D	    MODELO
        'E	    ID_FORNECEDOR
        'F	    VALOR
        'G	    NF FORNEC
        'H	    DATA AQUISIÇÃO
        'I	    GARANTIA (DIAS)


        For ixx = 0 To 13
            dgvDados.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        dgvDados.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados.MultiSelect = False
        dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados.AllowUserToResizeColumns = False
        dgvDados.EnableHeadersVisualStyles = False

    End Sub

    Private Sub ImportarCadastroEquipamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormataGrid()
    End Sub

    Private Sub Popula_Grid(ByVal arrayPlanilha As ArrayList)
        ' arrayPlanilha elementos:
        '===========================
        'A	0    ID_TIPO_EQUIPAMENTO
        'B	1    DESC_EQUIPAMENTO
        'C	2    SERIE
        'D	3    MODELO
        'E	4    ID_FORNECEDOR
        'F	5    VALOR
        'G	6    NF FORNEC
        'H	7    DATA AQUISIÇÃO
        'I	8    GARANTIA (DIAS)
        Try

            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid
            Dim strLinha As String()

            Dim _Id_Equipamento As String
            Dim _Desc_Tipo_Equipamento As String
            Dim _Nome As String
            Dim _Status As String
            Dim _Obs As String

            For ixx = 0 To arrayPlanilha.Count - 1

                Dim myRow As ArrayList, comandoSQL As String

                comandoSQL = "SELECT ID_EQUIPAMENTO, DESC_EQUIPAMENTO, SERIE, MODELO, ID_TIPO_EQUIPAMENTO, "
                comandoSQL += "DESC_TIPO_EQUIPAMENTO, ID_FORNECEDOR, NOME, VALOR, OBS "
                comandoSQL += "FROM VW_CG_EQUIPAMENTO "
                comandoSQL += "WHERE SERIE = '" & arrayPlanilha(ixx)(2) & "'"

                myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)

                If myRow.Count > 0 Then

                    _Id_Equipamento = myRow(0)(0).ToString
                    _Desc_Tipo_Equipamento = myRow(0)(5).ToString
                    _Nome = myRow(0)(7).ToString
                    _Status = "EXISTE"
                    _Obs = "ATUALIZAR CADASTRO"

                Else

                    _Id_Equipamento = String.Empty
                    _Desc_Tipo_Equipamento = String.Empty
                    _Nome = String.Empty
                    _Status = "NOVO"
                    _Obs = String.Empty


                    'myRow = Nothing

                    'comandoSQL = "select ID_TIPO_EQUIPAMENTO, DESC_TIPO_EQUIPAMENTO from CG_TIPO_EQUIPAMENTO "
                    'comandoSQL += "WHERE ID_TIPO_EQUIPAMENTO = '" & arrayPlanilha(ixx)(0) & "' "

                    'myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                    'If myRow.Count > 0 Then
                    '    _Desc_Tipo_Equipamento = myRow(0)(1).ToString
                    'Else
                    '    _Status = "ERRO"
                    '    _Obs = "TIPO DE EQUIPAMENTO NÃO EXISTE"
                    'End If

                    'myRow = Nothing

                    'comandoSQL = "SELECT ID_FORNECEDOR, NOME FROM CG_FORNECEDOR "
                    'comandoSQL += "WHERE ID_FORNECEDOR = " & arrayPlanilha(ixx)(4)
                    'myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                    'If myRow.Count > 0 Then
                    '    _Nome = myRow(0)(1).ToString
                    'Else
                    '    _Status = "ERRO"
                    '    _Obs = "FORNECEDOR NÃO EXISTE"
                    'End If

                End If

                '////////
                '// VALIDA DADOS DA PLANILHA PARA INCLUSÃO E ALTERAÇÃO
                '//
                '

                myRow = Nothing

                comandoSQL = "select ID_TIPO_EQUIPAMENTO, DESC_TIPO_EQUIPAMENTO from CG_TIPO_EQUIPAMENTO "
                comandoSQL += "WHERE ID_TIPO_EQUIPAMENTO = '" & arrayPlanilha(ixx)(0) & "' "

                myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                If myRow.Count > 0 Then
                    _Desc_Tipo_Equipamento = myRow(0)(1).ToString
                Else
                    _Status = "ERRO"
                    _Obs = "TIPO DE EQUIPAMENTO NÃO EXISTE"
                End If

                myRow = Nothing

                comandoSQL = "SELECT ID_FORNECEDOR, NOME FROM CG_FORNECEDOR "
                comandoSQL += "WHERE ID_FORNECEDOR = " & arrayPlanilha(ixx)(4)
                myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                If myRow.Count > 0 Then
                    _Nome = myRow(0)(1).ToString
                Else
                    _Status = "ERRO"
                    _Obs = "FORNECEDOR NÃO EXISTE"
                End If

                strLinha = {_Id_Equipamento, _
                            arrayPlanilha(ixx)(1), _
                            arrayPlanilha(ixx)(2), _
                            arrayPlanilha(ixx)(3), _
                            arrayPlanilha(ixx)(0), _
                            _Desc_Tipo_Equipamento, _
                            arrayPlanilha(ixx)(4), _
                            _Nome, _
                            arrayPlanilha(ixx)(5), _
                            arrayPlanilha(ixx)(6), _
                            arrayPlanilha(ixx)(7), _
                            arrayPlanilha(ixx)(8), _
                            _Status, _
                            _Obs}

                dgvDados.Rows.Add(strLinha)
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ImportarPlanilha()

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ExportaExcel(dgvDados, "LOG_IMPORT_Equipamento")
    End Sub

    Public Sub Gravar()
        'MyBase.Gravar(acao)
        Dim bllGlobal As New BLL.GlobalBLL

        Dim bll As New BLL.EquipamentoBLL
        Dim objEquipamento As New DTO.Cg_equipamento
        Dim blnErro As Boolean
        Dim KeyId As Integer
        blnErro = True

        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    lblMensagem.Text = "Aguarde atualizando banco de dados..."
                    If Trim(row.Cells(12).Value) = "NOVO" Then

                        KeyId = bllGlobal.NovaChaveBLL("CG_Equipamento")

                        objEquipamento.Desc_equipamento = row.Cells(1).Value
                        objEquipamento.Id_equipamento = KeyId
                        objEquipamento.Id_fornecedor = CInt(row.Cells(6).Value)
                        objEquipamento.Id_tipo_equipamento = CInt(row.Cells(4).Value)
                        objEquipamento.Modelo = row.Cells(3).Value
                        objEquipamento.Obs = "IMPORTADO POR PLANILHA EXCEL EM: " & Hoje().ToString
                        objEquipamento.Protocolo = ""
                        objEquipamento.Serie = row.Cells(2).Value

                        objEquipamento.NF_Entrada = row.Cells(9).Value
                        objEquipamento.Data_NF = CDate(IIf(row.Cells(10).Value = "", "01/01/1900", row.Cells(10).Value))
                        objEquipamento.Prazo_garantia = CInt(IIf(row.Cells(11).Value = "", "0", row.Cells(11).Value))

                        objEquipamento.User_ins = ACE_CODIGO
                        objEquipamento.User_upd = ACE_CODIGO
                        objEquipamento.Data_ins = Hoje()
                        objEquipamento.Data_upd = Hoje()
                        objEquipamento.Id_empresa = Publico.Id_empresa

                        objEquipamento.Valor = Convert.ToDouble(Replace(row.Cells(8).Value, ".", ","))


                        bll.GravarBLL(1, objEquipamento) 'insert
                        row.Cells(13).Value = "GRAVADO COM SUCESSO"
                    End If

                    If Trim(row.Cells(12).Value) = "EXISTE" Then

                        KeyId = CInt(row.Cells(0).Value) 'bllGlobal.NovaChaveBLL("CG_Equipamento")

                        objEquipamento.Desc_equipamento = row.Cells(1).Value
                        objEquipamento.Id_equipamento = KeyId
                        objEquipamento.Id_fornecedor = CInt(row.Cells(6).Value)
                        objEquipamento.Id_tipo_equipamento = CInt(row.Cells(4).Value)
                        objEquipamento.Modelo = row.Cells(3).Value
                        objEquipamento.Obs = "ATUALIZADO POR PLANILHA EXCEL EM: " & Hoje().ToString
                        objEquipamento.Protocolo = ""
                        objEquipamento.Serie = row.Cells(2).Value

                        objEquipamento.NF_Entrada = row.Cells(9).Value
                        objEquipamento.Data_NF = CDate(IIf(row.Cells(10).Value = "", "01/01/1900", row.Cells(10).Value))
                        objEquipamento.Prazo_garantia = CInt(IIf(row.Cells(11).Value = "", "0", row.Cells(11).Value))

                        objEquipamento.User_ins = ACE_CODIGO
                        objEquipamento.User_upd = ACE_CODIGO
                        objEquipamento.Data_ins = Hoje()
                        objEquipamento.Data_upd = Hoje()
                        objEquipamento.Id_empresa = Publico.Id_empresa

                        objEquipamento.Valor = Convert.ToDouble(Replace(row.Cells(8).Value, ".", ","))


                        bll.GravarBLL(2, objEquipamento) 'UPDATE
                        row.Cells(13).Value = "ATUALIZADO COM SUCESSO"
                    End If

                End If

            Next
            'MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'flagAcao = Operacao.Consulta
            lblMensagem.Text = "."

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try

    End Sub

End Class