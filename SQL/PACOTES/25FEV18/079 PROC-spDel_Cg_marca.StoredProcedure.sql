USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_marca]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_marca]

	@ID_MARCA As int

AS

BEGIN
DELETE FROM CG_MARCA WHERE
	ID_MARCA = @ID_MARCA

END
------------------------------------------------------------



GO
