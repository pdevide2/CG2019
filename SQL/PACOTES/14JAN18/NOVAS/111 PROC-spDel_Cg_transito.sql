if exists(select 1 from sysobjects where TYPE = 'P' AND name = 'spDel_Cg_transito')begin	drop procedure spDel_Cg_transitoendGOCREATE PROCEDURE spDel_Cg_transito	@ID_TRANSITO As intASBEGINDELETE FROM CG_TRANSITO WHERE	ID_TRANSITO = @ID_TRANSITOENDGO------------------------------------------------------------