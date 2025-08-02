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
using Datos;
using Entidades;

namespace Negocio
{
   public static class NegocioPedidos
   {
      // Nuevo método para uso con SQL Server
      public static string RegistrarPedido(int idCliente, int idRepartidor, string direccion, DateTime fecha)
      {
         return DatosPedidos.InsertarPedido(idCliente, idRepartidor, direccion, fecha);
      }

      // Método antiguo basado en objetos en memoria
      public static string RegistrarPedidos(Pedidos nuevopedido)
      {
         try
         {
            if (string.IsNullOrWhiteSpace(nuevopedido.DireccionPedido) ||
                nuevopedido.cliente == null ||
                nuevopedido.repartidores == null ||
                nuevopedido.FechaPedido.Date < DateTime.Today)
            {
               return "Error: Todos los campos deben ser válidos y completos.";
            }

            if (nuevopedido.IdPedido < 1 || nuevopedido.IdPedido > 40)
            {
               return "Error: El ID debe estar entre 1 y 40.";
            }

            Pedidos[] pedidosExistentes = DatosPedidos.ObtenerTodos();
            foreach (var existente in pedidosExistentes)
            {
               if (existente != null && existente.IdPedido == nuevopedido.IdPedido)
               {
                  return "Error: Ya existe un pedido con ese ID.";
               }
            }

            bool agregado = DatosPedidos.AgregarPedidos(nuevopedido);
            return agregado
                ? "Se ha registrado el pedido con éxito."
                : "No se pueden agregar más registros. Se ha alcanzado el límite.";
         }
         catch (Exception ex)
         {
            return "Error: No fue posible registrar el pedido. Revise los requisitos. " + ex.Message;
         }
      }

      public static Pedidos[] Consultar()
      {
         return DatosPedidos.ObtenerTodos();
      }

      public static List<object> ConsultarPedidos()
      {
         var pedidos = DatosPedidos.ObtenerTodos();
         if (pedidos == null)
            return new List<object>();

         var listaPlano = pedidos
             .Where(p => p != null && p.cliente != null && p.repartidores != null)
             .Select(p => new
             {
                p.IdPedido,
                p.FechaPedido,
                p.cliente.IdCliente,
                p.cliente.NombreCliente,
                p.cliente.PrimerApellidoC,
                p.cliente.SegundoApellidoC,
                p.repartidores.IdRepartidor,
                p.repartidores.NombreRepartidor,
                p.repartidores.PrimerApellidoR,
                p.repartidores.SegundoApellidoR,
                p.DireccionPedido
             })
             .ToList<object>();

         return listaPlano;
      }
   }
}

