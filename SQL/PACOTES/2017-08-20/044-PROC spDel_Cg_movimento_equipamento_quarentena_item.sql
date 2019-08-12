USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_equipamento_QUARENTENA_item]    Script Date: 19/08/2017 10:05:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spDel_Cg_movimento_equipamento_quarentena_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO


