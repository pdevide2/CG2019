USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamentoMovimento]    Script Date: 02/04/2017 17:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelecionaEquipamentoDisponivelDevolucao]

@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que j� foram selecionados na tela
*/
SELECT cast(0 AS bit) AS selecao,
	  cc.ID_EQUIPAMENTO,
       cc.SERIE,
       cc.MODELO,
       cc.DESC_EQUIPAMENTO,
	  cc.ID_LOCAL_ESTOQUE,
       cc.VALOR
FROM VW_CG_EQUIPAMENTOS_DISPONIVEIS_DEVOLUCAO_MATRIZ cc
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_EQUIPAMENTO NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )
