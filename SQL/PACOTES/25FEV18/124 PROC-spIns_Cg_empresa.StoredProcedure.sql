USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_empresa]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spIns_Cg_empresa]

	@ID_EMPRESA As int,
	@NOME_EMPRESA As varchar(60),
	@SIGLA_EMPRESA As varchar(20),
	@ENDERECO_EMPRESA As varchar(80) = NULL,
	@CEP_EMPRESA As varchar(10) = NULL,
	@COMPLEMENTO_EMPRESA As varchar(40) = NULL,
	@BAIRRO_EMPRESA As varchar(50) = NULL,
	@CIDADE_EMPRESA As varchar(50) = NULL,
	@UF_EMPRESA As char(2) = NULL,
	@REFERENCIA_ENDERECO As varchar(150) = NULL,
	@CONTATO_EMPRESA As varchar(50) = NULL,
	@CELULAR_EMPRESA As varchar(20) = NULL,
	@TELEFONE_EMPRESA As varchar(20) = NULL,
	@OBSERVACAO As text = NULL,
	@EMAIL varchar(150) = NULL 

AS

BEGIN
INSERT INTO CG_EMPRESA (
	id_empresa,
	nome_empresa,
	sigla_empresa,
	endereco_empresa,
	cep_empresa,
	complemento_empresa,
	bairro_empresa,
	cidade_empresa,
	uf_empresa,
	referencia_endereco,
	contato_empresa,
	celular_empresa,
	telefone_empresa,
	observacao,
	EMAIL)
VALUES (
	@id_empresa,
	@nome_empresa,
	@sigla_empresa,
	@endereco_empresa,
	@cep_empresa,
	@complemento_empresa,
	@bairro_empresa,
	@cidade_empresa,
	@uf_empresa,
	@referencia_endereco,
	@contato_empresa,
	@celular_empresa,
	@telefone_empresa,
	@observacao,
	@EMAIL)

END


GO
