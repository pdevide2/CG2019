USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_entrada_chip_item]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_entrada_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_ENTRADA_CHIP_ITEM SET
	id_chip = @id_chip,
	simid = @simid,
	qtd = @qtd,
	valor = @valor,
	id_empresa = @id_empresa
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO
