USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_equipamento_historico_serie]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDel_Cg_equipamento_historico_serie]	@ID_EQUIPAMENTO As int,	@ID_OS As int,	@ITEM_ID As intASBEGINDELETE FROM CG_EQUIPAMENTO_HISTORICO_SERIE WHERE	ID_OS = @ID_OS AND	ITEM_ID = @ITEM_ID AND	ID_EQUIPAMENTO = @ID_EQUIPAMENTOEND------------------------------------------------------------
GO
