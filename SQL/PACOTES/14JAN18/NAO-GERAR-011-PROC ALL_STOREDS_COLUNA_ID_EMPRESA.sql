USE [dbCG]
GO

IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_ACESSO') 
drop proc spIns_CG_ACESSO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_ALOCACAO') 
drop proc spIns_CG_ALOCACAO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_AREA') 
drop proc spIns_CG_AREA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_CARGO') 
drop proc spIns_CG_CARGO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_CATEGORIA') 
drop proc spIns_CG_CATEGORIA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_CHIP') 
drop proc spIns_CG_CHIP
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_EMPRESA') 
drop proc spIns_CG_EMPRESA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_ENTRADA_CHIP') 
drop proc spIns_CG_ENTRADA_CHIP
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_ENTRADA_CHIP_ITEM') 
drop proc spIns_CG_ENTRADA_CHIP_ITEM
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_ENTRADA_EQUIPAMENTO') 
drop proc spIns_CG_ENTRADA_EQUIPAMENTO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_ENTRADA_EQUIPAMENTO_ITEM') 
drop proc spIns_CG_ENTRADA_EQUIPAMENTO_ITEM
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_EQUIPAMENTO') 
drop proc spIns_CG_EQUIPAMENTO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_EQUIPAMENTO_HISTORICO_SERIE') 
drop proc spIns_CG_EQUIPAMENTO_HISTORICO_SERIE
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_EQUIPAMENTO_VS_CHIP') 
drop proc spIns_CG_EQUIPAMENTO_VS_CHIP
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_ESTOQUE_CHIP') 
drop proc spIns_CG_ESTOQUE_CHIP
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_ESTOQUE_EQUIPAMENTO') 
drop proc spIns_CG_ESTOQUE_EQUIPAMENTO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_FINALIDADE') 
drop proc spIns_CG_FINALIDADE
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_FOLLOW_UP') 
drop proc spIns_CG_FOLLOW_UP
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_FORNECEDOR') 
drop proc spIns_CG_FORNECEDOR
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_LOJA') 
drop proc spIns_CG_LOJA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_MARCA') 
drop proc spIns_CG_MARCA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_MODELOS') 
drop proc spIns_CG_MODELOS
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_MOTIVO') 
drop proc spIns_CG_MOTIVO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_OCORRENCIA') 
drop proc spIns_CG_OCORRENCIA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_OPERADORA') 
drop proc spIns_CG_OPERADORA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_OS') 
drop proc spIns_CG_OS
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_OS_ITEM') 
drop proc spIns_CG_OS_ITEM
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_PECA') 
drop proc spIns_CG_PECA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_PEDIDO_COMPRA_PECA') 
drop proc spIns_CG_PEDIDO_COMPRA_PECA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_PEDIDO_COMPRA_PECA_ITEM') 
drop proc spIns_CG_PEDIDO_COMPRA_PECA_ITEM
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_RESPONSAVEL') 
drop proc spIns_CG_RESPONSAVEL
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_STATUS') 
drop proc spIns_CG_STATUS
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_STATUS_OS') 
drop proc spIns_CG_STATUS_OS
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_TIPO_EQUIPAMENTO') 
drop proc spIns_CG_TIPO_EQUIPAMENTO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_TIPO_SERVICO') 
drop proc spIns_CG_TIPO_SERVICO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_TRANSITO') 
drop proc spIns_CG_TRANSITO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spIns_CG_USUARIO') 
drop proc spIns_CG_USUARIO
GO

IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_ACESSO') 
drop proc spUpd_CG_ACESSO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_ALOCACAO') 
drop proc spUpd_CG_ALOCACAO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_AREA') 
drop proc spUpd_CG_AREA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_CARGO') 
drop proc spUpd_CG_CARGO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_CATEGORIA') 
drop proc spUpd_CG_CATEGORIA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_CHIP') 
drop proc spUpd_CG_CHIP
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_ENTRADA_CHIP') 
drop proc spUpd_CG_ENTRADA_CHIP
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_ENTRADA_CHIP_ITEM') 
drop proc spUpd_CG_ENTRADA_CHIP_ITEM
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_ENTRADA_EQUIPAMENTO') 
drop proc spUpd_CG_ENTRADA_EQUIPAMENTO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_ENTRADA_EQUIPAMENTO_ITEM') 
drop proc spUpd_CG_ENTRADA_EQUIPAMENTO_ITEM
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_EQUIPAMENTO') 
drop proc spUpd_CG_EQUIPAMENTO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_EQUIPAMENTO_VS_CHIP') 
drop proc spUpd_CG_EQUIPAMENTO_VS_CHIP
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_ESTOQUE_CHIP') 
drop proc spUpd_CG_ESTOQUE_CHIP
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_ESTOQUE_EQUIPAMENTO') 
drop proc spUpd_CG_ESTOQUE_EQUIPAMENTO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_FINALIDADE') 
drop proc spUpd_CG_FINALIDADE
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_FOLLOW_UP') 
drop proc spUpd_CG_FOLLOW_UP
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_FORNECEDOR') 
drop proc spUpd_CG_FORNECEDOR
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_LOJA') 
drop proc spUpd_CG_LOJA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_MARCA') 
drop proc spUpd_CG_MARCA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_MODELOS') 
drop proc spUpd_CG_MODELOS
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_MOTIVO') 
drop proc spUpd_CG_MOTIVO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_OCORRENCIA') 
drop proc spUpd_CG_OCORRENCIA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_OPERADORA') 
drop proc spUpd_CG_OPERADORA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_OS') 
drop proc spUpd_CG_OS
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_OS_ITEM') 
drop proc spUpd_CG_OS_ITEM
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_PECA') 
drop proc spUpd_CG_PECA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_PEDIDO_COMPRA_PECA') 
drop proc spUpd_CG_PEDIDO_COMPRA_PECA
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_PEDIDO_COMPRA_PECA_ITEM') 
drop proc spUpd_CG_PEDIDO_COMPRA_PECA_ITEM
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_RESPONSAVEL') 
drop proc spUpd_CG_RESPONSAVEL
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_TIPO_EQUIPAMENTO') 
drop proc spUpd_CG_TIPO_EQUIPAMENTO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_TIPO_SERVICO') 
drop proc spUpd_CG_TIPO_SERVICO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_TRANSITO') 
drop proc spUpd_CG_TRANSITO
GO
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='spUpd_CG_USUARIO') 
drop proc spUpd_CG_USUARIO
GO


