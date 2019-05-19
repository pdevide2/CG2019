Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word

Module WordReport

    Const wdpanenone = 0

    '* WdViewType
    Const wdnormalview = 1
    Const wdoutlineview = 2
    Const wdpageview = 3
    Const wdprintpreview = 4
    Const wdmasterview = 5
    Const wdonlineview = 6

    '* WdSeekView
    Const wdseekmaindocument = 0
    Const wdseekcurrentpageheader = 9
    Const wdseekcurrentpagefooter = 10


    Const wdstory = 6
    Const wdcollapseend = 0
    Const cr = Chr(13)
    Const wdlinestyledouble = 7
    Const wdalignparagraphleft = 0
    Const wdalignparagraphcenter = 1
    Const wdalignparagraphright = 2

    '*********************************** << inicio >>
    Const _class_type = "Paint.Picture"

    Public Sub SampleWord()

        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
        Dim oRng As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double

        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add

        'Insert a paragraph at the beginning of the document.
        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Text = "Heading 1"
        oPara1.Range.Font.Bold = True
        oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Text = "Heading 2"
        oPara2.Format.SpaceAfter = 6
        oPara2.Range.InsertParagraphAfter()

        'Insert another paragraph.
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Text = "This is a sentence of normal text. Now here is a table:"
        oPara3.Range.Font.Bold = False
        oPara3.Format.SpaceAfter = 24
        oPara3.Range.InsertParagraphAfter()

        'Insert a 3 x 5 table, fill it with data, and make the first row
        'bold and italic.
        Dim r As Integer, c As Integer
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 3, 5)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 3
            For c = 1 To 5
                oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            Next
        Next
        oTable.Rows.Item(1).Range.Font.Bold = True
        oTable.Rows.Item(1).Range.Font.Italic = True

        'Add some text after the table.
        'oTable.Range.InsertParagraphAfter()
        oPara4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara4.Range.InsertParagraphBefore()
        oPara4.Range.Text = "And here's another table:"
        oPara4.Format.SpaceAfter = 24
        oPara4.Range.InsertParagraphAfter()

        'Insert a 5 x 2 table, fill it with data, and change the column widths.
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 5
            For c = 1 To 2
                oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            Next
        Next
        oTable.Columns.Item(1).Width = oWord.InchesToPoints(2)   'Change width of columns 1 & 2
        oTable.Columns.Item(2).Width = oWord.InchesToPoints(3)

        'Keep inserting text. When you get to 7 inches from top of the
        'document, insert a hard page break.
        Pos = oWord.InchesToPoints(7)
        oDoc.Bookmarks.Item("\endofdoc").Range.InsertParagraphAfter()
        Do
            oRng = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng.ParagraphFormat.SpaceAfter = 6
            oRng.InsertAfter("A line of text")
            oRng.InsertParagraphAfter()
        Loop While Pos >= oRng.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)
        oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        oRng.InsertBreak(Word.WdBreakType.wdPageBreak)
        oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        oRng.InsertAfter("We're now on page 2. Here's my chart:")
        oRng.InsertParagraphAfter()

        'Insert a chart and change the chart.
        oShape = oDoc.Bookmarks.Item("\endofdoc").Range.InlineShapes.AddOLEObject(
            ClassType:="MSGraph.Chart.8", FileName _
            :="", LinkToFile:=False, DisplayAsIcon:=False)
        oChart = oShape.OLEFormat.Object
        oChart.charttype = 4 'xlLine = 4
        oChart.Application.Update()
        oChart.Application.Quit()
        'If desired, you can proceed from here using the Microsoft Graph 
        'Object model on the oChart object to make additional changes to the
        'chart.
        oShape.Width = oWord.InchesToPoints(6.25)
        oShape.Height = oWord.InchesToPoints(3.57)

        'Add text after the chart.
        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        oRng.InsertParagraphAfter()
        oRng.InsertAfter("THE END.")
    End Sub

    Public Sub ReportOSWord(ByVal _documento As String, ByVal oParam As DTO.Parametros_report_os, ByVal dgvDados As DataGridView)


        Dim oWord As Word.Application
        oWord = CreateObject("Word.Application")

        oWord.Caption = "MS WORD - SR"
        oWord.Documents.Open(_documento, True)

        If oWord.ActiveWindow.View.SplitSpecial <> wdpanenone Then

            oWord.ActiveWindow.Panes(2).Close()

        End If

        If oWord.ActiveWindow.ActivePane.View.Type = wdnormalview Or
                oWord.ActiveWindow.ActivePane.View.Type = wdoutlineview Or
            oWord.ActiveWindow.ActivePane.View.Type = wdmasterview Then

            oWord.ActiveWindow.ActivePane.View.Type = wdpageview

        End If

        oWord.ActiveWindow.ActivePane.View.SeekView = wdseekcurrentpageheader

        Dim loselection = oWord.ActiveWindow.ActivePane.Selection

        loselection.Find.ClearFormatting()

        '**========== DOCUMENTO =============================================================================================
        '**
        oWord.ActiveWindow.ActivePane.View.SeekView = wdseekmaindocument
        loselection = oWord.ActiveWindow.ActivePane.Selection

        Substitui_Variavel_no_Texto(loselection, "@OS", oParam.OS_Id, "")
        Substitui_Variavel_no_Texto(loselection, "@DATA_OS", oParam.Data, "")
        Substitui_Variavel_no_Texto(loselection, "@RESPONSAVEL", oParam.Responsavel, "")
        Substitui_Variavel_no_Texto(loselection, "@LOJA", oParam.Loja, "")
        Substitui_Variavel_no_Texto(loselection, "@FORNECEDOR", oParam.Fornecedor, "")
        Substitui_Variavel_no_Texto(loselection, "@NF", oParam.NF, "")
        Substitui_Variavel_no_Texto(loselection, "@SERIE", oParam.SerieNF, "")
        Substitui_Variavel_no_Texto(loselection, "@EMISSAO", oParam.Emissao, "")

        Dim lntabela As Integer = 0
        Dim orange = oWord.ActiveDocument.Range(0, 0)
        Dim llfound As Boolean

        With orange.Find

            .Text = "@TABELA_ITENS"
            .Format = False
            .MatchCase = True
            llfound = .Execute() ' ACHOU

        End With

        'Monta a tabela, baseado no DataGridView da Tela de OS
        If llfound Then
            WordTabelaItens("@TABELA_ITENS", oWord, dgvDados)
        End If

        oWord.Visible = True

        If oParam.GerarPDF = True Then
            Dim outputFilename As String
            With oWord

                Try
                    outputFilename = System.IO.Path.ChangeExtension(_documento, "pdf")
                    'oWord.ActiveDocument.SaveAs2(outputFilename, WdExportFormat.wdExportFormatPDF)
                    oWord.ActiveDocument.ExportAsFixedFormat(outputFilename, 17, True)

                    '                ActiveDocument.ExportAsFixedFormat OutputFileName:=
                    '"D:\Workspace\Source\Saida\RELATORIO_OS_20180819125739412.pdf",
                    'ExportFormat:=wdExportFormatPDF, OpenAfterExport:=True, OptimizeFor:=
                    'wdExportOptimizeForPrint, Range:=wdExportAllDocument, From:=1, To:=1,
                    'Item:=wdExportDocumentContent, IncludeDocProps:=True, KeepIRM:=True,
                    'CreateBookmarks:=wdExportCreateNoBookmarks, DocStructureTags:=True,
                    'BitmapMissingFonts:=True, UseISO19005_1:=False

                    'VisualizarArquivo("PDF", outputFilename)
                Catch ex As Exception
                    'TODO: handle exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


            End With

        End If

    End Sub

    Public Sub ReportOSWordPaisagem(ByVal _documento As String, ByVal oParam As DTO.Parametros_report_os, ByVal dgvDados As DataGridView)


        Dim oWord As Word.Application
        oWord = CreateObject("Word.Application")

        oWord.Caption = "MS WORD - SR"
        oWord.Documents.Open(_documento, True)

        If oWord.ActiveWindow.View.SplitSpecial <> wdpanenone Then

            oWord.ActiveWindow.Panes(2).Close()

        End If

        If oWord.ActiveWindow.ActivePane.View.Type = wdnormalview Or
                oWord.ActiveWindow.ActivePane.View.Type = wdoutlineview Or
            oWord.ActiveWindow.ActivePane.View.Type = wdmasterview Then

            oWord.ActiveWindow.ActivePane.View.Type = wdpageview

        End If

        oWord.ActiveWindow.ActivePane.View.SeekView = wdseekcurrentpageheader

        Dim loselection = oWord.ActiveWindow.ActivePane.Selection

        loselection.Find.ClearFormatting()

        '**========== DOCUMENTO =============================================================================================
        '**
        oWord.ActiveWindow.ActivePane.View.SeekView = wdseekmaindocument
        loselection = oWord.ActiveWindow.ActivePane.Selection

        Substitui_Variavel_no_Texto(loselection, "@OS", oParam.OS_Id, "")
        Substitui_Variavel_no_Texto(loselection, "@DATA_OS", oParam.Data, "")
        Substitui_Variavel_no_Texto(loselection, "@RESPONSAVEL", oParam.Responsavel, "")
        Substitui_Variavel_no_Texto(loselection, "@LOJA", oParam.Loja, "")
        Substitui_Variavel_no_Texto(loselection, "@FORNECEDOR", oParam.Fornecedor, "")
        Substitui_Variavel_no_Texto(loselection, "@NF", oParam.NF, "")
        Substitui_Variavel_no_Texto(loselection, "@SERIE", oParam.SerieNF, "")
        Substitui_Variavel_no_Texto(loselection, "@EMISSAO", oParam.Emissao, "")

        Dim lntabela As Integer = 0
        Dim orange = oWord.ActiveDocument.Range(0, 0)
        Dim llfound As Boolean

        With orange.Find

            .Text = "@TABELA_ITENS"
            .Format = False
            .MatchCase = True
            llfound = .Execute() ' ACHOU

        End With

        'Monta a tabela, baseado no DataGridView da Tela de OS
        If llfound Then
            WordTabelaItensPaisagem("@TABELA_ITENS", oWord, dgvDados)
        End If

        oWord.Visible = True

        If oParam.GerarPDF = True Then
            Dim outputFilename As String
            With oWord

                Try
                    outputFilename = System.IO.Path.ChangeExtension(_documento, "pdf")
                    'oWord.ActiveDocument.SaveAs2(outputFilename, WdExportFormat.wdExportFormatPDF)
                    oWord.ActiveDocument.ExportAsFixedFormat(outputFilename, 17, True)
                    'VisualizarArquivo("PDF", outputFilename)
                Catch ex As Exception
                    'TODO: handle exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


            End With

        End If

    End Sub

    Public Sub Substitui_Variavel_no_Texto(ByRef toSelection As Object, ByVal tcVariavel As String, _
                                           ByVal tcTexto As String, ByVal tcTexto2 As String)

        tcTexto = Trim(tcTexto)
        tcTexto2 = Trim(tcTexto2)

        Dim lcVariavel2 As String

        lcVariavel2 = Replace(tcVariavel, "@", "@_")

        '** Tenho que analisar se o tcTexto tem mais de 250 caracteres
        '** Se tiver, tenho que quebrar em partes de 250 chars.
        Dim lnMax As Integer = 250, lnLen As Integer, lnTam As Integer
        lnLen = Len(IIf(String.IsNullOrEmpty(tcTexto), "", tcTexto))

        lnTam = Int(lnLen / lnMax) + IIf(lnLen Mod lnMax > 0, 1, 0)

        If lnLen > lnMax Then

            Dim lcVars As String = ""
            Dim lnPos As Integer = 1
            Dim laPartes(lnTam, 2)
            Dim lcNovaVar As String = ""

            For i = 1 To lnTam

                lcNovaVar = "@Xpto" + Trim(CStr(i)).PadLeft(3)
                lcVars = lcVars + lcNovaVar

                laPartes(i, 0) = lcNovaVar
                laPartes(i, 1) = Mid(tcTexto, lnPos, lnMax)

                lnPos = lnPos + lnMax

            Next i

            toSelection.Find.ClearFormatting()

            toSelection.Find.Replacement.ClearFormatting()

            toSelection.Find.Text = tcVariavel

            toSelection.Find.Replacement.Text = lcVars

            toSelection.Find.Forward = 1
            toSelection.Find.Wrap = 1

            toSelection.Find.MatchWildcards = 0

            toSelection.Find.Execute(, , , , , , , , , , 2)



            toSelection.Find.ClearFormatting()

            toSelection.Find.Replacement.ClearFormatting()

            toSelection.Find.Text = lcVariavel2

            toSelection.Find.Replacement.Text = lcVars

            toSelection.Find.Forward = 1
            toSelection.Find.Wrap = 1

            toSelection.Find.MatchWildcards = 0

            toSelection.Find.Execute(, , , , , , , , , , 2)


            For i = 1 To lnTam

                toSelection.Find.ClearFormatting()

                toSelection.Find.Replacement.ClearFormatting()

                toSelection.Find.Text = laPartes(i, 0)

                toSelection.Find.Replacement.Text = laPartes(i, 1)

                toSelection.Find.Forward = 1
                toSelection.Find.Wrap = 1

                toSelection.Find.MatchWildcards = 0

                toSelection.Find.Execute(, , , , , , , , , , 2)

            Next i

        Else

            toSelection.Find.ClearFormatting()

            toSelection.Find.Replacement.ClearFormatting()

            toSelection.Find.Text = tcVariavel

            toSelection.Find.Replacement.Text = IIf(Not String.IsNullOrEmpty(tcTexto), tcTexto, tcTexto2)

            toSelection.Find.Forward = 1
            toSelection.Find.Wrap = 1

            toSelection.Find.MatchWildcards = 0

            toSelection.Find.Execute(, , , , , , , , , , 2)


            toSelection.Find.ClearFormatting()

            toSelection.Find.Replacement.ClearFormatting()

            toSelection.Find.Text = lcVariavel2

            toSelection.Find.Replacement.Text = StrConv(IIf(Not String.IsNullOrEmpty(tcTexto), tcTexto, tcTexto2), VbStrConv.ProperCase)

            toSelection.Find.Forward = 1
            toSelection.Find.Wrap = 1

            toSelection.Find.MatchWildcards = 0

            toSelection.Find.Execute(, , , , , , , , , , 2)


        End If

    End Sub

    Public Sub WordTabelaItens(ByVal tcnometab As String, ByRef lowordapplication As Object, ByVal dgvDados As DataGridView)

        '**** INSERIR TABELAS COM OS ITENS UMA POR ITEM
        Dim otable As Object
        Dim llfound As Boolean

        Dim wdalignparagraphleft As Integer, wdalignparagraphcenter As Integer, wdalignparagraphright As Integer
        wdalignparagraphleft = 0
        wdalignparagraphcenter = 1
        wdalignparagraphright = 2
        Dim cr As String = Chr(13)

        Dim orange As Object
        orange = lowordapplication.activedocument.RANGE(0, 0)

        With orange.FIND
            .TEXT = tcnometab
            .FORMAT = False
            .matchcase = True
            llfound = .execute()
        End With

        If llfound Then
            orange.TEXT = ""

            '* Set up a font for the table
            orange.FONT.NAME = "Arial Narrow"
            orange.FONT.SIZE = 7
            orange.paragraphformat.ALIGNMENT = wdalignparagraphleft
            orange.insertafter(cr)

            'Quantidade de linhas do grid + 1 linha de header das colunas
            Dim MTOTLI As Integer = dgvDados.RowCount + 1
            otable = lowordapplication.activedocument.TABLES.ADD(orange, MTOTLI, 1)

            Dim lnl As Integer = 1
            'Colunas do DataGridView
            '==========================
            '0 editar
            '1 os n
            '*2 item id
            '3 id equipamento
            '*4 descricao equipamento
            '*5 serie #
            '*6 modelo
            '*7 prev retorno
            '8 descr defeito
            '9 conserto ok? 
            '10 id tipo equip
            '11 descr tipo equip
            '*12 garantia
            'total 6 cols

            'Monta o cabeçalho da Tabela
            With otable     '&& CABEÇALHO

                .cell(lnl, 1).SPLIT(1, 7)

                .cell(lnl, 1).RANGE.FONT.SIZE = 7
                .cell(lnl, 1).RANGE.insertafter("Item #")
                .cell(lnl, 1).WIDTH = lowordapplication.inchestopoints(0.35)
                .cell(lnl, 1).RANGE.shading.texture = 150

                .cell(lnl, 2).RANGE.FONT.SIZE = 7
                .cell(lnl, 2).RANGE.insertafter("Descrição")
                .cell(lnl, 2).WIDTH = lowordapplication.inchestopoints(2.5) '&&(4.0)
                .cell(lnl, 2).RANGE.shading.texture = 150

                .cell(lnl, 3).RANGE.FONT.SIZE = 7
                .cell(lnl, 3).RANGE.insertafter("Série #")
                .cell(lnl, 3).WIDTH = lowordapplication.inchestopoints(1.15)
                .cell(lnl, 3).RANGE.shading.texture = 150

                .cell(lnl, 4).RANGE.FONT.SIZE = 7
                .cell(lnl, 4).RANGE.insertafter("Descrição do Defeito")
                .cell(lnl, 4).WIDTH = lowordapplication.inchestopoints(1.5)
                .cell(lnl, 4).RANGE.shading.texture = 150

                .cell(lnl, 5).RANGE.FONT.SIZE = 7
                .cell(lnl, 5).RANGE.insertafter("Modelo")
                .cell(lnl, 5).WIDTH = lowordapplication.inchestopoints(0.9)
                .cell(lnl, 5).RANGE.shading.texture = 150

                .cell(lnl, 6).RANGE.FONT.SIZE = 7
                .cell(lnl, 6).RANGE.insertafter("Prev. Retorno")
                .cell(lnl, 6).WIDTH = lowordapplication.inchestopoints(0.65)
                .cell(lnl, 6).RANGE.shading.texture = 150

                .cell(lnl, 7).RANGE.FONT.SIZE = 7
                .cell(lnl, 7).RANGE.insertafter("Garantia")
                .cell(lnl, 7).WIDTH = lowordapplication.inchestopoints(0.45)
                .cell(lnl, 7).RANGE.shading.texture = 150

            End With

            'Percorre todo Grid Linha a Linha
            Dim colunas(7) As String
            Dim alinhamento(7) As Integer
            Dim tamanho(7) As Double

            'Define os alinhamentos das colunas
            alinhamento(0) = wdalignparagraphright
            alinhamento(1) = wdalignparagraphleft
            alinhamento(2) = wdalignparagraphleft
            alinhamento(3) = wdalignparagraphleft
            alinhamento(4) = wdalignparagraphleft
            alinhamento(5) = wdalignparagraphcenter
            alinhamento(6) = wdalignparagraphcenter

            'define o tamanho das colunas do word
            tamanho(0) = 0.35
            tamanho(1) = 2.5 '1.75
            tamanho(2) = 1.15 '1.25
            tamanho(3) = 1.5 '1.5
            tamanho(4) = 0.9 '1.5
            tamanho(5) = 0.65
            tamanho(6) = 0.45


            lnl = lnl + 1

            For rowIndex = 0 To dgvDados.RowCount - 1
                With otable

                    .cell(lnl, 1).SPLIT(1, 7)
                    colunas(0) = dgvDados.Rows(rowIndex).Cells("item_id").Value.ToString '*2 item id
                    colunas(1) = dgvDados.Rows(rowIndex).Cells("DESC_EQUIPAMENTO").Value.ToString '*4 descricao equipamento
                    colunas(2) = dgvDados.Rows(rowIndex).Cells("serie").Value.ToString '*5 serie #
                    colunas(3) = dgvDados.Rows(rowIndex).Cells("DESC_OCORRENCIA").Value.ToString
                    colunas(4) = dgvDados.Rows(rowIndex).Cells("modelo").Value.ToString '*6 modelo
                    colunas(5) = dgvDados.Rows(rowIndex).Cells("PREVISAO_RETORNO").Value.ToString '*7 prev retorno
                    colunas(6) = IIf(CBool(dgvDados.Rows(rowIndex).Cells("garantia").Value) = True, "X", " ") '*12 garantia

                    For itt = 0 To 6 'Percorre o vetor de colunas
                        If Not String.IsNullOrEmpty(colunas(itt)) Then  '&& Item
                            .cell(lnl, itt + 1).RANGE.FONT.SIZE = 8
                            .cell(lnl, itt + 1).RANGE.paragraphformat.ALIGNMENT = alinhamento(itt)
                            .cell(lnl, itt + 1).RANGE.insertafter(Trim(colunas(itt)))
                            .cell(lnl, itt + 1).WIDTH = lowordapplication.inchestopoints(tamanho(itt)) '&& 1.5
                            .cell(lnl, itt + 1).RANGE.FONT.bold = False
                            '*!*					.Cell(lnL,1).Range.Shading.Texture = 100
                        End If
                    Next itt

                End With

                lnl = lnl + 1
            Next

            otable.BorderS.InsideLineStyle = True
            otable.BorderS.OutsideLineStyle = True


        End If  '&& achou a tabela

    End Sub
    Public Sub WordTabelaItensPaisagem(ByVal tcnometab As String, ByRef lowordapplication As Object, ByVal dgvDados As DataGridView)

        '**** INSERIR TABELAS COM OS ITENS UMA POR ITEM
        Dim otable As Object
        Dim llfound As Boolean

        Dim wdalignparagraphleft As Integer, wdalignparagraphcenter As Integer, wdalignparagraphright As Integer
        wdalignparagraphleft = 0
        wdalignparagraphcenter = 1
        wdalignparagraphright = 2
        Dim cr As String = Chr(13)

        Dim orange As Object
        orange = lowordapplication.activedocument.RANGE(0, 0)

        With orange.FIND
            .TEXT = tcnometab
            .FORMAT = False
            .matchcase = True
            llfound = .execute()
        End With

        If llfound Then
            orange.TEXT = ""

            '* Set up a font for the table
            orange.FONT.NAME = "Arial Narrow"
            orange.FONT.SIZE = 7
            orange.paragraphformat.ALIGNMENT = wdalignparagraphleft
            orange.insertafter(cr)

            'Quantidade de linhas do grid + 1 linha de header das colunas
            Dim MTOTLI As Integer = dgvDados.RowCount + 1
            otable = lowordapplication.activedocument.TABLES.ADD(orange, MTOTLI, 1)

            Dim lnl As Integer = 1
            'Colunas do DataGridView
            '==========================
            '0 editar
            '1 os n
            '*2 item id
            '3 id equipamento
            '*4 descricao equipamento
            '*5 serie #
            '*6 modelo
            '*7 prev retorno
            '8 descr defeito
            '9 conserto ok? 
            '10 id tipo equip
            '11 descr tipo equip
            '*12 garantia
            'total 6 cols

            'Monta o cabeçalho da Tabela
            With otable     '&& CABEÇALHO

                .cell(lnl, 1).SPLIT(1, 7)

                .cell(lnl, 1).RANGE.FONT.SIZE = 7
                .cell(lnl, 1).RANGE.insertafter("Item #")
                .cell(lnl, 1).WIDTH = lowordapplication.inchestopoints(0.5)
                .cell(lnl, 1).RANGE.shading.texture = 150

                .cell(lnl, 2).RANGE.FONT.SIZE = 7
                .cell(lnl, 2).RANGE.insertafter("Descrição")
                .cell(lnl, 2).WIDTH = lowordapplication.inchestopoints(2.75) '&&(4.0)
                .cell(lnl, 2).RANGE.shading.texture = 150

                .cell(lnl, 3).RANGE.FONT.SIZE = 7
                .cell(lnl, 3).RANGE.insertafter("Série #")
                .cell(lnl, 3).WIDTH = lowordapplication.inchestopoints(1.5)
                .cell(lnl, 3).RANGE.shading.texture = 150

                .cell(lnl, 4).RANGE.FONT.SIZE = 7
                .cell(lnl, 4).RANGE.insertafter("Descrição do Defeito")
                .cell(lnl, 4).WIDTH = lowordapplication.inchestopoints(3.5)
                .cell(lnl, 4).RANGE.shading.texture = 150

                .cell(lnl, 5).RANGE.FONT.SIZE = 7
                .cell(lnl, 5).RANGE.insertafter("Modelo")
                .cell(lnl, 5).WIDTH = lowordapplication.inchestopoints(1.25)
                .cell(lnl, 5).RANGE.shading.texture = 150

                .cell(lnl, 6).RANGE.FONT.SIZE = 7
                .cell(lnl, 6).RANGE.insertafter("Prev. Retorno")
                .cell(lnl, 6).WIDTH = lowordapplication.inchestopoints(0.8)
                .cell(lnl, 6).RANGE.shading.texture = 150

                .cell(lnl, 7).RANGE.FONT.SIZE = 7
                .cell(lnl, 7).RANGE.insertafter("Garantia")
                .cell(lnl, 7).WIDTH = lowordapplication.inchestopoints(0.5)
                .cell(lnl, 7).RANGE.shading.texture = 150

            End With

            'Percorre todo Grid Linha a Linha
            Dim colunas(7) As String
            Dim alinhamento(7) As Integer
            Dim tamanho(7) As Double

            'Define os alinhamentos das colunas
            alinhamento(0) = wdalignparagraphright
            alinhamento(1) = wdalignparagraphleft
            alinhamento(2) = wdalignparagraphleft
            alinhamento(3) = wdalignparagraphleft
            alinhamento(4) = wdalignparagraphleft
            alinhamento(5) = wdalignparagraphcenter
            alinhamento(6) = wdalignparagraphcenter

            'define o tamanho das colunas do word
            tamanho(0) = 0.5
            tamanho(1) = 2.75 '1.75
            tamanho(2) = 1.5 '1.25
            tamanho(3) = 3.5 '1.5
            tamanho(4) = 1.25 '1.5
            tamanho(5) = 0.8
            tamanho(6) = 0.5


            lnl = lnl + 1

            For rowIndex = 0 To dgvDados.RowCount - 1
                With otable

                    .cell(lnl, 1).SPLIT(1, 7)
                    colunas(0) = dgvDados.Rows(rowIndex).Cells("item_id").Value.ToString '*2 item id
                    colunas(1) = dgvDados.Rows(rowIndex).Cells("DESC_EQUIPAMENTO").Value.ToString '*4 descricao equipamento
                    colunas(2) = dgvDados.Rows(rowIndex).Cells("serie").Value.ToString '*5 serie #
                    colunas(3) = dgvDados.Rows(rowIndex).Cells("DESC_OCORRENCIA").Value.ToString
                    colunas(4) = dgvDados.Rows(rowIndex).Cells("modelo").Value.ToString '*6 modelo
                    colunas(5) = dgvDados.Rows(rowIndex).Cells("PREVISAO_RETORNO").Value.ToString '*7 prev retorno
                    colunas(6) = IIf(CBool(dgvDados.Rows(rowIndex).Cells("garantia").Value) = True, "X", " ") '*12 garantia

                    For itt = 0 To 6 'Percorre o vetor de colunas
                        If Not String.IsNullOrEmpty(colunas(itt)) Then  '&& Item
                            .cell(lnl, itt + 1).RANGE.FONT.SIZE = 8
                            .cell(lnl, itt + 1).RANGE.paragraphformat.ALIGNMENT = alinhamento(itt)
                            .cell(lnl, itt + 1).RANGE.insertafter(Trim(colunas(itt)))
                            .cell(lnl, itt + 1).WIDTH = lowordapplication.inchestopoints(tamanho(itt)) '&& 1.5
                            .cell(lnl, itt + 1).RANGE.FONT.bold = False
                            '*!*					.Cell(lnL,1).Range.Shading.Texture = 100
                        End If
                    Next itt

                End With

                lnl = lnl + 1
            Next

            otable.BorderS.InsideLineStyle = True
            otable.BorderS.OutsideLineStyle = True


        End If  '&& achou a tabela

    End Sub

End Module
