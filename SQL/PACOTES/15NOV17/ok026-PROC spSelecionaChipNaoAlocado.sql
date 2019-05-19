USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spSelecionaChipNaoAlocado]    Script Date: 20/11/2017 09:46:41 ******/
DROP PROCEDURE [dbo].[spSelecionaChipNaoAlocado]
GO

/****** Object:  StoredProcedure [dbo].[spSelecionaChipNaoAlocado]    Script Date: 20/11/2017 09:46:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSelecionaChipNaoAlocado]
@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000),
@TIPO_BUSCA INT = 2,
@TEXTO_BUSCA VARCHAR(30) = ''
AS
/*
Chamada:
exec spSelecionaChipMovimento 1, '101,102'
retorna todos os chips em estoque no local de origem, excluindo os que já foram selecionados na tela
*/

IF ISNULL(@TEXTO_BUSCA,'')=''
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_CHIP,
		 cc.SIMID,
		 cc.ID_OPERADORA,
		 cc.DESC_OPERADORA,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.CUSTO
    FROM VW_CG_CHIP_DISPONIVEIS_ENTRADA_MATRIZ cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
	   AND cc.ID_CHIP NOT IN (
	   SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
	   )
END
ELSE
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_CHIP,
		 cc.SIMID,
		 cc.ID_OPERADORA,
		 cc.DESC_OPERADORA,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.CUSTO
    FROM VW_CG_CHIP_DISPONIVEIS_ENTRADA_MATRIZ cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
	   AND cc.ID_CHIP NOT IN (SELECT cast(splitdata as int) as splitdata 
						  FROM dbo.fnSplitString(@FILTRO_EXCLUIR,','))
	   AND cc.SIMID LIKE 
		  CASE @TIPO_BUSCA
		  WHEN 1 THEN RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  WHEN 2 THEN '%'+RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  END

END

GO


