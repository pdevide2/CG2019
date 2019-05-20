
SELECT TAB.* 
FROM (
SELECT Cast(0 AS INT) AS ID_HISTORICO, 
       A.codigo, 
       A.id_loja, 
       A.sigla, 
       A.nome, 
       A.endereco, 
       A.complemento, 
       A.cep, 
       A.cidade, 
       A.bairro, 
       A.uf, 
       A.id_tipo_local, 
	   D.DESC_ALOCACAO,
       A.id_responsavel, 
	   R.NOME AS RESPONSAVEL,
       A.telefone, 
       A.celular, 
       A.loja_fisica, 
       A.parceria, 
       A.id_area, 
	   C.DESC_AREA,
       A.id_empresa, 
	   E.NOME_EMPRESA,
       A.id_tipo_local_estoque, 
	   L.DESC_TIPO_LOCAL_ESTOQUE,	
       A.telefone2, 
       A.celular2, 
       A.celular3, 
       A.celular4, 
       A.celular5, 
       A.celular6, 
       A.inativo, 
       A.ultima_atualizacao, 
       A.inicio_vigencia, 
       A.final_vigencia 
FROM   cg_loja A
LEFT JOIN CG_AREA C ON C.ID_AREA=A.ID_AREA AND C.ID_EMPRESA = A.ID_EMPRESA
LEFT JOIN CG_EMPRESA E ON E.ID_EMPRESA=A.ID_EMPRESA
LEFT JOIN CG_TIPO_LOCAL_ESTOQUE L ON L.ID_TIPO_LOCAL_ESTOQUE = A.ID_TIPO_LOCAL_ESTOQUE      
LEFT JOIN CG_RESPONSAVEL R ON R.ID_RESPONSAVEL = A.ID_RESPONSAVEL
LEFT JOIN CG_ALOCACAO D ON D.ID_ALOCACAO = A.ID_TIPO_LOCAL

UNION ALL 

SELECT B.id_historico, 
       B.codigo, 
       B.id_loja, 
       B.sigla, 
       B.nome, 
       B.endereco, 
       B.complemento, 
       B.cep, 
       B.cidade, 
       B.bairro, 
       B.uf, 
       B.id_tipo_local, 
	   D.DESC_ALOCACAO,
       B.id_responsavel, 
	   R.NOME AS RESPONSAVEL,
       B.telefone, 
       B.celular, 
       B.loja_fisica, 
       B.parceria, 
       B.id_area, 
	   C.DESC_AREA,
       B.id_empresa, 
	   E.NOME_EMPRESA,
       B.id_tipo_local_estoque, 
	   L.DESC_TIPO_LOCAL_ESTOQUE,	
       B.telefone2, 
       B.celular2, 
       B.celular3, 
       B.celular4, 
       B.celular5, 
       B.celular6, 
       B.inativo, 
       B.ultima_atualizacao, 
       B.inicio_vigencia, 
       B.final_vigencia 
FROM   cg_loja_historico B
LEFT JOIN CG_AREA C ON C.ID_AREA=B.ID_AREA  AND C.ID_EMPRESA = B.ID_EMPRESA
LEFT JOIN CG_EMPRESA E ON E.ID_EMPRESA=B.ID_EMPRESA
LEFT JOIN CG_TIPO_LOCAL_ESTOQUE L ON L.ID_TIPO_LOCAL_ESTOQUE = B.ID_TIPO_LOCAL_ESTOQUE       
LEFT JOIN CG_RESPONSAVEL R ON R.ID_RESPONSAVEL = B.ID_RESPONSAVEL
LEFT JOIN CG_ALOCACAO D ON D.ID_ALOCACAO = B.ID_TIPO_LOCAL) AS TAB
ORDER  BY TAB.ID_EMPRESA ASC,
			TAB.ID_LOJA ASC, 
			TAB.ID_HISTORICO ASC 


