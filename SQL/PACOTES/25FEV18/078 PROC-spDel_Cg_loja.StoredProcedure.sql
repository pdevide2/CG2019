USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_loja]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_loja]

	@ID_LOJA As int

AS

BEGIN
DELETE FROM CG_LOJA WHERE
	ID_LOJA = @ID_LOJA

END
------------------------------------------------------------



GO
