USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_status]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_status]

	@ID_STATUS As int,
	@DESC_STATUS As varchar(20),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_STATUS (
	id_status,
	desc_status,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	id_empresa)
VALUES (
	@id_status,
	@desc_status,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@id_empresa)

END

------------------------------------------------------------




GO
