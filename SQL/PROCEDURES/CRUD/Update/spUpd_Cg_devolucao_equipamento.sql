CREATE PROCEDURE spUpd_Cg_devolucao_equipamento	@ID_ROMANEIO As int,	@DATA_MOVTO As datetime,	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULLASBEGINUPDATE CG_DEVOLUCAO_EQUIPAMENTO SET	data_movto = @data_movto,	user_ins = @user_ins,	data_ins = @data_ins,	user_upd = @user_upd,	data_upd = @data_updWHERE	ID_ROMANEIO = @ID_ROMANEIOEND------------------------------------------------------------