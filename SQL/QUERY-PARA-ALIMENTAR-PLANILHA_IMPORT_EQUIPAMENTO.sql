Select * from CG_CHIP where SIMID not in (select serie from cg_equipamento)

select 1 as ID_TIPO_EQUIPAMENTO,
	 'POS - SIM:' + SIMID AS DESC_EQUIPAMENTO,
	 SIMID AS  SERIE,
	 'MODELO POS'	AS MODELO,
	 20 AS ID_FORNECEDOR,
	 120.00 AS VALOR
from CG_CHIP where SIMID not in (select serie from cg_equipamento)