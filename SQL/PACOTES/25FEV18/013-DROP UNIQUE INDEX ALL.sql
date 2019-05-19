
IF EXISTS(SELECT 1 FROM [dbCG].[INFORMATION_SCHEMA].[TABLE_CONSTRAINTS] WHERE CONSTRAINT_NAME = 'UQ__CG_LOJA__CC87E1268799F784')
BEGIN
	ALTER TABLE CG_LOJA DROP CONSTRAINT UQ__CG_LOJA__CC87E1268799F784
END
GO

IF EXISTS(SELECT 1 FROM [dbCG].[INFORMATION_SCHEMA].[TABLE_CONSTRAINTS] WHERE CONSTRAINT_NAME = 'UNQ_CG_TABELAS_PESQUISA_DINAMICA')
BEGIN
	ALTER TABLE CG_TABELAS_PESQUISA_DINAMICA DROP CONSTRAINT UNQ_CG_TABELAS_PESQUISA_DINAMICA
END
GO

IF EXISTS(SELECT 1 FROM [dbCG].[INFORMATION_SCHEMA].[TABLE_CONSTRAINTS] WHERE CONSTRAINT_NAME = 'UNQ_CG_CHIP_SIMID')
BEGIN
	ALTER TABLE CG_CHIP DROP CONSTRAINT UNQ_CG_CHIP_SIMID
END
GO

IF EXISTS(SELECT 1 FROM [dbCG].[INFORMATION_SCHEMA].[TABLE_CONSTRAINTS] WHERE CONSTRAINT_NAME = 'UNQ_DESC_AREA')
BEGIN
	ALTER TABLE CG_AREA DROP CONSTRAINT UNQ_DESC_AREA
END
GO

IF EXISTS(SELECT 1 FROM [dbCG].[INFORMATION_SCHEMA].[TABLE_CONSTRAINTS] WHERE CONSTRAINT_NAME = 'UNIQUE_CG_MARCA_1')
BEGIN
	ALTER TABLE CG_MARCA DROP CONSTRAINT UNIQUE_CG_MARCA_1
END
GO

IF EXISTS(SELECT 1 FROM [dbCG].[INFORMATION_SCHEMA].[TABLE_CONSTRAINTS] WHERE CONSTRAINT_NAME = 'UNIQUE_CG_FINALIDADE_1')
BEGIN
	ALTER TABLE CG_FINALIDADE DROP CONSTRAINT UNIQUE_CG_FINALIDADE_1
END
GO

IF EXISTS(SELECT 1 FROM [dbCG].[INFORMATION_SCHEMA].[TABLE_CONSTRAINTS] WHERE CONSTRAINT_NAME = 'UNIQUE_CG_CATEGORIA_1')
BEGIN
	ALTER TABLE CG_CATEGORIA DROP CONSTRAINT UNIQUE_CG_CATEGORIA_1
END
GO

IF EXISTS(SELECT 1 FROM [dbCG].[INFORMATION_SCHEMA].[TABLE_CONSTRAINTS] WHERE CONSTRAINT_NAME = 'UNIQUE_CG_PECA_1')
BEGIN
	ALTER TABLE CG_PECA DROP CONSTRAINT UNIQUE_CG_PECA_1
END
GO