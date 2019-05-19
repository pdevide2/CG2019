USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_loja]    Script Date: 07/05/2017 14:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spIns_Cg_loja]

	@ID_LOJA As int,
	@SIGLA As varchar(50) = NULL,
	@NOME As varchar(50) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CEP As varchar(9) = NULL,
	@CIDADE As varchar(50) = NULL,
	@BAIRRO As varchar(50) = NULL,
	@UF As char(2) = NULL,
	@ID_TIPO_LOCAL As int = NULL,
	@ID_RESPONSAVEL As int = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@CODIGO AS VARCHAR(10),
	@TELEFONE AS VARCHAR(20) = NULL,
	@CELULAR AS VARCHAR(20) = NULL

AS

BEGIN
INSERT INTO CG_LOJA (
	id_loja,
	sigla,
	nome,
	endereco,
	complemento,
	cep,
	cidade,
	bairro,
	uf,
	id_tipo_local,
	id_responsavel,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	CODIGO,
	TELEFONE,
	CELULAR)
VALUES (
	@id_loja,
	@sigla,
	@nome,
	@endereco,
	@complemento,
	@cep,
	@cidade,
	@bairro,
	@uf,
	@id_tipo_local,
	@id_responsavel,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@CODIGO,
	@TELEFONE,
	@CELULAR)

END

------------------------------------------------------------



