USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[ListaCategorias]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListaCategorias]
as
select * from categorias

GO
/****** Object:  StoredProcedure [dbo].[sp_ComandoListarSQL]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* sp_ComandoListarSQL CG_MODULO */
CREATE PROCEDURE [dbo].[sp_ComandoListarSQL]
@TABELA VARCHAR(50)
AS
BEGIN

DECLARE @I INT
DECLARE @TOT INT
DECLARE @COMANDO VARCHAR(8000)
DECLARE @COLUNA VARCHAR(50)
DECLARE @VIRGULA VARCHAR(10)

SELECT 
	IDENTITY(INT,1,1) AS ID, 
	TABELA, 
	COLUNA, 
	IDCOLUNA, 
	ORDERCOL, 
	CHAVE, 
	TIPODADO, 
	COLUNA_FILTRO, 
	APELIDO_COLUNA, 
	MOSTRA_COLUNA
INTO #TMPPESQ
FROM 
	CG_PARAMETRO_PESQUISA_DINAMICA
WHERE 
	TABELA = @TABELA
	AND MOSTRA_COLUNA = 1
ORDER BY 	ORDERCOL

SET @TOT = @@ROWCOUNT
SET @I = 1
SET @COMANDO = 'SELECT '

WHILE @I <= @TOT
BEGIN

	SELECT @COLUNA = RTRIM(LTRIM(COLUNA)) 
	FROM #TMPPESQ 
	WHERE ID = @I
	SET @VIRGULA = CASE
					WHEN @I<@TOT THEN ','
					ELSE ' '
					END

	 SET @COMANDO = @COMANDO + LTRIM(RTRIM(@COLUNA)) + @VIRGULA
	 SET @I = @I + 1		
END

SELECT @COMANDO + ' FROM ' + @TABELA AS COMANDO

END


GO
/****** Object:  StoredProcedure [dbo].[sp_gera_BLL]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
PAULO EDUARDO DEVIDE
GERADOR DE CÓDIGO DA CLASSE BLL (CLASSE DE NEGÓCIO)
JULHO/16

sintaxe da chamada:

EXEC sp_gera_BLL @tabela = 'CG_MODULO'

*/

CREATE procedure [dbo].[sp_gera_BLL] 
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

CREATE TABLE #CHAVES (COLID INT IDENTITY(1,1), COL_NAME VARCHAR(50)  COLLATE Latin1_General_CI_AI NULL)

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


GO
/****** Object:  StoredProcedure [dbo].[sp_gera_DTO]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure  [dbo].[sp_gera_DTO] 
@tabela varchar(50) 
as

begin

create table #comando (campo1 varchar(150) null)

declare @qtdcolunas int, @i int
declare @campo varchar(100), @tipovb as varchar(30)
declare @tab char(1)
set @tab = char(9)

select @qtdcolunas = count(*) from syscolumns where id = object_id(@tabela)

select 
	sc.name as campo, sc.id, sc.xtype, sc.length, sc.prec, sc.xscale, sc.colid, sc.isnullable, st.name as tipo, 
	TipoVB = 
	case
	when st.name = 'bigint' then 'Long'
	when st.name = 'bit' then 'Boolean'
	when st.name = 'char' then 'String'
	when st.name = 'date' then 'Date'
	when st.name = 'datetime' then 'Date'
	when st.name = 'decimal' then 'Decimal'
	when st.name = 'float' then 'Decimal'
	when st.name = 'image' then 'Object'
	when st.name = 'int' then 'Integer'
	when st.name = 'money' then 'Decimal'
	when st.name = 'nchar' then 'String'
	when st.name = 'ntext' then 'String'
	when st.name = 'numeric' then 'Decimal'
	when st.name = 'nvarchar' then 'String'
	when st.name = 'real' then 'Decimal'
	when st.name = 'smalldatetime' then 'Date'
	when st.name = 'smallint' then 'Integer'
	when st.name = 'smallmoney' then 'Decimal'
	when st.name = 'sql_variant' then 'VariantType'
	when st.name = 'sysname' then 'String'
	when st.name = 'text' then 'String'
	when st.name = 'time' then 'Date'
	when st.name = 'tinyint' then 'Byte'
	when st.name = 'uniqueidentifier' then 'String'
	when st.name = 'varbinary' then 'VariantType'
	when st.name = 'varchar' then 'String'
	when st.name = 'xml' then 'String'
	else 'String'
	end
into #tmp_atributos
from 
	syscolumns sc 
inner join 
	systypes st on st.xtype = sc.xtype
where 
	sc.id = object_id(@tabela) order by sc.colid

insert into #comando values ('Public Class '+Upper(substring(@tabela,1,1))+LOWER(substring(@tabela,2,49)))
insert into #comando values ('')


set @i = 1
while @i <= @qtdcolunas
begin

	select @campo = lower(campo), @tipovb = Tipovb
	from #tmp_atributos 
	where colid=@i

	insert into #comando values (@tab + 'Dim _'+LOWER(@campo)+' As '+@tipovb)

	set @i = @i + 1

end

insert into #comando values('')
insert into #comando values('')

set @i = 1
while @i <= @qtdcolunas
begin

	select @campo = lower(campo), @tipovb = Tipovb
	from #tmp_atributos 
	where colid=@i

        insert into #comando values (@tab + 'Property '+Upper(substring(@campo,1,1))+substring(@campo,2,99)+'() As '+@tipovb)
        insert into #comando values (@tab + @tab + 'Get')
        insert into #comando values (@tab + @tab + @tab + 'Return _'+@campo)
        insert into #comando values (@tab + @tab + 'End Get')
        insert into #comando values (@tab + @tab + 'Set(ByVal value As '+@tipovb+')')
        insert into #comando values (@tab + @tab + @tab + '_'+@campo +' = value ')
        insert into #comando values (@tab + @tab + 'End Set')
        insert into #comando values (@tab + 'End Property')

		insert into #comando values('')
	
	set @i = @i + 1

end
insert into #comando values ('')
insert into #comando values ('End Class')

select * from #comando

end


GO
/****** Object:  StoredProcedure [dbo].[sp_gera_stored_crud]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_gera_stored_crud]
@TABELA AS VARCHAR(50)
AS

EXEC sp_gera_stored_insert @TABELA

EXEC sp_gera_stored_delete @TABELA

EXEC sp_gera_stored_update @TABELA

GO
/****** Object:  StoredProcedure [dbo].[sp_gera_stored_delete]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--EXEC sp_gera_stored_delete CG_LOJA
CREATE  procedure  [dbo].[sp_gera_stored_delete] 
@tabela varchar(50) 
as

begin
SET NOCOUNT ON
create table #comando (campo1 varchar(150) null)

declare @qtdcolunas int, @i int
declare @campo varchar(100)
declare @tab char(1)
declare @tipo varchar(30) 
declare @tamanho varchar(50)
declare @valordefault varchar(50)
declare @virgula char(1)
declare @procname varchar(100)
declare @aspas char(1)

set @aspas = char(39) -- aspas simples
set @tab = char(9)



CREATE TABLE #CHAVES (COLID INT IDENTITY(1,1), COL_NAME VARCHAR(50) COLLATE Latin1_General_CI_AI NULL)

INSERT INTO #CHAVES (COL_NAME)
SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE As K 
where TABLE_NAME =	@tabela
AND CONSTRAINT_NAME = (SELECT NAME FROM SYSOBJECTS As U
    WHERE K.TABLE_NAME  = OBJECT_NAME(U.Parent_Obj)  AND
        U.XTYPE = 'PK')
order by ORDINAL_POSITION

select IDENTITY(INT, 1,1) AS KEYCOLUNA,
	sc.name as campo, sc.id, sc.xtype, sc.length, sc.prec, sc.xscale, sc.colid, sc.isnullable, st.name as tipo 

into #tmp_atributos
from 
	syscolumns sc 
inner join 
	systypes st on st.xtype = sc.xtype
where 
	sc.id = object_id(@tabela) and sc.name in (select COL_NAME from #CHAVES)
	
order by sc.colid

select @qtdcolunas = @@ROWCOUNT

set @procname = @aspas + 'spDel_'+Upper(substring(@tabela,1,1))+LOWER(substring(@tabela,2,49)) + @aspas
insert into #comando values ('if exists(select 1 from sysobjects where TYPE = '+@aspas+'P'+@aspas+' AND name = '+@procname+')')
insert into #comando values ('begin')
insert into #comando values (@tab+'drop procedure '+replace(@procname,@aspas,''))
insert into #comando values ('end')
insert into #comando values ('GO')
insert into #comando values ('')
insert into #comando values ('CREATE PROCEDURE '+replace(@procname,@aspas,''))
insert into #comando values ('')

set @i = 1
while @i <= @qtdcolunas
begin

	select @campo = lower(campo), @tipo = tipo, 
	@tamanho = 
	case
	when upper(tipo) IN ('VARCHAR', 'CHAR', 'NCHAR', 'NVARCHAR') THEN '('+convert(varchar,length)+')'
	when upper(tipo) IN ('DECIMAL','NUMERIC') THEN '('+convert(varchar,prec)+','+convert(varchar,xscale)+')'
	else ''
	end,
	@valordefault = 
	case
	when isnullable = 1 then ' = NULL'
	else ''
	end

	from #tmp_atributos 
	where /*colid=@i*/ KEYCOLUNA=@i

	set @virgula = case when @i < @qtdcolunas then ',' else '' end

	insert into #comando values (@tab + '@'+UPPER(@campo)+' As '+@tipo+@tamanho+@valordefault+@virgula)

	set @i = @i + 1

end

insert into #comando values('')
insert into #comando values('AS')
insert into #comando values('')
insert into #comando values('BEGIN')

DELETE FROM #tmp_atributos WHERE campo in (select COL_NAME from #CHAVES)

select @qtdcolunas = count(*)
from #tmp_atributos

insert into #comando values('DELETE FROM '+@tabela+' WHERE ')


declare @qtdkey int
select @qtdkey = count(*) from #CHAVES

if @qtdkey>0
begin
	
	set @i = 1
	while @i <= @qtdkey
	begin

		select @campo = COL_NAME 
		FROM #CHAVES where COLID = @i

		insert into #comando values (@tab+@campo+' = @'+@campo + case when @i < @qtdkey then ' AND ' else '' end) 
		
		set @i = @i + 1

	end
end


insert into #comando values ('')
insert into #comando values('END')
insert into #comando values('GO')
insert into #comando values (replicate('-',60))
insert into #comando values ('')

select * from #comando
SET NOCOUNT OFF
end



GO
/****** Object:  StoredProcedure [dbo].[sp_gera_stored_insert]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--EXEC sp_gera_stored_insert CG_EQUIPAMENTO
CREATE   procedure  [dbo].[sp_gera_stored_insert] 
@tabela varchar(50) 
as

begin
SET NOCOUNT ON
create table #comando (campo1 varchar(150) null)

declare @qtdcolunas int, @i int
declare @campo varchar(100)
declare @tab char(1)
declare @tipo varchar(30) 
declare @tamanho varchar(50)
declare @valordefault varchar(50)
declare @virgula char(1)
declare @procname varchar(100)
declare @aspas char(1)

set @aspas = char(39) -- aspas simples

set @tab = char(9)

select @qtdcolunas = count(*) from syscolumns where id = object_id(@tabela)

select IDENTITY(INT, 1,1) AS KEYCOLUNA,
	sc.name as campo, sc.id, sc.xtype, sc.length, sc.prec, sc.xscale, sc.colid, sc.isnullable, st.name as tipo 

into #tmp_atributos
from 
	syscolumns sc 
inner join 
	systypes st on st.xtype = sc.xtype
where 
	sc.id = object_id(@tabela) order by sc.colid

set @procname = @aspas + 'spIns_'+Upper(substring(@tabela,1,1))+LOWER(substring(@tabela,2,49)) + @aspas

insert into #comando values ('if exists(select 1 from sysobjects where TYPE = '+@aspas+'P'+@aspas+' AND name = '+@procname+')')
insert into #comando values ('begin')
insert into #comando values (@tab+'drop procedure '+replace(@procname,@aspas,''))
insert into #comando values ('end')
insert into #comando values ('GO')
insert into #comando values ('')
insert into #comando values ('CREATE PROCEDURE '+replace(@procname,@aspas,''))
insert into #comando values ('')


set @i = 1
while @i <= @qtdcolunas
begin

	select @campo = lower(campo), @tipo = tipo, 
	@tamanho = 
	case
	when upper(tipo) IN ('VARCHAR', 'CHAR', 'NCHAR', 'NVARCHAR') THEN '('+convert(varchar,length)+')'
	when upper(tipo) IN ('DECIMAL','NUMERIC') THEN '('+convert(varchar,prec)+','+convert(varchar,xscale)+')'
	else ''
	end,
	@valordefault = 
	case
	when isnullable = 1 then ' = NULL'
	else ''
	end

	from #tmp_atributos 
	where /*colid=@i*/ KEYCOLUNA=@i

	set @virgula = case when @i < @qtdcolunas then ',' else '' end

	insert into #comando values (@tab + '@'+UPPER(@campo)+' As '+@tipo+@tamanho+@valordefault+@virgula)

	set @i = @i + 1

end

insert into #comando values('')
insert into #comando values('AS')
insert into #comando values('')
insert into #comando values('BEGIN')

insert into #comando values('INSERT INTO '+@tabela+' (')
set @i = 1
while @i <= @qtdcolunas
begin

	select @campo = lower(campo), @tipo = tipo, 
	@tamanho = 
	case
	when upper(tipo) IN ('VARCHAR', 'CHAR', 'NCHAR', 'NVARCHAR') THEN '('+convert(varchar,length)+')'
	when upper(tipo) IN ('DECIMAL','NUMERIC') THEN '('+convert(varchar,prec)+','+convert(varchar,xscale)+')'
	else ''
	end,
	@valordefault = 
	case
	when isnullable = 1 then ' = NULL'
	else ''
	end

	from #tmp_atributos 
	where /*colid=@i*/ KEYCOLUNA=@i

	set @virgula = case when @i < @qtdcolunas then ',' else ')' end

	insert into #comando values(@tab+@campo+@virgula)
	
	set @i = @i + 1

end

insert into #comando values('VALUES (')
set @i = 1
while @i <= @qtdcolunas
begin

	select @campo = lower(campo), @tipo = tipo, 
	@tamanho = 
	case
	when upper(tipo) IN ('VARCHAR', 'CHAR', 'NCHAR', 'NVARCHAR') THEN '('+convert(varchar,length)+')'
	when upper(tipo) IN ('DECIMAL','NUMERIC') THEN '('+convert(varchar,prec)+','+convert(varchar,xscale)+')'
	else ''
	end,
	@valordefault = 
	case
	when isnullable = 1 then ' = NULL'
	else ''
	end

	from #tmp_atributos 
	where /*colid=@i*/ KEYCOLUNA=@i

	set @virgula = case when @i < @qtdcolunas then ',' else ')' end

	insert into #comando values(@tab+'@'+@campo+@virgula)
	
	set @i = @i + 1

end

insert into #comando values ('')
insert into #comando values('END')
insert into #comando values ('GO')
insert into #comando values ('')
insert into #comando values (replicate('-',60))

select * from #comando

SET NOCOUNT OFF
end



