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

namespace Entidades
{
   // Declaracion de la clase'Pedidos' y sus atributos
   public class Pedidos
   {
      public int IdPedido {get; set;}
      public DateTime FechaPedido {get; set;}
      public Clientes cliente {get; set;}
      public Repartidores repartidores {get; set;}
      public string DireccionPedido { get; set;}

   }
}
