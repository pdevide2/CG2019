'********************************************************
'* LojaBLL
'* Classe BLL do cadastro de Lojas
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

Public Class LojaBLL

    Public Enum flagOp

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum

    Public Sub GravarBLL(ByVal acao As Integer, ByVal oLoja As DTO.Cg_loja)

        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_LOJA", DbType.Int32, oLoja.Id_loja))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@SIGLA", DbType.String, oLoja.Sigla))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@NOME", DbType.String, oLoja.Nome))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ENDERECO", DbType.String, oLoja.Endereco))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@COMPLEMENTO", DbType.String, oLoja.Complemento))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CEP", DbType.String, oLoja.Cep))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CIDADE", DbType.String, oLoja.Cidade))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@BAIRRO", DbType.String, oLoja.Bairro))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@UF", DbType.String, oLoja.Uf))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_TIPO_LOCAL", DbType.Int32, oLoja.Id_tipo_local))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_RESPONSAVEL", DbType.Int32, oLoja.Id_responsavel))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_INS", DbType.Int32, oLoja.User_ins))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_INS", DbType.DateTime, oLoja.Data_ins))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_UPD", DbType.Int32, oLoja.User_upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_UPD", DbType.DateTime, oLoja.Data_upd))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CODIGO", DbType.String, oLoja.Codigo))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@TELEFONE", DbType.String, oLoja.Telefone))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CELULAR", DbType.String, oLoja.Celular))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@LOJA_FISICA", DbType.Boolean, oLoja.LojaFisica))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@PARCERIA", DbType.Boolean, oLoja.Parceria))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_AREA", DbType.String, oLoja.IdArea))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA", DbType.Int32, oLoja.Id_empresa))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_TIPO_LOCAL_ESTOQUE", DbType.Int32, oLoja.Id_Tipo_Local_Estoque))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@TELEFONE2", DbType.String, oLoja.Telefone2))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CELULAR2", DbType.String, oLoja.Celular2))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CELULAR3", DbType.String, oLoja.Celular3))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CELULAR4", DbType.String, oLoja.Celular4))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CELULAR5", DbType.String, oLoja.Celular5))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CELULAR6", DbType.String, oLoja.Celular6))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@INATIVO", DbType.Boolean, oLoja.Inativo))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ULTIMA_ATUALIZACAO", DbType.DateTime, oLoja.Ultima_atualizacao))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@INICIO_VIGENCIA", DbType.DateTime, oLoja.Inicio_vigencia))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@FINAL_VIGENCIA", DbType.DateTime, oLoja.Final_vigencia))

        Try

            Dim cmd As String
            cmd = Nothing
            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_loja"
            ElseIf acao = flagOp.Novo Then
                cmd = "spIns_Cg_loja"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub ExcluirBLL(_KeyId As Integer)
        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_LOJA", DbType.Int32, _KeyId))

        Try

            Dim cmd As String
            cmd = Nothing

            cmd = "spDel_Cg_loja"

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_loja

        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString

        Dim dr As SqlDataReader

        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)

        Dim oModelo As New DTO.Cg_loja
        If dr.HasRows Then
            dr.Read()
            oModelo.Id_loja = CInt(dr.Item("Id_loja"))
            oModelo.Sigla = dr.Item("Sigla")
            oModelo.Nome = dr.Item("Nome")
            oModelo.Endereco = dr.Item("Endereco")
            oModelo.Complemento = dr.Item("Complemento")
            oModelo.Cep = dr.Item("Cep")
            oModelo.Cidade = dr.Item("Cidade")
            oModelo.Bairro = dr.Item("Bairro")
            oModelo.Uf = dr.Item("Uf")
            oModelo.Id_tipo_local = CInt(dr.Item("Id_tipo_local"))
            oModelo.Id_responsavel = CInt(dr.Item("Id_responsavel"))
            oModelo.User_ins = CInt(dr.Item("User_ins"))
            oModelo.Data_ins = CDate(dr.Item("Data_ins"))
            oModelo.User_upd = CInt(dr.Item("User_upd"))
            oModelo.Data_upd = CDate(dr.Item("Data_upd"))
        Else
            oModelo.Id_loja = -1
        End If

        Return oModelo

    End Function

    Public Sub GravarFotoLojaBLL(ByVal acao As Integer, ByVal oLojaFoto As DTO.Cg_loja_foto)
        Dim listaParametros As New List(Of DbParameter)
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_LOJA", DbType.Int32, oLojaFoto.Id_Loja))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@FOTO", DbType.Binary, oLojaFoto.Foto_Loja))
        listaParametros.Add(DAL.DALGenerico.CriarParametro("@FILETYPE", DbType.String, oLojaFoto.Filetype))


        Try

            Dim cmd As String
            cmd = Nothing

            acao = flagOp.Alterar 'Nesta tela a operação é sempre Update

            If acao = flagOp.Alterar Then
                cmd = "spUpd_Cg_Loja_Foto"
                'ElseIf acao = flagOp.Novo Then
                '    cmd = "spIns_Cg_os_retorno"
            End If

            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class

