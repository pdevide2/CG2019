CREATE VIEW VW_TEXTO_TRIGGERS
AS
--select object_name(parent_obj) as tabela, * from sysobjects where type='TR' order by 1

SELECT DISTINCT
    o.name AS Object_Name,o.type_desc , m.definition
    FROM sys.sql_modules        m 
        INNER JOIN sys.objects  o ON m.object_id=o.object_id
    WHERE o.type = 'TR'
    --ORDER BY 2,1