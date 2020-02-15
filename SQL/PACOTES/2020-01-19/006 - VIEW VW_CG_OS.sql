USE [dbCG]
GO

/****** Object:  View [dbo].[VW_CG_OS]    Script Date: 15/02/2020 09:16:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[VW_CG_OS]
AS
SELECT A.ID_OS,
       A.DATA_MOVTO,
       A.ID_LOJA_ORIGEM,
       E.SIGLA AS SIGLA_LOJA,
       E.NOME AS NOME_LOJA,
       A.NF_TRANSP,
       A.SERIE_NF_TRANSP,
       A.EMISSAO_NF_TRANSP,
       A.ID_FORNECEDOR,
       B.SIGLA AS SIGLA_FORNECEDOR,
       B.UTILIZA_NFTS,
       B.NOME AS NOME_FORNECEDOR,
       A.ID_RESPONSAVEL_IDA,
       C.NOME AS RESPONSAVEL,
       C.APELIDO AS APELIDO_RESPONSAVEL,
       A.STATUS_OS,
       D.DESC_STATUS,
       A.XML_NF_TRANSP,
       A.XML_NF_TS,
	   CAST(ISNULL(A.INDICA_OS_CLIENTE,0) AS BIT) AS INDICA_OS_CLIENTE,
	   A.ID_CLIENTE,
	   F.NOME AS NOME_CLIENTE
FROM 
	CG_OS AS A (NOLOCK)
LEFT JOIN 
	CG_FORNECEDOR AS B (NOLOCK)
		ON A.ID_FORNECEDOR = B.ID_FORNECEDOR
LEFT JOIN 
	CG_RESPONSAVEL AS C (NOLOCK)
		ON A.ID_RESPONSAVEL_IDA = C.ID_RESPONSAVEL
LEFT JOIN 
	CG_STATUS_OS AS D (NOLOCK)
		ON A.STATUS_OS = D.ID_STATUS
LEFT JOIN 
	CG_LOJA AS E (NOLOCK)
		ON A.ID_LOJA_ORIGEM = E.ID_LOJA
LEFT JOIN CG_CLIENTE F (NOLOCK) 
	ON F.ID_CLIENTE = A.ID_CLIENTE
GO


