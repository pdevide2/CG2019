Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ImportarEntradaEquipamento
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

            Dim arqOrigem As String = My.Settings.DIRHOME & "CG\CG\Modelos\MODELO_ENTRADA_ESTOQUE_EQUIPAMENTO.xlsx"
            Dim arqDestino As String = "C:\TEMP2\MODELO_ENTRADA_ESTOQUE_EQUIPAMENTO_" & ProtocoloNumero() & ".xlsx"
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
            xlw.Worksheets.Select(1)


            Dim strDados As New ArrayList


            Dim strSerie As String = String.Empty
            Dim strModelo As String = String.Empty
            Dim strSerieEquipamento As String = String.Empty
            Dim strIdEquipamento As String = String.Empty
            Dim strObs As String = String.Empty
            Dim strCusto As String = String.Empty
            Dim strDescEquipamento As String = String.Empty

            '*****
            '* Le a Planilha Excel até encontrar um Serie nulo
            '* carrega para um ArrayList e depois valida e popula 
            '* o DataGridView, se não encontrar importa, caso
            '* contrário da mensagem de erro e não importa a Linha
            '*/
            Dim linha As Integer = 2

            strSerieEquipamento = xlw.Application.Cells(linha, 1).Value.ToString

            Dim myRow As ArrayList, comandoSQL As String

            While Len(Trim(strSerieEquipamento)) > 0

                Try
                    comandoSQL = "EXEC sp_Valida_Equipamento_Entrada '" & strSerieEquipamento & "'"
                    myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                    If myRow.Count > 0 Then
                        strDescEquipamento = myRow(0)(1).ToString
                        strSerie = myRow(0)(2).ToString
                        strModelo = myRow(0)(3).ToString
                        strCusto = myRow(0)(4).ToString
                        strIdEquipamento = myRow(0)(0).ToString
                        strObs = "OK"
                    End If
                Catch ex As Exception
                    strSerie = ""
                    strModelo = ""
                    strDescEquipamento = ""
                    strIdEquipamento = ""
                    strCusto = ""
                    strObs = ex.Message
                Finally
                    strDados.Add({strIdEquipamento, strDescEquipamento, strSerieEquipamento, strModelo, strCusto, strObs})
                End Try

                linha = linha + 1

                If String.IsNullOrEmpty(xlw.Application.Cells(linha, 1).Value) Then
                    strSerieEquipamento = ""
                Else
                    lblMensagem.Text = "Lendo linha " & linha & " Equipamento: " & strSerieEquipamento
                    strSerieEquipamento = Trim(xlw.Application.Cells(linha, 1).Value.ToString)
                End If


            End While

            strSerieEquipamento = Nothing
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

        Dim colIdEquipamento As DataGridViewTextBoxColumn
        Dim colDescEquipamento As DataGridViewTextBoxColumn
        Dim colSerie As DataGridViewTextBoxColumn
        Dim colModelo As DataGridViewTextBoxColumn
        Dim colCusto As DataGridViewTextBoxColumn
        Dim colStatus As DataGridViewTextBoxColumn
        Dim colObs As DataGridViewTextBoxColumn

        'coluna colIdEquipamento
        colIdEquipamento = New DataGridViewTextBoxColumn
        colIdEquipamento.HeaderText = "ID Equipamento"
        colIdEquipamento.Name = "ID_Equipamento"
        colIdEquipamento.Width = 60

        'coluna colDescEquipamento
        colDescEquipamento = New DataGridViewTextBoxColumn
        colDescEquipamento.HeaderText = "Descrição Equipamento"
        colDescEquipamento.Name = "DESC_EQUIPAMENTO"
        colDescEquipamento.Width = 200

        'coluna colSerie
        colSerie = New DataGridViewTextBoxColumn
        colSerie.HeaderText = "Serie"
        colSerie.Name = "Serie"
        colSerie.Width = 120

        'coluna colModelo
        colModelo = New DataGridViewTextBoxColumn
        colModelo.HeaderText = "Modelo"
        colModelo.Name = "Modelo"
        colModelo.Width = 120

        'coluna colModelo
        colCusto = New DataGridViewTextBoxColumn
        colCusto.HeaderText = "Custo R$"
        colCusto.Name = "CUSTO"
        colCusto.Width = 90

        'coluna colStatus
        colStatus = New DataGridViewTextBoxColumn
        colStatus.HeaderText = "Status"
        colStatus.Name = "STATUS"
        colStatus.Width = 50

        'coluna colObs
        colObs = New DataGridViewTextBoxColumn
        colObs.HeaderText = "Observação"
        colObs.Name = "OBS"
        colObs.Width = 300

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colIdEquipamento, colDescEquipamento, colSerie, _
                                                            colModelo, colCusto, colStatus, colObs})

        For ixx = 0 To 6
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
        Try

            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid
            Dim strLinha As String()

            Dim _idEquipamento As String
            Dim _descEquipamento As String
            Dim _status As String
            Dim _obs As String
            Dim _custo As String
            Dim _totalEquipamento As Integer = 0

            '{strIdEquipamento, strDescEquipamento, strSerie, strModelo, strCusto, strObs}
            'arrayPlanilha(ixx)(0)
            For ixx = 0 To arrayPlanilha.Count - 1

                If arrayPlanilha(ixx)(5) = "OK" Then

                    _descEquipamento = arrayPlanilha(ixx)(1)
                    _idEquipamento = arrayPlanilha(ixx)(0)
                    _status = "OK"
                    _custo = arrayPlanilha(ixx)(4)
                    _obs = "ESTOQUE ATUALIZADO"
                    _totalEquipamento = _totalEquipamento + 1

                Else
                    _descEquipamento = arrayPlanilha(ixx)(1)
                    _idEquipamento = String.Empty
                    _custo = String.Empty
                    _status = "ERRO"
                    _obs = arrayPlanilha(ixx)(5)


                End If

                '{colIdEquipamento, 
                'colDescEquipamento, 
                'colSerie, 
                'colModelo, 
                'colCusto, 
                'colStatus, 
                'colObs}
                strLinha = {_idEquipamento, _
                            _descEquipamento, _
                            arrayPlanilha(ixx)(2), _
                            arrayPlanilha(ixx)(3), _
                            _custo, _
                            _status, _
                            _obs}

                dgvDados.Rows.Add(strLinha)
                txtTotal.Text = _totalEquipamento.ToString

            Next

            txtTotal.Text = _totalEquipamento.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ImportarPlanilha()

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ExportaExcel(dgvDados, "LOG_IMPORT_ENTRADA_Equipamento")
    End Sub

    Public Sub Gravar()
        'MyBase.Gravar(acao)

        Dim bllPai As New BLL.Entrada_EstoqueBLL
        Dim objEntradaEquipamento As New DTO.Cg_entrada_estoque

        Dim bllFilha As New BLL.Entrada_equipamento_itemBLL
        Dim objEntradaEquipamentoItem As New DTO.Cg_entrada_equipamento_item

        Dim _totalEquipamento As Integer = CInt(txtTotal.Text)
        Dim KeyId As Integer = 0

        If _totalEquipamento = 0 Then
            MessageBox.Show("Não há Equipamento disponivel para importar para o estoque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try
            Dim bll As New BLL.GlobalBLL
            KeyId = bll.NovaChaveBLL("CG_ENTRADA_Equipamento")

            objEntradaEquipamento.Id_romaneio = KeyId
            objEntradaEquipamento.Data_movto = ShortDate()
            objEntradaEquipamento.Id_loja = CInt(getCodigoMatriz())  'Matriz - codigo = 1

            objEntradaEquipamento.User_ins = ACE_CODIGO
            objEntradaEquipamento.Data_ins = Hoje()
            objEntradaEquipamento.User_upd = ACE_CODIGO
            objEntradaEquipamento.Data_upd = Hoje()
            objEntradaEquipamento.Id_empresa = Publico.Id_empresa

            bllPai.GravarBLL(1, objEntradaEquipamento) 'modo inclusão - código = 1

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    lblMensagem.Text = "Aguarde atualizando banco de dados..."
                    If Trim(row.Cells(5).Value) = "OK" Then

                        'Carrega os dados no objeto Model para passagem de parametro
                        objEntradaEquipamentoItem.Id_equipamento = CInt(row.Cells(0).Value)
                        objEntradaEquipamentoItem.Serie = row.Cells(2).Value
                        objEntradaEquipamentoItem.Qtd = 1
                        objEntradaEquipamentoItem.Valor = Convert.ToDouble(Replace(row.Cells(4).Value, ".", ","))
                        objEntradaEquipamentoItem.Id_romaneio = KeyId
                        objEntradaEquipamentoItem.Unique_keyid = NovoKeyId()
                        objEntradaEquipamentoItem.Id_empresa = Publico.Id_empresa

                        'Operação de delete/insert
                        bllFilha.GravarBLL(1, objEntradaEquipamentoItem)

                        row.Cells(6).Value = "GRAVADO COM SUCESSO"
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
    Private Function getCodigoMatriz() As String
        Dim strLoja As ArrayList
        Dim sqlquery As String
        Dim ret As String

        'Pega o ID da Matriz, da empresa logada. Cada empresa logada tem uma MATRIZ de estoque
        sqlquery = "SELECT ID_LOJA, NOME FROM CG_LOJA WHERE ID_TIPO_LOCAL_ESTOQUE=1 and id_empresa = " & Publico.Id_empresa
        strLoja = Global.BLL.GlobalBLL.PesquisarFkListaBLL(sqlquery)

        ret = strLoja(0)(0).ToString
        'txtDescLoja.Text = strLoja(0)(1).ToString
        Return ret
    End Function
End Class