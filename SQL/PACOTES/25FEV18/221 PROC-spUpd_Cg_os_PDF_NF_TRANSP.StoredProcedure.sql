USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_PDF_NF_TRANSP]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_os_PDF_NF_TRANSP]
      
	@ID_OS As int,
	@PDF AS IMAGE = NULL

AS

BEGIN
UPDATE CG_OS SET

    PDF_NF_TRANSP = @PDF

WHERE

	ID_OS = @ID_OS 

END





GO
