CREATE PROCEDURE spDel_Cg_acesso	@ID_USUARIO As int,	@ID_MODULO As intASBEGINDELETE FROM CG_ACESSO WHERE	ID_USUARIO = @ID_USUARIO AND	ID_MODULO = @ID_MODULOEND------------------------------------------------------------