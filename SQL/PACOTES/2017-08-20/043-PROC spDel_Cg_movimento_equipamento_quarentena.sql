USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_equipamento_QUARENTENA]    Script Date: 19/08/2017 10:05:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spDel_Cg_movimento_equipamento_quarentena]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO


