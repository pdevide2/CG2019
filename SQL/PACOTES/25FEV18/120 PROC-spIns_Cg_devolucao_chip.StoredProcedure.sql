USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_devolucao_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_devolucao_chip]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_DEVOLUCAO_CHIP (
	id_romaneio,
	data_movto,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_romaneio,
	@data_movto,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
