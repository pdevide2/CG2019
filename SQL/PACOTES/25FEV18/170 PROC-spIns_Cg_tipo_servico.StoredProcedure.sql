USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_tipo_servico]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_tipo_servico]

	@ID_TIPO_SERVICO As int,
	@DESC_TIPO_SERVICO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_TIPO_SERVICO (
	id_tipo_servico,
	desc_tipo_servico,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	id_empresa)
VALUES (
	@id_tipo_servico,
	@desc_tipo_servico,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@id_empresa)

END

------------------------------------------------------------




GO
