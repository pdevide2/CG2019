<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabelasPesquisaDinamica
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
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.optTipo1 = New System.Windows.Forms.RadioButton()
        Me.optTipo2 = New System.Windows.Forms.RadioButton()
        Me.chkFiltraEmpresa = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(21, 32)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Código"
        '
        'lblDescricao
        '
        Me.lblDescricao.Location = New System.Drawing.Point(21, 63)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(76, 31)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Nome Tabela/View"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(91, 29)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(91, 74)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(322, 20)
        Me.txtDescricao.TabIndex = 4
        Me.txtDescricao.Tag = "Descrição do Cargo"
        '
        'optTipo1
        '
        Me.optTipo1.AutoSize = True
        Me.optTipo1.Location = New System.Drawing.Point(208, 28)
        Me.optTipo1.Name = "optTipo1"
        Me.optTipo1.Size = New System.Drawing.Size(64, 17)
        Me.optTipo1.TabIndex = 5
        Me.optTipo1.TabStop = True
        Me.optTipo1.Text = "(T)abela"
        Me.optTipo1.UseVisualStyleBackColor = True
        '
        'optTipo2
        '
        Me.optTipo2.AutoSize = True
        Me.optTipo2.Location = New System.Drawing.Point(323, 28)
        Me.optTipo2.Name = "optTipo2"
        Me.optTipo2.Size = New System.Drawing.Size(54, 17)
        Me.optTipo2.TabIndex = 6
        Me.optTipo2.TabStop = True
        Me.optTipo2.Text = "(V)iew"
        Me.optTipo2.UseVisualStyleBackColor = True
        '
        'chkFiltraEmpresa
        '
        Me.chkFiltraEmpresa.AutoSize = True
        Me.chkFiltraEmpresa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFiltraEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFiltraEmpresa.Location = New System.Drawing.Point(24, 120)
        Me.chkFiltraEmpresa.Name = "chkFiltraEmpresa"
        Me.chkFiltraEmpresa.Size = New System.Drawing.Size(112, 17)
        Me.chkFiltraEmpresa.TabIndex = 7
        Me.chkFiltraEmpresa.Text = "Filtrar por empresa"
        Me.chkFiltraEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFiltraEmpresa.UseVisualStyleBackColor = True
        '
        'TabelasPesquisaDinamica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 202)
        Me.Controls.Add(Me.chkFiltraEmpresa)
        Me.Controls.Add(Me.optTipo2)
        Me.Controls.Add(Me.optTipo1)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "TabelasPesquisaDinamica"
        Me.Text = "Cadastro de Tabelas/Views  do Sistema para Pesquisa Dinâmica"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblDescricao, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtDescricao, 0)
        Me.Controls.SetChildIndex(Me.optTipo1, 0)
        Me.Controls.SetChildIndex(Me.optTipo2, 0)
        Me.Controls.SetChildIndex(Me.chkFiltraEmpresa, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents optTipo1 As System.Windows.Forms.RadioButton
    Friend WithEvents optTipo2 As System.Windows.Forms.RadioButton
    Friend WithEvents chkFiltraEmpresa As System.Windows.Forms.CheckBox
End Class