GO
/****** Object:  StoredProcedure [dbo].[sp_gera_stored_lista]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--EXEC sp_gera_stored_insert CG_EQUIPAMENTO
CREATE  procedure  [dbo].[sp_gera_stored_lista] --CG_CARGO
@tabela varchar(50) 
as

begin
SET NOCOUNT ON
create table #comando (campo1 varchar(150) null)

declare @qtdcolunas int, @i int
declare @campo varchar(100)
declare @tab char(1)
declare @tipo varchar(30) 
declare @tamanho varchar(50)
declare @valordefault varchar(50)
declare @virgula char(1)

set @tab = char(9)

select 
	sc.name as campo, sc.id, sc.xtype, sc.length, sc.prec, sc.xscale, sc.colid, sc.isnullable, st.name as tipo 

into #tmp_atributos
from 
	syscolumns sc 
inner join 
	systypes st on st.xtype = sc.xtype
where 
	sc.id = object_id(@tabela) 
	and sc.name not in ('USER_INS','DATA_INS','USER_UPD','DATA_UPD')	
order by sc.colid

select @qtdcolunas = @@ROWCOUNT

insert into #comando values ('CREATE PROCEDURE spLista_'+Upper(substring(@tabela,1,1))+LOWER(substring(@tabela,2,49)))
insert into #comando values ('')


set @i = 1


insert into #comando values('')
insert into #comando values('AS')
insert into #comando values('')
insert into #comando values('BEGIN')

insert into #comando values('SELECT ')
set @i = 1
while @i <= @qtdcolunas
begin

	select @campo = lower(campo), @tipo = tipo, 
	@tamanho = 
	case
	when upper(tipo) IN ('VARCHAR', 'CHAR', 'NCHAR', 'NVARCHAR') THEN '('+convert(varchar,length)+')'
	when upper(tipo) IN ('DECIMAL','NUMERIC') THEN '('+convert(varchar,prec)+','+convert(varchar,xscale)+')'
	else ''
	end,
	@valordefault = 
	case
	when isnullable = 1 then ' = NULL'
	else ''
	end

	from #tmp_atributos 
	where colid=@i

	set @virgula = case when @i < @qtdcolunas then ',' else ' ' end

	insert into #comando values(@tab+@campo+@virgula)
	
	set @i = @i + 1

end

insert into #comando values('FROM ')
insert into #comando values(@tab+@tabela)

insert into #comando values ('')
insert into #comando values('END')
insert into #comando values ('')
insert into #comando values (replicate('-',60))

select * from #comando

SET NOCOUNT OFF
end



GO
/****** Object:  StoredProcedure [dbo].[sp_gera_stored_update]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--EXEC sp_gera_stored_update CG_OS_ITEM
CREATE  procedure  [dbo].[sp_gera_stored_update] 
@tabela varchar(50) 
as

begin
SET NOCOUNT ON
create table #comando (campo1 varchar(150) null)

declare @qtdcolunas int, @i int
declare @campo varchar(100)
declare @tab char(1)
declare @tipo varchar(30) 
declare @tamanho varchar(50)
declare @valordefault varchar(50)
declare @virgula char(1)
declare @procname varchar(100)
declare @aspas char(1) = char(39)
set @tab = char(9)

select @qtdcolunas = count(*) from syscolumns where id = object_id(@tabela)

CREATE TABLE #CHAVES (COLID INT IDENTITY(1,1), COL_NAME VARCHAR(50) COLLATE Latin1_General_CI_AI NULL)

INSERT INTO #CHAVES (COL_NAME)
SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE As K 
where TABLE_NAME =	@tabela
AND CONSTRAINT_NAME = (SELECT NAME FROM SYSOBJECTS As U
    WHERE K.TABLE_NAME = OBJECT_NAME(U.Parent_Obj) AND
        U.XTYPE = 'PK')
order by ORDINAL_POSITION

select IDENTITY(INT, 1,1) AS KEYCOLUNA,
	sc.name as campo, sc.id, sc.xtype, sc.length, sc.prec, sc.xscale, sc.colid, sc.isnullable, st.name as tipo 

into #tmp_atributos
from 
	syscolumns sc 
inner join 
	systypes st on st.xtype = sc.xtype
where 
	sc.id = object_id(@tabela) order by sc.colid

set @procname = @aspas + 'spUpd_'+Upper(substring(@tabela,1,1))+LOWER(substring(@tabela,2,49)) + @aspas
insert into #comando values ('if exists(select 1 from sysobjects where TYPE = '+@aspas+'P'+@aspas+' AND name = '+@procname+')')
insert into #comando values ('begin')
insert into #comando values (@tab+'drop procedure '+replace(@procname,@aspas,''))
insert into #comando values ('end')
insert into #comando values ('GO')
insert into #comando values ('')

insert into #comando values ('CREATE PROCEDURE '+replace(@procname,@aspas,''))

insert into #comando values ('')


set @i = 1
while @i <= @qtdcolunas
begin

	select @campo = lower(campo), @tipo = tipo, 
	@tamanho = 
	case
	when upper(tipo) IN ('VARCHAR', 'CHAR', 'NCHAR', 'NVARCHAR') THEN '('+convert(varchar,length)+')'
	when upper(tipo) IN ('DECIMAL','NUMERIC') THEN '('+convert(varchar,prec)+','+convert(varchar,xscale)+')'
	else ''
	end,
	@valordefault = 
	case
	when isnullable = 1 then ' = NULL'
	else ''
	end

	from #tmp_atributos 
	where /*colid=@i*/ KEYCOLUNA=@i

	set @virgula = case when @i < @qtdcolunas then ',' else '' end

	insert into #comando values (@tab + '@'+UPPER(@campo)+' As '+@tipo+@tamanho+@valordefault+@virgula)

	set @i = @i + 1

end

insert into #comando values('')
insert into #comando values('AS')
insert into #comando values('')
insert into #comando values('BEGIN')

--DELETE FROM #tmp_atributos WHERE campo in (select COL_NAME from #CHAVES)

select @qtdcolunas = count(*)
from #tmp_atributos

