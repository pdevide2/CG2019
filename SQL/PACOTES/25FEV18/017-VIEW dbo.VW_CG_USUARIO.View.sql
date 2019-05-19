USE [dbCG]
GO
/****** Object:  View [dbo].[VW_CG_USUARIO]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[VW_CG_USUARIO]
AS
SELECT A.ID_USUARIO,
       A.APELIDO,
       A.NOME,
       A.CPF,
       A.RG,
       A.EMAIL,
       A.TELEFONE,
       A.WHATSAPP,
       A.CEP,
       A.ENDERECO,
       A.COMPLEMENTO,
       A.CIDADE,
       A.BAIRRO,
       A.UF,
       A.LOGIN,
       A.ID_STATUS,
       B.DESC_STATUS,
	   A.ID_EMPRESA
FROM 
	CG_USUARIO AS A
LEFT JOIN 
	CG_STATUS AS B ON A.ID_STATUS = B.ID_STATUS






GO
