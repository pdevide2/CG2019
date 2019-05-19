USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spSelecionaChipMovimento]    Script Date: 02/04/2017 17:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelecionaChipDisponivelDevolucao]
@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaChipMovimento 1, '101,102'
retorna todos os chips em estoque no local de origem, excluindo os que já foram selecionados na tela
*/

SELECT cast(0 AS bit) AS selecao,
	  cc.ID_CHIP,
       cc.SIMID,
       cc.ID_OPERADORA,
       cc.DESC_OPERADORA,
	  cc.ID_LOCAL_ESTOQUE,
       cc.CUSTO
FROM VW_CG_CHIP_DISPONIVEIS_DEVOLUCAO_MATRIZ cc
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_CHIP NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )
