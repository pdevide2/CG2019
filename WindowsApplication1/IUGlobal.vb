Imports System
Imports System.IO
Imports System.Text
Imports System.Security
Imports DTO
Imports BLL
Imports Excel = Microsoft.Office.Interop.Excel

Module IUGlobal
    Friend ACE_CODIGO As Integer
    Friend ACE_MODULO As Integer
    Friend ACE_PERMISSAO As String
    Friend ACE_NOME_USUARIO As String = vbNullString

    Function getLastUser() As String
        Return My.Settings.LASTUSER
    End Function

    Function LoginCG() As Integer
        'ACE_CODIGO = My.Settings.ID_USER
        'variavel ACE_CODIGO É FRIEND e é setada na tela de Login
        Return ACE_CODIGO

    End Function

    Function ModuloID() As Integer
        ACE_MODULO = My.Settings.ID_MODULO
        Return ACE_MODULO

    End Function

    Function PermissaoModulo() As String
        ACE_PERMISSAO = My.Settings.PERMISSAO
        Return ACE_PERMISSAO

    End Function

    Function DirHome()
        Return My.Settings.DIRHOME
    End Function

    Function ShortDate()
        Return CDate(Date.Now.ToShortDateString)
    End Function

    Function UserName()
        'Return Environment.UserDomainName & "\" & Environment.UserName
        Return ACE_NOME_USUARIO & " (" & ACE_CODIGO.ToString & ")"
    End Function

    Function Hoje()

        Dim Data_hoje As DateTime = DateTime.Now

        Return Data_hoje

    End Function
    '********
    '** Função retorna a função NEWID() DO SQL SERVER
    '** no formato "98A07BF7-2617-49C2-91DD-EAFC708656A8"
    '**/
    Function NovoKeyId() As String
        Return UCase(BLL.GlobalBLL.getNewId())
    End Function

    Function ProtocoloNumero() As String
        'Retorna String com Ano + Mês + Dia + Hora Formato 24 + minutos + segundos + Milesimos de Segundos (3 digitos)
        'Exemplo: "20160819124536827"
        Return DateTime.Now.ToString("yyyyMMddHHmmssfff")
    End Function

    Function Dtos(ByVal _data As Date)
        'Retorna string no formato yyyyMMdd com 8 posições. Exemplo: Dtos("10/04/2016") ==> retorna "20160410"
        Return _data.ToString("yyyyMMdd")
    End Function


    Public Sub NAR(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Public Sub MataProcessoExcel()
        For Each processo As Process In Process.GetProcesses()
            If UCase(processo.ProcessName) = "EXCEL" Then
                If processo.MainWindowTitle = "" Then
                    Try
                        processo.Kill()
                        System.Threading.Thread.Sleep(1000)
                    Catch
                        MessageBox.Show("Não foi possivel finalizar o processo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Next
    End Sub

    Function FilePathExcel(ByVal _firstName As String) As String
        'My.Computer.FileSystem
        Dim strFilePath As String = ""
        Try
            Dim sd As New SaveFileDialog

            sd.Filter = "Excel File|*.xlsx"
            sd.Title = "Salvar Planilha Excel"
            sd.FileName = _firstName & ProtocoloNumero() & ".xlsx"

            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                strFilePath = Trim(sd.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return strFilePath

    End Function

    Public Function AscIItoChar(ByVal _intCode As Integer) As String
        If _intCode >= 33 And _intCode <= 255 Then
            Dim associatedChar As Char
            associatedChar = Chr(_intCode)

            Return associatedChar.ToString
        Else
            Return ""
        End If
    End Function

    Public Function getRangeExcel(ByVal _linha As Integer, _coluna As Integer) As String

        Dim strRef As String = ""
        Dim strSubRef As String = ""
        Dim _coluna2 As Integer = 0

        Dim strCol As String = ""
        Dim intRedutor As Integer = 0

        If _coluna >= 1 And _coluna <= 26 Then
            strCol = ""
            intRedutor = 26 * 0
        End If
        If _coluna >= 27 And _coluna <= 52 Then
            strCol = "A"
            intRedutor = 26 * 1
        End If
        If _coluna >= 53 And _coluna <= 78 Then
            strCol = "B"
            intRedutor = 26 * 2
        End If
        If _coluna >= 79 And _coluna <= 104 Then
            strCol = "C"
            intRedutor = 26 * 3
        End If
        If _coluna >= 105 And _coluna <= 130 Then
            strCol = "D"
            intRedutor = 26 * 4
        End If
        If _coluna >= 131 And _coluna <= 156 Then
            strCol = "E"
            intRedutor = 26 * 5
        End If
        If _coluna >= 157 And _coluna <= 182 Then
            strCol = "F"
            intRedutor = 26 * 6
        End If
        If _coluna >= 183 And _coluna <= 208 Then
            strCol = "G"
            intRedutor = 26 * 7
        End If
        If _coluna >= 209 And _coluna <= 234 Then
            strCol = "H"
            intRedutor = 26 * 8
        End If
        If _coluna >= 235 And _coluna <= 260 Then
            strCol = "I"
            intRedutor = 26 * 9
        End If
        If _coluna >= 261 And _coluna <= 286 Then
            strCol = "J"
            intRedutor = 26 * 10
        End If
        If _coluna >= 287 And _coluna <= 312 Then
            strCol = "K"
            intRedutor = 26 * 11
        End If
        If _coluna >= 313 And _coluna <= 338 Then
            strCol = "L"
            intRedutor = 26 * 12
        End If
        If _coluna >= 339 And _coluna <= 364 Then
            strCol = "M"
            intRedutor = 26 * 13
        End If
        If _coluna >= 365 And _coluna <= 390 Then
            strCol = "N"
            intRedutor = 26 * 14
        End If
        If _coluna >= 391 And _coluna <= 416 Then
            strCol = "O"
            intRedutor = 26 * 15
        End If
        If _coluna >= 417 And _coluna <= 442 Then
            strCol = "P"
            intRedutor = 26 * 16
        End If
        If _coluna >= 443 And _coluna <= 468 Then
            strCol = "Q"
            intRedutor = 26 * 17
        End If
        If _coluna >= 469 And _coluna <= 494 Then
            strCol = "R"
            intRedutor = 26 * 18
        End If
        If _coluna >= 495 And _coluna <= 520 Then
            strCol = "S"
            intRedutor = 26 * 19
        End If
        If _coluna >= 521 And _coluna <= 546 Then
            strCol = "T"
            intRedutor = 26 * 20
        End If
        If _coluna >= 547 And _coluna <= 572 Then
            strCol = "U"
            intRedutor = 26 * 21
        End If
        If _coluna >= 573 And _coluna <= 598 Then
            strCol = "V"
            intRedutor = 26 * 22
        End If
        If _coluna >= 599 And _coluna <= 624 Then
            strCol = "W"
            intRedutor = 26 * 23
        End If
        If _coluna >= 625 And _coluna <= 650 Then
            strCol = "X"
            intRedutor = 26 * 24
        End If
        If _coluna >= 651 And _coluna <= 676 Then
            strCol = "Y"
            intRedutor = 26 * 25
        End If
        If _coluna >= 677 And _coluna <= 702 Then
            strCol = "Z"
            intRedutor = 26 * 26
        End If

        _coluna2 = _coluna - intRedutor

        strSubRef = AscIItoChar(_coluna2 + 64)
        strRef = strCol & strSubRef & _linha.ToString

        Return strRef
    End Function

    Public Sub ExportaExcel(ByVal dgvDados As DataGridView, ByVal _view As String)

        Dim MyTable1 As New DataTable
        MyTable1 = TryCast(dgvDados.DataSource, DataTable)

        'Define os objetos Excel
        Dim xlApp As New Excel.Application
        'Inclui um Novo Workbook
        xlApp.SheetsInNewWorkbook = 1

        Dim xlWorkBooks As Excel.Workbooks = xlApp.Workbooks
        Dim xlWorkBook As Excel.Workbook = xlWorkBooks.Add
        Dim xlWorkSheet As Excel.Worksheet = xlApp.ActiveSheet

        Dim blnSalvou As Boolean = False

        Dim strFile As String
        strFile = FilePathExcel(_view) 'Pega o nome e a pasta do arquivo que vai ser salvo

        Dim result As String = ""
        Dim strCols As String = ""

        'Faz a leitura de todo o DataGridView e joga numa string, que posteriormente vai ser exportada para um arquivo TXT
        For rowIndex = 0 To dgvDados.RowCount - 1
            For colIndex = 0 To dgvDados.ColumnCount - 1
                result += dgvDados.Rows(rowIndex).Cells(colIndex).Value.ToString &
                    IIf(colIndex < dgvDados.ColumnCount - 1, vbTab, vbCrLf)
            Next
        Next

        'Pega o Caption das colunas
        For Each coluna As DataGridViewColumn In dgvDados.Columns
            strCols += coluna.HeaderText & vbTab
        Next

        Dim fileTemp As String

        fileTemp = My.Computer.FileSystem.GetTempFileName.ToString ' gera um arquivo temporário na pasta temporária do windows %temp%

        result = strCols & vbCrLf & result

        My.Computer.FileSystem.WriteAllText(fileTemp, result, False)

        Dim strArq As String
        Dim tr As IO.TextReader = New IO.StreamReader(fileTemp)
        strArq = tr.ReadToEnd


        xlApp.Visible = False

        xlWorkSheet = xlWorkBook.Sheets(1)
        xlWorkSheet.Name = _view

        Clipboard.Clear()
        Clipboard.SetText(strArq)
        tr.Close()


        Dim tipoDado As Type
        Dim campo As String = ""
        Dim iCont As Integer = 0
        Dim letraColuna As String = ""
        With xlWorkSheet
            .Range("A1").Select()

            For Each column As DataColumn In MyTable1.Columns
                iCont += 1
                letraColuna = getRangeExcel(1, iCont).Substring(0, IIf(iCont < 27, 1, 2))
                campo = column.ColumnName
                tipoDado = column.DataType
                If tipoDado.Name = "String" Then
                    'xlWorkSheet.Columns(letraColuna & ":" & letraColuna).Select
                    xlWorkSheet.Columns(letraColuna).NumberFormat = "@"
                End If
            Next

            .Range("A1").Select()
            .Paste()

            .Cells.Select()

            .Cells.EntireColumn.AutoFit()
            .Cells(1, 1).select()

            Dim strLastCell As String = getRangeExcel(1, dgvDados.ColumnCount)
            With .Range("A1:" & strLastCell)
                .Interior.ColorIndex = 1 'Cor de Fundo Preta

                With .Font
                    .ColorIndex = 2      'Cor de fonte Branca
                    .Size = 8
                    .Name = "Tahoma"
                    '.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleSingle --> sublinhado
                    .Bold = True
                End With


            End With
            .Range("A1").Select()

            ' salva o arquivo
            Try
                xlApp.DisplayAlerts = False
                xlApp.ActiveWorkbook.SaveAs(Filename:=Trim(strFile),
                    FileFormat:=51, CreateBackup:=False)

                blnSalvou = True

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar planilha: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try



        End With

        'Exclui o arquivo temporário que acabou de ser utilizado
        My.Computer.FileSystem.DeleteFile(fileTemp)
        Clipboard.Clear()

        NAR(xlWorkSheet)
        xlWorkBook.Close(False)
        NAR(xlWorkBook)
        NAR(xlWorkBooks)
        xlApp.Quit()
        NAR(xlApp)

        'Kill Process
        MataProcessoExcel()

        xlWorkBooks = Nothing
        xlWorkBook = Nothing
        xlWorkSheet = Nothing
        xlApp = Nothing

        GC.Collect()

        If blnSalvou Then
            If VisualizarArquivo("EXCEL", strFile) = True Then
                MessageBox.Show("Planilha gerada em " & strFile & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Public Sub ExportaExcel2(ByVal dgvDados As DataGridView, ByVal dgvDados2 As DataGridView, ByVal _nomeSaida As String,
                                ByVal _view As String, ByVal _view2 As String)

        Dim MyTable1 As New DataTable
        MyTable1 = TryCast(dgvDados.DataSource, DataTable)

        Dim MyTable2 As New DataTable
        MyTable2 = TryCast(dgvDados2.DataSource, DataTable)

        'Define os objetos Excel
        Dim xlApp As New Excel.Application
        'Inclui um Novo Workbook
        xlApp.SheetsInNewWorkbook = 2 'duas abas - dgvDados e dgvDados2

        Dim xlWorkBooks As Excel.Workbooks = xlApp.Workbooks
        Dim xlWorkBook As Excel.Workbook = xlWorkBooks.Add
        Dim xlWorkSheet As Excel.Worksheet = xlApp.ActiveSheet

        Dim blnSalvou As Boolean = False

        Dim strFile As String
        strFile = FilePathExcel(_nomeSaida) 'Pega o nome e a pasta do arquivo que vai ser salvo

        Dim iSheet As Integer
        Dim fileTemp As String

        For iSheet = 0 To 1
            Dim result As String = ""
            Dim strCols As String = ""

            If iSheet = 0 Then
                'Faz a leitura de todo o DataGridView e joga numa string, que posteriormente vai ser exportada para um arquivo TXT
                For rowIndex = 0 To dgvDados.RowCount - 1
                    For colIndex = 0 To dgvDados.ColumnCount - 1
                        result += dgvDados.Rows(rowIndex).Cells(colIndex).Value.ToString & IIf(colIndex < dgvDados.ColumnCount - 1, vbTab, vbCrLf)
                    Next
                Next

                'Pega o Caption das colunas
                For Each coluna As DataGridViewColumn In dgvDados.Columns
                    strCols += coluna.HeaderText & vbTab
                Next


                fileTemp = My.Computer.FileSystem.GetTempFileName.ToString ' gera um arquivo temporário na pasta temporária do windows %temp%

                result = strCols & vbCrLf & result

                My.Computer.FileSystem.WriteAllText(fileTemp, result, False)

                Dim strArq As String
                Dim tr As IO.TextReader = New IO.StreamReader(fileTemp)
                strArq = tr.ReadToEnd


                xlApp.Visible = False

                xlWorkSheet = xlWorkBook.Sheets(1)
                xlWorkSheet.Name = _view

                Clipboard.Clear()
                Clipboard.SetText(strArq)
                tr.Close()

            Else
                'Faz a leitura de todo o DataGridView e joga numa string, que posteriormente vai ser exportada para um arquivo TXT
                For rowIndex = 0 To dgvDados2.RowCount - 1
                    For colIndex = 0 To dgvDados2.ColumnCount - 1
                        result += dgvDados2.Rows(rowIndex).Cells(colIndex).Value.ToString & IIf(colIndex < dgvDados2.ColumnCount - 1, vbTab, vbCrLf)
                    Next
                Next

                'Pega o Caption das colunas
                For Each coluna As DataGridViewColumn In dgvDados2.Columns
                    strCols += coluna.HeaderText & vbTab
                Next


                fileTemp = My.Computer.FileSystem.GetTempFileName.ToString ' gera um arquivo temporário na pasta temporária do windows %temp%

                result = strCols & vbCrLf & result

                My.Computer.FileSystem.WriteAllText(fileTemp, result, False)

                Dim strArq As String
                Dim tr As IO.TextReader = New IO.StreamReader(fileTemp)
                strArq = tr.ReadToEnd


                xlApp.Visible = False

                xlWorkSheet = xlWorkBook.Sheets(2)
                xlWorkSheet.Name = _view2

                Clipboard.Clear()
                Clipboard.SetText(strArq)
                tr.Close()

            End If

            Dim tipoDado As Type
            Dim campo As String = ""
            Dim iCont As Integer = 0
            Dim letraColuna As String = ""

            With xlWorkSheet
                .Select()
                .Range("A1").Select()

                If xlWorkSheet.Name = _view Then
                    For Each column As DataColumn In MyTable1.Columns
                        iCont += 1
                        letraColuna = getRangeExcel(1, iCont).Substring(0, IIf(iCont < 27, 1, 2))
                        campo = column.ColumnName
                        tipoDado = column.DataType
                        If tipoDado.Name = "String" Then
                            'xlWorkSheet.Columns(letraColuna & ":" & letraColuna).Select
                            xlWorkSheet.Columns(letraColuna).NumberFormat = "@"
                        End If
                    Next
                Else
                    For Each column As DataColumn In MyTable2.Columns
                        iCont += 1
                        letraColuna = getRangeExcel(1, iCont).Substring(0, IIf(iCont < 27, 1, 2))
                        campo = column.ColumnName
                        tipoDado = column.DataType
                        If tipoDado.Name = "String" Then
                            'xlWorkSheet.Columns(letraColuna & ":" & letraColuna).Select
                            xlWorkSheet.Columns(letraColuna).NumberFormat = "@"
                        End If
                    Next
                End If

                .Range("A1").Select()

                .Paste()

                .Cells.Select()

                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).select()

                Dim strLastCell As String = getRangeExcel(1, dgvDados.ColumnCount)
                With .Range("A1:" & strLastCell)
                    .Interior.ColorIndex = 1 'Cor de Fundo Preta

                    With .Font
                        .ColorIndex = 2      'Cor de fonte Branca
                        .Size = 8
                        .Name = "Tahoma"
                        '.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleSingle --> sublinhado
                        .Bold = True
                    End With


                End With
                .Range("A1").Select()

                If iSheet = 1 Then 'segunda aba - já processou a primeira e a segunda aba, dai salva
                    ' salva o arquivo
                    Try
                        xlApp.DisplayAlerts = False
                        xlApp.ActiveWorkbook.SaveAs(Filename:=Trim(strFile),
                            FileFormat:=51, CreateBackup:=False)

                        blnSalvou = True

                    Catch ex As Exception
                        MessageBox.Show("Erro ao salvar planilha: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Try
                End If



            End With

            'Exclui o arquivo temporário que acabou de ser utilizado
            My.Computer.FileSystem.DeleteFile(fileTemp)
            Clipboard.Clear()

        Next 'isheet = 0 to 1

        NAR(xlWorkSheet)
        xlWorkBook.Close(False)
        NAR(xlWorkBook)
        NAR(xlWorkBooks)
        xlApp.Quit()
        NAR(xlApp)

        'Kill Process
        MataProcessoExcel()

        xlWorkBooks = Nothing
        xlWorkBook = Nothing
        xlWorkSheet = Nothing
        xlApp = Nothing

        GC.Collect()

        If blnSalvou Then
            If VisualizarArquivo("EXCEL", strFile) = True Then
                MessageBox.Show("Planilha gerada em " & strFile & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Public Function PesquisaString(ByVal strTextFull As String, ByVal strTextFind As String, ByVal intPosicao As Integer) As Boolean
        Dim blnRetorno As Boolean = False
        'strTextFull - texto completo 
        'strTextFind - pedaço de string a ser pesquisada no texto completo
        'intPosicao - 0 = pesquisar do inicio da String / 1 = pesquisar em qualquer posição da string
        Dim intTamanho As Integer

        strTextFull = strTextFull.ToLower
        strTextFind = strTextFind.ToLower
        intTamanho = Len(strTextFind)

        If intPosicao = 1 Then
            blnRetorno = strTextFull.Contains(strTextFind)
        Else
            'Pega um pedaço do texto completo do tamanho da string de pesquisa
            'e compara e verifica se é igual. Se for retorna True
            If strTextFull.StartsWith(strTextFind) Then
                'If strTextFull.Substring(0, intTamanho) = strTextFind Then
                blnRetorno = True
            End If
        End If

        Return blnRetorno
    End Function

    Function SomaData(ByVal pTipo As String, ByVal pQtd As Integer, ByVal pData As Date) As Date
        Dim pData1 As Date
        If pTipo = "D" Then
            pData1 = DateAdd(DateInterval.Day, pQtd, pData)
        ElseIf pTipo = "M" Then
            pData1 = DateAdd(DateInterval.Month, pQtd, pData)
        Else
            pData1 = pData
        End If

        Return pData1
    End Function

    Function TxtToString(ByVal _filePath As String) As String
        Dim strRetorno As String = ""
        Try
            If File.Exists(_filePath) = False Then
                MessageBox.Show(_filePath & " não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return strRetorno
            End If

            Dim readText As String = File.ReadAllText(_filePath)
            If readText.Length > 0 Then
                strRetorno = readText
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return strRetorno
    End Function

    Public Function IsPDFHeader(filename As String) As Boolean
        Dim stream As New StreamReader(filename)
        Dim containsPDFHeader As Boolean = True

        If Not stream.ReadLine().Contains("%PDF") Then
            containsPDFHeader = False
        End If
        Return containsPDFHeader

    End Function

    Public Function AcessoTela(ByVal intModulo As Integer, ByVal intUsuario As Integer) As String
        'flagAcao = Operacao.Limpar
        Dim strPermissao As String = "S"

        Dim myRow As ArrayList, comandoSQL As String

        comandoSQL = "EXEC spVer_Permissao @ID_MODULO = " & intModulo.ToString
        comandoSQL += ", @ID_PERFIL = " & Publico.Id_Perfil
        'comandoSQL += ", @ID_USUARIO = " & intUsuario.ToString


        myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)

        If myRow.Count > 0 Then

            strPermissao = myRow(0)("PERMISSAO").ToString 'Pega o campo PERMISSAO (String), resultado da query

        End If
        If strPermissao.Equals(";;;") Then
            strPermissao = "S" 'Sem acesso nenhum
        End If
        Return strPermissao

    End Function

    Public Function Le_Celula_Excel(ByVal _celula)
        If IsDBNull(_celula) Then
            Le_Celula_Excel = ""
        Else
            Le_Celula_Excel = _celula
        End If
    End Function
    'Public Sub BuscaLoja(ByRef oModel As Object, ByVal _loja_ref As String, ByRef _form As Object)
    '    oModel = New DTO.PesquisaFK

    '    oModel.Tabela = "CG_LOJA"
    '    oModel.CampoId = "ID_LOJA"
    '    oModel.CampoDesc = "NOME"
    '    oModel.LabelBuscaId = "Código"
    '    oModel.LabelBuscaDesc = "Nome"
    '    oModel.TituloTela = "Pesquisa de Loja"
    '    oModel.TxtId = 0 'IIf(Len(Trim(TextBox1.Text)) = 0, 0, CInt(TextBox1.Text))
    '    oModel.TxtDesc = ""

    '    'Monta o Comando SQL'
    '    oModel.ComandoSQL = "Select " & oModel.CampoId & ", " & oModel.CampoDesc & _
    '                        " From " & oModel.Tabela

    '    If String.IsNullOrEmpty(_loja_ref) Then
    '        oModel.FiltroSQL = " where (ID_LOJA = 1 OR ID_LOJA > 9) "
    '    Else
    '        oModel.FiltroSQL = " where (ID_LOJA = 1 OR ID_LOJA > 9) AND ID_LOJA <> " & _loja_ref
    '    End If

    '    PesquisaLojaFK(oModel, _form)

    '    'txtIdLoja.Text = Me.ObjModelFk.txtId.ToString
    '    'txtDescLoja.Text = Me.ObjModelFk.txtDesc

    'End Sub

    'Public Sub PesquisaLojaFK(ByRef oPesqFk As DTO.PesquisaFK, ByRef _form As Object)
    '    'Chama uma tela de Pesquisa Dinamica
    '    'Para buscar e filtrar um registro de tabela estrangeira
    '    Dim frm As New PesquisaDinamica(_form, oPesqFk)
    '    frm.Owner = _form
    '    frm.ShowDialog()

    'End Sub

    Function SoLETRAS(ByVal KeyAscii As Integer) As Integer

        'Transformar letras minusculas em Maiúsculas

        KeyAscii = Asc(UCase(Chr(KeyAscii)))

        ' Intercepta um código ASCII recebido e admite somente letras

        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then

            SoLETRAS = 0

        Else

            SoLETRAS = KeyAscii

        End If



        ' teclas adicionais permitidas

        If KeyAscii = 8 Then SoLETRAS = KeyAscii ' Backspace

        If KeyAscii = 13 Then SoLETRAS = KeyAscii ' Enter

        If KeyAscii = 32 Then SoLETRAS = KeyAscii ' Espace

    End Function


    Function SoNumeros(ByVal Keyascii As Short) As Short

        If InStr("1234567890", Chr(Keyascii)) = 0 Then

            SoNumeros = 0

        Else

            SoNumeros = Keyascii

        End If



        Select Case Keyascii

            Case 8

                SoNumeros = Keyascii

            Case 13

                SoNumeros = Keyascii

            Case 32

                SoNumeros = Keyascii

        End Select

    End Function

    Function SoNumerosMoeda(ByVal Keyascii As Short) As Short

        If InStr("1234567890.,", Chr(Keyascii)) = 0 Then

            SoNumerosMoeda = 0

        Else
            'Se o usuário digitou virgula ",", troca o valor por ".", pois o SQL não aceita virgula
            If Chr(Keyascii) = "," Then
                Keyascii = Asc(".")
            End If
            SoNumerosMoeda = Keyascii

        End If



        Select Case Keyascii

            Case 8

                SoNumerosMoeda = Keyascii

            Case 13

                SoNumerosMoeda = Keyascii

            Case 32

                SoNumerosMoeda = Keyascii

        End Select

    End Function

    Function SoNumerosData(ByVal Keyascii As Short) As Short

        If InStr("1234567890/", Chr(Keyascii)) = 0 Then

            SoNumerosData = 0

        Else
            SoNumerosData = Keyascii

        End If



        Select Case Keyascii

            Case 8

                SoNumerosData = Keyascii

            Case 13

                SoNumerosData = Keyascii

            Case 32

                SoNumerosData = Keyascii

        End Select

    End Function

    Function validaData(_data As String) As Boolean
        If String.IsNullOrEmpty(_data) Then
            validaData = True
        Else
            If _data.Length < 8 Then  'Data no formato dd/mm/aa ou dd/mm/aaaa, valida o tamanho, tem que ser mais que 8
                validaData = False
            Else
                validaData = IsDate(_data)
            End If
        End If
    End Function

    Function VisualizarArquivo(ByVal _tipoArq As String, ByVal _arquivo As String) As Boolean
        Try

            If _tipoArq.ToUpper = "EXCEL" Then
                Dim startInfo As New ProcessStartInfo
                startInfo.FileName = "EXCEL.EXE"
                'adiciona aspas (") antes e depois do nome e caminho do arquivo para não dar erro 
                startInfo.Arguments = Chr(34) & _arquivo & Chr(34)

                Process.Start(startInfo)

                'Process.Start("Excel.exe", _arquivo)
            End If

            If _tipoArq.ToUpper = "WORD" Then

                Dim startInfo As New ProcessStartInfo
                startInfo.FileName = "WINWORD.EXE"
                'adiciona aspas (") antes e depois do nome e caminho do arquivo para não dar erro 
                startInfo.Arguments = Chr(34) & _arquivo & Chr(34)

                Process.Start(startInfo)

                'Process.Start("Winword.exe", _arquivo)
            End If

            If _tipoArq.ToUpper = "PDF" Or _tipoArq = "XML" Then

                _arquivo = Chr(34) & _arquivo & Chr(34)

                Process.Start(_arquivo)

            End If

            VisualizarArquivo = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            VisualizarArquivo = False
        End Try
    End Function

    Public Function GeraStringRandomico(ByVal _tamanho As Byte) As String
        Dim strRetorno As String = ""
        Try
            Dim objAleatorio As Random = New Random()
            Dim strCombinacao As String = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim codigoCaptcha As StringBuilder = New StringBuilder()
            Dim i As Byte
            For i = 1 To _tamanho
                codigoCaptcha.Append(strCombinacao(objAleatorio.Next(strCombinacao.Length)))
            Next
            strRetorno = codigoCaptcha.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return strRetorno

    End Function

    'Public Overridable Sub DefineAcesso()

    '    Me.Acesso = ACE_PERMISSAO

    '    Dim arrayPermissao() As String

    '    arrayPermissao = Me.Acesso.Split(";")

    '    Me.BotaoPesquisa = IIf(arrayPermissao(0).Equals("P"), True, False)
    '    Me.BotaoIncluir = IIf(arrayPermissao(1).Equals("I"), True, False)
    '    Me.BotaoAlterar = IIf(arrayPermissao(2).Equals("A"), True, False)
    '    Me.BotaoExcluir = IIf(arrayPermissao(3).Equals("E"), True, False)

    '    If (Me.BotaoPesquisa = True) And (Me.BotaoIncluir = False) And (Me.BotaoAlterar = False) And (Me.BotaoExcluir = False) Then
    '        flagAcao = Operacao.Leitura
    '    Else
    '        flagAcao = Operacao.Limpar
    '    End If

    '    'If Me.Acesso = "L" Then
    '    '    flagAcao = Operacao.Leitura
    '    'ElseIf Me.Acesso = "G" Then
    '    '    flagAcao = Operacao.Limpar
    '    'End If

    'End Sub

    Public Function DefineAcessoBotao(ByVal _modulo As Integer, ByRef objPermissaoModulo1 As DTO.PermissaoModulo) As DTO.PermissaoModulo

        Dim bllAcesso As New BLL.GlobalBLL
        Dim dtAcesso = bllAcesso.SqlExecDT("exec spVER_Permissao " & _modulo & ", " & Publico.Id_Perfil)

        If dtAcesso.Rows.Count > 0 Then

            objPermissaoModulo1.Pesquisa = dtAcesso(0)("PESQUISAR")
            objPermissaoModulo1.Incluir = dtAcesso(0)("INCLUIR")
            objPermissaoModulo1.Alterar = dtAcesso(0)("ALTERAR")
            objPermissaoModulo1.Excluir = dtAcesso(0)("EXCLUIR")

        End If
        dtAcesso = Nothing
        Return objPermissaoModulo1
    End Function

End Module