/****** Object:  StoredProcedure [dbo].[spIns_Cg_acesso]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_acesso]

	@ID_USUARIO As int,
	@ID_MODULO As int,
	@PERMISSAO As char(1) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_ACESSO (
	id_usuario,
	id_modulo,
	permissao,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_usuario,
	@id_modulo,
	@permissao,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_alocacao]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_alocacao]

	@ID_ALOCACAO As int,
	@DESC_ALOCACAO As varchar(50) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_ALOCACAO (
	id_alocacao,
	desc_alocacao,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_alocacao,
	@desc_alocacao,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_area]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_area]

	@ID_AREA As CHAR(8),
	@DESC_AREA As varchar(50),
	@ID_RESPONSAVEL As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_AREA (
	id_area,
	desc_area,
	id_responsavel,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_area,
	@desc_area,
	@id_responsavel,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_cargo]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_cargo]

	@ID_CARGO As int,
	@DESC_CARGO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_CARGO (
	id_cargo,
	desc_cargo,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_cargo,
	@desc_cargo,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_categoria]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_categoria]

	@ID_CATEGORIA As int,
	@DESC_CATEGORIA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_CATEGORIA (
	id_categoria,
	desc_categoria,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_categoria,
	@desc_categoria,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_chip]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_chip]

	@ID_CHIP As int,
	@SIMID As varchar(20),
	@ID_OPERADORA As int,
	@ID_FORNECEDOR As int,
	@CUSTO as Numeric(12,2) = 0.00,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_CHIP (
	id_chip,
	simid,
	id_operadora,
	id_fornecedor,
	custo,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	ID_LOCAL_ESTOQUE)
VALUES (
	@id_chip,
	@simid,
	@id_operadora,
	@id_fornecedor,
	@CUSTO,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	0)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_chip]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_entrada_chip]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_ENTRADA_CHIP (
	id_romaneio,
	data_movto,
	id_loja,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_romaneio,
	@data_movto,
	@id_loja,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_chip_item]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_entrada_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_ENTRADA_CHIP_ITEM (
	id_romaneio,
	unique_keyid,
	id_chip,
	simid,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_chip,
	@simid,
	@qtd,
	@valor)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_equipamento]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_entrada_equipamento]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_ENTRADA_EQUIPAMENTO (
	id_romaneio,
	data_movto,
	id_loja,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_romaneio,
	@data_movto,
	@id_loja,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_equipamento_item]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_entrada_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_ENTRADA_EQUIPAMENTO_ITEM (
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_equipamento,
	@serie,
	@qtd,
	@valor)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_equipamento]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_equipamento]

	@ID_EQUIPAMENTO As int,
	@ID_TIPO_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL,
	@ID_FORNECEDOR As int,
	@PROTOCOLO As varchar(30) = NULL,
	@VALOR As numeric(12,2) = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@NF_ENTRADA AS VARCHAR(15) = NULL,
	@DATA_NF AS DATETIME = NULL,
	@PRAZO_GARANTIA AS INT = NULL

AS

BEGIN
INSERT INTO CG_EQUIPAMENTO (
	id_equipamento,
	id_tipo_equipamento,
	desc_equipamento,
	serie,
	modelo,
	id_fornecedor,
	protocolo,
	valor,
	obs,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	ID_LOCAL_ESTOQUE,
	NF_ENTRADA,
	DATA_NF,
	PRAZO_GARANTIA)
VALUES (
	@id_equipamento,
	@id_tipo_equipamento,
	@desc_equipamento,
	@serie,
	@modelo,
	@id_fornecedor,
	@protocolo,
	@valor,
	@obs,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	0,
	@NF_ENTRADA,
	@DATA_NF,
	@PRAZO_GARANTIA)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_equipamento_vs_chip]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_equipamento_vs_chip]

	@ID_EQUIPAMENTO As int,
	@ID_CHIP As int,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_EQUIPAMENTO_VS_CHIP (
	id_equipamento,
	id_chip,
	user_upd,
	data_upd)
VALUES (
	@id_equipamento,
	@id_chip,
	@user_upd,
	@data_upd)

END

GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_finalidade]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_finalidade]

	@ID_FINALIDADE As int,
	@DESC_FINALIDADE As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_FINALIDADE (
	id_finalidade,
	desc_finalidade,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_finalidade,
	@desc_finalidade,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_follow_up]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_follow_up]

	@ID_OS As int,
	@PROTOCOLO As varchar(20),
	@DATA_HORA As datetime,
	@TEXTO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_FOLLOW_UP (
	id_os,
	protocolo,
	data_hora,
	texto,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_os,
	@protocolo,
	@data_hora,
	@texto,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_fornecedor]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_fornecedor]

	@ID_FORNECEDOR As int,
	@SIGLA As varchar(50),
	@UTILIZA_NFTS As bit,
	@NOME As varchar(50),
	@CEP As varchar(9) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CIDADE As varchar(50) = NULL,
	@BAIRRO As varchar(50) = NULL,
	@UF As char(2) = NULL,
	@EMAIL As varchar(120) = NULL,
	@TELEFONE As varchar(20) = NULL,
	@CONTATO As varchar(50) = NULL,
	@WHATSAPP As varchar(20) = NULL,
	@ID_TIPO_SERVICO As int = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA_AQUISICAO INT = NULL,
	@GARANTIA_ASSISTENCIA INT = NULL

AS

BEGIN
INSERT INTO CG_FORNECEDOR (
	id_fornecedor,
	sigla,
	utiliza_nfts,
	nome,
	cep,
	endereco,
	complemento,
	cidade,
	bairro,
	uf,
	email,
	telefone,
	contato,
	whatsapp,
	id_tipo_servico,
	obs,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	GARANTIA_AQUISICAO,
	GARANTIA_ASSISTENCIA)
VALUES (
	@id_fornecedor,
	@sigla,
	@utiliza_nfts,
	@nome,
	@cep,
	@endereco,
	@complemento,
	@cidade,
	@bairro,
	@uf,
	@email,
	@telefone,
	@contato,
	@whatsapp,
	@id_tipo_servico,
	@obs,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@GARANTIA_AQUISICAO,
	@GARANTIA_ASSISTENCIA)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_loja]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_loja]

	@ID_LOJA As int,
	@SIGLA As varchar(50) = NULL,
	@NOME As varchar(50) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CEP As varchar(9) = NULL,
	@CIDADE As varchar(50) = NULL,
	@BAIRRO As varchar(50) = NULL,
	@UF As char(2) = NULL,
	@ID_TIPO_LOCAL As int = NULL,
	@ID_RESPONSAVEL As int = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@CODIGO AS VARCHAR(10),
	@TELEFONE AS VARCHAR(20) = NULL,
	@CELULAR AS VARCHAR(20) = NULL,
	@LOJA_FISICA AS BIT = 0,
	@PARCERIA AS BIT = 0,
	@ID_AREA AS CHAR(8) = '0000'

AS

BEGIN
INSERT INTO CG_LOJA (
	id_loja,
	sigla,
	nome,
	endereco,
	complemento,
	cep,
	cidade,
	bairro,
	uf,
	id_tipo_local,
	id_responsavel,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	CODIGO,
	TELEFONE,
	CELULAR,
	LOJA_FISICA,
	PARCERIA,
	ID_AREA)
VALUES (
	@id_loja,
	@sigla,
	@nome,
	@endereco,
	@complemento,
	@cep,
	@cidade,
	@bairro,
	@uf,
	@id_tipo_local,
	@id_responsavel,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@CODIGO,
	@TELEFONE,
	@CELULAR,
	@LOJA_FISICA,
	@PARCERIA,
	@ID_AREA)

END

------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_marca]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_marca]

	@ID_MARCA As int,
	@DESC_MARCA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_MARCA (
	id_marca,
	desc_marca,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_marca,
	@desc_marca,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_modelos]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_modelos]

	@ID_MODELO As int,
	@DESC_MODELO As varchar(100),
	@OBS As text = NULL,
	@CAMINHO_ARQUIVO As varchar(150) = NULL,
	@EXTENSAO_ARQUIVO As varchar(5) = NULL

AS

BEGIN
INSERT INTO CG_MODELOS (
	id_modelo,
	desc_modelo,
	obs,
	caminho_arquivo,
	extensao_arquivo)
VALUES (
	@id_modelo,
	@desc_modelo,
	@obs,
	@caminho_arquivo,
	@extensao_arquivo)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_motivo]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_motivo]

	@ID_MOTIVO As int,
	@DESC_MOTIVO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_MOTIVO (
	id_motivo,
	desc_motivo,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_motivo,
	@desc_motivo,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_ocorrencia]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_ocorrencia]

	@ID_OCORRENCIA As int,
	@DATA_OCORRENCIA As datetime,
	@DESCRICAO As varchar(60),
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@ID_LOJA As int,
	@HISTORICO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@OS_VINCULADA as varchar(50) = NULL


AS

BEGIN
INSERT INTO CG_OCORRENCIA (
	id_ocorrencia,
	data_ocorrencia,
	descricao,
	id_equipamento,
	serie,
	id_loja,
	historico,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	OS_VINCULADA)
VALUES (
	@id_ocorrencia,
	@data_ocorrencia,
	@descricao,
	@id_equipamento,
	@serie,
	@id_loja,
	@historico,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@OS_VINCULADA)

    IF ISNULL(@OS_VINCULADA,'') <> ''
    BEGIN

	   SELECT IDENTITY(INT, 1,1) AS ID_ROW, VALUE 
	   INTO #TMP_SPLIT
	   from dbo.SplitString(@OS_VINCULADA,'|')

	   DECLARE @P1 INT, @P2 INT, @P3 INT
	   SELECT @P1 = CAST(VALUE AS INT) FROM #TMP_SPLIT WHERE ID_ROW = 1
	   SELECT @P2 = CAST(VALUE AS INT) FROM #TMP_SPLIT WHERE ID_ROW = 2
	   SELECT @P3 = CAST(VALUE AS INT) FROM #TMP_SPLIT WHERE ID_ROW = 3
	   

	   UPDATE CG_OS_ITEM
	   SET ID_OCORRENCIA = @id_ocorrencia
	   WHERE ID_OS = @P1 AND ITEM_ID = @P2 AND ID_EQUIPAMENTO = @P3


    END

END

------------------------------------------------------------


 



GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_operadora]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_operadora]

	@ID_OPERADORA As int,
	@DESC_OPERADORA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_OPERADORA (
	id_operadora,
	desc_operadora,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_operadora,
	@desc_operadora,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_os]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_os]

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
	@XML_NF_TS As xml = NULL

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
	xml_nf_ts)
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
	@xml_nf_ts)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_os_item]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_os_item]

	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL,
	@PROTOCOLO As varchar(30) = NULL,
	@PREVISAO_RETORNO As datetime = NULL,
	@DESC_DEFEITO As varchar(250) = NULL,
	/*@CONSERTO_OK As bit,
	@NF_FORNEC As varchar(10) = NULL,
	@SERIE_NF_FORNEC As varchar(10) = NULL,
	@EMISSAO_NF_FORNEC As datetime = NULL,
	@ID_RESPONSAVEL_RET As int = NULL,
	@XML_NF_FORNEC As xml = NULL,
	@LAUDO_FORNEC As image = NULL,*/
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA AS BIT = NULL,
	@ID_OCORRENCIA AS INT = NULL 

