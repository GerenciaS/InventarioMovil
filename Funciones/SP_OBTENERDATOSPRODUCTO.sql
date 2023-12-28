USE [BDRotativos]
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENERDATOSPRODUCTO]    Script Date: 28/12/2023 01:28:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: David Martinez Burgos
-- Create date: 30/Nov/2023
-- Description: Procedimiento para realizar consulta de codigo capturado en la toma de inventario.
-- =============================================

CREATE PROCEDURE [dbo].[SP_OBTENERDATOSPRODUCTO]
@Establecimiento VARCHAR(5),
@Producto VARCHAR(10)

AS
BEGIN

SET NOCOUNT ON;

    BEGIN TRAN Tadd
	     BEGIN TRY
	     
			BEGIN

           SELECT prodestab.cod_prod,prodestab.codigo_barras_pieza AS barras,prodestab.descripcion,CAST(prodestab.costo AS decimal(8,2)) AS costo,CAST(prodestab.precio as decimal(8,2)) as precio FROM prodestab
			LEFT JOIN barras_adicionales ON prodestab.cod_prod=barras_adicionales.cod_prod
			WHERE prodestab.cod_estab=@Establecimiento and (prodestab.cod_prod=@Producto or prodestab.codigo_barras_pieza=@Producto)

		END

		COMMIT TRAN Tadd
    
	END TRY
	BEGIN CATCH
    
    ROLLBACK TRAN Tadd
    END CATCH
END