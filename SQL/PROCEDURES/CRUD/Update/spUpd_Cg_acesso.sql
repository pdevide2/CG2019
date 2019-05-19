CREATE PROCEDURE spUpd_Cg_acesso	@ID_USUARIO As int,	@ID_MODULO As int,	@PERMISSAO As char(1) = NULL,	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULLASBEGINif EXISTS( SELECT 1 FROM CG_ACESSO WHERE ID_USUARIO = @ID_USUARIO AND ID_MODULO = @ID_MODULO)BEGIN	UPDATE CG_ACESSO SET		permissao = @permissao,		user_ins = @user_ins,		data_ins = @data_ins,		user_upd = @user_upd,		data_upd = @data_upd	WHERE		ID_USUARIO = @ID_USUARIO AND		ID_MODULO = @ID_MODULOENDELSEBEGIN	INSERT INTO CG_ACESSO (
		id_usuario,
		id_modulo,
		permissao,
		user_ins,
		data_ins,
		user_upd,
		data_upd)
	VALUES (
		@id_usuario,
		@id_modulo,
		@permissao,
		@user_ins,
		@data_ins,
		@user_upd,
		@data_upd)ENDEND------------------------------------------------------------