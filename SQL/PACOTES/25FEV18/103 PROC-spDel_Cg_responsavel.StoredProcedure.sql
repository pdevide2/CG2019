USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_responsavel]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_responsavel]

	@ID_RESPONSAVEL As int

AS

BEGIN
DELETE FROM CG_RESPONSAVEL WHERE
	ID_RESPONSAVEL = @ID_RESPONSAVEL

END
------------------------------------------------------------



GO
