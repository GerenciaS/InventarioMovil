USE [BDRotativos]
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENERDATOSPRODUCTO2]    Script Date: 28/12/2023 01:50:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: David Martinez Burgos
-- Create date: 30/Nov/2023
-- Description: Procedimiento para realizar consulta de codigo capturado en la toma de inventario en case no estar.
-- en la ubicacion y conteo seleccionado.
-- =============================================

CREATE PROCEDURE [dbo].[SP_OBTENERDATOSPRODUCTO2]
@Establecimiento VARCHAR(5),
@Producto VARCHAR(10)

AS
BEGIN

SET NOCOUNT ON;

    BEGIN TRAN Tadd
	     BEGIN TRY
	     
			BEGIN

               SELECT prodestab.cod_prod, CASE WHEN barras_adicionales.codigo_barras_pieza='' THEN barras_adicionales.codigo_barras_unidad ELSE barras_adicionales.codigo_barras_pieza END AS barras,
			   prodestab.descripcion,prodestab.costo,prodestab.precio from prodestab 
			   left join barras_adicionales on prodestab.cod_prod=barras_adicionales.cod_prod 
			   where prodestab.cod_estab=@Establecimiento and (barras_adicionales.codigo_barras_pieza=@Producto or barras_adicionales.codigo_barras_unidad=@Producto)

		END

		COMMIT TRAN Tadd
    
	END TRY
	BEGIN CATCH
    
    ROLLBACK TRAN Tadd
    END CATCH
END