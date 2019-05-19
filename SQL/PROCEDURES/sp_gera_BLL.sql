/*
PAULO EDUARDO DEVIDE
GERADOR DE CÓDIGO DA CLASSE BLL (CLASSE DE NEGÓCIO)
JULHO/16

sintaxe da chamada:

EXEC sp_gera_BLL @tabela = 'CG_MODULO'

*/

alter procedure sp_gera_BLL 
@tabela varchar(50)
as
BEGIN

SET NOCOUNT ON

declare @qtdcolunas int
declare @qtdcolunas2 int, @i int
declare @campo varchar(100), @campo2 varchar(100)
declare @tab char(1)
declare @tipo varchar(30) 
declare @tamanho varchar(50)
declare @valordefault varchar(50)
declare @virgula char(1)
declare @objeto varchar(50)

set @tab = char(9)

select @qtdcolunas = count(*) from syscolumns where id = object_id(@tabela)

CREATE TABLE #CHAVES (COLID INT IDENTITY(1,1), COL_NAME VARCHAR(50) NULL)

INSERT INTO #CHAVES (COL_NAME)
SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE As K 
where TABLE_NAME =	@tabela
AND CONSTRAINT_NAME = (SELECT NAME FROM SYSOBJECTS As U
    WHERE K.TABLE_NAME = OBJECT_NAME(U.Parent_Obj) AND
        U.XTYPE = 'PK')
order by ORDINAL_POSITION

select 
	sc.name as campo, sc.id, sc.xtype, sc.length, sc.prec, sc.xscale, sc.colid, sc.isnullable, st.name as tipo, 
	TipoVB = 
	case
	when st.name = 'bigint' then 'DbType.Int64'
	when st.name = 'bit' then 'DbType.Boolean'
	when st.name = 'char' then 'DbType.String'
	when st.name = 'date' then 'DbType.Date'
	when st.name = 'datetime' then 'DbType.Datetime'
	when st.name = 'decimal' then 'DbType.Decimal'
	when st.name = 'float' then 'DbType.Decimal'
	when st.name = 'image' then 'DbType.Object'
	when st.name = 'int' then 'DbType.Int32'
	when st.name = 'money' then 'DbType.Currency'
	when st.name = 'nchar' then 'DbType.String'
	when st.name = 'ntext' then 'DbType.String'
	when st.name = 'numeric' then 'DbType.Decimal'
	when st.name = 'nvarchar' then 'DbType.String'
	when st.name = 'real' then 'DbType.Decimal'
	when st.name = 'smalldatetime' then 'DbType.Datetime'
	when st.name = 'smallint' then 'DbType.Int32'
	when st.name = 'smallmoney' then 'DbType.Currency'
	when st.name = 'sql_variant' then 'VariantType'
	when st.name = 'sysname' then 'DbType.String'
	when st.name = 'text' then 'DbType.String'
	when st.name = 'time' then 'DbType.Date'
	when st.name = 'tinyint' then 'DbType.Byte'
	when st.name = 'uniqueidentifier' then 'DbType.String'
	when st.name = 'varbinary' then 'VariantType'
	when st.name = 'varchar' then 'DbType.String'
	when st.name = 'xml' then 'DbType.String'
	else 'DbType.String'
	end
into #tmp_atributos
from 
	syscolumns sc 
inner join 
	systypes st on st.xtype = sc.xtype
where 
	sc.id = object_id(@tabela) order by sc.colid

create table #classeBLL (campo varchar(200) null)

/*Declaração dos Imports de Namespaces*/
insert into #classeBLL values ('Imports System.Data')
insert into #classeBLL values ('Imports System.Collections.Generic')
insert into #classeBLL values ('Imports DAL')
insert into #classeBLL values ('Imports System.Data.Common')
insert into #classeBLL values ('Imports System.Data.SqlClient')
insert into #classeBLL values ('')

/*Corpo da Classe*/
DECLARE @CLASSE VARCHAR(50)
SET @CLASSE = replace(@tabela,'CG_','')
SET @CLASSE = LEFT(UPPER(@CLASSE),1)+LOWER(SUBSTRING(@CLASSE,2,50))+'BLL'

