USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_equipamento_historico_serie]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpd_Cg_equipamento_historico_serie]	@ID_EQUIPAMENTO As int,	@DATA_ALTERACAO As datetime,	@ID_OS As int,	@ITEM_ID As int,	@MOTIVO_ALTERACAO As text,	@SERIE_ANTERIOR As varchar(30),	@SERIE_NOVA As varchar(30),	@ID_EMPRESA As intASBEGINUPDATE CG_EQUIPAMENTO_HISTORICO_SERIE SET	data_alteracao = @data_alteracao,	motivo_alteracao = @motivo_alteracao,	serie_anterior = @serie_anterior,	serie_nova = @serie_nova,	id_empresa = @id_empresaWHERE	ID_OS = @ID_OS AND	ITEM_ID = @ITEM_ID AND	ID_EQUIPAMENTO = @ID_EQUIPAMENTOEND------------------------------------------------------------
GO
