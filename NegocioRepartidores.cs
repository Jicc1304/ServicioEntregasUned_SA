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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   // Declaracion de la clse 'NegocioRepartidores'
   public class NegocioRepartidores
   {
     
         // Método para registrar Repartidores
         public static string RegistrarRepartidores(Repartidores repartidores)
         {
            try
            {
            // Se valida que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(repartidores.NombreRepartidor) ||
                string.IsNullOrWhiteSpace(repartidores.PrimerApellidoR) ||
                string.IsNullOrWhiteSpace(repartidores.SegundoApellidoR) ||
                repartidores.FechaNacimientoR == default(DateTime) ||
                repartidores.FechaContratacionR == default(DateTime))
                   
               {
                  return "Error: Todos los campos son requeridos.";
               }

               // Se valida que el ID no esté repetido
               Repartidores[] repExistentes = DatosRepartidores.ObtenerTodos();
               foreach (var repExistente in repExistentes)
               {
                  if (repExistente.IdRepartidor == repartidores.IdRepartidor)
                  {
                     return "Error: Ya existe un Repartidor con ese ID.";
                  }
               }

               // Se intenta agregar
               bool Repagregado = DatosRepartidores.AgregarRepartidores(repartidores);
               return Repagregado ? "Se ha registrado el repartidor con éxito." : "No se pueden agregar más registros. Se ha llegado al límite.";
            }
            catch (Exception ex)
            {
               return "Error: No fue posible registrar el repartidor. Revise los requisitos. " + ex.Message;
            }
         }

         // Método para consultar los repartidores
         public static Repartidores[] Consultar()
         {
            return DatosRepartidores.ObtenerTodos();
         }
      // Metodo para consultar repartidores con estado activo
      public static Repartidores[] ConsultarActivos()
      {
         return DatosRepartidores.ObtenerTodos()
             .Where(r => r != null && r.EstadoRepartidor)
             .ToArray();
      }
   }
   }


