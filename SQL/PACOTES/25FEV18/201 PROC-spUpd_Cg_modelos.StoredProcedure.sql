USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_modelos]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_modelos]

	@ID_MODELO As int,
	@DESC_MODELO As varchar(100),
	@OBS As text = NULL,
	@CAMINHO_ARQUIVO As varchar(150) = NULL,
	@EXTENSAO_ARQUIVO As varchar(5) = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_MODELOS SET
	desc_modelo = @desc_modelo,
	obs = @obs,
	caminho_arquivo = @caminho_arquivo,
	extensao_arquivo = @extensao_arquivo,
	id_empresa = @id_empresa
WHERE
	ID_MODELO = @ID_MODELO

END
------------------------------------------------------------




GO
