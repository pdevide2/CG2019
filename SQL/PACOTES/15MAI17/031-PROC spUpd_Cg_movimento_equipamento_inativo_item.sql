USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spUpd_Cg_movimento_equipamento_item]    Script Date: 20/05/2017 14:37:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_movimento_equipamento_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM SET
	id_equipamento = @id_equipamento,
	serie = @serie,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO


