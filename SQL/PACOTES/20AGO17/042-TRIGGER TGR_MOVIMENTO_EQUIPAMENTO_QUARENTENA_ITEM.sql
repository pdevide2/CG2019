USE [dbCG]
GO

/****** Object:  Trigger [dbo].[TGR_MOVIMENTO_EQUIPAMENTO_QUARENTENA_ITEM]    Script Date: 19/08/2017 09:51:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[TGR_MOVIMENTO_EQUIPAMENTO_QUARENTENA_ITEM] ON [dbo].[CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA_ITEM] 
FOR INSERT, DELETE
AS
BEGIN

DECLARE @TIPO_OP CHAR(1), @ID_ROMANEIO INT, @ID_TRANSACAO CHAR(3)
DECLARE @ID_LOCAL_DE INT, @ID_LOCAL_PARA INT, @ENTRADA_SAIDA CHAR(1)
DECLARE @OBS VARCHAR(200),@ID_EQUIPAMENTO INT, @TRANSITO BIT

IF EXISTS (SELECT * FROM INSERTED) AND NOT EXISTS (SELECT * FROM DELETED)
BEGIN
    SET @TIPO_OP = 'I' /*INSERT*/
    SET @ID_TRANSACAO = 'MIE'

    SELECT distinct @ID_ROMANEIO = i.ID_ROMANEIO, @ID_EQUIPAMENTO = i.ID_EQUIPAMENTO, @TRANSITO = i.TRANSITO
    FROM inserted i
END

IF NOT EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
BEGIN
    SET @TIPO_OP = 'D' /*DELETE*/
    SET @ID_TRANSACAO = 'MEE'

    SELECT distinct @ID_ROMANEIO = d.ID_ROMANEIO, @ID_EQUIPAMENTO = d.ID_EQUIPAMENTO, @TRANSITO = d.TRANSITO
    FROM deleted d
END

DECLARE @ID_LOJA_ORIGEM INT,  
	   @ID_LOJA_DESTINO INT,
	   @ROMANEIO_ESTOQUE INT


SELECT  @ID_LOJA_ORIGEM = a.ID_LOJA_ORIGEM,  
	   @ID_LOJA_DESTINO = a.ID_LOJA_DESTINO,
	   @ROMANEIO_ESTOQUE = a.ROMANEIO_ESTOQUE
FROM CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA a
where a.ID_ROMANEIO = @ID_ROMANEIO

IF @TIPO_OP = 'I'
BEGIN
    SET @ENTRADA_SAIDA = 'E'
    SET @OBS = 'MOVIMENTO - INCLUSAO EQUIPAMENTO'
END

IF @TIPO_OP = 'D'
BEGIN
    SET @ENTRADA_SAIDA = 'S'
    SET @OBS = 'MOVIMENTO - ESTORNO EQUIPAMENTO'
END

DECLARE @LOCAL1 INT, @LOCAL2 INT

SET @LOCAL1 = CASE @TIPO_OP
			 WHEN 'I' THEN @ID_LOJA_ORIGEM
			 WHEN 'D' THEN @ID_LOJA_DESTINO
			 ELSE 0
		    END

SET @LOCAL2 = CASE @TIPO_OP
			 WHEN 'D' THEN @ID_LOJA_ORIGEM
			 WHEN 'I' THEN @ID_LOJA_DESTINO
			 ELSE 0
		    END

INSERT INTO ROMANEIO_ESTOQUE_ITEM
           ([ROMANEIO]
           ,[UNIQUE_KEY]
           ,[ID_TRANSACAO]
           ,[TRANSITO]
           ,[ID_LOCAL_DE]
           ,[ID_LOCAL_PARA]
           ,[DATAMOV]
           ,[ENTRADA_SAIDA]
           ,[QUANTIDADE]
           ,[OBSERVACAO]
		 ,[ID_PRODUTO])
     VALUES
           (@ROMANEIO_ESTOQUE
           ,NEWID()
           ,@ID_TRANSACAO
           ,@TRANSITO
           ,@LOCAL1
           ,@LOCAL2
           ,GETDATE()
           ,@ENTRADA_SAIDA
           ,1
           ,@OBS
		 ,@ID_EQUIPAMENTO)

END


GO


