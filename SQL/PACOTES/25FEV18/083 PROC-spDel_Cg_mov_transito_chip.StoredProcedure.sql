USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_mov_transito_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_mov_transito_chip]

	@ID_LANCTO As bigint

AS

BEGIN
DELETE FROM CG_MOV_TRANSITO_CHIP WHERE
	ID_LANCTO = @ID_LANCTO

END
------------------------------------------------------------



GO
