

Imports System.Data
Imports System.Collections.Generic
Imports DAL
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class PecaBLL

    Public Enum flagOp

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum

    Public Sub GravarBLL(ByVal acao As Integer, ByVal oPeca As DTO.Cg_peca)

        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_PECA", DbType.Int32, oPeca.Id_peca))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@NOME_PECA", DbType.String, oPeca.Nome_peca))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DESCRICAO", DbType.String, oPeca.Descricao))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_MARCA", DbType.Int32, oPeca.Id_marca))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_CATEGORIA", DbType.Int32, oPeca.Id_categoria))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_FORNECEDOR", DbType.Int32, oPeca.Id_fornecedor))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_FINALIDADE", DbType.Int32, oPeca.Id_finalidade))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ESTOQUE", DbType.Int32, oPeca.Estoque))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ESTOQUE_MIN", DbType.Int32, oPeca.Estoque_min))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ESTOQUE_MAX", DbType.Int32, oPeca.Estoque_max))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@UNIDADE", DbType.String, oPeca.Unidade))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_AQUISICAO", DbType.Datetime, oPeca.Data_aquisicao))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DIAS_GARANTIA", DbType.Int32, oPeca.Dias_garantia))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CUSTO", DbType.Decimal, oPeca.Custo))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@REF_FORNEC", DbType.String, oPeca.Ref_fornec))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@OBS", DbType.String, oPeca.Obs))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_INS", DbType.Int32, oPeca.User_ins))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_INS", DbType.Datetime, oPeca.Data_ins))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_UPD", DbType.Int32, oPeca.User_upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_UPD", DbType.DateTime, oPeca.Data_upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA", DbType.Int32, oPeca.Id_empresa))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@SERIE", DbType.String, oPeca.Serie))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@MODELO", DbType.String, oPeca.Modelo))

        Try

            Dim cmd As String
            cmd = Nothing
            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_peca"
            ElseIf acao = flagOp.Novo Then
                cmd = "spIns_Cg_peca"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub ExcluirBLL(_KeyId As Integer)
        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_PECA", DbType.Int32, _KeyId))

        Try

            Dim cmd As String
            cmd = Nothing

            cmd = "spDel_Cg_peca"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_peca

        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim oModelo As New DTO.Cg_peca
        If dr.HasRows Then
            dr.Read()
            oModelo.Id_peca = CInt(dr.Item("Id_peca"))
            oModelo.Nome_peca = dr.Item("Nome_peca")
            oModelo.Descricao = dr.Item("Descricao")
            oModelo.Id_marca = CInt(dr.Item("Id_marca"))
            oModelo.Id_categoria = CInt(dr.Item("Id_categoria"))
            oModelo.Id_fornecedor = CInt(dr.Item("Id_fornecedor"))
            oModelo.Id_finalidade = CInt(dr.Item("Id_finalidade"))
            oModelo.Estoque = CInt(dr.Item("Estoque"))
            oModelo.Estoque_min = CInt(dr.Item("Estoque_min"))
            oModelo.Estoque_max = CInt(dr.Item("Estoque_max"))
            oModelo.Unidade = dr.Item("Unidade")
            oModelo.Data_aquisicao = CDate(dr.Item("Data_aquisicao"))
            oModelo.Dias_garantia = CInt(dr.Item("Dias_garantia"))
            oModelo.Custo = CDec(dr.Item("Custo"))
            oModelo.Foto = dr.Item("Foto")
            oModelo.Ref_fornec = dr.Item("Ref_fornec")
            oModelo.Obs = dr.Item("Obs")
            oModelo.User_ins = CInt(dr.Item("User_ins"))
            oModelo.Data_ins = CDate(dr.Item("Data_ins"))
            oModelo.User_upd = CInt(dr.Item("User_upd"))
            oModelo.Data_upd = CDate(dr.Item("Data_upd"))
        Else
            oModelo.Id_peca = -1
        End If

        Return oModelo

    End Function

    Public Sub GravarFotoPecaBLL(ByVal acao As Integer, ByVal oPeca As DTO.Cg_peca_foto)
        Dim listaParametros As New List(Of DbParameter)
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_PECA", DbType.Int32, oPeca.Id_peca))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@FOTO", DbType.Binary, oPeca.Foto_peca))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@FILETYPE", DbType.String, oPeca.Filetype))


        Try

            Dim cmd As String
            cmd = Nothing

            acao = flagOp.Alterar 'Nesta tela a operação é sempre Update

            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_Peca_Foto"
                'ElseIf acao = flagOp.Novo Then
                '    cmd = "spIns_Cg_os_retorno"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class

