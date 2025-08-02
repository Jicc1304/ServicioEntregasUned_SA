/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   // Declracion del la clase 'DatosArticulo', su arreglos y metodos
   public class DatosArticulo
   {
      //Declaracion del arreglo de 20 posiciones
      private static Articulo[] articulos = new Articulo[20];

      //Declaracion de contador para los datos ingreados
      private static int Contador = 0;

      //Metodo para agregar articulos
      public static bool AgregarArticulo(Articulo art)
      {
         if (Contador >= articulos.Length)
         {
            return false;// Arreglo lleno
         }

         // Se valida que no se repita el articulos

         for (int i = 0; i < Contador; i++)
         {
            if (articulos[i].IdArticulo == art.IdArticulo)
            {
               throw new Exception("ya esiste un articulo con esa identificación: ");
            }
         }

         // Se guarda la informacion en el arreglo

         articulos[Contador] = art;
         Contador++;
         return true;
      }
      // Metodo para consultar todos los articulos
      public static Articulo[] ObtenerTodos()
      {
        
         return articulos;
      }
      // Metodo para generar los Id's automaticamente
      public static int ObtenerSiguienteId()
      {
         if (articulos.Count(p => p != null) >= 20)
         {
            throw new InvalidOperationException("Se ha alcanzado el límite máximo de 20 Articulos.");
         }
         var articulosExistentes = articulos.Where(a => a != null).Select(a => a.IdArticulo);

         if (!articulosExistentes.Any())
         {
            return 1; // Si no hay registros, empieza en 1
         }

         return articulosExistentes.Max() + 1;
      }


   }
}
