select object_name(id) COMANDO 
from syscolumns where name = 'id_empresa' and id NOT IN (object_id('CG_EMPRESA'),object_id('CG_OS'),object_id('CG_OS_ITEM'))

select object_name(id) COMANDO 
from syscolumns where name = 'ID_CONTROLE'

object_id('CG_LOJA')
object_id('CG_PECA')
object_id('CG_EQUIPAMENTO')