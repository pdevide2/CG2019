USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_chip]

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
	id_empresa)
VALUES (
	@id_chip,
	@simid,
	@id_operadora,
	@id_fornecedor,
	@custo,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@id_empresa)

END

------------------------------------------------------------




GO
