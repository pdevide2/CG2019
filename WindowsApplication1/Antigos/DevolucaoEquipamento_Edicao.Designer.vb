<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevolucaoEquipamento_Edicao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevolucaoEquipamento_Edicao))
        Me.txtRomaneio = New System.Windows.Forms.TextBox()
        Me.txtUniqueId = New System.Windows.Forms.TextBox()
        Me.txtIdEquipamento = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtDescEquipamento = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnPesqEquipamento = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnEditaSalva = New System.Windows.Forms.Button()
        Me.btnPesqMotivo = New System.Windows.Forms.Button()
        Me.txtDescMotivo = New System.Windows.Forms.TextBox()
        Me.txtIdMotivo = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
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
        ID_ROMANEIOLabel.Location = New System.Drawing.Point(15, 19)
        ID_ROMANEIOLabel.Name = "ID_ROMANEIOLabel"
        ID_ROMANEIOLabel.Size = New System.Drawing.Size(68, 13)
        ID_ROMANEIOLabel.TabIndex = 0
        ID_ROMANEIOLabel.Text = "Romaneio nº"
        '
        'UNIQUE_KEYIDLabel
        '
        UNIQUE_KEYIDLabel.AutoSize = True
        UNIQUE_KEYIDLabel.Location = New System.Drawing.Point(215, 19)
        UNIQUE_KEYIDLabel.Name = "UNIQUE_KEYIDLabel"
        UNIQUE_KEYIDLabel.Size = New System.Drawing.Size(62, 13)
        UNIQUE_KEYIDLabel.TabIndex = 2
        UNIQUE_KEYIDLabel.Text = "Unique ID#"
        '
        'ID_CHIPLabel
        '
        ID_CHIPLabel.AutoSize = True
        ID_CHIPLabel.Location = New System.Drawing.Point(34, 45)
        ID_CHIPLabel.Name = "ID_CHIPLabel"
        ID_CHIPLabel.Size = New System.Drawing.Size(49, 13)
        ID_CHIPLabel.TabIndex = 4
        ID_CHIPLabel.Text = "Id Equip."
        '
        'SIMIDLabel
        '
        SIMIDLabel.AutoSize = True
        SIMIDLabel.Location = New System.Drawing.Point(246, 45)
        SIMIDLabel.Name = "SIMIDLabel"
        SIMIDLabel.Size = New System.Drawing.Size(31, 13)
        SIMIDLabel.TabIndex = 7
        SIMIDLabel.Text = "Série"
        '
        'ID_OPERADORALabel
        '
        ID_OPERADORALabel.AutoSize = True
        ID_OPERADORALabel.Location = New System.Drawing.Point(41, 71)
        ID_OPERADORALabel.Name = "ID_OPERADORALabel"
        ID_OPERADORALabel.Size = New System.Drawing.Size(42, 13)
        ID_OPERADORALabel.TabIndex = 9
        ID_OPERADORALabel.Text = "Modelo"
        '
        'DESC_OPERADORALabel
        '
        DESC_OPERADORALabel.AutoSize = True
        DESC_OPERADORALabel.Location = New System.Drawing.Point(9, 97)
        DESC_OPERADORALabel.Name = "DESC_OPERADORALabel"
        DESC_OPERADORALabel.Size = New System.Drawing.Size(74, 13)
        DESC_OPERADORALabel.TabIndex = 11
        DESC_OPERADORALabel.Text = "Desc. Equipto"
        '
        'QTDLabel
        '
        QTDLabel.AutoSize = True
        QTDLabel.Location = New System.Drawing.Point(21, 125)
        QTDLabel.Name = "QTDLabel"
        QTDLabel.Size = New System.Drawing.Size(62, 13)
        QTDLabel.TabIndex = 13
        QTDLabel.Text = "Quantidade"
        '
        'VALORLabel
        '
        VALORLabel.AutoSize = True
        VALORLabel.Location = New System.Drawing.Point(374, 125)
        VALORLabel.Name = "VALORLabel"
        VALORLabel.Size = New System.Drawing.Size(48, 13)
        VALORLabel.TabIndex = 15
        VALORLabel.Text = "Valor R$"
        '
        'txtRomaneio
        '
        Me.txtRomaneio.Enabled = False
        Me.txtRomaneio.Location = New System.Drawing.Point(87, 16)
        Me.txtRomaneio.Name = "txtRomaneio"
        Me.txtRomaneio.Size = New System.Drawing.Size(106, 20)
        Me.txtRomaneio.TabIndex = 1
        '
        'txtUniqueId
        '
        Me.txtUniqueId.Enabled = False
        Me.txtUniqueId.Location = New System.Drawing.Point(283, 16)
        Me.txtUniqueId.Name = "txtUniqueId"
        Me.txtUniqueId.Size = New System.Drawing.Size(248, 20)
        Me.txtUniqueId.TabIndex = 3
        '
        'txtIdEquipamento
        '
        Me.txtIdEquipamento.Enabled = False
        Me.txtIdEquipamento.Location = New System.Drawing.Point(87, 42)
        Me.txtIdEquipamento.Name = "txtIdEquipamento"
        Me.txtIdEquipamento.Size = New System.Drawing.Size(69, 20)
        Me.txtIdEquipamento.TabIndex = 5
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Location = New System.Drawing.Point(283, 42)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(248, 20)
        Me.txtSerie.TabIndex = 8
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Location = New System.Drawing.Point(87, 68)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(444, 20)
        Me.txtModelo.TabIndex = 10
        '
        'txtDescEquipamento
        '
        Me.txtDescEquipamento.Enabled = False
        Me.txtDescEquipamento.Location = New System.Drawing.Point(87, 96)
        Me.txtDescEquipamento.Name = "txtDescEquipamento"
        Me.txtDescEquipamento.Size = New System.Drawing.Size(444, 20)
        Me.txtDescEquipamento.TabIndex = 12
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Enabled = False
        Me.txtQuantidade.Location = New System.Drawing.Point(87, 122)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(81, 20)
        Me.txtQuantidade.TabIndex = 14
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(431, 125)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 16
        '
        'btnPesqEquipamento
        '
        Me.btnPesqEquipamento.Image = CType(resources.GetObject("btnPesqEquipamento.Image"), System.Drawing.Image)
        Me.btnPesqEquipamento.Location = New System.Drawing.Point(158, 41)
        Me.btnPesqEquipamento.Name = "btnPesqEquipamento"
        Me.btnPesqEquipamento.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqEquipamento.TabIndex = 6
        Me.btnPesqEquipamento.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.Location = New System.Drawing.Point(463, 181)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 22
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnEditaSalva
        '
        Me.btnEditaSalva.Image = CType(resources.GetObject("btnEditaSalva.Image"), System.Drawing.Image)
        Me.btnEditaSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditaSalva.Location = New System.Drawing.Point(387, 181)
        Me.btnEditaSalva.Name = "btnEditaSalva"
        Me.btnEditaSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnEditaSalva.TabIndex = 21
        Me.btnEditaSalva.Text = "Novo"
        Me.btnEditaSalva.UseVisualStyleBackColor = True
        '
        'btnPesqMotivo
        '
        Me.btnPesqMotivo.Enabled = False
        Me.btnPesqMotivo.Image = CType(resources.GetObject("btnPesqMotivo.Image"), System.Drawing.Image)
        Me.btnPesqMotivo.Location = New System.Drawing.Point(501, 148)
        Me.btnPesqMotivo.Name = "btnPesqMotivo"
        Me.btnPesqMotivo.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqMotivo.TabIndex = 20
        Me.btnPesqMotivo.UseVisualStyleBackColor = True
        '
        'txtDescMotivo
        '
        Me.txtDescMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescMotivo.Enabled = False
        Me.txtDescMotivo.Location = New System.Drawing.Point(145, 149)
        Me.txtDescMotivo.Name = "txtDescMotivo"
        Me.txtDescMotivo.Size = New System.Drawing.Size(354, 20)
        Me.txtDescMotivo.TabIndex = 19
        '
        'txtIdMotivo
        '
        Me.txtIdMotivo.Enabled = False
        Me.txtIdMotivo.Location = New System.Drawing.Point(87, 149)
        Me.txtIdMotivo.Name = "txtIdMotivo"
        Me.txtIdMotivo.Size = New System.Drawing.Size(55, 20)
        Me.txtIdMotivo.TabIndex = 18
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(44, 153)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "Motivo"
        '
        'DevolucaoEquipamento_Edicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 207)
        Me.Controls.Add(Me.btnPesqMotivo)
        Me.Controls.Add(Me.txtDescMotivo)
        Me.Controls.Add(Me.txtIdMotivo)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnEditaSalva)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnPesqEquipamento)
        Me.Controls.Add(ID_ROMANEIOLabel)
        Me.Controls.Add(Me.txtRomaneio)
        Me.Controls.Add(UNIQUE_KEYIDLabel)
        Me.Controls.Add(Me.txtUniqueId)
        Me.Controls.Add(ID_CHIPLabel)
        Me.Controls.Add(Me.txtIdEquipamento)
        Me.Controls.Add(SIMIDLabel)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(ID_OPERADORALabel)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(DESC_OPERADORALabel)
        Me.Controls.Add(Me.txtDescEquipamento)
        Me.Controls.Add(QTDLabel)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(VALORLabel)
        Me.Controls.Add(Me.txtValor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "DevolucaoEquipamento_Edicao"
        Me.Text = "Devolução de Equipamento (Visualizar/Editar)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRomaneio As System.Windows.Forms.TextBox
    Friend WithEvents txtUniqueId As System.Windows.Forms.TextBox
    Friend WithEvents txtIdEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents btnPesqEquipamento As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnEditaSalva As System.Windows.Forms.Button
    Friend WithEvents btnPesqMotivo As System.Windows.Forms.Button
    Friend WithEvents txtDescMotivo As System.Windows.Forms.TextBox
    Friend WithEvents txtIdMotivo As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
