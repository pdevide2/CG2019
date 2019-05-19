USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_marca]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_marca]

	@ID_MARCA As int,
	@DESC_MARCA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_MARCA SET
	desc_marca = @desc_marca,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	id_empresa = @id_empresa
WHERE
	ID_MARCA = @ID_MARCA

END
------------------------------------------------------------




GO
