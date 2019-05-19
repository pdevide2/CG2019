'********************************************************
'* Os_retornoBLL
'* Classe BLL do cadastro de retorno de OS
'* PAULO EDUARDO DEVIDE
'* 15-jan-17
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

Public Class Os_retornoBLL

    Public Enum flagOp

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum

    Public Sub GravarBLL(ByVal acao As Integer, ByVal oOSRetorno As DTO.Cg_os_retorno)

        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, oOSRetorno.Id_Os))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ITEM_ID", DbType.Int32, oOSRetorno.Item_Id))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EQUIPAMENTO", DbType.Int32, oOSRetorno.Id_Equipamento))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_RETORNO", DbType.DateTime, oOSRetorno.Data_Retorno))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DESC_DEFEITO", DbType.String, oOSRetorno.Desc_Defeito))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CONSERTO_OK", DbType.Boolean, oOSRetorno.Conserto_Ok))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@NF_FORNEC", DbType.String, oOSRetorno.Nf_Fornec))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@SERIE_NF_FORNEC", DbType.String, oOSRetorno.Serie_Nf_Fornec))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@EMISSAO_NF_FORNEC", DbType.DateTime, oOSRetorno.Emissao_Nf_Fornec))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@OBS_RETORNO", DbType.String, oOSRetorno.Obs_Retorno))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_RESPONSAVEL_RET", DbType.Int32, oOSRetorno.Id_Responsavel_Ret))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_UPD", DbType.Int32, oOSRetorno.User_Upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_UPD", DbType.DateTime, oOSRetorno.Data_upd))

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@GARANTIA", DbType.Boolean, oOSRetorno.Garantia))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@VALOR_CONSERTO", DbType.Double, oOSRetorno.Valor_Conserto))

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CONFIG_GARANTIA", DbType.Boolean, oOSRetorno.Config_Garantia))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@QTDE_DIAS_GARANTIA", DbType.Int32, oOSRetorno.Qtde_Dias_Garantia))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_INICIO_GARANTIA", DbType.DateTime, oOSRetorno.Data_Inicio_Garantia))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_TERMINO_GARANTIA", DbType.DateTime, oOSRetorno.Data_Termino_Garantia))

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@LAUDO", DbType.Boolean, oOSRetorno.Laudo))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@OUTROS", DbType.Boolean, oOSRetorno.Outros))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@MOTIVO_OUTROS", DbType.String, oOSRetorno.Motivo_Outros))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_TABELA", DbType.String, oOSRetorno.TabelaServicos))

        Try

            Dim cmd As String
            cmd = Nothing

            acao = flagOp.Alterar 'Nesta tela a operação é sempre Update

            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_os_retorno"
                'ElseIf acao = flagOp.Novo Then
                '    cmd = "spIns_Cg_os_retorno"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GravarPDF(ByVal acao As Integer, ByVal oOSRetornoPDF As DTO.Cg_os_retorno_PDF)
        Dim listaParametros As New List(Of DbParameter)
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, oOSRetornoPDF.Id_os))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ITEM_ID", DbType.Int32, oOSRetornoPDF.Item_id))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EQUIPAMENTO", DbType.Int32, oOSRetornoPDF.Id_equipamento))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@LAUDO_FORNEC", DbType.Binary, oOSRetornoPDF.Laudo_Fornec))

        Try

            Dim cmd As String
            cmd = Nothing

            acao = flagOp.Alterar 'Nesta tela a operação é sempre Update

            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_os_retorno_pdf"
                'ElseIf acao = flagOp.Novo Then
                '    cmd = "spIns_Cg_os_retorno"
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

            cmd = "spDel_Cg_os_retorno"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_os_retorno

    '    Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString

    '    Dim dr As SqlDataReader

    '    dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

    '    Dim oModelo As New DTO.Cg_os_retorno
    '    If dr.HasRows Then
    '        dr.Read()
    '        oModelo.Id_os = CInt(dr.Item("Id_os"))
    '        oModelo.Data_movto = CDate(dr.Item("Data_movto"))
    '        oModelo.Id_loja_origem = CInt(dr.Item("Id_loja_origem"))
    '        oModelo.Nf_transp = dr.Item("Nf_transp")
    '        oModelo.Serie_nf_transp = dr.Item("Serie_nf_transp")
    '        oModelo.Emissao_nf_transp = CDate(dr.Item("Emissao_nf_transp"))
    '        oModelo.Id_fornecedor = CInt(dr.Item("Id_fornecedor"))
    '        oModelo.Id_responsavel_ida = CInt(dr.Item("Id_responsavel_ida"))
    '        oModelo.Status_os = CInt(dr.Item("Status_os"))
    '        oModelo.User_ins = CInt(dr.Item("User_ins"))
    '        oModelo.Data_ins = CDate(dr.Item("Data_ins"))
    '        oModelo.User_upd = CInt(dr.Item("User_upd"))
    '        oModelo.Data_upd = CDate(dr.Item("Data_upd"))

    '    Else
    '        oModelo.Id_os = -1
    '    End If

    '    Return oModelo

    'End Function

    Public Sub GravarPDF_NF_FORNEC(ByVal acao As Integer, ByVal oOS As DTO.Cg_os_PDF_NF_Fornec)
        Dim listaParametros As New List(Of DbParameter)
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_OS", DbType.Int32, oOS.Id_os))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ITEM_ID", DbType.Int32, oOS.Item_id))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EQUIPAMENTO", DbType.Int32, oOS.Id_equipamento))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@PDF", DbType.Binary, oOS.NF_Fornec))

        Try

            Dim cmd As String
            cmd = Nothing

            acao = flagOp.Alterar 'Nesta tela a operação é sempre Update

            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_os_PDF_NF_Fornec"
                'ElseIf acao = flagOp.Novo Then
                '    cmd = "spIns_Cg_os_retorno"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class

