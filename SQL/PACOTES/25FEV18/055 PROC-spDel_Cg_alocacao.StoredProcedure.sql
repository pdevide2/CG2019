USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_alocacao]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_alocacao]

	@ID_ALOCACAO As int

AS

BEGIN
DELETE FROM CG_ALOCACAO WHERE
	ID_ALOCACAO = @ID_ALOCACAO

END
------------------------------------------------------------



GO
