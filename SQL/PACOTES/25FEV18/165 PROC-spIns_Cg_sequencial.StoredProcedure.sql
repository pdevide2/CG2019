USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_sequencial]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_sequencial]

	@TABELA As varchar(40),
	@KEYID As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_SEQUENCIAL (
	tabela,
	keyid,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@tabela,
	@keyid,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
