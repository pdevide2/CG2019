USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[sp_gera_stored_insert]    Script Date: 23/07/2016 19:29:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--EXEC sp_gera_stored_insert CG_EQUIPAMENTO
ALTER  procedure  [dbo].[sp_gera_stored_lista] --CG_CARGO
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

