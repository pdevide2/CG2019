IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_acesso')
DROP PROCEDURE spIns_cg_acesso

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_alocacao')
DROP PROCEDURE spIns_cg_alocacao

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_cargo')
DROP PROCEDURE spIns_cg_cargo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_chip')
DROP PROCEDURE spIns_cg_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_area')
DROP PROCEDURE spIns_cg_area

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_entrada_chip')
DROP PROCEDURE spIns_cg_entrada_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_entrada_chip_item')
DROP PROCEDURE spIns_cg_entrada_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_entrada_equipamento')
DROP PROCEDURE spIns_cg_entrada_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_ocorrencia')
DROP PROCEDURE spIns_cg_ocorrencia

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_entrada_equipamento_item')
DROP PROCEDURE spIns_cg_entrada_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_equipamento')
DROP PROCEDURE spIns_cg_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_equipamento_vs_chip')
DROP PROCEDURE spIns_cg_equipamento_vs_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_estoque_chip')
DROP PROCEDURE spIns_cg_estoque_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_estoque_equipamento')
DROP PROCEDURE spIns_cg_estoque_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_follow_up')
DROP PROCEDURE spIns_cg_follow_up

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_fornecedor')
DROP PROCEDURE spIns_cg_fornecedor

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_loja')
DROP PROCEDURE spIns_cg_loja

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_motivo')
DROP PROCEDURE spIns_cg_motivo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_equipamento_historico_serie')
DROP PROCEDURE spIns_cg_equipamento_historico_serie

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_operadora')
DROP PROCEDURE spIns_cg_operadora

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_transito')
DROP PROCEDURE spIns_cg_transito

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_responsavel')
DROP PROCEDURE spIns_cg_responsavel

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_marca')
DROP PROCEDURE spIns_cg_marca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_mov_transito_chip')
DROP PROCEDURE spIns_cg_mov_transito_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_finalidade')
DROP PROCEDURE spIns_cg_finalidade

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_status')
DROP PROCEDURE spIns_cg_status

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_status_os')
DROP PROCEDURE spIns_cg_status_os

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_categoria')
DROP PROCEDURE spIns_cg_categoria

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_modelos')
DROP PROCEDURE spIns_cg_modelos

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_tipo_equipamento')
DROP PROCEDURE spIns_cg_tipo_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_tipo_servico')
DROP PROCEDURE spIns_cg_tipo_servico

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_peca')
DROP PROCEDURE spIns_cg_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_usuario')
DROP PROCEDURE spIns_cg_usuario

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_mov_transito_equipamento')
DROP PROCEDURE spIns_cg_mov_transito_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_romaneio_estoque')
DROP PROCEDURE spIns_romaneio_estoque

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_romaneio_estoque_item')
DROP PROCEDURE spIns_romaneio_estoque_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_pedido_compra_peca')
DROP PROCEDURE spIns_cg_pedido_compra_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spIns_cg_pedido_compra_peca_item')
DROP PROCEDURE spIns_cg_pedido_compra_peca_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_acesso')
DROP PROCEDURE spUpd_cg_acesso

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_alocacao')
DROP PROCEDURE spUpd_cg_alocacao

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_cargo')
DROP PROCEDURE spUpd_cg_cargo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_chip')
DROP PROCEDURE spUpd_cg_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_area')
DROP PROCEDURE spUpd_cg_area

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_entrada_chip')
DROP PROCEDURE spUpd_cg_entrada_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_entrada_chip_item')
DROP PROCEDURE spUpd_cg_entrada_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_entrada_equipamento')
DROP PROCEDURE spUpd_cg_entrada_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_ocorrencia')
DROP PROCEDURE spUpd_cg_ocorrencia

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_entrada_equipamento_item')
DROP PROCEDURE spUpd_cg_entrada_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_equipamento')
DROP PROCEDURE spUpd_cg_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_equipamento_vs_chip')
DROP PROCEDURE spUpd_cg_equipamento_vs_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_estoque_chip')
DROP PROCEDURE spUpd_cg_estoque_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_estoque_equipamento')
DROP PROCEDURE spUpd_cg_estoque_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_follow_up')
DROP PROCEDURE spUpd_cg_follow_up

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_fornecedor')
DROP PROCEDURE spUpd_cg_fornecedor

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_loja')
DROP PROCEDURE spUpd_cg_loja

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_motivo')
DROP PROCEDURE spUpd_cg_motivo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_equipamento_historico_serie')
DROP PROCEDURE spUpd_cg_equipamento_historico_serie

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_operadora')
DROP PROCEDURE spUpd_cg_operadora

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_transito')
DROP PROCEDURE spUpd_cg_transito

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_responsavel')
DROP PROCEDURE spUpd_cg_responsavel

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_marca')
DROP PROCEDURE spUpd_cg_marca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_mov_transito_chip')
DROP PROCEDURE spUpd_cg_mov_transito_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_finalidade')
DROP PROCEDURE spUpd_cg_finalidade

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_status')
DROP PROCEDURE spUpd_cg_status

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_status_os')
DROP PROCEDURE spUpd_cg_status_os

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_categoria')
DROP PROCEDURE spUpd_cg_categoria

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_modelos')
DROP PROCEDURE spUpd_cg_modelos

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_tipo_equipamento')
DROP PROCEDURE spUpd_cg_tipo_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_tipo_servico')
DROP PROCEDURE spUpd_cg_tipo_servico

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_peca')
DROP PROCEDURE spUpd_cg_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_usuario')
DROP PROCEDURE spUpd_cg_usuario

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_mov_transito_equipamento')
DROP PROCEDURE spUpd_cg_mov_transito_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_romaneio_estoque')
DROP PROCEDURE spUpd_romaneio_estoque

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_romaneio_estoque_item')
DROP PROCEDURE spUpd_romaneio_estoque_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_pedido_compra_peca')
DROP PROCEDURE spUpd_cg_pedido_compra_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spUpd_cg_pedido_compra_peca_item')
DROP PROCEDURE spUpd_cg_pedido_compra_peca_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_acesso')
DROP PROCEDURE spDel_cg_acesso

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_alocacao')
DROP PROCEDURE spDel_cg_alocacao

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_cargo')
DROP PROCEDURE spDel_cg_cargo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_chip')
DROP PROCEDURE spDel_cg_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_area')
DROP PROCEDURE spDel_cg_area

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_entrada_chip')
DROP PROCEDURE spDel_cg_entrada_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_entrada_chip_item')
DROP PROCEDURE spDel_cg_entrada_chip_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_entrada_equipamento')
DROP PROCEDURE spDel_cg_entrada_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_ocorrencia')
DROP PROCEDURE spDel_cg_ocorrencia

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_entrada_equipamento_item')
DROP PROCEDURE spDel_cg_entrada_equipamento_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_equipamento')
DROP PROCEDURE spDel_cg_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_equipamento_vs_chip')
DROP PROCEDURE spDel_cg_equipamento_vs_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_estoque_chip')
DROP PROCEDURE spDel_cg_estoque_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_estoque_equipamento')
DROP PROCEDURE spDel_cg_estoque_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_follow_up')
DROP PROCEDURE spDel_cg_follow_up

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_fornecedor')
DROP PROCEDURE spDel_cg_fornecedor

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_loja')
DROP PROCEDURE spDel_cg_loja

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_motivo')
DROP PROCEDURE spDel_cg_motivo

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_equipamento_historico_serie')
DROP PROCEDURE spDel_cg_equipamento_historico_serie

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_operadora')
DROP PROCEDURE spDel_cg_operadora

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_transito')
DROP PROCEDURE spDel_cg_transito

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_responsavel')
DROP PROCEDURE spDel_cg_responsavel

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_marca')
DROP PROCEDURE spDel_cg_marca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_mov_transito_chip')
DROP PROCEDURE spDel_cg_mov_transito_chip

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_finalidade')
DROP PROCEDURE spDel_cg_finalidade

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_status')
DROP PROCEDURE spDel_cg_status

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_status_os')
DROP PROCEDURE spDel_cg_status_os

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_categoria')
DROP PROCEDURE spDel_cg_categoria

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_modelos')
DROP PROCEDURE spDel_cg_modelos

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_tipo_equipamento')
DROP PROCEDURE spDel_cg_tipo_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_tipo_servico')
DROP PROCEDURE spDel_cg_tipo_servico

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_peca')
DROP PROCEDURE spDel_cg_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_usuario')
DROP PROCEDURE spDel_cg_usuario

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_mov_transito_equipamento')
DROP PROCEDURE spDel_cg_mov_transito_equipamento

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_romaneio_estoque')
DROP PROCEDURE spDel_romaneio_estoque

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_romaneio_estoque_item')
DROP PROCEDURE spDel_romaneio_estoque_item

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_pedido_compra_peca')
DROP PROCEDURE spDel_cg_pedido_compra_peca

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE TYPE = 'P' AND NAME = 'spDel_cg_pedido_compra_peca_item')
DROP PROCEDURE spDel_cg_pedido_compra_peca_item

