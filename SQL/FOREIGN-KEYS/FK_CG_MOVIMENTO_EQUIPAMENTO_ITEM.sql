ALTER TABLE CG_MOVIMENTO_EQUIPAMENTO_ITEM
	ADD CONSTRAINT FK_CG_MOVIMENTO_EQUIPAMENTO_ITEM_1
	FOREIGN KEY (ID_ROMANEIO)
	REFERENCES CG_MOVIMENTO_EQUIPAMENTO(ID_ROMANEIO)
GO

ALTER TABLE CG_MOVIMENTO_EQUIPAMENTO_ITEM
	ADD CONSTRAINT FK_CG_MOVIMENTO_EQUIPAMENTO_ITEM_2
	FOREIGN KEY (ID_EQUIPAMENTO)
	REFERENCES CG_EQUIPAMENTO(ID_EQUIPAMENTO)
GO

