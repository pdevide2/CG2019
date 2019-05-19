USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Romaneio_estoque_item]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Romaneio_estoque_item]

	@ROMANEIO As int,
	@UNIQUE_KEY As uniqueidentifier

AS

BEGIN
DELETE FROM ROMANEIO_ESTOQUE_ITEM WHERE
	ROMANEIO = @ROMANEIO AND
	UNIQUE_KEY = @UNIQUE_KEY

END
------------------------------------------------------------



GO
