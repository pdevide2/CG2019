USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Romaneio_estoque]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Romaneio_estoque]	@ROMANEIO As int,	@MODULO As varchar(50) = NULL,	@TIPO_PRODUTO As char(1),	@TIPO_OP As char(1) = NULL,	@DATAMOV As datetime,	@ID_USUARIO As int,	@ID_EMPRESA As intASBEGININSERT INTO ROMANEIO_ESTOQUE (	romaneio,	modulo,	tipo_produto,	tipo_op,	datamov,	id_usuario,	id_empresa)VALUES (	@romaneio,	@modulo,	@tipo_produto,	@tipo_op,	@datamov,	@id_usuario,	@id_empresa)END------------------------------------------------------------
GO
