USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_os]    Script Date: 13/03/2018 22:34:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spIns_Cg_os]

	@ID_OS As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA_ORIGEM As int,
	@NF_TRANSP As varchar(10) = NULL,
	@SERIE_NF_TRANSP As varchar(10) = NULL,
	@EMISSAO_NF_TRANSP As datetime = NULL,
	@ID_FORNECEDOR As int,
	@ID_RESPONSAVEL_IDA As int = NULL,
	@STATUS_OS As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@XML_NF_TRANSP As xml = NULL,
	@XML_NF_TS As xml = NULL,
	@ID_EMPRESA INT

AS

BEGIN
INSERT INTO CG_OS (
	id_os,
	data_movto,
	id_loja_origem,
	nf_transp,
	serie_nf_transp,
	emissao_nf_transp,
	id_fornecedor,
	id_responsavel_ida,
	status_os,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	xml_nf_transp,
	xml_nf_ts,
	ID_EMPRESA)
VALUES (
	@id_os,
	@data_movto,
	@id_loja_origem,
	@nf_transp,
	@serie_nf_transp,
	@emissao_nf_transp,
	@id_fornecedor,
	@id_responsavel_ida,
	@status_os,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@xml_nf_transp,
	@xml_nf_ts,
	@ID_EMPRESA)

END

------------------------------------------------------------





