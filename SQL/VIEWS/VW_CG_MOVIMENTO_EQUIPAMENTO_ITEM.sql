ALTER VIEW VW_CG_MOVIMENTO_EQUIPAMENTO_ITEM 
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
	CG_MOVIMENTO_EQUIPAMENTO_ITEM AS A
LEFT JOIN 
	CG_EQUIPAMENTO AS B 
		ON A.ID_EQUIPAMENTO = B.ID_EQUIPAMENTO