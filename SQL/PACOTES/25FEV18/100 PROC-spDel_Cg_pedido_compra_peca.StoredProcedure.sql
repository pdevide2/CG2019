USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_pedido_compra_peca]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDel_Cg_pedido_compra_peca]	@ID_PEDIDO As intASBEGINDELETE FROM CG_PEDIDO_COMPRA_PECA WHERE	ID_PEDIDO = @ID_PEDIDOEND------------------------------------------------------------
GO
