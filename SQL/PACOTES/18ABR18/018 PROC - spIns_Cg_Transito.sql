USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_transito]    Script Date: 08/04/2018 15:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spIns_Cg_transito]

	@ID_TRANSITO As int,
	@NOME_TRANSITO As varchar(40),
	@INATIVO As bit

AS

BEGIN
INSERT INTO CG_TRANSITO (
	id_transito,
	nome_transito,
	inativo)
VALUES (
	@id_transito,
	@nome_transito,
	@inativo)

END

------------------------------------------------------------




