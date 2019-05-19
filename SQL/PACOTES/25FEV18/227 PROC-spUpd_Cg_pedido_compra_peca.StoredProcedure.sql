USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_pedido_compra_peca]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_pedido_compra_peca]

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
UPDATE CG_PEDIDO_COMPRA_PECA SET
	tipo_pedido = @tipo_pedido,
	status_pedido = @status_pedido,
	id_fornecedor = @id_fornecedor,
	id_comprador = @id_comprador,
	data_compra = @data_compra,
	previsao_entrega = @previsao_entrega,
	data_recebimento = @data_recebimento,
	obs_pedido = @obs_pedido,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	romaneio_estoque = @romaneio_estoque,
	qtd_total = @qtd_total,
	qtd_recebida = @qtd_recebida,
	id_empresa = @id_empresa
WHERE
	ID_PEDIDO = @ID_PEDIDO

END
------------------------------------------------------------




GO
