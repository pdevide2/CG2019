ALTER TABLE CG_OS_ITEM 
ADD LAUDO BIT NOT NULL CONSTRAINT DF_CG_OS_ITEM_LAUDO DEFAULT(0),
	OUTROS BIT NOT NULL CONSTRAINT DF_CG_OS_ITEM_OUTROS DEFAULT(0),
	MOTIVO_OUTROS VARCHAR(50) NULL
GO

/* TABELA DE SERVICOS DO FORNECEDOR POR ITEM*/
ALTER TABLE CG_OS_ITEM
ADD ID_TABELA VARCHAR(10) NULL
GO
