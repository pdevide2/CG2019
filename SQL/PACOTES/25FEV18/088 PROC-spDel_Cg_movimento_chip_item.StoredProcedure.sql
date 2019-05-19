USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_chip_item]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_movimento_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_MOVIMENTO_CHIP_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------




GO
