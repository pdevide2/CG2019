USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_motivo]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_motivo]

	@ID_MOTIVO As int,
	@DESC_MOTIVO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_MOTIVO (
	id_motivo,
	desc_motivo,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	id_empresa)
VALUES (
	@id_motivo,
	@desc_motivo,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@id_empresa)

END

------------------------------------------------------------




GO
