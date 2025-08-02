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
   // Declaracion de la clase ´Articulo´ y sus atributos
   public class Articulo
   {
      public int IdArticulo {  get; set; }
      public string NombreArticulo { get; set;}
      public TipoArticulo TipoArt { get; set; }
      public double ValorArticulo { get; set;}
      public int InventarioArticulo {  get; set; }
      public bool EstadoArticulo { get; set;}

   }
}
