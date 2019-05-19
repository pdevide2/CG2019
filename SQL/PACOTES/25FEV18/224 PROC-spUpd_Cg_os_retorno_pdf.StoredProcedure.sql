USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_retorno_pdf]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_os_retorno_pdf]
      
	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@LAUDO_FORNEC AS IMAGE = NULL

AS

BEGIN
UPDATE CG_OS_ITEM SET

    LAUDO_FORNEC = @LAUDO_FORNEC

WHERE

	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END






GO
