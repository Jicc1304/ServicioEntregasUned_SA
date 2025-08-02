/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */
using Entidades;
using System;

namespace Datos
{
   // Declaracion de la clase 'DatosDetallePedidos'
   public class DatosDetallePedidos
   {
      // Arreglo para almacenar hasta 200 detalles
      private static DetallePedidos[] detalles = new DetallePedidos[500];

      // Contador para llevar la cuenta
      private static int Contador = 0;

      // Método para agregar un detalle
      public static bool AgregarDetalle(DetallePedidos nuevoDetalle)
      {
         if (Contador >= detalles.Length) // Verifica si hay espacio
         {
            return false;
         }

         // Verifica que no se repita el mismo artículo en el mismo pedido
         for (int i = 0; i < Contador; i++)
         {
            if (detalles[i].Pedido.IdPedido == nuevoDetalle.Pedido.IdPedido &&
                detalles[i].Articulo.IdArticulo == nuevoDetalle.Articulo.IdArticulo)
            {
               throw new Exception("Ya existe ese artículo en este pedido.");
            }
         }

         // Si pasa las validaciones, lo agrega
         detalles[Contador] = nuevoDetalle;
         Contador++;
         return true;
      }

      // Método para consultar todos los detalles
      public static DetallePedidos[] ObtenerTodos()
      {
         DetallePedidos[] obDetalles = new DetallePedidos[Contador];
         Array.Copy(detalles, obDetalles, Contador);
         return obDetalles;
      }

      //Método para obtener detalles por ID de pedido,
      public static DetallePedidos[] ObtenerPorPedido(int idPedido)
      {
         int count = 0;

         for (int i = 0; i < Contador; i++)
         {
            if (detalles[i].Pedido.IdPedido == idPedido)
            {
               count++;
            }
         }

         DetallePedidos[] resultado = new DetallePedidos[count];
         int j = 0;

         for (int i = 0; i < Contador; i++)
         {
            if (detalles[i].Pedido.IdPedido == idPedido)
            {
               resultado[j] = detalles[i];
               j++;
            }
         }

         return resultado;
      }
   }
}

