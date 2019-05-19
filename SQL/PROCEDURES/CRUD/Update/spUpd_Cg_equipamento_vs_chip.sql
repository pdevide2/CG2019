CREATE PROCEDURE spUpd_Cg_equipamento_vs_chip

	@ID_EQUIPAMENTO As int,
	@ID_CHIP As int,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_EQUIPAMENTO_VS_CHIP SET
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO AND
	ID_CHIP = @ID_CHIP

END