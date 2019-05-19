USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_Peca_Foto]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[spUpd_Cg_Peca_Foto]
      
	@ID_PECA As int,
	@FOTO AS IMAGE = NULL,
	@FILETYPE AS VARCHAR(5) = NULL

AS

BEGIN
UPDATE CG_PECA SET

    FOTO = @FOTO,
    FILETYPE = @FILETYPE

WHERE

	ID_PECA = @ID_PECA 

END





GO