insert into #comando values('UPDATE '+@tabela+' SET ')
set @i = 1
while @i <= @qtdcolunas
begin

	select @campo = lower(campo), @tipo = tipo, 
	@tamanho = 
	case
	when upper(tipo) IN ('VARCHAR', 'CHAR', 'NCHAR', 'NVARCHAR') THEN '('+convert(varchar,length)+')'
	when upper(tipo) IN ('DECIMAL','NUMERIC') THEN '('+convert(varchar,prec)+','+convert(varchar,xscale)+')'
	else ''
	end,
	@valordefault = 
	case
	when isnullable = 1 then ' = NULL'
	else ''
	end

	from #tmp_atributos 
	where /*colid=@i*/ KEYCOLUNA=@i and campo not in (select COL_NAME from #CHAVES)

	if @@ROWCOUNT>0
	begin
		set @virgula = case when @i < @qtdcolunas then ',' else '' end

		insert into #comando values(@tab+@campo+' = @'+@campo+@virgula)
	end

	set @i = @i + 1

end

declare @qtdkey int
select @qtdkey = count(*) from #CHAVES

if @qtdkey>0
begin
	insert into #comando values('WHERE ')

	set @i = 1
	while @i <= @qtdkey
	begin

		select @campo = COL_NAME 
		FROM #CHAVES where COLID = @i

		insert into #comando values (@tab+@campo+' = @'+@campo + case when @i < @qtdkey then ' AND ' else '' end) 
		
		set @i = @i + 1

	end
end


insert into #comando values ('')
insert into #comando values('END')
insert into #comando values('GO')
insert into #comando values (replicate('-',60))
insert into #comando values ('')

select * from #comando
SET NOCOUNT OFF
end



GO
/****** Object:  StoredProcedure [dbo].[sp_getColunaFiltro]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* sp_getColunaFiltro CG_MODULO */
CREATE PROCEDURE [dbo].[sp_getColunaFiltro]
@TABELA VARCHAR(50)
AS
BEGIN

SELECT COLUNA
FROM 
	CG_PARAMETRO_PESQUISA_DINAMICA
WHERE 
	TABELA = @TABELA
	AND COLUNA_FILTRO = 1
ORDER BY 	ORDERCOL


END


GO
/****** Object:  StoredProcedure [dbo].[sp_Valida_Chip_Entrada]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Valida_Chip_Entrada]
@SIMID VARCHAR(20)
AS

DECLARE @ERRO BIT, @MSG VARCHAR(100)
SET @ERRO = 0
SET @MSG = ''

IF NOT EXISTS(SELECT 1 FROM [dbo].[VW_CG_CHIP_DISPONIVEIS_ENTRADA_MATRIZ]
    WHERE SIMID = @SIMID)
BEGIN 
    IF NOT EXISTS (SELECT 1 FROM CG_CHIP WHERE SIMID = @SIMID)
    BEGIN
	   SET @ERRO = 1
	   SET @MSG = 'CHIP NÃO CADASTRADO NO BANCO DE DADOS'
    END
    ELSE 
    BEGIN
	   IF EXISTS (SELECT 1 FROM CG_ESTOQUE_CHIP 
				INNER JOIN CG_CHIP ON CG_CHIP.ID_CHIP = CG_ESTOQUE_CHIP.ID_CHIP
				WHERE CG_CHIP.SIMID = @SIMID AND CG_ESTOQUE_CHIP.ID_LOCAL <> 0)
	   BEGIN
		  SET @ERRO = 1
		  SET @MSG = 'CHIP JÁ CADASTRADO NO BANCO DE DADOS'
	   END
    END
END

IF @ERRO = 1
BEGIN
    RAISERROR(@MSG, 16, 1)
END
ELSE
BEGIN
    select 
	   a.ID_CHIP, 
	   a.SIMID, 
	   a.ID_OPERADORA, 
	   a.DESC_OPERADORA, 
	   b.CUSTO 
    from 
	   VW_CG_CHIP_DISPONIVEIS_ENTRADA_MATRIZ A
    inner join CG_CHIP B 
		  ON B.ID_CHIP = A.ID_CHIP
    where a.SIMID = @SIMID
END





GO
/****** Object:  StoredProcedure [dbo].[sp_Valida_Equipamento_Entrada]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Valida_Equipamento_Entrada]
@DESC_EQUIPAMENTO VARCHAR(50)
AS

DECLARE @ERRO BIT, @MSG VARCHAR(100)
SET @ERRO = 0
SET @MSG = ''

IF NOT EXISTS(SELECT 1 FROM [dbo].[VW_CG_EQUIPAMENTO_DISPONIVEIS_ENTRADA_MATRIZ]
    WHERE DESC_EQUIPAMENTO = @DESC_EQUIPAMENTO)
BEGIN 
    IF NOT EXISTS (SELECT 1 FROM CG_EQUIPAMENTO WHERE DESC_EQUIPAMENTO = @DESC_EQUIPAMENTO)
    BEGIN
	   SET @ERRO = 1
	   SET @MSG = 'EQUIPAMENTO NÃO CADASTRADO NO BANCO DE DADOS'
    END
    ELSE 
    BEGIN
	   IF EXISTS (SELECT 1 FROM CG_ESTOQUE_EQUIPAMENTO 
				INNER JOIN CG_EQUIPAMENTO ON CG_EQUIPAMENTO.ID_EQUIPAMENTO = CG_ESTOQUE_EQUIPAMENTO.ID_EQUIPAMENTO
				WHERE CG_EQUIPAMENTO.DESC_EQUIPAMENTO = @DESC_EQUIPAMENTO 
					   AND CG_ESTOQUE_EQUIPAMENTO.ID_LOCAL <> 0)
	   BEGIN
		  SET @ERRO = 1
		  SET @MSG = 'EQUIPAMENTO JÁ CADASTRADO NO BANCO DE DADOS'
	   END
    END
END

IF @ERRO = 1
BEGIN
    RAISERROR(@MSG, 16, 1)
END
ELSE
BEGIN
    select 
	   a.ID_EQUIPAMENTO, 
	   a.DESC_EQUIPAMENTO,
	   a.SERIE, 
	   a.MODELO, 
	   b.VALOR 
    from 
	   VW_CG_EQUIPAMENTO_DISPONIVEIS_ENTRADA_MATRIZ A
    inner join CG_EQUIPAMENTO B 
		  ON B.ID_EQUIPAMENTO = A.ID_EQUIPAMENTO
    where a.DESC_EQUIPAMENTO = @DESC_EQUIPAMENTO
END





GO
/****** Object:  StoredProcedure [dbo].[spBuscaOcorrencia_Loja]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spBuscaOcorrencia_Loja] 
(
@ID_LOJA INT 
)
AS
select 
    a.ID_OCORRENCIA, 
    a.DATA_OCORRENCIA, 
    a.DESCRICAO, 
    a.ID_EQUIPAMENTO, 
    d.DESC_EQUIPAMENTO,
    a.SERIE, 
    d.MODELO,
    a.ID_LOJA, 
    b.NOME,
    b.CODIGO,
    a.HISTORICO, 
    a.USER_INS, 
    a.DATA_INS, 
    a.USER_UPD, 
    a.DATA_UPD, 
    a.OS_VINCULADA
from cg_ocorrencia a
left join cg_loja b 
    on b.ID_LOJA = a.ID_LOJA
left join CG_AREA c
    on c.ID_AREA = b.ID_AREA
left join cg_equipamento d
    on d.ID_EQUIPAMENTO = a.ID_EQUIPAMENTO
where a.ID_LOJA = @ID_LOJA ;

GO
/****** Object:  StoredProcedure [dbo].[spDatasEstoqueChip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDatasEstoqueChip]
as
BEGIN
    DECLARE @DATAS TABLE (DATAMOV VARCHAR(10) NULL)

    INSERT @DATAS 
    select DISTINCT CONVERT(VARCHAR,DATAMOV,103) AS DATAMOV 
    from CG_ESTOQUE_CHIP

    INSERT @DATAS VALUES ('TODAS')

    SELECT DATAMOV FROM @DATAS ORDER BY DATAMOV DESC
END

GO
/****** Object:  StoredProcedure [dbo].[spDatasEstoqueEquipamentos]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDatasEstoqueEquipamentos]
as
BEGIN
    DECLARE @DATAS TABLE (DATAMOV VARCHAR(10) NULL)

    INSERT @DATAS 
    select DISTINCT CONVERT(VARCHAR,DATAMOV,103) AS DATAMOV 
    from CG_ESTOQUE_EQUIPAMENTO

    INSERT @DATAS VALUES ('TODAS')

    SELECT DATAMOV FROM @DATAS ORDER BY DATAMOV DESC
END

GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_acesso]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_acesso]

	@ID_USUARIO As int,
	@ID_MODULO As int

AS

BEGIN
DELETE FROM CG_ACESSO WHERE
	ID_USUARIO = @ID_USUARIO AND
	ID_MODULO = @ID_MODULO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_alocacao]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_alocacao]

	@ID_ALOCACAO As int

AS

BEGIN
DELETE FROM CG_ALOCACAO WHERE
	ID_ALOCACAO = @ID_ALOCACAO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_area]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spDel_Cg_area]

	@ID_AREA As CHAR(8)

AS

BEGIN
DELETE FROM CG_AREA WHERE
	ID_AREA = @ID_AREA

END
------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_cargo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_cargo]

	@ID_CARGO As int

AS

BEGIN
DELETE FROM CG_CARGO WHERE
	ID_CARGO = @ID_CARGO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_categoria]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_categoria]

	@ID_CATEGORIA As int

AS

BEGIN
DELETE FROM CG_CATEGORIA WHERE
	ID_CATEGORIA = @ID_CATEGORIA

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_chip]

	@ID_CHIP As int

AS

BEGIN
DELETE FROM CG_CHIP WHERE
	ID_CHIP = @ID_CHIP

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_devolucao_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_devolucao_chip]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_DEVOLUCAO_CHIP WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_devolucao_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_devolucao_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_DEVOLUCAO_CHIP_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_devolucao_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_devolucao_equipamento]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_DEVOLUCAO_EQUIPAMENTO WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_devolucao_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_devolucao_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_DEVOLUCAO_EQUIPAMENTO_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_empresa]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDel_Cg_empresa]

	@ID_EMPRESA As int 

AS

BEGIN
DELETE FROM CG_EMPRESA WHERE 
	ID_EMPRESA = @ID_EMPRESA

END

GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_entrada_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_entrada_chip]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_ENTRADA_CHIP WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_entrada_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_entrada_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_ENTRADA_CHIP_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_entrada_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_entrada_equipamento]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_ENTRADA_EQUIPAMENTO WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_entrada_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_entrada_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_ENTRADA_EQUIPAMENTO_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_equipamento]

	@ID_EQUIPAMENTO As int

AS

BEGIN
DELETE FROM CG_EQUIPAMENTO WHERE
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_equipamento_vs_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDel_Cg_equipamento_vs_chip]

	@ID_EQUIPAMENTO As int,
	@ID_CHIP As int

AS

BEGIN
DELETE FROM CG_EQUIPAMENTO_VS_CHIP WHERE
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO AND
	ID_CHIP = @ID_CHIP

END

GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_finalidade]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_finalidade]

	@ID_FINALIDADE As int

AS

BEGIN
DELETE FROM CG_FINALIDADE WHERE
	ID_FINALIDADE = @ID_FINALIDADE

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_follow_up]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_follow_up]

	@ID_OS As int,
	@PROTOCOLO As varchar(20)

AS

BEGIN
DELETE FROM CG_FOLLOW_UP WHERE
	ID_OS = @ID_OS AND
	PROTOCOLO = @PROTOCOLO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_fornecedor]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_fornecedor]

	@ID_FORNECEDOR As int

AS

BEGIN
DELETE FROM CG_FORNECEDOR WHERE
	ID_FORNECEDOR = @ID_FORNECEDOR

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_loja]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_loja]

	@ID_LOJA As int

AS

BEGIN
DELETE FROM CG_LOJA WHERE
	ID_LOJA = @ID_LOJA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_marca]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_marca]

	@ID_MARCA As int

AS

BEGIN
DELETE FROM CG_MARCA WHERE
	ID_MARCA = @ID_MARCA

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_modelos]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_modelos]

	@ID_MODELO As int

AS

BEGIN
DELETE FROM CG_MODELOS WHERE
	ID_MODELO = @ID_MODELO

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_modulo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_modulo]

	@ID_MODULO As int

AS

BEGIN
DELETE FROM CG_MODULO WHERE
	ID_MODULO = @ID_MODULO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_motivo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_motivo]

	@ID_MOTIVO As int

AS

BEGIN
DELETE FROM CG_MOTIVO WHERE
	ID_MOTIVO = @ID_MOTIVO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_movimento_chip]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_MOVIMENTO_CHIP WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_chip_inativo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_movimento_chip_inativo]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_MOVIMENTO_CHIP_INATIVO WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_chip_inativo_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_movimento_chip_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_MOVIMENTO_CHIP_INATIVO_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_movimento_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_MOVIMENTO_CHIP_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_movimento_equipamento]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_MOVIMENTO_EQUIPAMENTO WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_equipamento_inativo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spDel_Cg_movimento_equipamento_inativo]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_MOVIMENTO_EQUIPAMENTO_INATIVO WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_equipamento_inativo_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spDel_Cg_movimento_equipamento_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_movimento_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_MOVIMENTO_EQUIPAMENTO_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_equipamento_quarentena]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spDel_Cg_movimento_equipamento_quarentena]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_equipamento_quarentena_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spDel_Cg_movimento_equipamento_quarentena_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_ocorrencia]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_ocorrencia]

	@ID_OCORRENCIA As int

AS

BEGIN
DELETE FROM CG_OCORRENCIA WHERE
	ID_OCORRENCIA = @ID_OCORRENCIA

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_operadora]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_operadora]

	@ID_OPERADORA As int

AS

BEGIN
DELETE FROM CG_OPERADORA WHERE
	ID_OPERADORA = @ID_OPERADORA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_os]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_os]

	@ID_OS As int

AS

BEGIN
DELETE FROM CG_OS WHERE
	ID_OS = @ID_OS

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_os_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_os_item]

	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int

AS

BEGIN
DELETE FROM CG_OS_ITEM WHERE
	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND 
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_peca]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_peca]

	@ID_PECA As int

AS

BEGIN
DELETE FROM CG_PECA WHERE
	ID_PECA = @ID_PECA

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_pedido_compra_peca]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_pedido_compra_peca]

	@ID_PEDIDO As int

AS

BEGIN
DELETE FROM CG_PEDIDO_COMPRA_PECA WHERE
	ID_PEDIDO = @ID_PEDIDO

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_pedido_compra_peca_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_pedido_compra_peca_item]

	@ID_PEDIDO As int,
	@ID_PECA As int

AS

BEGIN
DELETE FROM CG_PEDIDO_COMPRA_PECA_ITEM WHERE
	ID_PEDIDO = @ID_PEDIDO AND
	ID_PECA = @ID_PECA

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_responsavel]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_responsavel]

	@ID_RESPONSAVEL As int

AS

BEGIN
DELETE FROM CG_RESPONSAVEL WHERE
	ID_RESPONSAVEL = @ID_RESPONSAVEL

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_sequencial]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_sequencial]

	@TABELA As varchar(40)

AS

BEGIN
DELETE FROM CG_SEQUENCIAL WHERE
	TABELA = @TABELA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_status]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_status]

	@ID_STATUS As int

AS

BEGIN
DELETE FROM CG_STATUS WHERE
	ID_STATUS = @ID_STATUS

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_status_os]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_status_os]

	@ID_STATUS As int

AS

BEGIN
DELETE FROM CG_STATUS_OS WHERE
	ID_STATUS = @ID_STATUS

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_tabelas_pesquisa_dinamica]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_tabelas_pesquisa_dinamica]

	@ID_TABELA As int

AS

BEGIN
DELETE FROM CG_TABELAS_PESQUISA_DINAMICA WHERE
	ID_TABELA = @ID_TABELA

END
------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_tipo_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_tipo_equipamento]

	@ID_TIPO_EQUIPAMENTO As int

AS

BEGIN
DELETE FROM CG_TIPO_EQUIPAMENTO WHERE
	ID_TIPO_EQUIPAMENTO = @ID_TIPO_EQUIPAMENTO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_tipo_servico]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_tipo_servico]

	@ID_TIPO_SERVICO As int

AS

BEGIN
DELETE FROM CG_TIPO_SERVICO WHERE
	ID_TIPO_SERVICO = @ID_TIPO_SERVICO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_transito]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_transito]

	@ID_TRANSITO As int

AS

BEGIN
delete from CG_TRANSITO where ID_TRANSITO = @ID_TRANSITO

END

------------------------------------------------------------


GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_usuario]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_usuario]

	@ID_USUARIO As int

AS

BEGIN
DELETE FROM CG_USUARIO WHERE
	ID_USUARIO = @ID_USUARIO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spDuplicaUsuario]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
EXEC spDuplicaUsuario
    @ID_USUARIO = 1,
    @NOME = 'NOME USUARIO NOVO',
    @APELIDO = 'APELIDO USUARIO NOVO',
    @LOGIN = 'DOMINIO\NOVOUSUARIO',
    @USER_INS = 1
*/
CREATE PROCEDURE [dbo].[spDuplicaUsuario]
    @ID_USUARIO INT,
    @NOME VARCHAR(50),
    @APELIDO VARCHAR(50),
    @LOGIN VARCHAR(20),
    @USER_INS INT
AS
BEGIN

    DECLARE @NEW_USUARIO INT
    DECLARE @ID_STATUS INT
    DECLARE @DATA_INS DATETIME
    DECLARE @USER_UPD INT
    DECLARE @DATA_UPD DATETIME

    /*PEGA A NOVA CHAVE DO USUARIO*/
    DECLARE @TABLEID TABLE (NEWID INT) 
    INSERT INTO @TABLEID
    EXEC spNovaChave 'CG_USUARIO'

    SELECT @NEW_USUARIO = NEWID FROM @TABLEID

    SELECT 
	   @ID_STATUS = 1, 
	   @DATA_INS = GETDATE(), 
	   @USER_UPD = @USER_INS,  
	   @DATA_UPD = GETDATE()
    
    INSERT INTO CG_USUARIO
    (ID_USUARIO, APELIDO, NOME, LOGIN, ID_STATUS, USER_INS, DATA_INS, USER_UPD, DATA_UPD)
    VALUES 
    (@NEW_USUARIO, @APELIDO, @NOME, @LOGIN, @ID_STATUS, @USER_INS, @DATA_INS, @USER_UPD, @DATA_UPD)

    INSERT INTO CG_ACESSO 
    (ID_USUARIO, ID_MODULO, PERMISSAO, USER_INS, DATA_INS, USER_UPD, DATA_UPD)
    SELECT 
	   @NEW_USUARIO AS ID_USUARIO, 
	   ID_MODULO, 
	   PERMISSAO, 
	   @USER_INS AS USER_INS, 
	   GETDATE() AS DATA_INS, 
	   @USER_INS AS USER_UPD, 
	   GETDATE() AS DATA_UPD 
    FROM CG_ACESSO
    WHERE ID_USUARIO = @ID_USUARIO

END




GO
/****** Object:  StoredProcedure [dbo].[spGrava_Cg_follow_up]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGrava_Cg_follow_up]

	@ID_OS As int,
	@PROTOCOLO As varchar(20),
	@DATA_HORA As datetime,
	@TEXTO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN

    IF NOT EXISTS(SELECT 1 FROM CG_FOLLOW_UP WHERE ID_OS = @ID_OS AND PROTOCOLO = @PROTOCOLO)
    BEGIN
	   INSERT INTO CG_FOLLOW_UP (
		   id_os,
		   protocolo,
		   data_hora,
		   texto,
		   user_ins,
		   data_ins,
		   user_upd,
		   data_upd)
	   VALUES (
		   @id_os,
		   @protocolo,
		   @data_hora,
		   @texto,
		   @user_ins,
		   @data_ins,
		   @user_upd,
		   @data_upd)

	   END
    ELSE
    BEGIN
	   UPDATE CG_FOLLOW_UP SET
		   data_hora = @data_hora,
		   texto = @texto,
		   user_ins = @user_ins,
		   data_ins = @data_ins,
		   user_upd = @user_upd,
		   data_upd = @data_upd
	   WHERE
		   ID_OS = @ID_OS AND
		   PROTOCOLO = @PROTOCOLO
    END

END



GO
/****** Object:  StoredProcedure [dbo].[spGravaCg_equipamento_historico_serie]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGravaCg_equipamento_historico_serie]

    @ID_OS as int,
    @ITEM_ID as int,
    @ID_EQUIPAMENTO as int,
    @DATA_ALTERACAO as datetime,
    @MOTIVO_ALTERACAO as text,
    @SERIE_ANTERIOR as varchar(30),
    @SERIE_NOVA as varchar(30)

as
begin

    if exists(select 1 from CG_EQUIPAMENTO_HISTORICO_SERIE
			 where id_os = @ID_OS and item_id = @ITEM_ID and ID_EQUIPAMENTO = @ID_EQUIPAMENTO)
    begin

	   UPDATE 
		  CG_EQUIPAMENTO_HISTORICO_SERIE
	   SET 
		  DATA_ALTERACAO = @DATA_ALTERACAO, MOTIVO_ALTERACAO = @MOTIVO_ALTERACAO,
		  SERIE_ANTERIOR = @SERIE_ANTERIOR, SERIE_NOVA = @SERIE_NOVA
	   WHERE 
		  id_os = @ID_OS 
		  and item_id = @ITEM_ID 
		  and ID_EQUIPAMENTO = @ID_EQUIPAMENTO

    end
    ELSE
    begin
	   insert into 
		  CG_EQUIPAMENTO_HISTORICO_SERIE
			 (ID_EQUIPAMENTO, DATA_ALTERACAO, ID_OS, ITEM_ID, MOTIVO_ALTERACAO, SERIE_ANTERIOR, SERIE_NOVA)
		  values
			 (@ID_EQUIPAMENTO, @DATA_ALTERACAO, @ID_OS, @ITEM_ID, @MOTIVO_ALTERACAO, @SERIE_ANTERIOR, @SERIE_NOVA)
    end
end

UPDATE CG_EQUIPAMENTO SET SERIE = @SERIE_NOVA
WHERE ID_EQUIPAMENTO = @ID_EQUIPAMENTO

UPDATE CG_OS_ITEM
SET MUDOU_SERIE = 1
WHERE ID_OS = @ID_OS
	   AND ITEM_ID = @ITEM_ID
	   AND ID_EQUIPAMENTO = @ID_EQUIPAMENTO


GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_acesso]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_acesso]

	@ID_USUARIO As int,
	@ID_MODULO As int,
	@PERMISSAO As char(1) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_ACESSO (
	id_usuario,
	id_modulo,
	permissao,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_usuario,
	@id_modulo,
	@permissao,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_alocacao]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_alocacao]

	@ID_ALOCACAO As int,
	@DESC_ALOCACAO As varchar(50) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_ALOCACAO (
	id_alocacao,
	desc_alocacao,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_alocacao,
	@desc_alocacao,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_area]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_area]

	@ID_AREA As CHAR(8),
	@DESC_AREA As varchar(50),
	@ID_RESPONSAVEL As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_AREA (
	id_area,
	desc_area,
	id_responsavel,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_area,
	@desc_area,
	@id_responsavel,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_cargo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_cargo]

	@ID_CARGO As int,
	@DESC_CARGO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_CARGO (
	id_cargo,
	desc_cargo,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_cargo,
	@desc_cargo,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_categoria]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_categoria]

	@ID_CATEGORIA As int,
	@DESC_CATEGORIA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_CATEGORIA (
	id_categoria,
	desc_categoria,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_categoria,
	@desc_categoria,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_chip]

	@ID_CHIP As int,
	@SIMID As varchar(20),
	@ID_OPERADORA As int,
	@ID_FORNECEDOR As int,
	@CUSTO as Numeric(12,2) = 0.00,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_CHIP (
	id_chip,
	simid,
	id_operadora,
	id_fornecedor,
	custo,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	ID_LOCAL_ESTOQUE)
VALUES (
	@id_chip,
	@simid,
	@id_operadora,
	@id_fornecedor,
	@CUSTO,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	0)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_devolucao_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_devolucao_chip]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_DEVOLUCAO_CHIP (
	id_romaneio,
	data_movto,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_romaneio,
	@data_movto,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_devolucao_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_devolucao_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL,
	@ID_MOTIVO As int

AS

BEGIN
INSERT INTO CG_DEVOLUCAO_CHIP_ITEM (
	id_romaneio,
	unique_keyid,
	id_chip,
	simid,
	qtd,
	valor,
	id_motivo)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_chip,
	@simid,
	@qtd,
	@valor,
	@id_motivo)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_devolucao_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_devolucao_equipamento]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_DEVOLUCAO_EQUIPAMENTO (
	id_romaneio,
	data_movto,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_romaneio,
	@data_movto,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_devolucao_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_devolucao_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL,
	@ID_MOTIVO As int

AS

BEGIN
INSERT INTO CG_DEVOLUCAO_EQUIPAMENTO_ITEM (
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor,
	id_motivo)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_equipamento,
	@serie,
	@qtd,
	@valor,
	@id_motivo)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_empresa]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_empresa]

	@ID_EMPRESA As int,
	@NOME_EMPRESA As varchar(60),
	@SIGLA_EMPRESA As varchar(20),
	@ENDERECO_EMPRESA As varchar(80) = NULL,
	@CEP_EMPRESA As varchar(10) = NULL,
	@COMPLEMENTO_EMPRESA As varchar(40) = NULL,
	@BAIRRO_EMPRESA As varchar(50) = NULL,
	@CIDADE_EMPRESA As varchar(50) = NULL,
	@UF_EMPRESA As char(2) = NULL,
	@REFERENCIA_ENDERECO As varchar(150) = NULL,
	@CONTATO_EMPRESA As varchar(50) = NULL,
	@CELULAR_EMPRESA As varchar(20) = NULL,
	@TELEFONE_EMPRESA As varchar(20) = NULL,
	@OBSERVACAO As text = NULL,
	@EMAIL varchar(150) = NULL 

AS

BEGIN
INSERT INTO CG_EMPRESA (
	id_empresa,
	nome_empresa,
	sigla_empresa,
	endereco_empresa,
	cep_empresa,
	complemento_empresa,
	bairro_empresa,
	cidade_empresa,
	uf_empresa,
	referencia_endereco,
	contato_empresa,
	celular_empresa,
	telefone_empresa,
	observacao,
	EMAIL)
VALUES (
	@id_empresa,
	@nome_empresa,
	@sigla_empresa,
	@endereco_empresa,
	@cep_empresa,
	@complemento_empresa,
	@bairro_empresa,
	@cidade_empresa,
	@uf_empresa,
	@referencia_endereco,
	@contato_empresa,
	@celular_empresa,
	@telefone_empresa,
	@observacao,
	@EMAIL)

END


GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_entrada_chip]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_ENTRADA_CHIP (
	id_romaneio,
	data_movto,
	id_loja,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_romaneio,
	@data_movto,
	@id_loja,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_entrada_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_ENTRADA_CHIP_ITEM (
	id_romaneio,
	unique_keyid,
	id_chip,
	simid,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_chip,
	@simid,
	@qtd,
	@valor)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_entrada_equipamento]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_ENTRADA_EQUIPAMENTO (
	id_romaneio,
	data_movto,
	id_loja,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_romaneio,
	@data_movto,
	@id_loja,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_entrada_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_ENTRADA_EQUIPAMENTO_ITEM (
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_equipamento,
	@serie,
	@qtd,
	@valor)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_equipamento]

	@ID_EQUIPAMENTO As int,
	@ID_TIPO_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL,
	@ID_FORNECEDOR As int,
	@PROTOCOLO As varchar(30) = NULL,
	@VALOR As numeric(12,2) = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@NF_ENTRADA AS VARCHAR(15) = NULL,
	@DATA_NF AS DATETIME = NULL,
	@PRAZO_GARANTIA AS INT = NULL

AS

BEGIN
INSERT INTO CG_EQUIPAMENTO (
	id_equipamento,
	id_tipo_equipamento,
	desc_equipamento,
	serie,
	modelo,
	id_fornecedor,
	protocolo,
	valor,
	obs,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	ID_LOCAL_ESTOQUE,
	NF_ENTRADA,
	DATA_NF,
	PRAZO_GARANTIA)
VALUES (
	@id_equipamento,
	@id_tipo_equipamento,
	@desc_equipamento,
	@serie,
	@modelo,
	@id_fornecedor,
	@protocolo,
	@valor,
	@obs,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	0,
	@NF_ENTRADA,
	@DATA_NF,
	@PRAZO_GARANTIA)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_equipamento_vs_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_equipamento_vs_chip]

	@ID_EQUIPAMENTO As int,
	@ID_CHIP As int,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_EQUIPAMENTO_VS_CHIP (
	id_equipamento,
	id_chip,
	user_upd,
	data_upd)
VALUES (
	@id_equipamento,
	@id_chip,
	@user_upd,
	@data_upd)

END

GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_finalidade]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_finalidade]

	@ID_FINALIDADE As int,
	@DESC_FINALIDADE As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_FINALIDADE (
	id_finalidade,
	desc_finalidade,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_finalidade,
	@desc_finalidade,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_follow_up]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_follow_up]

	@ID_OS As int,
	@PROTOCOLO As varchar(20),
	@DATA_HORA As datetime,
	@TEXTO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_FOLLOW_UP (
	id_os,
	protocolo,
	data_hora,
	texto,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_os,
	@protocolo,
	@data_hora,
	@texto,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_fornecedor]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_fornecedor]

	@ID_FORNECEDOR As int,
	@SIGLA As varchar(50),
	@UTILIZA_NFTS As bit,
	@NOME As varchar(50),
	@CEP As varchar(9) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CIDADE As varchar(50) = NULL,
	@BAIRRO As varchar(50) = NULL,
	@UF As char(2) = NULL,
	@EMAIL As varchar(120) = NULL,
	@TELEFONE As varchar(20) = NULL,
	@CONTATO As varchar(50) = NULL,
	@WHATSAPP As varchar(20) = NULL,
	@ID_TIPO_SERVICO As int = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA_AQUISICAO INT = NULL,
	@GARANTIA_ASSISTENCIA INT = NULL

AS

BEGIN
INSERT INTO CG_FORNECEDOR (
	id_fornecedor,
	sigla,
	utiliza_nfts,
	nome,
	cep,
	endereco,
	complemento,
	cidade,
	bairro,
	uf,
	email,
	telefone,
	contato,
	whatsapp,
	id_tipo_servico,
	obs,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	GARANTIA_AQUISICAO,
	GARANTIA_ASSISTENCIA)
VALUES (
	@id_fornecedor,
	@sigla,
	@utiliza_nfts,
	@nome,
	@cep,
	@endereco,
	@complemento,
	@cidade,
	@bairro,
	@uf,
	@email,
	@telefone,
	@contato,
	@whatsapp,
	@id_tipo_servico,
	@obs,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@GARANTIA_AQUISICAO,
	@GARANTIA_ASSISTENCIA)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_loja]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_loja]

	@ID_LOJA As int,
	@SIGLA As varchar(50) = NULL,
	@NOME As varchar(50) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CEP As varchar(9) = NULL,
	@CIDADE As varchar(50) = NULL,
	@BAIRRO As varchar(50) = NULL,
	@UF As char(2) = NULL,
	@ID_TIPO_LOCAL As int = NULL,
	@ID_RESPONSAVEL As int = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@CODIGO AS VARCHAR(10),
	@TELEFONE AS VARCHAR(20) = NULL,
	@CELULAR AS VARCHAR(20) = NULL,
	@LOJA_FISICA AS BIT = 0,
	@PARCERIA AS BIT = 0,
	@ID_AREA AS CHAR(8) = '0000'

AS

BEGIN
INSERT INTO CG_LOJA (
	id_loja,
	sigla,
	nome,
	endereco,
	complemento,
	cep,
	cidade,
	bairro,
	uf,
	id_tipo_local,
	id_responsavel,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	CODIGO,
	TELEFONE,
	CELULAR,
	LOJA_FISICA,
	PARCERIA,
	ID_AREA)
VALUES (
	@id_loja,
	@sigla,
	@nome,
	@endereco,
	@complemento,
	@cep,
	@cidade,
	@bairro,
	@uf,
	@id_tipo_local,
	@id_responsavel,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@CODIGO,
	@TELEFONE,
	@CELULAR,
	@LOJA_FISICA,
	@PARCERIA,
	@ID_AREA)

END

------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_marca]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_marca]

	@ID_MARCA As int,
	@DESC_MARCA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_MARCA (
	id_marca,
	desc_marca,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_marca,
	@desc_marca,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_modelos]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_modelos]

	@ID_MODELO As int,
	@DESC_MODELO As varchar(100),
	@OBS As text = NULL,
	@CAMINHO_ARQUIVO As varchar(150) = NULL,
	@EXTENSAO_ARQUIVO As varchar(5) = NULL

AS

BEGIN
INSERT INTO CG_MODELOS (
	id_modelo,
	desc_modelo,
	obs,
	caminho_arquivo,
	extensao_arquivo)
VALUES (
	@id_modelo,
	@desc_modelo,
	@obs,
	@caminho_arquivo,
	@extensao_arquivo)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_modulo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_modulo]

	@ID_MODULO As int,
	@DESC_MODULO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_MODULO (
	id_modulo,
	desc_modulo,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_modulo,
	@desc_modulo,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_motivo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_motivo]

	@ID_MOTIVO As int,
	@DESC_MOTIVO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_MOTIVO (
	id_motivo,
	desc_motivo,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_motivo,
	@desc_motivo,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_movimento_chip]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA INT,
	@QTD_TOTAL INT

AS

BEGIN
INSERT INTO CG_MOVIMENTO_CHIP (
	id_romaneio,
	data_movto,
	id_responsavel,
	id_loja_origem,
	id_loja_destino,
	tipo_op,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	QTD_RECEBIDA,
	QTD_TOTAL)
VALUES (
	@id_romaneio,
	@data_movto,
	@id_responsavel,
	@id_loja_origem,
	@id_loja_destino,
	@tipo_op,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@QTD_RECEBIDA,
	@QTD_TOTAL)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_chip_inativo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_movimento_chip_inativo]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA INT,
	@QTD_TOTAL INT

AS

BEGIN
INSERT INTO CG_MOVIMENTO_CHIP_INATIVO (
	id_romaneio,
	data_movto,
	id_responsavel,
	id_loja_origem,
	id_loja_destino,
	tipo_op,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	QTD_RECEBIDA,
	QTD_TOTAL)
VALUES (
	@id_romaneio,
	@data_movto,
	@id_responsavel,
	@id_loja_origem,
	@id_loja_destino,
	@tipo_op,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@QTD_RECEBIDA,
	@QTD_TOTAL)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_chip_inativo_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_movimento_chip_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_MOVIMENTO_CHIP_INATIVO_ITEM (
	id_romaneio,
	unique_keyid,
	id_chip,
	simid,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_chip,
	@simid,
	@qtd,
	@valor)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_movimento_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_MOVIMENTO_CHIP_ITEM (
	id_romaneio,
	unique_keyid,
	id_chip,
	simid,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_chip,
	@simid,
	@qtd,
	@valor)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[spIns_Cg_movimento_equipamento]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA INT,
	@QTD_TOTAL INT



AS

BEGIN
INSERT INTO CG_MOVIMENTO_EQUIPAMENTO (
	id_romaneio,
	data_movto,
	id_responsavel,
	id_loja_origem,
	id_loja_destino,
	tipo_op,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	qtd_recebida,
	qtd_total)
VALUES (
	@id_romaneio,
	@data_movto,
	@id_responsavel,
	@id_loja_origem,
	@id_loja_destino,
	@tipo_op,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@qtd_recebida,
	@qtd_total)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_equipamento_inativo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  PROCEDURE [dbo].[spIns_Cg_movimento_equipamento_inativo]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA INT,
	@QTD_TOTAL INT



AS

BEGIN
INSERT INTO CG_MOVIMENTO_EQUIPAMENTO_INATIVO (
	id_romaneio,
	data_movto,
	id_responsavel,
	id_loja_origem,
	id_loja_destino,
	tipo_op,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	qtd_recebida,
	qtd_total)
VALUES (
	@id_romaneio,
	@data_movto,
	@id_responsavel,
	@id_loja_origem,
	@id_loja_destino,
	@tipo_op,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@qtd_recebida,
	@qtd_total)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_equipamento_inativo_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_movimento_equipamento_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM (
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_equipamento,
	@serie,
	@qtd,
	@valor)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_movimento_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_MOVIMENTO_EQUIPAMENTO_ITEM (
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_equipamento,
	@serie,
	@qtd,
	@valor)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_equipamento_quarentena]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE  PROCEDURE [dbo].[spIns_Cg_movimento_equipamento_quarentena]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA INT,
	@QTD_TOTAL INT



AS

BEGIN
INSERT INTO CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA (
	id_romaneio,
	data_movto,
	id_responsavel,
	id_loja_origem,
	id_loja_destino,
	tipo_op,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	qtd_recebida,
	qtd_total)
VALUES (
	@id_romaneio,
	@data_movto,
	@id_responsavel,
	@id_loja_origem,
	@id_loja_destino,
	@tipo_op,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@qtd_recebida,
	@qtd_total)

END

------------------------------------------------------------






GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_equipamento_quarentena_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spIns_Cg_movimento_equipamento_quarentena_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA_ITEM (
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_equipamento,
	@serie,
	@qtd,
	@valor)

END

------------------------------------------------------------






GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_ocorrencia]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_ocorrencia]

	@ID_OCORRENCIA As int,
	@DATA_OCORRENCIA As datetime,
	@DESCRICAO As varchar(60),
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@ID_LOJA As int,
	@HISTORICO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@OS_VINCULADA as varchar(50) = NULL


AS

BEGIN
INSERT INTO CG_OCORRENCIA (
	id_ocorrencia,
	data_ocorrencia,
	descricao,
	id_equipamento,
	serie,
	id_loja,
	historico,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	OS_VINCULADA)
VALUES (
	@id_ocorrencia,
	@data_ocorrencia,
	@descricao,
	@id_equipamento,
	@serie,
	@id_loja,
	@historico,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@OS_VINCULADA)

    IF ISNULL(@OS_VINCULADA,'') <> ''
    BEGIN

	   SELECT IDENTITY(INT, 1,1) AS ID_ROW, VALUE 
	   INTO #TMP_SPLIT
	   from dbo.SplitString(@OS_VINCULADA,'|')

	   DECLARE @P1 INT, @P2 INT, @P3 INT
	   SELECT @P1 = CAST(VALUE AS INT) FROM #TMP_SPLIT WHERE ID_ROW = 1
	   SELECT @P2 = CAST(VALUE AS INT) FROM #TMP_SPLIT WHERE ID_ROW = 2
	   SELECT @P3 = CAST(VALUE AS INT) FROM #TMP_SPLIT WHERE ID_ROW = 3
	   

	   UPDATE CG_OS_ITEM
	   SET ID_OCORRENCIA = @id_ocorrencia
	   WHERE ID_OS = @P1 AND ITEM_ID = @P2 AND ID_EQUIPAMENTO = @P3


    END

END

------------------------------------------------------------


 



GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_operadora]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_operadora]

	@ID_OPERADORA As int,
	@DESC_OPERADORA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_OPERADORA (
	id_operadora,
	desc_operadora,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_operadora,
	@desc_operadora,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_os]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_os]

	@ID_OS As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA_ORIGEM As int,
	@NF_TRANSP As varchar(10) = NULL,
	@SERIE_NF_TRANSP As varchar(10) = NULL,
	@EMISSAO_NF_TRANSP As datetime = NULL,
	@ID_FORNECEDOR As int,
	@ID_RESPONSAVEL_IDA As int = NULL,
	@STATUS_OS As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@XML_NF_TRANSP As xml = NULL,
	@XML_NF_TS As xml = NULL

AS

BEGIN
INSERT INTO CG_OS (
	id_os,
	data_movto,
	id_loja_origem,
	nf_transp,
	serie_nf_transp,
	emissao_nf_transp,
	id_fornecedor,
	id_responsavel_ida,
	status_os,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	xml_nf_transp,
	xml_nf_ts)
VALUES (
	@id_os,
	@data_movto,
	@id_loja_origem,
	@nf_transp,
	@serie_nf_transp,
	@emissao_nf_transp,
	@id_fornecedor,
	@id_responsavel_ida,
	@status_os,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@xml_nf_transp,
	@xml_nf_ts)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_os_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_os_item]

	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL,
	@PROTOCOLO As varchar(30) = NULL,
	@PREVISAO_RETORNO As datetime = NULL,
	@DESC_DEFEITO As varchar(250) = NULL,
	/*@CONSERTO_OK As bit,
	@NF_FORNEC As varchar(10) = NULL,
	@SERIE_NF_FORNEC As varchar(10) = NULL,
	@EMISSAO_NF_FORNEC As datetime = NULL,
	@ID_RESPONSAVEL_RET As int = NULL,
	@XML_NF_FORNEC As xml = NULL,
	@LAUDO_FORNEC As image = NULL,*/
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA AS BIT = NULL,
	@ID_OCORRENCIA AS INT = NULL 

AS

BEGIN
INSERT INTO CG_OS_ITEM (
	id_os,
	item_id,
	id_equipamento,
	desc_equipamento,
	serie,
	modelo,
	protocolo,
	previsao_retorno,
	desc_defeito,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	garantia,
	ID_OCORRENCIA)
VALUES (
	@id_os,
	@item_id,
	@id_equipamento,
	@desc_equipamento,
	@serie,
	@modelo,
	@protocolo,
	@previsao_retorno,
	@desc_defeito,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@GARANTIA,
	@ID_OCORRENCIA)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_parametro_pesquisa_dinamica]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spIns_Cg_parametro_pesquisa_dinamica]

	@TABELA As varchar(50),
	@COLUNA As varchar(50),
	@IDCOLUNA As int,
	@ORDERCOL As int,
	@CHAVE As bit,
	@TIPODADO As varchar(50) = NULL,
	@COLUNA_FILTRO As bit,
	@APELIDO_COLUNA As varchar(50) = NULL,
	@MOSTRA_COLUNA As bit,
	@COLUNA_FILTRO_INICIAL As bit

