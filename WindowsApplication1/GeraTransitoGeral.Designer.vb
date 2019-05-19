<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeraTransitoGeral
    Inherits modeloCadastro

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeraTransitoGeral))
        Me.PesqFkTransito = New WinCG.PesqFK()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExclui = New System.Windows.Forms.Button()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExcluiPOS = New System.Windows.Forms.Button()
        Me.dgvDados2 = New System.Windows.Forms.DataGridView()
        Me.btnAdicionaPOS = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PesqFkTransito
        '
        Me.PesqFkTransito.CampoDesc = Nothing
        Me.PesqFkTransito.CampoId = Nothing
        Me.PesqFkTransito.Clicou = "0"
        Me.PesqFkTransito.CodigoSelecionado = Nothing
        Me.PesqFkTransito.ColunasFiltro = Nothing
        Me.PesqFkTransito.DescricaoSelecionada = Nothing
        Me.PesqFkTransito.FiltroSQL = Nothing
        Me.PesqFkTransito.LabelBuscaDesc = Nothing
        Me.PesqFkTransito.LabelBuscaId = Nothing
        Me.PesqFkTransito.LabelPesqFK = Nothing
        Me.PesqFkTransito.ListaCampos = Nothing
        Me.PesqFkTransito.Location = New System.Drawing.Point(12, 12)
        Me.PesqFkTransito.Name = "PesqFkTransito"
        Me.PesqFkTransito.ObjModelFk = Nothing
        Me.PesqFkTransito.PosValida = False
        Me.PesqFkTransito.Size = New System.Drawing.Size(432, 25)
        Me.PesqFkTransito.Tabela = Nothing
        Me.PesqFkTransito.TabIndex = 28
        Me.PesqFkTransito.TituloTela = Nothing
        Me.PesqFkTransito.View = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExclui)
        Me.GroupBox1.Controls.Add(Me.btnAdiciona)
        Me.GroupBox1.Controls.Add(Me.dgvDados)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 195)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chip"
        '
        'btnExclui
        '
        Me.btnExclui.Image = CType(resources.GetObject("btnExclui.Image"), System.Drawing.Image)
        Me.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExclui.Location = New System.Drawing.Point(105, 169)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(97, 23)
        Me.btnExclui.TabIndex = 26
        Me.btnExclui.Text = "Excluir"
        Me.btnExclui.UseVisualStyleBackColor = True
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Image = CType(resources.GetObject("btnAdiciona.Image"), System.Drawing.Image)
        Me.btnAdiciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdiciona.Location = New System.Drawing.Point(6, 169)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(97, 23)
        Me.btnAdiciona.TabIndex = 25
        Me.btnAdiciona.Text = "Adicionar"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(6, 19)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(785, 144)
        Me.dgvDados.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExcluiPOS)
        Me.GroupBox2.Controls.Add(Me.dgvDados2)
        Me.GroupBox2.Controls.Add(Me.btnAdicionaPOS)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 252)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(805, 195)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "POS"
        '
        'btnExcluiPOS
        '
        Me.btnExcluiPOS.Image = CType(resources.GetObject("btnExcluiPOS.Image"), System.Drawing.Image)
        Me.btnExcluiPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluiPOS.Location = New System.Drawing.Point(105, 168)
        Me.btnExcluiPOS.Name = "btnExcluiPOS"
        Me.btnExcluiPOS.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluiPOS.TabIndex = 28
        Me.btnExcluiPOS.Text = "Excluir"
        Me.btnExcluiPOS.UseVisualStyleBackColor = True
        '
        'dgvDados2
        '
        Me.dgvDados2.AllowUserToAddRows = False
        Me.dgvDados2.AllowUserToDeleteRows = False
        Me.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados2.Location = New System.Drawing.Point(6, 20)
        Me.dgvDados2.Name = "dgvDados2"
        Me.dgvDados2.ReadOnly = True
        Me.dgvDados2.Size = New System.Drawing.Size(783, 144)
        Me.dgvDados2.TabIndex = 23
        '
        'btnAdicionaPOS
        '
        Me.btnAdicionaPOS.Image = CType(resources.GetObject("btnAdicionaPOS.Image"), System.Drawing.Image)
        Me.btnAdicionaPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionaPOS.Location = New System.Drawing.Point(6, 168)
        Me.btnAdicionaPOS.Name = "btnAdicionaPOS"
        Me.btnAdicionaPOS.Size = New System.Drawing.Size(97, 23)
        Me.btnAdicionaPOS.TabIndex = 27
        Me.btnAdicionaPOS.Text = "Adicionar"
        Me.btnAdicionaPOS.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(730, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GeraTransitoGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 496)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PesqFkTransito)
        Me.Name = "GeraTransitoGeral"
        Me.Text = "Gera Movimento Trânsito"
        Me.Controls.SetChildIndex(Me.PesqFkTransito, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDados2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PesqFkTransito As WinCG.PesqFK
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExclui As Button
    Friend WithEvents btnAdiciona As Button
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExcluiPOS As Button
    Friend WithEvents dgvDados2 As DataGridView
    Friend WithEvents btnAdicionaPOS As Button
    Friend WithEvents Button1 As Button
End Class
