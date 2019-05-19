USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spSelecionaChip_POS]    Script Date: 13/07/2017 22:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spSelecionaChip_POS]

@ID_EQUIPAMENTO INT,
@FILTRO_EXCLUIR VARCHAR(2000),
@FILTRO_ADICIONAR VARCHAR(25) = ''

AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que já foram selecionados na tela
*/

SELECT cast(0 AS bit) AS selecao,
	  cc.ID_CHIP,
       cc.SIMID,
       cc.ID_OPERADORA,
       cc.DESC_OPERADORA

FROM dbo.VW_CG_CHIP cc

WHERE cc.ID_CHIP NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )
    AND cc.ID_CHIP NOT IN (SELECT ID_CHIP FROM CG_EQUIPAMENTO_VS_CHIP) 
    AND cc.SIMID like @FILTRO_ADICIONAR+'%'
    

