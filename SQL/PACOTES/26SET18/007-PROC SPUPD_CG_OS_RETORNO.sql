USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_retorno]    Script Date: 23/09/2018 10:27:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spUpd_Cg_os_retorno]
      
	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@DATA_RETORNO AS DATETIME = NULL,
	@DESC_DEFEITO As varchar(250) = NULL,
	@CONSERTO_OK As bit,
	@NF_FORNEC As varchar(10) = NULL,
	@SERIE_NF_FORNEC As varchar(10) = NULL,
	@EMISSAO_NF_FORNEC As datetime = NULL,
	@OBS_RETORNO text = NULL,
	@ID_RESPONSAVEL_RET As int = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA AS BIT = NULL,
	@VALOR_CONSERTO NUMERIC(12,2) = NULL,
	@CONFIG_GARANTIA BIT = NULL, 
	@QTDE_DIAS_GARANTIA INT = NULL, 
    @DATA_INICIO_GARANTIA DATETIME = NULL, 
	@DATA_TERMINO_GARANTIA DATETIME = NULL, 
	@LAUDO AS BIT,
	@OUTROS AS BIT,
	@MOTIVO_OUTROS AS VARCHAR(50) = '',
	@ID_TABELA AS VARCHAR(10) = NULL
AS

BEGIN
UPDATE CG_OS_ITEM SET
    DATA_RETORNO =@DATA_RETORNO,
    DESC_DEFEITO =@DESC_DEFEITO,
    CONSERTO_OK =@CONSERTO_OK,
    NF_FORNEC =@NF_FORNEC,
    SERIE_NF_FORNEC =@SERIE_NF_FORNEC,
    EMISSAO_NF_FORNEC =@EMISSAO_NF_FORNEC,
    OBS_RETORNO =@OBS_RETORNO,
    ID_RESPONSAVEL_RET =@ID_RESPONSAVEL_RET,
    user_upd = @user_upd,
    data_upd = @data_upd,
    RECEBIDO = CASE WHEN @DATA_RETORNO IS NULL THEN 0 ELSE 1 END,
    GARANTIA = @GARANTIA,
    VALOR_CONSERTO = @VALOR_CONSERTO,
    CONFIG_GARANTIA = @CONFIG_GARANTIA,
    QTDE_DIAS_GARANTIA = @QTDE_DIAS_GARANTIA,
    DATA_INICIO_GARANTIA = @DATA_INICIO_GARANTIA,
    DATA_TERMINO_GARANTIA = @DATA_TERMINO_GARANTIA,
	LAUDO=@LAUDO,
	OUTROS=@OUTROS,
	MOTIVO_OUTROS=@MOTIVO_OUTROS,
	ID_TABELA = @ID_TABELA


WHERE
	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO



END





