CREATE PROCEDURE spDel_Cg_os_item	@ID_OS As int,	@ITEM_ID As int,	@ID_EQUIPAMENTO As intASBEGINDELETE FROM CG_OS_ITEM WHERE	ID_OS = @ID_OS AND	ITEM_ID = @ITEM_ID AND 	ID_EQUIPAMENTO = @ID_EQUIPAMENTOEND------------------------------------------------------------