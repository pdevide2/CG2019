SELECT * FROM CG_ENTRADA_ESTOQUE ORDER BY ID_ROMANEIO DESC

SELECT a.id_romaneio,a.data_movto, a.id_loja, a.romaneio_estoque, a.id_empresa 
FROM VW_CG_ENTRADA_ESTOQUE_NAO_CONFERIDO a

select	a.ID_ROMANEIO, 
		a.UNIQUE_KEYID, 
		a.ID_EQUIPAMENTO, 
		a.SERIE, 
		b.DESC_EQUIPAMENTO,
		b.MODELO,
		a.QTD, 
		a.VALOR, 
		a.ID_EMPRESA, 
		a.MOVIMENTO_CONFERIDO, 
		a.REPROVADO 
from Cg_Log_entrada_equipamento_item a
inner join CG_EQUIPAMENTO b 
	on b.ID_EQUIPAMENTO = a.ID_EQUIPAMENTO
WHERE a.MOVIMENTO_CONFERIDO=0
and a.ID_ROMANEIO in (2653, 2654)

select	a.ID_ROMANEIO, 
		a.UNIQUE_KEYID, 
		a.ID_CHIP, 
		a.SIMID, 
		b.ID_OPERADORA,
		c.DESC_OPERADORA,
		a.QTD, 
		a.VALOR, 
		a.ID_EMPRESA, 
		a.MOVIMENTO_CONFERIDO, 
		a.REPROVADO  
from Cg_Log_entrada_chip_item a
inner join CG_CHIP b 
	on b.ID_CHIP = a.ID_CHIP
inner join CG_OPERADORA c
	on c.ID_OPERADORA = b.ID_OPERADORA
WHERE a.MOVIMENTO_CONFERIDO=0
and a.ID_ROMANEIO in (2653, 2654)

select * from Cg_entrada_equipamento_item order by id_romaneio desc

select * from Cg_entrada_chip_item

select * from CG_ESTOQUE_EQUIPAMENTO where ID_EMPRESA=9

select * from CG_ESTOQUE_CHIP where ID_EMPRESA=9

UPDATE Cg_Log_entrada_equipamento_item SET MOVIMENTO_CONFERIDO=1
WHERE ID_ROMANEIO=2652 AND UNIQUE_KEYID='0752393D-6AFC-4775-BC27-7F9CD489C61A'

UPDATE Cg_Log_entrada_chip_item SET MOVIMENTO_CONFERIDO=1
WHERE ID_ROMANEIO=2652 AND UNIQUE_KEYID='DE328AC9-0454-40E0-9D3A-50C6275F3D5F'


