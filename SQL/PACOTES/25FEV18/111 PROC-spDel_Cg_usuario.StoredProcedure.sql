USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_usuario]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_usuario]

	@ID_USUARIO As int

AS

BEGIN
DELETE FROM CG_USUARIO WHERE
	ID_USUARIO = @ID_USUARIO

END
------------------------------------------------------------



GO
