<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chip
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblSIMId = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtSIMId = New System.Windows.Forms.TextBox()
        Me.txtCusto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PesqFKOperadora = New WinCG.PesqFK()
        Me.PesqFKFornecedor = New WinCG.PesqFK()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(21, 16)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
        '
        'lblSIMId
        '
        Me.lblSIMId.AutoSize = True
        Me.lblSIMId.Location = New System.Drawing.Point(186, 16)
        Me.lblSIMId.Name = "lblSIMId"
        Me.lblSIMId.Size = New System.Drawing.Size(37, 13)
        Me.lblSIMId.TabIndex = 2
        Me.lblSIMId.Text = "SIMID"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(91, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(60, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtSIMId
        '
        Me.txtSIMId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSIMId.Location = New System.Drawing.Point(227, 12)
        Me.txtSIMId.Name = "txtSIMId"
        Me.txtSIMId.Size = New System.Drawing.Size(221, 20)
        Me.txtSIMId.TabIndex = 3
        '
        'txtCusto
        '
        Me.txtCusto.Location = New System.Drawing.Point(92, 108)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(64, 20)
        Me.txtCusto.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Custo R$"
        '
        'PesqFKOperadora
        '
        Me.PesqFKOperadora.CampoDesc = Nothing
        Me.PesqFKOperadora.CampoId = Nothing
        Me.PesqFKOperadora.Clicou = "0"
        Me.PesqFKOperadora.ColunasFiltro = Nothing
        Me.PesqFKOperadora.LabelBuscaDesc = Nothing
        Me.PesqFKOperadora.LabelBuscaId = Nothing
        Me.PesqFKOperadora.LabelPesqFK = Nothing
        Me.PesqFKOperadora.ListaCampos = Nothing
        Me.PesqFKOperadora.Location = New System.Drawing.Point(21, 42)
        Me.PesqFKOperadora.Name = "PesqFKOperadora"
        Me.PesqFKOperadora.ObjModelFk = Nothing
        Me.PesqFKOperadora.PosValida = False
        Me.PesqFKOperadora.Size = New System.Drawing.Size(425, 25)
        Me.PesqFKOperadora.Tabela = Nothing
        Me.PesqFKOperadora.TabIndex = 14
        Me.PesqFKOperadora.TituloTela = Nothing
        Me.PesqFKOperadora.View = Nothing
        '
        'PesqFKFornecedor
        '
        Me.PesqFKFornecedor.CampoDesc = Nothing
        Me.PesqFKFornecedor.CampoId = Nothing
        Me.PesqFKFornecedor.Clicou = "0"
        Me.PesqFKFornecedor.ColunasFiltro = Nothing
        Me.PesqFKFornecedor.LabelBuscaDesc = Nothing
        Me.PesqFKFornecedor.LabelBuscaId = Nothing
        Me.PesqFKFornecedor.LabelPesqFK = Nothing
        Me.PesqFKFornecedor.ListaCampos = Nothing
        Me.PesqFKFornecedor.Location = New System.Drawing.Point(21, 75)
        Me.PesqFKFornecedor.Name = "PesqFKFornecedor"
        Me.PesqFKFornecedor.ObjModelFk = Nothing
        Me.PesqFKFornecedor.PosValida = False
        Me.PesqFKFornecedor.Size = New System.Drawing.Size(425, 25)
        Me.PesqFKFornecedor.Tabela = Nothing
        Me.PesqFKFornecedor.TabIndex = 15
        Me.PesqFKFornecedor.TituloTela = Nothing
        Me.PesqFKFornecedor.View = Nothing
        '
        'Chip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 186)
        Me.Controls.Add(Me.PesqFKFornecedor)
        Me.Controls.Add(Me.PesqFKOperadora)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCusto)
        Me.Controls.Add(Me.txtSIMId)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblSIMId)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Chip"
        Me.Text = "Cadastro de Chip"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblSIMId, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtSIMId, 0)
        Me.Controls.SetChildIndex(Me.txtCusto, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.PesqFKOperadora, 0)
        Me.Controls.SetChildIndex(Me.PesqFKFornecedor, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblSIMId As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtSIMId As System.Windows.Forms.TextBox
    Friend WithEvents txtCusto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PesqFKOperadora As WinCG.PesqFK
    Friend WithEvents PesqFKFornecedor As WinCG.PesqFK
End Class
