USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_finalidade]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_finalidade]

	@ID_FINALIDADE As int

AS

BEGIN
DELETE FROM CG_FINALIDADE WHERE
	ID_FINALIDADE = @ID_FINALIDADE

END
------------------------------------------------------------



GO
