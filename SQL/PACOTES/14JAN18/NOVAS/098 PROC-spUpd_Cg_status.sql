if exists(select 1 from sysobjects where TYPE = 'P' AND name = 'spUpd_Cg_status')begin	drop procedure spUpd_Cg_statusendGOCREATE PROCEDURE spUpd_Cg_status	@ID_STATUS As int,	@DESC_STATUS As varchar(20),	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULL,	@ID_EMPRESA As intASBEGINUPDATE CG_STATUS SET	desc_status = @desc_status,	user_ins = @user_ins,	data_ins = @data_ins,	user_upd = @user_upd,	data_upd = @data_upd,	id_empresa = @id_empresaWHERE	ID_STATUS = @ID_STATUSENDGO------------------------------------------------------------