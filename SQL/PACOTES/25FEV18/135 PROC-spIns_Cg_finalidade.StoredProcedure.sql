USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_finalidade]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_finalidade]

	@ID_FINALIDADE As int,
	@DESC_FINALIDADE As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_FINALIDADE (
	id_finalidade,
	desc_finalidade,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	id_empresa)
VALUES (
	@id_finalidade,
	@desc_finalidade,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@id_empresa)

END

------------------------------------------------------------




GO
