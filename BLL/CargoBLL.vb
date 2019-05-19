'********************************************************
'* CargoBLL
'* Classe BLL do cadastro de Cargos
'* PAULO EDUARDO DEVIDE
'* 23-JUL-2016
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


Public Class CargoBLL

    Public Enum flagOp

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum

    Public Shared Function getAllCargoDS() As DataSet

        Try
            Dim ds = New DataSet
            Dim cmd = "spListaCargo"
            Return DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, Nothing, DALGenerico.TipoDeComando.ExecuteDataSet)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function getAllCargoDT() As List(Of String)
        Dim sql = "SELECT * from CG_CARGO"
        Dim dt = New DataTable
        dt = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteDataTable)
        Dim retorno As List(Of String) = New List(Of String)
        For Each item As DataRow In dt.Rows
            retorno.Add(item("DESC_CARGO").ToString)
        Next
        Return retorno
    End Function

    Public Sub GravarBLL(ByVal acao As Integer, ByVal oCargo As DTO.Cg_cargo)

        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_CARGO", DbType.Int32, oCargo.Id_cargo))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DESC_CARGO", DbType.String, oCargo.Desc_cargo))

        If acao = flagOp.Novo Then
            'listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_INS", dbtype., oCargo.User_ins))

            listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_INS", DbType.Int32, oCargo.User_ins))
            listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_INS", DbType.DateTime, oCargo.Data_ins))
        End If

        If acao = flagOp.Alterar Then
            listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_UPD", DbType.Int32, oCargo.User_upd))
            listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_UPD", DbType.DateTime, oCargo.Data_upd))
        End If
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA", DbType.Int32, oCargo.Id_empresa))

        Try

            Dim cmd As String
            cmd = Nothing
            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_cargo"
            ElseIf acao = flagOp.Novo Then
                cmd = "spIns_Cg_cargo"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ExcluirBLL(_KeyId As Integer)
        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_CARGO", DbType.Int32, _KeyId))

        Try

            Dim cmd As String
            cmd = Nothing

            cmd = "spDel_Cg_cargo"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_cargo

        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim oModelo As New DTO.Cg_cargo
        If dr.HasRows Then
            dr.Read()
            oModelo.Id_cargo = CInt(dr.Item("Id_cargo"))
            oModelo.Desc_cargo = dr.Item("desc_cargo")
        Else
            oModelo.Id_cargo = -1
        End If

        Return oModelo

    End Function
End Class


