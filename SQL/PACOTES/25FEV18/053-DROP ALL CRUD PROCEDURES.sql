IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_pedido_compra_peca')
	DROP PROCEDURE spIns_Cg_pedido_compra_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_pedido_compra_peca')
	DROP PROCEDURE spUpd_Cg_pedido_compra_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_pedido_compra_peca')
	DROP PROCEDURE spDel_Cg_pedido_compra_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_pedido_compra_peca_item')
	DROP PROCEDURE spIns_Cg_pedido_compra_peca_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_pedido_compra_peca_item')
	DROP PROCEDURE spUpd_Cg_pedido_compra_peca_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_pedido_compra_peca_item')
	DROP PROCEDURE spDel_Cg_pedido_compra_peca_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_tabelas_pesquisa_dinamica')
	DROP PROCEDURE spIns_Cg_tabelas_pesquisa_dinamica

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_tabelas_pesquisa_dinamica')
	DROP PROCEDURE spUpd_Cg_tabelas_pesquisa_dinamica

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_tabelas_pesquisa_dinamica')
	DROP PROCEDURE spDel_Cg_tabelas_pesquisa_dinamica

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_parametro_pesquisa_dinamica')
	DROP PROCEDURE spIns_Cg_parametro_pesquisa_dinamica

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_area')
	DROP PROCEDURE spIns_Cg_area

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_area')
	DROP PROCEDURE spUpd_Cg_area

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_area')
	DROP PROCEDURE spDel_Cg_area

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_movimento_chip_inativo')
	DROP PROCEDURE spIns_Cg_movimento_chip_inativo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_movimento_chip_inativo')
	DROP PROCEDURE spUpd_Cg_movimento_chip_inativo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_movimento_chip_inativo')
	DROP PROCEDURE spDel_Cg_movimento_chip_inativo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_movimento_chip_inativo_item')
	DROP PROCEDURE spIns_Cg_movimento_chip_inativo_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_movimento_chip_inativo_item')
	DROP PROCEDURE spUpd_Cg_movimento_chip_inativo_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_movimento_chip_inativo_item')
	DROP PROCEDURE spDel_Cg_movimento_chip_inativo_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_acesso')
	DROP PROCEDURE spUpd_Cg_acesso

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_alocacao')
	DROP PROCEDURE spUpd_Cg_alocacao

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_cargo')
	DROP PROCEDURE spUpd_Cg_cargo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_chip')
	DROP PROCEDURE spUpd_Cg_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_devolucao_chip')
	DROP PROCEDURE spUpd_Cg_devolucao_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_devolucao_chip_item')
	DROP PROCEDURE spUpd_Cg_devolucao_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_ocorrencia')
	DROP PROCEDURE spIns_Cg_ocorrencia

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_devolucao_equipamento')
	DROP PROCEDURE spUpd_Cg_devolucao_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_ocorrencia')
	DROP PROCEDURE spUpd_Cg_ocorrencia

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_devolucao_equipamento_item')
	DROP PROCEDURE spUpd_Cg_devolucao_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_ocorrencia')
	DROP PROCEDURE spDel_Cg_ocorrencia

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_entrada_chip')
	DROP PROCEDURE spUpd_Cg_entrada_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_entrada_chip_item')
	DROP PROCEDURE spUpd_Cg_entrada_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_entrada_equipamento')
	DROP PROCEDURE spUpd_Cg_entrada_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_entrada_equipamento_item')
	DROP PROCEDURE spUpd_Cg_entrada_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_equipamento')
	DROP PROCEDURE spUpd_Cg_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_equipamento_vs_chip')
	DROP PROCEDURE spUpd_Cg_equipamento_vs_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_follow_up')
	DROP PROCEDURE spUpd_Cg_follow_up

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_fornecedor')
	DROP PROCEDURE spUpd_Cg_fornecedor

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_loja')
	DROP PROCEDURE spUpd_Cg_loja

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_movimento_equipamento_inativo')
	DROP PROCEDURE spIns_Cg_movimento_equipamento_inativo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_modulo')
	DROP PROCEDURE spUpd_Cg_modulo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_movimento_equipamento_inativo_item')
	DROP PROCEDURE spIns_Cg_movimento_equipamento_inativo_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_motivo')
	DROP PROCEDURE spUpd_Cg_motivo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_movimento_equipamento_inativo')
	DROP PROCEDURE spDel_Cg_movimento_equipamento_inativo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_movimento_chip')
	DROP PROCEDURE spUpd_Cg_movimento_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_movimento_equipamento_inativo')
	DROP PROCEDURE spUpd_Cg_movimento_equipamento_inativo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_movimento_chip_item')
	DROP PROCEDURE spUpd_Cg_movimento_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_movimento_equipamento_inativo_item')
	DROP PROCEDURE spUpd_Cg_movimento_equipamento_inativo_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_movimento_equipamento')
	DROP PROCEDURE spUpd_Cg_movimento_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_movimento_equipamento_inativo_item')
	DROP PROCEDURE spDel_Cg_movimento_equipamento_inativo_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_movimento_equipamento_item')
	DROP PROCEDURE spUpd_Cg_movimento_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_movimento_equipamento_quarentena')
	DROP PROCEDURE spDel_Cg_movimento_equipamento_quarentena

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_operadora')
	DROP PROCEDURE spUpd_Cg_operadora

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_movimento_equipamento_quarentena_item')
	DROP PROCEDURE spDel_Cg_movimento_equipamento_quarentena_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_os')
	DROP PROCEDURE spUpd_Cg_os

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_movimento_equipamento_quarentena')
	DROP PROCEDURE spIns_Cg_movimento_equipamento_quarentena

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_os_item')
	DROP PROCEDURE spUpd_Cg_os_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_movimento_equipamento_quarentena_item')
	DROP PROCEDURE spIns_Cg_movimento_equipamento_quarentena_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_os_PDF_NF_TRANSP')
	DROP PROCEDURE spUpd_Cg_os_PDF_NF_TRANSP

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_os_retorno')
	DROP PROCEDURE spUpd_Cg_os_retorno

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_movimento_equipamento_quarentena')
	DROP PROCEDURE spUpd_Cg_movimento_equipamento_quarentena

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_os_PDF_NF_TS')
	DROP PROCEDURE spUpd_Cg_os_PDF_NF_TS

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_os_retorno_pdf')
	DROP PROCEDURE spUpd_Cg_os_retorno_pdf

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_movimento_equipamento_quarentena_item')
	DROP PROCEDURE spUpd_Cg_movimento_equipamento_quarentena_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_responsavel')
	DROP PROCEDURE spUpd_Cg_responsavel

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_acesso')
	DROP PROCEDURE spDel_Cg_acesso

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_sequencial')
	DROP PROCEDURE spUpd_Cg_sequencial

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_alocacao')
	DROP PROCEDURE spDel_Cg_alocacao

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_status')
	DROP PROCEDURE spUpd_Cg_status

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_cargo')
	DROP PROCEDURE spDel_Cg_cargo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_status_os')
	DROP PROCEDURE spUpd_Cg_status_os

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_chip')
	DROP PROCEDURE spDel_Cg_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_tipo_equipamento')
	DROP PROCEDURE spUpd_Cg_tipo_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_devolucao_chip')
	DROP PROCEDURE spDel_Cg_devolucao_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_tipo_servico')
	DROP PROCEDURE spUpd_Cg_tipo_servico

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_devolucao_chip_item')
	DROP PROCEDURE spDel_Cg_devolucao_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_os_PDF_NF_Fornec')
	DROP PROCEDURE spUpd_Cg_os_PDF_NF_Fornec

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_usuario')
	DROP PROCEDURE spUpd_Cg_usuario

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_devolucao_equipamento')
	DROP PROCEDURE spDel_Cg_devolucao_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_devolucao_equipamento_item')
	DROP PROCEDURE spDel_Cg_devolucao_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_entrada_chip')
	DROP PROCEDURE spDel_Cg_entrada_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_entrada_chip_item')
	DROP PROCEDURE spDel_Cg_entrada_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_entrada_equipamento')
	DROP PROCEDURE spDel_Cg_entrada_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_entrada_equipamento_item')
	DROP PROCEDURE spDel_Cg_entrada_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_equipamento')
	DROP PROCEDURE spDel_Cg_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_equipamento_vs_chip')
	DROP PROCEDURE spDel_Cg_equipamento_vs_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_transito')
	DROP PROCEDURE spIns_Cg_transito

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_follow_up')
	DROP PROCEDURE spDel_Cg_follow_up

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_transito')
	DROP PROCEDURE spUpd_Cg_transito

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_fornecedor')
	DROP PROCEDURE spDel_Cg_fornecedor

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_transito')
	DROP PROCEDURE spDel_Cg_transito

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_loja')
	DROP PROCEDURE spDel_Cg_loja

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_modulo')
	DROP PROCEDURE spDel_Cg_modulo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_motivo')
	DROP PROCEDURE spDel_Cg_motivo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_movimento_chip')
	DROP PROCEDURE spDel_Cg_movimento_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_movimento_chip_item')
	DROP PROCEDURE spDel_Cg_movimento_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_movimento_equipamento')
	DROP PROCEDURE spDel_Cg_movimento_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_movimento_equipamento_item')
	DROP PROCEDURE spDel_Cg_movimento_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_operadora')
	DROP PROCEDURE spDel_Cg_operadora

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_os')
	DROP PROCEDURE spDel_Cg_os

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_os_item')
	DROP PROCEDURE spDel_Cg_os_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_responsavel')
	DROP PROCEDURE spDel_Cg_responsavel

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_sequencial')
	DROP PROCEDURE spDel_Cg_sequencial

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_status')
	DROP PROCEDURE spDel_Cg_status

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_status_os')
	DROP PROCEDURE spDel_Cg_status_os

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_tipo_equipamento')
	DROP PROCEDURE spDel_Cg_tipo_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_tipo_servico')
	DROP PROCEDURE spDel_Cg_tipo_servico

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_usuario')
	DROP PROCEDURE spDel_Cg_usuario

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_acesso')
	DROP PROCEDURE spIns_Cg_acesso

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_alocacao')
	DROP PROCEDURE spIns_Cg_alocacao

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_cargo')
	DROP PROCEDURE spIns_Cg_cargo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_chip')
	DROP PROCEDURE spIns_Cg_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_devolucao_chip')
	DROP PROCEDURE spIns_Cg_devolucao_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_modelos')
	DROP PROCEDURE spIns_Cg_modelos

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_devolucao_chip_item')
	DROP PROCEDURE spIns_Cg_devolucao_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_modelos')
	DROP PROCEDURE spUpd_Cg_modelos

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_devolucao_equipamento')
	DROP PROCEDURE spIns_Cg_devolucao_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_modelos')
	DROP PROCEDURE spDel_Cg_modelos

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_devolucao_equipamento_item')
	DROP PROCEDURE spIns_Cg_devolucao_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_entrada_chip')
	DROP PROCEDURE spIns_Cg_entrada_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_entrada_chip_item')
	DROP PROCEDURE spIns_Cg_entrada_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_entrada_equipamento')
	DROP PROCEDURE spIns_Cg_entrada_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_entrada_equipamento_item')
	DROP PROCEDURE spIns_Cg_entrada_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_categoria')
	DROP PROCEDURE spIns_Cg_categoria

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_equipamento')
	DROP PROCEDURE spIns_Cg_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_categoria')
	DROP PROCEDURE spUpd_Cg_categoria

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_equipamento_vs_chip')
	DROP PROCEDURE spIns_Cg_equipamento_vs_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_categoria')
	DROP PROCEDURE spDel_Cg_categoria

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_follow_up')
	DROP PROCEDURE spIns_Cg_follow_up

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_finalidade')
	DROP PROCEDURE spIns_Cg_finalidade

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_fornecedor')
	DROP PROCEDURE spIns_Cg_fornecedor

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_finalidade')
	DROP PROCEDURE spUpd_Cg_finalidade

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_loja')
	DROP PROCEDURE spIns_Cg_loja

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_finalidade')
	DROP PROCEDURE spDel_Cg_finalidade

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_modulo')
	DROP PROCEDURE spIns_Cg_modulo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_marca')
	DROP PROCEDURE spIns_Cg_marca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_motivo')
	DROP PROCEDURE spIns_Cg_motivo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_marca')
	DROP PROCEDURE spUpd_Cg_marca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_movimento_chip')
	DROP PROCEDURE spIns_Cg_movimento_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_marca')
	DROP PROCEDURE spDel_Cg_marca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_movimento_chip_item')
	DROP PROCEDURE spIns_Cg_movimento_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_peca')
	DROP PROCEDURE spIns_Cg_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_movimento_equipamento')
	DROP PROCEDURE spIns_Cg_movimento_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_peca')
	DROP PROCEDURE spUpd_Cg_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_movimento_equipamento_item')
	DROP PROCEDURE spIns_Cg_movimento_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_Cg_peca')
	DROP PROCEDURE spDel_Cg_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_operadora')
	DROP PROCEDURE spIns_Cg_operadora

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_os')
	DROP PROCEDURE spIns_Cg_os

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_Cg_Peca_Foto')
	DROP PROCEDURE spUpd_Cg_Peca_Foto

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_os_item')
	DROP PROCEDURE spIns_Cg_os_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_responsavel')
	DROP PROCEDURE spIns_Cg_responsavel

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_sequencial')
	DROP PROCEDURE spIns_Cg_sequencial

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_status')
	DROP PROCEDURE spIns_Cg_status

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_status_os')
	DROP PROCEDURE spIns_Cg_status_os

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_tipo_equipamento')
	DROP PROCEDURE spIns_Cg_tipo_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_tipo_servico')
	DROP PROCEDURE spIns_Cg_tipo_servico

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_Cg_usuario')
	DROP PROCEDURE spIns_Cg_usuario
