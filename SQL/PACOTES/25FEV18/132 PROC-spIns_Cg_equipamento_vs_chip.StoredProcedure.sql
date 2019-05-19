USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_equipamento_vs_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_equipamento_vs_chip]

	@ID_EQUIPAMENTO As int,
	@ID_CHIP As int,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_EQUIPAMENTO_VS_CHIP (
	id_equipamento,
	id_chip,
	user_upd,
	data_upd,
	id_empresa)
VALUES (
	@id_equipamento,
	@id_chip,
	@user_upd,
	@data_upd,
	@id_empresa)

END

------------------------------------------------------------




GO