AS

BEGIN
INSERT INTO CG_OS_ITEM (
	id_os,
	item_id,
	id_equipamento,
	desc_equipamento,
	serie,
	modelo,
	protocolo,
	previsao_retorno,
	desc_defeito,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	garantia,
	ID_OCORRENCIA)
VALUES (
	@id_os,
	@item_id,
	@id_equipamento,
	@desc_equipamento,
	@serie,
	@modelo,
	@protocolo,
	@previsao_retorno,
	@desc_defeito,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@GARANTIA,
	@ID_OCORRENCIA)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_peca]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spIns_Cg_peca]

	@ID_PECA As int,
	@NOME_PECA As varchar(50),
	@DESCRICAO As varchar(250),
	@ID_MARCA As int,
	@ID_CATEGORIA As int,
	@ID_FORNECEDOR As int,
	@ID_FINALIDADE As int,
	@ESTOQUE As int = NULL,
	@ESTOQUE_MIN As int = NULL,
	@ESTOQUE_MAX As int = NULL,
	@UNIDADE As varchar(10) = NULL,
	@DATA_AQUISICAO As datetime,
	@DIAS_GARANTIA As int,
	@CUSTO As numeric(10,2) = NULL,
	@REF_FORNEC As varchar(20) = NULL,
	@OBS As text = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_PECA (
	id_peca,
	nome_peca,
	descricao,
	id_marca,
	id_categoria,
	id_fornecedor,
	id_finalidade,
	estoque,
	estoque_min,
	estoque_max,
	unidade,
	data_aquisicao,
	dias_garantia,
	custo,
	ref_fornec,
	obs,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_peca,
	@nome_peca,
	@descricao,
	@id_marca,
	@id_categoria,
	@id_fornecedor,
	@id_finalidade,
	@estoque,
	@estoque_min,
	@estoque_max,
	@unidade,
	@data_aquisicao,
	@dias_garantia,
	@custo,
	@ref_fornec,
	@obs,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_pedido_compra_peca]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_pedido_compra_peca]

	@ID_PEDIDO As int,
	@TIPO_PEDIDO As char(2),
	@STATUS_PEDIDO As varchar(10),
	@ID_FORNECEDOR As int,
	@ID_COMPRADOR As int,
	@DATA_COMPRA As datetime,
	@PREVISAO_ENTREGA As datetime,
	@DATA_RECEBIMENTO As datetime = NULL,
	@OBS_PEDIDO As text = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_TOTAL As int = NULL

