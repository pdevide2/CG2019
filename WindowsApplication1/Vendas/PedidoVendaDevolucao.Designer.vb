<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoVendaDevolucao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoVendaDevolucao))
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnProcurarSerie = New System.Windows.Forms.Button()
        Me.optPesqSerie2 = New System.Windows.Forms.RadioButton()
        Me.optPesqSerie1 = New System.Windows.Forms.RadioButton()
        Me.txtPesquisaSerie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PesqFK1 = New WinCG.PesqFK()
        Me.btnMarcar = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(12, 92)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(1020, 339)
        Me.dgvDados.TabIndex = 1
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.Location = New System.Drawing.Point(902, 437)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(130, 42)
        Me.btnConfirmar.TabIndex = 2
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(769, 437)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 42)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnProcurarSerie
        '
        Me.btnProcurarSerie.Location = New System.Drawing.Point(530, 65)
        Me.btnProcurarSerie.Name = "btnProcurarSerie"
        Me.btnProcurarSerie.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarSerie.TabIndex = 24
        Me.btnProcurarSerie.Text = "Procurar"
        Me.btnProcurarSerie.UseVisualStyleBackColor = True
        '
        'optPesqSerie2
        '
        Me.optPesqSerie2.AutoSize = True
        Me.optPesqSerie2.Checked = True
        Me.optPesqSerie2.Location = New System.Drawing.Point(412, 68)
        Me.optPesqSerie2.Name = "optPesqSerie2"
        Me.optPesqSerie2.Size = New System.Drawing.Size(108, 17)
        Me.optPesqSerie2.TabIndex = 25
        Me.optPesqSerie2.TabStop = True
        Me.optPesqSerie2.Text = "Qualquer posição"
        Me.optPesqSerie2.UseVisualStyleBackColor = True
        '
        'optPesqSerie1
        '
        Me.optPesqSerie1.AutoSize = True
        Me.optPesqSerie1.Location = New System.Drawing.Point(297, 68)
        Me.optPesqSerie1.Name = "optPesqSerie1"
        Me.optPesqSerie1.Size = New System.Drawing.Size(100, 17)
        Me.optPesqSerie1.TabIndex = 26
        Me.optPesqSerie1.Text = "Começando por"
        Me.optPesqSerie1.UseVisualStyleBackColor = True
        '
        'txtPesquisaSerie
        '
        Me.txtPesquisaSerie.Location = New System.Drawing.Point(62, 66)
        Me.txtPesquisaSerie.Name = "txtPesquisaSerie"
        Me.txtPesquisaSerie.Size = New System.Drawing.Size(229, 20)
        Me.txtPesquisaSerie.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nº. Série"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(611, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Exibir Todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PesqFK1
        '
        Me.PesqFK1.CampoDesc = Nothing
        Me.PesqFK1.CampoId = Nothing
        Me.PesqFK1.Clicou = "0"
        Me.PesqFK1.CodigoSelecionado = Nothing
        Me.PesqFK1.ColunasFiltro = Nothing
        Me.PesqFK1.DescricaoSelecionada = Nothing
        Me.PesqFK1.FiltroSQL = Nothing
        Me.PesqFK1.LabelBuscaDesc = Nothing
        Me.PesqFK1.LabelBuscaId = Nothing
        Me.PesqFK1.LabelPesqFK = Nothing
        Me.PesqFK1.ListaCampos = Nothing
        Me.PesqFK1.Location = New System.Drawing.Point(12, 25)
        Me.PesqFK1.Name = "PesqFK1"
        Me.PesqFK1.ObjModelFk = Nothing
        Me.PesqFK1.PosValida = False
        Me.PesqFK1.Size = New System.Drawing.Size(631, 25)
        Me.PesqFK1.Tabela = Nothing
        Me.PesqFK1.TabIndex = 0
        Me.PesqFK1.TituloTela = Nothing
        Me.PesqFK1.View = Nothing
        '
        'btnMarcar
        '
        Me.btnMarcar.Location = New System.Drawing.Point(12, 447)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(116, 23)
        Me.btnMarcar.TabIndex = 28
        Me.btnMarcar.Text = "Marcar Todos"
        Me.btnMarcar.UseVisualStyleBackColor = True
        '
        'PedidoVendaDevolucao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 484)
        Me.Controls.Add(Me.btnMarcar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnProcurarSerie)
        Me.Controls.Add(Me.optPesqSerie2)
        Me.Controls.Add(Me.optPesqSerie1)
        Me.Controls.Add(Me.txtPesquisaSerie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.PesqFK1)
        Me.Name = "PedidoVendaDevolucao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolução de Pedido"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PesqFK1 As PesqFK
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnProcurarSerie As Button
    Friend WithEvents optPesqSerie2 As RadioButton
    Friend WithEvents optPesqSerie1 As RadioButton
    Friend WithEvents txtPesquisaSerie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMarcar As Button
End Class
