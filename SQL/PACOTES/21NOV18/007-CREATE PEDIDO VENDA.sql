CREATE TABLE CG_PEDIDOVENDA (
ID_PEDIDO INT NOT NULL,
STATUS_PEDIDO VARCHAR(15) NOT NULL,
ID_CLIENTE INT NOT NULL,
DATA DATETIME NOT NULL CONSTRAINT DF_CG_PEDIDOVENDA_DATA DEFAULT (GETDATE()),
PREVISAO_ENTREGA DATETIME NOT NULL,
DATA_BAIXA DATETIME NULL,
TOT_QTDE_ORIGINAL INT NULL,
TOT_QTDE_ENTREGAR INT NULL,
CONSTRAINT PK_CG_TIPOVENDA PRIMARY KEY (ID_PEDIDO),
CONSTRAINT FK_CG_TIPOVENDA_ID_CLIENTE FOREIGN KEY (ID_CLIENTE) REFERENCES CG_CLIENTE (ID_CLIENTE)
)
GO

CREATE TABLE CG_PEDIDOVENDA_ITENS (
ID_PEDIDO INT NOT NULL,
ID_EQUIPAMENTO INT NOT NULL,
QTDE INT NOT NULL,
PRECO_VENDA NUMERIC(14,2) NOT NULL,
STATUS_ITEM INT NOT NULL,
DATA_CADASTRO DATETIME NOT NULL CONSTRAINT DF_CG_PEDIDOVENDA_ITENS_DATA_CADASTRO DEFAULT (GETDATE()),
DATA_BAIXA DATETIME NULL,
ULTIMA_ALTERACAO DATETIME NOT NULL,
CANCEL BIT NULL,
CONSTRAINT PK_CG_TIPOVENDA_ITENS PRIMARY KEY (ID_PEDIDO,ID_EQUIPAMENTO),
CONSTRAINT FK_CG_TIPOVENDA_ITENS_ID_PEDIDO FOREIGN KEY (ID_PEDIDO) REFERENCES CG_PEDIDOVENDA (ID_PEDIDO) ON DELETE CASCADE,
CONSTRAINT FK_CG_TIPOVENDA_ITENS_ID_EQUIPAMENTO FOREIGN KEY (ID_EQUIPAMENTO) REFERENCES CG_EQUIPAMENTO (ID_EQUIPAMENTO)
)
GO

ALTER TABLE CG_PEDIDOVENDA
ADD ULTIMA_ALTERACAO AS GETDATE()
GO

ALTER TABLE CG_PEDIDOVENDA
ADD OBS TEXT NULL
GO