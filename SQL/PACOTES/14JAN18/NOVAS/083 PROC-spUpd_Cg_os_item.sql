if exists(select 1 from sysobjects where TYPE = 'P' AND name = 'spUpd_Cg_os_item')begin	drop procedure spUpd_Cg_os_itemendGOCREATE PROCEDURE spUpd_Cg_os_item	@ID_OS As int,	@ITEM_ID As int,	@ID_EQUIPAMENTO As int,	@DESC_EQUIPAMENTO As varchar(50),	@SERIE As varchar(30) = NULL,	@MODELO As varchar(30) = NULL,	@PROTOCOLO As varchar(30) = NULL,	@PREVISAO_RETORNO As datetime = NULL,	@DATA_RETORNO As datetime = NULL,	@DESC_DEFEITO As varchar(250) = NULL,	@CONSERTO_OK As bit,	@NF_FORNEC As varchar(10) = NULL,	@SERIE_NF_FORNEC As varchar(10) = NULL,	@EMISSAO_NF_FORNEC As datetime = NULL,	@OBS_RETORNO As text = NULL,	@ID_RESPONSAVEL_RET As int = NULL,	@XML_NF_FORNEC As xml = NULL,	@LAUDO_FORNEC As image = NULL,	@USER_INS As int = NULL,	@DATA_INS As datetime = NULL,	@USER_UPD As int = NULL,	@DATA_UPD As datetime = NULL,	@GARANTIA As bit,	@RECEBIDO As bit,	@VALOR_CONSERTO As numeric(12,2) = NULL,	@PDF_NF_FORNEC As image = NULL,	@MUDOU_SERIE As bit,	@CONFIG_GARANTIA As bit,	@QTDE_DIAS_GARANTIA As int = NULL,	@DATA_INICIO_GARANTIA As datetime = NULL,	@DATA_TERMINO_GARANTIA As datetime = NULL,	@ID_OCORRENCIA As int = NULL,	@ID_EMPRESA As intASBEGINUPDATE CG_OS_ITEM SET	desc_equipamento = @desc_equipamento,	serie = @serie,	modelo = @modelo,	protocolo = @protocolo,	previsao_retorno = @previsao_retorno,	data_retorno = @data_retorno,	desc_defeito = @desc_defeito,	conserto_ok = @conserto_ok,	nf_fornec = @nf_fornec,	serie_nf_fornec = @serie_nf_fornec,	emissao_nf_fornec = @emissao_nf_fornec,	obs_retorno = @obs_retorno,	id_responsavel_ret = @id_responsavel_ret,	xml_nf_fornec = @xml_nf_fornec,	laudo_fornec = @laudo_fornec,	user_ins = @user_ins,	data_ins = @data_ins,	user_upd = @user_upd,	data_upd = @data_upd,	garantia = @garantia,	recebido = @recebido,	valor_conserto = @valor_conserto,	pdf_nf_fornec = @pdf_nf_fornec,	mudou_serie = @mudou_serie,	config_garantia = @config_garantia,	qtde_dias_garantia = @qtde_dias_garantia,	data_inicio_garantia = @data_inicio_garantia,	data_termino_garantia = @data_termino_garantia,	id_ocorrencia = @id_ocorrencia,	id_empresa = @id_empresaWHERE	ID_OS = @ID_OS AND	ITEM_ID = @ITEM_ID AND	ID_EQUIPAMENTO = @ID_EQUIPAMENTOENDGO------------------------------------------------------------