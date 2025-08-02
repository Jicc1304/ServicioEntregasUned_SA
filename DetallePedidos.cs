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
   //Declaración de la clase 'DetallePedidos' y sus atributos
     public class DetallePedidos
    {
      public Pedidos Pedido {  get; set; }
      public Articulo Articulo { get; set; }
      public int CantidadArticulos {  get; set; }
      public double ValorArticulo {  get; set; }
    }
}
