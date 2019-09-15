/*
select object_name(parent_obj) tabela , * from sysobjects where type='TR'

select 'alter table ' + object_name(parent_obj) +' ENABLE trigger '+name+char(13)+char(10)+'GO' from sysobjects where type='TR'
*/

SELECT ID_LOJA, NOME, ID_EMPRESA, ID_EMPRESA_OLD FROM CG_LOJA
WHERE ID_EMPRESA IN (1,4)
GO


ALTER TABLE CG_LOJA_HISTORICO ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_CG_LOJA_HISTORICO_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
GO

ALTER TABLE CG_AREA ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_AREA_HISTORICO_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
GO

SELECT ID_LOJA, NOME, ID_EMPRESA, ID_EMPRESA_OLD FROM CG_LOJA_HISTORICO
WHERE ID_EMPRESA IN (1,4)
GO

UPDATE CG_AREA
SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO


UPDATE CG_LOJA_HISTORICO
SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO


-- 1�) Desabilita TODAS as foreign key de uma tabela SQL Server
ALTER TABLE [CG_LOJA_HISTORICO] NOCHECK CONSTRAINT ALL
GO

ALTER TABLE [CG_LOJA] NOCHECK CONSTRAINT ALL
GO

UPDATE CG_AREA
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO
-- 2�) Habilita TODAS as foreign key de uma tabela SQL Server novamente
ALTER TABLE [CG_LOJA_HISTORICO] CHECK CONSTRAINT ALL
GO
ALTER TABLE [CG_LOJA] CHECK CONSTRAINT ALL
GO
UPDATE CG_LOJA_HISTORICO
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

UPDATE CG_LOJA
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

ALTER TABLE CG_ESTOQUE_CHIP
ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_CG_ESTOQUE_CHIP_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
GO

UPDATE CG_ESTOQUE_CHIP SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_ESTOQUE_CHIP
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

UPDATE CG_CHIP SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
WHERE ID_EMPRESA IN (1,4)
GO

--SELECT * FROM CG_CHIP
--WHERE ID_EMPRESA IN (1,4)

UPDATE CG_CHIP
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

---------------JJ

ALTER TABLE CG_ESTOQUE_EQUIPAMENTO
ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_CG_ESTOQUE_EQUIPTO_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
GO

UPDATE CG_ESTOQUE_EQUIPAMENTO SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_ESTOQUE_EQUIPAMENTO
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

UPDATE CG_EQUIPAMENTO SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
WHERE ID_EMPRESA IN (1,4)
GO

--SELECT * FROM CG_CHIP
--WHERE ID_EMPRESA IN (1,4)

UPDATE CG_EQUIPAMENTO
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

--------------------------------ZZ

ALTER TABLE CG_MOV_TRANSITO_CHIP
ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_CG_MOV_TRANSITO_CHIP_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
GO

UPDATE CG_MOV_TRANSITO_CHIP SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_MOV_TRANSITO_CHIP
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

--------------------------------WW
ALTER TABLE CG_MOV_TRANSITO_EQUIPAMENTO
ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_CG_MOV_TRANSITO_EQUIPAMENTO_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
GO

UPDATE CG_MOV_TRANSITO_EQUIPAMENTO SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_MOV_TRANSITO_EQUIPAMENTO
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

--------------------------------QQ
--ALTER TABLE CG_ENTRADA_CHIP_ITEM
--ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_CG_ENTRADA_CHIP_ITEM_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
--GO

UPDATE CG_ENTRADA_CHIP_ITEM SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_ENTRADA_CHIP_ITEM
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO
--------------------------------KK
UPDATE CG_ENTRADA_EQUIPAMENTO_ITEM SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_ENTRADA_EQUIPAMENTO_ITEM
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO
--------------------------------XX
ALTER TABLE CG_ENTRADA_ESTOQUE
ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_CG_ENTRADA_ESTOQUE_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
GO

UPDATE CG_ENTRADA_ESTOQUE SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_ENTRADA_ESTOQUE
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

-----------FORNECEDORES
UPDATE CG_FORNECEDOR SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_FORNECEDOR
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

------------------OS
ALTER TABLE [CG_OS] NOCHECK CONSTRAINT ALL
GO
UPDATE CG_OS SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_OS
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO
ALTER TABLE [CG_OS] CHECK CONSTRAINT ALL
GO



----------------OS ITEM
ALTER TABLE [CG_OS_ITEM] NOCHECK CONSTRAINT ALL
GO
UPDATE CG_OS_ITEM SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_OS_ITEM
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO
ALTER TABLE [CG_OS_ITEM] CHECK CONSTRAINT ALL
GO

--------------CG_RESPONSAVEL
ALTER TABLE CG_RESPONSAVEL
ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_CG_RESPONSAVEL_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
GO

UPDATE CG_RESPONSAVEL SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE CG_RESPONSAVEL
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

-----------ROMANEIO_ESTOQUE
ALTER TABLE ROMANEIO_ESTOQUE
ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_ROMANEIO_ESTOQUE_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
GO

UPDATE ROMANEIO_ESTOQUE SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE ROMANEIO_ESTOQUE
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO

-----------ROMANEIO_ESTOQUE_ITEM
ALTER TABLE ROMANEIO_ESTOQUE_ITEM
ADD ID_EMPRESA_OLD INT NULL, DT_ALT_EMPRESA_OLD DATETIME NULL CONSTRAINT DF_ROMANEIO_ESTOQUE_ITEM_DT_ALT_EMPRESA_OLD DEFAULT (GETDATE()) ;
GO

UPDATE ROMANEIO_ESTOQUE_ITEM SET ID_EMPRESA_OLD = ID_EMPRESA, DT_ALT_EMPRESA_OLD = CONVERT(VARCHAR, GETDATE(),112)
GO

UPDATE ROMANEIO_ESTOQUE_ITEM
SET ID_EMPRESA = CASE
					WHEN ID_EMPRESA_OLD = 1 THEN 4
					WHEN ID_EMPRESA_OLD = 4 THEN 1
					ELSE ID_EMPRESA
				END
GO