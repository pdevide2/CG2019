CREATE TABLE CG_FINALIDADE (
ID_FINALIDADE INT NOT NULL,
DESC_FINALIDADE VARCHAR(50) NOT NULL,
USER_INS INT NULL,
DATA_INS DATETIME NULL,
USER_UPD INT NULL,
DATA_UPD DATETIME )
GO

ALTER TABLE CG_FINALIDADE
ADD CONSTRAINT PK_CG_FINALIDADE PRIMARY KEY (ID_FINALIDADE)
GO

ALTER TABLE CG_FINALIDADE
ADD CONSTRAINT UNIQUE_CG_FINALIDADE_1 UNIQUE (DESC_FINALIDADE)
GO




