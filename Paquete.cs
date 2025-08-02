using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
  
      [Serializable]
      // Declaracion del la clase paquete, que nos permite enviar y recibir mensajes
      public class Paquete
      {
         public string Comando { get; set; }
         public object Datos { get; set; }
      }
   }

