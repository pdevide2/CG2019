CREATE VIEW VW_CG_TABELA_SERVICOS_FORNECEDOR
AS
SELECT T.id_fornecedor, 
       F.sigla, 
       F.nome, 
       T.id_tabela, 
       T.preco, 
       T.id_item 
FROM   dbo.cg_fornecedor AS F 
       INNER JOIN dbo.cg_tabela_servicos_fornecedor AS T 
               ON F.id_fornecedor = T.id_fornecedor 
GO

