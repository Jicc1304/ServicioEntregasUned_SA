/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */
using System;
using System.Linq;
using Datos;
using Entidades;


namespace Negocio
{
   // Declaracion de la clase 'RegistrarClientes'
    public class  NegocioClientes
   {
      // Método para registrar clientes
      public static string RegistrarClientes(Clientes clientes)
      {
         try
         {
            // Se valida que los campos sean válidos
            if (string.IsNullOrWhiteSpace(clientes.NombreCliente) ||
                string.IsNullOrWhiteSpace(clientes.PrimerApellidoC) ||
                string.IsNullOrWhiteSpace(clientes.SegundoApellidoC) ||
                clientes.FechaNacimientoC == default(DateTime))
                
            {
               return "Error: Todos los campos son requeridos.";
            }

            // Se valida que el ID no esté repetido
            Clientes[] existentes = DatosClientes.ObtenerTodos();
            foreach (var existente in existentes)
            {
               if (existente.IdCliente == clientes.IdCliente)
               {
                  return "Error: Ya existe un cliente con ese ID.";
               }
            }

            // Se intenta agregar
            bool agregado = DatosClientes.AgregarClientes(clientes);
            return agregado ? "Se ha registrado el cliente con éxito." : "No se pueden agregar más registros. Se ha llegado al límite.";
         }
         catch (Exception ex)
         {
            return "Error: No fue posible registrar el cliente. Revise los requisitos. " + ex.Message;
         }
      }

      // Método para consultar los clientes
      public static Clientes[] Consultar()
      {
         return DatosClientes.ObtenerTodos();
      }
      //Metodo para consultar los clientes activos
      public static Clientes[] ConsultarActivos()
      {
         return DatosClientes.ObtenerTodos()
             .Where(c => c != null && c.EstadoCliente)
             .ToArray();
      }
      // Método para validar si un cliente existe por su Id
      public static bool ClienteExiste(int idCliente)
      {
         Clientes cliente = DatosClientes.ObtenerPorId(idCliente);
         return cliente != null;
      }


   }
}
