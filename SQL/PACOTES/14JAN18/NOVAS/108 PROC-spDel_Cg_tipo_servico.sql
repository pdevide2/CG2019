if exists(select 1 from sysobjects where TYPE = 'P' AND name = 'spDel_Cg_tipo_servico')begin	drop procedure spDel_Cg_tipo_servicoendGOCREATE PROCEDURE spDel_Cg_tipo_servico	@ID_TIPO_SERVICO As intASBEGINDELETE FROM CG_TIPO_SERVICO WHERE	ID_TIPO_SERVICO = @ID_TIPO_SERVICOENDGO------------------------------------------------------------