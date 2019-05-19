USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_PDF_NF_Fornec]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[spUpd_Cg_os_PDF_NF_Fornec]
      
	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@PDF AS IMAGE = NULL

AS

BEGIN
UPDATE CG_OS_ITEM SET

    PDF_NF_FORNEC = @PDF

WHERE

	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO
END





GO
