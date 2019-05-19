
INSERT INTO [dbo].[CG_PARAMETRO_PESQUISA_DINAMICA]
(TABELA, COLUNA, IDCOLUNA, ORDERCOL, CHAVE, TIPODADO, COLUNA_FILTRO, APELIDO_COLUNA, MOSTRA_COLUNA)
SELECT 
	OBJECT_NAME(sc.id) as TABELA, 
	sc.name as COLUNA, 
	sc.colid as IDCOLUNA,
	sc.colid as ORDERCOL,
	0 as CHAVE, 
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
	end 	as TIPODADO, 
	CASE 
		WHEN sc.name IN ('USER_INS','DATA_INS','USER_UPD','DATA_UPD') THEN 0
		WHEN sc.name like 'DESC%' THEN 1
		ELSE 0
	END  as COLUNA_FILTRO, 
	LOWER(REPLACE(sc.name,'_',' ')) as APELIDO_COLUNA, 
	CASE 
		WHEN sc.name IN ('USER_INS','DATA_INS','USER_UPD','DATA_UPD') THEN 0
		ELSE 1
	END as MOSTRA_COLUNA

from 
	syscolumns sc 
inner join 
	systypes st on st.xtype = sc.xtype
inner join 
	sysobjects so 
		on so.id = sc.id
where so.type = 'V' and LEFT(OBJECT_NAME(sc.id),2)='VW'
order by 1, 3 

