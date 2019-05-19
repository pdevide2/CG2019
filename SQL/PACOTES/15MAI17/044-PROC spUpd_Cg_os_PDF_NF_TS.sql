USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_retorno_pdf]    Script Date: 28/05/2017 11:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_os_PDF_NF_TS]
      
	@ID_OS As int,
	@PDF AS IMAGE = NULL

AS

BEGIN
UPDATE CG_OS SET

    PDF_NF_TS = @PDF

WHERE

	ID_OS = @ID_OS 

END




