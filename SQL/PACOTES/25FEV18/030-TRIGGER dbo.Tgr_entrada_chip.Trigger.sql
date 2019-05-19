/* FIM: =======> TGR_DEVOLUCAO_EQUIPAMENTO_ITEM*/

/* INICIO: =======> TGR_ENTRADA_CHIP*/
ALTER TRIGGER [dbo].[TGR_ENTRADA_CHIP] ON [dbo].[CG_ENTRADA_CHIP] 
FOR INSERT, UPDATE, DELETE
AS
BEGIN

DECLARE @TIPO_OP CHAR(1), @ID_USUARIO INT, @ID_EMPRESA INT 
IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
BEGIN
    SET @TIPO_OP = 'A' /*ALTERA��O*/
    SELECT @ID_USUARIO = inserted.USER_INS, @ID_EMPRESA = inserted.ID_EMPRESA
    FROM inserted
END

IF EXISTS (SELECT * FROM INSERTED) AND NOT EXISTS (SELECT * FROM DELETED)
BEGIN
    SET @TIPO_OP = 'I' /*INSERT*/
    SELECT @ID_USUARIO = inserted.USER_UPD, @ID_EMPRESA = inserted.ID_EMPRESA
    FROM inserted
END

IF NOT EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
BEGIN
    SET @TIPO_OP = 'D' /*DELETE*/
    SELECT @ID_USUARIO = deleted.USER_UPD, @ID_EMPRESA = deleted.ID_EMPRESA
    FROM deleted
END

INSERT INTO [dbo].[ROMANEIO_ESTOQUE]
           ([MODULO]
           ,[TIPO_PRODUTO]
           ,[TIPO_OP]
           ,[DATAMOV]
           ,[ID_USUARIO]
		   ,[ID_EMPRESA])
     VALUES
           ('ENTRADA DE CHIP'
           ,'C'
           ,@TIPO_OP
           ,GETDATE()
           ,@ID_USUARIO
		   ,@ID_EMPRESA)

DECLARE @CHAVE INT
SELECT @CHAVE = IDENT_CURRENT ('ROMANEIO_ESTOQUE')

IF @TIPO_OP IN ('I', 'A') 
BEGIN
    UPDATE CG_ENTRADA_CHIP set ROMANEIO_ESTOQUE = @CHAVE
    FROM inserted i 
    where CG_ENTRADA_CHIP.ID_ROMANEIO = i.ID_ROMANEIO
END

END


