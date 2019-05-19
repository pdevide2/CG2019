

Imports System.Data
Imports System.Collections.Generic
Imports DAL
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class PedidovendaBLL

    Public Enum flagOp

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum

    Public Sub GravarBLL(ByVal acao As Integer, ByVal oPedidovenda As DTO.Cg_pedidovenda)

        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_PEDIDO", DbType.Int32, oPedidovenda.Id_pedido))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@STATUS_PEDIDO", DbType.String, oPedidovenda.Status_pedido))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_CLIENTE", DbType.Int32, oPedidovenda.Id_cliente))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@PREVISAO_ENTREGA", DbType.DateTime, oPedidovenda.Previsao_entrega))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_BAIXA", DbType.DateTime, oPedidovenda.Data_baixa))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@TOT_QTDE_ORIGINAL", DbType.Int32, oPedidovenda.Tot_qtde_original))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@TOT_QTDE_ENTREGAR", DbType.Int32, oPedidovenda.Tot_qtde_entregar))

        Try

            Dim cmd As String
            cmd = Nothing
            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_pedidovenda"
            ElseIf acao = flagOp.Novo Then
                cmd = "spIns_Cg_pedidovenda"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub ExcluirBLL(_KeyId As Integer)
        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_PEDIDO", DbType.Int32, _KeyId))

        Try

            Dim cmd As String
            cmd = Nothing

            cmd = "spDel_Cg_pedidovenda"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_pedidovenda

        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim oModelo As New DTO.Cg_pedidovenda
        If dr.HasRows Then
            dr.Read()
            oModelo.Id_pedido = CInt(dr.Item("Id_pedido"))
            oModelo.Status_pedido = dr.Item("Status_pedido")
            oModelo.Id_cliente = CInt(dr.Item("Id_cliente"))
            oModelo.Previsao_entrega = CDate(dr.Item("Previsao_entrega"))
            oModelo.Data_baixa = CDate(dr.Item("Data_baixa"))
            oModelo.Tot_qtde_original = CInt(dr.Item("Tot_qtde_original"))
            oModelo.Tot_qtde_entregar = CInt(dr.Item("Tot_qtde_entregar"))
        Else
            oModelo.Id_pedido = -1
        End If

        Return oModelo

    End Function
End Class

