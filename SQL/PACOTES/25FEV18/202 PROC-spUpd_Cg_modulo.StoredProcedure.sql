USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_modulo]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_modulo]

	@ID_MODULO As int,
	@DESC_MODULO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_MODULO SET
	desc_modulo = @desc_modulo,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_MODULO = @ID_MODULO

END
------------------------------------------------------------





GO
