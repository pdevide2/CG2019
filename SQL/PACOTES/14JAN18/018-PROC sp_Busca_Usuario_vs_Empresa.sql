CREATE PROCEDURE sp_Busca_Usuario_vs_Empresa  
(
@ID_EMPRESA AS INT 
)
AS
BEGIN
	SELECT CAST(1 AS BIT) AS SELECAO, T1.ID_USUARIO, T2.APELIDO, T2.NOME, T1.ID_PERFIL
	from CG_EMPRESA_VS_USUARIOS T1
	INNER JOIN CG_USUARIO T2 ON T2.ID_USUARIO = T1.ID_USUARIO
	WHERE T1.ID_EMPRESA = @ID_EMPRESA
	UNION ALL
	SELECT CAST(0 AS BIT) AS SELECAO, T3.ID_USUARIO, T3.APELIDO, T3.NOME, CAST(null AS INT) AS ID_PERFIL
	FROM CG_USUARIO T3 
	WHERE T3.ID_USUARIO NOT IN (
		SELECT T4.ID_USUARIO FROM CG_EMPRESA_VS_USUARIOS T4 WHERE T4.ID_EMPRESA = @ID_EMPRESA)
END
