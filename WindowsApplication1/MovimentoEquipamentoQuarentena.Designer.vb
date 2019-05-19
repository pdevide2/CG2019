<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovimentoEquipamentoQuarentena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovimentoEquipamentoQuarentena))
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnPesqLoja = New System.Windows.Forms.Button()
        Me.txtDescLoja = New System.Windows.Forms.TextBox()
        Me.txtIdLoja = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtDataMovto = New System.Windows.Forms.DateTimePicker()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnPesqLojaDestino = New System.Windows.Forms.Button()
        Me.txtDescLojaDestino = New System.Windows.Forms.TextBox()
        Me.txtIdLojaDestino = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPesqResponsavel = New System.Windows.Forms.Button()
        Me.txtDescResponsavel = New System.Windows.Forms.TextBox()
        Me.txtIdResponsavel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExclui = New System.Windows.Forms.Button()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(16, 19)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(68, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Romaneio nº"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(396, 19)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(30, 13)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Data"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(97, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(98, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'btnPesqLoja
        '
        Me.btnPesqLoja.Enabled = False
        Me.btnPesqLoja.Image = CType(resources.GetObject("btnPesqLoja.Image"), System.Drawing.Image)
        Me.btnPesqLoja.Location = New System.Drawing.Point(493, 73)
        Me.btnPesqLoja.Name = "btnPesqLoja"
        Me.btnPesqLoja.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqLoja.TabIndex = 7
        Me.btnPesqLoja.UseVisualStyleBackColor = True
        '
        'txtDescLoja
        '
        Me.txtDescLoja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescLoja.Enabled = False
        Me.txtDescLoja.Location = New System.Drawing.Point(166, 74)
        Me.txtDescLoja.Name = "txtDescLoja"
        Me.txtDescLoja.Size = New System.Drawing.Size(321, 20)
        Me.txtDescLoja.TabIndex = 6
        '
        'txtIdLoja
        '
        Me.txtIdLoja.Enabled = False
        Me.txtIdLoja.Location = New System.Drawing.Point(97, 75)
        Me.txtIdLoja.Name = "txtIdLoja"
        Me.txtIdLoja.Size = New System.Drawing.Size(64, 20)
        Me.txtIdLoja.TabIndex = 5
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(16, 78)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(63, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Loja Origem"
        '
        'txtDataMovto
        '
        Me.txtDataMovto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataMovto.Location = New System.Drawing.Point(441, 15)
        Me.txtDataMovto.Name = "txtDataMovto"
        Me.txtDataMovto.Size = New System.Drawing.Size(85, 20)
        Me.txtDataMovto.TabIndex = 3
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(15, 134)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(710, 222)
        Me.dgvDados.TabIndex = 11
        '
        'btnPesqLojaDestino
        '
        Me.btnPesqLojaDestino.Enabled = False
        Me.btnPesqLojaDestino.Image = CType(resources.GetObject("btnPesqLojaDestino.Image"), System.Drawing.Image)
        Me.btnPesqLojaDestino.Location = New System.Drawing.Point(493, 102)
        Me.btnPesqLojaDestino.Name = "btnPesqLojaDestino"
        Me.btnPesqLojaDestino.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqLojaDestino.TabIndex = 15
        Me.btnPesqLojaDestino.UseVisualStyleBackColor = True
        '
        'txtDescLojaDestino
        '
        Me.txtDescLojaDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescLojaDestino.Enabled = False
        Me.txtDescLojaDestino.Location = New System.Drawing.Point(166, 103)
        Me.txtDescLojaDestino.Name = "txtDescLojaDestino"
        Me.txtDescLojaDestino.Size = New System.Drawing.Size(321, 20)
        Me.txtDescLojaDestino.TabIndex = 14
        '
        'txtIdLojaDestino
        '
        Me.txtIdLojaDestino.Enabled = False
        Me.txtIdLojaDestino.Location = New System.Drawing.Point(97, 104)
        Me.txtIdLojaDestino.Name = "txtIdLojaDestino"
        Me.txtIdLojaDestino.Size = New System.Drawing.Size(64, 20)
        Me.txtIdLojaDestino.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Loja Destino"
        '
        'btnPesqResponsavel
        '
        Me.btnPesqResponsavel.Enabled = False
        Me.btnPesqResponsavel.Image = CType(resources.GetObject("btnPesqResponsavel.Image"), System.Drawing.Image)
        Me.btnPesqResponsavel.Location = New System.Drawing.Point(493, 43)
        Me.btnPesqResponsavel.Name = "btnPesqResponsavel"
        Me.btnPesqResponsavel.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqResponsavel.TabIndex = 19
        Me.btnPesqResponsavel.UseVisualStyleBackColor = True
        '
        'txtDescResponsavel
        '
        Me.txtDescResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescResponsavel.Enabled = False
        Me.txtDescResponsavel.Location = New System.Drawing.Point(166, 44)
        Me.txtDescResponsavel.Name = "txtDescResponsavel"
        Me.txtDescResponsavel.Size = New System.Drawing.Size(321, 20)
        Me.txtDescResponsavel.TabIndex = 18
        '
        'txtIdResponsavel
        '
        Me.txtIdResponsavel.Enabled = False
        Me.txtIdResponsavel.Location = New System.Drawing.Point(97, 45)
        Me.txtIdResponsavel.Name = "txtIdResponsavel"
        Me.txtIdResponsavel.Size = New System.Drawing.Size(64, 20)
        Me.txtIdResponsavel.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Resp. Transito"
        '
        'btnExclui
        '
        Me.btnExclui.Image = CType(resources.GetObject("btnExclui.Image"), System.Drawing.Image)
        Me.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExclui.Location = New System.Drawing.Point(114, 363)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(99, 23)
        Me.btnExclui.TabIndex = 21
        Me.btnExclui.Text = "Excluir"
        Me.btnExclui.UseVisualStyleBackColor = True
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Image = CType(resources.GetObject("btnAdiciona.Image"), System.Drawing.Image)
        Me.btnAdiciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdiciona.Location = New System.Drawing.Point(15, 363)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(99, 23)
        Me.btnAdiciona.TabIndex = 20
        Me.btnAdiciona.Text = "Adicionar"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'MovimentoEquipamentoInativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 439)
        Me.Controls.Add(Me.btnExclui)
        Me.Controls.Add(Me.btnAdiciona)
        Me.Controls.Add(Me.btnPesqResponsavel)
        Me.Controls.Add(Me.txtDescResponsavel)
        Me.Controls.Add(Me.txtIdResponsavel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPesqLojaDestino)
        Me.Controls.Add(Me.txtDescLojaDestino)
        Me.Controls.Add(Me.txtIdLojaDestino)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.txtDataMovto)
        Me.Controls.Add(Me.btnPesqLoja)
        Me.Controls.Add(Me.txtDescLoja)
        Me.Controls.Add(Me.txtIdLoja)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "MovimentoEquipamentoInativo"
        Me.Text = "Movimentação de Equipamento/POS para Estoque Inativo"
        Me.Controls.SetChildIndex(Me.lblCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblDescricao, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.txtIdLoja, 0)
        Me.Controls.SetChildIndex(Me.txtDescLoja, 0)
        Me.Controls.SetChildIndex(Me.btnPesqLoja, 0)
        Me.Controls.SetChildIndex(Me.txtDataMovto, 0)
        Me.Controls.SetChildIndex(Me.dgvDados, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtIdLojaDestino, 0)
        Me.Controls.SetChildIndex(Me.txtDescLojaDestino, 0)
        Me.Controls.SetChildIndex(Me.btnPesqLojaDestino, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtIdResponsavel, 0)
        Me.Controls.SetChildIndex(Me.txtDescResponsavel, 0)
        Me.Controls.SetChildIndex(Me.btnPesqResponsavel, 0)
        Me.Controls.SetChildIndex(Me.btnAdiciona, 0)
        Me.Controls.SetChildIndex(Me.btnExclui, 0)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnPesqLoja As System.Windows.Forms.Button
    Friend WithEvents txtDescLoja As System.Windows.Forms.TextBox
    Friend WithEvents txtIdLoja As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtDataMovto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnPesqLojaDestino As System.Windows.Forms.Button
    Friend WithEvents txtDescLojaDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtIdLojaDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPesqResponsavel As System.Windows.Forms.Button
    Friend WithEvents txtDescResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents txtIdResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExclui As System.Windows.Forms.Button
    Friend WithEvents btnAdiciona As System.Windows.Forms.Button
End Class
