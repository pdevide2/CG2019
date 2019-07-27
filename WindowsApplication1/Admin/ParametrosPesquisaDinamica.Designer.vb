<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParametrosPesquisaDinamica
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParametrosPesquisaDinamica))
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.PesqFK1 = New WinCG.PesqFK()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(9, 41)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(971, 310)
        Me.dgvDados.TabIndex = 38
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(957, 390)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(23, 23)
        Me.btnSair.TabIndex = 39
        Me.btnSair.Text = " "
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(928, 390)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(23, 23)
        Me.btnSalvar.TabIndex = 40
        Me.btnSalvar.Text = " "
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(899, 390)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(23, 23)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.Text = " "
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(870, 390)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(23, 23)
        Me.btnModificar.TabIndex = 42
        Me.btnModificar.Text = " "
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(826, 390)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(34, 23)
        Me.btnExcel.TabIndex = 44
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'PesqFK1
        '
        Me.PesqFK1.CampoDesc = Nothing
        Me.PesqFK1.CampoId = Nothing
        Me.PesqFK1.ColunasFiltro = Nothing
        Me.PesqFK1.LabelBuscaDesc = Nothing
        Me.PesqFK1.LabelBuscaId = Nothing
        Me.PesqFK1.LabelPesqFK = Nothing
        Me.PesqFK1.ListaCampos = Nothing
        Me.PesqFK1.Location = New System.Drawing.Point(12, 12)
        Me.PesqFK1.Name = "PesqFK1"
        Me.PesqFK1.ObjModelFk = Nothing
        Me.PesqFK1.PosValida = False
        Me.PesqFK1.Size = New System.Drawing.Size(631, 25)
        Me.PesqFK1.Tabela = Nothing
        Me.PesqFK1.TabIndex = 45
        Me.PesqFK1.TituloTela = Nothing
        Me.PesqFK1.View = Nothing
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 361)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(269, 20)
        Me.TextBox1.TabIndex = 46
        '
        'ParametrosPesquisaDinamica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PesqFK1)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.dgvDados)
        Me.Name = "ParametrosPesquisaDinamica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametrização de Pesquisa Dinamica dos Cadastros"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents PesqFK1 As WinCG.PesqFK
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
