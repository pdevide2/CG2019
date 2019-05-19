USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_pedido_compra_peca_item]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_pedido_compra_peca_item]	@ID_PEDIDO As int,	@ID_PECA As int,	@QTDE As int,	@VALOR_UNIT As numeric(12,2),	@VALOR_TOTAL As numeric(12,2),	@RECEBIDO As bit,	@DATA_RECEBIMENTO As datetime = NULL,	@ID_EMPRESA As intASBEGININSERT INTO CG_PEDIDO_COMPRA_PECA_ITEM (	id_pedido,	id_peca,	qtde,	valor_unit,	valor_total,	recebido,	data_recebimento,	id_empresa)VALUES (	@id_pedido,	@id_peca,	@qtde,	@valor_unit,	@valor_total,	@recebido,	@data_recebimento,	@id_empresa)END------------------------------------------------------------
GO
