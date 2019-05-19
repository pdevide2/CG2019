USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_alocacao]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_alocacao]

	@ID_ALOCACAO As int,
	@DESC_ALOCACAO As varchar(50) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_ALOCACAO (
	id_alocacao,
	desc_alocacao,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	id_empresa)
VALUES (
	@id_alocacao,
	@desc_alocacao,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@id_empresa)

END

------------------------------------------------------------




GO
