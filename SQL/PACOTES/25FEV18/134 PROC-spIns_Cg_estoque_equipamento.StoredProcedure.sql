USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_estoque_equipamento]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_estoque_equipamento]	@ID_EQUIPAMENTO As int,	@ESTOQUE As int,	@TRANSITO As bit,	@ID_LOCAL As int,	@DATAMOV As datetime,	@TIPO_LOCAL As char(1),	@ID_EMPRESA As intASBEGININSERT INTO CG_ESTOQUE_EQUIPAMENTO (	id_equipamento,	estoque,	transito,	id_local,	datamov,	tipo_local,	id_empresa)VALUES (	@id_equipamento,	@estoque,	@transito,	@id_local,	@datamov,	@tipo_local,	@id_empresa)END------------------------------------------------------------
GO
