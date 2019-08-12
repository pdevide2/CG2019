CREATE PROCEDURE spPesquisaSeriePos
    @id_equipamento int,
    @id_os int,
    @item_id int

as
begin
    select 
	   a.id_equipamento, 
	   a.SERIE,  
	   ISNULL(b.DATA_ALTERACAO,CAST(GETDATE() AS DATE)) AS DATA_ALTERACAO, 
	   b.ID_OS, 
	   b.ITEM_ID, 
	   ISNULL(b.SERIE_ANTERIOR, a.SERIE) AS SERIE_ANTERIOR,
	   ISNULL(b.SERIE_NOVA,'') AS SERIE_NOVA, 
	   ISNULL(b.MOTIVO_ALTERACAO,'') AS MOTIVO_ALTERACAO,
	   CAST( ISNULL(c.MUDOU_SERIE,0) AS BIT) AS MUDOU_SERIE
    from 
	   cg_equipamento a
    left join 
	   CG_EQUIPAMENTO_HISTORICO_SERIE b 
		  on b.ID_EQUIPAMENTO = a.ID_EQUIPAMENTO and b.ID_OS = @id_os and b.ITEM_ID = @item_id
    left join 
	   CG_OS_ITEM c
		  on c.ID_OS = b.ID_OS and c.ITEM_ID = b.ITEM_ID and c.ID_EQUIPAMENTO = b.ID_EQUIPAMENTO
    where a.id_equipamento = @id_equipamento 

end
go