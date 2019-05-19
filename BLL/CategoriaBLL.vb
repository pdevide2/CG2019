Imports System.DataImports System.Collections.GenericImports DALImports System.Data.CommonImports System.Data.SqlClientPublic Class CategoriaBLLPublic Enum flagOp        Limpar = 0        Novo = 1        Alterar = 2        Excluir = 3        Consulta = 4        Leitura = 5    End Enum    Public Sub GravarBLL(ByVal acao As Integer, ByVal oCategoria As DTO.Cg_categoria)        Dim listaParametros As New List(Of DbParameter)        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_CATEGORIA",DbType.Int32,oCategoria.Id_categoria))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DESC_CATEGORIA",DbType.String,oCategoria.Desc_categoria))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_INS",DbType.Int32,oCategoria.User_ins))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_INS",DbType.Datetime,oCategoria.Data_ins))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_UPD",DbType.Int32,oCategoria.User_upd))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_UPD",DbType.Datetime,oCategoria.Data_upd))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA", DbType.Int32, oCategoria.Id_empresa))        Try            Dim cmd As String            cmd = Nothing            If acao = flagOp.Alterar Then                cmd = "spUpd_Cg_categoria"            ElseIf acao = flagOp.Novo Then                cmd = "spIns_Cg_categoria"            End If            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)        Catch ex As Exception            Throw ex        End Try    End Sub    Public Sub ExcluirBLL(_KeyId As Integer)        Dim listaParametros As New List(Of DbParameter)        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_CATEGORIA",DbType.Int32,_KeyId))        Try            Dim cmd As String            cmd = Nothing            cmd = "spDel_Cg_categoria"            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)        Catch ex As Exception            Throw ex        End Try    End Sub    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_categoria        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString        Dim dr As SqlDataReader        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)        Dim oModelo As New DTO.Cg_categoria        If dr.HasRows Then            dr.Read()        oModelo.Id_categoria = CInt(dr.Item("Id_categoria"))        oModelo.Desc_categoria = dr.Item("Desc_categoria")        oModelo.User_ins = CInt(dr.Item("User_ins"))        oModelo.Data_ins = CDate(dr.Item("Data_ins"))        oModelo.User_upd = CInt(dr.Item("User_upd"))        oModelo.Data_upd = CDate(dr.Item("Data_upd"))        Else        oModelo.Id_categoria = -1        End If        Return oModelo    End FunctionEnd Class