AS

BEGIN

DELETE FROM CG_PARAMETRO_PESQUISA_DINAMICA
WHERE TABELA = @TABELA AND COLUNA = @COLUNA;

INSERT INTO CG_PARAMETRO_PESQUISA_DINAMICA (
	tabela,
	coluna,
	idcoluna,
	ordercol,
	chave,
	tipodado,
	coluna_filtro,
	apelido_coluna,
	mostra_coluna,
	coluna_filtro_inicial)
VALUES (
	@tabela,
	@coluna,
	@idcoluna,
	@ordercol,
	@chave,
	@tipodado,
	@coluna_filtro,
	@apelido_coluna,
	@mostra_coluna,
	@coluna_filtro_inicial)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_peca]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spIns_Cg_peca]

	@ID_PECA As int,
	@NOME_PECA As varchar(50),
	@DESCRICAO As varchar(250),
	@ID_MARCA As int,
	@ID_CATEGORIA As int,
	@ID_FORNECEDOR As int,
	@ID_FINALIDADE As int,
	@ESTOQUE As int = NULL,
	@ESTOQUE_MIN As int = NULL,
	@ESTOQUE_MAX As int = NULL,
	@UNIDADE As varchar(10) = NULL,
	@DATA_AQUISICAO As datetime,
	@DIAS_GARANTIA As int,
	@CUSTO As numeric(10,2) = NULL,
	@REF_FORNEC As varchar(20) = NULL,
	@OBS As text = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_PECA (
	id_peca,
	nome_peca,
	descricao,
	id_marca,
	id_categoria,
	id_fornecedor,
	id_finalidade,
	estoque,
	estoque_min,
	estoque_max,
	unidade,
	data_aquisicao,
	dias_garantia,
	custo,
	ref_fornec,
	obs,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_peca,
	@nome_peca,
	@descricao,
	@id_marca,
	@id_categoria,
	@id_fornecedor,
	@id_finalidade,
	@estoque,
	@estoque_min,
	@estoque_max,
	@unidade,
	@data_aquisicao,
	@dias_garantia,
	@custo,
	@ref_fornec,
	@obs,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_pedido_compra_peca]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_pedido_compra_peca]

	@ID_PEDIDO As int,
	@TIPO_PEDIDO As char(2),
	@STATUS_PEDIDO As varchar(10),
	@ID_FORNECEDOR As int,
	@ID_COMPRADOR As int,
	@DATA_COMPRA As datetime,
	@PREVISAO_ENTREGA As datetime,
	@DATA_RECEBIMENTO As datetime = NULL,
	@OBS_PEDIDO As text = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_TOTAL As int = NULL

AS

BEGIN
INSERT INTO CG_PEDIDO_COMPRA_PECA (
	id_pedido,
	tipo_pedido,
	status_pedido,
	id_fornecedor,
	id_comprador,
	data_compra,
	previsao_entrega,
	data_recebimento,
	obs_pedido,
	user_ins,
	data_ins,
	qtd_total)
VALUES (
	@id_pedido,
	@tipo_pedido,
	@status_pedido,
	@id_fornecedor,
	@id_comprador,
	@data_compra,
	@previsao_entrega,
	@data_recebimento,
	@obs_pedido,
	@user_ins,
	@data_ins,
	@qtd_total)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_pedido_compra_peca_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_pedido_compra_peca_item]

	@ID_PEDIDO As int,
	@ID_PECA As int,
	@QTDE As int,
	@VALOR_UNIT As numeric(12,2),
	@VALOR_TOTAL As numeric(12,2),
	@RECEBIDO As bit = 0,
	@DATA_RECEBIMENTO As datetime = NULL

