USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_equipamento_vs_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_equipamento_vs_chip]

	@ID_EQUIPAMENTO As int,
	@ID_CHIP As int,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_EQUIPAMENTO_VS_CHIP SET
	user_upd = @user_upd,
	data_upd = @data_upd,
	id_empresa = @id_empresa
WHERE
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO AND
	ID_CHIP = @ID_CHIP

END
------------------------------------------------------------




GO
