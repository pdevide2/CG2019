USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_follow_up]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_follow_up]	@ID_OS As int,	@PROTOCOLO As varchar(20),	@DATA_HORA As datetime,	@TEXTO As text,	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULL,	@ID_EMPRESA As intASBEGININSERT INTO CG_FOLLOW_UP (	id_os,	protocolo,	data_hora,	texto,	user_ins,	data_ins,	user_upd,	data_upd,	id_empresa)VALUES (	@id_os,	@protocolo,	@data_hora,	@texto,	@user_ins,	@data_ins,	@user_upd,	@data_upd,	@id_empresa)END------------------------------------------------------------
GO
