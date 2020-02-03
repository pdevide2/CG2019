USE [dbCG]
GO

/****** Object:  View [dbo].[VW_CG_ORIGEM_ESTOQUE_POS]    Script Date: 02/02/2020 10:56:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VW_CG_ORIGEM_ESTOQUE_CHIP]
AS
SELECT
	CT.DESC_TIPO_LOCAL_ESTOQUE AS ORIGEM,
    A.ID_CHIP, 
    B.SIMID, 
    B.ID_OPERADORA, 
    C.DESC_OPERADORA, 
	A.ID_EMPRESA,
	L.ID_TIPO_LOCAL_ESTOQUE
    
FROM
    dbo.CG_ESTOQUE_CHIP AS A 
	   INNER JOIN
		  dbo.CG_CHIP AS B 
			 ON A.ID_CHIP = B.ID_CHIP
		INNER JOIN
		  dbo.CG_OPERADORA AS C 
			 ON C.ID_OPERADORA = B.ID_OPERADORA
		LEFT JOIN CG_LOJA L
				ON L.ID_LOJA = A.ID_LOCAL 
		LEFT JOIN 
			CG_TIPO_LOCAL_ESTOQUE CT ON CT.ID_TIPO_LOCAL_ESTOQUE = L.ID_TIPO_LOCAL_ESTOQUE
WHERE A.TRANSITO = 0 AND L.ID_TIPO_LOCAL_ESTOQUE NOT IN (0, 2, 7, 9, 10)




GO

SELECT ORIGEM, ID_CHIP, SIMID, ID_OPERADORA, DESC_OPERADORA, ID_EMPRESA, ID_TIPO_LOCAL, ID_TIPO_LOCAL_ESTOQUE FROM [VW_CG_ORIGEM_ESTOQUE_CHIP]

SELECT * FROM CG_ESTOQUE_CHIP
