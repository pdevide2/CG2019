USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_estoque_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_estoque_chip]	@ID_CHIP As int,	@ESTOQUE As int,	@TRANSITO As bit,	@ID_LOCAL As int,	@DATAMOV As datetime,	@TIPO_LOCAL As char(1),	@ID_EMPRESA As intASBEGININSERT INTO CG_ESTOQUE_CHIP (	id_chip,	estoque,	transito,	id_local,	datamov,	tipo_local,	id_empresa)VALUES (	@id_chip,	@estoque,	@transito,	@id_local,	@datamov,	@tipo_local,	@id_empresa)END------------------------------------------------------------
GO
