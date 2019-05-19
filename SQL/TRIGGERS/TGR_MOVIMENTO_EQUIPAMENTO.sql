USE [dbCG]
GO
/****** Object:  Trigger [dbo].[TGR_MOVIMENTO_EQUIPAMENTO]    */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TGR_MOVIMENTO_EQUIPAMENTO] ON [dbo].[CG_MOVIMENTO_EQUIPAMENTO] 
FOR INSERT, UPDATE, DELETE
AS
BEGIN

DECLARE @TIPO_OP CHAR(1), @ID_USUARIO INT
IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
BEGIN
    SET @TIPO_OP = 'A' /*ALTERAÇÃO*/
    SELECT @ID_USUARIO = inserted.USER_INS
    FROM inserted
END

IF EXISTS (SELECT * FROM INSERTED) AND NOT EXISTS (SELECT * FROM DELETED)
BEGIN
    SET @TIPO_OP = 'I' /*INSERT*/
    SELECT @ID_USUARIO = inserted.USER_UPD
    FROM inserted
END

IF NOT EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
BEGIN
    SET @TIPO_OP = 'D' /*DELETE*/
    SELECT @ID_USUARIO = deleted.USER_UPD
    FROM deleted
END

INSERT INTO [dbo].[ROMANEIO_ESTOQUE]
           ([MODULO]
           ,[TIPO_PRODUTO]
           ,[TIPO_OP]
           ,[DATAMOV]
           ,[ID_USUARIO])
     VALUES
           ('MOVIMENTAÇÃO DE EQUIPAMENTO'
           ,'C'
           ,@TIPO_OP
           ,GETDATE()
           ,@ID_USUARIO)

DECLARE @CHAVE INT
SELECT @CHAVE = IDENT_CURRENT ('ROMANEIO_ESTOQUE')

IF @TIPO_OP IN ('I', 'A') 
BEGIN
    UPDATE CG_MOVIMENTO_EQUIPAMENTO set ROMANEIO_ESTOQUE = @CHAVE
    FROM inserted i 
    where CG_MOVIMENTO_EQUIPAMENTO.ID_ROMANEIO = i.ID_ROMANEIO
END

END

