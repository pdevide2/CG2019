if exists(select 1 from sysobjects where TYPE = 'P' AND name = 'spDel_Romaneio_estoque')begin	drop procedure spDel_Romaneio_estoqueendGOCREATE PROCEDURE spDel_Romaneio_estoque	@ROMANEIO As intASBEGINDELETE FROM ROMANEIO_ESTOQUE WHERE	ROMANEIO = @ROMANEIOENDGO------------------------------------------------------------