﻿Imports System.Data
Imports System.Collections.Generic
Imports DAL
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class PedidoVendaAprovarBLL
    Public Enum flagOp

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum

    Public Sub GravarBLL(ByVal acao As Integer, ByVal oPedidovenda_itens As DTO.Cg_AprovaPedidoVenda)

        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_PEDIDO", DbType.Int32, oPedidovenda_itens.Id_pedido))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EQUIPAMENTO", DbType.Int32, oPedidovenda_itens.Id_equipamento))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@STATUS_ITEM", DbType.Int32, oPedidovenda_itens.Status_item))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CANCEL", DbType.Boolean, oPedidovenda_itens.Cancel))

        Try

            Dim cmd As String
            cmd = Nothing
            cmd = "spAprova_PedidoVenda_Itens"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


End Class
