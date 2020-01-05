Public Class MovEstoqueChip
    Private Sub MovEstoqueChip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carrega()
    End Sub

    Private Sub optMatriz_CheckedChanged(sender As Object, e As EventArgs) Handles optMatriz.CheckedChanged
        Carrega()
    End Sub

    Private Sub optDefeito_CheckedChanged(sender As Object, e As EventArgs) Handles optDefeito.CheckedChanged
        Carrega()
    End Sub

    Private Sub optLaudo_CheckedChanged(sender As Object, e As EventArgs) Handles optLaudo.CheckedChanged
        Carrega()
    End Sub

    Private Sub optEstqPeca_CheckedChanged(sender As Object, e As EventArgs) Handles optEstqPeca.CheckedChanged
        Carrega()
    End Sub

    Private Sub optInativo_CheckedChanged(sender As Object, e As EventArgs) Handles optInativo.CheckedChanged
        Carrega()
    End Sub
    Private Sub Carrega()
        Dim sql As String, optSelect As Integer = 0
        sql = "select ORIGEM, ID_EQUIPAMENTO, SERIE, MODELO, DESC_EQUIPAMENTO, "
        sql += "ID_EMPRESA, ID_TIPO_LOCAL_ESTOQUE from VW_CG_ORIGEM_ESTOQUE_POS "

        If optMatriz.Checked Then
            optSelect = 1
        End If
        If optDefeito.Checked Then
            optSelect = 2
        End If
        If optLaudo.Checked Then
            optSelect = 3
        End If
        If optEstqPeca.Checked Then
            optSelect = 4
        End If
        If optInativo.Checked Then
            optSelect = 5
        End If

        '==>Código ID_TIPO_LOCAL_ESTOQUE para FILTRO 
        '=1 Matriz
        '=3 Com Defeito
        '=4 Laudo
        '=5 Estoque de Peças
        '=8 Inativo

        Dim lnIdTipoLocalEstoque As Integer
        Select Case optSelect
            Case 1
                lnIdTipoLocalEstoque = 1
            Case 2
                lnIdTipoLocalEstoque = 3
            Case 3
                lnIdTipoLocalEstoque = 4
            Case 4
                lnIdTipoLocalEstoque = 5
            Case 5
                lnIdTipoLocalEstoque = 8
        End Select

        sql += " WHERE ID_EMPRESA = " & Publico.Id_empresa & "AND ID_TIPO_LOCAL_ESTOQUE = " & lnIdTipoLocalEstoque

        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        dgvDados.Columns(1).Visible = False
        dgvDados.Columns(5).Visible = False
        dgvDados.Columns(6).Visible = False
        dgvDados.AutoResizeColumns()
        UpdateFont()
        CarregaComboEstoque(lnIdTipoLocalEstoque)
    End Sub
    Private Sub CarregaComboEstoque(ByVal pIdTipoLocalEstoque As Integer)
        'combobox1
        ComboBox1.DataSource = Nothing
        ComboBox1.DisplayMember = Nothing
        ComboBox1.Items.Clear()

        Dim dt As New DataTable
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Nome", GetType(String))

        If pIdTipoLocalEstoque = 1 Then
            dt.Rows.Add(3, "COM DEFEITO")
            dt.Rows.Add(4, "LAUDO")
            dt.Rows.Add(5, "ESTOQUE DE PEÇAS")
            dt.Rows.Add(8, "INATIVO")
        End If
        If pIdTipoLocalEstoque = 3 Then
            dt.Rows.Add(1, "MATRIZ")
            dt.Rows.Add(4, "LAUDO")
            dt.Rows.Add(5, "ESTOQUE DE PEÇAS")
            dt.Rows.Add(8, "INATIVO")
        End If
        If pIdTipoLocalEstoque = 4 Then
            dt.Rows.Add(1, "MATRIZ")
            dt.Rows.Add(3, "COM DEFEITO")
            dt.Rows.Add(5, "ESTOQUE DE PEÇAS")
            dt.Rows.Add(8, "INATIVO")
        End If
        If pIdTipoLocalEstoque = 5 Then
            dt.Rows.Add(1, "MATRIZ")
            dt.Rows.Add(3, "COM DEFEITO")
            dt.Rows.Add(4, "LAUDO")
            dt.Rows.Add(8, "INATIVO")
        End If
        If pIdTipoLocalEstoque = 8 Then
            dt.Rows.Add(1, "MATRIZ")
            dt.Rows.Add(3, "COM DEFEITO")
            dt.Rows.Add(4, "LAUDO")
            dt.Rows.Add(5, "ESTOQUE DE PEÇAS")
        End If

        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "Nome"
        ComboBox1.ValueMember = "Id"
    End Sub
    Private Sub UpdateFont()


        Dim colHeader() As String
        Me.dgvDados.DefaultCellStyle.Font = New Font("Tahoma", 10.0F, GraphicsUnit.Pixel)
        colHeader = {"Origem", "Id Equipamento", "Série", "Modelo",
                         "Descrição Equipamento", "Id Empresa", "Id Tipo Local Estoque"}
        For ixx = 0 To dgvDados.ColumnCount - 1
            dgvDados.Columns(ixx).HeaderText = colHeader(ixx)
        Next


    End Sub

    Private Sub btnProcurarSerie_Click(sender As Object, e As EventArgs) Handles btnProcurarSerie.Click
        Dim texto As String = Nothing
        Dim intEscolha As Integer = IIf(optPesqSerie1.Checked = True, 0, 1)

        If txtPesquisaSerie.Text <> String.Empty Then
            'Percorre todas as linhas do Grid e compara o conteudo do textbox de Pesquisa
            'com o conteudo da coluna SIMID do grid. Se a condição for satisfeita seleciona a linha e sai da rotina
            For Each linha As DataGridViewRow In dgvDados.Rows
                texto = linha.Cells(2).Value 'Pesquisa na coluna de SIMID
                If PesquisaString(texto.ToLower, txtPesquisaSerie.Text.ToLower, intEscolha) Then
                    linha.Selected = True
                    Dim linhaAtual = dgvDados.CurrentRow.Index
                    dgvDados.CurrentCell = dgvDados.Rows(linhaAtual).Cells(0)
                    dgvDados.FirstDisplayedScrollingRowIndex = linha.Index
                    dgvDados.Rows(linha.Index).Selected = True
                    dgvDados.CurrentCell = dgvDados.Rows(linha.Index).Cells(0)
                    dgvDados.Update()

                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub dgvDados_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellEnter
        Dim linhaAtual = dgvDados.CurrentRow.Index
        txtOrigem.Text = dgvDados.Rows(linhaAtual).Cells(0).Value
        txtSerie.Text = dgvDados.Rows(linhaAtual).Cells(2).Value
        txtModelo.Text = dgvDados.Rows(linhaAtual).Cells(3).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim linhaAtual = dgvDados.CurrentRow.Index
        Dim pIdEquipamento As Integer
        Dim pIdLocalPara As Integer
        Dim pTipoLocal As String
        pIdEquipamento = CInt(dgvDados.Rows(linhaAtual).Cells(1).Value)
        pIdLocalPara = CInt(ComboBox1.SelectedValue)
        pTipoLocal = "L"
        Transfere(pIdEquipamento, pIdLocalPara, pTipoLocal)
    End Sub
    Private Sub Transfere(ByVal pIdEquipamento As Integer, ByVal pIdLocalPara As Integer, pTipoLocal As String)
        Try
            Dim sqlEmpty As String, sql As String = ""
            sqlEmpty = "EXEC spTransfere_Estoque_POS {0},{1},{2},{3},'{4}',{5}"
            sql = sqlEmpty
            sql = String.Format(sql, pIdEquipamento.ToString, "1", "0", pIdLocalPara.ToString, pTipoLocal, "1")

            Dim bllGlobal As New BLL.GlobalBLL
            bllGlobal.GravarGenericoBLL(sql)
            MessageBox.Show("Transferência Efetuada com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class