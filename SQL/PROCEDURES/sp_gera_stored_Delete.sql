USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[sp_gera_stored_delete]    Script Date: 17/07/2016 18:56:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--EXEC sp_gera_stored_delete CG_LOJA
ALTER  procedure  [dbo].[sp_gera_stored_delete] 
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



CREATE TABLE #CHAVES (COLID INT IDENTITY(1,1), COL_NAME VARCHAR(50) NULL)

INSERT INTO #CHAVES (COL_NAME)
SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE As K 
where TABLE_NAME =	@tabela
AND CONSTRAINT_NAME = (SELECT NAME FROM SYSOBJECTS As U
    WHERE K.TABLE_NAME = OBJECT_NAME(U.Parent_Obj) AND
        U.XTYPE = 'PK')
order by ORDINAL_POSITION

select 
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

insert into #comando values ('CREATE PROCEDURE spDel_'+Upper(substring(@tabela,1,1))+LOWER(substring(@tabela,2,49)))
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
	where colid=@i

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
insert into #comando values (replicate('-',60))
insert into #comando values ('')

select * from #comando
SET NOCOUNT OFF
end