AS

BEGIN
INSERT INTO CG_PEDIDO_COMPRA_PECA (
	id_pedido,
	tipo_pedido,
	status_pedido,
	id_fornecedor,
	id_comprador,
	data_compra,
	previsao_entrega,
	data_recebimento,
	obs_pedido,
	user_ins,
	data_ins,
	qtd_total)
VALUES (
	@id_pedido,
	@tipo_pedido,
	@status_pedido,
	@id_fornecedor,
	@id_comprador,
	@data_compra,
	@previsao_entrega,
	@data_recebimento,
	@obs_pedido,
	@user_ins,
	@data_ins,
	@qtd_total)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_pedido_compra_peca_item]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_pedido_compra_peca_item]

	@ID_PEDIDO As int,
	@ID_PECA As int,
	@QTDE As int,
	@VALOR_UNIT As numeric(12,2),
	@VALOR_TOTAL As numeric(12,2),
	@RECEBIDO As bit = 0,
	@DATA_RECEBIMENTO As datetime = NULL

AS

BEGIN
INSERT INTO CG_PEDIDO_COMPRA_PECA_ITEM (
	id_pedido,
	id_peca,
	qtde,
	valor_unit,
	valor_total,
	recebido,
	data_recebimento)
VALUES (
	@id_pedido,
	@id_peca,
	@qtde,
	@valor_unit,
	@valor_total,
	@recebido,
	@data_recebimento)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_responsavel]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_responsavel]

	@ID_RESPONSAVEL As int,
	@NOME As varchar(50),
	@APELIDO As varchar(50) = NULL,
	@EMAIL As varchar(120) = NULL,
	@CELULAR As varchar(20) = NULL,
	@WHATSAPP As varchar(20) = NULL,
	@ID_CARGO As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_RESPONSAVEL (
	id_responsavel,
	nome,
	apelido,
	email,
	celular,
	whatsapp,
	id_cargo,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_responsavel,
	@nome,
	@apelido,
	@email,
	@celular,
	@whatsapp,
	@id_cargo,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_tipo_equipamento]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_tipo_equipamento]

	@ID_TIPO_EQUIPAMENTO As int,
	@DESC_TIPO_EQUIPAMENTO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_TIPO_EQUIPAMENTO (
	id_tipo_equipamento,
	desc_tipo_equipamento,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_tipo_equipamento,
	@desc_tipo_equipamento,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_tipo_servico]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_tipo_servico]

	@ID_TIPO_SERVICO As int,
	@DESC_TIPO_SERVICO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_TIPO_SERVICO (
	id_tipo_servico,
	desc_tipo_servico,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_tipo_servico,
	@desc_tipo_servico,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_transito]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_transito]

	@ID_TRANSITO As int,
	@NOME_TRANSITO As varchar(40),
	@INATIVO As bit

