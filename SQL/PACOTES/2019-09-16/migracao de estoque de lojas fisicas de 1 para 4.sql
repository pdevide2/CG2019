update a
set id_empresa = 4
from CG_ESTOQUE_EQUIPAMENTO a
inner join cg_loja b on b.ID_LOJA = a.ID_LOCAL
inner join CG_TIPO_LOCAL_ESTOQUE c on c.ID_TIPO_LOCAL_ESTOQUE = b.ID_TIPO_LOCAL_ESTOQUE
where a.id_empresa = 1 and b.ID_TIPO_LOCAL_ESTOQUE in (10)