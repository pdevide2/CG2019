
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER dbo.TGR_UPD_CG_LOG_ENTRADA_EQUIPAMENTO_ITEM 
   ON  DBO.CG_LOG_ENTRADA_EQUIPAMENTO_ITEM 
   AFTER UPDATE
AS 
BEGIN

	SET NOCOUNT ON;
	DECLARE @MOVIMENTO_CONFERIDO BIT
	DECLARE @REPROVADO BIT

	DECLARE @ID_ROMANEIO As int,
			@UNIQUE_KEYID As uniqueidentifier,
			@ID_EQUIPAMENTO As int,
			@SERIE As varchar(30),
			@QTD As int,
			@VALOR As numeric(12,2),
			@ID_EMPRESA As int

	SELECT	@MOVIMENTO_CONFERIDO=MOVIMENTO_CONFERIDO, 
			@REPROVADO=REPROVADO
	FROM inserted
    
	/*
	Somente efetiva a movimentação do estoque caso 
	o flag MOVIMENTO_CONFERIDO seja igual a 1 e não tenha sido REPROVADO (REPROVADO = 1)
	*/
	IF @MOVIMENTO_CONFERIDO=1 AND @REPROVADO=0
	BEGIN

			SELECT	@ID_ROMANEIO=i.ID_ROMANEIO,
					@UNIQUE_KEYID=i.UNIQUE_KEYID,
					@ID_EQUIPAMENTO=i.ID_EQUIPAMENTO,
					@SERIE=i.SERIE,
					@QTD=i.QTD,
					@VALOR=i.VALOR,
					@ID_EMPRESA=i.ID_EMPRESA
			FROM INSERTED i

		INSERT INTO CG_ENTRADA_EQUIPAMENTO_ITEM (
			id_romaneio,
			unique_keyid,
			id_equipamento,
			serie,
			qtd,
			valor,
			id_empresa)
		VALUES (
			@id_romaneio,
			@unique_keyid,
			@id_equipamento,
			@serie,
			@qtd,
			@valor,
			@id_empresa)

	END

END
GO
