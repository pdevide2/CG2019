Imports System.DataImports System.Collections.GenericImports DALImports System.Data.CommonImports System.Data.SqlClientPublic Class Pedidovenda_itensBLL

    Public Enum flagOp        Limpar = 0        Novo = 1        Alterar = 2        Excluir = 3        Consulta = 4        Leitura = 5    End Enum    Public Sub GravarBLL(ByVal acao As Integer, ByVal oPedidovenda_itens As DTO.Cg_pedidovenda_itens)        Dim listaParametros As New List(Of DbParameter)        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_PEDIDO", DbType.Int32, oPedidovenda_itens.Id_pedido))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EQUIPAMENTO", DbType.Int32, oPedidovenda_itens.Id_equipamento))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@QTDE", DbType.Int32, oPedidovenda_itens.Qtde))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@PRECO_VENDA", DbType.Decimal, oPedidovenda_itens.Preco_venda))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@STATUS_ITEM", DbType.Int32, oPedidovenda_itens.Status_item))
        'listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_CADASTRO",DbType.Datetime,oPedidovenda_itens.Data_cadastro))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_BAIXA", DbType.DateTime, oPedidovenda_itens.Data_baixa))
        'listaParametros.Add(DAL.DALGenerico.CriarParametro("@ULTIMA_ALTERACAO",DbType.Datetime,oPedidovenda_itens.Ultima_alteracao))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CANCEL", DbType.Boolean, oPedidovenda_itens.Cancel))        Try            Dim cmd As String            cmd = Nothing
            'If acao = flagOp.Alterar Then
            '    cmd = "spUpd_Cg_pedidovenda_itens"
            'ElseIf acao = flagOp.Novo Then
            '    cmd = "spIns_Cg_pedidovenda_itens"
            'End If
            'A proc spGrava_PedidoVenda_Itens insere, atualiza e exclui itens
            cmd = "spGrava_PedidoVenda_Itens"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)        Catch ex As Exception            Throw ex        End Try    End Sub    Public Sub ExcluirBLL(_KeyId As Integer)        Dim listaParametros As New List(Of DbParameter)        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_PEDIDO", DbType.Int32, _KeyId))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EQUIPAMENTO", DbType.Int32, _KeyId))        Try            Dim cmd As String            cmd = Nothing            cmd = "spDel_Cg_pedidovenda_itens"            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)        Catch ex As Exception            Throw ex        End Try    End Sub    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_pedidovenda_itens        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString        Dim dr As SqlDataReader        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)        Dim oModelo As New DTO.Cg_pedidovenda_itens        If dr.HasRows Then            dr.Read()
            oModelo.Id_pedido = CInt(dr.Item("Id_pedido"))
            oModelo.Id_equipamento = CInt(dr.Item("Id_equipamento"))
            oModelo.Qtde = CInt(dr.Item("Qtde"))
            oModelo.Preco_venda = CDec(dr.Item("Preco_venda"))
            oModelo.Status_item = CInt(dr.Item("Status_item"))
            'oModelo.Data_cadastro = CDate(dr.Item("Data_cadastro"))
            oModelo.Data_baixa = CDate(dr.Item("Data_baixa"))
            'oModelo.Ultima_alteracao = CDate(dr.Item("Ultima_alteracao"))
            oModelo.Cancel = CBool(dr.Item("Cancel"))        Else
            oModelo.Id_pedido = -1
            oModelo.Id_equipamento = -1        End If        Return oModelo    End FunctionEnd Class