CREATE PROCEDURE spIns_Cg_area	@ID_AREA As char(8),	@DESC_AREA As varchar(50),	@ID_RESPONSAVEL As int,	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULL,	@ID_EMPRESA As intASBEGININSERT INTO CG_AREA (	id_area,	desc_area,	id_responsavel,	user_ins,	data_ins,	user_upd,	data_upd,	id_empresa)VALUES (	@id_area,	@desc_area,	@id_responsavel,	@user_ins,	@data_ins,	@user_upd,	@data_upd,	@id_empresa)END------------------------------------------------------------