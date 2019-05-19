USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_area]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_area]

	@ID_AREA As char(8),
	@ID_EMPRESA INT

AS

BEGIN
DELETE FROM CG_AREA WHERE
	ID_AREA = @ID_AREA AND ID_EMPRESA = @ID_EMPRESA

END
------------------------------------------------------------



GO
