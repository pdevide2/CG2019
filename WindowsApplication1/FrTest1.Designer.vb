<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrTest1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrTest1))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alocação")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Áreas")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cargos")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Categorias")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chips")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clientes")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Equipamentos (POS)")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finalidades")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fornecedores")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Itens de Conserto/Reparo")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lojas")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Marcas")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Módulos")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Motivos")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Operadoras")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Peças")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Responsáveis")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sequenciais")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Status")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Status OS")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tabelas/Views")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tipo de Equipamento")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tipo de Serviço")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trânsito")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Usuários")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tabelas/Cadastros", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25})
        Me.Report1 = New FastReport.Report()
        Me.DbCGDataSet1 = New WinCG.dbCGDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TvReport = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PesqFK1 = New WinCG.PesqFK()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCGDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Report1
        '
        Me.Report1.NeedRefresh = False
        Me.Report1.ReportResourceString = resources.GetString("Report1.ReportResourceString")
        Me.Report1.RegisterData(Me.DbCGDataSet1, "DbCGDataSet1")
        '
        'DbCGDataSet1
        '
        Me.DbCGDataSet1.DataSetName = "dbCGDataSet"
        Me.DbCGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(4, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(275, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Imprimir Relatório"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TvReport
        '
        Me.TvReport.ImageIndex = 1
        Me.TvReport.ImageList = Me.ImageList1
        Me.TvReport.Location = New System.Drawing.Point(3, 8)
        Me.TvReport.Name = "TvReport"
        TreeNode1.ImageKey = "printer16.png"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Alocação"
        TreeNode2.Name = "Node2"
        TreeNode2.Text = "Áreas"
        TreeNode3.Name = "Node3"
        TreeNode3.Text = "Cargos"
        TreeNode4.Name = "Node4"
        TreeNode4.Text = "Categorias"
        TreeNode5.Name = "Node5"
        TreeNode5.Text = "Chips"
        TreeNode6.Name = "Node6"
        TreeNode6.Text = "Clientes"
        TreeNode7.Name = "Node7"
        TreeNode7.Text = "Equipamentos (POS)"
        TreeNode8.Name = "Node8"
        TreeNode8.Text = "Finalidades"
        TreeNode9.Name = "Node9"
        TreeNode9.Text = "Fornecedores"
        TreeNode10.Name = "Node10"
        TreeNode10.Text = "Itens de Conserto/Reparo"
        TreeNode11.Name = "Node11"
        TreeNode11.Text = "Lojas"
        TreeNode12.Name = "Node12"
        TreeNode12.Text = "Marcas"
        TreeNode13.Name = "Node13"
        TreeNode13.Text = "Módulos"
        TreeNode14.Name = "Node14"
        TreeNode14.Text = "Motivos"
        TreeNode15.Name = "Node15"
        TreeNode15.Text = "Operadoras"
        TreeNode16.Name = "Node16"
        TreeNode16.Text = "Peças"
        TreeNode17.Name = "Node17"
        TreeNode17.Text = "Responsáveis"
        TreeNode18.Name = "Node18"
        TreeNode18.Text = "Sequenciais"
        TreeNode19.Name = "Node19"
        TreeNode19.Text = "Status"
        TreeNode20.Name = "Node20"
        TreeNode20.Text = "Status OS"
        TreeNode21.Name = "Node21"
        TreeNode21.Text = "Tabelas/Views"
        TreeNode22.Name = "Node22"
        TreeNode22.Text = "Tipo de Equipamento"
        TreeNode23.Name = "Node23"
        TreeNode23.Text = "Tipo de Serviço"
        TreeNode24.Name = "Node24"
        TreeNode24.Text = "Trânsito"
        TreeNode25.Name = "Node25"
        TreeNode25.Text = "Usuários"
        TreeNode26.Name = "Node0"
        TreeNode26.Text = "Tabelas/Cadastros"
        Me.TvReport.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode26})
        Me.TvReport.SelectedImageIndex = 1
        Me.TvReport.Size = New System.Drawing.Size(277, 446)
        Me.TvReport.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "database16.png")
        Me.ImageList1.Images.SetKeyName(1, "printer16.png")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PesqFK1)
        Me.Panel1.Location = New System.Drawing.Point(297, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 446)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(297, 467)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(490, 38)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Limpar Filtros"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PesqFK1
        '
        Me.PesqFK1.CampoDesc = Nothing
        Me.PesqFK1.CampoId = Nothing
        Me.PesqFK1.Clicou = "0"
        Me.PesqFK1.CodigoSelecionado = Nothing
        Me.PesqFK1.ColunasFiltro = Nothing
        Me.PesqFK1.DescricaoSelecionada = Nothing
        Me.PesqFK1.FiltroSQL = Nothing
        Me.PesqFK1.LabelBuscaDesc = Nothing
        Me.PesqFK1.LabelBuscaId = Nothing
        Me.PesqFK1.LabelPesqFK = "Empresa"
        Me.PesqFK1.ListaCampos = Nothing
        Me.PesqFK1.Location = New System.Drawing.Point(13, 24)
        Me.PesqFK1.Name = "PesqFK1"
        Me.PesqFK1.ObjModelFk = Nothing
        Me.PesqFK1.PosValida = False
        Me.PesqFK1.Size = New System.Drawing.Size(400, 25)
        Me.PesqFK1.Tabela = Nothing
        Me.PesqFK1.TabIndex = 0
        Me.PesqFK1.TituloTela = Nothing
        Me.PesqFK1.View = Nothing
        Me.PesqFK1.Visible = False
        '
        'FrTest1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 511)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TvReport)
        Me.Controls.Add(Me.Button1)
        Me.Location = New System.Drawing.Point(20, 30)
        Me.Name = "FrTest1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios de Cadastros e Tabelas Auxiliares"
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCGDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Report1 As FastReport.Report
    Friend WithEvents DbCGDataSet1 As dbCGDataSet
    Friend WithEvents Button1 As Button
    Friend WithEvents TvReport As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PesqFK1 As PesqFK
    Friend WithEvents Button2 As Button
End Class