AS

BEGIN
INSERT INTO CG_TRANSITO (
	id_transito,
	nome_transito,
	inativo)
VALUES (
	@id_transito,
	@nome_transito,
	@inativo)

END

------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_usuario]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_usuario]

	@ID_USUARIO As int,
	@APELIDO As varchar(50),
	@NOME As varchar(50),
	@CPF As varchar(15) = NULL,
	@RG As varchar(15) = NULL,
	@EMAIL As varchar(120) = NULL,
	@TELEFONE As varchar(15) = NULL,
	@WHATSAPP As varchar(15) = NULL,
	@CEP As varchar(9) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CIDADE As varchar(40) = NULL,
	@BAIRRO As varchar(40) = NULL,
	@UF As varchar(2) = NULL,
	@LOGIN As varchar(20) = NULL,
	@ID_STATUS As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
INSERT INTO CG_USUARIO (
	id_usuario,
	apelido,
	nome,
	cpf,
	rg,
	email,
	telefone,
	whatsapp,
	cep,
	endereco,
	complemento,
	cidade,
	bairro,
	uf,
	login,
	id_status,
	user_ins,
	data_ins,
	user_upd,
	data_upd)
VALUES (
	@id_usuario,
	@apelido,
	@nome,
	@cpf,
	@rg,
	@email,
	@telefone,
	@whatsapp,
	@cep,
	@endereco,
	@complemento,
	@cidade,
	@bairro,
	@uf,
	@login,
	@id_status,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd)

END

------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_acesso]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_acesso]

	@ID_USUARIO As int,
	@ID_MODULO As int,
	@PERMISSAO As char(1) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
if EXISTS( SELECT 1 FROM CG_ACESSO WHERE ID_USUARIO = @ID_USUARIO AND ID_MODULO = @ID_MODULO)
BEGIN
	UPDATE CG_ACESSO SET
		permissao = @permissao,
		user_ins = @user_ins,
		data_ins = @data_ins,
		user_upd = @user_upd,
		data_upd = @data_upd
	WHERE
		ID_USUARIO = @ID_USUARIO AND
		ID_MODULO = @ID_MODULO
END

ELSE

BEGIN
	INSERT INTO CG_ACESSO (

		id_usuario,

		id_modulo,

		permissao,

		user_ins,

		data_ins,

		user_upd,

		data_upd)

	VALUES (

		@id_usuario,

		@id_modulo,

		@permissao,

		@user_ins,

		@data_ins,

		@user_upd,

		@data_upd)
END

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_alocacao]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_alocacao]

	@ID_ALOCACAO As int,
	@DESC_ALOCACAO As varchar(50) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_ALOCACAO SET
	desc_alocacao = @desc_alocacao,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_ALOCACAO = @ID_ALOCACAO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_area]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_area]

	@ID_AREA As CHAR(8),
	@DESC_AREA As varchar(50),
	@ID_RESPONSAVEL As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_AREA SET
	desc_area = @desc_area,
	id_responsavel = @id_responsavel,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_AREA = @ID_AREA

