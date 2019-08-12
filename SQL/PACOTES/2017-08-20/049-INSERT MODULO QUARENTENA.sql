USE [dbCG]
GO

INSERT INTO [dbo].[CG_MODULO]
           ([ID_MODULO]
           ,[DESC_MODULO]
           ,[USER_INS]
           ,[DATA_INS]
           ,[USER_UPD]
           ,[DATA_UPD])
     VALUES
           (55,
           'MOVIMENTAR PARA QUARENTENA',
           1,
           GETDATE(),
           1,
           GETDATE())
GO


  INSERT INTO CG_SEQUENCIAL (TABELA, KEYID, USER_INS, DATA_INS, USER_UPD, DATA_UPD)
  VALUES ('CG_MOVIMENTO_EQUIPAMENTO_QUARENTENA',0, 1, GETDATE(), 1, GETDATE())

  GO
