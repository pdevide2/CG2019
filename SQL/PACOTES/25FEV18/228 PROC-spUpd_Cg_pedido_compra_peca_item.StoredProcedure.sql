USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_pedido_compra_peca_item]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpd_Cg_pedido_compra_peca_item]	@ID_PEDIDO As int,	@ID_PECA As int,	@QTDE As int,	@VALOR_UNIT As numeric(12,2),	@VALOR_TOTAL As numeric(12,2),	@RECEBIDO As bit,	@DATA_RECEBIMENTO As datetime = NULL,	@ID_EMPRESA As intASBEGINUPDATE CG_PEDIDO_COMPRA_PECA_ITEM SET	qtde = @qtde,	valor_unit = @valor_unit,	valor_total = @valor_total,	recebido = @recebido,	data_recebimento = @data_recebimento,	id_empresa = @id_empresaWHERE	ID_PEDIDO = @ID_PEDIDO AND	ID_PECA = @ID_PECAEND------------------------------------------------------------
GO