insert into #classeBLL values ('Public Class '+@CLASSE)
insert into #classeBLL values ('')
insert into #classeBLL values ('Public Enum flagOp')
insert into #classeBLL values ('')
insert into #classeBLL values ('        Limpar = 0')
insert into #classeBLL values ('        Novo = 1')
insert into #classeBLL values ('        Alterar = 2')
insert into #classeBLL values ('        Excluir = 3')
insert into #classeBLL values ('        Consulta = 4')
insert into #classeBLL values ('        Leitura = 5')
insert into #classeBLL values ('')
insert into #classeBLL values ('    End Enum')
insert into #classeBLL values ('')
insert into #classeBLL values ('    Public Sub GravarBLL(ByVal acao As Integer, ByVal o'+replace(@CLASSE,'BLL','')+' As DTO.'+upper(left(@tabela,1)) + substring(lower(@tabela),2,50)+')')
insert into #classeBLL values ('')
insert into #classeBLL values ('        Dim listaParametros As New List(Of DbParameter)')
insert into #classeBLL values ('')

set @i=1
WHILE @i <= @qtdcolunas
begin
/*
insert into #classeBLL values ('        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_CARGO", DbType.Int32, oCargo.Id_cargo))')
insert into #classeBLL values ('        listaParametros.Add(DAL.DALGenerico.CriarParametro("@DESC_CARGO", DbType.String, oCargo.Desc_cargo))')
*/
	select @campo = upper(campo), @tipo = TipoVB, 
			@objeto = 'o' + replace(@CLASSE,'BLL','') + '.' + upper(left(campo,1)) + substring(lower(campo),2,50)
	from #tmp_atributos 
	where colid=@i

	insert into #classeBLL values ('        listaParametros.Add(DAL.DALGenerico.CriarParametro("@'+@campo+'",'+@tipo+','+@objeto+'))')
	set @i = @i + 1

end

insert into #classeBLL values ('')
insert into #classeBLL values ('        Try')
insert into #classeBLL values ('')
insert into #classeBLL values ('            Dim cmd As String')
insert into #classeBLL values ('            cmd = Nothing')
insert into #classeBLL values ('            If acao = flagOp.Alterar Then')
insert into #classeBLL values ('                cmd = "spUpd_'+upper(left(@tabela,1)) + substring(lower(@tabela),2,50)+'"')
insert into #classeBLL values ('            ElseIf acao = flagOp.Novo Then')
insert into #classeBLL values ('                cmd = "spIns_'+upper(left(@tabela,1)) + substring(lower(@tabela),2,50)+'"')
insert into #classeBLL values ('            End If')
insert into #classeBLL values ('')
insert into #classeBLL values ('            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)')
insert into #classeBLL values ('')
insert into #classeBLL values ('        Catch ex As Exception')
insert into #classeBLL values ('            Throw ex')
insert into #classeBLL values ('        End Try')
insert into #classeBLL values ('')
insert into #classeBLL values ('    End Sub')
insert into #classeBLL values ('')
insert into #classeBLL values ('')
insert into #classeBLL values ('    Public Sub ExcluirBLL(_KeyId As Integer)')
insert into #classeBLL values ('        Dim listaParametros As New List(Of DbParameter)')
insert into #classeBLL values ('')

set @i=1

select * 
into #tmp_atributos2
from #tmp_atributos
where campo in
(
select COL_NAME
from #CHAVES
)

set @qtdcolunas2 = @@ROWCOUNT

WHILE @i <= @qtdcolunas2
begin
/*
insert into #classeBLL values ('        listaParametros.Add(DAL.DALGenerico.CriarParametro("@ID_CARGO", DbType.Int32, _KeyId))')
*/
	select @campo = upper(campo), @tipo = TipoVB, 
			@objeto = 'o' + replace(@CLASSE,'BLL','') + '.' + upper(left(campo,1)) + substring(lower(campo),2,50)
	from #tmp_atributos2 
	where colid=@i

	insert into #classeBLL values ('        listaParametros.Add(DAL.DALGenerico.CriarParametro("@'+@campo+'",'+@tipo+','+'_KeyId'+'))')
	set @i = @i + 1

end


insert into #classeBLL values ('')
insert into #classeBLL values ('        Try')
insert into #classeBLL values ('')
insert into #classeBLL values ('            Dim cmd As String')
insert into #classeBLL values ('            cmd = Nothing')
insert into #classeBLL values ('')

insert into #classeBLL values ('            cmd = "spDel_'+upper(left(@tabela,1)) + substring(lower(@tabela),2,50)+'"')

