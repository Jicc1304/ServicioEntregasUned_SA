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
   // Declaracion de la clase 'Repartidores'
   public class DatosRepartidores
   {
      // Arreglo para 20 pedidos
      private static Repartidores[] repartidores = new Repartidores[20];

      // Contador para llevar la cuenta
      private static int Contador = 0;

      // Método para agregar pedidos
      public static bool AgregarRepartidores(Repartidores repartidor)
      {
         if (Contador >= repartidores.Length) // Verifica si hay espacio
         {
            return false;
         }

         // Verifica que no se repita el ID
         for (int i = 0; i < Contador; i++)
         {
            if (repartidores[i].IdRepartidor == repartidor.IdRepartidor)
            {
               throw new Exception("Ya existe un repartidor con esa identificación.");
            }
         }

         // Si pasa las validaciones, lo agrega
         repartidores[Contador] = repartidor;
         Contador++;
         return true;
      }

      // Metodo para consultar todos los repartidores
      public static Repartidores[] ObtenerTodos()
      {
         Repartidores[] obrepartidores = new Repartidores[Contador];
         Array.Copy(repartidores, obrepartidores, Contador);
         return obrepartidores;
      }
   }
}


