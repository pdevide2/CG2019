<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ocorrencia
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
        Me.components = New System.ComponentModel.Container()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnPesqEquipamento = New System.Windows.Forms.Button()
        Me.txtDescEquipamento = New System.Windows.Forms.TextBox()
        Me.txtIdEquipamento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDescLoja = New System.Windows.Forms.TextBox()
        Me.txtIdLoja = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHistorico = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigoLoja = New System.Windows.Forms.TextBox()
        Me.txtChaveOS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblChave = New System.Windows.Forms.Label()
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
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(21, 77)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(55, 13)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(91, 29)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtCodigo, "ID da Ocorrência")
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(91, 68)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(487, 20)
        Me.txtDescricao.TabIndex = 4
        Me.txtDescricao.Tag = "Descrição da Alocação"
        Me.ToolTip1.SetToolTip(Me.txtDescricao, "Descrição curta para identificar a ocorrência")
        '
        'btnPesqEquipamento
        '
        Me.btnPesqEquipamento.Enabled = False
        Me.btnPesqEquipamento.Image = Global.WinCG.My.Resources.Resources.Lupa16
        Me.btnPesqEquipamento.Location = New System.Drawing.Point(545, 107)
        Me.btnPesqEquipamento.Name = "btnPesqEquipamento"
        Me.btnPesqEquipamento.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqEquipamento.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnPesqEquipamento, "Selecionar Equipamento")
        Me.btnPesqEquipamento.UseVisualStyleBackColor = True
        '
        'txtDescEquipamento
        '
        Me.txtDescEquipamento.Enabled = False
        Me.txtDescEquipamento.Location = New System.Drawing.Point(152, 107)
        Me.txtDescEquipamento.Name = "txtDescEquipamento"
        Me.txtDescEquipamento.ReadOnly = True
        Me.txtDescEquipamento.Size = New System.Drawing.Size(387, 20)
        Me.txtDescEquipamento.TabIndex = 26
        '
        'txtIdEquipamento
        '
        Me.txtIdEquipamento.Enabled = False
        Me.txtIdEquipamento.Location = New System.Drawing.Point(91, 107)
        Me.txtIdEquipamento.Name = "txtIdEquipamento"
        Me.txtIdEquipamento.ReadOnly = True
        Me.txtIdEquipamento.Size = New System.Drawing.Size(55, 20)
        Me.txtIdEquipamento.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Equipamento"
        '
        'txtData
        '
        Me.txtData.CustomFormat = " "
        Me.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtData.Location = New System.Drawing.Point(467, 25)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(111, 20)
        Me.txtData.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.txtData, "Data da Ocorrência")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Série"
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Location = New System.Drawing.Point(91, 146)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(214, 20)
        Me.txtSerie.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Image = Global.WinCG.My.Resources.Resources.Lupa16
        Me.Button1.Location = New System.Drawing.Point(545, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.Button1, "Selecionar Loja")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDescLoja
        '
        Me.txtDescLoja.Enabled = False
        Me.txtDescLoja.Location = New System.Drawing.Point(152, 185)
        Me.txtDescLoja.Name = "txtDescLoja"
        Me.txtDescLoja.ReadOnly = True
        Me.txtDescLoja.Size = New System.Drawing.Size(300, 20)
        Me.txtDescLoja.TabIndex = 34
        '
        'txtIdLoja
        '
        Me.txtIdLoja.Enabled = False
        Me.txtIdLoja.Location = New System.Drawing.Point(91, 185)
        Me.txtIdLoja.Name = "txtIdLoja"
        Me.txtIdLoja.ReadOnly = True
        Me.txtIdLoja.Size = New System.Drawing.Size(55, 20)
        Me.txtIdLoja.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Loja"
        '
        'txtHistorico
        '
        Me.txtHistorico.Location = New System.Drawing.Point(91, 224)
        Me.txtHistorico.Multiline = True
        Me.txtHistorico.Name = "txtHistorico"
        Me.txtHistorico.Size = New System.Drawing.Size(487, 134)
        Me.txtHistorico.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.txtHistorico, "Descreva o Histórico da Ocorrência")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Histórico"
        '
        'txtCodigoLoja
        '
        Me.txtCodigoLoja.Enabled = False
        Me.txtCodigoLoja.Location = New System.Drawing.Point(458, 185)
        Me.txtCodigoLoja.Name = "txtCodigoLoja"
        Me.txtCodigoLoja.ReadOnly = True
        Me.txtCodigoLoja.Size = New System.Drawing.Size(81, 20)
        Me.txtCodigoLoja.TabIndex = 38
        '
        'txtChaveOS
        '
        Me.txtChaveOS.Enabled = False
        Me.txtChaveOS.Location = New System.Drawing.Point(91, 373)
        Me.txtChaveOS.Name = "txtChaveOS"
        Me.txtChaveOS.ReadOnly = True
        Me.txtChaveOS.Size = New System.Drawing.Size(247, 20)
        Me.txtChaveOS.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.txtChaveOS, "ID_OS | ITEM_ID | ID_EQUIPAMENTO")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Chave OS"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Bisque
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Cadastro de Ocorrências"
        '
        'lblChave
        '
        Me.lblChave.AutoSize = True
        Me.lblChave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChave.ForeColor = System.Drawing.Color.Red
        Me.lblChave.Location = New System.Drawing.Point(344, 376)
        Me.lblChave.Name = "lblChave"
        Me.lblChave.Size = New System.Drawing.Size(11, 13)
        Me.lblChave.TabIndex = 41
        Me.lblChave.Text = "."
        '
        'Ocorrencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 447)
        Me.Controls.Add(Me.lblChave)
        Me.Controls.Add(Me.txtChaveOS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodigoLoja)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHistorico)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDescLoja)
        Me.Controls.Add(Me.txtIdLoja)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnPesqEquipamento)
        Me.Controls.Add(Me.txtDescEquipamento)
        Me.Controls.Add(Me.txtIdEquipamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Ocorrencia"
        Me.Text = "Cadastro de Ocorrências"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblDescricao, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtDescricao, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtIdEquipamento, 0)
        Me.Controls.SetChildIndex(Me.txtDescEquipamento, 0)
        Me.Controls.SetChildIndex(Me.btnPesqEquipamento, 0)
        Me.Controls.SetChildIndex(Me.txtData, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtSerie, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtIdLoja, 0)
        Me.Controls.SetChildIndex(Me.txtDescLoja, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.txtHistorico, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtCodigoLoja, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtChaveOS, 0)
        Me.Controls.SetChildIndex(Me.lblChave, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents btnPesqEquipamento As System.Windows.Forms.Button
    Friend WithEvents txtDescEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents txtIdEquipamento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtDescLoja As System.Windows.Forms.TextBox
    Friend WithEvents txtIdLoja As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHistorico As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoLoja As System.Windows.Forms.TextBox
    Friend WithEvents txtChaveOS As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblChave As System.Windows.Forms.Label
End Class
