USE [dbCG]
GO

/****** Object:  View [dbo].[VW_CG_PECA]    Script Date: 11/08/2018 20:11:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[VW_CG_PECA]
AS
SELECT cg_peca.id_peca,
       cg_peca.nome_peca,
       cg_peca.descricao,
       cg_peca.id_marca,
       cg_marca.desc_marca,
       cg_peca.id_categoria,
       cg_categoria.desc_categoria,
       cg_peca.id_fornecedor,
       cg_fornecedor.sigla,
       cg_fornecedor.nome,
       cg_peca.id_finalidade,
       cg_finalidade.desc_finalidade,
       cg_peca.estoque,
       cg_peca.estoque_min,
       cg_peca.estoque_max,
       cg_peca.unidade,
       cg_peca.data_aquisicao,
       cg_peca.dias_garantia,
       cg_peca.custo,
       cg_peca.ref_fornec,
       cg_peca.obs,
       cg_peca.user_ins,
       cg_peca.data_ins,
       cg_peca.user_upd,
       cg_peca.data_upd,
	  cg_peca.CODIGO as ID_CONTROLE,
	  cg_peca.serie,
	  cg_peca.modelo
FROM   cg_peca
       INNER JOIN cg_categoria
               ON cg_peca.id_categoria = cg_categoria.id_categoria
       INNER JOIN cg_finalidade
               ON cg_peca.id_finalidade = cg_finalidade.id_finalidade
       INNER JOIN cg_fornecedor
               ON cg_peca.id_fornecedor = cg_fornecedor.id_fornecedor
       INNER JOIN cg_marca
               ON cg_peca.id_marca = cg_marca.id_marca  

GO