AS

BEGIN
INSERT INTO CG_PEDIDO_COMPRA_PECA_ITEM (
	id_pedido,
	id_peca,
	qtde,
	valor_unit,
	valor_total,
	recebido,
	data_recebimento)
VALUES (
	@id_pedido,
	@id_peca,
	@qtde,
	@valor_unit,
	@valor_total,
	@recebido,
	@data_recebimento)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_responsavel]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_responsavel]

	@ID_RESPONSAVEL As int,
	@NOME As varchar(50),
	@APELIDO As varchar(50) = NULL,
	@EMAIL As varchar(120) = NULL,
	@CELULAR As varchar(20) = NULL,
	@WHATSAPP As varchar(20) = NULL,
	@ID_CARGO As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_RESPONSAVEL (
	id_responsavel,
	nome,
	apelido,
	email,
	celular,
	whatsapp,
	id_cargo,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_responsavel,
	@nome,
	@apelido,
	@email,
	@celular,
	@whatsapp,
	@id_cargo,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_sequencial]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_sequencial]

	@TABELA As varchar(40),
	@KEYID As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_SEQUENCIAL (
	tabela,
	keyid,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@tabela,
	@keyid,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_status]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_status]

	@ID_STATUS As int,
	@DESC_STATUS As varchar(20),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_STATUS (
	id_status,
	desc_status,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_status,
	@desc_status,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_status_os]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_status_os]

	@ID_STATUS As int,
	@DESC_STATUS As varchar(20),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_STATUS_OS (
	id_status,
	desc_status,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_status,
	@desc_status,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_tabelas_pesquisa_dinamica]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_tabelas_pesquisa_dinamica]

	@ID_TABELA As int,
	@TABELA As varchar(50),
	@TIPO_TABELA As char(1)

AS

BEGIN
INSERT INTO CG_TABELAS_PESQUISA_DINAMICA (
	id_tabela,
	tabela,
	tipo_tabela)
VALUES (
	@id_tabela,
	@tabela,
	@tipo_tabela)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_tipo_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_tipo_equipamento]

	@ID_TIPO_EQUIPAMENTO As int,
	@DESC_TIPO_EQUIPAMENTO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_TIPO_EQUIPAMENTO (
	id_tipo_equipamento,
	desc_tipo_equipamento,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_tipo_equipamento,
	@desc_tipo_equipamento,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_tipo_servico]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_tipo_servico]

	@ID_TIPO_SERVICO As int,
	@DESC_TIPO_SERVICO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_TIPO_SERVICO (
	id_tipo_servico,
	desc_tipo_servico,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_tipo_servico,
	@desc_tipo_servico,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_transito]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_transito]

	@ID_TRANSITO As int,
	@NOME_TRANSITO As varchar(40),
	@INATIVO As bit

AS

BEGIN
INSERT INTO CG_TRANSITO (
	id_transito,
	nome_transito,
	inativo)
VALUES (
	@id_transito,
	@nome_transito,
	@inativo)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_usuario]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_usuario]

	@ID_USUARIO As int,
	@APELIDO As varchar(50),
	@NOME As varchar(50),
	@CPF As varchar(15) = NULL,
	@RG As varchar(15) = NULL,
	@EMAIL As varchar(120) = NULL,
	@TELEFONE As varchar(15) = NULL,
	@WHATSAPP As varchar(15) = NULL,
	@CEP As varchar(9) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CIDADE As varchar(40) = NULL,
	@BAIRRO As varchar(40) = NULL,
	@UF As varchar(2) = NULL,
	@LOGIN As varchar(20) = NULL,
	@ID_STATUS As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_USUARIO (
	id_usuario,
	apelido,
	nome,
	cpf,
	rg,
	email,
	telefone,
	whatsapp,
	cep,
	endereco,
	complemento,
	cidade,
	bairro,
	uf,
	login,
	id_status,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_usuario,
	@apelido,
	@nome,
	@cpf,
	@rg,
	@email,
	@telefone,
	@whatsapp,
	@cep,
	@endereco,
	@complemento,
	@cidade,
	@bairro,
	@uf,
	@login,
	@id_status,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_acesso]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_acesso]


AS

BEGIN
SELECT
	id_usuario,
	id_modulo,
	permissao
FROM
	CG_ACESSO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_alocacao]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_alocacao]


AS

BEGIN
SELECT
	id_alocacao,
	desc_alocacao
FROM
	CG_ALOCACAO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_cargo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_cargo]


AS

BEGIN
SELECT
	id_cargo,
	desc_cargo
FROM
	CG_CARGO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_chip]


AS

BEGIN
SELECT
	id_chip,
	simid,
	id_operadora,
	id_fornecedor
FROM
	CG_CHIP

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_devolucao_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_devolucao_chip]


AS

BEGIN
SELECT
	id_romaneio,
	data_movto
FROM
	CG_DEVOLUCAO_CHIP

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_devolucao_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_devolucao_chip_item]


AS

BEGIN
SELECT
	id_romaneio,
	unique_keyid,
	id_chip,
	simid,
	qtd,
	valor,
	id_motivo
FROM
	CG_DEVOLUCAO_CHIP_ITEM

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_devolucao_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_devolucao_equipamento]


AS

BEGIN
SELECT
	id_romaneio,
	data_movto
FROM
	CG_DEVOLUCAO_EQUIPAMENTO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_devolucao_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_devolucao_equipamento_item]


AS

BEGIN
SELECT
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor,
	id_motivo
FROM
	CG_DEVOLUCAO_EQUIPAMENTO_ITEM

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_entrada_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_entrada_chip]


AS

BEGIN
SELECT
	id_romaneio,
	data_movto,
	id_loja
FROM
	CG_ENTRADA_CHIP

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_entrada_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_entrada_chip_item]


AS

BEGIN
SELECT
	id_romaneio,
	unique_keyid,
	id_chip,
	simid,
	qtd,
	valor
FROM
	CG_ENTRADA_CHIP_ITEM

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_entrada_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_entrada_equipamento]


AS

BEGIN
SELECT
	id_romaneio,
	data_movto,
	id_loja
FROM
	CG_ENTRADA_EQUIPAMENTO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_entrada_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_entrada_equipamento_item]


AS

BEGIN
SELECT
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor
FROM
	CG_ENTRADA_EQUIPAMENTO_ITEM

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_equipamento]


AS

BEGIN
SELECT
	id_equipamento,
	id_tipo_equipamento,
	desc_equipamento,
	serie,
	modelo,
	id_fornecedor,
	protocolo,
	valor,
	obs
FROM
	CG_EQUIPAMENTO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_follow_up]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_follow_up]


AS

BEGIN
SELECT
	id_os,
	protocolo,
	data_hora,
	texto
FROM
	CG_FOLLOW_UP

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_fornecedor]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_fornecedor]


AS

BEGIN
SELECT
	id_fornecedor,
	sigla,
	utiliza_nfts,
	nome,
	cep,
	endereco,
	complemento,
	cidade,
	bairro,
	uf,
	email,
	telefone,
	contato,
	whatsapp,
	id_tipo_servico,
	obs
FROM
	CG_FORNECEDOR

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_loja]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_loja]


AS

BEGIN
SELECT
	id_loja,
	sigla,
	nome,
	endereco,
	complemento,
	cep,
	cidade,
	bairro,
	uf,
	id_tipo_local,
	id_responsavel
FROM
	CG_LOJA

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_modulo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_modulo]


AS

BEGIN
SELECT
	id_modulo,
	desc_modulo
FROM
	CG_MODULO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_motivo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_motivo]


AS

BEGIN
SELECT
	id_motivo,
	desc_motivo
FROM
	CG_MOTIVO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_movimento_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_movimento_chip]


AS

BEGIN
SELECT
	id_romaneio,
	data_movto,
	id_responsavel,
	id_loja_origem,
	id_loja_destino,
	tipo_op
FROM
	CG_MOVIMENTO_CHIP

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_movimento_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_movimento_chip_item]


AS

BEGIN
SELECT
	id_romaneio,
	unique_keyid,
	id_chip,
	simid,
	qtd,
	valor
FROM
	CG_MOVIMENTO_CHIP_ITEM

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_movimento_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_movimento_equipamento]


AS

BEGIN
SELECT
	id_romaneio,
	data_movto,
	id_responsavel,
	id_loja_origem,
	id_loja_destino,
	tipo_op
FROM
	CG_MOVIMENTO_EQUIPAMENTO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_movimento_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_movimento_equipamento_item]


AS

BEGIN
SELECT
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor
FROM
	CG_MOVIMENTO_EQUIPAMENTO_ITEM

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_operadora]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_operadora]


AS

BEGIN
SELECT
	id_operadora,
	desc_operadora
FROM
	CG_OPERADORA

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_os]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_os]


AS

BEGIN
SELECT
	id_os,
	data_movto,
	id_loja_origem,
	nf_transp,
	serie_nf_transp,
	emissao_nf_transp,
	id_fornecedor,
	id_responsavel_ida,
	status_os,
	status_os,
	status_os
FROM
	CG_OS

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_os_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_os_item]


AS

BEGIN
SELECT
	id_os,
	item_id,
	id_equipamento,
	desc_equipamento,
	serie,
	modelo,
	protocolo,
	previsao_retorno,
	data_retorno,
	desc_defeito,
	conserto_ok,
	nf_fornec,
	serie_nf_fornec,
	emissao_nf_fornec,
	id_responsavel_ret,
	xml_nf_fornec,
	laudo_fornec
FROM
	CG_OS_ITEM

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_responsavel]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_responsavel]


AS

BEGIN
SELECT
	id_responsavel,
	nome,
	apelido,
	email,
	celular,
	whatsapp,
	id_cargo
FROM
	CG_RESPONSAVEL

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_sequencial]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_sequencial]


AS

BEGIN
SELECT
	tabela,
	keyid
FROM
	CG_SEQUENCIAL

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_status]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_status]


AS

BEGIN
SELECT
	id_status,
	desc_status
FROM
	CG_STATUS

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_status_os]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_status_os]


AS

BEGIN
SELECT
	id_status,
	desc_status
FROM
	CG_STATUS_OS

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_tipo_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_tipo_equipamento]


AS

BEGIN
SELECT
	id_tipo_equipamento,
	desc_tipo_equipamento
FROM
	CG_TIPO_EQUIPAMENTO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_tipo_servico]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_tipo_servico]


AS

BEGIN
SELECT
	id_tipo_servico,
	desc_tipo_servico
FROM
	CG_TIPO_SERVICO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_Cg_usuario]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spLista_Cg_usuario]


AS

BEGIN
SELECT
	id_usuario,
	apelido,
	nome,
	cpf,
	rg,
	email,
	telefone,
	whatsapp,
	cep,
	endereco,
	complemento,
	cidade,
	bairro,
	uf,
	login,
	id_status
FROM
	CG_USUARIO

END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spLista_mov_transito_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLista_mov_transito_chip]
(
    @ID_TRANSITO INT = NULL,
    @DATA1 DATETIME = NULL,
    @DATA2 DATETIME = NULL
)
as
SELECT  
    ID_TRANSITO 
    ,NOME_TRANSITO
    ,CODIGO_ORIGEM as CD_ORIGEM
    ,NOME_ORIGEM AS NM_ORIGEM
    ,SIMID 
    ,DESC_OPERADORA AS NM_OPERADORA
    ,QUANTIDADE AS QTD
    ,DATA_LANCTO AS DT_LANC
    ,ID_DESTINO 
    ,CODIGO_DESTINO AS CD_DEST
    ,NOME_DESTINO AS NM_DEST
    ,DATA_MOV_DESTINO AS DT_MOV_DEST
    ,ID_LANCTO 
    ,ID_ORIGEM
    ,ID_CHIP
    ,USER_INS
    ,NOME_USUARIO
FROM VW_CG_MOV_TRANSITO_CHIP 
WHERE 
    CONVERT(VARCHAR,DATA_LANCTO,112) BETWEEN CONVERT(VARCHAR,ISNULL(@DATA1,GETDATE()),112) AND CONVERT(VARCHAR,ISNULL(@DATA2,GETDATE()),112)
    AND ID_TRANSITO = ISNULL(@ID_TRANSITO, ID_TRANSITO)
ORDER BY NOME_TRANSITO ASC, DATA_LANCTO ASC
 
GO
/****** Object:  StoredProcedure [dbo].[spLista_mov_transito_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLista_mov_transito_equipamento]
(
    @ID_TRANSITO INT = NULL,
    @DATA1 DATETIME = NULL,
    @DATA2 DATETIME = NULL
)
as
SELECT  
    ID_TRANSITO
    , NOME_TRANSITO
    , CODIGO_ORIGEM
    , NOME_ORIGEM
    , SERIE
    , MODELO
    , ID_EQUIPAMENTO
    , QUANTIDADE
    , DATA_LANCTO
    , CODIGO_DESTINO
    , NOME_DESTINO
    , ID_DESTINO
    , DATA_MOV_DESTINO
    , ID_LANCTO
    , ID_ORIGEM
    , DESC_EQUIPAMENTO
    , USER_INS
    , NOME_USUARIO

FROM VW_CG_MOV_TRANSITO_EQUIPAMENTO
WHERE 
    CONVERT(VARCHAR,DATA_LANCTO,112) BETWEEN CONVERT(VARCHAR,ISNULL(@DATA1,GETDATE()),112) AND CONVERT(VARCHAR,ISNULL(@DATA2,GETDATE()),112)
    AND ID_TRANSITO = ISNULL(@ID_TRANSITO, ID_TRANSITO)
ORDER BY NOME_TRANSITO ASC, DATA_LANCTO ASC
 
GO
/****** Object:  StoredProcedure [dbo].[spListaAcessoUsuario]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* EXEC spListaAcessoUsuario 1 */
CREATE PROCEDURE [dbo].[spListaAcessoUsuario]
@ID_USUARIO INT
AS
BEGIN
	SELECT 
		M.ID_MODULO, 
		M.DESC_MODULO, 
		@ID_USUARIO AS ID_USUARIO, 
		APELIDO=(SELECT U.APELIDO FROM CG_USUARIO U WHERE U.ID_USUARIO=@ID_USUARIO), 
		NOME=(SELECT U.NOME FROM CG_USUARIO U WHERE U.ID_USUARIO=@ID_USUARIO),  
		PERMISSAO = ISNULL((SELECT A.PERMISSAO 
								FROM CG_ACESSO A WHERE A.ID_USUARIO=@ID_USUARIO 
								AND A.ID_MODULO=M.ID_MODULO),'S')
	FROM 
		CG_MODULO M
END

