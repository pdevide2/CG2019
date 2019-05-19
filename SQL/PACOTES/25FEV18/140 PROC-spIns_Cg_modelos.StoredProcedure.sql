USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_modelos]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_modelos]

	@ID_MODELO As int,
	@DESC_MODELO As varchar(100),
	@OBS As text = NULL,
	@CAMINHO_ARQUIVO As varchar(150) = NULL,
	@EXTENSAO_ARQUIVO As varchar(5) = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_MODELOS (
	id_modelo,
	desc_modelo,
	obs,
	caminho_arquivo,
	extensao_arquivo,
	id_empresa)
VALUES (
	@id_modelo,
	@desc_modelo,
	@obs,
	@caminho_arquivo,
	@extensao_arquivo,
	@id_empresa)

END

------------------------------------------------------------




GO
