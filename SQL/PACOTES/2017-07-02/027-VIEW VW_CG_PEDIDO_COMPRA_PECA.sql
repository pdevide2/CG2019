CREATE VIEW VW_CG_PEDIDO_COMPRA_PECA
AS
 SELECT a.id_pedido,
       a.tipo_pedido,
       a.status_pedido,
       a.id_fornecedor,
       b.nome as nome_fornecedor,
       b.sigla as sigla_fornecedor,
       a.id_comprador,
       c.nome AS Nome_comprador,
       c.apelido As Apelido_comprador,
       a.data_compra,
       a.previsao_entrega,
       a.data_recebimento,
       a.obs_pedido,
       a.user_ins,
       a.data_ins,
       a.user_upd,
       a.data_upd,
       a.romaneio_estoque,
       a.qtd_total,
       a.qtd_recebida
FROM   dbo.cg_pedido_compra_peca AS a
       INNER JOIN dbo.cg_fornecedor AS b
               ON a.id_fornecedor = b.id_fornecedor
       INNER JOIN dbo.cg_usuario AS c
               ON a.id_comprador = c.id_usuario  