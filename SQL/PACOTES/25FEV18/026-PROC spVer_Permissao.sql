USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spVer_Permissao]    Script Date: 18/12/2017 09:39:36 ******/
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spVer_Permissao' AND TYPE='P')
BEGIN
	DROP PROCEDURE [dbo].[spVer_Permissao]
END
GO

/****** Object:  StoredProcedure [dbo].[spVer_Permissao]    Script Date: 18/12/2017 09:39:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spVer_Permissao] 
	@ID_MODULO int,
	@ID_PERFIL int
AS
BEGIN

DECLARE @ACESSO TABLE (ID_PERFIL INT NULL, ID_MODULO INT NULL, PESQUISAR BIT, 
						INCLUIR BIT, ALTERAR BIT, EXCLUIR BIT, PERMISSAO VARCHAR(10) NULL)

INSERT INTO @ACESSO 
	select 
		ID_PERFIL,
		ID_MODULO,
		PESQUISAR,
		INCLUIR,
		ALTERAR,
		EXCLUIR,
		CASE WHEN PESQUISAR = 1 THEN 'P' ELSE '' END + ';' +
		CASE WHEN PESQUISAR = 1 THEN 'I' ELSE '' END + ';' +
		CASE WHEN PESQUISAR = 1 THEN 'A' ELSE '' END + ';' +
		CASE WHEN PESQUISAR = 1 THEN 'E' ELSE '' END AS PERMISSAO
		FROM CG_PERFIL_MODULO
		WHERE ID_PERFIL = @ID_PERFIL AND ID_MODULO = @ID_MODULO

SELECT * FROM @ACESSO
END
