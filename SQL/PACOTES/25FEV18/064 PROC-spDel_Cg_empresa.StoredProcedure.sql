USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_empresa]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spDel_Cg_empresa]

	@ID_EMPRESA As int 

AS

BEGIN
DELETE FROM CG_EMPRESA WHERE 
	ID_EMPRESA = @ID_EMPRESA

END

GO
