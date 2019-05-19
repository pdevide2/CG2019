USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamentoMovimento]    Script Date: 20/05/2017 14:55:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spSelecionaEquipamentoMovimento]

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
FROM dbo.CG_EQUIPAMENTO cc
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_EQUIPAMENTO NOT IN (SELECT ID_EQUIPAMENTO FROM CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM)
    AND cc.ID_EQUIPAMENTO NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )

GO


