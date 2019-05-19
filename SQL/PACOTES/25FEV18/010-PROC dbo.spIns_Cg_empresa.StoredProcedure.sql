IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_Cg_empresa')
DROP PROC spIns_Cg_empresa
GO

IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_Cg_empresa')
DROP PROC spUpd_Cg_empresa
GO

IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spDel_Cg_empresa')
DROP PROC spDel_Cg_empresa
GO

CREATE PROCEDURE spIns_Cg_empresa

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