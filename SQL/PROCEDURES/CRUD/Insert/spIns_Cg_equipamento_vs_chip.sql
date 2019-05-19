CREATE PROCEDURE spIns_Cg_equipamento_vs_chip

	@ID_EQUIPAMENTO As int,
	@ID_CHIP As int,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_EQUIPAMENTO_VS_CHIP (
	id_equipamento,
	id_chip,
	user_upd,
	data_upd)
VALUES (
	@id_equipamento,
	@id_chip,
	@user_upd,
	@data_upd)

END