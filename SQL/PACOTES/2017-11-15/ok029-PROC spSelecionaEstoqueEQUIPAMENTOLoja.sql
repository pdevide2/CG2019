USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spSelecionaEstoqueEQUIPAMENTOLoja]    Script Date: 21/11/2017 16:28:33 ******/
DROP PROCEDURE [dbo].[spSelecionaEstoqueEQUIPAMENTOLoja]
GO

/****** Object:  StoredProcedure [dbo].[spSelecionaEstoqueEQUIPAMENTOLoja]    Script Date: 21/11/2017 16:28:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSelecionaEstoqueEQUIPAMENTOLoja]
@ID_LOCAL_ESTOQUE INT,
@TIPO_BUSCA INT = 2,
@TEXTO_BUSCA VARCHAR(30) = ''
AS
IF ISNULL(@TEXTO_BUSCA,'')=''
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_EQUIPAMENTO,
		 cc.SERIE,
		 cc.DESC_EQUIPAMENTO,
		 cc.MODELO,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.VALOR
    FROM dbo.CG_EQUIPAMENTO cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
END
ELSE
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_EQUIPAMENTO,
		 cc.SERIE,
		 cc.DESC_EQUIPAMENTO,
		 cc.MODELO,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.VALOR
    FROM dbo.CG_EQUIPAMENTO cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
	   AND cc.SERIE LIKE
		  CASE @TIPO_BUSCA
			 WHEN 1 THEN RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
			 WHEN 2 THEN '%'+RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  END
END

GO


