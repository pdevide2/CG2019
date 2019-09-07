Public Class PedidoVendaDevolucao

    Private blnAddColumn As Boolean = False
    Private Sub PesqFK1_Load(sender As Object, e As EventArgs) Handles PesqFK1.Load
        With Me.PesqFK1
            .LabelPesqFK = "Cliente"
            .Tabela = "CG_CLIENTE"
            .View = "CG_CLIENTE"
            .CampoId = "ID_CLIENTE"
            .CampoDesc = "NOME"
            .ListaCampos = "ID_CLIENTE, NOME, SIGLA"
            .ColunasFiltro = "NOME,SIGLA,ID_CLIENTE"  ' ComboBox de filtros
            .LabelBuscaId = "Código"
            .LabelBuscaDesc = "Nome"
            .TituloTela = "Pesquisa de Clientes"

            .lblLabelFK.Text = .LabelPesqFK

            .PosValida = True

            'Ajustes de layout
            .lblLabelFK.Left = 0
            .txtId.Left += 26
            .txtId.Width -= 0
            .txtDesc.Left = .txtId.Left + .txtId.Width + 3
            .txtDesc.Width += 162
            .btnPesq.Left = .txtDesc.Left + .txtDesc.Width + 2

        End With
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        DevolveItens()

    End Sub

    Private Sub DevolveItens()
        Dim sql As String = ""
        Dim bllGlobal As New BLL.GlobalBLL
        Dim intCliente As Integer
        Dim intEquipamento As Integer

        Try
            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Se estiver flagado para exclusão - Deleta a linha do Estoque - a trigger devolve pra Matriz
                    If row.Cells(0).Value = True Then

                        intCliente = CInt(row.Cells("id_cliente").Value)
                        intEquipamento = CInt(row.Cells("id_equipamento").Value)
                        sql = "DELETE FROM CG_ESTOQUE_CLIENTE WHERE ID_CLIENTE = " & intCliente & " AND ID_EQUIPAMENTO = " & intEquipamento

                        bllGlobal.GravarGenericoBLL(sql)

                    End If

                End If

            Next
            MessageBox.Show("Devolução executada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub Carregar()
        Dim sql As String
        sql = " select	a.ID_CLIENTE, B.NOME, A.ID_EQUIPAMENTO, A.ESTOQUE, "
        sql += " 		C.DESC_EQUIPAMENTO, C.SERIE, C.MODELO, A.DATAMOV "
        sql += " from CG_ESTOQUE_CLIENTE a "
        sql += " inner join CG_CLIENTE b ON B.ID_CLIENTE = A.ID_CLIENTE "
        sql += " INNER JOIN CG_EQUIPAMENTO C ON C.ID_EQUIPAMENTO = A.ID_EQUIPAMENTO "
        sql += " WHERE A.TRANSITO = 0 AND A.ID_CLIENTE = " & PesqFK1.txtId.Text
        sql += " ORDER BY A.DATAMOV DESC "

        Try

            Dim dt = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
            Dim strFilter = ""
            If Not String.IsNullOrEmpty(txtPesquisaSerie.Text) Then
                If optPesqSerie1.Checked Then
                    strFilter = "serie like'" + Trim(txtPesquisaSerie.Text) + "%'"
                End If
                If optPesqSerie2.Checked Then
                    strFilter = "serie like'%" + Trim(txtPesquisaSerie.Text) + "%'"
                End If
            End If
            dt.DefaultView.RowFilter = strFilter
            dgvDados.DataSource = dt

            'Verifica se coluna já foi adicionada ao Grid, caso contrário ignora a adição da coluna de Checkbox
            If Not blnAddColumn Then
                blnAddColumn = True
                Dim coluna As New DataGridViewCheckBoxColumn()
                With coluna
                    .HeaderText = "Secionar"
                    .Name = "colSelecao"
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .FlatStyle = FlatStyle.Standard
                    .CellTemplate = New DataGridViewCheckBoxCell()
                    .CellTemplate.Style.BackColor = Color.Beige
                End With
                dgvDados.Columns.Insert(0, coluna)

            End If

            For i = 1 To dgvDados.DisplayedColumnCount(True) - 1
                dgvDados.Columns(i).ReadOnly = True
            Next
            'Marca todas as colunas como True (flagado)
            For Each row As DataGridViewRow In dgvDados.Rows
                row.Cells(0).Value = False
            Next
            dgvDados.Columns("desc_equipamento").Width = 350
            dgvDados.Columns("id_cliente").Visible = False
            dgvDados.Columns("nome").Visible = False
            dgvDados.Columns("id_equipamento").Visible = False
            dgvDados.Columns("estoque").Width = 70
            dgvDados.Columns("estoque").HeaderText = "Estoque"
            dgvDados.Columns("desc_equipamento").HeaderText = "Descrição Equipamento"
            dgvDados.Columns("serie").HeaderText = "Série"
            dgvDados.Columns("modelo").HeaderText = "Modelo"
            dgvDados.Columns("datamov").HeaderText = "Data Movimento"


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PesqFK1_Leave(sender As Object, e As EventArgs) Handles PesqFK1.Leave

        If PesqFK1.PosValida = True And PesqFK1.Clicou > 0 Then
            Carregar()
        End If

    End Sub

    Private Sub BtnProcurarSerie_Click(sender As Object, e As EventArgs) Handles btnProcurarSerie.Click
        Carregar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtPesquisaSerie.Text = ""
        Carregar()
    End Sub

    Private Sub BtnMarcar_Click(sender As Object, e As EventArgs) Handles btnMarcar.Click
        Try
            If btnMarcar.Text = "Marcar Todos" Then
                btnMarcar.Text = "Desmarcar Todos"
                For Each row As DataGridViewRow In dgvDados.Rows
                    row.Cells(0).Value = True
                Next
            Else
                btnMarcar.Text = "Marcar Todos"
                For Each row As DataGridViewRow In dgvDados.Rows
                    row.Cells(0).Value = False
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class