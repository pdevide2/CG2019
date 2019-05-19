USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_mov_transito_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_mov_transito_chip]

	@ID_LANCTO As bigint,
	@ID_TRANSITO As int,
	@ID_ORIGEM As int,
	@ID_CHIP As int,
	@QUANTIDADE As int,
	@USER_INS As int,
	@DATA_LANCTO As datetime,
	@ID_DESTINO As int = NULL,
	@DATA_MOV_DESTINO As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_MOV_TRANSITO_CHIP (
	id_lancto,
	id_transito,
	id_origem,
	id_chip,
	quantidade,
	user_ins,
	data_lancto,
	id_destino,
	data_mov_destino,
	id_empresa)
VALUES (
	@id_lancto,
	@id_transito,
	@id_origem,
	@id_chip,
	@quantidade,
	@user_ins,
	@data_lancto,
	@id_destino,
	@data_mov_destino,
	@id_empresa)

END

------------------------------------------------------------




GO
