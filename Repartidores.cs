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
   //Definicion de la clase'Repartidores'y sus atributos
   public class Repartidores
   {
      public int IdRepartidor {  get; set; }
      public string NombreRepartidor { get; set; }
      public string PrimerApellidoR {  get; set; }
      public string SegundoApellidoR {  get; set; }
      public DateTime FechaNacimientoR {  get; set; }
      public DateTime FechaContratacionR {  get; set; }
      public bool EstadoRepartidor { get; set; }
   }
}
