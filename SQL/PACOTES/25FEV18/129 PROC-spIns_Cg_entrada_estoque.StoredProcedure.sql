USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_estoque]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spIns_Cg_entrada_estoque]	@ID_ROMANEIO As int,	@DATA_MOVTO As datetime,	@ID_LOJA As int,	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULL,	@ROMANEIO_ESTOQUE As int = NULL,	@ID_EMPRESA As intASBEGININSERT INTO CG_ENTRADA_ESTOQUE (	id_romaneio,	data_movto,	id_loja,	user_ins,	data_ins,	user_upd,	data_upd,	romaneio_estoque,	id_empresa)VALUES (	@id_romaneio,	@data_movto,	@id_loja,	@user_ins,	@data_ins,	@user_upd,	@data_upd,	@romaneio_estoque,	@id_empresa)END------------------------------------------------------------
GO
