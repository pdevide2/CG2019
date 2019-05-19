<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FollowUp_OS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FollowUp_OS))
        Me.lblOS = New System.Windows.Forms.Label()
        Me.txtId_OS = New System.Windows.Forms.TextBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.lblDataHora = New System.Windows.Forms.Label()
        Me.txtDataHora = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPesqOS = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOS
        '
        Me.lblOS.AutoSize = True
        Me.lblOS.Location = New System.Drawing.Point(10, 28)
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Size = New System.Drawing.Size(44, 13)
        Me.lblOS.TabIndex = 0
        Me.lblOS.Text = "O.S. n º"
        '
        'txtId_OS
        '
        Me.txtId_OS.Enabled = False
        Me.txtId_OS.Location = New System.Drawing.Point(60, 24)
        Me.txtId_OS.Name = "txtId_OS"
        Me.txtId_OS.ReadOnly = True
        Me.txtId_OS.Size = New System.Drawing.Size(96, 20)
        Me.txtId_OS.TabIndex = 1
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(13, 47)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(177, 338)
        Me.dgvDados.TabIndex = 2
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(223, 49)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.ReadOnly = True
        Me.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTexto.Size = New System.Drawing.Size(408, 336)
        Me.txtTexto.TabIndex = 3
        '
        'lblDataHora
        '
        Me.lblDataHora.AutoSize = True
        Me.lblDataHora.Location = New System.Drawing.Point(224, 28)
        Me.lblDataHora.Name = "lblDataHora"
        Me.lblDataHora.Size = New System.Drawing.Size(61, 13)
        Me.lblDataHora.TabIndex = 5
        Me.lblDataHora.Text = "Data/Hora:"
        '
        'txtDataHora
        '
        Me.txtDataHora.Enabled = False
        Me.txtDataHora.Location = New System.Drawing.Point(289, 24)
        Me.txtDataHora.Name = "txtDataHora"
        Me.txtDataHora.ReadOnly = True
        Me.txtDataHora.Size = New System.Drawing.Size(212, 20)
        Me.txtDataHora.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Aqua
        Me.PictureBox1.Image = Global.WinCG.My.Resources.Resources.WhatsappSingleTicks32
        Me.PictureBox1.Location = New System.Drawing.Point(599, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnPesqOS
        '
        Me.btnPesqOS.Image = Global.WinCG.My.Resources.Resources.Lupa16
        Me.btnPesqOS.Location = New System.Drawing.Point(158, 24)
        Me.btnPesqOS.Name = "btnPesqOS"
        Me.btnPesqOS.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqOS.TabIndex = 20
        Me.btnPesqOS.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.Image = Global.WinCG.My.Resources.Resources.save16
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(454, 391)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(177, 23)
        Me.btnSalvar.TabIndex = 7
        Me.btnSalvar.Text = "      Gravar Comentário"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionar.Location = New System.Drawing.Point(14, 391)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(177, 23)
        Me.btnAdicionar.TabIndex = 4
        Me.btnAdicionar.Text = "      Adicionar Novo Comentário"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Image = Global.WinCG.My.Resources.Resources.WhatsappDoubleTicks32
        Me.PictureBox2.Location = New System.Drawing.Point(599, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'FollowUp_OS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 423)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPesqOS)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtDataHora)
        Me.Controls.Add(Me.lblDataHora)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.txtId_OS)
        Me.Controls.Add(Me.lblOS)
        Me.Name = "FollowUp_OS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Follow Up de Ordem de Serviço (Acompanhamento)"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOS As System.Windows.Forms.Label
    Friend WithEvents txtId_OS As System.Windows.Forms.TextBox
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents lblDataHora As System.Windows.Forms.Label
    Friend WithEvents txtDataHora As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnPesqOS As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
