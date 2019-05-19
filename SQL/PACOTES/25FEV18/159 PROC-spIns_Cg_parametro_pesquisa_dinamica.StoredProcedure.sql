USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_parametro_pesquisa_dinamica]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spIns_Cg_parametro_pesquisa_dinamica]

	@TABELA As varchar(50),
	@COLUNA As varchar(50),
	@IDCOLUNA As int,
	@ORDERCOL As int,
	@CHAVE As bit,
	@TIPODADO As varchar(50) = NULL,
	@COLUNA_FILTRO As bit,
	@APELIDO_COLUNA As varchar(50) = NULL,
	@MOSTRA_COLUNA As bit,
	@COLUNA_FILTRO_INICIAL As bit

AS

BEGIN

DELETE FROM CG_PARAMETRO_PESQUISA_DINAMICA
WHERE TABELA = @TABELA AND COLUNA = @COLUNA;

INSERT INTO CG_PARAMETRO_PESQUISA_DINAMICA (
	tabela,
	coluna,
	idcoluna,
	ordercol,
	chave,
	tipodado,
	coluna_filtro,
	apelido_coluna,
	mostra_coluna,
	coluna_filtro_inicial)
VALUES (
	@tabela,
	@coluna,
	@idcoluna,
	@ordercol,
	@chave,
	@tipodado,
	@coluna_filtro,
	@apelido_coluna,
	@mostra_coluna,
	@coluna_filtro_inicial)

END

------------------------------------------------------------




GO
