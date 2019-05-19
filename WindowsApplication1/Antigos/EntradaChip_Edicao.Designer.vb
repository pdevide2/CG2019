<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradaChip_Edicao
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
        Dim ID_ROMANEIOLabel As System.Windows.Forms.Label
        Dim UNIQUE_KEYIDLabel As System.Windows.Forms.Label
        Dim ID_CHIPLabel As System.Windows.Forms.Label
        Dim SIMIDLabel As System.Windows.Forms.Label
        Dim ID_OPERADORALabel As System.Windows.Forms.Label
        Dim DESC_OPERADORALabel As System.Windows.Forms.Label
        Dim QTDLabel As System.Windows.Forms.Label
        Dim VALORLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntradaChip_Edicao))
        Me.txtRomaneio = New System.Windows.Forms.TextBox()
        Me.txtUniqueId = New System.Windows.Forms.TextBox()
        Me.txtIdChip = New System.Windows.Forms.TextBox()
        Me.txtSimId = New System.Windows.Forms.TextBox()
        Me.txtIdOperadora = New System.Windows.Forms.TextBox()
        Me.txtDescOperadora = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnPesqChip = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnEditaSalva = New System.Windows.Forms.Button()
        ID_ROMANEIOLabel = New System.Windows.Forms.Label()
        UNIQUE_KEYIDLabel = New System.Windows.Forms.Label()
        ID_CHIPLabel = New System.Windows.Forms.Label()
        SIMIDLabel = New System.Windows.Forms.Label()
        ID_OPERADORALabel = New System.Windows.Forms.Label()
        DESC_OPERADORALabel = New System.Windows.Forms.Label()
        QTDLabel = New System.Windows.Forms.Label()
        VALORLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ID_ROMANEIOLabel
        '
        ID_ROMANEIOLabel.AutoSize = True
        ID_ROMANEIOLabel.Location = New System.Drawing.Point(20, 19)
        ID_ROMANEIOLabel.Name = "ID_ROMANEIOLabel"
        ID_ROMANEIOLabel.Size = New System.Drawing.Size(68, 13)
        ID_ROMANEIOLabel.TabIndex = 1
        ID_ROMANEIOLabel.Text = "Romaneio nº"
        '
        'UNIQUE_KEYIDLabel
        '
        UNIQUE_KEYIDLabel.AutoSize = True
        UNIQUE_KEYIDLabel.Location = New System.Drawing.Point(209, 19)
        UNIQUE_KEYIDLabel.Name = "UNIQUE_KEYIDLabel"
        UNIQUE_KEYIDLabel.Size = New System.Drawing.Size(62, 13)
        UNIQUE_KEYIDLabel.TabIndex = 3
        UNIQUE_KEYIDLabel.Text = "Unique ID#"
        '
        'ID_CHIPLabel
        '
        ID_CHIPLabel.AutoSize = True
        ID_CHIPLabel.Location = New System.Drawing.Point(48, 45)
        ID_CHIPLabel.Name = "ID_CHIPLabel"
        ID_CHIPLabel.Size = New System.Drawing.Size(40, 13)
        ID_CHIPLabel.TabIndex = 5
        ID_CHIPLabel.Text = "Id Chip"
        '
        'SIMIDLabel
        '
        SIMIDLabel.AutoSize = True
        SIMIDLabel.Location = New System.Drawing.Point(234, 45)
        SIMIDLabel.Name = "SIMIDLabel"
        SIMIDLabel.Size = New System.Drawing.Size(37, 13)
        SIMIDLabel.TabIndex = 7
        SIMIDLabel.Text = "SIMID"
        '
        'ID_OPERADORALabel
        '
        ID_OPERADORALabel.AutoSize = True
        ID_OPERADORALabel.Location = New System.Drawing.Point(19, 71)
        ID_OPERADORALabel.Name = "ID_OPERADORALabel"
        ID_OPERADORALabel.Size = New System.Drawing.Size(69, 13)
        ID_OPERADORALabel.TabIndex = 9
        ID_OPERADORALabel.Text = "Id Operadora"
        '
        'DESC_OPERADORALabel
        '
        DESC_OPERADORALabel.AutoSize = True
        DESC_OPERADORALabel.Location = New System.Drawing.Point(163, 71)
        DESC_OPERADORALabel.Name = "DESC_OPERADORALabel"
        DESC_OPERADORALabel.Size = New System.Drawing.Size(108, 13)
        DESC_OPERADORALabel.TabIndex = 11
        DESC_OPERADORALabel.Text = "Descrição Operadora"
        '
        'QTDLabel
        '
        QTDLabel.AutoSize = True
        QTDLabel.Location = New System.Drawing.Point(26, 97)
        QTDLabel.Name = "QTDLabel"
        QTDLabel.Size = New System.Drawing.Size(62, 13)
        QTDLabel.TabIndex = 13
        QTDLabel.Text = "Quantidade"
        '
        'VALORLabel
        '
        VALORLabel.AutoSize = True
        VALORLabel.Location = New System.Drawing.Point(223, 97)
        VALORLabel.Name = "VALORLabel"
        VALORLabel.Size = New System.Drawing.Size(48, 13)
        VALORLabel.TabIndex = 15
        VALORLabel.Text = "Valor R$"
        '
        'txtRomaneio
        '
        Me.txtRomaneio.Enabled = False
        Me.txtRomaneio.Location = New System.Drawing.Point(93, 16)
        Me.txtRomaneio.Name = "txtRomaneio"
        Me.txtRomaneio.Size = New System.Drawing.Size(106, 20)
        Me.txtRomaneio.TabIndex = 2
        '
        'txtUniqueId
        '
        Me.txtUniqueId.Enabled = False
        Me.txtUniqueId.Location = New System.Drawing.Point(277, 16)
        Me.txtUniqueId.Name = "txtUniqueId"
        Me.txtUniqueId.Size = New System.Drawing.Size(248, 20)
        Me.txtUniqueId.TabIndex = 4
        '
        'txtIdChip
        '
        Me.txtIdChip.Enabled = False
        Me.txtIdChip.Location = New System.Drawing.Point(93, 42)
        Me.txtIdChip.Name = "txtIdChip"
        Me.txtIdChip.Size = New System.Drawing.Size(69, 20)
        Me.txtIdChip.TabIndex = 6
        '
        'txtSimId
        '
        Me.txtSimId.Enabled = False
        Me.txtSimId.Location = New System.Drawing.Point(277, 42)
        Me.txtSimId.Name = "txtSimId"
        Me.txtSimId.Size = New System.Drawing.Size(186, 20)
        Me.txtSimId.TabIndex = 8
        '
        'txtIdOperadora
        '
        Me.txtIdOperadora.Enabled = False
        Me.txtIdOperadora.Location = New System.Drawing.Point(93, 68)
        Me.txtIdOperadora.Name = "txtIdOperadora"
        Me.txtIdOperadora.Size = New System.Drawing.Size(57, 20)
        Me.txtIdOperadora.TabIndex = 10
        '
        'txtDescOperadora
        '
        Me.txtDescOperadora.Enabled = False
        Me.txtDescOperadora.Location = New System.Drawing.Point(277, 68)
        Me.txtDescOperadora.Name = "txtDescOperadora"
        Me.txtDescOperadora.Size = New System.Drawing.Size(248, 20)
        Me.txtDescOperadora.TabIndex = 12
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Enabled = False
        Me.txtQuantidade.Location = New System.Drawing.Point(93, 94)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(81, 20)
        Me.txtQuantidade.TabIndex = 14
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(277, 94)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 16
        '
        'btnPesqChip
        '
        Me.btnPesqChip.Image = CType(resources.GetObject("btnPesqChip.Image"), System.Drawing.Image)
        Me.btnPesqChip.Location = New System.Drawing.Point(166, 41)
        Me.btnPesqChip.Name = "btnPesqChip"
        Me.btnPesqChip.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqChip.TabIndex = 38
        Me.btnPesqChip.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.Location = New System.Drawing.Point(457, 139)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 39
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnEditaSalva
        '
        Me.btnEditaSalva.Image = CType(resources.GetObject("btnEditaSalva.Image"), System.Drawing.Image)
        Me.btnEditaSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditaSalva.Location = New System.Drawing.Point(381, 139)
        Me.btnEditaSalva.Name = "btnEditaSalva"
        Me.btnEditaSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnEditaSalva.TabIndex = 41
        Me.btnEditaSalva.Text = "Novo"
        Me.btnEditaSalva.UseVisualStyleBackColor = True
        '
        'EntradaChip_Edicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 169)
        Me.Controls.Add(Me.btnEditaSalva)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnPesqChip)
        Me.Controls.Add(ID_ROMANEIOLabel)
        Me.Controls.Add(Me.txtRomaneio)
        Me.Controls.Add(UNIQUE_KEYIDLabel)
        Me.Controls.Add(Me.txtUniqueId)
        Me.Controls.Add(ID_CHIPLabel)
        Me.Controls.Add(Me.txtIdChip)
        Me.Controls.Add(SIMIDLabel)
        Me.Controls.Add(Me.txtSimId)
        Me.Controls.Add(ID_OPERADORALabel)
        Me.Controls.Add(Me.txtIdOperadora)
        Me.Controls.Add(DESC_OPERADORALabel)
        Me.Controls.Add(Me.txtDescOperadora)
        Me.Controls.Add(QTDLabel)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(VALORLabel)
        Me.Controls.Add(Me.txtValor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "EntradaChip_Edicao"
        Me.Text = "Entrada de Chip (Visualizar/Editar)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRomaneio As System.Windows.Forms.TextBox
    Friend WithEvents txtUniqueId As System.Windows.Forms.TextBox
    Friend WithEvents txtIdChip As System.Windows.Forms.TextBox
    Friend WithEvents txtSimId As System.Windows.Forms.TextBox
    Friend WithEvents txtIdOperadora As System.Windows.Forms.TextBox
    Friend WithEvents txtDescOperadora As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents btnPesqChip As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnEditaSalva As System.Windows.Forms.Button
End Class
