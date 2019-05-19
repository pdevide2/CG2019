USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_area]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_area]

	@ID_AREA As char(8),
	@DESC_AREA As varchar(50),
	@ID_RESPONSAVEL As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_AREA SET
	desc_area = @desc_area,
	id_responsavel = @id_responsavel,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	id_empresa = @id_empresa
WHERE
	ID_AREA = @ID_AREA and id_empresa = @id_empresa

END
------------------------------------------------------------




GO
