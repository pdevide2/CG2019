<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OS_Edicao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OS_Edicao))
        Dim Label1 As System.Windows.Forms.Label
        Me.txtId_OS = New System.Windows.Forms.TextBox()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.txtIdEquipamento = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtDescEquipamento = New System.Windows.Forms.TextBox()
        Me.btnEditaSalva = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.txtPrevisaoRetorno = New System.Windows.Forms.DateTimePicker()
        Me.txtDescDefeito = New System.Windows.Forms.TextBox()
        Me.chkGarantia = New System.Windows.Forms.CheckBox()
        Me.cboTabelaServico = New System.Windows.Forms.ComboBox()
        ID_ROMANEIOLabel = New System.Windows.Forms.Label()
        UNIQUE_KEYIDLabel = New System.Windows.Forms.Label()
        ID_CHIPLabel = New System.Windows.Forms.Label()
        SIMIDLabel = New System.Windows.Forms.Label()
        ID_OPERADORALabel = New System.Windows.Forms.Label()
        DESC_OPERADORALabel = New System.Windows.Forms.Label()
        QTDLabel = New System.Windows.Forms.Label()
        VALORLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ID_ROMANEIOLabel
        '
        ID_ROMANEIOLabel.AutoSize = True
        ID_ROMANEIOLabel.Location = New System.Drawing.Point(20, 19)
        ID_ROMANEIOLabel.Name = "ID_ROMANEIOLabel"
        ID_ROMANEIOLabel.Size = New System.Drawing.Size(35, 13)
        ID_ROMANEIOLabel.TabIndex = 1
        ID_ROMANEIOLabel.Text = "OS nº"
        '
        'UNIQUE_KEYIDLabel
        '
        UNIQUE_KEYIDLabel.AutoSize = True
        UNIQUE_KEYIDLabel.Location = New System.Drawing.Point(211, 19)
        UNIQUE_KEYIDLabel.Name = "UNIQUE_KEYIDLabel"
        UNIQUE_KEYIDLabel.Size = New System.Drawing.Size(48, 13)
        UNIQUE_KEYIDLabel.TabIndex = 3
        UNIQUE_KEYIDLabel.Text = "Item ID#"
        '
        'ID_CHIPLabel
        '
        ID_CHIPLabel.AutoSize = True
        ID_CHIPLabel.Location = New System.Drawing.Point(20, 45)
        ID_CHIPLabel.Name = "ID_CHIPLabel"
        ID_CHIPLabel.Size = New System.Drawing.Size(49, 13)
        ID_CHIPLabel.TabIndex = 5
        ID_CHIPLabel.Text = "Id Equip."
        '
        'SIMIDLabel
        '
        SIMIDLabel.AutoSize = True
        SIMIDLabel.Location = New System.Drawing.Point(228, 45)
        SIMIDLabel.Name = "SIMIDLabel"
        SIMIDLabel.Size = New System.Drawing.Size(31, 13)
        SIMIDLabel.TabIndex = 7
        SIMIDLabel.Text = "Série"
        '
        'ID_OPERADORALabel
        '
        ID_OPERADORALabel.AutoSize = True
        ID_OPERADORALabel.Location = New System.Drawing.Point(20, 71)
        ID_OPERADORALabel.Name = "ID_OPERADORALabel"
        ID_OPERADORALabel.Size = New System.Drawing.Size(42, 13)
        ID_OPERADORALabel.TabIndex = 9
        ID_OPERADORALabel.Text = "Modelo"
        '
        'DESC_OPERADORALabel
        '
        DESC_OPERADORALabel.AutoSize = True
        DESC_OPERADORALabel.Location = New System.Drawing.Point(20, 97)
        DESC_OPERADORALabel.Name = "DESC_OPERADORALabel"
        DESC_OPERADORALabel.Size = New System.Drawing.Size(55, 13)
        DESC_OPERADORALabel.TabIndex = 11
        DESC_OPERADORALabel.Text = "Descrição"
        '
        'QTDLabel
        '
        QTDLabel.AutoSize = True
        QTDLabel.Location = New System.Drawing.Point(20, 123)
        QTDLabel.Name = "QTDLabel"
        QTDLabel.Size = New System.Drawing.Size(89, 13)
        QTDLabel.TabIndex = 13
        QTDLabel.Text = "Previsão Retorno"
        '
        'VALORLabel
        '
        VALORLabel.AutoSize = True
        VALORLabel.Location = New System.Drawing.Point(20, 167)
        VALORLabel.Name = "VALORLabel"
        VALORLabel.Size = New System.Drawing.Size(107, 13)
        VALORLabel.TabIndex = 15
        VALORLabel.Text = "Descrição do Defeito"
        '
        'txtId_OS
        '
        Me.txtId_OS.Enabled = False
        Me.txtId_OS.Location = New System.Drawing.Point(82, 16)
        Me.txtId_OS.Name = "txtId_OS"
        Me.txtId_OS.ReadOnly = True
        Me.txtId_OS.Size = New System.Drawing.Size(106, 20)
        Me.txtId_OS.TabIndex = 2
        '
        'txtItemId
        '
        Me.txtItemId.Enabled = False
        Me.txtItemId.Location = New System.Drawing.Point(266, 16)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.ReadOnly = True
        Me.txtItemId.Size = New System.Drawing.Size(44, 20)
        Me.txtItemId.TabIndex = 4
        '
        'txtIdEquipamento
        '
        Me.txtIdEquipamento.Enabled = False
        Me.txtIdEquipamento.Location = New System.Drawing.Point(82, 42)
        Me.txtIdEquipamento.Name = "txtIdEquipamento"
        Me.txtIdEquipamento.ReadOnly = True
        Me.txtIdEquipamento.Size = New System.Drawing.Size(69, 20)
        Me.txtIdEquipamento.TabIndex = 6
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Location = New System.Drawing.Point(266, 42)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(248, 20)
        Me.txtSerie.TabIndex = 8
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Location = New System.Drawing.Point(82, 68)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(432, 20)
        Me.txtModelo.TabIndex = 10
        '
        'txtDescEquipamento
        '
        Me.txtDescEquipamento.Enabled = False
        Me.txtDescEquipamento.Location = New System.Drawing.Point(82, 94)
        Me.txtDescEquipamento.Name = "txtDescEquipamento"
        Me.txtDescEquipamento.ReadOnly = True
        Me.txtDescEquipamento.Size = New System.Drawing.Size(432, 20)
        Me.txtDescEquipamento.TabIndex = 12
        '
        'btnEditaSalva
        '
        Me.btnEditaSalva.Image = Global.WinCG.My.Resources.Resources.save16B
        Me.btnEditaSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditaSalva.Location = New System.Drawing.Point(371, 286)
        Me.btnEditaSalva.Name = "btnEditaSalva"
        Me.btnEditaSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnEditaSalva.TabIndex = 41
        Me.btnEditaSalva.Text = "Salvar"
        Me.btnEditaSalva.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.Location = New System.Drawing.Point(447, 286)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 39
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'txtPrevisaoRetorno
        '
        Me.txtPrevisaoRetorno.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtPrevisaoRetorno.Location = New System.Drawing.Point(20, 139)
        Me.txtPrevisaoRetorno.Name = "txtPrevisaoRetorno"
        Me.txtPrevisaoRetorno.Size = New System.Drawing.Size(101, 20)
        Me.txtPrevisaoRetorno.TabIndex = 42
        '
        'txtDescDefeito
        '
        Me.txtDescDefeito.Location = New System.Drawing.Point(20, 188)
        Me.txtDescDefeito.Multiline = True
        Me.txtDescDefeito.Name = "txtDescDefeito"
        Me.txtDescDefeito.Size = New System.Drawing.Size(499, 84)
        Me.txtDescDefeito.TabIndex = 43
        '
        'chkGarantia
        '
        Me.chkGarantia.AutoSize = True
        Me.chkGarantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarantia.Location = New System.Drawing.Point(214, 139)
        Me.chkGarantia.Name = "chkGarantia"
        Me.chkGarantia.Size = New System.Drawing.Size(81, 17)
        Me.chkGarantia.TabIndex = 44
        Me.chkGarantia.Text = "Garantia?"
        Me.chkGarantia.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(330, 123)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(99, 13)
        Label1.TabIndex = 45
        Label1.Text = "Tabela de Serviços"
        '
        'cboTabelaServico
        '
        Me.cboTabelaServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTabelaServico.FormattingEnabled = True
        Me.cboTabelaServico.Location = New System.Drawing.Point(336, 139)
        Me.cboTabelaServico.Name = "cboTabelaServico"
        Me.cboTabelaServico.Size = New System.Drawing.Size(177, 21)
        Me.cboTabelaServico.TabIndex = 46
        '
        'OS_Edicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 314)
        Me.Controls.Add(Me.cboTabelaServico)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.chkGarantia)
        Me.Controls.Add(Me.txtDescDefeito)
        Me.Controls.Add(Me.txtPrevisaoRetorno)
        Me.Controls.Add(Me.btnEditaSalva)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(ID_ROMANEIOLabel)
        Me.Controls.Add(Me.txtId_OS)
        Me.Controls.Add(UNIQUE_KEYIDLabel)
        Me.Controls.Add(Me.txtItemId)
        Me.Controls.Add(ID_CHIPLabel)
        Me.Controls.Add(Me.txtIdEquipamento)
        Me.Controls.Add(SIMIDLabel)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(ID_OPERADORALabel)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(DESC_OPERADORALabel)
        Me.Controls.Add(Me.txtDescEquipamento)
        Me.Controls.Add(QTDLabel)
        Me.Controls.Add(VALORLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "OS_Edicao"
        Me.Text = "OS (Visualizar/Editar)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtId_OS As System.Windows.Forms.TextBox
    Friend WithEvents txtItemId As System.Windows.Forms.TextBox
    Friend WithEvents txtIdEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnEditaSalva As System.Windows.Forms.Button
    Friend WithEvents txtPrevisaoRetorno As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescDefeito As System.Windows.Forms.TextBox
    Friend WithEvents chkGarantia As System.Windows.Forms.CheckBox
    Friend WithEvents cboTabelaServico As ComboBox
End Class
