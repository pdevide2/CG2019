USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_chip]    Script Date: 20/05/2017 09:15:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_movimento_chip_inativo]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_MOVIMENTO_CHIP_INATIVO WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------


