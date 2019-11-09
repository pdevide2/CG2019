CREATE VIEW VW_CG_ENTRADA_ESTOQUE_NAO_CONFERIDO
AS
SELECT	id_romaneio,
		data_movto,
		id_loja,
		user_ins,
		data_ins,
		user_upd,
		data_upd,
		romaneio_estoque,
		id_empresa
FROM CG_ENTRADA_ESTOQUE
WHERE 
	ID_ROMANEIO IN (select ID_ROMANEIO 
					from CG_LOG_ENTRADA_CHIP_ITEM 
					WHERE MOVIMENTO_CONFERIDO = 0)
	OR
	ID_ROMANEIO IN (select ID_ROMANEIO 
					from CG_LOG_ENTRADA_EQUIPAMENTO_ITEM 
					WHERE MOVIMENTO_CONFERIDO = 0)
