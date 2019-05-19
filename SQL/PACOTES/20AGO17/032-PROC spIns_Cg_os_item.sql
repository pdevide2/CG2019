USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spIns_Cg_os_item]    Script Date: 29/07/2017 14:30:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spIns_Cg_os_item]

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
INSERT INTO CG_OS_ITEM (
	id_os,
	item_id,
	id_equipamento,
	desc_equipamento,
	serie,
	modelo,
	protocolo,
	previsao_retorno,
	desc_defeito,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	garantia,
	ID_OCORRENCIA)
VALUES (
	@id_os,
	@item_id,
	@id_equipamento,
	@desc_equipamento,
	@serie,
	@modelo,
	@protocolo,
	@previsao_retorno,
	@desc_defeito,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@GARANTIA,
	@ID_OCORRENCIA)

END

------------------------------------------------------------




GO


