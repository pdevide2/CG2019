USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEquipamento_OS]    Script Date: 04/08/2018 19:13:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spSelecionaEquipamento_OS]

@ID_LOCAL_ESTOQUE INT,
@FILTRO_EXCLUIR VARCHAR(2000),
@PESQUISADO_FILTRAR VARCHAR(50)='',
@TIPO_LIKE INT = 1
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
	  te.DESC_TIPO_EQUIPAMENTO,
	  case 
		  when (ISNULL(cc.DATA_TERMINO_GARANTIA,'19000101')>=getdate()) 
				OR (DATEADD("dd",isnull(cc.PRAZO_GARANTIA,0),ISNULL(cc.DATA_NF,'19000101'))>=getdate())
				then cast(1 as bit)
		  else cast(0 as bit) 
       end as GARANTIA
FROM dbo.CG_EQUIPAMENTO cc

LEFT JOIN CG_TIPO_EQUIPAMENTO te 
    ON te.ID_TIPO_EQUIPAMENTO = cc.ID_TIPO_EQUIPAMENTO

WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE
    AND cc.ID_EQUIPAMENTO NOT IN (
    SELECT cast(splitdata as int) as splitdata FROM dbo.fnSplitString(@FILTRO_EXCLUIR,',')
    )
    AND cc.ID_LOCAL_ESTOQUE <> 2 /*em assistencia tecnica*/
    AND cc.SERIE LIKE 
		CASE	
		WHEN @PESQUISADO_FILTRAR = '' THEN cc.SERIE
		ELSE CASE 
				WHEN @TIPO_LIKE = 1 THEN  RTRIM(LTRIM(@PESQUISADO_FILTRAR)) + '%'
			      ELSE '%' + RTRIM(LTRIM(@PESQUISADO_FILTRAR)) + '%'
			 END
		END
				  	
