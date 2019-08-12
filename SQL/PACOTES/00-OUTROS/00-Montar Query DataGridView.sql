--Dim colId_Romaneio As DataGridViewTextBoxColumn


SELECT 'Dim col'+upper(left(name,1))+substring(lower(name),2,30)+' As DataGridViewTextBoxColumn'   FROM SYSCOLUMNS WHERE ID = OBJECT_ID('VW_CG_PEDIDOVENDA_ITENS') ORDER BY COLID

SELECT colid, 1 as ordem, texto = 'col'+upper(left(name,1))+substring(lower(name),2,30)+' = New DataGridViewTextBoxColumn'   FROM SYSCOLUMNS WHERE ID = OBJECT_ID('VW_CG_PEDIDOVENDA_ITENS') 
union all
SELECT colid, 2 as ordem,texto = 'col'+Rtrim(upper(left(name,1))+substring(lower(name),2,30))+'.HeaderText = '+'"'+name+'"'   FROM SYSCOLUMNS WHERE ID = OBJECT_ID('VW_CG_PEDIDOVENDA_ITENS') 
union all
SELECT colid, 3 as ordem,texto = 'col'+Rtrim(upper(left(name,1))+substring(lower(name),2,30))+'.Name = '+'"'+name+'"'   FROM SYSCOLUMNS WHERE ID = OBJECT_ID('VW_CG_PEDIDOVENDA_ITENS') 
order by colid, ordem

SELECT 'col'+upper(left(name,1))+substring(lower(name),2,30)+','   FROM SYSCOLUMNS WHERE ID = OBJECT_ID('VW_CG_PEDIDOVENDA_ITENS') ORDER BY COLID
