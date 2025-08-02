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
using Entidades;

namespace Datos
{
   // Declaracion de la clase 'DatosTipoArticulos' arreglos y metodos
   public class DatosTipoArticulo
   {
      //Declaracion del arreglo de 10 posiciones
      private static TipoArticulo[] tipoArticulos = new TipoArticulo[10];

      //Declaracion de contador para los datos ingreados
      private static int Contador = 0;

      //Metodo para agregar  tipos de articulos
      public static bool AgregarTipoArticulo(TipoArticulo tipoArt)
      {
         if (Contador >= tipoArticulos.Length)
         {
            return false;// Arreglo lleno
         }

         // Se valida que no se repita el tipo de articulos

         for (int i = 0; i < Contador; i++)
         {
            if (tipoArticulos[i] != null && tipoArticulos[i].IdTipoArticulo == tipoArt.IdTipoArticulo)
            {
               throw new Exception("Ya existe un tipo de artículo con esa identificación.");
            }
         }

         // Se guarda la informacion en el arreglo

         tipoArticulos[Contador] = tipoArt;
         Contador++;
         return true;

      }

      // Metodo para consultar todos los articulos
      public static TipoArticulo[] ObtenerTodos()
      {
         TipoArticulo[] copia = new TipoArticulo[Contador];
         Array.Copy(tipoArticulos, copia, Contador);
         return copia;
      }

      // Este metodo funciona generando ID´s automaticamente
      public static int ObtenerSiguienteId()
      {
         
         var idsExistentes = tipoArticulos
       .Where(t => t != null)  // Ignorar espacios vacíos
       .Select(t => t.IdTipoArticulo);

         if (!idsExistentes.Any())
         {
            return 1; // Si no hay registros, empieza en 1
         }

         return idsExistentes.Max() + 1; // Tomar el mayor ID y sumar 1

      }
   }
}