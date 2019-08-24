Public Class PedidoVendasAprovacao


    Private Sub Inicio()
        Dim sql As String = ""


        sql = "SELECT ID_PEDIDO, ROW_NUMBER() OVER(PARTITION BY ID_PEDIDO ORDER BY ID_PEDIDO ASC)  AS Item, "
        sql += "ID_EQUIPAMENTO, MODELO, SERIE, PRECO_VENDA, STATUS_ITEM, DATA_CADASTRO, DATA_BAIXA, ULTIMA_ALTERACAO, CANCEL "
        sql += "FROM VW_CG_PEDIDOVENDA_ITENS WHERE STATUS_ITEM = 1 order by ID_PEDIDO "



        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        For i = 0 To 10
            dgvDados.Columns(i).ReadOnly = True
            If i >= 2 Then
                dgvDados.Columns(i).Visible = False
            End If

        Next
        dgvDados.AutoResizeColumns()
        'lblTotalRegistros.Text = "A pesquisa retornou " & dgvDados.RowCount & " linhas..."
        'Troca fonte e atualiza os headertext
        'UpdateFont()



    End Sub

    Private Sub PedidoVendasAprovacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio()

    End Sub

    Private Sub DgvDados_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellEnter

        Dim BLLInfo As New BLL.Pedidovenda_itensBLL

        txtPedido.Text = dgvDados.CurrentRow.Cells("ID_PEDIDO").Value
        txtItem.Text = dgvDados.CurrentRow.Cells("item").Value
        txtIdEquipamento.Text = dgvDados.CurrentRow.Cells("id_equipamento").Value
        txtModelo.Text = dgvDados.CurrentRow.Cells("modelo").Value
        txtSerie.Text = dgvDados.CurrentRow.Cells("serie").Value
        txtPrecoVenda.Text = dgvDados.CurrentRow.Cells("preco_venda").Value
        txtDataCadastro.Text = dgvDados.CurrentRow.Cells("data_cadastro").Value

        Dim objInfoItem = BLLInfo.InfoPedidoVendaItemBLL(CInt(txtPedido.Text), CInt(txtIdEquipamento.Text))

        txtCliente.Text = objInfoItem.NomeCliente
        txtDescEquipamento.Text = objInfoItem.DescEquipamento
        txtDescTipoEquipamento.Text = objInfoItem.DescTipoEquipamento


        If CInt(dgvDados.CurrentRow.Cells("status_item").Value) = 1 Then
            rbAnalise.Checked = True
            rbAprovar.Checked = False
            rbReprovar.Checked = False
        End If

        If CInt(dgvDados.CurrentRow.Cells("status_item").Value) = 2 Then
            rbAnalise.Checked = False
            rbAprovar.Checked = True
            rbReprovar.Checked = False
        End If

        If CInt(dgvDados.CurrentRow.Cells("status_item").Value) = 3 Then
            rbAnalise.Checked = False
            rbAprovar.Checked = False
            rbReprovar.Checked = True
        End If

    End Sub

    Private Sub RbAnalise_CheckedChanged(sender As Object, e As EventArgs) Handles rbAnalise.CheckedChanged
        If rbAnalise.Checked Then
            dgvDados.CurrentRow.Cells("status_item").Value = "1"
        End If
    End Sub

    Private Sub RbAprovar_CheckedChanged(sender As Object, e As EventArgs) Handles rbAprovar.CheckedChanged
        If rbAprovar.Checked Then
            dgvDados.CurrentRow.Cells("status_item").Value = "2"
        End If

    End Sub

    Private Sub RbReprovar_CheckedChanged(sender As Object, e As EventArgs) Handles rbReprovar.CheckedChanged
        If rbReprovar.Checked Then
            dgvDados.CurrentRow.Cells("status_item").Value = "3"
        End If

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Gravar(2)
        Me.Close()

    End Sub

    Private Sub Gravar(acao As Integer)

        Dim bllFilha As New BLL.PedidoVendaAprovarBLL
        Dim objPedidoVendaItem As New DTO.Cg_AprovaPedidoVenda

        Dim llErro As Boolean = True
        Dim intStatus_Item As Integer = 1

        Try


            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    objPedidoVendaItem.Id_pedido = CInt(row.Cells("id_pedido").Value)
                    objPedidoVendaItem.Id_equipamento = CInt(row.Cells("id_equipamento").Value)
                    objPedidoVendaItem.Status_item = CInt(row.Cells("status_item").Value)
                    objPedidoVendaItem.Cancel = False
                    'Operação de delete/insert/update
                    bllFilha.GravarBLL(2, objPedidoVendaItem)

                End If

            Next


            MessageBox.Show("Processo concluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            llErro = False
        Catch ex As SqlClient.SqlException
            llErro = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            llErro = True
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            'Habilita_Controles(llErro) 'modo leitura

        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class