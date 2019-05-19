USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spSelecionaChipMovimento]    Script Date: 03/11/2017 20:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelecionaEstoqueChipLoja]
@ID_LOCAL_ESTOQUE INT
AS
SELECT cast(0 AS bit) AS selecao,
	  cc.ID_CHIP,
       cc.SIMID,
       cc.ID_OPERADORA,
       co.DESC_OPERADORA,
	  cc.ID_LOCAL_ESTOQUE,
       cc.CUSTO
FROM dbo.CG_CHIP cc
     LEFT JOIN dbo.CG_OPERADORA co ON CO.ID_OPERADORA = cc.ID_OPERADORA
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
GO