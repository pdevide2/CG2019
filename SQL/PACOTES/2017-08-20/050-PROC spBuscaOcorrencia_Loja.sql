CREATE PROCEDURE spBuscaOcorrencia_Loja 
(
@ID_LOJA INT 
)
AS
select 
    a.ID_OCORRENCIA, 
    a.DATA_OCORRENCIA, 
    a.DESCRICAO, 
    a.ID_EQUIPAMENTO, 
    d.DESC_EQUIPAMENTO,
    a.SERIE, 
    d.MODELO,
    a.ID_LOJA, 
    b.NOME,
    b.CODIGO,
    a.HISTORICO, 
    a.USER_INS, 
    a.DATA_INS, 
    a.USER_UPD, 
    a.DATA_UPD, 
    a.OS_VINCULADA
from cg_ocorrencia a
left join cg_loja b 
    on b.ID_LOJA = a.ID_LOJA
left join CG_AREA c
    on c.ID_AREA = b.ID_AREA
left join cg_equipamento d
    on d.ID_EQUIPAMENTO = a.ID_EQUIPAMENTO
where a.ID_LOJA = @ID_LOJA ;
