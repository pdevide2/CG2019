USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamentoMovimentoNaoAlocado]    Script Date: 21/11/2017 13:02:49 ******/
DROP PROCEDURE [dbo].[spSelecionaEquipamentoMovimentoNaoAlocado]
GO

/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamentoMovimentoNaoAlocado]    Script Date: 21/11/2017 13:02:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSelecionaEquipamentoMovimentoNaoAlocado]

@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000),
@TIPO_BUSCA INT = 2,
@TEXTO_BUSCA VARCHAR(30) = ''
AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que já foram selecionados na tela
*/
IF ISNULL(@TEXTO_BUSCA,'')=''
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_EQUIPAMENTO,
		 cc.SERIE,
		 cc.MODELO,
		 cc.DESC_EQUIPAMENTO,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.VALOR
    FROM VW_CG_EQUIPAMENTO_DISPONIVEIS_ENTRADA_MATRIZ cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
	   AND cc.ID_EQUIPAMENTO NOT IN (
	   SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
	   )
END
ELSE
BEGIN
    SELECT cast(0 AS bit) AS selecao,
		 cc.ID_EQUIPAMENTO,
		 cc.SERIE,
		 cc.MODELO,
		 cc.DESC_EQUIPAMENTO,
		 cc.ID_LOCAL_ESTOQUE,
		 cc.VALOR
    FROM VW_CG_EQUIPAMENTO_DISPONIVEIS_ENTRADA_MATRIZ cc
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
	   AND cc.ID_EQUIPAMENTO NOT IN (
	   SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
	   )
	   AND cc.SERIE LIKE 
		  CASE @TIPO_BUSCA
		  WHEN 1 THEN RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  WHEN 2 THEN '%'+RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  END
END

GO


