USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_modelos]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_modelos]

	@ID_MODELO As int

AS

BEGIN
DELETE FROM CG_MODELOS WHERE
	ID_MODELO = @ID_MODELO

END
------------------------------------------------------------



GO
