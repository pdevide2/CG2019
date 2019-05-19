USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_equipamento_QUARENTENA]    Script Date: 19/08/2017 10:11:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_equipamento_quarentena]

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
	@QTD_RECEBIDA AS INT,
	@QTD_TOTAL AS INT

AS

BEGIN
UPDATE CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA SET
	data_movto = @data_movto,
	id_responsavel = @id_responsavel,
	id_loja_origem = @id_loja_origem,
	id_loja_destino = @id_loja_destino,
	tipo_op = @tipo_op,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	QTD_RECEBIDA = @QTD_RECEBIDA,
	QTD_TOTAL = @QTD_TOTAL
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO


