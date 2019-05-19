USE [dbCG]
GO
/****** Object:  Trigger [dbo].[TGR_ROMANEIO_ESTOQUE_ITEM]    Script Date: 26/03/2017 15:13:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[TGR_ROMANEIO_ESTOQUE_ITEM] 
	   ON [dbo].[ROMANEIO_ESTOQUE_ITEM] FOR INSERT 
AS
BEGIN

    DECLARE @ROMANEIO INT, @UNIQUE_KEY uniqueidentifier, @ID_TRANSACAO CHAR(3), 
		  @TRANSITO bit, @ID_LOCAL_DE int, @ID_LOCAL_PARA int, 
		  @DATAMOV datetime, @ENTRADA_SAIDA CHAR(1), @QUANTIDADE INT, @OBSERVACAO VARCHAR(200),
		  @ID_PRODUTO INT


    SELECT  @ROMANEIO = i.ROMANEIO,
		  @UNIQUE_KEY = i.UNIQUE_KEY,
		  @ID_TRANSACAO = i.ID_TRANSACAO,
		  @TRANSITO = i.TRANSITO,
		  @ID_LOCAL_DE = i.ID_LOCAL_DE,
		  @ID_LOCAL_PARA = i.ID_LOCAL_PARA,
		  @DATAMOV = i.DATAMOV,
		  @ENTRADA_SAIDA = i.ENTRADA_SAIDA,
		  @QUANTIDADE = i.QUANTIDADE,
		  @OBSERVACAO = i.OBSERVACAO,
		  @ID_PRODUTO = i.ID_PRODUTO
    FROM inserted i

    IF RIGHT(@ID_TRANSACAO,1)='C' /*CHIP*/
    BEGIN

	   IF NOT EXISTS(SELECT 1 FROM CG_ESTOQUE_CHIP WHERE ID_CHIP = @ID_PRODUTO) /*SE REGISTRO NÃO EXISTE - INSERT*/
	   BEGIN
		  INSERT INTO CG_ESTOQUE_CHIP (
				id_chip,
				estoque,
				transito,
				id_local,
				datamov)
		  VALUES (
				@ID_PRODUTO,
				@QUANTIDADE,
				@transito,
				@ID_LOCAL_PARA,
				@datamov)
	   END

	   ELSE /*REGISTRO EXISTE - ENTÃO UPDATE*/

	   BEGIN
		  UPDATE CG_ESTOQUE_CHIP SET
				estoque = @QUANTIDADE,
				transito = @transito,
				id_local = @ID_LOCAL_PARA,
				datamov = @datamov
		  WHERE
				ID_CHIP = @ID_PRODUTO

	   END

    END /*TRANSACOES DE CHIP - FIM IF*/

    IF RIGHT(@ID_TRANSACAO,1) IN ('E','O') /*EQUIPAMENTO*/
    BEGIN

	   IF NOT EXISTS(SELECT 1 FROM CG_ESTOQUE_EQUIPAMENTO WHERE ID_EQUIPAMENTO = @ID_PRODUTO) /*SE REGISTRO NÃO EXISTE - INSERT*/
	   BEGIN
		  INSERT INTO CG_ESTOQUE_EQUIPAMENTO (
				id_equipamento,
				estoque,
				transito,
				id_local,
				datamov)
		  VALUES (
				@ID_PRODUTO,
				@QUANTIDADE,
				@transito,
				@ID_LOCAL_PARA,
				@datamov)
	   END

	   ELSE /*REGISTRO EXISTE - ENTÃO UPDATE*/

	   BEGIN
		  UPDATE CG_ESTOQUE_EQUIPAMENTO SET
				estoque = @QUANTIDADE,
				transito = @transito,
				id_local = @ID_LOCAL_PARA,
				datamov = @datamov
		  WHERE
				ID_EQUIPAMENTO = @ID_PRODUTO

	   END

    END /*TRANSACOES DE EQUIPAMENTO - FIM IF*/

END


