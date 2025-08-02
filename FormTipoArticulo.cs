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
using Negocio;
using Datos;
using Entidades;

namespace Presentacion
{
   // DEclaracion de la clase 'FormTipoArticulo'
   public partial class FormTipoArticulo : Form
   {
      // Inicializa los Id en '1', y los genera automaticamente
      public FormTipoArticulo()
      {
         InitializeComponent();

         // Asignar ID automático
         txtIdTipoArticulo.Text = DatosTipoArticulo.ObtenerSiguienteId().ToString();
         txtIdTipoArticulo.ReadOnly = true;
      }
      // metodo para mostrar de forma mas clara los nombres de las columnas de l DataGridView
      private void ConfigurarColumnas()
      {
         if (dgvConsultar.Columns.Count > 0)
         {
            dgvConsultar.Columns["IdTipoArticulo"].HeaderText = "ID Tipo Artículo";
            dgvConsultar.Columns["NombreTipoArticulo"].HeaderText = "Nombre del Tipo";
            dgvConsultar.Columns["DescripcionTipoArticulo"].HeaderText = "Descripción";
         }
      }
      // Este método se llama al cargar el formulario para asignar los ID´s
      private void FormTipoArticulo_Load(object sender, EventArgs e)
      {

         // Asignar ID automático
         txtIdTipoArticulo.Text = DatosTipoArticulo.ObtenerSiguienteId().ToString();
         txtIdTipoArticulo.ReadOnly = true;
      }


      // Se define el evento para el boton registrar con sus validaciones
      private void btnRegistrar_Click(Object sender, EventArgs e)
      {
         try
         {
            // declaracion  de variable  'id'
            int id = DatosTipoArticulo.ObtenerSiguienteId();
            
            // Se declara un articulo 'nuevo', que recibe los  datos de los textbox
            TipoArticulo nuevo = new TipoArticulo
            {
               IdTipoArticulo = id,
               NombreTipoArticulo = txtNombreTipoArticulo.Text.Trim(),
               DescripcionTipoArticulo = txtDescripcionTipoArticulo.Text.Trim()

            };
            // se declara 'mensaje' para lanzarlo en caso de registro exitoso
            string mensaje = NegocioTipoArticulo.RegistrarTipoArticulo(nuevo);
            MessageBox.Show(mensaje);

            if (mensaje.StartsWith("Se ha registrado"))
            {
               LimpiarCampos();// Llamamos al metodo que limpia los campos
            }
            // se llama al metodo para obtener el siguiente Id
            txtIdTipoArticulo.Text = DatosTipoArticulo.ObtenerSiguienteId().ToString();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error no definido" + ex.Message);
         }
      }
      // metodo para limpiar los campos de los textbox despues de hacer un registro
      private void LimpiarCampos()
      {
         txtIdTipoArticulo.Clear();
         txtNombreTipoArticulo.Clear();
         txtDescripcionTipoArticulo.Clear();
         txtIdTipoArticulo.Focus();
      }
      // metodo para consultar los registros realizados
      private void btnConsultar_Click(object sender, EventArgs e)
      {

         {
            // Permite cargar el DataGridView con los datos del arreglo
            dgvConsultar.DataSource = null;
            dgvConsultar.DataSource = NegocioTipoArticulo.Consultar();
            ConfigurarColumnas();// se llama al metodo para mostrar las columnas ordenadamente
         }
      }
      // Metodo para saltar al siguiente formulario
      private void btnSiguiente_Click(object sender, EventArgs e)
      {
         FormArticulo siguiente = new FormArticulo();
         siguiente.Show();// nuestra el siguiente formulario
         this.Hide();// Oculta el  formulario actual
      }
      // Metodo para salir de la aplicacion
      private void btnSalir_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

     

   }
}
