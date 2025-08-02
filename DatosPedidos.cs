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
using System.Data.SqlClient;

namespace Datos
{
    
    
      // Clase de datos para los pedidos
      public class DatosPedidos
      {
         // Arreglo para 40 Pedidos
         private static Pedidos[] pedidos = new Pedidos[40];

         // Contador para llevar la cuenta
         private static int Contador = 0;

         // Método para agregar Pedidos
         public static bool AgregarPedidos(Pedidos nuevopedido)
         {
            if (Contador >= DatosPedidos.pedidos.Length) // Verifica si hay espacio
            {
               return false;
            }

            // Verifica que no se repita el ID
            for (int i = 0; i < Contador; i++)
            {
               if (DatosPedidos.pedidos[i].IdPedido == nuevopedido.IdPedido)
               {
                  throw new Exception("Ya existe un pedido con esa identificación.");
               }
            }

         // Se agregan pedidos
         DatosPedidos.pedidos[Contador] = nuevopedido;
            Contador++;
            return true;
         }

         // Metodo para consultar todos los pedidos
         public static Pedidos[] ObtenerTodos()
         {
            Pedidos[] obpedidos = new Pedidos[Contador];
            Array.Copy(pedidos, obpedidos, Contador);
            return obpedidos;
         }

      // Metodo para generar los Id's automaticamente
      public static int ObtenerSiguienteId()
      {
         if (pedidos.Count(p => p != null) >= 40)
         {
            throw new InvalidOperationException("Se ha alcanzado el límite máximo de 40 pedidos.");
         }

         var pedidosExistentes = pedidos.Where(a => a != null).Select(a => a.IdPedido);

         if (!pedidosExistentes.Any())
         {
            return 1; // Si no hay registros, empieza en 1
         }

         return pedidosExistentes.Max() + 1;
      }

      public static string InsertarPedido(int idCliente, int idRepartidor, string direccion, DateTime fecha)
      {
         try
         {
            string cadenaConexion = @"Server=LAPTOP-NNPGKHQ8\SQLEXPRESS;Database=ENTREGAUNED;Trusted_Connection=True;";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
               conexion.Open();

               string sql = @"INSERT INTO Pedido (FechaPedido, IdCliente, IdRepartidor, Direccion) 
                        VALUES (@FechaPedido, @IdCliente, @IdRepartidor, @Direccion)";

               using (SqlCommand cmd = new SqlCommand(sql, conexion))
               {
                  cmd.Parameters.AddWithValue("@FechaPedido", fecha);
                  cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                  cmd.Parameters.AddWithValue("@IdRepartidor", idRepartidor);
                  cmd.Parameters.AddWithValue("@Direccion", direccion);

                  int filas = cmd.ExecuteNonQuery();
                  return filas > 0 ? "✅ Pedido registrado con éxito." : "❌ No se pudo registrar el pedido.";
               }
            }
         }
         catch (Exception ex)
         {
            return "❌ Error al registrar el pedido: " + ex.Message;
         }
      }

   }
}
