USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEstoqueEQUIPAMENTOLoja]    Script Date: 25/08/2019 12:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[spSelecionaEstoqueEquipPedidoVenda]
@ID_LOCAL_ESTOQUE INT=1,
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
	INNER JOIN CG_PEDIDOVENDA_ITENS pv ON pv.ID_EQUIPAMENTO = cc.ID_EQUIPAMENTO
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
			and pv.STATUS_ITEM=2 
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
	INNER JOIN CG_PEDIDOVENDA_ITENS pv ON pv.ID_EQUIPAMENTO = cc.ID_EQUIPAMENTO
    WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
		and pv.STATUS_ITEM=2 
	   AND cc.SERIE LIKE
		  CASE @TIPO_BUSCA
			 WHEN 1 THEN RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
			 WHEN 2 THEN '%'+RTRIM(LTRIM(@TEXTO_BUSCA))+'%'
		  END
END

