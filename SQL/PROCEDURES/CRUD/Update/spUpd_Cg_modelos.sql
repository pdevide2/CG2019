CREATE PROCEDURE spUpd_Cg_modelos	@ID_MODELO As int,	@DESC_MODELO As varchar(100),	@OBS As text = NULL,	@CAMINHO_ARQUIVO As varchar(150) = NULL,	@EXTENSAO_ARQUIVO As varchar(5) = NULLASBEGINUPDATE CG_MODELOS SET	desc_modelo = @desc_modelo,	obs = @obs,	caminho_arquivo = @caminho_arquivo,	extensao_arquivo = @extensao_arquivoWHERE	ID_MODELO = @ID_MODELOEND------------------------------------------------------------