END
------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_cargo]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_cargo]

	@ID_CARGO As int,
	@DESC_CARGO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_CARGO SET
	desc_cargo = @desc_cargo,
	user_ins = user_ins,
	data_ins = data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_CARGO = @ID_CARGO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_categoria]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_categoria]

	@ID_CATEGORIA As int,
	@DESC_CATEGORIA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_CATEGORIA SET
	desc_categoria = @desc_categoria,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_CATEGORIA = @ID_CATEGORIA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_chip]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_chip]

	@ID_CHIP As int,
	@SIMID As varchar(20),
	@ID_OPERADORA As int,
	@ID_FORNECEDOR As int,
	@CUSTO Numeric(12,2),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_CHIP SET
	simid = @simid,
	id_operadora = @id_operadora,
	id_fornecedor = @id_fornecedor,
	custo = @CUSTO,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_CHIP = @ID_CHIP

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_entrada_chip]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_entrada_chip]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_ENTRADA_CHIP SET
	data_movto = @data_movto,
	id_loja = @id_loja,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_entrada_chip_item]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_entrada_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_ENTRADA_CHIP_ITEM SET
	id_chip = @id_chip,
	simid = @simid,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_entrada_equipamento]    Script Date: 29/11/2017 21:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_entrada_equipamento]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_ENTRADA_EQUIPAMENTO SET
	data_movto = @data_movto,
	id_loja = @id_loja,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_entrada_equipamento_item]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_entrada_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
UPDATE CG_ENTRADA_EQUIPAMENTO_ITEM SET
	id_equipamento = @id_equipamento,
	serie = @serie,
	qtd = @qtd,
	valor = @valor
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_equipamento]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_equipamento]

	@ID_EQUIPAMENTO As int,
	@ID_TIPO_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL,
	@ID_FORNECEDOR As int,
	@PROTOCOLO As varchar(30) = NULL,
	@VALOR As numeric(12,2) = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@NF_ENTRADA AS VARCHAR(15) = NULL,
	@DATA_NF AS DATETIME = NULL,
	@PRAZO_GARANTIA AS INT = NULL


AS

BEGIN
UPDATE CG_EQUIPAMENTO SET
	id_tipo_equipamento = @id_tipo_equipamento,
	desc_equipamento = @desc_equipamento,
	serie = @serie,
	modelo = @modelo,
	id_fornecedor = @id_fornecedor,
	protocolo = @protocolo,
	valor = @valor,
	obs = @obs,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	NF_ENTRADA = @NF_ENTRADA,
	DATA_NF	= @DATA_NF,
	PRAZO_GARANTIA = @PRAZO_GARANTIA
WHERE
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_equipamento_vs_chip]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpd_Cg_equipamento_vs_chip]

	@ID_EQUIPAMENTO As int,
	@ID_CHIP As int,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_EQUIPAMENTO_VS_CHIP SET
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO AND
	ID_CHIP = @ID_CHIP

END

GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_finalidade]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_finalidade]

	@ID_FINALIDADE As int,
	@DESC_FINALIDADE As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_FINALIDADE SET
	desc_finalidade = @desc_finalidade,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_FINALIDADE = @ID_FINALIDADE

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_follow_up]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_follow_up]

	@ID_OS As int,
	@PROTOCOLO As varchar(20),
	@DATA_HORA As datetime,
	@TEXTO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_FOLLOW_UP SET
	data_hora = @data_hora,
	texto = @texto,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_OS = @ID_OS AND
	PROTOCOLO = @PROTOCOLO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_fornecedor]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_fornecedor]

	@ID_FORNECEDOR As int,
	@SIGLA As varchar(50),
	@UTILIZA_NFTS As bit,
	@NOME As varchar(50),
	@CEP As varchar(9) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CIDADE As varchar(50) = NULL,
	@BAIRRO As varchar(50) = NULL,
	@UF As char(2) = NULL,
	@EMAIL As varchar(120) = NULL,
	@TELEFONE As varchar(20) = NULL,
	@CONTATO As varchar(50) = NULL,
	@WHATSAPP As varchar(20) = NULL,
	@ID_TIPO_SERVICO As int = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA_AQUISICAO INT = NULL,
	@GARANTIA_ASSISTENCIA INT = NULL

AS

BEGIN
UPDATE CG_FORNECEDOR SET
	sigla = @sigla,
	utiliza_nfts = @utiliza_nfts,
	nome = @nome,
	cep = @cep,
	endereco = @endereco,
	complemento = @complemento,
	cidade = @cidade,
	bairro = @bairro,
	uf = @uf,
	email = @email,
	telefone = @telefone,
	contato = @contato,
	whatsapp = @whatsapp,
	id_tipo_servico = @id_tipo_servico,
	obs = @obs,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	GARANTIA_AQUISICAO = @GARANTIA_AQUISICAO,
	GARANTIA_ASSISTENCIA = @GARANTIA_ASSISTENCIA
WHERE
	ID_FORNECEDOR = @ID_FORNECEDOR

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_loja]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_loja]

	@ID_LOJA As int,
	@SIGLA As varchar(50) = NULL,
	@NOME As varchar(50) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CEP As varchar(9) = NULL,
	@CIDADE As varchar(50) = NULL,
	@BAIRRO As varchar(50) = NULL,
	@UF As char(2) = NULL,
	@ID_TIPO_LOCAL As int = NULL,
	@ID_RESPONSAVEL As int = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@CODIGO AS VARCHAR(10),
	@TELEFONE AS VARCHAR(20) = NULL,
	@CELULAR AS VARCHAR(20) = NULL,
	@LOJA_FISICA AS BIT = 0,
	@PARCERIA AS BIT = 0,
	@ID_AREA AS CHAR(8) = '0000'

