/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */

using Datos;
using Entidades;
using System;

namespace Negocio
{
   // Declaración de la clase 'NegocioDetallePedidos'
   public class NegocioDetallePedidos
   {
      // Metodo para registrar pedidos
      public static string RegistrarDetalle(DetallePedidos nuevoDetalle)
      {
         try
         {
            // Validaciones de los campos
            if (nuevoDetalle == null || nuevoDetalle.Pedido == null || nuevoDetalle.Articulo == null)
               return "Error: Los datos del pedido o artículo no pueden ser nulos.";

            if (nuevoDetalle.CantidadArticulos <= 0)
               return "Error: La cantidad debe ser mayor que cero.";

            if (nuevoDetalle.CantidadArticulos > nuevoDetalle.Articulo.InventarioArticulo)
               return $"Error: La cantidad solicitada ({nuevoDetalle.CantidadArticulos}) supera el inventario disponible ({nuevoDetalle.Articulo.InventarioArticulo}).";

            // Validar que el artículo no esté repetido para ese pedido
            var existentes = DatosDetallePedidos.ObtenerPorPedido(nuevoDetalle.Pedido.IdPedido);
            foreach (var detalle in existentes)
            {
               if (detalle != null && detalle.Articulo.IdArticulo == nuevoDetalle.Articulo.IdArticulo)
                  return "Error: Ya se registró ese artículo para este pedido.";
            }

            // Calcular el monto con el 12% de envío
            double montoFinal = nuevoDetalle.Articulo.ValorArticulo * nuevoDetalle.CantidadArticulos * 1.12;
            nuevoDetalle.ValorArticulo = montoFinal;

            // Registrar el detalle
            bool agregado = DatosDetallePedidos.AgregarDetalle(nuevoDetalle);
            if (!agregado)
               return "No se pueden agregar más detalles. Se alcanzó el límite.";

            // Se resta inventario al objeto recibido
            nuevoDetalle.Articulo.InventarioArticulo -= nuevoDetalle.CantidadArticulos;

            // Si el inventario queda en 0,  se desactiva el artículo
            if (nuevoDetalle.Articulo.InventarioArticulo == 0)
            {
               nuevoDetalle.Articulo.EstadoArticulo = false;
            }

            // Se actualizar el artículo real en el arreglo central, recorriendolo y validando las condiciones
            Articulo[] articulos = DatosArticulo.ObtenerTodos(); 
            for (int i = 0; i < articulos.Length; i++)
            {
               if (articulos[i] != null && articulos[i].IdArticulo == nuevoDetalle.Articulo.IdArticulo)
               {
                  articulos[i].InventarioArticulo = nuevoDetalle.Articulo.InventarioArticulo;
                  articulos[i].EstadoArticulo = nuevoDetalle.Articulo.EstadoArticulo;
                  break;
               }
            }

            return "El detalle del pedido se ha registrado correctamente.";
         }
         catch (Exception ex)
         {
            return "Error al registrar el detalle del pedido: " + ex.Message;
         }

      }
    

      public static DetallePedidos[] ConsultarPorPedido(int idPedido)
      {
         return DatosDetallePedidos.ObtenerPorPedido(idPedido);
      }
   }
}

