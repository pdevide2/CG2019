Imports System.DataImports System.Collections.GenericImports DALImports System.Data.CommonImports System.Data.SqlClientPublic Class EmpresaBLLPublic Enum flagOp        Limpar = 0        Novo = 1        Alterar = 2        Excluir = 3        Consulta = 4        Leitura = 5    End Enum    Public Sub GravarBLL(ByVal acao As Integer, ByVal oEmpresa As DTO.Cg_empresa)        Dim listaParametros As New List(Of DbParameter)        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA",DbType.Int32,oEmpresa.Id_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@NOME_EMPRESA",DbType.String,oEmpresa.Nome_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@SIGLA_EMPRESA",DbType.String,oEmpresa.Sigla_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ENDERECO_EMPRESA",DbType.String,oEmpresa.Endereco_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CEP_EMPRESA",DbType.String,oEmpresa.Cep_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@COMPLEMENTO_EMPRESA",DbType.String,oEmpresa.Complemento_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@BAIRRO_EMPRESA",DbType.String,oEmpresa.Bairro_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CIDADE_EMPRESA",DbType.String,oEmpresa.Cidade_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@UF_EMPRESA",DbType.String,oEmpresa.Uf_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@REFERENCIA_ENDERECO",DbType.String,oEmpresa.Referencia_endereco))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CONTATO_EMPRESA",DbType.String,oEmpresa.Contato_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@CELULAR_EMPRESA",DbType.String,oEmpresa.Celular_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@TELEFONE_EMPRESA",DbType.String,oEmpresa.Telefone_empresa))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@OBSERVACAO",DbType.String,oEmpresa.Observacao))        listaParametros.Add(DAL.DALGenerico.CriarParametro("@EMAIL", DbType.String, oEmpresa.Email))        Try            Dim cmd As String            cmd = Nothing            If acao = flagOp.Alterar Then                cmd = "spUpd_Cg_empresa"            ElseIf acao = flagOp.Novo Then                cmd = "spIns_Cg_empresa"            End If            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)        Catch ex As Exception            Throw ex        End Try    End Sub    Public Sub ExcluirBLL(_KeyId As Integer)        Dim listaParametros As New List(Of DbParameter)        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_EMPRESA",DbType.Int32,_KeyId))        Try            Dim cmd As String            cmd = Nothing            cmd = "spDel_Cg_empresa"            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)        Catch ex As Exception            Throw ex        End Try    End Sub    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.Cg_empresa        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString        Dim dr As SqlDataReader        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)        Dim oModelo As New DTO.Cg_empresa        If dr.HasRows Then            dr.Read()        oModelo.Id_empresa = CInt(dr.Item("Id_empresa"))        oModelo.Nome_empresa = dr.Item("Nome_empresa")        oModelo.Sigla_empresa = dr.Item("Sigla_empresa")        oModelo.Endereco_empresa = dr.Item("Endereco_empresa")        oModelo.Cep_empresa = dr.Item("Cep_empresa")        oModelo.Complemento_empresa = dr.Item("Complemento_empresa")        oModelo.Bairro_empresa = dr.Item("Bairro_empresa")        oModelo.Cidade_empresa = dr.Item("Cidade_empresa")        oModelo.Uf_empresa = dr.Item("Uf_empresa")        oModelo.Referencia_endereco = dr.Item("Referencia_endereco")        oModelo.Contato_empresa = dr.Item("Contato_empresa")        oModelo.Celular_empresa = dr.Item("Celular_empresa")        oModelo.Telefone_empresa = dr.Item("Telefone_empresa")        oModelo.Observacao = dr.Item("Observacao")        Else        oModelo.Id_empresa = -1        End If        Return oModelo    End FunctionEnd Class