USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_equipamento]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[spIns_Cg_movimento_equipamento]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_RESPONSAVEL As int,
	@ID_LOJA_ORIGEM As int,
	@ID_LOJA_DESTINO As int,
	@TIPO_OP As char(1),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_RECEBIDA INT,
	@QTD_TOTAL INT



AS

BEGIN
INSERT INTO CG_MOVIMENTO_EQUIPAMENTO (
	id_romaneio,
	data_movto,
	id_responsavel,
	id_loja_origem,
	id_loja_destino,
	tipo_op,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	qtd_recebida,
	qtd_total)
VALUES (
	@id_romaneio,
	@data_movto,
	@id_responsavel,
	@id_loja_origem,
	@id_loja_destino,
	@tipo_op,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@qtd_recebida,
	@qtd_total)

END

------------------------------------------------------------





GO
