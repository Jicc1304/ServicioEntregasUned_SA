/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
   // Se declara el formulario principal
   public partial class FormPrincipal : Form
   {
      public FormPrincipal()
      {
         InitializeComponent();
      }

      // Metodo del boton de iniciar el sistema
      private void btnIniciar_Click(object sender, EventArgs e)
      {
         this.Hide(); // oculta el inicio
         FormTipoArticulo tipoArticulo = new FormTipoArticulo();
         tipoArticulo.ShowDialog();// Abre el FormTipoArticulo y bloquea el actual
         this.Show();// Muestra el form tipo articulo
         this.Hide();// Oculta el form actual


      }

      // Metodo para el boton de salir del sistema
      private void btnSalir_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}
