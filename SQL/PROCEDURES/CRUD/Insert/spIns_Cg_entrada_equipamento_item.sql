CREATE PROCEDURE spIns_Cg_entrada_equipamento_item	@ID_ROMANEIO As int,	@UNIQUE_KEYID As uniqueidentifier,	@ID_EQUIPAMENTO As int,	@SERIE As varchar(30),	@QTD As int,	@VALOR As numeric(12,2) = NULLASBEGININSERT INTO CG_ENTRADA_EQUIPAMENTO_ITEM (	id_romaneio,	unique_keyid,	id_equipamento,	serie,	qtd,	valor)VALUES (	@id_romaneio,	@unique_keyid,	@id_equipamento,	@serie,	@qtd,	@valor)END------------------------------------------------------------