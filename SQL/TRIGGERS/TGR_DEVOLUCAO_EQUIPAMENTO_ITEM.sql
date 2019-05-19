USE [dbCG]
GO
/****** Object:  Trigger [dbo].[TGR_DEVOLUCAO_EQUIPAMENTO_ITEM]    Script Date: 02/04/2017 22:33:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[TGR_DEVOLUCAO_EQUIPAMENTO_ITEM] ON [dbo].[CG_DEVOLUCAO_EQUIPAMENTO_ITEM] 
FOR INSERT, DELETE
AS
BEGIN

DECLARE @TIPO_OP CHAR(1), @ID_ROMANEIO INT, @ID_TRANSACAO CHAR(3)
DECLARE @ID_LOCAL_DE INT, @ID_LOCAL_PARA INT, @ENTRADA_SAIDA CHAR(1)
DECLARE @OBS VARCHAR(200),@ID_EQUIPAMENTO INT

IF EXISTS (SELECT * FROM INSERTED) AND NOT EXISTS (SELECT * FROM DELETED)
BEGIN
    SET @TIPO_OP = 'I' /*INSERT*/
    SET @ID_TRANSACAO = 'DIE'

    SELECT distinct @ID_ROMANEIO = i.ID_ROMANEIO, @ID_EQUIPAMENTO = i.ID_EQUIPAMENTO
    FROM inserted i
END

IF NOT EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
BEGIN
    SET @TIPO_OP = 'D' /*DELETE*/
    SET @ID_TRANSACAO = 'DEE'

    SELECT distinct @ID_ROMANEIO = d.ID_ROMANEIO, @ID_EQUIPAMENTO = d.ID_EQUIPAMENTO
    FROM deleted d
END

DECLARE @ID_LOJA INT,  
	   @ROMANEIO_ESTOQUE INT


SELECT  @ID_LOJA = 1,  
	   @ROMANEIO_ESTOQUE = a.ROMANEIO_ESTOQUE
FROM CG_DEVOLUCAO_EQUIPAMENTO a
where a.ID_ROMANEIO = @ID_ROMANEIO

IF @TIPO_OP = 'I'
BEGIN
    SET @ID_LOCAL_DE = 1
    SET @ID_LOCAL_PARA = 9
    SET @ENTRADA_SAIDA = 'S'
    SET @OBS = 'DEVOLUCAO - INCLUSAO EQUIPAMENTO'
END

IF @TIPO_OP = 'D'
BEGIN
    SET @ID_LOCAL_DE = 9
    SET @ID_LOCAL_PARA = 1
    SET @ENTRADA_SAIDA = 'E'
    SET @OBS = 'DEVOLUCAO - ESTORNO EQUIPAMENTO'
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
           ,0 /*FALSE PARA TRANSITO*/
           ,@ID_LOCAL_DE
           ,@ID_LOCAL_PARA
           ,GETDATE()
           ,@ENTRADA_SAIDA
           ,1
           ,@OBS
		 ,@ID_EQUIPAMENTO)

END

