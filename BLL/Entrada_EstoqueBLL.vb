'********************************************************'* Entrada_chipBLL'* Classe BLL do cadastro de Entrada de Estoque de Chip'* PAULO EDUARDO DEVIDE'* 30-JUL-2016'*'* M�todos:'* GravarBLL()'* ExcluirBLL()'* PesquisaPorIdModelBLL()'*' ********************************************************Imports System.DataImports System.Collections.GenericImports DALImports System.Data.CommonImports System.Data.SqlClientPublic Class Entrada_EstoqueBLL    Public Enum flagOp        Limpar = 0        Novo = 1        Alterar = 2        Excluir = 3        Consulta = 4        Leitura = 5    End Enum    Public Sub GravarBLL(ByVal acao As Integer, ByVal oEntrada_estoque As DTO.Cg_entrada_estoque)        Dim listaParametros As New List(Of DbParameter)        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_ROMANEIO", DbType.Int32, oEntrada_estoque.Id_romaneio))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_MOVTO", DbType.DateTime, oEntrada_estoque.Data_movto))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_LOJA", DbType.Int32, oEntrada_estoque.Id_loja))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_INS", DbType.Int32, oEntrada_estoque.User_ins))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_INS", DbType.DateTime, oEntrada_estoque.Data_ins))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_UPD", DbType.Int32, oEntrada_estoque.User_upd))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_UPD", DbType.DateTime, oEntrada_estoque.Data_upd))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA", DbType.Int32, oEntrada_estoque.Id_empresa))        Try            Dim cmd As String            cmd = Nothing            If acao = flagOp.Alterar Then                cmd = "spUpd_Cg_entrada_estoque"            ElseIf acao = flagOp.Novo Then                cmd = "spIns_Cg_entrada_estoque"            End If            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)        Catch ex As Exception            Throw ex        End Try    End Sub    Public Sub ExcluirBLL(_KeyId As Integer)        Dim listaParametros As New List(Of DbParameter)        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_ROMANEIO", DbType.Int32, _KeyId))        Try            Dim cmd As String            cmd = Nothing            cmd = "spDel_Cg_entrada_estoque"            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)        Catch ex As Exception            Throw ex        End Try    End Sub    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_entrada_chip        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString        Dim dr As SqlDataReader        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)        Dim oModelo As New DTO.Cg_entrada_chip        If dr.HasRows Then            dr.Read()            oModelo.Id_romaneio = CInt(dr.Item("Id_romaneio"))            oModelo.Data_movto = CDate(dr.Item("Data_movto"))            oModelo.Id_loja = CInt(dr.Item("Id_loja"))            oModelo.User_ins = CInt(dr.Item("User_ins"))            oModelo.Data_ins = CDate(dr.Item("Data_ins"))            oModelo.User_upd = CInt(dr.Item("User_upd"))            oModelo.Data_upd = CDate(dr.Item("Data_upd"))        Else            oModelo.Id_romaneio = -1        End If        Return oModelo    End FunctionEnd Class