/**
 * UNED II Cuatrimestre
 * Proyecto 2: Aplicacion Cliente-Servidor.
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 27/07/25
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
   public class DatosClientes
   {
      // Cambia esta cadena según tu configuración
      private static readonly string connectionString =
         "Server=LAPTOP-NNPGKHQ8\\SQLEXPRESS;Database=ENTREGAUNED;Trusted_Connection=True;";

      // Obtener todos los clientes
      public static Clientes[] ObtenerTodos()
      {
         var lista = new List<Clientes>();

         using (SqlConnection conn = new SqlConnection(connectionString))
         {
            conn.Open();
            string query = "SELECT * FROM Cliente";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
               while (reader.Read())
               {
                  lista.Add(new Clientes
                  {
                     IdCliente = Convert.ToInt32(reader["Identificacion"]),
                     NombreCliente = reader["Nombre"].ToString(),
                     PrimerApellidoC = reader["PrimerApellido"].ToString(),
                     SegundoApellidoC = reader["SegundoApellido"].ToString(),
                     FechaNacimientoC = Convert.ToDateTime(reader["FechaNacimiento"]),
                     EstadoCliente = Convert.ToBoolean(reader["Activo"])
                  });
               }
            }
         }

         return lista.ToArray();
      }

      // Agregar un nuevo cliente
      public static bool AgregarClientes(Clientes cliente)
      {
         using (SqlConnection conn = new SqlConnection(connectionString))
         {
            conn.Open();
            string query = @"INSERT INTO Cliente (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Activo)
                             VALUES (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Activo)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
               cmd.Parameters.AddWithValue("@Identificacion", cliente.IdCliente);
               cmd.Parameters.AddWithValue("@Nombre", cliente.NombreCliente);
               cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellidoC);
               cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellidoC);
               cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimientoC);
               cmd.Parameters.AddWithValue("@Activo", cliente.EstadoCliente);

               return cmd.ExecuteNonQuery() > 0;
            }
         }
      }

      // Buscar un cliente por su identificación
      public static Clientes ObtenerPorId(int id)
      {
         using (SqlConnection conn = new SqlConnection(connectionString))
         {
            conn.Open();
            string query = "SELECT * FROM Cliente WHERE Identificacion = @Id";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
               cmd.Parameters.AddWithValue("@Id", id);

               using (SqlDataReader reader = cmd.ExecuteReader())
               {
                  if (reader.Read())
                  {
                     return new Clientes
                     {
                        IdCliente = Convert.ToInt32(reader["Identificacion"]),
                        NombreCliente = reader["Nombre"].ToString(),
                        PrimerApellidoC = reader["PrimerApellido"].ToString(),
                        SegundoApellidoC = reader["SegundoApellido"].ToString(),
                        FechaNacimientoC = Convert.ToDateTime(reader["FechaNacimiento"]),
                        EstadoCliente = Convert.ToBoolean(reader["Activo"])
                     };
                  }
               }
            }
         }

         return null;
      }
   }
}


