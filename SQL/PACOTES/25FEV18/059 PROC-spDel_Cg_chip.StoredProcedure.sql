USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_chip]

	@ID_CHIP As int

AS

BEGIN
DELETE FROM CG_CHIP WHERE
	ID_CHIP = @ID_CHIP

END
------------------------------------------------------------



GO
