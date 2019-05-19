USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_chip_item]    Script Date: 20/05/2017 09:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_movimento_chip_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier

AS

BEGIN
DELETE FROM CG_MOVIMENTO_CHIP_INATIVO_ITEM WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------


