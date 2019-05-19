USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_follow_up]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_follow_up]

	@ID_OS As int,
	@PROTOCOLO As varchar(20),
	@DATA_HORA As datetime,
	@TEXTO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_FOLLOW_UP SET
	data_hora = @data_hora,
	texto = @texto,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	id_empresa = @id_empresa
WHERE
	ID_OS = @ID_OS AND
	PROTOCOLO = @PROTOCOLO

END
------------------------------------------------------------




GO
