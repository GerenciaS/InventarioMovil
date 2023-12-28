
-- =============================================
-- Author: David Martinez Burgos
-- Create date: 30/Nov/2023
-- Description: Procedimiento para realizar consultar permisos de acceso de Usuario.
-- =============================================

CREATE PROCEDURE SP_BUSCAR_USUARIO
@Usuario VARCHAR(5),
@Establecimiento VARCHAR(10)

AS
BEGIN

SET NOCOUNT ON;

    BEGIN TRAN Tadd
	     BEGIN TRY
	     
			BEGIN

               SELECT usuarios.usuario,usuarios.nombre,usuarios.clave,usuarios.status,establecimientos_usuario.cod_estab,establecimientos.nombre,establecimientos.DB 
               FROM usuarios 
               INNER JOIN opciones_usuario ON usuarios.usuario=opciones_usuario.usuario 
               INNER JOIN establecimientos_usuario ON usuarios.usuario=establecimientos_usuario.usuario 
               INNER JOIN establecimientos ON establecimientos_usuario.cod_estab=establecimientos.cod_estab 
               WHERE usuarios.usuario=@Usuario and opciones_usuario.opcion='F017' and establecimientos_usuario.cod_estab=@Establecimiento and establecimientos_usuario.acceso='1'

		END

		COMMIT TRAN Tadd
    
	END TRY
	BEGIN CATCH
    
    ROLLBACK TRAN Tadd
    END CATCH
END