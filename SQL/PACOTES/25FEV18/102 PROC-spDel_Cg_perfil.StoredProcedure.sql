USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_perfil]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[spDel_Cg_perfil]

	@ID_PERFIL As int

AS

BEGIN
DELETE FROM CG_PERFIL WHERE
	ID_PERFIL = @ID_PERFIL

END
------------------------------------------------------------



GO
