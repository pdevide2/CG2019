USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_item]    Script Date: 29/07/2017 14:28:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[spUpd_Cg_os_item]

	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL,
	@PROTOCOLO As varchar(30) = NULL,
	@PREVISAO_RETORNO As datetime = NULL,
	@DESC_DEFEITO As varchar(250) = NULL,
	/*@CONSERTO_OK As bit,
	@NF_FORNEC As varchar(10) = NULL,
	@SERIE_NF_FORNEC As varchar(10) = NULL,
	@EMISSAO_NF_FORNEC As datetime = NULL,
	@ID_RESPONSAVEL_RET As int = NULL,
	@XML_NF_FORNEC As xml = NULL,
	@LAUDO_FORNEC As image = NULL,*/
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA AS BIT = NULL,
	@ID_OCORRENCIA AS INT = NULL 

AS

BEGIN
UPDATE CG_OS_ITEM SET
	id_equipamento = @id_equipamento,
	desc_equipamento = @desc_equipamento,
	serie = @serie,
	modelo = @modelo,
	protocolo = @protocolo,
	previsao_retorno = @previsao_retorno,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	GARANTIA = @GARANTIA,
	ID_OCORRENCIA = @ID_OCORRENCIA
WHERE
	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END
------------------------------------------------------------




GO


