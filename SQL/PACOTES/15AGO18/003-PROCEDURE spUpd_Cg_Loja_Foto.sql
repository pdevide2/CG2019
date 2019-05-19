USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_Peca_Foto]    Script Date: 05/08/2018 20:15:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_Loja_Foto]
      
	@ID_LOJA As int,
	@FOTO AS IMAGE = NULL,
	@FILETYPE AS VARCHAR(5) = NULL

AS

BEGIN
UPDATE CG_LOJA SET

    FOTO = @FOTO,
    FILETYPE = @FILETYPE

WHERE

	ID_LOJA = @ID_LOJA

END





