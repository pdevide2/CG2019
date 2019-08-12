USE [dbCG]
GO

INSERT INTO [dbo].[CG_LOJA]
           ([ID_LOJA]
           ,[SIGLA]
           ,[NOME]
           ,[ENDERECO]
           ,[COMPLEMENTO]
           ,[CEP]
           ,[CIDADE]
           ,[BAIRRO]
           ,[UF]
           ,[ID_TIPO_LOCAL]
           ,[ID_RESPONSAVEL]
           ,[USER_INS]
           ,[DATA_INS]
           ,[USER_UPD]
           ,[DATA_UPD]
           ,[CODIGO]
           ,[TELEFONE]
           ,[CELULAR]
           ,[LOJA_FISICA]
           ,[PARCERIA]
           ,[ID_AREA])
     VALUES
           (7,
           'QUARENTENA',
           'QUARENTENA',
           'MATRIZ',
           '',
           '',
           'SAO PAULO',
           'PENHA',
           'SP',
           1,
           1,
           1,
           GETDATE(),
           1,
           GETDATE(),
           '0007',
           '11999999999',
           '',
           0,
           0,
           0)



