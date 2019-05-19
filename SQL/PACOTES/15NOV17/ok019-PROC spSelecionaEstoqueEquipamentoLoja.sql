USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spSelecionaEQUIPAMENTOMovimento]    Script Date: 03/11/2017 20:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelecionaEstoqueEQUIPAMENTOLoja]
@ID_LOCAL_ESTOQUE INT
AS
SELECT cast(0 AS bit) AS selecao,
	  cc.ID_EQUIPAMENTO,
       cc.SERIE,
       cc.DESC_EQUIPAMENTO,
       cc.MODELO,
	  cc.ID_LOCAL_ESTOQUE,
       cc.VALOR
FROM dbo.CG_EQUIPAMENTO cc
WHERE cc.ID_LOCAL_ESTOQUE = @ID_LOCAL_ESTOQUE and cc.TIPO_LOCAL = 'L'
GO