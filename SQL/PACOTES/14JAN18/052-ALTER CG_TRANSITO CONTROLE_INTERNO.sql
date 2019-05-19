ALTER TABLE CG_TRANSITO 
ADD CONTROLE_INTERNO BIT NOT NULL CONSTRAINT DF_CG_TRANSITO_CONTROLE_INTERNO DEFAULT (0)
GO

UPDATE CG_TRANSITO
SET CONTROLE_INTERNO=1
WHERE ID_TRANSITO=1

DECLARE @NEWKEY INT, @ID_EMPRESA INT
DECLARE @TABCHAVE TABLE (NEWKEY INT NOT NULL)

INSERT @TABCHAVE 
EXEC spNovaChave 'CG_TRANSITO'

SELECT @NEWKEY= NEWKEY 
FROM @TABCHAVE

SET @ID_EMPRESA = 2
INSERT INTO CG_TRANSITO VALUES (@NEWKEY, 'TRANSITO INTERNO MATRIZ ('+CONVERT(VARCHAR, @ID_EMPRESA) + ')', 0, @ID_EMPRESA, 1)

INSERT @TABCHAVE 
EXEC spNovaChave 'CG_TRANSITO'

SELECT @NEWKEY= NEWKEY 
FROM @TABCHAVE

SET @ID_EMPRESA = 3
INSERT INTO CG_TRANSITO VALUES (@NEWKEY, 'TRANSITO INTERNO MATRIZ ('+CONVERT(VARCHAR, @ID_EMPRESA) + ')', 0, @ID_EMPRESA, 1)
