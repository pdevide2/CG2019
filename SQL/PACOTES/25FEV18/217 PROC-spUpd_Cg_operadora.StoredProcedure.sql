USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_operadora]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_operadora]

	@ID_OPERADORA As int,
	@DESC_OPERADORA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_OPERADORA SET
	desc_operadora = @desc_operadora,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	id_empresa = @id_empresa
WHERE
	ID_OPERADORA = @ID_OPERADORA

END
------------------------------------------------------------




GO
