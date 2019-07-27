Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Reflection
Public Class rptEstoqueGeralEquipamentoPorLoja

    Private _filtroChart As String
    Public Property FiltroChart() As String
        Get
            Return _filtroChart
        End Get
        Set(ByVal value As String)
            _filtroChart = value
        End Set
    End Property

    Private _cmdSQLChart As String
    Public Property ComandoSQLChart() As String
        Get
            Return _cmdSQLChart
        End Get
        Set(ByVal value As String)
            _cmdSQLChart = value
        End Set
    End Property

    Private _ComEstoque As String
    Public Property FiltroComEstoque() As String
        Get
            Return _ComEstoque
        End Get
        Set(ByVal value As String)
            _ComEstoque = value
        End Set
    End Property

    Private Sub rptEstoqueGeralChipPorLoja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "coluna"
        ComboBox2.Text = "Excel"
        PreencheComboCorFundo()

        Inicio()

    End Sub

    Private Sub Inicio()
        Dim comandoSQLGrid As String
        Dim iqq As Integer = 0

        comandoSQLGrid = "exec spRpt_EstoqueEquipamentoTotalPorLoja"

        FormataGrid(comandoSQLGrid)


        FormataChart()

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        FormataChart()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        FormataChart()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        FormataChart()
    End Sub

    Private Sub PreencheComboCorFundo()
        ComboBox3.Items.Clear()
        BindSysColors()
    End Sub
    Private Sub BindSysColors()
        'binding combobox with systemcolor vaues
        'assign combobox drawmode
        ComboBox3.DrawMode = DrawMode.OwnerDrawFixed
        ComboBox3.ItemHeight = 20
        Dim sysType As Type = GetType(System.Drawing.SystemColors)
        For Each prop As PropertyInfo In sysType.GetProperties()
            If prop.PropertyType Is GetType(System.Drawing.Color) Then
                ComboBox3.Items.Add(prop.Name)
            End If
        Next
    End Sub

    Private Sub ComboBox3_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox3.DrawItem
        'Drawing the itemsinto the combobox.
        'exit if there is no item
        If e.Index = -1 Then
            Exit Sub
        End If
        'declare a colorbrush
        Dim sysBrush As Brush = New SolidBrush(Color.FromName(DirectCast(ComboBox3.Items(e.Index), String)))
        'Drawing rectangles for the color values
        e.Graphics.DrawRectangle(New Pen(Brushes.Black), e.Bounds.Left + 2, e.Bounds.Top + 2, 30, e.Bounds.Height - 5)
        e.Graphics.FillRectangle(sysBrush, e.Bounds.Left + 3, e.Bounds.Top + 3, 29, e.Bounds.Height - 6)
        'Draw the name of the color
        e.Graphics.DrawString(DirectCast(ComboBox3.Items(e.Index), String), ComboBox3.Font, Brushes.Black, 35, e.Bounds.Top + 2)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim cmb As ComboBox = CType(sender, ComboBox)
        'Label1.ForeColor = Color.FromName(cmb.Items(cmb.SelectedIndex))
        Chart1.BackColor = Color.FromName(cmb.Items(cmb.SelectedIndex))
    End Sub

    Private Sub FormataGrid(comandoSQLGrid As String)
        Dim iqq As Integer = 0

        Dim coluna0 As DataGridViewCheckBoxColumn
        Dim coluna1 As DataGridViewTextBoxColumn
        Dim coluna2 As DataGridViewTextBoxColumn
        Dim coluna3 As DataGridViewTextBoxColumn

        'coluna checkbox
        coluna0 = New DataGridViewCheckBoxColumn
        coluna0.HeaderText = "X"
        coluna0.Name = "X"
        coluna0.FlatStyle = FlatStyle.Standard
        coluna0.CellTemplate = New DataGridViewCheckBoxCell()
        coluna0.CellTemplate.Style.BackColor = Color.Beige

        'coluna coluna1
        coluna1 = New DataGridViewTextBoxColumn
        coluna1.HeaderText = "Id Loja"
        coluna1.Name = "ID_LOJA"

        'coluna coluna2
        coluna2 = New DataGridViewTextBoxColumn
        coluna2.HeaderText = "Nome da Loja"
        coluna2.Name = "NOME"

        'coluna coluna3
        coluna3 = New DataGridViewTextBoxColumn
        coluna3.HeaderText = "Qtd. Estoque"
        coluna3.Name = "ESTOQUE"

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {coluna0, coluna1, coluna2, coluna3})

        Popula_Grid(comandoSQLGrid)

        dgvDados.ReadOnly = False
        dgvDados.Enabled = True

        dgvDados.Columns(0).ReadOnly = False ' coluna do Botão

        For ixx = 1 To 3
            dgvDados.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        dgvDados.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados.MultiSelect = False
        'dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados.AllowUserToResizeColumns = False
        dgvDados.EnableHeadersVisualStyles = False

        'Alinhamento dos dados nas colunas do Grid
        dgvDados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvDados.GridColor = Color.Chocolate

    End Sub

    Private Sub Popula_Grid(comandoSQLGrid As String)
        'Faz a Query no banco e retorna uma Lista de Array do Comando SQL
        Dim myRow As ArrayList
        myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQLGrid)

        Dim ixx As Integer
        Dim strLinha As String() 'declara um array de Strings que vai armazenar uma linha de registro toda
        For ixx = 0 To myRow.Count - 1

            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid
            strLinha = {myRow(ixx)(0).ToString, _
                        myRow(ixx)(1).ToString, _
                        myRow(ixx)(2).ToString, _
                        myRow(ixx)(3).ToString}

            dgvDados.Rows.Add(strLinha)

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Marcar()
    End Sub

    Private Sub Marcar()
        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    row.Cells(0).Value = True

                End If

            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao selecionar Equipamento: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Desmarcar()
    End Sub

    Private Sub Desmarcar()
        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    row.Cells(0).Value = False

                End If

            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao selecionar Equipamento: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Inverter()
    End Sub
    Private Sub Inverter()
        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    If row.Cells(0).Value = False Then
                        row.Cells(0).Value = True
                    Else
                        row.Cells(0).Value = False
                    End If

                End If

            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao selecionar Equipamento: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormataChart()
    End Sub

    Private Sub AtualizarQuery()
        Me.FiltroComEstoque = "@COM_ESTOQUE = " & IIf(chkEstoque.Checked = True, "1", "NULL")
        Me.FiltroChart = String.Empty
        Dim s1 As String = ""

        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    If row.Cells(0).Value = True Then 'Verifica se o checkbox está clicado

                        s1 += row.Cells(1).Value.ToString & ","

                    End If

                End If

            Next

            If Not String.IsNullOrEmpty(s1) Then
                s1 = Mid(s1, 1, Len(s1) - 1)
                If Not InStr(1, s1, ",") > 0 Then
                    Me.FiltroChart = "@CLICADOS = '-1' "
                Else
                    Me.FiltroChart = "@CLICADOS = '" & s1 & "'"
                End If

            Else
                Me.FiltroChart = "@CLICADOS = '-1' "
            End If

            Me.ComandoSQLChart = "exec spRpt_EstoqueEquipamentoTotalPorLoja " & Me.FiltroComEstoque & ", " & Me.FiltroChart
            'MessageBox.Show(Me.ComandoSQLChart, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Catch ex As Exception
            MessageBox.Show("Erro ao selecionar Equipamento: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub
    Private Sub FormataChart()

        Dim _tipo_grafico As String, _3D As Boolean, _cor As String

        _tipo_grafico = ComboBox1.Text
        _3D = IIf(CheckBox1.Checked = True, True, False)
        _cor = ComboBox2.Text

        Dim myRow As ArrayList
        Dim iqq As Integer = 0

        'Atualiza os filtros e a propriedade Me.ComandoSQLChart
        AtualizarQuery()

        myRow = BLL.GlobalBLL.PesquisarFkListaBLL(Me.ComandoSQLChart)

        Dim ixx As Integer = 0
        Dim tot As Integer = myRow.Count - 1

        If tot = 0 Then
            Exit Sub
        End If

        Dim yEstoque(tot) As Integer
        Dim xLoja(tot) As String

        While ixx <= tot
            xLoja(ixx) = myRow(ixx)(2).ToString
            yEstoque(ixx) = myRow(ixx)(3)
            ixx += 1
        End While

        With Chart1
            'define o tipo de gráfico
            If _tipo_grafico = "barra" Then
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
            End If
            If _tipo_grafico = "bolha" Then
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
            End If
            If _tipo_grafico = "coluna" Then
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
            End If
            If _tipo_grafico = "funil" Then
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Funnel
            End If
            If _tipo_grafico = "linha" Then
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
            End If
            If _tipo_grafico = "pizza" Then
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
            End If
            If _tipo_grafico = "pontos" Then
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
            End If
            If _tipo_grafico = "pirâmide" Then
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
            End If
            If _tipo_grafico = "radar" Then
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Radar
            End If
            '.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
            'define o texto da legenda 

            'define o titulo do eixo y , sua fonte e a cor
            .ChartAreas(0).AxisY.Title = "Estoque (Unidades)"
            .ChartAreas(0).AxisY.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
            .ChartAreas(0).AxisY.TitleForeColor = Color.Red
            'define o titulo do eixo x , sua fonte e a cor
            .ChartAreas(0).AxisX.Title = "Lojas"
            .ChartAreas(0).AxisX.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
            .ChartAreas(0).AxisX.TitleForeColor = Color.ForestGreen
            .ChartAreas(0).AxisX.LabelStyle.TruncatedLabels = False

            .Series(0).LegendText = "Estoque de Equipamento"

            If InStr("pirâmide|funil|pizza", _tipo_grafico) Then
                .Series(0).LegendText = "#VALX"
            End If

            .ChartAreas(0).AxisX.LabelStyle.Font = New Font("Tahoma", 8, FontStyle.Italic)
            .ChartAreas(0).AxisY.LabelStyle.Font = New Font("Tahoma", 8, FontStyle.Italic)

            .ChartAreas(0).AxisX.IsLabelAutoFit = True
            '.ChartAreas(0).AxisX.LabelAutoFitStyle = DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90
            .ChartAreas(0).AxisX.LabelStyle.Enabled = True


            .ChartAreas(0).BackColor = Color.White
            '.ChartAreas(0).AxisX.LabelStyle.Font.Bold = True
            'define a paleta de cores usada

            '.Palette = ChartColorPalette.BrightPastel

            If _cor = "Berry" Then
                .Palette = ChartColorPalette.Berry
            End If

            If _cor = "Bright" Then
                .Palette = ChartColorPalette.Bright
            End If

            If _cor = "BrightPastel" Then
                .Palette = ChartColorPalette.BrightPastel
            End If

            If _cor = "Chocolate" Then
                .Palette = ChartColorPalette.Chocolate
            End If

            If _cor = "EarthTones" Then
                .Palette = ChartColorPalette.EarthTones
            End If

            If _cor = "Excel" Then
                .Palette = ChartColorPalette.Excel
            End If

            If _cor = "Fire" Then
                .Palette = ChartColorPalette.Fire
            End If

            If _cor = "GrayScales" Then
                .Palette = ChartColorPalette.Grayscale
            End If

            If _cor = "Light" Then
                .Palette = ChartColorPalette.Light
            End If

            If _cor = "None" Then
                .Palette = ChartColorPalette.None
            End If

            If _cor = "Pastel" Then
                .Palette = ChartColorPalette.Pastel
            End If

            If _cor = "SeaGreen" Then
                .Palette = ChartColorPalette.SeaGreen
            End If

            If _cor = "SemiTransparent" Then
                .Palette = ChartColorPalette.SemiTransparent
            End If
            .BackColor = Color.AliceBlue

            '.ChartAreas(1).AxisY.LabelStyle.Font = New Font(.ChartAreas(1).AxisY.LabelStyle.Font, FontStyle.Bold)
            '.ChartAreas(0).AxisY2.LabelStyle.Font = New Font(.ChartAreas(0).AxisY2.LabelStyle.Font, FontStyle.Bold)

            '  .ChartAreas(0).AxisY.LabelStyle.Font = New Font("Trebuchet MS", 2.25F, System.Drawing.FontStyle.Bold)


            'vincula os dados ao gráfico
            .Series(0).Points.DataBindXY(xLoja, yEstoque)

            'exibe os valores nos eixos
            .Series(0).IsValueShownAsLabel = True
            .Series(0).IsVisibleInLegend = True
            '.Series(0).Label = "#VALX = #VALY"
            .Series(0).LabelToolTip = "#VALX = #VALY"
            .Series(0).Label = "#VALY"


            'desabilita a exibição 3D
            .ChartAreas(0).Area3DStyle.Enable3D = _3D


        End With
    End Sub

End Class