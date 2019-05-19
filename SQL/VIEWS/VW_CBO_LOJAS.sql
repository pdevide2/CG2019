CREATE VIEW VW_CBO_LOJAS
AS
select '<TODOS>' AS NOME
UNION
select NOME from CG_LOJA
GO

select nome from VW_CBO_LOJAS order by nome asc