alter table cg_peca 
add serie varchar(30) null,
	modelo varchar(30) null
go

update cg_peca 
set serie = (select dbo.FX_PROTOCOLO(id_peca))
go

alter table cg_peca
add constraint UNQ_SERIE_PECA UNIQUE (serie)
go

