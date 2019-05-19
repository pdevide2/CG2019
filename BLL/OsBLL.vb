'********************************************************
'* OsBLL
'* Classe BLL do cadastro de OS
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

Public Class OsBLL

    Public Enum flagOp

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum

    Public Sub GravarBLL(ByVal acao As Integer, ByVal oOs As DTO.Cg_os)

        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, oOs.Id_os))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_MOVTO", DbType.DateTime, oOs.Data_movto))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_LOJA_ORIGEM", DbType.Int32, oOs.Id_loja_origem))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@NF_TRANSP", DbType.String, oOs.Nf_transp))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@SERIE_NF_TRANSP", DbType.String, oOs.Serie_nf_transp))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@EMISSAO_NF_TRANSP", DbType.DateTime, oOs.Emissao_nf_transp))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_FORNECEDOR", DbType.Int32, oOs.Id_fornecedor))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_RESPONSAVEL_IDA", DbType.Int32, oOs.Id_responsavel_ida))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@STATUS_OS", DbType.Int32, oOs.Status_os))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_INS", DbType.Int32, oOs.User_ins))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_INS", DbType.DateTime, oOs.Data_ins))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_UPD", DbType.Int32, oOs.User_upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_UPD", DbType.DateTime, oOs.Data_upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA", DbType.Int32, oOs.Id_empresa))


        Try

            Dim cmd As String
            cmd = Nothing
            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_os"
            ElseIf acao = flagOp.Novo Then
                cmd = "spIns_Cg_os"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub ExcluirBLL(_KeyId As Integer)
        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, _KeyId))

        Try

            Dim cmd As String
            cmd = Nothing

            cmd = "spDel_Cg_os"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_os

        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim oModelo As New DTO.Cg_os
        If dr.HasRows Then
            dr.Read()
            oModelo.Id_os = CInt(dr.Item("Id_os"))
            oModelo.Data_movto = CDate(dr.Item("Data_movto"))
            oModelo.Id_loja_origem = CInt(dr.Item("Id_loja_origem"))
            oModelo.Nf_transp = dr.Item("Nf_transp")
            oModelo.Serie_nf_transp = dr.Item("Serie_nf_transp")
            oModelo.Emissao_nf_transp = CDate(dr.Item("Emissao_nf_transp"))
            oModelo.Id_fornecedor = CInt(dr.Item("Id_fornecedor"))
            oModelo.Id_responsavel_ida = CInt(dr.Item("Id_responsavel_ida"))
            oModelo.Status_os = CInt(dr.Item("Status_os"))
            oModelo.User_ins = CInt(dr.Item("User_ins"))
            oModelo.Data_ins = CDate(dr.Item("Data_ins"))
            oModelo.User_upd = CInt(dr.Item("User_upd"))
            oModelo.Data_upd = CDate(dr.Item("Data_upd"))

        Else
            oModelo.Id_os = -1
        End If

        Return oModelo

    End Function

    Public Sub GravarPDF_NF_TRANSP(ByVal acao As Integer, ByVal oOS As DTO.Cg_os_PDF_NF_TRANSP)
        Dim listaParametros As New List(Of DbParameter)
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, oOS.Id_os))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@PDF", DbType.Binary, oOS.PDF_NF_TRANSP))

        Try

            Dim cmd As String
            cmd = Nothing

            acao = flagOp.Alterar 'Nesta tela a operação é sempre Update

            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_os_PDF_NF_TRANSP"
                'ElseIf acao = flagOp.Novo Then
                '    cmd = "spIns_Cg_os_retorno"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GravarPDF_NF_TS(ByVal acao As Integer, ByVal oOS As DTO.Cg_os_PDF_NF_TS)
        Dim listaParametros As New List(Of DbParameter)
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, oOS.Id_os))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@PDF", DbType.Binary, oOS.PDF_NF_TS))

        Try

            Dim cmd As String
            cmd = Nothing

            acao = flagOp.Alterar 'Nesta tela a operação é sempre Update

            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_os_PDF_NF_TS"
                'ElseIf acao = flagOp.Novo Then
                '    cmd = "spIns_Cg_os_retorno"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class



