USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_os_item]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_os_item]

	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int

AS

BEGIN
DELETE FROM CG_OS_ITEM WHERE
	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND 
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END
------------------------------------------------------------




GO
