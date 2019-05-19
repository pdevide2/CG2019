USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spSelecionaEstoqueChipLoja]    Script Date: 21/11/2017 16:22:22 ******/
DROP PROCEDURE [dbo].[spSelecionaEstoqueChipLoja]
GO

/****** Object:  StoredProcedure [dbo].[spSelecionaEstoqueChipLoja]    Script Date: 21/11/2017 16:22:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSelecionaEstoqueChipLoja]
@ID_LOCAL_ESTOQUE INT,
@TIPO_BUSCA INT = 2,
@TEXTO_BUSCA VARCHAR(30) = ''
AS
IF ISNULL(@TEXTO_BUSCA,'')=''
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_CHIP,
		 cc.SIMID,
		 cc.ID_OPERADORA,
		 co.DESC_OPERADORA,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.CUSTO
    FROM dbo.CG_CHIP cc
	    LEFT JOIN dbo.CG_OPERADORA co ON CO.ID_OPERADORA = cc.ID_OPERADORA
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
END
ELSE
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_CHIP,
		 cc.SIMID,
		 cc.ID_OPERADORA,
		 co.DESC_OPERADORA,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.CUSTO
    FROM dbo.CG_CHIP cc
	    LEFT JOIN dbo.CG_OPERADORA co ON CO.ID_OPERADORA = cc.ID_OPERADORA
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
	   AND cc.SIMID LIKE
		  CASE @TIPO_BUSCA
			 WHEN 1 THEN RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
			 WHEN 2 THEN '%'+RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  END

END
GO
