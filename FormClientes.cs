/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */
using System;
using System.Windows.Forms;
using Datos;
using Entidades;
using Negocio;

namespace Presentacion
{
   // Declaracion de la clase 'FormClientes'
   public partial class FormClientes : Form
   {
      public FormClientes()
      {
         // se inicializan la carga de estados y las fechas
         InitializeComponent();
         CargarEstados();

         dtpFechaNacimientoC.Format = DateTimePickerFormat.Short;
         dtpFechaNacimientoC.MaxDate =DateTime.Today;
      }
      // metodo para cargar los estados Activo(si), desactivo(no)
      private void CargarEstados()
      {
         
         cmbActivo.Items.Clear();
         cmbActivo.Items.Add("Sí");
         cmbActivo.Items.Add("No");

         if (cmbActivo.Items.Count > 0)
         {
            cmbActivo.SelectedIndex = 0; // Seleccionar "Activo" por defecto
         }
      }
      // Metodo para ordenar mas claramente los nombres de las columnas del DataGridView
      private void ConfigurarColumnas()
      {
         if (dgvConsultas.Columns.Count > 0)
         {
            dgvConsultas.Columns["IdCliente"].HeaderText = " ID del cliente";
            dgvConsultas.Columns["NombreCliente"].HeaderText = "Nombre ";
            dgvConsultas.Columns["PrimerApellidoC"].HeaderText = "Primer Apellido";
            dgvConsultas.Columns["SegundoApellidoC"].HeaderText = "Segundo Apellido";
            dgvConsultas.Columns["FechaNacimientoC"].HeaderText = "Fecha de nacimiento";
            dgvConsultas.Columns["EstadoCliente"].HeaderText = "Activo";
         }
      }

      // Este método se llama al cargar el formulario
      private void FormClientes_Load(object sender, EventArgs e)
      {
         //Carga automática del DataGridView con los clientes ya registrados
         dgvConsultas.DataSource = null;
         dgvConsultas.DataSource = NegocioClientes.Consultar();
      }

      // Se define el evento para el botón registrar con sus validaciones
      private void btnRegistrar_Click(object sender, EventArgs e)
      {
         try
         {
            // Se intenta que los datos se corrijan en caso de error
            if (!int.TryParse(txtIdCliente.Text.Trim(), out int id))
            {
               MessageBox.Show("El Id debe ser un número entero válido");
               txtIdCliente.Focus();
               return;
            }

            // Creación del objeto Cliente correctamente, tomando los datos de los textbox
            Clientes nuevo = new Clientes
            {
               IdCliente = id,
               NombreCliente = txtNombreCliente.Text.Trim(),
               PrimerApellidoC = txtPrimerApellidoC.Text.Trim(),
               SegundoApellidoC = txtSegundoApellidoC.Text.Trim(),
               FechaNacimientoC = dtpFechaNacimientoC.Value,
               EstadoCliente = cmbActivo.SelectedItem.ToString() == "Sí"
            };

            // Se declara 'mensaje' para lanzarlo en caso de registro exitoso
            string mensaje = NegocioClientes.RegistrarClientes(nuevo);
            MessageBox.Show(mensaje);

            if (mensaje.StartsWith("Se ha registrado"))
            {
               LimpiarCampos();// se llama para limpiar los campos despues de ingresar
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
         txtIdCliente.Clear();
         txtNombreCliente.Clear();
         txtPrimerApellidoC.Clear();
         txtSegundoApellidoC.Clear();
         dtpFechaNacimientoC.MaxDate = DateTime.Today; // No permite que la fecha sea superior al día
         cmbActivo.SelectedIndex = 0;
      }

      // Método para consultar los registros realizados
      private void btnConsultar_Click(object sender, EventArgs e)
      {
         dgvConsultas.DataSource = null;
         dgvConsultas.DataSource = NegocioClientes.Consultar();
         ConfigurarColumnas();// Se llama para ordenar las columnas del DGV
      }

      // Método para saltar al siguiente formulario
      private void btnSiguiente_Click(object sender, EventArgs e)
      {
         FormRepartidores siguiente = new FormRepartidores();
         siguiente.Show();// se muestra el siguiente formulario
         this.Hide();// Se oculta el actual formulario
      }

      // Método para salir de la aplicación
      private void btnSalir_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
      // metodo para regresar al formulario anterior
      private void btnRegresar_Click(object sender, EventArgs e)
      {
         FormArticulo formArticulo = new FormArticulo();
         formArticulo.Show();// muestra el formulario anterior 
         this.Hide();// oculta el formulario actual
      }
   }
}