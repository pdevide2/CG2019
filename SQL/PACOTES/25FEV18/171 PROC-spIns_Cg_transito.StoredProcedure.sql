USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_transito]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_transito]

	@ID_TRANSITO As int,
	@NOME_TRANSITO As varchar(40),
	@INATIVO As bit,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_TRANSITO (
	id_transito,
	nome_transito,
	inativo,
	id_empresa)
VALUES (
	@id_transito,
	@nome_transito,
	@inativo,
	@id_empresa)

END

------------------------------------------------------------




GO
