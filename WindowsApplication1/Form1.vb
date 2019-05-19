Public Class Form1

    Private Sub btnCarregar_Click(sender As Object, e As EventArgs) Handles btnCarregar.Click
        dgvDados.DataSource = BLL.CategoriaBLL.getTodasCategoriasDS.Tables(0)

        For Each nome In BLL.CategoriaBLL.getTodasCategoriasDT
            lbDados.Items.Add(nome)
        Next
    End Sub
End Class