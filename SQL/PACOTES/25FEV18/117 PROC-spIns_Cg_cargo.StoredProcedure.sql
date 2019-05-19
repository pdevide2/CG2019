USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_cargo]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_cargo]	@ID_CARGO As int,	@DESC_CARGO As varchar(50),	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULL,	@ID_EMPRESA As intASBEGININSERT INTO CG_CARGO (	id_cargo,	desc_cargo,	user_ins,	data_ins,	user_upd,	data_upd,	id_empresa)VALUES (	@id_cargo,	@desc_cargo,	@user_ins,	@data_ins,	@user_upd,	@data_upd,	@id_empresa)END------------------------------------------------------------
GO