AS

BEGIN
UPDATE CG_LOJA SET
	sigla = @sigla,
	nome = @nome,
	endereco = @endereco,
	complemento = @complemento,
	cep = @cep,
	cidade = @cidade,
	bairro = @bairro,
	uf = @uf,
	id_tipo_local = @id_tipo_local,
	id_responsavel = @id_responsavel,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	codigo = @CODIGO,
	TELEFONE = @TELEFONE,
	CELULAR = @CELULAR,
	LOJA_FISICA = @LOJA_FISICA,
	PARCERIA = @PARCERIA,
	ID_AREA = @ID_AREA
WHERE
	ID_LOJA = @ID_LOJA

END
------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_marca]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_marca]

	@ID_MARCA As int,
	@DESC_MARCA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_MARCA SET
	desc_marca = @desc_marca,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_MARCA = @ID_MARCA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_modelos]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_modelos]

	@ID_MODELO As int,
	@DESC_MODELO As varchar(100),
	@OBS As text = NULL,
	@CAMINHO_ARQUIVO As varchar(150) = NULL,
	@EXTENSAO_ARQUIVO As varchar(5) = NULL

AS

BEGIN
UPDATE CG_MODELOS SET
	desc_modelo = @desc_modelo,
	obs = @obs,
	caminho_arquivo = @caminho_arquivo,
	extensao_arquivo = @extensao_arquivo
WHERE
	ID_MODELO = @ID_MODELO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_motivo]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_motivo]

	@ID_MOTIVO As int,
	@DESC_MOTIVO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_MOTIVO SET
	desc_motivo = @desc_motivo,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_MOTIVO = @ID_MOTIVO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_ocorrencia]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_ocorrencia]

	@ID_OCORRENCIA As int,
	@DATA_OCORRENCIA As datetime,
	@DESCRICAO As varchar(60),
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@ID_LOJA As int,
	@HISTORICO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@OS_VINCULADA as varchar(50) = NULL

AS

BEGIN
UPDATE CG_OCORRENCIA SET
	data_ocorrencia = @data_ocorrencia,
	descricao = @descricao,
	id_equipamento = @id_equipamento,
	serie = @serie,
	id_loja = @id_loja,
	historico = @historico,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	OS_VINCULADA = @OS_VINCULADA
WHERE
	ID_OCORRENCIA = @ID_OCORRENCIA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_operadora]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_operadora]

	@ID_OPERADORA As int,
	@DESC_OPERADORA As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_OPERADORA SET
	desc_operadora = @desc_operadora,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_OPERADORA = @ID_OPERADORA

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_os]

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
	@XML_NF_TS As xml = NULL

AS

BEGIN
UPDATE CG_OS SET
	data_movto = @data_movto,
	id_loja_origem = @id_loja_origem,
	nf_transp = @nf_transp,
	serie_nf_transp = @serie_nf_transp,
	emissao_nf_transp = @emissao_nf_transp,
	id_fornecedor = @id_fornecedor,
	id_responsavel_ida = @id_responsavel_ida,
	status_os = @status_os,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	xml_nf_transp = @xml_nf_transp,
	xml_nf_ts = @xml_nf_ts
WHERE
	ID_OS = @ID_OS

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_os_item]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_os_item]

	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL,
	@PROTOCOLO As varchar(30) = NULL,
	@PREVISAO_RETORNO As datetime = NULL,
	@DESC_DEFEITO As varchar(250) = NULL,
	/*@CONSERTO_OK As bit,
	@NF_FORNEC As varchar(10) = NULL,
	@SERIE_NF_FORNEC As varchar(10) = NULL,
	@EMISSAO_NF_FORNEC As datetime = NULL,
	@ID_RESPONSAVEL_RET As int = NULL,
	@XML_NF_FORNEC As xml = NULL,
	@LAUDO_FORNEC As image = NULL,*/
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@GARANTIA AS BIT = NULL,
	@ID_OCORRENCIA AS INT = NULL 

AS

BEGIN
UPDATE CG_OS_ITEM SET
	id_equipamento = @id_equipamento,
	desc_equipamento = @desc_equipamento,
	serie = @serie,
	modelo = @modelo,
	protocolo = @protocolo,
	previsao_retorno = @previsao_retorno,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	GARANTIA = @GARANTIA,
	ID_OCORRENCIA = @ID_OCORRENCIA
