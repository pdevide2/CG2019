USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_pedido_compra_peca]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_pedido_compra_peca]

	@ID_PEDIDO As int,
	@TIPO_PEDIDO As char(2),
	@STATUS_PEDIDO As varchar(10),
	@ID_FORNECEDOR As int,
	@ID_COMPRADOR As int,
	@DATA_COMPRA As datetime,
	@PREVISAO_ENTREGA As datetime,
	@DATA_RECEBIMENTO As datetime = NULL,
	@OBS_PEDIDO As text = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ROMANEIO_ESTOQUE As int = NULL,
	@QTD_TOTAL As int = NULL,
	@QTD_RECEBIDA As int = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_PEDIDO_COMPRA_PECA (
	id_pedido,
	tipo_pedido,
	status_pedido,
	id_fornecedor,
	id_comprador,
	data_compra,
	previsao_entrega,
	data_recebimento,
	obs_pedido,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	romaneio_estoque,
	qtd_total,
	qtd_recebida,
	id_empresa)
VALUES (
	@id_pedido,
	@tipo_pedido,
	@status_pedido,
	@id_fornecedor,
	@id_comprador,
	@data_compra,
	@previsao_entrega,
	@data_recebimento,
	@obs_pedido,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@romaneio_estoque,
	@qtd_total,
	@qtd_recebida,
	@id_empresa)

END

------------------------------------------------------------




GO
