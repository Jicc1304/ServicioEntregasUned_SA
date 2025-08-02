/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */
using System;
using Datos;
using Entidades;
namespace Negocio
{
   //Declaracion de la clase 'NegocioTipoArticulo' y sus metodos
   public class NegocioTipoArticulo
   {

      // Metodo Para registrar tipos de articulos
      public static string RegistrarTipoArticulo(TipoArticulo tipoArt)
      {
         try
         {
            // Se valida que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(tipoArt.NombreTipoArticulo) ||
                string.IsNullOrWhiteSpace(tipoArt.DescripcionTipoArticulo))
            {
               return "Error: Todos los campos son requeridos.";
            }

            // Se valida que el ID esté entre 1 y 10
            if (tipoArt.IdTipoArticulo < 1 || tipoArt.IdTipoArticulo > 10)
            {
               return "Error: El ID debe ser un número entre 1 y 10.";
            }

            // Se valida que el ID no esté repetido
            TipoArticulo[] existentes = DatosTipoArticulo.ObtenerTodos();
            foreach (var existente in existentes)
            {
               if (existente.IdTipoArticulo == tipoArt.IdTipoArticulo)
               {
                  return "Error: Ya existe un tipo de artículo con ese ID.";
               }
            }

            // Se intenta agregar
            bool agregado = DatosTipoArticulo.AgregarTipoArticulo(tipoArt);
            if (agregado)
            {
               return "Se ha registrado el tipo de artículo con éxito.";
            }
            else
            {
               return "No se pueden agregar más registros. Se ha llegado al límite.";
            }
         }
         catch (Exception ex)
         {
            return "Error: No fue posible registrar el tipo de artículo. Revise los requisitos. " + ex.Message;
         }
      }

      // Metodo para consultar  todos los tipos de articulos
      public static TipoArticulo[] Consultar()
      {
         return DatosTipoArticulo.ObtenerTodos();
      }
   }
}