insert into #classeBLL values ('')
insert into #classeBLL values ('            DAL.DALGenerico.ExecutarComando("SQLServer", cmd, CommandType.StoredProcedure, listaParametros, DAL.DALGenerico.TipoDeComando.ExecuteNonQuery)')
insert into #classeBLL values ('')
insert into #classeBLL values ('        Catch ex As Exception')
insert into #classeBLL values ('            Throw ex')
insert into #classeBLL values ('        End Try')
insert into #classeBLL values ('    End Sub')
insert into #classeBLL values ('')

insert into #classeBLL values ('    Public Function PesquisaPorIdModelBLL(ByVal KeyId As Integer, ByVal strTabela As String, colunaId As String) As DTO.'+upper(left(@tabela,1)) + substring(lower(@tabela),2,50))
insert into #classeBLL values ('')
insert into #classeBLL values ('        Dim sql = "SELECT * FROM " & strTabela & " WHERE " & colunaId & " = " & KeyId.ToString')
insert into #classeBLL values ('')
insert into #classeBLL values ('        Dim dr As SqlDataReader')
insert into #classeBLL values ('')
insert into #classeBLL values ('        dr = DAL.DALGenerico.ExecutarComando("SQLServer", sql, CommandType.Text, Nothing, DALGenerico.TipoDeComando.ExecuteReader)')
insert into #classeBLL values ('')
insert into #classeBLL values ('        Dim oModelo As New DTO.'+upper(left(@tabela,1)) + substring(lower(@tabela),2,50))
insert into #classeBLL values ('        If dr.HasRows Then')
insert into #classeBLL values ('            dr.Read()')

set @i=1
WHILE @i <= @qtdcolunas
begin
/*
insert into #classeBLL values ('            oModelo.Id_cargo = CInt(dr.Item("Id_cargo"))')
insert into #classeBLL values ('            oModelo.Desc_cargo = dr.Item("desc_cargo")')
-- conversão de tipos VB.Net
CBool(expression)
CByte(expression)
CCur(expression)
CDate(expression)
CDbl(expression)
CDec(expression)
CInt(expression)
CLng(expression)
CSng(expression)
CStr(expression)
CVar(expression)

*/
	select @campo = upper(campo), @tipo = TipoVB, 
			@objeto = 'o' + replace(@CLASSE,'BLL','') + '.' + upper(left(campo,1)) + substring(lower(campo),2,50),
			@campo2 = 
			case TipoVB
			when 'DbType.Int32' then 'CInt(dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'"))'
			when 'DbType.Int64' then 'CInt(dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'"))'
			when 'DbType.Boolean' then 'CBool(dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'"))'
			when 'DbType.Datetime' then 'CDate(dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'"))'
			when 'DbType.Decimal' then 'CDec(dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'"))'
			else 'dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'")' /*string*/
			end
	from #tmp_atributos 
	where colid=@i


	insert into #classeBLL values ('        oModelo.'+upper(left(@campo,1)) + substring(lower(@campo),2,50)+' = ' + @campo2 )

	set @i = @i + 1

end



insert into #classeBLL values ('        Else')

set @i=1
WHILE @i <= @qtdcolunas2
begin
/*
insert into #classeBLL values ('            oModelo.Id_cargo = -1')
*/
	select @campo = upper(campo), @tipo = TipoVB, 
			@objeto = 'o' + replace(@CLASSE,'BLL','') + '.' + upper(left(campo,1)) + substring(lower(campo),2,50),
			@campo2 = 
			case TipoVB
			when 'DbType.Int32' then 'CInt(dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'"))'
			when 'DbType.Int64' then 'CInt(dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'"))'
			when 'DbType.Boolean' then 'CBool(dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'"))'
			when 'DbType.Datetime' then 'CDate(dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'"))'
			when 'DbType.Decimal' then 'CDec(dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'"))'
			else 'dr.Item("'+upper(left(campo,1)) + substring(lower(campo),2,50)+'")' /*string*/
			end
	from #tmp_atributos2 
	where colid=@i


	insert into #classeBLL values ('        oModelo.'+upper(left(@campo,1)) + substring(lower(@campo),2,50)+' = -1' /*+ @campo2*/ )

	set @i = @i + 1

end


insert into #classeBLL values ('        End If')
insert into #classeBLL values ('')
insert into #classeBLL values ('        Return oModelo')
insert into #classeBLL values ('')
insert into #classeBLL values ('    End Function')
insert into #classeBLL values ('End Class')

select * from #classeBLL
SET NOCOUNT OFF

END