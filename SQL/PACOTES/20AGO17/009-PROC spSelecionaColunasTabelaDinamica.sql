CREATE PROCEDURE spSelecionaColunasTabelaDinamica
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