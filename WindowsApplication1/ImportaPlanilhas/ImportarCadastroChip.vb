Imports System.Diagnostics
Imports System.ComponentModel
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ImportarCadastroChip
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

            Dim arqOrigem As String = My.Settings.DIRHOME & "CG\CG\Modelos\MODELO_CADASTRO_CHIP.xlsx"
            Dim arqDestino As String = "C:\TEMP2\MODELO_CADASTRO_CHIP_" & ProtocoloNumero() & ".xlsx"
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


            Dim strSimid As String
            Dim strOperadora As String
            Dim strFornecedor As String
            Dim strCusto As String


            '*****
            '* Le a Planilha Excel até encontrar um SIMID nulo
            '* carrega para um ArrayList e depois valida e popula 
            '* o DataGridView, se não encontrar importa, caso
            '* contrário da mensagem de erro e não importa a Linha
            '*/
            Dim linha As Integer = 2

            strSimid = xlw.Application.Cells(linha, 1).Value.ToString
            strOperadora = xlw.Application.Cells(linha, 2).Value.ToString
            strFornecedor = xlw.Application.Cells(linha, 3).Value.ToString
            strCusto = xlw.Application.Cells(linha, 4).Value.ToString

            While Len(Trim(strSimid)) > 0


                strDados.Add({strSimid, strOperadora, strFornecedor, strCusto})
                linha = linha + 1

                If String.IsNullOrEmpty(xlw.Application.Cells(linha, 1).Value) Then
                    strSimid = ""
                Else
                    lblMensagem.Text = "Lendo linha " & linha & " SIMID: " & strSimid
                    strSimid = xlw.Application.Cells(linha, 1).Value.ToString
                    strOperadora = xlw.Application.Cells(linha, 2).Value.ToString
                    strFornecedor = xlw.Application.Cells(linha, 3).Value.ToString
                    strCusto = xlw.Application.Cells(linha, 4).Value.ToString
                End If


            End While

            strSimid = Nothing
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

        Dim colIdChip As DataGridViewTextBoxColumn
        Dim colSimId As DataGridViewTextBoxColumn
        Dim colIdOperadora As DataGridViewTextBoxColumn
        Dim colOperadora As DataGridViewTextBoxColumn
        Dim colIdFornecedor As DataGridViewTextBoxColumn
        Dim colNome As DataGridViewTextBoxColumn
        Dim colCusto As DataGridViewTextBoxColumn
        Dim colStatus As DataGridViewTextBoxColumn
        Dim colObs As DataGridViewTextBoxColumn

        'coluna colIdChip
        colIdChip = New DataGridViewTextBoxColumn
        colIdChip.HeaderText = "ID Chip"
        colIdChip.Name = "ID_CHIP"
        colIdChip.Width = 60

        'coluna colSimId
        colSimId = New DataGridViewTextBoxColumn
        colSimId.HeaderText = "SIMID"
        colSimId.Name = "SIMID"
        colSimId.Width = 120

        'coluna colIdOperadora
        colIdOperadora = New DataGridViewTextBoxColumn
        colIdOperadora.HeaderText = "ID Operadora"
        colIdOperadora.Name = "ID_OPERADORA"
        colIdOperadora.Width = 60

        'coluna colOperadora
        colOperadora = New DataGridViewTextBoxColumn
        colOperadora.HeaderText = "Operadora"
        colOperadora.Name = "OPERADORA"
        colOperadora.Width = 120

        'coluna colIdFornecedor
        colIdFornecedor = New DataGridViewTextBoxColumn
        colIdFornecedor.HeaderText = "ID Fornec."
        colIdFornecedor.Name = "ID_FORNECEDOR"
        colIdFornecedor.Width = 60

        'coluna colNome
        colNome = New DataGridViewTextBoxColumn
        colNome.HeaderText = "Nome Fornecedor"
        colNome.Name = "NOME"
        colNome.Width = 200

        'coluna colCusto
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
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colIdChip, colSimId, colIdOperadora, _
                                                            colOperadora, colIdFornecedor, colNome, _
                                                            colCusto, colStatus, colObs})

        For ixx = 0 To 8
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

    Private Sub ImportarCadastroChip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormataGrid()
    End Sub

    Private Sub Popula_Grid(ByVal arrayPlanilha As ArrayList)
        Try

            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid
            Dim strLinha As String()

            Dim _idChip As String
            Dim _idOperadora As String
            Dim _nome As String
            Dim _status As String
            Dim _obs As String

            For ixx = 0 To arrayPlanilha.Count - 1

                Dim myRow As ArrayList, comandoSQL As String

                comandoSQL = "SELECT "
                comandoSQL += "ID_CHIP, SIMID, ID_OPERADORA, DESC_OPERADORA, ID_FORNECEDOR, NOME "
                comandoSQL += "FROM VW_CG_CHIP "
                comandoSQL += "WHERE SIMID = '" & arrayPlanilha(ixx)(0) & "'"

                myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)

                If myRow.Count > 0 Then

                    _idChip = myRow(0)(0).ToString
                    _idOperadora = myRow(0)(2).ToString
                    _nome = myRow(0)(5).ToString
                    _status = "EXISTE"
                    '_obs = "NÃO ADICIONADO"
                    _obs = "ATUALIZAR CADASTRO"

                Else

                    _idChip = String.Empty
                    _idOperadora = String.Empty
                    _nome = String.Empty
                    _status = "NOVO"
                    _obs = String.Empty

                    'myRow = Nothing

                    'comandoSQL = "SELECT ID_OPERADORA, DESC_OPERADORA FROM CG_OPERADORA "
                    'comandoSQL += "WHERE DESC_OPERADORA = '" & arrayPlanilha(ixx)(1) & "' "

                    'myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                    'If myRow.Count > 0 Then
                    '    _idOperadora = myRow(0)(0).ToString
                    'Else
                    '    _status = "ERRO"
                    '    _obs = "OPERADORA NÃO EXISTE"
                    'End If

                    'myRow = Nothing

                    'comandoSQL = "SELECT ID_FORNECEDOR, NOME FROM CG_FORNECEDOR "
                    'comandoSQL += "WHERE ID_FORNECEDOR = " & arrayPlanilha(ixx)(2)
                    'myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                    'If myRow.Count > 0 Then
                    '    _nome = myRow(0)(1).ToString
                    'Else
                    '    _status = "ERRO"
                    '    _obs = "FORNECEDOR NÃO EXISTE"
                    'End If

                End If

                '/////////////
                '// VALIDA A EXISTENCIA DOS DADOS DA PLANILHA OPERADORA E FORNECEDOR
                '// PARA INCLUSÃO E ATUALIZAÇÃO
                '// PAULO - 16SET17
                '
                myRow = Nothing

                comandoSQL = "SELECT ID_OPERADORA, DESC_OPERADORA FROM CG_OPERADORA "
                comandoSQL += "WHERE DESC_OPERADORA = '" & arrayPlanilha(ixx)(1) & "' "

                myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                If myRow.Count > 0 Then
                    _idOperadora = myRow(0)(0).ToString
                Else
                    _status = "ERRO"
                    _obs = "OPERADORA NÃO EXISTE"
                End If

                myRow = Nothing

                comandoSQL = "SELECT ID_FORNECEDOR, NOME FROM CG_FORNECEDOR "
                comandoSQL += "WHERE ID_FORNECEDOR = " & arrayPlanilha(ixx)(2)
                myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                If myRow.Count > 0 Then
                    _nome = myRow(0)(1).ToString
                Else
                    _status = "ERRO"
                    _obs = "FORNECEDOR NÃO EXISTE"
                End If

                strLinha = {_idChip, _
                            arrayPlanilha(ixx)(0), _
                            _idOperadora, _
                            arrayPlanilha(ixx)(1), _
                            arrayPlanilha(ixx)(2), _
                            _nome, _
                            arrayPlanilha(ixx)(3), _
                            _status, _
                            _obs}

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
        ExportaExcel(dgvDados, "LOG_IMPORT_CHIP")
    End Sub

    Public Sub Gravar()
        'MyBase.Gravar(acao)
        Dim bllGlobal As New BLL.GlobalBLL

        Dim bll As New BLL.ChipBLL
        Dim objChip As New DTO.Cg_chip
        Dim blnErro As Boolean
        Dim KeyId As Integer
        blnErro = True

        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    lblMensagem.Text = "Aguarde atualizando banco de dados..."
                    If Trim(row.Cells(7).Value) = "NOVO" Then

                        KeyId = bllGlobal.NovaChaveBLL("CG_CHIP")

                        objChip.Id_chip = KeyId 'CInt(row.Cells(0).Value)
                        objChip.Simid = row.Cells(1).Value
                        objChip.Id_operadora = CInt(row.Cells(2).Value)
                        objChip.Id_fornecedor = CInt(row.Cells(4).Value)
                        objChip.Custo = Convert.ToDouble(Replace(row.Cells(6).Value, ".", ","))

                        objChip.User_ins = ACE_CODIGO
                        objChip.Data_ins = Hoje()
                        objChip.User_upd = ACE_CODIGO
                        objChip.Data_upd = Hoje()
                        objChip.Id_empresa = Publico.Id_empresa

                        bll.GravarBLL(1, objChip) 'insert
                        row.Cells(8).Value = "GRAVADO COM SUCESSO"
                    End If

                    If Trim(row.Cells(7).Value) = "EXISTE" Then

                        KeyId = CInt(row.Cells(0).Value) 'bllGlobal.NovaChaveBLL("CG_CHIP")

                        objChip.Id_chip = KeyId 'CInt(row.Cells(0).Value)
                        objChip.Simid = row.Cells(1).Value
                        objChip.Id_operadora = CInt(row.Cells(2).Value)
                        objChip.Id_fornecedor = CInt(row.Cells(4).Value)
                        objChip.Custo = Convert.ToDouble(Replace(row.Cells(6).Value, ".", ","))

                        objChip.User_ins = ACE_CODIGO
                        objChip.Data_ins = Hoje()
                        objChip.User_upd = ACE_CODIGO
                        objChip.Data_upd = Hoje()
                        objChip.Id_empresa = Publico.Id_empresa

                        bll.GravarBLL(2, objChip) 'UPDATE
                        row.Cells(8).Value = "ATUALIZADO COM SUCESSO"
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