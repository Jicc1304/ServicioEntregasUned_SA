﻿using System;
using System.Windows.Forms;

namespace Presentacion
{
   static class Program
   {
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new FormPrincipal()); // Cambia a tu formulario inicial si es otro
      }
   }
}
