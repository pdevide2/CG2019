CREATE TABLE CG_MODELOS (
ID_MODELO INT NOT NULL,
DESC_MODELO VARCHAR(100) NOT NULL,
OBS TEXT NULL,
CAMINHO_ARQUIVO VARCHAR(150) NULL,
EXTENSAO_ARQUIVO VARCHAR(5) NULL )
GO

ALTER TABLE CG_MODELOS
ADD PRIMARY KEY (ID_MODELO)
GO
