USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_peca]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_peca]

	@ID_PECA As int

AS

BEGIN
DELETE FROM CG_PECA WHERE
	ID_PECA = @ID_PECA

END
------------------------------------------------------------



GO
