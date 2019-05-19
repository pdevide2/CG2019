USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_chip]

	@ID_CHIP As int,
	@SIMID As varchar(20),
	@ID_OPERADORA As int,
	@ID_FORNECEDOR As int,
	@CUSTO As numeric(14,2) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_CHIP SET
	simid = @simid,
	id_operadora = @id_operadora,
	id_fornecedor = @id_fornecedor,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	custo = @custo,
	id_empresa = @id_empresa
WHERE
	ID_CHIP = @ID_CHIP

END
------------------------------------------------------------




GO
