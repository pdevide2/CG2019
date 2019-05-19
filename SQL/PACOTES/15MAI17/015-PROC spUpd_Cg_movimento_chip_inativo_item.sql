USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_chip_item]    Script Date: 20/05/2017 09:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_chip_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_MOVIMENTO_CHIP_INATIVO_ITEM SET
	id_chip = @id_chip,
	simid = @simid,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------



