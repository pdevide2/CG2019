USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_operadora]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_operadora]

	@ID_OPERADORA As int

AS

BEGIN
DELETE FROM CG_OPERADORA WHERE
	ID_OPERADORA = @ID_OPERADORA

END
------------------------------------------------------------



GO
