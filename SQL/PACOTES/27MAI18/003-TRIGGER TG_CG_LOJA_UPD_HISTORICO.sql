IF EXISTS (SELECT name FROM sys.objects  
      WHERE name = 'TG_CG_LOJA_UPD_HISTORICO' AND type = 'TR')  
   DROP TRIGGER DBO.TG_CG_LOJA_UPD_HISTORICO;  
GO 

CREATE TRIGGER TG_CG_LOJA_UPD_HISTORICO ON DBO.CG_LOJA AFTER UPDATE
AS

DECLARE 
	@ID_HISTORICO  int,
	@ID_LOJA  int,
	@SIGLA  varchar(50),
	@NOME  varchar(50) ,
	@ENDERECO  varchar(70) ,
	@COMPLEMENTO  varchar(40) ,
	@CEP  varchar(9) ,
	@CIDADE  varchar(50) ,
	@BAIRRO  varchar(50) ,
	@UF  char(2),
	@ID_TIPO_LOCAL  int ,
	@ID_RESPONSAVEL  int ,
	@USER_INS  int ,
	@DATA_INS  datetime ,
	@USER_UPD  int ,
	@DATA_UPD  datetime ,
	@CODIGO  varchar(10),
	@TELEFONE  varchar(20) ,
	@CELULAR  varchar(20) ,
	@LOJA_FISICA  bit,
	@PARCERIA  bit,
	@ID_AREA  char(8),
	@ID_EMPRESA  int,
	@ID_TIPO_LOCAL_ESTOQUE  int,
	@TELEFONE2  varchar(20) ,
	@CELULAR2  varchar(20) ,
	@CELULAR3  varchar(20) ,
	@CELULAR4  varchar(20) ,
	@CELULAR5  varchar(20) ,
	@CELULAR6  varchar(20) ,
	@INATIVO  bit,
	@ULTIMA_ATUALIZACAO  datetime,
	@INICIO_VIGENCIA  datetime ,
	@FINAL_VIGENCIA  datetime  

SELECT 
	@ID_LOJA = d.ID_LOJA, 
	@SIGLA = d.SIGLA, 
	@NOME = d.NOME, 
	@ENDERECO = d.ENDERECO, 
	@COMPLEMENTO = d.COMPLEMENTO, 
	@CEP = d.CEP, 
	@CIDADE = d.CIDADE, 
	@BAIRRO = d.BAIRRO, 
	@UF = d.UF, 
	@ID_TIPO_LOCAL = d.ID_TIPO_LOCAL, 
	@ID_RESPONSAVEL = d.ID_RESPONSAVEL, 
	@USER_INS = d.USER_INS, 
	@DATA_INS = d.DATA_INS, 
	@USER_UPD = d.USER_UPD, 
	@DATA_UPD = GETDATE(), 
	@CODIGO = d.CODIGO, 
	@TELEFONE = d.TELEFONE, 
	@CELULAR = d.CELULAR, 
	@LOJA_FISICA = d.LOJA_FISICA, 
	@PARCERIA = d.PARCERIA, 
	@ID_AREA = d.ID_AREA, 
	@ID_EMPRESA = d.ID_EMPRESA, 
	@ID_TIPO_LOCAL_ESTOQUE = d.ID_TIPO_LOCAL_ESTOQUE, 
	@TELEFONE2 = d.TELEFONE2, 
	@CELULAR2 = d.CELULAR2, 
	@CELULAR3 = d.CELULAR3, 
	@CELULAR4 = d.CELULAR4, 
	@CELULAR5 = d.CELULAR5, 
	@CELULAR6 = d.CELULAR6, 
	@INATIVO = 1, 
	@ULTIMA_ATUALIZACAO = GETDATE(), 
	@INICIO_VIGENCIA = d.INICIO_VIGENCIA, 
	@FINAL_VIGENCIA = GETDATE()
FROM deleted d

IF	UPDATE(ID_LOJA) OR 
	UPDATE(SIGLA) OR 
	UPDATE(NOME) OR 
	UPDATE(ENDERECO) OR 
	UPDATE(COMPLEMENTO) OR 
	UPDATE(CEP) OR 
	UPDATE(CIDADE) OR 
	UPDATE(BAIRRO) OR 
	UPDATE(UF) OR 
	UPDATE(ID_TIPO_LOCAL) OR 
	UPDATE(ID_RESPONSAVEL) OR 
	UPDATE(USER_INS) OR 
	UPDATE(DATA_INS) OR 
	UPDATE(USER_UPD) OR 
	UPDATE(DATA_UPD) OR 
	UPDATE(CODIGO) OR 
	UPDATE(TELEFONE) OR 
	UPDATE(CELULAR) OR 
	UPDATE(LOJA_FISICA) OR 
	UPDATE(PARCERIA) OR 
	UPDATE(ID_AREA) OR 
	UPDATE(ID_EMPRESA) OR 
	UPDATE(TELEFONE2) OR 
	UPDATE(CELULAR2) OR 
	UPDATE(CELULAR3) OR 
	UPDATE(CELULAR4) OR 
	UPDATE(CELULAR5) OR 
	UPDATE(CELULAR6) OR 
	UPDATE(INATIVO) OR 
	UPDATE(INICIO_VIGENCIA) OR 
	UPDATE(FINAL_VIGENCIA)  
BEGIN
	INSERT INTO CG_LOJA_HISTORICO (
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
		codigo,
		telefone,
		celular,
		loja_fisica,
		parceria,
		id_area,
		id_empresa,
		id_tipo_local_estoque,
		telefone2,
		celular2,
		celular3,
		celular4,
		celular5,
		celular6,
		inativo,
		ultima_atualizacao,
		inicio_vigencia,
		final_vigencia)
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
		@codigo,
		@telefone,
		@celular,
		@loja_fisica,
		@parceria,
		@id_area,
		@id_empresa,
		@id_tipo_local_estoque,
		@telefone2,
		@celular2,
		@celular3,
		@celular4,
		@celular5,
		@celular6,
		@inativo,
		@ultima_atualizacao,
		@inicio_vigencia,
		@final_vigencia)

END
GO
