USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_fornecedor]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_fornecedor]

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
	@GARANTIA_AQUISICAO As int = NULL,
	@GARANTIA_ASSISTENCIA As int = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_FORNECEDOR (
	id_fornecedor,
	sigla,
	utiliza_nfts,
	nome,
	cep,
	endereco,
	complemento,
	cidade,
	bairro,
	uf,
	email,
	telefone,
	contato,
	whatsapp,
	id_tipo_servico,
	obs,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	garantia_aquisicao,
	garantia_assistencia,
	id_empresa)
VALUES (
	@id_fornecedor,
	@sigla,
	@utiliza_nfts,
	@nome,
	@cep,
	@endereco,
	@complemento,
	@cidade,
	@bairro,
	@uf,
	@email,
	@telefone,
	@contato,
	@whatsapp,
	@id_tipo_servico,
	@obs,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@garantia_aquisicao,
	@garantia_assistencia,
	@id_empresa)

END

------------------------------------------------------------




GO
