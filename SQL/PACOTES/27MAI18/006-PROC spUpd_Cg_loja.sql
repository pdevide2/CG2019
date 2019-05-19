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
	@CODIGO As varchar(10) = NULL,
	@TELEFONE As varchar(20) = NULL,
	@CELULAR As varchar(20) = NULL,
	@LOJA_FISICA As bit,
	@PARCERIA As bit,
	@ID_AREA As char(8),
	@ID_EMPRESA As int,
	@ID_TIPO_LOCAL_ESTOQUE As int,	@TELEFONE2 As varchar(20) = NULL,	@CELULAR2 As varchar(20) = NULL,	@CELULAR3 As varchar(20) = NULL,	@CELULAR4 As varchar(20) = NULL,	@CELULAR5 As varchar(20) = NULL,	@CELULAR6 As varchar(20) = NULL,	@INATIVO As bit,	@ULTIMA_ATUALIZACAO As datetime,	@INICIO_VIGENCIA As datetime = NULL,	@FINAL_VIGENCIA As datetime = NULL

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
	ID_TIPO_LOCAL_ESTOQUE = @ID_TIPO_LOCAL_ESTOQUE,	telefone2 = @telefone2,	celular2 = @celular2,	celular3 = @celular3,	celular4 = @celular4,	celular5 = @celular5,	celular6 = @celular6,	inativo = @inativo,	ultima_atualizacao = @ultima_atualizacao,	inicio_vigencia = @inicio_vigencia,	final_vigencia = @final_vigencia
WHERE
	ID_LOJA = @ID_LOJA

END
------------------------------------------------------------




