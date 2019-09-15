DECLARE @id_empresa INT = 4

UPDATE CG_CHIP SET ID_EMPRESA  = 22 WHERE  id_empresa_old = @id_empresa 
--UPDATE CG_ENTRADA_CHIP SET ID_EMPRESA  = 4 WHERE  id_empresa_old = @id_empresa 
UPDATE CG_ENTRADA_CHIP_ITEM SET ID_EMPRESA  = 22 WHERE  id_empresa_old = @id_empresa 
--UPDATE CG_ENTRADA_EQUIPAMENTO SET ID_EMPRESA  = 4 WHERE  id_empresa_old = @id_empresa 
UPDATE CG_ENTRADA_EQUIPAMENTO_ITEM SET ID_EMPRESA  = 22 WHERE  id_empresa_old = @id_empresa 
UPDATE CG_EQUIPAMENTO SET ID_EMPRESA  =22 WHERE  id_empresa_old = @id_empresa 
UPDATE CG_FORNECEDOR SET ID_EMPRESA  = 22 WHERE  id_empresa_old = @id_empresa 
UPDATE CG_LOJA SET ID_EMPRESA  = 22 WHERE  id_empresa_old = @id_empresa and CODIGO <> '1103'
--UPDATE CG_OS SET ID_EMPRESA  = 22 WHERE  id_empresa_old = @id_empresa 
--UPDATE CG_OS_ITEM SET ID_EMPRESA  = 22 WHERE  id_empresa_old = @id_empresa 


--UPDATE CG_LOJA SET ID_EMPRESA  = 22 WHERE  id_empresa_old = 4 

select * from cg_area where id_empresa = 1

insert into cg_area 
select id_area, DESC_AREA, ID_RESPONSAVEL, USER_INS, DATA_INS, USER_UPD, DATA_UPD, 22 as ID_EMPRESA
from cg_area where id_empresa = 1 and id_area <> '0000'
