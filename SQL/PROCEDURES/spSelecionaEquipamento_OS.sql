USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamentoMovimento]    Script Date: 10/12/2016 11:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spSelecionaEquipamento_OS]

@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000)
AS
/*
Chamada:
exec spSelecionaEquipamentoMovimento 1, '101,102'
retorna todos os Equipamentos em estoque no local de origem, excluindo os que já foram selecionados na tela
*/

SELECT cast(0 AS bit) AS selecao,
	  cc.ID_EQUIPAMENTO,
       cc.SERIE,
       cc.MODELO,
       cc.DESC_EQUIPAMENTO,
	  cc.ID_LOCAL_ESTOQUE,
       cc.VALOR,
	  cc.ID_TIPO_EQUIPAMENTO, 
	  te.DESC_TIPO_EQUIPAMENTO
FROM dbo.CG_EQUIPAMENTO cc

LEFT JOIN CG_TIPO_EQUIPAMENTO te 
    ON te.ID_TIPO_EQUIPAMENTO = cc.ID_TIPO_EQUIPAMENTO

WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_EQUIPAMENTO NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )
    AND cc.ID_EQUIPAMENTO NOT IN (SELECT ID_EQUIPAMENTO FROM CG_OS_ITEM)
    

