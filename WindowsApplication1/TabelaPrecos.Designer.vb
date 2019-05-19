<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabelaPrecos
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblIdItem = New System.Windows.Forms.Label()
        Me.PesqFKFornecedor = New WinCG.PesqFK()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtTabela = New System.Windows.Forms.TextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(543, 364)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblIdItem)
        Me.TabPage1.Controls.Add(Me.PesqFKFornecedor)
        Me.TabPage1.Controls.Add(Me.txtPreco)
        Me.TabPage1.Controls.Add(Me.txtTabela)
        Me.TabPage1.Controls.Add(Me.lblDescricao)
        Me.TabPage1.Controls.Add(Me.lblCodigo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(535, 338)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Tabela"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblIdItem
        '
        Me.lblIdItem.AutoSize = True
        Me.lblIdItem.Location = New System.Drawing.Point(9, 313)
        Me.lblIdItem.Name = "lblIdItem"
        Me.lblIdItem.Size = New System.Drawing.Size(10, 13)
        Me.lblIdItem.TabIndex = 77
        Me.lblIdItem.Text = "."
        '
        'PesqFKFornecedor
        '
        Me.PesqFKFornecedor.CampoDesc = Nothing
        Me.PesqFKFornecedor.CampoId = Nothing
        Me.PesqFKFornecedor.Clicou = "0"
        Me.PesqFKFornecedor.CodigoSelecionado = Nothing
        Me.PesqFKFornecedor.ColunasFiltro = Nothing
        Me.PesqFKFornecedor.DescricaoSelecionada = Nothing
        Me.PesqFKFornecedor.FiltroSQL = Nothing
        Me.PesqFKFornecedor.LabelBuscaDesc = Nothing
        Me.PesqFKFornecedor.LabelBuscaId = Nothing
        Me.PesqFKFornecedor.LabelPesqFK = "Fornecedor"
        Me.PesqFKFornecedor.ListaCampos = Nothing
        Me.PesqFKFornecedor.Location = New System.Drawing.Point(12, 19)
        Me.PesqFKFornecedor.Name = "PesqFKFornecedor"
        Me.PesqFKFornecedor.ObjModelFk = Nothing
        Me.PesqFKFornecedor.PosValida = False
        Me.PesqFKFornecedor.Size = New System.Drawing.Size(467, 25)
        Me.PesqFKFornecedor.Tabela = Nothing
        Me.PesqFKFornecedor.TabIndex = 76
        Me.PesqFKFornecedor.TituloTela = Nothing
        Me.PesqFKFornecedor.View = Nothing
        '
        'txtPreco
        '
        Me.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreco.Location = New System.Drawing.Point(95, 84)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(96, 20)
        Me.txtPreco.TabIndex = 75
        Me.txtPreco.Tag = "Descrição do Motivo"
        '
        'txtTabela
        '
        Me.txtTabela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTabela.Enabled = False
        Me.txtTabela.Location = New System.Drawing.Point(94, 53)
        Me.txtTabela.MaxLength = 10
        Me.txtTabela.Name = "txtTabela"
        Me.txtTabela.Size = New System.Drawing.Size(74, 20)
        Me.txtTabela.TabIndex = 74
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(18, 87)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(35, 13)
        Me.lblDescricao.TabIndex = 73
        Me.lblDescricao.Text = "Preço"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(18, 56)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 72
        Me.lblCodigo.Text = "Tabela"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnRemove)
        Me.TabPage2.Controls.Add(Me.btnAdd)
        Me.TabPage2.Controls.Add(Me.dgvDados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(535, 338)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Itens Tabela"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(100, 290)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remover"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(19, 290)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Adicionar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToOrderColumns = True
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(19, 19)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(494, 265)
        Me.dgvDados.TabIndex = 0
        '
        'TabelaPrecos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 418)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "TabelaPrecos"
        Me.Text = "Tabela de Precos de Serviços"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PesqFKFornecedor As PesqFK
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents txtTabela As TextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents lblIdItem As Label
End Class
