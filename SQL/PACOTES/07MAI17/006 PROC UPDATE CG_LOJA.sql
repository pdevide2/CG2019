USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_loja]    Script Date: 07/05/2017 14:55:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spUpd_Cg_loja]

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
UPDATE CG_LOJA SET
	sigla = @sigla,
	nome = @nome,
	endereco = @endereco,
	complemento = @complemento,
	cep = @cep,
	cidade = @cidade,
	bairro = @bairro,
	uf = @uf,
	id_tipo_local = @id_tipo_local,
	id_responsavel = @id_responsavel,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	codigo = @CODIGO,
	TELEFONE = @TELEFONE,
	CELULAR = @CELULAR
WHERE
	ID_LOJA = @ID_LOJA

END
------------------------------------------------------------



