CREATE PROCEDURE spIns_Cg_ocorrencia	@ID_OCORRENCIA As int,	@DATA_OCORRENCIA As datetime,	@DESCRICAO As varchar(60),	@ID_EQUIPAMENTO As int,	@SERIE As varchar(30),	@ID_LOJA As int,	@HISTORICO As text,	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULLASBEGININSERT INTO CG_OCORRENCIA (	id_ocorrencia,	data_ocorrencia,	descricao,	id_equipamento,	serie,	id_loja,	historico,	user_ins,	data_ins,	user_upd,	data_upd)VALUES (	@id_ocorrencia,	@data_ocorrencia,	@descricao,	@id_equipamento,	@serie,	@id_loja,	@historico,	@user_ins,	@data_ins,	@user_upd,	@data_upd)END------------------------------------------------------------