GO
/****** Object:  StoredProcedure [dbo].[spListaCargo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spListaCargo]

as
SELECT [ID_CARGO]
      ,[DESC_CARGO]
   
  FROM [dbo].[CG_CARGO]



GO
/****** Object:  StoredProcedure [dbo].[spNovaChave]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spNovaChave]
@TABELA VARCHAR(50) 
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @KEYVALUE INT

	SELECT @KEYVALUE = ISNULL(KEYID,0) + 1 
	FROM [dbo].[CG_SEQUENCIAL] 
	WHERE TABELA = @TABELA

	IF @@ROWCOUNT > 0
	BEGIN
		UPDATE [dbo].[CG_SEQUENCIAL] 
		SET KEYID = @KEYVALUE 
		WHERE TABELA = @TABELA
	END
	ELSE 
	BEGIN
		SET @KEYVALUE = -1
	END

	SELECT @KEYVALUE KEYID
	SET NOCOUNT OFF

END

GO
/****** Object:  StoredProcedure [dbo].[spPesquisaSeriePos]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPesquisaSeriePos]
    @id_equipamento int,
    @id_os int,
    @item_id int

as
begin
    select 
	   a.id_equipamento, 
	   a.SERIE,  
	   ISNULL(b.DATA_ALTERACAO,CAST(GETDATE() AS DATE)) AS DATA_ALTERACAO, 
	   b.ID_OS, 
	   b.ITEM_ID, 
	   ISNULL(b.SERIE_ANTERIOR, a.SERIE) AS SERIE_ANTERIOR,
	   ISNULL(b.SERIE_NOVA,'') AS SERIE_NOVA, 
	   ISNULL(b.MOTIVO_ALTERACAO,'') AS MOTIVO_ALTERACAO,
	   CAST( ISNULL(c.MUDOU_SERIE,0) AS BIT) AS MUDOU_SERIE
    from 
	   cg_equipamento a
    left join 
	   CG_EQUIPAMENTO_HISTORICO_SERIE b 
		  on b.ID_EQUIPAMENTO = a.ID_EQUIPAMENTO and b.ID_OS = @id_os and b.ITEM_ID = @item_id
    left join 
	   CG_OS_ITEM c
		  on c.ID_OS = b.ID_OS and c.ITEM_ID = b.ITEM_ID and c.ID_EQUIPAMENTO = b.ID_EQUIPAMENTO
    where a.id_equipamento = @id_equipamento 

end

GO
/****** Object:  StoredProcedure [dbo].[spRpt_EstoqueChipTotalPorLoja]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC spRpt_EstoqueChipTotalPorLoja 1, '-1'
CREATE PROCEDURE [dbo].[spRpt_EstoqueChipTotalPorLoja] 
@COM_ESTOQUE BIT = NULL,
@CLICADOS VARCHAR(2000) = NULL
AS
BEGIN

DECLARE @RESULT TABLE (
			 X BIT NULL, ID_LOJA INT NULL, 
			 NOME VARCHAR(50) NULL, ESTOQUE INT NULL)

IF @COM_ESTOQUE IS NULL
    BEGIN
	   INSERT INTO @RESULT (X, ID_LOJA, NOME, ESTOQUE) 
	   SELECT  
		  CAST(1 AS BIT) AS X,
		  A.ID_LOJA, 
		  A.NOME, 
		  ISNULL(SUM(ESTOQUE),0) AS ESTOQUE
	   FROM 
		  CG_LOJA A 
	   LEFT JOIN 
		  VW_CG_ESTOQUE_CHIP B 
			 ON B.ID_LOCAL = A.ID_LOJA
	   WHERE 
		  A.ID_LOJA <> 0
	   GROUP BY 
		  A.ID_LOJA, 
		  A.NOME

	   UNION 

	   SELECT  
		  CAST(1 AS BIT) AS X,
		  A.ID_LOJA, 
		  A.NOME, 
		  ISNULL(COUNT(*),0) AS ESTOQUE
	   FROM 
		  CG_LOJA A 
	   LEFT JOIN 
		  CG_CHIP B 
			 ON B.ID_LOCAL_ESTOQUE = A.ID_LOJA 
	   WHERE 
		  B.ID_LOCAL_ESTOQUE = 0
	   GROUP BY 
		  A.ID_LOJA, 
		  A.NOME
	   ORDER BY 
		  A.NOME
    END
ELSE
    BEGIN
	   INSERT INTO @RESULT (X, ID_LOJA, NOME, ESTOQUE)
	   SELECT  
		  CAST(1 AS BIT) AS X,
		  A.ID_LOJA, 
		  A.NOME, 
		  ISNULL(SUM(ESTOQUE),0) AS ESTOQUE
	   FROM 
		  CG_LOJA A 
	   LEFT JOIN 
		  VW_CG_ESTOQUE_CHIP B 
			 ON B.ID_LOCAL = A.ID_LOJA
	   WHERE 
		  A.ID_LOJA <> 0
	   GROUP BY 
		  A.ID_LOJA, 
		  A.NOME
	   HAVING ISNULL(SUM(ESTOQUE),0) > 0

	   UNION 

	   SELECT  
		  CAST(1 AS BIT) AS X,
		  A.ID_LOJA, 
		  A.NOME, 
		  ISNULL(COUNT(*),0) AS ESTOQUE
	   FROM 
		  CG_LOJA A 
	   LEFT JOIN 
		  CG_CHIP B 
			 ON B.ID_LOCAL_ESTOQUE = A.ID_LOJA 
	   WHERE 
		  B.ID_LOCAL_ESTOQUE = 0
	   GROUP BY 
		  A.ID_LOJA, 
		  A.NOME
	   HAVING ISNULL(COUNT(*),0) > 0
	   ORDER BY 
		  A.NOME
    END
    IF ISNULL(@CLICADOS,'') <> ''
    BEGIN
	   SELECT * FROM @RESULT 
	   WHERE ID_LOJA
			  IN (SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@CLICADOS,','))
    END
    ELSE
    BEGIN
	   SELECT * FROM @RESULT 
    END

END

GO
/****** Object:  StoredProcedure [dbo].[spRpt_EstoqueEquipamentoTotalPorLoja]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC spRpt_EstoqueEquipamentoTotalPorLoja 1, '-1'
CREATE PROCEDURE [dbo].[spRpt_EstoqueEquipamentoTotalPorLoja] 
@COM_ESTOQUE BIT = NULL,
@CLICADOS VARCHAR(2000) = NULL
AS
BEGIN

DECLARE @RESULT TABLE (
			 X BIT NULL, ID_LOJA INT NULL, 
			 NOME VARCHAR(50) NULL, ESTOQUE INT NULL)

IF @COM_ESTOQUE IS NULL
    BEGIN
	   INSERT INTO @RESULT (X, ID_LOJA, NOME, ESTOQUE) 
	   SELECT  
		  CAST(1 AS BIT) AS X,
		  A.ID_LOJA, 
		  A.NOME, 
		  ISNULL(SUM(ESTOQUE),0) AS ESTOQUE
	   FROM 
		  CG_LOJA A 
	   LEFT JOIN 
		  VW_CG_ESTOQUE_EQUIPAMENTO B 
			 ON B.ID_LOCAL = A.ID_LOJA
	   WHERE 
		  A.ID_LOJA <> 0
	   GROUP BY 
		  A.ID_LOJA, 
		  A.NOME

	   UNION 

	   SELECT  
		  CAST(1 AS BIT) AS X,
		  A.ID_LOJA, 
		  A.NOME, 
		  ISNULL(COUNT(*),0) AS ESTOQUE
	   FROM 
		  CG_LOJA A 
	   LEFT JOIN 
		  CG_EQUIPAMENTO B 
			 ON B.ID_LOCAL_ESTOQUE = A.ID_LOJA 
	   WHERE 
		  B.ID_LOCAL_ESTOQUE = 0
	   GROUP BY 
		  A.ID_LOJA, 
		  A.NOME
	   ORDER BY 
		  A.NOME
    END
ELSE
    BEGIN
	   INSERT INTO @RESULT (X, ID_LOJA, NOME, ESTOQUE)
	   SELECT  
		  CAST(1 AS BIT) AS X,
		  A.ID_LOJA, 
		  A.NOME, 
		  ISNULL(SUM(ESTOQUE),0) AS ESTOQUE
	   FROM 
		  CG_LOJA A 
	   LEFT JOIN 
		  VW_CG_ESTOQUE_EQUIPAMENTO B 
			 ON B.ID_LOCAL = A.ID_LOJA
	   WHERE 
		  A.ID_LOJA <> 0
	   GROUP BY 
		  A.ID_LOJA, 
		  A.NOME
	   HAVING ISNULL(SUM(ESTOQUE),0) > 0

	   UNION 

	   SELECT  
		  CAST(1 AS BIT) AS X,
		  A.ID_LOJA, 
		  A.NOME, 
		  ISNULL(COUNT(*),0) AS ESTOQUE
	   FROM 
		  CG_LOJA A 
	   LEFT JOIN 
		  CG_EQUIPAMENTO B 
			 ON B.ID_LOCAL_ESTOQUE = A.ID_LOJA 
	   WHERE 
		  B.ID_LOCAL_ESTOQUE = 0
	   GROUP BY 
		  A.ID_LOJA, 
		  A.NOME
	   HAVING ISNULL(COUNT(*),0) > 0
	   ORDER BY 
		  A.NOME
    END
    IF ISNULL(@CLICADOS,'') <> ''
    BEGIN
	   SELECT * FROM @RESULT 
	   WHERE ID_LOJA
			  IN (SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@CLICADOS,','))
    END
    ELSE
    BEGIN
	   SELECT * FROM @RESULT 
    END

END






GO
/****** Object:  StoredProcedure [dbo].[spSelecionaChip_POS]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelecionaChip_POS]

@ID_EQUIPAMENTO INT,
@FILTRO_EXCLUIR VARCHAR(2000),
@FILTRO_ADICIONAR VARCHAR(25) = ''

AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que já foram selecionados na tela
*/

SELECT cast(0 AS bit) AS selecao,
	  cc.ID_CHIP,
       cc.SIMID,
       cc.ID_OPERADORA,
       cc.DESC_OPERADORA

FROM dbo.VW_CG_CHIP cc

WHERE cc.ID_CHIP NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )
    AND cc.ID_CHIP NOT IN (SELECT ID_CHIP FROM CG_EQUIPAMENTO_VS_CHIP) 
    AND cc.SIMID like @FILTRO_ADICIONAR+'%'
    


GO
/****** Object:  StoredProcedure [dbo].[spSelecionaChipDisponivelDevolucao]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelecionaChipDisponivelDevolucao]
@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaChipMovimento 1, '101,102'
retorna todos os chips em estoque no local de origem, excluindo os que já foram selecionados na tela
*/

SELECT cast(0 AS bit) AS selecao,
	  cc.ID_CHIP,
       cc.SIMID,
       cc.ID_OPERADORA,
       cc.DESC_OPERADORA,
	  cc.ID_LOCAL_ESTOQUE,
       cc.CUSTO
FROM VW_CG_CHIP_DISPONIVEIS_DEVOLUCAO_MATRIZ cc
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_CHIP NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )

GO
/****** Object:  StoredProcedure [dbo].[spSelecionaChipMovimento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelecionaChipMovimento]
@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaChipMovimento 1, '101,102'
retorna todos os chips em estoque no local de origem, excluindo os que já foram selecionados na tela
*/
SELECT cast(0 AS bit) AS selecao,
	  cc.ID_CHIP,
       cc.SIMID,
       cc.ID_OPERADORA,
       co.DESC_OPERADORA,
	  cc.ID_LOCAL_ESTOQUE,
       cc.CUSTO
FROM dbo.CG_CHIP cc
     LEFT JOIN dbo.CG_OPERADORA co ON CO.ID_OPERADORA = cc.ID_OPERADORA
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_CHIP NOT IN (SELECT ID_CHIP FROM CG_MOVIMENTO_CHIP_INATIVO_ITEM)
    AND cc.ID_CHIP NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )

GO
/****** Object:  StoredProcedure [dbo].[spSelecionaChipMovimentoInativo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[spSelecionaChipMovimentoInativo]
@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaChipMovimentoInativo 1, '101,102'
retorna todos os chips em estoque no local de origem, excluindo os que já foram selecionados na tela
*/
SELECT cast(0 AS bit) AS selecao,
	  cc.ID_CHIP,
       cc.SIMID,
       cc.ID_OPERADORA,
       co.DESC_OPERADORA,
	  cc.ID_LOCAL_ESTOQUE,
       cc.CUSTO
FROM dbo.CG_CHIP cc
     LEFT JOIN dbo.CG_OPERADORA co ON CO.ID_OPERADORA = cc.ID_OPERADORA
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_CHIP NOT IN (SELECT ID_CHIP FROM CG_MOVIMENTO_CHIP_INATIVO_ITEM)
    AND cc.ID_CHIP NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )

GO
/****** Object:  StoredProcedure [dbo].[spSelecionaChipNaoAlocado]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSelecionaChipNaoAlocado]
@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000),
@TIPO_BUSCA INT = 2,
@TEXTO_BUSCA VARCHAR(30) = ''
AS
/*
Chamada:
exec spSelecionaChipMovimento 1, '101,102'
retorna todos os chips em estoque no local de origem, excluindo os que já foram selecionados na tela
*/

IF ISNULL(@TEXTO_BUSCA,'')=''
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_CHIP,
		 cc.SIMID,
		 cc.ID_OPERADORA,
		 cc.DESC_OPERADORA,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.CUSTO
    FROM VW_CG_CHIP_DISPONIVEIS_ENTRADA_MATRIZ cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
	   AND cc.ID_CHIP NOT IN (
	   SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
	   )
END
ELSE
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_CHIP,
		 cc.SIMID,
		 cc.ID_OPERADORA,
		 cc.DESC_OPERADORA,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.CUSTO
    FROM VW_CG_CHIP_DISPONIVEIS_ENTRADA_MATRIZ cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
	   AND cc.ID_CHIP NOT IN (SELECT cast(splitdata as int) as splitdata 
						  FROM dbo.fnSplitString(@FILTRO_EXCLUIR,','))
	   AND cc.SIMID LIKE 
		  CASE @TIPO_BUSCA
		  WHEN 1 THEN RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  WHEN 2 THEN '%'+RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  END

END


GO
/****** Object:  StoredProcedure [dbo].[spSelecionaColunasTabelaDinamica]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelecionaColunasTabelaDinamica]
(
@TABELA VARCHAR(50)
)
AS
SELECT object_name(a.id) as tabela,
       a.name as coluna,
       colid as idcoluna,
       isnull(b.ordercol,0) as ordercol,
       isnull(b.chave,0) as chave,
	  	case
		when st.name = 'bigint' then 'Long'
		when st.name = 'bit' then 'Boolean'
		when st.name = 'char' then 'String'
		when st.name = 'date' then 'Date'
		when st.name = 'datetime' then 'Date'
		when st.name = 'decimal' then 'Decimal'
		when st.name = 'float' then 'Decimal'
		when st.name = 'image' then 'Object'
		when st.name = 'int' then 'Integer'
		when st.name = 'money' then 'Decimal'
		when st.name = 'nchar' then 'String'
		when st.name = 'ntext' then 'String'
		when st.name = 'numeric' then 'Decimal'
		when st.name = 'nvarchar' then 'String'
		when st.name = 'real' then 'Decimal'
		when st.name = 'smalldatetime' then 'Date'
		when st.name = 'smallint' then 'Integer'
		when st.name = 'smallmoney' then 'Decimal'
		when st.name = 'sql_variant' then 'VariantType'
		when st.name = 'sysname' then 'String'
		when st.name = 'text' then 'String'
		when st.name = 'time' then 'Date'
		when st.name = 'tinyint' then 'Byte'
		when st.name = 'uniqueidentifier' then 'String'
		when st.name = 'varbinary' then 'VariantType'
		when st.name = 'varchar' then 'String'
		when st.name = 'xml' then 'String'
		else 'String'
	end 	as tipodado,
       isnull(b.coluna_filtro,0) as coluna_filtro,
       isnull(b.apelido_coluna,lower(a.name)) as apelido_coluna,
       isnull(b.mostra_coluna,0) as mostra_coluna,
       isnull(b.coluna_filtro_inicial,0) as coluna_filtro_inicial
FROM   syscolumns a 
inner join 
	systypes st on st.xtype = a.xtype
LEFT JOIN 
    cg_parametro_pesquisa_dinamica b
	   ON object_name(a.id) = b.tabela and a.colid = b.idcoluna
WHERE  object_name(a.id) = @TABELA
ORDER BY 3

GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamento_OS]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelecionaEquipamento_OS]

@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que já foram selecionados na tela
*/

SELECT cast(0 AS bit) AS selecao,
	  cc.ID_EQUIPAMENTO,
       cc.SERIE,
       cc.MODELO,
       cc.DESC_EQUIPAMENTO,
	  cc.ID_LOCAL_ESTOQUE,
       cc.VALOR,
	  cc.ID_TIPO_EQUIPAMENTO, 
	  te.DESC_TIPO_EQUIPAMENTO,
	  case 
		  when (ISNULL(cc.DATA_TERMINO_GARANTIA,'19000101')>=getdate()) 
				OR (DATEADD("dd",isnull(cc.PRAZO_GARANTIA,0),ISNULL(cc.DATA_NF,'19000101'))>=getdate())
				then cast(1 as bit)
		  else cast(0 as bit) 
       end as GARANTIA
FROM dbo.CG_EQUIPAMENTO cc

LEFT JOIN CG_TIPO_EQUIPAMENTO te 
    ON te.ID_TIPO_EQUIPAMENTO = cc.ID_TIPO_EQUIPAMENTO

WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_EQUIPAMENTO NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )
    AND cc.ID_LOCAL_ESTOQUE <> 2 /*em assistencia tecnica*/
   

GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamentoDisponivelDevolucao]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelecionaEquipamentoDisponivelDevolucao]

@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que já foram selecionados na tela
*/
SELECT cast(0 AS bit) AS selecao,
	  cc.ID_EQUIPAMENTO,
       cc.SERIE,
       cc.MODELO,
       cc.DESC_EQUIPAMENTO,
	  cc.ID_LOCAL_ESTOQUE,
       cc.VALOR
FROM VW_CG_EQUIPAMENTOS_DISPONIVEIS_DEVOLUCAO_MATRIZ cc
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_EQUIPAMENTO NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )

GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamentoMovimento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSelecionaEquipamentoMovimento]

@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que já foram selecionados na tela
*/
SELECT cast(0 AS bit) AS selecao,
	  cc.ID_EQUIPAMENTO,
       cc.SERIE,
       cc.MODELO,
       cc.DESC_EQUIPAMENTO,
	  cc.ID_LOCAL_ESTOQUE,
       cc.VALOR
FROM dbo.CG_EQUIPAMENTO cc
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_EQUIPAMENTO NOT IN (SELECT ID_EQUIPAMENTO FROM CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM)
    AND cc.ID_EQUIPAMENTO NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )


GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamentoMovimentoInativo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  PROCEDURE [dbo].[spSelecionaEquipamentoMovimentoInativo]