WHERE
	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_peca]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[spUpd_Cg_peca]

	@ID_PECA As int,
	@NOME_PECA As varchar(50),
	@DESCRICAO As varchar(250),
	@ID_MARCA As int,
	@ID_CATEGORIA As int,
	@ID_FORNECEDOR As int,
	@ID_FINALIDADE As int,
	@ESTOQUE As int = NULL,
	@ESTOQUE_MIN As int = NULL,
	@ESTOQUE_MAX As int = NULL,
	@UNIDADE As varchar(10) = NULL,
	@DATA_AQUISICAO As datetime,
	@DIAS_GARANTIA As int,
	@CUSTO As numeric(10,2) = NULL,
	@REF_FORNEC As varchar(20) = NULL,
	@OBS As text = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_PECA SET
	nome_peca = @nome_peca,
	descricao = @descricao,
	id_marca = @id_marca,
	id_categoria = @id_categoria,
	id_fornecedor = @id_fornecedor,
	id_finalidade = @id_finalidade,
	estoque = @estoque,
	estoque_min = @estoque_min,
	estoque_max = @estoque_max,
	unidade = @unidade,
	data_aquisicao = @data_aquisicao,
	dias_garantia = @dias_garantia,
	custo = @custo,
	ref_fornec = @ref_fornec,
	obs = @obs,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_PECA = @ID_PECA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_pedido_compra_peca]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_pedido_compra_peca]

	@ID_PEDIDO As int,
	@TIPO_PEDIDO As char(2),
	@STATUS_PEDIDO As varchar(10),
	@ID_FORNECEDOR As int,
	@ID_COMPRADOR As int,
	@DATA_COMPRA As datetime,
	@PREVISAO_ENTREGA As datetime,
	@DATA_RECEBIMENTO As datetime = NULL,
	@OBS_PEDIDO As text = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@QTD_TOTAL As int = NULL

AS

BEGIN
UPDATE CG_PEDIDO_COMPRA_PECA SET
	tipo_pedido = @tipo_pedido,
	status_pedido = @status_pedido,
	id_fornecedor = @id_fornecedor,
	id_comprador = @id_comprador,
	data_compra = @data_compra,
	previsao_entrega = @previsao_entrega,
	data_recebimento = @data_recebimento,
	obs_pedido = @obs_pedido,
	user_upd = @user_upd,
	data_upd = @data_upd,
	qtd_total = @qtd_total
WHERE
	ID_PEDIDO = @ID_PEDIDO

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_pedido_compra_peca_item]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_pedido_compra_peca_item]

	@ID_PEDIDO As int,
	@ID_PECA As int,
	@QTDE As int,
	@VALOR_UNIT As numeric(12,2),
	@VALOR_TOTAL As numeric(12,2),
	@RECEBIDO As bit = 0,
	@DATA_RECEBIMENTO As datetime = NULL

AS

BEGIN
UPDATE CG_PEDIDO_COMPRA_PECA_ITEM SET
	qtde = @qtde,
	valor_unit = @valor_unit,
	valor_total = @valor_total,
	recebido = @recebido,
	data_recebimento = @data_recebimento
WHERE
	ID_PEDIDO = @ID_PEDIDO AND
	ID_PECA = @ID_PECA

END
------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_responsavel]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_responsavel]

	@ID_RESPONSAVEL As int,
	@NOME As varchar(50),
	@APELIDO As varchar(50) = NULL,
	@EMAIL As varchar(120) = NULL,
	@CELULAR As varchar(20) = NULL,
	@WHATSAPP As varchar(20) = NULL,
	@ID_CARGO As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_RESPONSAVEL SET
	nome = @nome,
	apelido = @apelido,
	email = @email,
	celular = @celular,
	whatsapp = @whatsapp,
	id_cargo = @id_cargo,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_RESPONSAVEL = @ID_RESPONSAVEL

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_tipo_equipamento]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_tipo_equipamento]

	@ID_TIPO_EQUIPAMENTO As int,
	@DESC_TIPO_EQUIPAMENTO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_TIPO_EQUIPAMENTO SET
	desc_tipo_equipamento = @desc_tipo_equipamento,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_TIPO_EQUIPAMENTO = @ID_TIPO_EQUIPAMENTO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_tipo_servico]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_tipo_servico]

	@ID_TIPO_SERVICO As int,
	@DESC_TIPO_SERVICO As varchar(50),
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_TIPO_SERVICO SET
	desc_tipo_servico = @desc_tipo_servico,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_TIPO_SERVICO = @ID_TIPO_SERVICO

END
------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_transito]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_transito]

	@ID_TRANSITO As int,
	@NOME_TRANSITO As varchar(40),
	@INATIVO As bit

AS

BEGIN
update CG_TRANSITO set
	nome_transito = @nome_transito,
	inativo = @inativo
where ID_TRANSITO = @ID_TRANSITO
END

------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_usuario]    Script Date: 29/11/2017 21:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_usuario]

	@ID_USUARIO As int,
	@APELIDO As varchar(50),
	@NOME As varchar(50),
	@CPF As varchar(15) = NULL,
	@RG As varchar(15) = NULL,
	@EMAIL As varchar(120) = NULL,
	@TELEFONE As varchar(15) = NULL,
	@WHATSAPP As varchar(15) = NULL,
	@CEP As varchar(9) = NULL,
	@ENDERECO As varchar(70) = NULL,
	@COMPLEMENTO As varchar(40) = NULL,
	@CIDADE As varchar(40) = NULL,
	@BAIRRO As varchar(40) = NULL,
	@UF As varchar(2) = NULL,
	@LOGIN As varchar(20) = NULL,
	@ID_STATUS As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN
UPDATE CG_USUARIO SET
	apelido = @apelido,
	nome = @nome,
	cpf = @cpf,
	rg = @rg,
	email = @email,
	telefone = @telefone,
	whatsapp = @whatsapp,
	cep = @cep,
	endereco = @endereco,
	complemento = @complemento,
	cidade = @cidade,
	bairro = @bairro,
	uf = @uf,
	login = @login,
	id_status = @id_status,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd
WHERE
	ID_USUARIO = @ID_USUARIO

END
------------------------------------------------------------





GO
