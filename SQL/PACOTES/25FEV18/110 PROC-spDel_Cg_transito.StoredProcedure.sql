USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_transito]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_transito]

	@ID_TRANSITO As int

AS

BEGIN
DELETE FROM CG_TRANSITO WHERE
	ID_TRANSITO = @ID_TRANSITO

END
------------------------------------------------------------



GO