@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que já foram selecionados na tela
*/
SELECT cast(0 AS bit) AS selecao,
	  cc.ID_EQUIPAMENTO,
       cc.SERIE,
       cc.MODELO,
       cc.DESC_EQUIPAMENTO,
	  cc.ID_LOCAL_ESTOQUE,
       cc.VALOR
FROM dbo.CG_EQUIPAMENTO cc
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_EQUIPAMENTO NOT IN (SELECT ID_EQUIPAMENTO FROM CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM)
    AND cc.ID_EQUIPAMENTO NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )


GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamentoMovimentoNaoAlocado]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSelecionaEquipamentoMovimentoNaoAlocado]

@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000),
@TIPO_BUSCA INT = 2,
@TEXTO_BUSCA VARCHAR(30) = ''
AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que já foram selecionados na tela
*/
IF ISNULL(@TEXTO_BUSCA,'')=''
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_EQUIPAMENTO,
		 cc.SERIE,
		 cc.MODELO,
		 cc.DESC_EQUIPAMENTO,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.VALOR
    FROM VW_CG_EQUIPAMENTO_DISPONIVEIS_ENTRADA_MATRIZ cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
	   AND cc.ID_EQUIPAMENTO NOT IN (
	   SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
	   )
END
ELSE
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_EQUIPAMENTO,
		 cc.SERIE,
		 cc.MODELO,
		 cc.DESC_EQUIPAMENTO,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.VALOR
    FROM VW_CG_EQUIPAMENTO_DISPONIVEIS_ENTRADA_MATRIZ cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
	   AND cc.ID_EQUIPAMENTO NOT IN (
	   SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
	   )
	   AND cc.SERIE LIKE 
		  CASE @TIPO_BUSCA
		  WHEN 1 THEN RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  WHEN 2 THEN '%'+RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  END
END


GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamentoMovimentoQuarentena]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spSelecionaEquipamentoMovimentoQuarentena]

@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que já foram selecionados na tela
*/
SELECT cast(0 AS bit) AS selecao,
	  cc.ID_EQUIPAMENTO,
       cc.SERIE,
       cc.MODELO,
       cc.DESC_EQUIPAMENTO,
	  cc.ID_LOCAL_ESTOQUE,
       cc.VALOR
FROM dbo.CG_EQUIPAMENTO cc
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_EQUIPAMENTO NOT IN (SELECT ID_EQUIPAMENTO FROM CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA_ITEM)
    AND cc.ID_EQUIPAMENTO NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )



GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEstoqueChipLoja]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSelecionaEstoqueChipLoja]
@ID_LOCAL_ESTOQUE INT,
@TIPO_BUSCA INT = 2,
@TEXTO_BUSCA VARCHAR(30) = ''
AS
IF ISNULL(@TEXTO_BUSCA,'')=''
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_CHIP,
		 cc.SIMID,
		 cc.ID_OPERADORA,
		 co.DESC_OPERADORA,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.CUSTO
    FROM dbo.CG_CHIP cc
	    LEFT JOIN dbo.CG_OPERADORA co ON CO.ID_OPERADORA = cc.ID_OPERADORA
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
END
ELSE
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_CHIP,
		 cc.SIMID,
		 cc.ID_OPERADORA,
		 co.DESC_OPERADORA,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.CUSTO
    FROM dbo.CG_CHIP cc
	    LEFT JOIN dbo.CG_OPERADORA co ON CO.ID_OPERADORA = cc.ID_OPERADORA
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
	   AND cc.SIMID LIKE
		  CASE @TIPO_BUSCA
			 WHEN 1 THEN RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
			 WHEN 2 THEN '%'+RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  END

END

GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEstoqueEQUIPAMENTOLoja]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSelecionaEstoqueEQUIPAMENTOLoja]
@ID_LOCAL_ESTOQUE INT,
@TIPO_BUSCA INT = 2,
@TEXTO_BUSCA VARCHAR(30) = ''
AS
IF ISNULL(@TEXTO_BUSCA,'')=''
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_EQUIPAMENTO,
		 cc.SERIE,
		 cc.DESC_EQUIPAMENTO,
		 cc.MODELO,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.VALOR
    FROM dbo.CG_EQUIPAMENTO cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
END
ELSE
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_EQUIPAMENTO,
		 cc.SERIE,
		 cc.DESC_EQUIPAMENTO,
		 cc.MODELO,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.VALOR
    FROM dbo.CG_EQUIPAMENTO cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
	   AND cc.SERIE LIKE
		  CASE @TIPO_BUSCA
			 WHEN 1 THEN RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
			 WHEN 2 THEN '%'+RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  END
END


GO
/****** Object:  StoredProcedure [dbo].[spTrocaSenhaUser]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTrocaSenhaUser]
@ID_USUARIO int,
@NOVA_SENHA VARCHAR(50)
AS
BEGIN
    declare @SENHA1 varbinary(8000)
    SET @SENHA1 = [DBO].[fx_Encriptar](@NOVA_SENHA)

    UPDATE CG_USUARIO
    SET SENHA=@SENHA1
    WHERE ID_USUARIO = @ID_USUARIO
END

GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_acesso]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_acesso]

	@ID_USUARIO As int,
	@ID_MODULO As int,
	@PERMISSAO As char(1) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
if EXISTS( SELECT 1 FROM CG_ACESSO WHERE ID_USUARIO = @ID_USUARIO AND ID_MODULO = @ID_MODULO)
BEGIN
	UPDATE CG_ACESSO SET
		permissao = @permissao,
		user_ins = @user_ins,
		data_ins = @data_ins,
		user_upd = @user_upd,
		data_upd = @data_upd
	WHERE
		ID_USUARIO = @ID_USUARIO AND
		ID_MODULO = @ID_MODULO
END

ELSE

BEGIN
	INSERT INTO CG_ACESSO (

		id_usuario,

		id_modulo,

		permissao,

		user_ins,

		data_ins,

		user_upd,

		data_upd)

	VALUES (

		@id_usuario,

		@id_modulo,

		@permissao,

		@user_ins,

		@data_ins,

		@user_upd,

		@data_upd)
END

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_alocacao]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_alocacao]

	@ID_ALOCACAO As int,
	@DESC_ALOCACAO As varchar(50) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_ALOCACAO SET
	desc_alocacao = @desc_alocacao,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_ALOCACAO = @ID_ALOCACAO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_area]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_area]

	@ID_AREA As CHAR(8),
	@DESC_AREA As varchar(50),
	@ID_RESPONSAVEL As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_AREA SET
	desc_area = @desc_area,
	id_responsavel = @id_responsavel,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_AREA = @ID_AREA

END
------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_cargo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_cargo]

	@ID_CARGO As int,
	@DESC_CARGO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_CARGO SET
	desc_cargo = @desc_cargo,
	user_ins = user_ins,
	data_ins = data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_CARGO = @ID_CARGO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_categoria]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_categoria]

	@ID_CATEGORIA As int,
	@DESC_CATEGORIA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_CATEGORIA SET
	desc_categoria = @desc_categoria,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_CATEGORIA = @ID_CATEGORIA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_chip]

	@ID_CHIP As int,
	@SIMID As varchar(20),
	@ID_OPERADORA As int,
	@ID_FORNECEDOR As int,
	@CUSTO Numeric(12,2),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_CHIP SET
	simid = @simid,
	id_operadora = @id_operadora,
	id_fornecedor = @id_fornecedor,
	custo = @CUSTO,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_CHIP = @ID_CHIP

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_devolucao_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_devolucao_chip]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_DEVOLUCAO_CHIP SET
	data_movto = @data_movto,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_devolucao_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_devolucao_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL,
	@ID_MOTIVO As int

AS

BEGIN
UPDATE CG_DEVOLUCAO_CHIP_ITEM SET
	id_chip = @id_chip,
	simid = @simid,
	qtd = @qtd,
	valor = @valor,
	id_motivo = @id_motivo
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_devolucao_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_devolucao_equipamento]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_DEVOLUCAO_EQUIPAMENTO SET
	data_movto = @data_movto,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_devolucao_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_devolucao_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL,
	@ID_MOTIVO As int

AS

BEGIN
UPDATE CG_DEVOLUCAO_EQUIPAMENTO_ITEM SET
	id_equipamento = @id_equipamento,
	serie = @serie,
	qtd = @qtd,
	valor = @valor,
	id_motivo = @id_motivo
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_empresa]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_empresa]

	@ID_EMPRESA As int,
	@NOME_EMPRESA As varchar(60),
	@SIGLA_EMPRESA As varchar(20),
	@ENDERECO_EMPRESA As varchar(80) = NULL,
	@CEP_EMPRESA As varchar(10) = NULL,
	@COMPLEMENTO_EMPRESA As varchar(40) = NULL,
	@BAIRRO_EMPRESA As varchar(50) = NULL,
	@CIDADE_EMPRESA As varchar(50) = NULL,
	@UF_EMPRESA As char(2) = NULL,
	@REFERENCIA_ENDERECO As varchar(150) = NULL,
	@CONTATO_EMPRESA As varchar(50) = NULL,
	@CELULAR_EMPRESA As varchar(20) = NULL,
	@TELEFONE_EMPRESA As varchar(20) = NULL,
	@OBSERVACAO As text = NULL,
	@email as varchar(150) = NULL 

AS

BEGIN
UPDATE CG_EMPRESA SET 
	nome_empresa = @nome_empresa,
	sigla_empresa = @sigla_empresa,
	endereco_empresa = @endereco_empresa,
	cep_empresa = @cep_empresa,
	complemento_empresa = @complemento_empresa,
	bairro_empresa = @bairro_empresa,
	cidade_empresa = @cidade_empresa,
	uf_empresa = @uf_empresa,
	referencia_endereco = @referencia_endereco,
	contato_empresa = @contato_empresa,
	celular_empresa = @celular_empresa,
	telefone_empresa = @telefone_empresa,
	observacao = @observacao,
	EMAIL = @email 
WHERE 
	ID_EMPRESA = @ID_EMPRESA

END

GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_entrada_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_entrada_chip]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_ENTRADA_CHIP SET
	data_movto = @data_movto,
	id_loja = @id_loja,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_entrada_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_entrada_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_ENTRADA_CHIP_ITEM SET
	id_chip = @id_chip,
	simid = @simid,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_entrada_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_entrada_equipamento]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_ENTRADA_EQUIPAMENTO SET
	data_movto = @data_movto,
	id_loja = @id_loja,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_entrada_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_entrada_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_ENTRADA_EQUIPAMENTO_ITEM SET
	id_equipamento = @id_equipamento,
	serie = @serie,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_equipamento]

	@ID_EQUIPAMENTO As int,
	@ID_TIPO_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL,
	@ID_FORNECEDOR As int,
	@PROTOCOLO As varchar(30) = NULL,
	@VALOR As numeric(12,2) = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@NF_ENTRADA AS VARCHAR(15) = NULL,
	@DATA_NF AS DATETIME = NULL,
	@PRAZO_GARANTIA AS INT = NULL


AS

BEGIN
UPDATE CG_EQUIPAMENTO SET
	id_tipo_equipamento = @id_tipo_equipamento,
	desc_equipamento = @desc_equipamento,
	serie = @serie,
	modelo = @modelo,
	id_fornecedor = @id_fornecedor,
	protocolo = @protocolo,
	valor = @valor,
	obs = @obs,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	NF_ENTRADA = @NF_ENTRADA,
	DATA_NF	= @DATA_NF,
	PRAZO_GARANTIA = @PRAZO_GARANTIA
WHERE
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_equipamento_vs_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpd_Cg_equipamento_vs_chip]

	@ID_EQUIPAMENTO As int,
	@ID_CHIP As int,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_EQUIPAMENTO_VS_CHIP SET
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO AND
	ID_CHIP = @ID_CHIP

END

GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_finalidade]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_finalidade]

	@ID_FINALIDADE As int,
	@DESC_FINALIDADE As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_FINALIDADE SET
	desc_finalidade = @desc_finalidade,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_FINALIDADE = @ID_FINALIDADE

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_follow_up]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_follow_up]

	@ID_OS As int,
	@PROTOCOLO As varchar(20),
	@DATA_HORA As datetime,
	@TEXTO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_FOLLOW_UP SET
	data_hora = @data_hora,
	texto = @texto,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_OS = @ID_OS AND
	PROTOCOLO = @PROTOCOLO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_fornecedor]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_fornecedor]

	@ID_FORNECEDOR As int,
	@SIGLA As varchar(50),
	@UTILIZA_NFTS As bit,
	@NOME As varchar(50),
	@CEP As varchar(9) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CIDADE As varchar(50) = NULL,
	@BAIRRO As varchar(50) = NULL,
	@UF As char(2) = NULL,
	@EMAIL As varchar(120) = NULL,
	@TELEFONE As varchar(20) = NULL,
	@CONTATO As varchar(50) = NULL,
	@WHATSAPP As varchar(20) = NULL,
	@ID_TIPO_SERVICO As int = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA_AQUISICAO INT = NULL,
	@GARANTIA_ASSISTENCIA INT = NULL

AS

BEGIN
UPDATE CG_FORNECEDOR SET
	sigla = @sigla,
	utiliza_nfts = @utiliza_nfts,
	nome = @nome,
	cep = @cep,
	endereco = @endereco,
	complemento = @complemento,
	cidade = @cidade,
	bairro = @bairro,
	uf = @uf,
	email = @email,
	telefone = @telefone,
	contato = @contato,
	whatsapp = @whatsapp,
	id_tipo_servico = @id_tipo_servico,
	obs = @obs,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	GARANTIA_AQUISICAO = @GARANTIA_AQUISICAO,
	GARANTIA_ASSISTENCIA = @GARANTIA_ASSISTENCIA
WHERE
	ID_FORNECEDOR = @ID_FORNECEDOR

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_loja]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_loja]

	@ID_LOJA As int,
	@SIGLA As varchar(50) = NULL,
	@NOME As varchar(50) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CEP As varchar(9) = NULL,
	@CIDADE As varchar(50) = NULL,
	@BAIRRO As varchar(50) = NULL,
	@UF As char(2) = NULL,
	@ID_TIPO_LOCAL As int = NULL,
	@ID_RESPONSAVEL As int = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@CODIGO AS VARCHAR(10),
	@TELEFONE AS VARCHAR(20) = NULL,
	@CELULAR AS VARCHAR(20) = NULL,
	@LOJA_FISICA AS BIT = 0,
	@PARCERIA AS BIT = 0,
	@ID_AREA AS CHAR(8) = '0000'

AS

BEGIN
UPDATE CG_LOJA SET
	sigla = @sigla,
	nome = @nome,
	endereco = @endereco,
	complemento = @complemento,
	cep = @cep,
	cidade = @cidade,
	bairro = @bairro,
	uf = @uf,
	id_tipo_local = @id_tipo_local,
	id_responsavel = @id_responsavel,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	codigo = @CODIGO,
	TELEFONE = @TELEFONE,
	CELULAR = @CELULAR,
	LOJA_FISICA = @LOJA_FISICA,
	PARCERIA = @PARCERIA,
	ID_AREA = @ID_AREA
WHERE
	ID_LOJA = @ID_LOJA

END
------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_marca]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_marca]

	@ID_MARCA As int,
	@DESC_MARCA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_MARCA SET
	desc_marca = @desc_marca,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_MARCA = @ID_MARCA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_modelos]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_modelos]

	@ID_MODELO As int,
	@DESC_MODELO As varchar(100),
	@OBS As text = NULL,
	@CAMINHO_ARQUIVO As varchar(150) = NULL,
	@EXTENSAO_ARQUIVO As varchar(5) = NULL

AS

BEGIN
UPDATE CG_MODELOS SET
	desc_modelo = @desc_modelo,
	obs = @obs,
	caminho_arquivo = @caminho_arquivo,
	extensao_arquivo = @extensao_arquivo
WHERE
	ID_MODELO = @ID_MODELO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_modulo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_modulo]

	@ID_MODULO As int,
	@DESC_MODULO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_MODULO SET
	desc_modulo = @desc_modulo,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_MODULO = @ID_MODULO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_motivo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_motivo]

	@ID_MOTIVO As int,
	@DESC_MOTIVO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_MOTIVO SET
	desc_motivo = @desc_motivo,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_MOTIVO = @ID_MOTIVO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_chip]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_chip]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA AS INT,
	@QTD_TOTAL AS INT

AS

BEGIN
UPDATE CG_MOVIMENTO_CHIP SET
	data_movto = @data_movto,
	id_responsavel = @id_responsavel,
	id_loja_origem = @id_loja_origem,
	id_loja_destino = @id_loja_destino,
	tipo_op = @tipo_op,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	QTD_RECEBIDA = @QTD_RECEBIDA,
	QTD_TOTAL = @QTD_TOTAL
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_chip_inativo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_chip_inativo]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA AS INT,
	@QTD_TOTAL AS INT

AS

BEGIN
UPDATE CG_MOVIMENTO_CHIP_INATIVO SET
	data_movto = @data_movto,
	id_responsavel = @id_responsavel,
	id_loja_origem = @id_loja_origem,
	id_loja_destino = @id_loja_destino,
	tipo_op = @tipo_op,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	QTD_RECEBIDA = @QTD_RECEBIDA,
	QTD_TOTAL = @QTD_TOTAL
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_chip_inativo_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_chip_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_MOVIMENTO_CHIP_INATIVO_ITEM SET
	id_chip = @id_chip,
	simid = @simid,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_chip_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_MOVIMENTO_CHIP_ITEM SET
	id_chip = @id_chip,
	simid = @simid,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_equipamento]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA AS INT,
	@QTD_TOTAL AS INT

AS

BEGIN
UPDATE CG_MOVIMENTO_EQUIPAMENTO SET
	data_movto = @data_movto,
	id_responsavel = @id_responsavel,
	id_loja_origem = @id_loja_origem,
	id_loja_destino = @id_loja_destino,
	tipo_op = @tipo_op,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	QTD_RECEBIDA = @QTD_RECEBIDA,
	QTD_TOTAL = @QTD_TOTAL
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_equipamento_inativo]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_equipamento_inativo]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA AS INT,
	@QTD_TOTAL AS INT

AS

BEGIN
UPDATE CG_MOVIMENTO_EQUIPAMENTO_INATIVO SET
	data_movto = @data_movto,
	id_responsavel = @id_responsavel,
	id_loja_origem = @id_loja_origem,
	id_loja_destino = @id_loja_destino,
	tipo_op = @tipo_op,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	QTD_RECEBIDA = @QTD_RECEBIDA,
	QTD_TOTAL = @QTD_TOTAL
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_equipamento_inativo_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_equipamento_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM SET
	id_equipamento = @id_equipamento,
	serie = @serie,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_equipamento_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_MOVIMENTO_EQUIPAMENTO_ITEM SET
	id_equipamento = @id_equipamento,
	serie = @serie,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_equipamento_quarentena]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_equipamento_quarentena]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA AS INT,
	@QTD_TOTAL AS INT

AS

BEGIN
UPDATE CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA SET
	data_movto = @data_movto,
	id_responsavel = @id_responsavel,
	id_loja_origem = @id_loja_origem,
	id_loja_destino = @id_loja_destino,
	tipo_op = @tipo_op,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	QTD_RECEBIDA = @QTD_RECEBIDA,
	QTD_TOTAL = @QTD_TOTAL
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------






GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_equipamento_quarentena_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_equipamento_quarentena_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA_ITEM SET
	id_equipamento = @id_equipamento,
	serie = @serie,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------






GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_ocorrencia]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_ocorrencia]

	@ID_OCORRENCIA As int,
	@DATA_OCORRENCIA As datetime,
	@DESCRICAO As varchar(60),
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@ID_LOJA As int,
	@HISTORICO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@OS_VINCULADA as varchar(50) = NULL

AS

BEGIN
UPDATE CG_OCORRENCIA SET
	data_ocorrencia = @data_ocorrencia,
	descricao = @descricao,
	id_equipamento = @id_equipamento,
	serie = @serie,
	id_loja = @id_loja,
	historico = @historico,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	OS_VINCULADA = @OS_VINCULADA
WHERE
	ID_OCORRENCIA = @ID_OCORRENCIA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_operadora]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_operadora]

	@ID_OPERADORA As int,
	@DESC_OPERADORA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_OPERADORA SET
	desc_operadora = @desc_operadora,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_OPERADORA = @ID_OPERADORA

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_os]

	@ID_OS As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA_ORIGEM As int,
	@NF_TRANSP As varchar(10) = NULL,
	@SERIE_NF_TRANSP As varchar(10) = NULL,
	@EMISSAO_NF_TRANSP As datetime = NULL,
	@ID_FORNECEDOR As int,
	@ID_RESPONSAVEL_IDA As int = NULL,
	@STATUS_OS As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@XML_NF_TRANSP As xml = NULL,
	@XML_NF_TS As xml = NULL

AS

BEGIN
UPDATE CG_OS SET
	data_movto = @data_movto,
	id_loja_origem = @id_loja_origem,
	nf_transp = @nf_transp,
	serie_nf_transp = @serie_nf_transp,
	emissao_nf_transp = @emissao_nf_transp,
	id_fornecedor = @id_fornecedor,
	id_responsavel_ida = @id_responsavel_ida,
	status_os = @status_os,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	xml_nf_transp = @xml_nf_transp,
	xml_nf_ts = @xml_nf_ts
WHERE
	ID_OS = @ID_OS

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_os_item]

	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL,
	@PROTOCOLO As varchar(30) = NULL,
	@PREVISAO_RETORNO As datetime = NULL,
	@DESC_DEFEITO As varchar(250) = NULL,
	/*@CONSERTO_OK As bit,
	@NF_FORNEC As varchar(10) = NULL,
	@SERIE_NF_FORNEC As varchar(10) = NULL,
	@EMISSAO_NF_FORNEC As datetime = NULL,
	@ID_RESPONSAVEL_RET As int = NULL,
	@XML_NF_FORNEC As xml = NULL,
	@LAUDO_FORNEC As image = NULL,*/
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA AS BIT = NULL,
	@ID_OCORRENCIA AS INT = NULL 

