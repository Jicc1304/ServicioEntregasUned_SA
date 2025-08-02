/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;



namespace Negocio
{
   // Declaracion de la clase 'NegocioArticulo'
   public class NegocioArticulo
   {
      // Metodo para registrar articulos
      public static string RegistrarArticulo(Articulo art)
      {
         try
         {
            // Se valida que los campos sean validos
            if (string.IsNullOrWhiteSpace(art.NombreArticulo) ||
                art.TipoArt == null ||
                art.ValorArticulo <= 0 ||
                art.InventarioArticulo < 0)
            {
               return "Error: Todos los campos deben ser válidos y completos.";
            }

            if (art.IdArticulo < 1 || art.IdArticulo > 20)
            {
               return "Error: El ID debe estar entre 1 y 20.";
            }

            //  De Valida que el ID no esté repetido
            Articulo[] existentes = DatosArticulo.ObtenerTodos();
            foreach (var existente in existentes)
            {
               if (existente != null && existente.IdArticulo == art.IdArticulo)
               {
                  return "Error: Ya existe un artículo con ese ID.";
               }
            }

            // Intenta agregar el artículo
            bool agregado = DatosArticulo.AgregarArticulo(art);
            return agregado
                ? "Se ha registrado el artículo con éxito."
                : "No se pueden agregar más registros. Se ha alcanzado el límite.";
         }
         catch (Exception ex)
         {
            return "Error: No fue posible registrar el artículo. Revise los requisitos. " + ex.Message;
         }
      }

      // Método para consultar todos los artículos
      public static Articulo[] Consultar()
      {
         return DatosArticulo.ObtenerTodos();
      }
   }
}