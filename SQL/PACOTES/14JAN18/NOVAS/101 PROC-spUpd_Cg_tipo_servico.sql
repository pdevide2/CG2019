CREATE PROCEDURE spUpd_Cg_tipo_servico	@ID_TIPO_SERVICO As int,	@DESC_TIPO_SERVICO As varchar(50),	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULL,	@ID_EMPRESA As intASBEGINUPDATE CG_TIPO_SERVICO SET	desc_tipo_servico = @desc_tipo_servico,	user_ins = @user_ins,	data_ins = @data_ins,	user_upd = @user_upd,	data_upd = @data_upd,	id_empresa = @id_empresaWHERE	ID_TIPO_SERVICO = @ID_TIPO_SERVICOEND------------------------------------------------------------