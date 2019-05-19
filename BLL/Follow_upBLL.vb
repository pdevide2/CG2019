'********************************************************
'* Follow_upBLL
'* Classe BLL do cadastro de Follow Up de OS
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

Public Class Follow_upBLL

    Public Enum flagOp

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum

    Public Sub GravarBLL(ByVal acao As Integer, ByVal oFollow_up As DTO.Cg_follow_up)

        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, oFollow_up.Id_os))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@PROTOCOLO", DbType.String, oFollow_up.Protocolo))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_HORA", DbType.DateTime, oFollow_up.Data_hora))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@TEXTO", DbType.String, oFollow_up.Texto))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_INS", DbType.Int32, oFollow_up.User_ins))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_INS", DbType.DateTime, oFollow_up.Data_ins))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_UPD", DbType.Int32, oFollow_up.User_upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_UPD", DbType.DateTime, oFollow_up.Data_upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@LIDO", DbType.Boolean, oFollow_up.Lido))
        'listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA", DbType.Int32, oFollow_up.Id_empresa))

        Try

            Dim cmd As String
            cmd = Nothing

            cmd = "spGrava_Cg_follow_up"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub ExcluirBLL(_KeyId As Integer)
        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, _KeyId))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@PROTOCOLO", DbType.String, _KeyId))

        Try

            Dim cmd As String
            cmd = Nothing

            cmd = "spDel_Cg_follow_up"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_follow_up

        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim oModelo As New DTO.Cg_follow_up
        If dr.HasRows Then
            dr.Read()
            oModelo.Id_os = CInt(dr.Item("Id_os"))
            oModelo.Protocolo = dr.Item("Protocolo")
            oModelo.Data_hora = CDate(dr.Item("Data_hora"))
            oModelo.Texto = dr.Item("Texto")
            oModelo.User_ins = CInt(dr.Item("User_ins"))
            oModelo.Data_ins = CDate(dr.Item("Data_ins"))
            oModelo.User_upd = CInt(dr.Item("User_upd"))
            oModelo.Data_upd = CDate(dr.Item("Data_upd"))
        Else
            oModelo.Id_os = -1
            oModelo.Protocolo = -1
        End If

        Return oModelo

    End Function
End Class

