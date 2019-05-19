USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spSelecionaChipMovimento]    Script Date: 20/05/2017 12:26:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[spSelecionaChipMovimentoInativo]
@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaChipMovimentoInativo 1, '101,102'
retorna todos os chips em estoque no local de origem, excluindo os que já foram selecionados na tela
*/
SELECT cast(0 AS bit) AS selecao,
	  cc.ID_CHIP,
       cc.SIMID,
       cc.ID_OPERADORA,
       co.DESC_OPERADORA,
	  cc.ID_LOCAL_ESTOQUE,
       cc.CUSTO
FROM dbo.CG_CHIP cc
     LEFT JOIN dbo.CG_OPERADORA co ON CO.ID_OPERADORA = cc.ID_OPERADORA
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_CHIP NOT IN (SELECT ID_CHIP FROM CG_MOVIMENTO_CHIP_INATIVO_ITEM)
    AND cc.ID_CHIP NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )
