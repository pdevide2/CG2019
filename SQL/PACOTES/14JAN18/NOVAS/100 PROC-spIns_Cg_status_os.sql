if exists(select 1 from sysobjects where TYPE = 'P' AND name = 'spIns_Cg_status_os')begin	drop procedure spIns_Cg_status_osendGOCREATE PROCEDURE spIns_Cg_status_os	@ID_STATUS As int,	@DESC_STATUS As varchar(20),	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULL,	@ID_EMPRESA As intASBEGININSERT INTO CG_STATUS_OS (	id_status,	desc_status,	user_ins,	data_ins,	user_upd,	data_upd,	id_empresa)VALUES (	@id_status,	@desc_status,	@user_ins,	@data_ins,	@user_upd,	@data_upd,	@id_empresa)ENDGO------------------------------------------------------------