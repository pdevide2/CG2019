CREATE PROCEDURE spUpd_Cg_concerto	@ID_CONCERTO As int,	@DESC_CONCERTO As varchar(75)ASBEGINUPDATE CG_CONCERTO SET	desc_concerto = @desc_concertoWHERE	ID_CONCERTO = @ID_CONCERTOEND------------------------------------------------------------