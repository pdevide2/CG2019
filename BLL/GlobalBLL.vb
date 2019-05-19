'********************************************************
'* GlobalBLL
'* Classe BLL Generica do Sistema
'* PAULO EDUARDO DEVIDE
'* 23-JUL-2016
'*
'* Métodos:
'* PesquisarTudoBLL()
'* verPermissaoBLL()
'* PesquisaPorIdDataReaderBLL()
'* getPKBLL()
'* NovaChaveBLL()
'* 
' ********************************************************

Imports System.Data
Imports System.Data.Common
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports DAL

Public Class GlobalBLL


    Public Shared Function PesquisarTudoBLL(ByVal strTabela As String) As DataSet

        Try
            Dim ds = New DataSet
            Dim cmd = "spLista_" & strTabela

            Return DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, Nothing, DALGenerico.TipoDeComando.ExecuteDataSet)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function PesquisarFkBLL(ByVal cmdSQL As String) As DataSet

        Try
            Dim ds = New DataSet
            Dim cmd = cmdSQL

            Return DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteDataSet)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function SqlExecDT(ByVal cmdSQL As String) As DataTable
        '**********
        '* Executa um select (query) no banco de dados SQL 
        '* Retorna um DataTable (cursor) simples
        '* Util para pegar dados de tabelas relacionadas para
        '* completar cadastro em telas e relatórios
        '====================================================
        '* PAULO DEVIDE - DEZ' 16
        '*/

        Try
            Dim dt = New DataTable
            Dim cmd = cmdSQL

            Return DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteDataTable)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function SqlLoadImage(ByVal cmdSQL As String) As Byte()
        'Exemplo de query:
        'select LAUDO_FORNEC from cg_os_item where id_os = 72 and ITEM_ID=3
        Try
            SqlLoadImage = DAL.DALGenerico.ExecutarComando("SQLServer", cmdSQL, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteScalar)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function PesquisarFkListaBLL(ByVal cmdSQL As String) As ArrayList

        Try
            Dim ds = New DataSet
            Dim cmd = cmdSQL

            ds = DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteDataSet)

            Dim myArrList As New ArrayList()

            For Each datarow As DataRow In ds.Tables(0).Rows

                myArrList.Add(datarow)

            Next

            Return myArrList

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    'Public Shared Function CompletaTexto()

    'End Function

    '!' Retorna o comando Select ... FROM da propriedade VIEW OU TABELA
    Public Shared Function getComandoSQL(ByVal _tabela As String) As String

        Dim sql = "Exec sp_ComandoListarSQL '" & _tabela & "'"

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim retorno As String
        If dr.HasRows Then
            dr.Read()
            retorno = dr.Item("COMANDO").ToString

        Else
            retorno = ""
        End If

        Return retorno
    End Function

    '!' Retorna o nome da coluna de filtro para realizar a busca por LIKE '%'
    Public Shared Function getColunaFiltroSQL(ByVal _tabela As String) As String

        Dim sql = "Exec sp_getColunaFiltro '" & _tabela & "'"

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim retorno As String
        If dr.HasRows Then
            dr.Read()
            retorno = dr.Item("COLUNA").ToString

        Else
            retorno = ""
        End If

        Return retorno
    End Function

    Public Function getPermissaoBLL(ByVal intModulo As Integer, ByVal intUsuario As Integer) As String

        Dim sql = "Exec spVer_Permissao " & intModulo.ToString & "," & intUsuario.ToString

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim retorno As String
        If dr.HasRows Then
            dr.Read()
            retorno = dr.Item("PERMISSAO").ToString

        Else
            retorno = ""
        End If

        Return retorno
    End Function
    Public Function validaLoginBLL(ByVal _login As String, ByVal _senha As String, ByVal _siglaEmpresa As String) As Integer 'retorna o Id_usuario se login for validado ou -1 caso contrário

        Dim sql As String
        'sql = "select  dbo.fx_Desencriptar(senha) as senha2, CG_USUARIO.* from CG_USUARIO where CG_USUARIO.LOGIN = '" & _login & "' "

        sql = "select  dbo.fx_Desencriptar(senha) as senha2, "
        sql += " A.ID_USUARIO, A.APELIDO, A.NOME, A.CPF, A.RG, A.EMAIL, A.TELEFONE,"
        sql += " A.WHATSAPP, A.CEP, A.ENDERECO, A.COMPLEMENTO, A.CIDADE, A.BAIRRO, A.UF,"
        sql += " A.LOGIN, A.ID_STATUS, A.PALAVRA_CHAVE, A.ID_PERGUNTA, B.ID_EMPRESA, C.SIGLA_EMPRESA, B.ID_PERFIL "
        sql += " from CG_USUARIO A"
        sql += " INNER JOIN CG_EMPRESA_VS_USUARIOS B"
        sql += " ON B.ID_USUARIO = A.ID_USUARIO"
        sql += " INNER JOIN CG_EMPRESA C ON C.ID_EMPRESA = B.ID_EMPRESA"
        sql += " WHERE A.LOGIN = '" & _login & "' AND C.SIGLA_EMPRESA = '" & _siglaEmpresa & "'"


        Dim dr As SqlDataReader


        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim strSenhaDB As String
        Dim retorno As Integer = -1

        If dr.HasRows Then
            dr.Read()
            strSenhaDB = dr.Item("senha2").ToString

            If Trim(_senha) = Trim(strSenhaDB) Then
                retorno = CInt(dr.Item("id_usuario"))
            End If

        Else 'Se usuario não existir cadastro na empresa, então login invalido
            retorno = -1
        End If

        Return retorno
    End Function

    Public Shared Function PesquisaObjModelFkPorId(ByRef oFk As DTO.PesquisaFK) As Object

        Dim csql As String

        csql = "SELECT " & oFk.CampoId & ", " & oFk.CampoDesc & _
                    " FROM " & oFk.Tabela & " WHERE " & oFk.CampoId & " = " & _
                    oFk.TxtId.ToString

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", csql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        If dr.HasRows Then
            dr.Read()

            oFk.TxtId = dr.Item(oFk.CampoId).ToString
            oFk.TxtDesc = dr.Item(oFk.CampoDesc).ToString

            Return True

        Else
            Return False
        End If

        Return True
    End Function

    Public Function PesquisaPorIdDataReaderBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As SqlDataReader

        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)


        Return dr
    End Function
    Public Shared Function getPKBLL(ByVal strTabela As String) As List(Of String)

        Dim sql = "Exec sp_pkeys '" & strTabela & "'"
        Dim dt = New DataTable
        dt = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteDataTable)

        Dim retorno As List(Of String) = New List(Of String)
        For Each item As DataRow In dt.Rows
            retorno.Add(item("COLUMN_NAME").ToString)
        Next
        Return retorno

    End Function

    Public Function NovaChaveBLL(ByVal strTabela) As Integer
        Dim sql = "Exec spNovaChave '" & strTabela & "'"

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim retorno As Integer
        If dr.HasRows Then
            dr.Read()
            retorno = CInt(dr.Item("KeyId"))

        Else
            retorno = -1
        End If

        Return retorno

    End Function

    Public Shared Function getNewId() As String

        Dim sql = "select newid() as NEW_ID"

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim retorno As String
        If dr.HasRows Then
            dr.Read()
            retorno = dr.Item("NEW_ID").ToString

        Else
            retorno = ""
        End If

        Return retorno
    End Function

    Public Sub GravarGenericoBLL(cmdsql As String)

        Try

            DAL.DALGenerico.ExecutarComando("SQLServer", cmdsql, CommandType.Text, Nothing, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class

