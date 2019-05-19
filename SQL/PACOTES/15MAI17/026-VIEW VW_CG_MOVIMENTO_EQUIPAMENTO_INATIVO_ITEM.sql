USE [dbCG]
GO

/****** Object:  View [dbo].[VW_CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM]    Script Date: 20/05/2017 14:16:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VW_CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM] 
AS
SELECT A.ID_ROMANEIO,
       A.UNIQUE_KEYID,
       A.ID_EQUIPAMENTO,
       B.DESC_EQUIPAMENTO,
       B.SERIE,
       B.MODELO,
       A.QTD,
       A.VALOR,
	  A.TRANSITO
FROM 
	CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM AS A
LEFT JOIN 
	CG_EQUIPAMENTO AS B 
		ON A.ID_EQUIPAMENTO = B.ID_EQUIPAMENTO
GO


