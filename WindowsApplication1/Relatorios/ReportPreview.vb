'\\Classe para imprimir DataGridView
'\\CodeProject: https://www.codeproject.com/Articles/11382/A-class-to-print-and-print-preview-a-DataGrid-or
'\\
Imports System.Drawing.Printing
Public Class ReportPreview
    Inherits System.Windows.Forms.Form

    Private removeuColuna As Boolean = False
    Friend WithEvents Cmb_Impressoras As ComboBox
    Friend WithEvents btn_carregar As Button
#Region "Private members"
    Private GridPrinter As DataGridPrinter
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal _gridDados As DataGridView, oParms As DTO.ParametrosReportPreview)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        Call PopulateColourList(Me.ComboBox_ColourBodyline)
        Call PopulateColourList(Me.ComboBox_ColourFooterLine)
        Call PopulateColourList(Me.ComboBox_ColourHeaderLine)

        Call PopulateBrushList(Me.ComboBox_EvenBrush)
        Call PopulateBrushList(Me.ComboBox_FooterBrush)
        Call PopulateBrushList(Me.ComboBox_HeaderBrush)
        Call PopulateBrushList(Me.ComboBox_OddRowBrush)
        Call PopulateBrushList(Me.ComboBox_ColumnHeaderBrush)

        '\\ Populate teh data grids with some bumpf
        '\\ Recebe o grid passado como parametro para a tela e converte em DataTable
        Dim MyTable As New DataTable
        MyTable = TryCast(_gridDados.DataSource, DataTable)
        'MyTable.Columns.Add(New DataColumn("Team", GetType(String)))
        'MyTable.Columns.Add(New DataColumn("Played", GetType(Integer)))
        'MyTable.Columns.Add(New DataColumn("Goals For", GetType(Integer)))
        'MyTable.Columns.Add(New DataColumn("Goals Against", GetType(Integer)))
        'MyTable.Columns.Add(New DataColumn("Points", GetType(Integer)))


        'Me.DataGrid1.DataSource = MyTable
        Me.DataGridView1.DataSource = MyTable
        Me.dgvDadosSaida.DataSource = MyTable 'Backup do grid original
        CarregaColunasGrid()
        Me.TextBox1.Text = oParms.Titulo
        CarregaListaImpressorasInstaladas()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents MainMenu_App As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem_File As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_File_PageSetup As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_File_print As System.Windows.Forms.MenuItem
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_HeaderHeightPercentage As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_FooterHeightPercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_InterSectionSpacingPercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_ColourHeaderLine As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_ColourFooterLine As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_ColourBodyline As System.Windows.Forms.ComboBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox_FooterBrush As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_HeaderBrush As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_EvenBrush As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_OddRowBrush As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_ColumnHeaderBrush As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown_PagesAcross As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabControl_GridType As TabControl
    Friend WithEvents TabPage_DataGridView As TabPage
    Friend WithEvents TabPage_DataGrid As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgvColunas As DataGridView
    Friend WithEvents TabPageSaida As TabPage
    Friend WithEvents dgvDadosSaida As DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreview))
        Me.MainMenu_App = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem_File = New System.Windows.Forms.MenuItem()
        Me.MenuItem_File_PageSetup = New System.Windows.Forms.MenuItem()
        Me.MenuItem_File_print = New System.Windows.Forms.MenuItem()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_InterSectionSpacingPercent = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown_FooterHeightPercent = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown_HeaderHeightPercentage = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_ColourBodyline = New System.Windows.Forms.ComboBox()
        Me.ComboBox_ColourFooterLine = New System.Windows.Forms.ComboBox()
        Me.ComboBox_ColourHeaderLine = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_ColumnHeaderBrush = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox_EvenBrush = New System.Windows.Forms.ComboBox()
        Me.ComboBox_OddRowBrush = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox_FooterBrush = New System.Windows.Forms.ComboBox()
        Me.ComboBox_HeaderBrush = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_PagesAcross = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabControl_GridType = New System.Windows.Forms.TabControl()
        Me.TabPage_DataGrid = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage_DataGridView = New System.Windows.Forms.TabPage()
        Me.dgvColunas = New System.Windows.Forms.DataGridView()
        Me.TabPageSaida = New System.Windows.Forms.TabPage()
        Me.dgvDadosSaida = New System.Windows.Forms.DataGridView()
        Me.btn_carregar = New System.Windows.Forms.Button()
        Me.Cmb_Impressoras = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown_InterSectionSpacingPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_FooterHeightPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_HeaderHeightPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NumericUpDown_PagesAcross, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_GridType.SuspendLayout()
        Me.TabPage_DataGrid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_DataGridView.SuspendLayout()
        CType(Me.dgvColunas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSaida.SuspendLayout()
        CType(Me.dgvDadosSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu_App
        '
        Me.MainMenu_App.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem_File})
        '
        'MenuItem_File
        '
        Me.MenuItem_File.Index = 0
        Me.MenuItem_File.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem_File_PageSetup, Me.MenuItem_File_print})
        Me.MenuItem_File.Text = "&Arquivo"
        '
        'MenuItem_File_PageSetup
        '
        Me.MenuItem_File_PageSetup.Index = 0
        Me.MenuItem_File_PageSetup.Text = "Configuração de &Página"
        '
        'MenuItem_File_print
        '
        Me.MenuItem_File_print.Index = 1
        Me.MenuItem_File_print.Text = "&Imprimir"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 202)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(528, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Data Grid Print Test"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cabeçalho da Página"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_InterSectionSpacingPercent)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_FooterHeightPercent)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_HeaderHeightPercentage)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 56)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alturas das Seções"
        '
        'NumericUpDown_InterSectionSpacingPercent
        '
        Me.NumericUpDown_InterSectionSpacingPercent.Location = New System.Drawing.Point(405, 24)
        Me.NumericUpDown_InterSectionSpacingPercent.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown_InterSectionSpacingPercent.Name = "NumericUpDown_InterSectionSpacingPercent"
        Me.NumericUpDown_InterSectionSpacingPercent.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown_InterSectionSpacingPercent.TabIndex = 5
        Me.NumericUpDown_InterSectionSpacingPercent.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(266, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Espaçamento entre seções"
        '
        'NumericUpDown_FooterHeightPercent
        '
        Me.NumericUpDown_FooterHeightPercent.Location = New System.Drawing.Point(198, 24)
        Me.NumericUpDown_FooterHeightPercent.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_FooterHeightPercent.Name = "NumericUpDown_FooterHeightPercent"
        Me.NumericUpDown_FooterHeightPercent.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown_FooterHeightPercent.TabIndex = 3
        Me.NumericUpDown_FooterHeightPercent.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(142, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rodapé"
        '
        'NumericUpDown_HeaderHeightPercentage
        '
        Me.NumericUpDown_HeaderHeightPercentage.Location = New System.Drawing.Point(69, 24)
        Me.NumericUpDown_HeaderHeightPercentage.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_HeaderHeightPercentage.Name = "NumericUpDown_HeaderHeightPercentage"
        Me.NumericUpDown_HeaderHeightPercentage.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown_HeaderHeightPercentage.TabIndex = 1
        Me.NumericUpDown_HeaderHeightPercentage.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cabeçalho"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox_ColourBodyline)
        Me.GroupBox2.Controls.Add(Me.ComboBox_ColourFooterLine)
        Me.GroupBox2.Controls.Add(Me.ComboBox_ColourHeaderLine)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 56)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cores da Linha de Grade"
        '
        'ComboBox_ColourBodyline
        '
        Me.ComboBox_ColourBodyline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ColourBodyline.Location = New System.Drawing.Point(400, 24)
        Me.ComboBox_ColourBodyline.Name = "ComboBox_ColourBodyline"
        Me.ComboBox_ColourBodyline.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox_ColourBodyline.TabIndex = 10
        '
        'ComboBox_ColourFooterLine
        '
        Me.ComboBox_ColourFooterLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ColourFooterLine.Location = New System.Drawing.Point(236, 24)
        Me.ComboBox_ColourFooterLine.Name = "ComboBox_ColourFooterLine"
        Me.ComboBox_ColourFooterLine.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox_ColourFooterLine.TabIndex = 9
        '
        'ComboBox_ColourHeaderLine
        '
        Me.ComboBox_ColourHeaderLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ColourHeaderLine.Location = New System.Drawing.Point(67, 24)
        Me.ComboBox_ColourHeaderLine.Name = "ComboBox_ColourHeaderLine"
        Me.ComboBox_ColourHeaderLine.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox_ColourHeaderLine.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(355, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Corpo"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(188, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Rodapé"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Cabeçalho"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox_ColumnHeaderBrush)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.ComboBox_EvenBrush)
        Me.GroupBox3.Controls.Add(Me.ComboBox_OddRowBrush)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ComboBox_FooterBrush)
        Me.GroupBox3.Controls.Add(Me.ComboBox_HeaderBrush)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 351)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(536, 56)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cores de Fundo da Grade"
        '
        'ComboBox_ColumnHeaderBrush
        '
        Me.ComboBox_ColumnHeaderBrush.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_ColumnHeaderBrush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ColumnHeaderBrush.Location = New System.Drawing.Point(488, 24)
        Me.ComboBox_ColumnHeaderBrush.Name = "ComboBox_ColumnHeaderBrush"
        Me.ComboBox_ColumnHeaderBrush.Size = New System.Drawing.Size(40, 21)
        Me.ComboBox_ColumnHeaderBrush.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(442, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Colunas"
        '
        'ComboBox_EvenBrush
        '
        Me.ComboBox_EvenBrush.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_EvenBrush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_EvenBrush.Location = New System.Drawing.Point(396, 24)
        Me.ComboBox_EvenBrush.Name = "ComboBox_EvenBrush"
        Me.ComboBox_EvenBrush.Size = New System.Drawing.Size(40, 21)
        Me.ComboBox_EvenBrush.TabIndex = 13
        '
        'ComboBox_OddRowBrush
        '
        Me.ComboBox_OddRowBrush.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_OddRowBrush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_OddRowBrush.Location = New System.Drawing.Point(279, 24)
        Me.ComboBox_OddRowBrush.Name = "ComboBox_OddRowBrush"
        Me.ComboBox_OddRowBrush.Size = New System.Drawing.Size(40, 21)
        Me.ComboBox_OddRowBrush.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(326, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Linhas Pares"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(200, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Linhas Ímpares"
        '
        'ComboBox_FooterBrush
        '
        Me.ComboBox_FooterBrush.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_FooterBrush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_FooterBrush.Location = New System.Drawing.Point(159, 24)
        Me.ComboBox_FooterBrush.Name = "ComboBox_FooterBrush"
        Me.ComboBox_FooterBrush.Size = New System.Drawing.Size(40, 21)
        Me.ComboBox_FooterBrush.TabIndex = 9
        '
        'ComboBox_HeaderBrush
        '
        Me.ComboBox_HeaderBrush.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_HeaderBrush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_HeaderBrush.Location = New System.Drawing.Point(64, 24)
        Me.ComboBox_HeaderBrush.Name = "ComboBox_HeaderBrush"
        Me.ComboBox_HeaderBrush.Size = New System.Drawing.Size(40, 21)
        Me.ComboBox_HeaderBrush.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(112, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Rodapé"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Cabeçalho"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Cmb_Impressoras)
        Me.GroupBox4.Controls.Add(Me.btn_carregar)
        Me.GroupBox4.Controls.Add(Me.NumericUpDown_PagesAcross)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 415)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(536, 65)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Layout da Página"
        '
        'NumericUpDown_PagesAcross
        '
        Me.NumericUpDown_PagesAcross.Location = New System.Drawing.Point(270, 10)
        Me.NumericUpDown_PagesAcross.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_PagesAcross.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_PagesAcross.Name = "NumericUpDown_PagesAcross"
        Me.NumericUpDown_PagesAcross.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown_PagesAcross.TabIndex = 3
        Me.NumericUpDown_PagesAcross.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(24, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(328, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Número mínimo de páginas para dividir as colunas"
        '
        'TabControl_GridType
        '
        Me.TabControl_GridType.Controls.Add(Me.TabPage_DataGrid)
        Me.TabControl_GridType.Controls.Add(Me.TabPage_DataGridView)
        Me.TabControl_GridType.Controls.Add(Me.TabPageSaida)
        Me.TabControl_GridType.Location = New System.Drawing.Point(8, 0)
        Me.TabControl_GridType.Name = "TabControl_GridType"
        Me.TabControl_GridType.SelectedIndex = 0
        Me.TabControl_GridType.Size = New System.Drawing.Size(536, 179)
        Me.TabControl_GridType.TabIndex = 7
        '
        'TabPage_DataGrid
        '
        Me.TabPage_DataGrid.Controls.Add(Me.DataGridView1)
        Me.TabPage_DataGrid.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_DataGrid.Name = "TabPage_DataGrid"
        Me.TabPage_DataGrid.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_DataGrid.Size = New System.Drawing.Size(528, 153)
        Me.TabPage_DataGrid.TabIndex = 0
        Me.TabPage_DataGrid.Text = "Dados"
        Me.TabPage_DataGrid.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(522, 147)
        Me.DataGridView1.TabIndex = 2
        '
        'TabPage_DataGridView
        '
        Me.TabPage_DataGridView.Controls.Add(Me.dgvColunas)
        Me.TabPage_DataGridView.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_DataGridView.Name = "TabPage_DataGridView"
        Me.TabPage_DataGridView.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_DataGridView.Size = New System.Drawing.Size(528, 153)
        Me.TabPage_DataGridView.TabIndex = 1
        Me.TabPage_DataGridView.Text = "Seleciona Colunas"
        Me.TabPage_DataGridView.ToolTipText = "This is the newer grid control (post VS 2008)"
        Me.TabPage_DataGridView.UseVisualStyleBackColor = True
        '
        'dgvColunas
        '
        Me.dgvColunas.AllowUserToAddRows = False
        Me.dgvColunas.AllowUserToDeleteRows = False
        Me.dgvColunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColunas.Location = New System.Drawing.Point(7, 3)
        Me.dgvColunas.Name = "dgvColunas"
        Me.dgvColunas.Size = New System.Drawing.Size(517, 144)
        Me.dgvColunas.TabIndex = 0
        '
        'TabPageSaida
        '
        Me.TabPageSaida.Controls.Add(Me.dgvDadosSaida)
        Me.TabPageSaida.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSaida.Name = "TabPageSaida"
        Me.TabPageSaida.Size = New System.Drawing.Size(528, 153)
        Me.TabPageSaida.TabIndex = 2
        Me.TabPageSaida.Text = "Saida"
        Me.TabPageSaida.UseVisualStyleBackColor = True
        '
        'dgvDadosSaida
        '
        Me.dgvDadosSaida.AllowUserToAddRows = False
        Me.dgvDadosSaida.AllowUserToDeleteRows = False
        Me.dgvDadosSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosSaida.Location = New System.Drawing.Point(6, 5)
        Me.dgvDadosSaida.Name = "dgvDadosSaida"
        Me.dgvDadosSaida.ReadOnly = True
        Me.dgvDadosSaida.Size = New System.Drawing.Size(518, 142)
        Me.dgvDadosSaida.TabIndex = 0
        '
        'btn_carregar
        '
        Me.btn_carregar.Location = New System.Drawing.Point(11, 35)
        Me.btn_carregar.Name = "btn_carregar"
        Me.btn_carregar.Size = New System.Drawing.Size(57, 23)
        Me.btn_carregar.TabIndex = 3
        Me.btn_carregar.Text = "Carregar"
        Me.btn_carregar.UseVisualStyleBackColor = True
        '
        'Cmb_Impressoras
        '
        Me.Cmb_Impressoras.FormattingEnabled = True
        Me.Cmb_Impressoras.Location = New System.Drawing.Point(74, 36)
        Me.Cmb_Impressoras.Name = "Cmb_Impressoras"
        Me.Cmb_Impressoras.Size = New System.Drawing.Size(454, 21)
        Me.Cmb_Impressoras.TabIndex = 4
        '
        'ReportPreview
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 492)
        Me.Controls.Add(Me.TabControl_GridType)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Menu = Me.MainMenu_App
        Me.Name = "ReportPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciador de Relatórios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown_InterSectionSpacingPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_FooterHeightPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_HeaderHeightPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.NumericUpDown_PagesAcross, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_GridType.ResumeLayout(False)
        Me.TabPage_DataGrid.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_DataGridView.ResumeLayout(False)
        CType(Me.dgvColunas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSaida.ResumeLayout(False)
        CType(Me.dgvDadosSaida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Menu handlers"

    Private Sub MenuItem_File_PageSetup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem_File_PageSetup.Click
        If removeuColuna = True Then
            GridPrinter = Nothing
        End If

        If GridPrinter Is Nothing Then
            GridPrinter = New DataGridPrinter(Me.DataGridView1)
        End If

        With Me.PageSetupDialog1
            .Document = GridPrinter.PrintDocument
            .ShowDialog()
        End With

    End Sub

    Private Sub MenuItem_File_print_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem_File_print.Click

        '\Pega todos as colunas selecionadas e gera um novo Grid para imprimir (Default - tudo selecionado)
        GeraGridSaida()

        If removeuColuna = True Then
            GridPrinter = Nothing
            removeuColuna = False
            CarregaColunasGrid()
        End If

        If GridPrinter Is Nothing Then
            GridPrinter = New DataGridPrinter(Me.DataGridView1)
        End If

        With GridPrinter
            .HeaderText = Me.TextBox1.Text
            .HeaderHeightPercent = CInt(Me.NumericUpDown_HeaderHeightPercentage.Value)
            .FooterHeightPercent = CInt(Me.NumericUpDown_FooterHeightPercent.Value)
            .InterSectionSpacingPercent = CInt(Me.NumericUpDown_InterSectionSpacingPercent.Value)
            .HeaderPen = New Pen(CType(Me.ComboBox_ColourHeaderLine.SelectedItem, System.Drawing.Color))
            .FooterPen = New Pen(CType(Me.ComboBox_ColourFooterLine.SelectedItem, System.Drawing.Color))
            .GridPen = New Pen(CType(Me.ComboBox_ColourBodyline.SelectedItem, System.Drawing.Color))
            .HeaderBrush = CType(Me.ComboBox_HeaderBrush.SelectedItem, Brush)
            .EvenRowBrush = CType(Me.ComboBox_EvenBrush.SelectedItem, Brush)
            .OddRowBrush = CType(Me.ComboBox_OddRowBrush.SelectedItem, Brush)
            .FooterBrush = CType(Me.ComboBox_FooterBrush.SelectedItem, Brush)
            .ColumnHeaderBrush = CType(Me.ComboBox_ColumnHeaderBrush.SelectedItem, Brush)
            .PagesAcross = CInt(Me.NumericUpDown_PagesAcross.Value)
        End With

        With Me.PrintPreviewDialog1
            .Document = GridPrinter.PrintDocument
            .Document.PrinterSettings.PrinterName = Cmb_Impressoras.Text

            If .ShowDialog = DialogResult.OK Then
                GridPrinter.Print()
            End If
        End With
    End Sub

#End Region

#Region "Private methods"
    Private Sub PopulateColourList(ByVal combo As ComboBox)

        combo.Items.Clear()
        combo.Items.Add(System.Drawing.Color.AliceBlue)
        combo.Items.Add(System.Drawing.Color.Aqua)
        combo.Items.Add(System.Drawing.Color.Azure)
        combo.Items.Add(System.Drawing.Color.Beige)
        combo.Items.Add(System.Drawing.Color.Black)
        combo.Items.Add(System.Drawing.Color.Blue)
        combo.Items.Add(System.Drawing.Color.Green)
        combo.Items.Add(System.Drawing.Color.Red)
        combo.SelectedIndex = 0
    End Sub

    Private Sub PopulateBrushList(ByVal Combo As ComboBox)
        Combo.Items.Clear()
        Combo.Items.Add(System.Drawing.Brushes.White)
        Combo.Items.Add(System.Drawing.Brushes.Beige)
        Combo.Items.Add(System.Drawing.Brushes.Bisque)
        Combo.Items.Add(System.Drawing.Brushes.BlanchedAlmond)
        Combo.Items.Add(System.Drawing.Brushes.Blue)
        Combo.Items.Add(System.Drawing.Brushes.BlueViolet)
        Combo.Items.Add(System.Drawing.Brushes.Brown)
        Combo.Items.Add(System.Drawing.Brushes.BurlyWood)
        Combo.Items.Add(System.Drawing.Brushes.CadetBlue)
        Combo.Items.Add(System.Drawing.Brushes.Chartreuse)
        Combo.Items.Add(System.Drawing.Brushes.Chocolate)
        Combo.Items.Add(System.Drawing.Brushes.Coral)
        Combo.Items.Add(System.Drawing.Brushes.CornflowerBlue)
        Combo.Items.Add(System.Drawing.Brushes.Cornsilk)
        Combo.Items.Add(System.Drawing.Brushes.Crimson)
        Combo.Items.Add(System.Drawing.Brushes.Cyan)
        Combo.SelectedIndex = 0
    End Sub
#End Region
    Private Sub GeraGridSaida()
        'Restabelece o Default
        DataGridView1.DataSource = dgvDadosSaida.DataSource
        RemoveColunasNaoSelecionadas()
    End Sub

    Private Sub RemoveColunasNaoSelecionadas()
        Try
            removeuColuna = False
            Dim MyTable1 As New DataTable
            MyTable1 = TryCast(Me.DataGridView1.DataSource, DataTable)

            'Me.DataGridView1.DataSource = MyTable

            For Each row As DataGridViewRow In dgvColunas.Rows

                If Not row.IsNewRow Then

                    If row.Cells(0).Value = False Then
                        'datagridview1.AlternatingRowsDefaultCellStyle((row.Cells(1).Value)
                        'DataGridView1.Columns(row.Cells(1).Value).visible = False
                        'DataGridView1.Columns.Remove(row.Cells(1).Value)
                        'DataGridView1.Columns.Remove(DataGridView1.Columns(row.Index).Name)

                        '\- Não da para remover só a coluna do Grid, porque dai nao atualiza o DataTable
                        '\- o correto é eliminar a coluna do DataTable e depois setar novamente o Datasource do Grid
                        MyTable1.Columns.Remove(row.Cells(1).Value)

                        'Reseta o Grid de Saida
                        removeuColuna = True
                    End If

                End If

            Next
            Me.DataGridView1.DataSource = MyTable1
        Catch ex As Exception
            MessageBox.Show("Erro ao remover: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ComboBox_EvenBrush_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox_EvenBrush.DrawItem
        e.Graphics.FillRectangle(CType(ComboBox_EvenBrush.Items(e.Index), Brush), e.Bounds)
        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, e.Bounds)
    End Sub


    Private Sub ComboBox_FooterBrush_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox_FooterBrush.DrawItem
        e.Graphics.FillRectangle(CType(ComboBox_FooterBrush.Items(e.Index), Brush), e.Bounds)
        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, e.Bounds)
    End Sub


    Private Sub ComboBox_OddRowBrush_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox_OddRowBrush.DrawItem

        e.Graphics.FillRectangle(CType(ComboBox_OddRowBrush.Items(e.Index), Brush), e.Bounds)
        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, e.Bounds)

    End Sub


    Private Sub ComboBox_HeaderBrush_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox_HeaderBrush.DrawItem
        e.Graphics.FillRectangle(CType(ComboBox_HeaderBrush.Items(e.Index), Brush), e.Bounds)
        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, e.Bounds)
    End Sub


    Private Sub ComboBox_ColumnHeaderBrush_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox_ColumnHeaderBrush.DrawItem
        e.Graphics.FillRectangle(CType(ComboBox_ColumnHeaderBrush.Items(e.Index), Brush), e.Bounds)
        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, e.Bounds)
    End Sub

    Private Sub MenuItem_Source_DataGrid_Click(sender As Object, e As EventArgs)
        GridPrinter = New DataGridPrinter(Me.DataGridView1)
        'MenuItem_Source_DataGrid.Checked = True
        'MenuItem_Source_DataGridView.Checked = False
        Me.TabControl_GridType.SelectedIndex = 0
    End Sub

    Private Sub MenuItem_Source_DataGridView_Click(sender As Object, e As EventArgs)
        GridPrinter = New DataGridPrinter(Me.DataGridView1)
        'MenuItem_Source_DataGrid.Checked = False
        'MenuItem_Source_DataGridView.Checked = True
        Me.TabControl_GridType.SelectedIndex = 1
    End Sub

    Private Sub CarregaColunasGrid()

        Dim linha As New ArrayList()
        Try

            For Each coluna As DataGridViewColumn In Me.DataGridView1.Columns

                linha.Add(New DTO.ColunasImpressao(True, coluna.Name))

            Next
            dgvColunas.DataSource = linha

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar colunas: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try


    End Sub

    Private Sub btn_carregar_Click(sender As Object, e As EventArgs) Handles btn_carregar.Click
        CarregaListaImpressorasInstaladas()
    End Sub

    Private Sub CarregaListaImpressorasInstaladas()
        Dim v_total, v_cont, v_item As Integer
        Dim pd As PrintDocument = New PrintDocument
        Try

            'retornar o numero total de impressoras instaladas
            v_total = pd.PrinterSettings.InstalledPrinters.Count

            'varre todas as impressoas instaladas adicionando-as ao combobox 
            Me.Cmb_Impressoras.Items.Clear()

            With pd.PrinterSettings.InstalledPrinters
                For v_cont = 0 To v_total - 1
                    Me.Cmb_Impressoras.Items.Add(.Item(v_cont))
                Next
            End With

            'seleciona o primeiro item
            Me.Cmb_Impressoras.SelectedIndex = (v_item)
        Catch ex As Exception

            'exibe mensagem de erro cajo aconteça ao inesperado
            MessageBox.Show("Erro de Impressão " + ex.Message)
        Finally

            'libera da memória
            pd.Dispose()
        End Try

    End Sub
End Class


