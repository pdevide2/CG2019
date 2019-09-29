Public Class PedidoVendasAprovacao2

    Private Sub Inicio()
        Dim sql As String

        sql = " SELECT ID_PEDIDO "
        sql += " FROM CG_PEDIDOVENDA_ITENS "
        sql += " WHERE STATUS_ITEM = 1 "
        sql += " group by ID_PEDIDO "
        sql += " order by ID_PEDIDO "

        dgvPedido.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        dgvPedido.Columns(0).ReadOnly = True
        dgvPedido.AutoResizeColumns()
        lblQtPedido.Text = "Qtde Pedidos " & dgvPedido.Rows.Count
    End Sub
    Private Sub CarregaItens()
        Dim sql As String = ""
        Dim _pedidoPai As String

        If dgvPedido.Rows.Count = 0 Then
            _pedidoPai = "0"
            LimparPainel()
        Else
            _pedidoPai = dgvPedido.CurrentRow.Cells(0).Value.ToString
        End If

        sql = "SELECT ID_PEDIDO, ROW_NUMBER() OVER(PARTITION BY ID_PEDIDO ORDER BY ID_PEDIDO ASC)  AS Item, "
        sql += "ID_EQUIPAMENTO, MODELO, SERIE, PRECO_VENDA, STATUS_ITEM, DATA_CADASTRO, DATA_BAIXA, ULTIMA_ALTERACAO, CANCEL "
        sql += "FROM VW_CG_PEDIDOVENDA_ITENS WHERE STATUS_ITEM = 1  and ID_PEDIDO = " & _pedidoPai
        sql += " order by ID_PEDIDO "



        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        For i = 0 To 10
            dgvDados.Columns(i).ReadOnly = True
            If i >= 2 Then
                dgvDados.Columns(i).Visible = False
            End If

        Next
        dgvDados.AutoResizeColumns()
        Dim _qtdLinhas As Integer = dgvDados.Rows.Count
        lblQtItens.Text = "Qtde Itens do Pedido " & _qtdLinhas

        'lblTotalRegistros.Text = "A pesquisa retornou " & dgvDados.RowCount & " linhas..."
        'Troca fonte e atualiza os headertext
        'UpdateFont()



    End Sub

    Private Sub PedidoVendasAprovacao2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimparPainel()
        Inicio()

    End Sub
    Private Sub LimparPainel()
        txtPedido.Text = ""
        txtItem.Text = ""
        txtIdEquipamento.Text = ""
        txtModelo.Text = ""
        txtSerie.Text = ""
        txtPrecoVenda.Text = ""
        txtDataCadastro.Text = ""

        txtCliente.Text = ""
        txtDescEquipamento.Text = ""
        txtDescTipoEquipamento.Text = ""


        rbAnalise.Checked = True
        rbAprovar.Checked = False
        rbReprovar.Checked = False


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
        If rbAnalise.Checked And dgvDados.Rows.Count > 0 Then
            dgvDados.CurrentRow.Cells("status_item").Value = "1"
        End If
    End Sub

    Private Sub RbAprovar_CheckedChanged(sender As Object, e As EventArgs) Handles rbAprovar.CheckedChanged
        If rbAprovar.Checked And dgvDados.Rows.Count > 0 Then
            dgvDados.CurrentRow.Cells("status_item").Value = "2"
        End If

    End Sub

    Private Sub RbReprovar_CheckedChanged(sender As Object, e As EventArgs) Handles rbReprovar.CheckedChanged
        If rbReprovar.Checked And dgvDados.Rows.Count > 0 Then
            dgvDados.CurrentRow.Cells("status_item").Value = "3"
        End If

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Gravar(2)
        Inicio()
        CarregaItens()
        'Me.Close()

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
        'Me.Close()
        Inicio()
    End Sub

    Private Sub DgvPedido_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedido.CellClick
        CarregaItens()
    End Sub

    Private Sub DgvPedido_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedido.CellEnter
        CarregaItens()
    End Sub

    Private Sub BtnAprovaTudo_Click(sender As Object, e As EventArgs) Handles btnAprovaTudo.Click

        For Each row In dgvDados.Rows
            row.cells("status_item").value = "2"
        Next
        dgvDados.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnReprovaTudo_Click(sender As Object, e As EventArgs) Handles btnReprovaTudo.Click

        For Each row In dgvDados.Rows
            row.cells("status_item").value = "3"
        Next
        dgvDados.Focus()
    End Sub
End Class