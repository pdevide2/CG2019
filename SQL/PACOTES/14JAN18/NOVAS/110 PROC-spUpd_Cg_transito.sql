if exists(select 1 from sysobjects where TYPE = 'P' AND name = 'spUpd_Cg_transito')begin	drop procedure spUpd_Cg_transitoendGOCREATE PROCEDURE spUpd_Cg_transito	@ID_TRANSITO As int,	@NOME_TRANSITO As varchar(40),	@INATIVO As bit,	@ID_EMPRESA As intASBEGINUPDATE CG_TRANSITO SET	nome_transito = @nome_transito,	inativo = @inativo,	id_empresa = @id_empresaWHERE	ID_TRANSITO = @ID_TRANSITOENDGO------------------------------------------------------------