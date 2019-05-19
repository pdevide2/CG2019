USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_chip]    Script Date: 29/04/2017 11:37:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spIns_Cg_chip]

	@ID_CHIP As int,
	@SIMID As varchar(20),
	@ID_OPERADORA As int,
	@ID_FORNECEDOR As int,
	@CUSTO as Numeric(12,2) = 0.00,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_CHIP (
	id_chip,
	simid,
	id_operadora,
	id_fornecedor,
	custo,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	ID_LOCAL_ESTOQUE)
VALUES (
	@id_chip,
	@simid,
	@id_operadora,
	@id_fornecedor,
	@CUSTO,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	0)

END

------------------------------------------------------------



