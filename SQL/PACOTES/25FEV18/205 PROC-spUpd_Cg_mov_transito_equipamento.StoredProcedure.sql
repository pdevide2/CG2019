USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_mov_transito_equipamento]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_mov_transito_equipamento]

	@ID_LANCTO As bigint,
	@ID_TRANSITO As int,
	@ID_ORIGEM As int,
	@ID_EQUIPAMENTO As int,
	@QUANTIDADE As int,
	@USER_INS As int,
	@DATA_LANCTO As datetime,
	@ID_DESTINO As int = NULL,
	@DATA_MOV_DESTINO As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_MOV_TRANSITO_EQUIPAMENTO SET
	id_transito = @id_transito,
	id_origem = @id_origem,
	id_equipamento = @id_equipamento,
	quantidade = @quantidade,
	user_ins = @user_ins,
	data_lancto = @data_lancto,
	id_destino = @id_destino,
	data_mov_destino = @data_mov_destino,
	id_empresa = @id_empresa
WHERE
	ID_LANCTO = @ID_LANCTO

END
------------------------------------------------------------




GO
