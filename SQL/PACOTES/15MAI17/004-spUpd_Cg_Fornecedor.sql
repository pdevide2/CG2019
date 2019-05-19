USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_fornecedor]    Script Date: 16/05/2017 20:29:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spUpd_Cg_fornecedor]

	@ID_FORNECEDOR As int,
	@SIGLA As varchar(50),
	@UTILIZA_NFTS As bit,
	@NOME As varchar(50),
	@CEP As varchar(9) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CIDADE As varchar(50) = NULL,
	@BAIRRO As varchar(50) = NULL,
	@UF As char(2) = NULL,
	@EMAIL As varchar(120) = NULL,
	@TELEFONE As varchar(20) = NULL,
	@CONTATO As varchar(50) = NULL,
	@WHATSAPP As varchar(20) = NULL,
	@ID_TIPO_SERVICO As int = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA_AQUISICAO INT = NULL,
	@GARANTIA_ASSISTENCIA INT = NULL

AS

BEGIN
UPDATE CG_FORNECEDOR SET
	sigla = @sigla,
	utiliza_nfts = @utiliza_nfts,
	nome = @nome,
	cep = @cep,
	endereco = @endereco,
	complemento = @complemento,
	cidade = @cidade,
	bairro = @bairro,
	uf = @uf,
	email = @email,
	telefone = @telefone,
	contato = @contato,
	whatsapp = @whatsapp,
	id_tipo_servico = @id_tipo_servico,
	obs = @obs,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	GARANTIA_AQUISICAO = @GARANTIA_AQUISICAO,
	GARANTIA_ASSISTENCIA = @GARANTIA_ASSISTENCIA
WHERE
	ID_FORNECEDOR = @ID_FORNECEDOR

END
------------------------------------------------------------



