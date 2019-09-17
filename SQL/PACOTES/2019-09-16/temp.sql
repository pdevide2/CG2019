/*
select 
'update CG_ESTOQUE_EQUIPAMENTO set id_local = 770, id_empresa = 4 where id_equipamento = ' + convert(varchar, id_equipamento) + ' ;'
from CG_ESTOQUE_EQUIPAMENTO a
inner join cg_loja b on b.ID_LOJA = a.ID_LOCAL
inner join CG_TIPO_LOCAL_ESTOQUE c on c.ID_TIPO_LOCAL_ESTOQUE = b.ID_TIPO_LOCAL_ESTOQUE
where a.id_empresa = 1 and b.ID_TIPO_LOCAL_ESTOQUE in (10)

--'update cg_estoque_chip set id_local = 1056, id_empresa = 8 where id_equipamento = ' + convert(varchar, id_equipamento) + ' ;'

select ','+char(39)+ltrim(rtrim(ID_AREA))+char(39) 
from cg_loja 
where id_empresa = 1 and ID_TIPO_LOCAL_ESTOQUE in (1,10) and id_area <> '0000'
group by ID_AREA

 


select * from cg_area where id_empresa = 1

select id_area, * from cg_loja where ID_EMPRESA=1


select a.*

from CG_ESTOQUE_EQUIPAMENTO a
inner join cg_loja b on b.ID_LOJA = a.ID_LOCAL
inner join CG_TIPO_LOCAL_ESTOQUE c on c.ID_TIPO_LOCAL_ESTOQUE = b.ID_TIPO_LOCAL_ESTOQUE
where a.id_empresa = 4 and b.ID_TIPO_LOCAL_ESTOQUE in (10)


select a.* from CG_ESTOQUE_EQUIPAMENTO a
inner join cg_loja b on b.ID_LOJA = a.ID_LOCAL
inner join CG_TIPO_LOCAL_ESTOQUE c on c.ID_TIPO_LOCAL_ESTOQUE = b.ID_TIPO_LOCAL_ESTOQUE
where a.id_empresa = 1 

*/


select 
'update cg_estoque_chip set id_local = 770, id_empresa = 4 where id_chip = ' + convert(varchar, id_chip) + ' ;'
from cg_estoque_chip where id_empresa = 1



