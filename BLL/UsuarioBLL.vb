'********************************************************'* UsuarioBLL'* Classe BLL do cadastro de Usuarios'* PAULO EDUARDO DEVIDE'* 30-JUL-2016'*'* M�todos:'* GravarBLL()'* ExcluirBLL()'* PesquisaPorIdModelBLL()'*' ********************************************************Imports System.DataImports System.Collections.GenericImports DALImports System.Data.CommonImports System.Data.SqlClientPublic Class UsuarioBLL    Public Enum flagOp        Limpar = 0        Novo = 1        Alterar = 2        Excluir = 3        Consulta = 4        Leitura = 5    End Enum    Public Sub GravarBLL(ByVal acao As Integer, ByVal oUsuario As DTO.Cg_usuario)        Dim listaParametros As New List(Of DbParameter)        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_USUARIO", DbType.Int32, oUsuario.Id_usuario))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@APELIDO", DbType.String, oUsuario.Apelido))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@NOME", DbType.String, oUsuario.Nome))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CPF", DbType.String, oUsuario.Cpf))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@RG", DbType.String, oUsuario.Rg))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@EMAIL", DbType.String, oUsuario.Email))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@TELEFONE", DbType.String, oUsuario.Telefone))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@WHATSAPP", DbType.String, oUsuario.Whatsapp))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CEP", DbType.String, oUsuario.Cep))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ENDERECO", DbType.String, oUsuario.Endereco))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@COMPLEMENTO", DbType.String, oUsuario.Complemento))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CIDADE", DbType.String, oUsuario.Cidade))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@BAIRRO", DbType.String, oUsuario.Bairro))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@UF", DbType.String, oUsuario.Uf))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@LOGIN", DbType.String, oUsuario.Login))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_STATUS", DbType.Int32, oUsuario.Id_status))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_INS", DbType.Int32, oUsuario.User_ins))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_INS", DbType.DateTime, oUsuario.Data_ins))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@USER_UPD", DbType.Int32, oUsuario.User_upd))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DATA_UPD", DbType.DateTime, oUsuario.Data_upd))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA", DbType.Int32, oUsuario.Id_empresa))        Try            Dim cmd As String            cmd = Nothing            If acao = flagOp.Alterar Then                cmd = "spUpd_Cg_usuario"            ElseIf acao = flagOp.Novo Then                cmd = "spIns_Cg_usuario"            End If            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)        Catch ex As Exception            Throw ex        End Try    End Sub    Public Sub ExcluirBLL(_KeyId As Integer)        Dim listaParametros As New List(Of DbParameter)        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_USUARIO", DbType.Int32, _KeyId))        Try            Dim cmd As String            cmd = Nothing            cmd = "spDel_Cg_usuario"            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)        Catch ex As Exception            Throw ex        End Try    End Sub    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_usuario        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString        Dim dr As SqlDataReader        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)        Dim oModelo As New DTO.Cg_usuario        If dr.HasRows Then            dr.Read()            oModelo.Id_usuario = CInt(dr.Item("Id_usuario"))            oModelo.Apelido = dr.Item("Apelido")            oModelo.Nome = dr.Item("Nome")            oModelo.Cpf = dr.Item("Cpf")            oModelo.Rg = dr.Item("Rg")            oModelo.Email = dr.Item("Email")            oModelo.Telefone = dr.Item("Telefone")            oModelo.Whatsapp = dr.Item("Whatsapp")            oModelo.Cep = dr.Item("Cep")            oModelo.Endereco = dr.Item("Endereco")            oModelo.Complemento = dr.Item("Complemento")            oModelo.Cidade = dr.Item("Cidade")            oModelo.Bairro = dr.Item("Bairro")            oModelo.Uf = dr.Item("Uf")            oModelo.Login = dr.Item("Login")            oModelo.Id_status = CInt(dr.Item("Id_status"))            oModelo.User_ins = CInt(dr.Item("User_ins"))            oModelo.Data_ins = CDate(dr.Item("Data_ins"))            oModelo.User_upd = CInt(dr.Item("User_upd"))            oModelo.Data_upd = CDate(dr.Item("Data_upd"))        Else            oModelo.Id_usuario = -1        End If        Return oModelo    End FunctionEnd Class