USE dbCG
GO

insert into CG_PARAMETRO_PESQUISA_DINAMICA
  (tabela, coluna, idcoluna, ordercol, chave, tipodado, coluna_filtro,apelido_coluna, mostra_coluna, coluna_filtro_inicial)
  values
  ('VW_CG_PECA', 'SERIE', 25, 25, 0, 'String', 1,'Serie', 1, 0),
  ('VW_CG_PECA', 'MODELO', 26, 26, 0, 'String', 1,'Modelo', 1, 0)
  GO
