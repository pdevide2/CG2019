USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_tabelas_pesquisa_dinamica]    Script Date: 15/12/2017 14:15:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spIns_Cg_tabelas_pesquisa_dinamica]

	@ID_TABELA As int,
	@TABELA As varchar(50),
	@TIPO_TABELA As char(1),
	@FILTRA_POR_EMPRESA as bit = 0

AS

BEGIN
INSERT INTO CG_TABELAS_PESQUISA_DINAMICA (
	id_tabela,
	tabela,
	tipo_tabela,
	FILTRA_POR_EMPRESA)
VALUES (
	@id_tabela,
	@tabela,
	@tipo_tabela,
	@FILTRA_POR_EMPRESA)

END

------------------------------------------------------------



