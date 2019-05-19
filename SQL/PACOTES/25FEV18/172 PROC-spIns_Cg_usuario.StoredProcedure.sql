USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_usuario]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_usuario]

	@ID_USUARIO As int,
	@APELIDO As varchar(50),
	@NOME As varchar(50),
	@CPF As varchar(15) = NULL,
	@RG As varchar(15) = NULL,
	@EMAIL As varchar(120) = NULL,
	@TELEFONE As varchar(15) = NULL,
	@WHATSAPP As varchar(15) = NULL,
	@CEP As varchar(9) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CIDADE As varchar(40) = NULL,
	@BAIRRO As varchar(40) = NULL,
	@UF As varchar(2) = NULL,
	@LOGIN As varchar(20) = NULL,
	@ID_STATUS As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@PALAVRA_CHAVE As varchar(100) = NULL,
	@ID_PERGUNTA As tinyint = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_USUARIO (
	id_usuario,
	apelido,
	nome,
	cpf,
	rg,
	email,
	telefone,
	whatsapp,
	cep,
	endereco,
	complemento,
	cidade,
	bairro,
	uf,
	login,
	id_status,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	palavra_chave,
	id_pergunta,
	id_empresa)
VALUES (
	@id_usuario,
	@apelido,
	@nome,
	@cpf,
	@rg,
	@email,
	@telefone,
	@whatsapp,
	@cep,
	@endereco,
	@complemento,
	@cidade,
	@bairro,
	@uf,
	@login,
	@id_status,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@palavra_chave,
	@id_pergunta,
	@id_empresa)

END

GO
