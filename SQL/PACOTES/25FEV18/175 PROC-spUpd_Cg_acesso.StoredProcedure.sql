USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_acesso]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_acesso]

	@ID_USUARIO As int,
	@ID_MODULO As int,
	@PERMISSAO As char(1) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_ACESSO SET
	permissao = @permissao,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	id_empresa = @id_empresa
WHERE
	ID_USUARIO = @ID_USUARIO AND
	ID_MODULO = @ID_MODULO

END
------------------------------------------------------------




GO