AS

BEGIN
UPDATE CG_OS_ITEM SET
	id_equipamento = @id_equipamento,
	desc_equipamento = @desc_equipamento,
	serie = @serie,
	modelo = @modelo,
	protocolo = @protocolo,
	previsao_retorno = @previsao_retorno,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	GARANTIA = @GARANTIA,
	ID_OCORRENCIA = @ID_OCORRENCIA
WHERE
	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_PDF_NF_Fornec]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[spUpd_Cg_os_PDF_NF_Fornec]
      
	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@PDF AS IMAGE = NULL

AS

BEGIN
UPDATE CG_OS_ITEM SET

    PDF_NF_FORNEC = @PDF

WHERE

	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO
END





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_PDF_NF_TRANSP]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_os_PDF_NF_TRANSP]
      
	@ID_OS As int,
	@PDF AS IMAGE = NULL

AS

BEGIN
UPDATE CG_OS SET

    PDF_NF_TRANSP = @PDF

WHERE

	ID_OS = @ID_OS 

END





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_PDF_NF_TS]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_os_PDF_NF_TS]
      
	@ID_OS As int,
	@PDF AS IMAGE = NULL

AS

BEGIN
UPDATE CG_OS SET

    PDF_NF_TS = @PDF

WHERE

	ID_OS = @ID_OS 

END





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_retorno]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_os_retorno]
      
	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@DATA_RETORNO AS DATETIME = NULL,
	@DESC_DEFEITO As varchar(250) = NULL,
	@CONSERTO_OK As bit,
	@NF_FORNEC As varchar(10) = NULL,
	@SERIE_NF_FORNEC As varchar(10) = NULL,
	@EMISSAO_NF_FORNEC As datetime = NULL,
	@OBS_RETORNO text = NULL,
	@ID_RESPONSAVEL_RET As int = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA AS BIT = NULL,
	@VALOR_CONSERTO NUMERIC(12,2) = NULL,
	@CONFIG_GARANTIA BIT = NULL, 
	@QTDE_DIAS_GARANTIA INT = NULL, 
     @DATA_INICIO_GARANTIA DATETIME = NULL, 
	@DATA_TERMINO_GARANTIA DATETIME = NULL 

AS

BEGIN
UPDATE CG_OS_ITEM SET
    DATA_RETORNO =@DATA_RETORNO,
    DESC_DEFEITO =@DESC_DEFEITO,
    CONSERTO_OK =@CONSERTO_OK,
    NF_FORNEC =@NF_FORNEC,
    SERIE_NF_FORNEC =@SERIE_NF_FORNEC,
    EMISSAO_NF_FORNEC =@EMISSAO_NF_FORNEC,
    OBS_RETORNO =@OBS_RETORNO,
    ID_RESPONSAVEL_RET =@ID_RESPONSAVEL_RET,
    user_upd = @user_upd,
    data_upd = @data_upd,
    RECEBIDO = CASE WHEN @DATA_RETORNO IS NULL THEN 0 ELSE 1 END,
    GARANTIA = @GARANTIA,
    VALOR_CONSERTO = @VALOR_CONSERTO,
    CONFIG_GARANTIA = @CONFIG_GARANTIA,
    QTDE_DIAS_GARANTIA = @QTDE_DIAS_GARANTIA,
    DATA_INICIO_GARANTIA = @DATA_INICIO_GARANTIA,
    DATA_TERMINO_GARANTIA = @DATA_TERMINO_GARANTIA

WHERE
	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO



END





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_retorno_pdf]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_os_retorno_pdf]
      
	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@LAUDO_FORNEC AS IMAGE = NULL

AS

BEGIN
UPDATE CG_OS_ITEM SET

    LAUDO_FORNEC = @LAUDO_FORNEC

WHERE

	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END






GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_peca]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[spUpd_Cg_peca]

	@ID_PECA As int,
	@NOME_PECA As varchar(50),
	@DESCRICAO As varchar(250),
	@ID_MARCA As int,
	@ID_CATEGORIA As int,
	@ID_FORNECEDOR As int,
	@ID_FINALIDADE As int,
	@ESTOQUE As int = NULL,
	@ESTOQUE_MIN As int = NULL,
	@ESTOQUE_MAX As int = NULL,
	@UNIDADE As varchar(10) = NULL,
	@DATA_AQUISICAO As datetime,
	@DIAS_GARANTIA As int,
	@CUSTO As numeric(10,2) = NULL,
	@REF_FORNEC As varchar(20) = NULL,
	@OBS As text = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_PECA SET
	nome_peca = @nome_peca,
	descricao = @descricao,
	id_marca = @id_marca,
	id_categoria = @id_categoria,
	id_fornecedor = @id_fornecedor,
	id_finalidade = @id_finalidade,
	estoque = @estoque,
	estoque_min = @estoque_min,
	estoque_max = @estoque_max,
	unidade = @unidade,
	data_aquisicao = @data_aquisicao,
	dias_garantia = @dias_garantia,
	custo = @custo,
	ref_fornec = @ref_fornec,
	obs = @obs,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_PECA = @ID_PECA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_Peca_Foto]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[spUpd_Cg_Peca_Foto]
      
	@ID_PECA As int,
	@FOTO AS IMAGE = NULL,
	@FILETYPE AS VARCHAR(5) = NULL

AS

BEGIN
UPDATE CG_PECA SET

    FOTO = @FOTO,
    FILETYPE = @FILETYPE

WHERE

	ID_PECA = @ID_PECA 

END





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_pedido_compra_peca]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_pedido_compra_peca]

	@ID_PEDIDO As int,
	@TIPO_PEDIDO As char(2),
	@STATUS_PEDIDO As varchar(10),
	@ID_FORNECEDOR As int,
	@ID_COMPRADOR As int,
	@DATA_COMPRA As datetime,
	@PREVISAO_ENTREGA As datetime,
	@DATA_RECEBIMENTO As datetime = NULL,
	@OBS_PEDIDO As text = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_TOTAL As int = NULL

AS

BEGIN
UPDATE CG_PEDIDO_COMPRA_PECA SET
	tipo_pedido = @tipo_pedido,
	status_pedido = @status_pedido,
	id_fornecedor = @id_fornecedor,
	id_comprador = @id_comprador,
	data_compra = @data_compra,
	previsao_entrega = @previsao_entrega,
	data_recebimento = @data_recebimento,
	obs_pedido = @obs_pedido,
	user_upd = @user_upd,
	data_upd = @data_upd,
	qtd_total = @qtd_total
WHERE
	ID_PEDIDO = @ID_PEDIDO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_pedido_compra_peca_item]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_pedido_compra_peca_item]

	@ID_PEDIDO As int,
	@ID_PECA As int,
	@QTDE As int,
	@VALOR_UNIT As numeric(12,2),
	@VALOR_TOTAL As numeric(12,2),
	@RECEBIDO As bit = 0,
	@DATA_RECEBIMENTO As datetime = NULL

AS

BEGIN
UPDATE CG_PEDIDO_COMPRA_PECA_ITEM SET
	qtde = @qtde,
	valor_unit = @valor_unit,
	valor_total = @valor_total,
	recebido = @recebido,
	data_recebimento = @data_recebimento
WHERE
	ID_PEDIDO = @ID_PEDIDO AND
	ID_PECA = @ID_PECA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_responsavel]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_responsavel]

	@ID_RESPONSAVEL As int,
	@NOME As varchar(50),
	@APELIDO As varchar(50) = NULL,
	@EMAIL As varchar(120) = NULL,
	@CELULAR As varchar(20) = NULL,
	@WHATSAPP As varchar(20) = NULL,
	@ID_CARGO As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_RESPONSAVEL SET
	nome = @nome,
	apelido = @apelido,
	email = @email,
	celular = @celular,
	whatsapp = @whatsapp,
	id_cargo = @id_cargo,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_RESPONSAVEL = @ID_RESPONSAVEL

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_sequencial]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_sequencial]

	@TABELA As varchar(40),
	@KEYID As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_SEQUENCIAL SET
	keyid = @keyid,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	TABELA = @TABELA

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_status]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_status]

	@ID_STATUS As int,
	@DESC_STATUS As varchar(20),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_STATUS SET
	desc_status = @desc_status,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_STATUS = @ID_STATUS

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_status_os]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_status_os]

	@ID_STATUS As int,
	@DESC_STATUS As varchar(20),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_STATUS_OS SET
	desc_status = @desc_status,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_STATUS = @ID_STATUS

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_tabelas_pesquisa_dinamica]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_tabelas_pesquisa_dinamica]

	@ID_TABELA As int,
	@TABELA As varchar(50),
	@TIPO_TABELA As char(1)

AS

BEGIN
UPDATE CG_TABELAS_PESQUISA_DINAMICA SET
	tabela = @tabela,
	tipo_tabela = @tipo_tabela
WHERE
	ID_TABELA = @ID_TABELA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_tipo_equipamento]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_tipo_equipamento]

	@ID_TIPO_EQUIPAMENTO As int,
	@DESC_TIPO_EQUIPAMENTO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_TIPO_EQUIPAMENTO SET
	desc_tipo_equipamento = @desc_tipo_equipamento,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_TIPO_EQUIPAMENTO = @ID_TIPO_EQUIPAMENTO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_tipo_servico]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_tipo_servico]

	@ID_TIPO_SERVICO As int,
	@DESC_TIPO_SERVICO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_TIPO_SERVICO SET
	desc_tipo_servico = @desc_tipo_servico,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_TIPO_SERVICO = @ID_TIPO_SERVICO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_transito]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_transito]

	@ID_TRANSITO As int,
	@NOME_TRANSITO As varchar(40),
	@INATIVO As bit

AS

BEGIN
update CG_TRANSITO set
	nome_transito = @nome_transito,
	inativo = @inativo
where ID_TRANSITO = @ID_TRANSITO
END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_usuario]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_usuario]

	@ID_USUARIO As int,
	@APELIDO As varchar(50),
	@NOME As varchar(50),
	@CPF As varchar(15) = NULL,
	@RG As varchar(15) = NULL,
	@EMAIL As varchar(120) = NULL,
	@TELEFONE As varchar(15) = NULL,
	@WHATSAPP As varchar(15) = NULL,
	@CEP As varchar(9) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CIDADE As varchar(40) = NULL,
	@BAIRRO As varchar(40) = NULL,
	@UF As varchar(2) = NULL,
	@LOGIN As varchar(20) = NULL,
	@ID_STATUS As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_USUARIO SET
	apelido = @apelido,
	nome = @nome,
	cpf = @cpf,
	rg = @rg,
	email = @email,
	telefone = @telefone,
	whatsapp = @whatsapp,
	cep = @cep,
	endereco = @endereco,
	complemento = @complemento,
	cidade = @cidade,
	bairro = @bairro,
	uf = @uf,
	login = @login,
	id_status = @id_status,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_USUARIO = @ID_USUARIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spVer_Permissao]    Script Date: 10/12/2017 17:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spVer_Permissao]
	@ID_MODULO int,
	@ID_USUARIO int
AS
BEGIN
SELECT A.ID_USUARIO
      ,A.ID_MODULO
      ,A.PERMISSAO
      ,A.USER_INS
      ,A.DATA_INS
      ,A.USER_UPD
      ,A.DATA_UPD
	  ,B.DESC_MODULO
	  ,C.APELIDO, C.NOME
  FROM 
		CG_ACESSO A
  LEFT JOIN 
		CG_MODULO B ON B.ID_MODULO = A.ID_MODULO
  LEFT JOIN 
		CG_USUARIO C ON C.ID_USUARIO = A.ID_USUARIO
  WHERE 
		A.ID_MODULO = @ID_MODULO AND A.ID_USUARIO = @ID_USUARIO
END


GO
