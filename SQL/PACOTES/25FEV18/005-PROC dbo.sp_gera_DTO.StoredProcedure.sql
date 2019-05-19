USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[sp_gera_DTO]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER  procedure  [dbo].[sp_gera_DTO] 
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
