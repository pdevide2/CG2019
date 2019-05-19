USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_equipamento_historico_serie]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_equipamento_historico_serie]

	@ID_EQUIPAMENTO As int,
	@DATA_ALTERACAO As datetime,
	@ID_OS As int,
	@ITEM_ID As int,
	@MOTIVO_ALTERACAO As text,
	@SERIE_ANTERIOR As varchar(30),
	@SERIE_NOVA As varchar(30),
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_EQUIPAMENTO_HISTORICO_SERIE (
	id_equipamento,
	data_alteracao,
	id_os,
	item_id,
	motivo_alteracao,
	serie_anterior,
	serie_nova,
	id_empresa)
VALUES (
	@id_equipamento,
	@data_alteracao,
	@id_os,
	@item_id,
	@motivo_alteracao,
	@serie_anterior,
	@serie_nova,
	@id_empresa)

END

------------------------------------------------------------




GO
