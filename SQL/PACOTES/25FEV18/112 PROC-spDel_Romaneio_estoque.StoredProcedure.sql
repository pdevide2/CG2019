USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Romaneio_estoque]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Romaneio_estoque]

	@ROMANEIO As int

AS

BEGIN
DELETE FROM ROMANEIO_ESTOQUE WHERE
	ROMANEIO = @ROMANEIO

END
------------------------------------------------------------



GO
