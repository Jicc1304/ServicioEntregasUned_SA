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
    
      // Definición de la clase 'Clientes' y sus atributos
      public class Clientes
      {
         public int IdCliente { get; set; }
         public string NombreCliente { get; set; }
         public string PrimerApellidoC { get; set; }
         public string SegundoApellidoC { get; set; }
         public DateTime FechaNacimientoC { get; set; }
         public bool EstadoCliente { get; set; }

         
      }
   }



