USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_loja]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_loja]

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
	@CODIGO As varchar(10) = NULL,
	@TELEFONE As varchar(20) = NULL,
	@CELULAR As varchar(20) = NULL,
	@LOJA_FISICA As bit,
	@PARCERIA As bit,
	@ID_AREA As char(8),
	@ID_EMPRESA As int,
	@ID_TIPO_LOCAL_ESTOQUE As int

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
	telefone = @telefone,
	celular = @celular,
	loja_fisica = @loja_fisica,
	parceria = @parceria,
	id_area = @id_area,
	id_empresa = @id_empresa,
	ID_TIPO_LOCAL_ESTOQUE = @ID_TIPO_LOCAL_ESTOQUE
WHERE
	ID_LOJA = @ID_LOJA

END
------------------------------------------------------------




GO
