/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */
using Datos;
using Entidades;
using Negocio;
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
   // Declaracion de la clase FormRepartidores
   public partial class FormRepartidores : Form
   {
      public FormRepartidores()
      {
         // Se inicializan los estados
         InitializeComponent();
         CargarEstados(); 

         // se configura DateTimePickers con rangos válidos

         //  Condiciones para la Fecha de nacimiento
         dtpFechaNacimientoR.Format = DateTimePickerFormat.Short;// formatea la fecha en formato corto
         dtpFechaNacimientoR.MaxDate = DateTime.Today.AddYears(-18);// Restringe la fecha para que sea mayor de edad
         dtpFechaNacimientoR.Value = dtpFechaNacimientoR.MaxDate; // Inicializa la fecha en formato maximo

         //  Condiciones para la Fecha de contratación
         dtpFechaContratacionR.Format = DateTimePickerFormat.Short;// formatea la fecha en formato corto
         dtpFechaContratacionR.MaxDate = DateTime.Today;// Inicializa la fecha en formato maximo
         dtpFechaContratacionR.Value = DateTime.Today;// establese la fecha del dia actual




      }
      // Metodo pra cargar los estados
      private void CargarEstados()
      {
        
         cmbEstadoRepartidor.Items.Clear();
         cmbEstadoRepartidor.Items.Add("Sí");
         cmbEstadoRepartidor.Items.Add("No");

         if (cmbEstadoRepartidor.Items.Count > 0)
         {
            cmbEstadoRepartidor.SelectedIndex = 0; // Seleccionar "Activo" por defecto
         }
      }
      // metodo para mostrar ordenadamente los nombres de las columnas
      private void ConfigurarColumnas()
      {
         if (dgvConsultas.Columns.Count > 0)
         {
            dgvConsultas.Columns["IdRepartidor"].HeaderText = " ID del repartidor";
            dgvConsultas.Columns["NombreRepartidor"].HeaderText = "Nombre ";
            dgvConsultas.Columns["PrimerApellidoR"].HeaderText = "Primer Apellido";
            dgvConsultas.Columns["SegundoApellidoR"].HeaderText = "Segundo Apellido";
            dgvConsultas.Columns["FechaNacimientoR"].HeaderText = "Fecha de nacimiento";
            dgvConsultas.Columns["FechaContratacionR"].HeaderText = "Fecha de Contratacion";
            dgvConsultas.Columns["EstadoRepartidor"].HeaderText = "Activo";
         }
      }

      // Este método se llama al cargar el formulario
      private void FormRepartidores_Load(object sender, EventArgs e)
      {
         //Carga automática del DataGridView con los clientes ya registrados
         dgvConsultas.DataSource = null;
         dgvConsultas.DataSource = NegocioRepartidores.Consultar();
      }

      // Se define el evento para el botón registrar con sus validaciones
      private void btnRegistrar_Click(object sender, EventArgs e)
      {
         try
         {
            // Se intenta que los datos se corrijan en caso de error
            if (!int.TryParse(txtIdRepartidor.Text.Trim(), out int id))
            {
               MessageBox.Show("El Id debe ser un número entero válido");// Valdacion para que el id sea entero
               txtIdRepartidor.Focus();
               return;
            }

            // Se valida fecha de nacimiento
            if (dtpFechaNacimientoR.Value > DateTime.Today.AddYears(-18))
            {
               MessageBox.Show("El repartidor debe tener al menos 18 años cumplidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            // Validar fecha de contratación
            if (dtpFechaContratacionR.Value > DateTime.Today)
            {
               MessageBox.Show("La fecha de contratación no puede ser posterior a hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }


            // Creación del objeto repartidornuevo, se toman los valores delos textbox y se pasan como parametros 
            Repartidores repartidornuevo = new Repartidores
            {
               IdRepartidor = id,
               NombreRepartidor = txtNombreRepartidor.Text.Trim(),
               PrimerApellidoR = txtPrimerApellidoR.Text.Trim(),
               SegundoApellidoR = txtSegundoApellidoR.Text.Trim(),
               FechaNacimientoR = dtpFechaNacimientoR.Value,
               FechaContratacionR = dtpFechaContratacionR.Value,
               EstadoRepartidor = cmbEstadoRepartidor.SelectedItem.ToString() == "Sí"
            };

            // Se declara 'mensaje' para lanzarlo en caso de registro exitoso
            string mensaje = NegocioRepartidores.RegistrarRepartidores(repartidornuevo);
            MessageBox.Show(mensaje);

            if (mensaje.StartsWith("Se ha registrado"))
            {
               LimpiarCampos();// se llama al metodo para limpiar campos
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error no definido: " + ex.Message);
         }
      }
      // Método para limpiar los campos después de hacer un registro
      private void LimpiarCampos()
      {
         txtIdRepartidor.Clear();
         txtNombreRepartidor.Clear();
         txtPrimerApellidoR.Clear();
         txtSegundoApellidoR.Clear();
         dtpFechaNacimientoR.Value = DateTime.Today.AddYears(-18);
         dtpFechaContratacionR.Value = DateTime.Today;
         cmbEstadoRepartidor.SelectedIndex = 0;
      }
      // Método para consultar los registros realizados
      private void btnConsultar_Click(object sender, EventArgs e)
      {
         // carga el DataGridView
         dgvConsultas.DataSource = null;
         dgvConsultas.DataSource = NegocioRepartidores.Consultar();
         ConfigurarColumnas();// se llama l metodo que ordena las columnas
      }

    

      // Método para saltar al siguiente formulario
      private void btnSiguiente_Click(object sender, EventArgs e)
      {
         FormPedidos siguiente = new FormPedidos();
         siguiente.Show();// muestra el siguiente formulario
         this.Hide();// Oculta el siguiente formulario
      }
      // Método para salir de la aplicación
      private void btnSalir_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
      // metodo para regresar al formulario anterior
      private void btnRegresar_Click(object sender, EventArgs e)
      {
         FormClientes formcliente = new FormClientes();
         formcliente.Show(); // Muestra el formulario anterior
         this.Hide();// Se oculta el formulario actual
      }
   }

}
