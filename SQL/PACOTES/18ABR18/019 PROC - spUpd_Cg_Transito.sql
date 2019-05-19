USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_transito]    Script Date: 08/04/2018 15:36:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[spUpd_Cg_transito]

	@ID_TRANSITO As int,
	@NOME_TRANSITO As varchar(40),
	@INATIVO As bit

AS

BEGIN
UPDATE CG_TRANSITO SET
	nome_transito = @nome_transito,
	inativo = @inativo
WHERE
	ID_TRANSITO = @ID_TRANSITO

END
------------------------------------------------------------




