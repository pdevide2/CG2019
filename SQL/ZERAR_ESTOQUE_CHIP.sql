/*ZERAR MOVIMENTAÇÃO DE ESTOQUE*/

ALTER TABLE CG_MOVIMENTO_CHIP_ITEM
DISABLE TRIGGER ALL
GO

ALTER TABLE CG_MOVIMENTO_CHIP
DISABLE TRIGGER ALL
GO

ALTER TABLE CG_ENTRADA_CHIP_ITEM
DISABLE TRIGGER ALL
GO

ALTER TABLE CG_ENTRADA_CHIP
DISABLE TRIGGER ALL
GO

ALTER TABLE CG_DEVOLUCAO_CHIP_ITEM
DISABLE TRIGGER ALL
GO

ALTER TABLE CG_DEVOLUCAO_CHIP
DISABLE TRIGGER ALL
GO

ALTER TABLE CG_ESTOQUE_CHIP
DISABLE TRIGGER ALL
GO

ALTER TABLE ROMANEIO_ESTOQUE_ITEM
DISABLE TRIGGER ALL
GO

ALTER TABLE ROMANEIO_ESTOQUE
DISABLE TRIGGER ALL
GO


DELETE FROM CG_MOVIMENTO_CHIP_ITEM
GO

DELETE FROM CG_MOVIMENTO_CHIP
GO

DELETE FROM CG_ENTRADA_CHIP_ITEM
GO

DELETE FROM CG_ENTRADA_CHIP
GO

DELETE FROM CG_DEVOLUCAO_CHIP_ITEM
GO

DELETE FROM CG_DEVOLUCAO_CHIP
GO

DELETE FROM CG_ESTOQUE_CHIP
GO

DELETE FROM ROMANEIO_ESTOQUE_ITEM
GO

DELETE FROM ROMANEIO_ESTOQUE
GO

UPDATE CG_SEQUENCIAL SET KEYID = 0 
  WHERE TABELA IN ('CG_DEVOLUCAO_CHIP','CG_ENTRADA_CHIP','CG_MOVIMENTO_CHIP')
GO

UPDATE CG_CHIP SET ID_LOCAL_ESTOQUE = 0
GO

ALTER TABLE CG_MOVIMENTO_CHIP_ITEM
ENABLE TRIGGER ALL
GO

ALTER TABLE CG_MOVIMENTO_CHIP
ENABLE TRIGGER ALL
GO

ALTER TABLE CG_ENTRADA_CHIP_ITEM
ENABLE TRIGGER ALL
GO

ALTER TABLE CG_ENTRADA_CHIP
ENABLE TRIGGER ALL
GO

ALTER TABLE CG_DEVOLUCAO_CHIP_ITEM
ENABLE TRIGGER ALL
GO

ALTER TABLE CG_DEVOLUCAO_CHIP
ENABLE TRIGGER ALL
GO

ALTER TABLE CG_ESTOQUE_CHIP
ENABLE TRIGGER ALL
GO

ALTER TABLE ROMANEIO_ESTOQUE_ITEM
ENABLE TRIGGER ALL
GO

ALTER TABLE ROMANEIO_ESTOQUE
ENABLE TRIGGER ALL
GO