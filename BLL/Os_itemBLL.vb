'********************************************************
'* Os_itemBLL
'* Classe BLL do cadastro de Itens da OS
'* PAULO EDUARDO DEVIDE
'* 30-JUL-2016
'*
'* Métodos:
'* GravarBLL()
'* ExcluirBLL()
'* PesquisaPorIdModelBLL()
'*
' ********************************************************

Imports System.Data
Imports System.Collections.Generic
Imports DAL
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class Os_itemBLL

    Public Enum flagOp

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum

    Public Sub GravarBLL(ByVal acao As Integer, ByVal oOs_item As DTO.Cg_os_item)

        Dim listaParametros As New List(Of DbParameter)



        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, oOs_item.Id_os))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ITEM_ID", DbType.Int32, oOs_item.Item_id))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EQUIPAMENTO", DbType.Int32, oOs_item.Id_equipamento))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DESC_EQUIPAMENTO", DbType.String, oOs_item.Desc_equipamento))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@SERIE", DbType.String, oOs_item.Serie))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@MODELO", DbType.String, oOs_item.Modelo))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@PROTOCOLO", DbType.String, oOs_item.Protocolo))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@PREVISAO_RETORNO", DbType.DateTime, oOs_item.Previsao_retorno))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DESC_DEFEITO", DbType.String, oOs_item.Desc_defeito))

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_INS", DbType.Int32, oOs_item.User_ins))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_INS", DbType.DateTime, oOs_item.Data_ins))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_UPD", DbType.Int32, oOs_item.User_upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_UPD", DbType.DateTime, oOs_item.Data_upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@GARANTIA", DbType.Boolean, oOs_item.Garantia))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OCORRENCIA", DbType.Int32, oOs_item.Id_Ocorrencia))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA", DbType.Int32, oOs_item.Id_empresa))

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_TABELA", DbType.String, oOs_item.Id_Tabela))

        Try

            Dim cmd As String
            cmd = Nothing
            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_os_item"
            ElseIf acao = flagOp.Novo Then
                cmd = "spIns_Cg_os_item"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ExcluirBLL(_id_os As Integer, _item_id As Integer, _id_equipamento As Integer)
        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, _id_os))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ITEM_ID", DbType.Int32, _item_id))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EQUIPAMENTO", DbType.Int32, _id_equipamento))

        Try

            Dim cmd As String
            cmd = Nothing

            cmd = "spDel_Cg_os_item"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_os_item

        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim oModelo As New DTO.Cg_os_item
        If dr.HasRows Then
            dr.Read()
            oModelo.Id_os = CInt(dr.Item("Id_os"))
            oModelo.Item_id = CInt(dr.Item("Item_id"))
            oModelo.Id_equipamento = CInt(dr.Item("Id_equipamento"))
            oModelo.Desc_equipamento = dr.Item("Desc_equipamento")
            oModelo.Serie = dr.Item("Serie")
            oModelo.Modelo = dr.Item("Modelo")
            oModelo.Protocolo = dr.Item("Protocolo")
            oModelo.Previsao_retorno = CDate(dr.Item("Previsao_retorno"))
            oModelo.Data_retorno = CDate(dr.Item("Data_retorno"))
            oModelo.Desc_defeito = dr.Item("Desc_defeito")
            oModelo.Conserto_ok = CBool(dr.Item("Conserto_ok"))
            oModelo.Nf_fornec = dr.Item("Nf_fornec")
            oModelo.Serie_nf_fornec = dr.Item("Serie_nf_fornec")
            oModelo.Emissao_nf_fornec = CDate(dr.Item("Emissao_nf_fornec"))
            oModelo.Id_responsavel_ret = CInt(dr.Item("Id_responsavel_ret"))
            oModelo.Xml_nf_fornec = dr.Item("Xml_nf_fornec")
            oModelo.Laudo_fornec = dr.Item("Laudo_fornec")
            oModelo.User_ins = CInt(dr.Item("User_ins"))
            oModelo.Data_ins = CDate(dr.Item("Data_ins"))
            oModelo.User_upd = CInt(dr.Item("User_upd"))
            oModelo.Data_upd = CDate(dr.Item("Data_upd"))
        Else
            oModelo.Id_os = -1
            oModelo.Item_id = -1
        End If

        Return oModelo

    End Function
End Class

