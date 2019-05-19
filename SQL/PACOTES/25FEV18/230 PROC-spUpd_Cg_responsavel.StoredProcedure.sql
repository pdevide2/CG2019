USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_responsavel]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_responsavel]

	@ID_RESPONSAVEL As int,
	@NOME As varchar(50),
	@APELIDO As varchar(50) = NULL,
	@EMAIL As varchar(120) = NULL,
	@CELULAR As varchar(20) = NULL,
	@WHATSAPP As varchar(20) = NULL,
	@ID_CARGO As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_RESPONSAVEL SET
	nome = @nome,
	apelido = @apelido,
	email = @email,
	celular = @celular,
	whatsapp = @whatsapp,
	id_cargo = @id_cargo,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	id_empresa = @id_empresa
WHERE
	ID_RESPONSAVEL = @ID_RESPONSAVEL

END
------------------------------------------------------------




GO
