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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
   // Se declara la clase 'FormPedidos'
   public partial class FormPedidos : Form
   {
      /* Se inicilaiza los metodos para cargar clientes y repartidores y los formatos de fecha y
      ademas se carga los ID´s automaticamente */
      public FormPedidos()
      {
         InitializeComponent();
         CargarClientes();
         CargarRepartidores();

         dtpFechaPedido.Format = DateTimePickerFormat.Short;
         dtpFechaPedido.MaxDate = DateTime.Today; // Evita las fechas futuras

         // Asignar el ID automático en 1 al empezar
         txtIdPedido.Text = DatosPedidos.ObtenerSiguienteId().ToString();
         txtIdPedido.ReadOnly = true;


      }
      // Metodo para cargar los clientes a los combobox
      private void CargarClientes()
      {// Llama al método  'consultaractivos' de  'NegocioClientes'
         var listaClientes = NegocioClientes.ConsultarActivos(); 

         if (listaClientes == null || listaClientes.Length == 0)
         {
            MessageBox.Show("No hay clientes registrados.");
            return;
         }

         // Se reciben los datos de los campos de los combobox
         cmbcliente.DataSource = listaClientes.Where(t => t != null).ToList();
         cmbcliente.ValueMember = "IdCliente";
         cmbcliente.DisplayMember = "NombreCliente";
         cmbcliente.ValueMember = "PrimerApellidoC";
         cmbcliente.ValueMember = "SegundoApellidoC";

      }

      // Metodo para cargar los repartidores
      private void CargarRepartidores()
      {
         // Llamada al método 'ConsultarActivos' de 'NegocioRepartidores'
         var listaRepartidores = NegocioRepartidores.ConsultarActivos(); 

         if (listaRepartidores == null || listaRepartidores.Length == 0)
         {
            MessageBox.Show("No hay repartidores registrados.");
            return;
         }

         // Se llenan los datos de los Repartidores
         cmbrepartidores.DataSource = listaRepartidores.Where(t => t != null).ToList();
         cmbrepartidores.ValueMember = "IdRepartidor";
         cmbrepartidores.DisplayMember = "NombreRepartidor";
         cmbrepartidores.ValueMember = "PrimerApellidoR";
         cmbrepartidores.ValueMember = "SegundoApellidoR";

      }

      // Metodo para registrar
      private void btnRegistrar_Click(object sender, EventArgs e)
      {
         // Validar campos obligatorios
         if (string.IsNullOrWhiteSpace(txtIdPedido.Text) ||
             cmbcliente.SelectedIndex == -1 ||
             cmbrepartidores.SelectedIndex == -1 ||
             string.IsNullOrWhiteSpace(txtDireccionPedido.Text))
         {
            MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }

         try
         {
            // Valida el  ID como número entero
            if (!int.TryParse(txtIdPedido.Text, out int idPedido))
            {
               MessageBox.Show("El ID del pedido debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            // Valida la  fecha para que no sea anterior a hoy
            DateTime fechaPedido = dtpFechaPedido.Value.Date;
            if (fechaPedido < DateTime.Today)
            {
               MessageBox.Show("La fecha del pedido no puede ser anterior al día actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
            }

            // Obtine los  cliente y repartidores seleccionados
            Clientes clienteSeleccionado = cmbcliente.SelectedItem as Clientes;
            Repartidores repartidorSeleccionado = cmbrepartidores.SelectedItem as Repartidores;

            if (clienteSeleccionado == null || repartidorSeleccionado == null)
            {
               MessageBox.Show("Debe seleccionar un cliente y un repartidor válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            // Crear objeto pedido con los 
            Pedidos nuevoPedido = new Pedidos
            {
               IdPedido = idPedido,
               FechaPedido = fechaPedido,
               cliente = clienteSeleccionado,
               repartidores = repartidorSeleccionado,
               DireccionPedido = txtDireccionPedido.Text
            };

            // Llamada a la capa de negocio para  registrar un nuevo pedido
            string mensaje = NegocioPedido.RegistrarPedidos(nuevoPedido);
            MessageBox.Show(mensaje);

            if (mensaje.StartsWith("Se ha registrado"))
            {
               LimpiarCampos();// se llama al metodo para limpiar los campos
               // Se llama al metodo para generar un nuevo id
               txtIdPedido.Text = DatosPedidos.ObtenerSiguienteId().ToString();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al registrar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      // Metodo para limpiar los campos
      private void LimpiarCampos()
      {
         txtIdPedido.Clear();
         txtDireccionPedido.Clear();
         cmbcliente.SelectedIndex = -1;
         cmbrepartidores.SelectedIndex = -1;
         dtpFechaPedido.Value = DateTime.Today;
      }

      // Botón para regresar al formulario anterior
      private void btnRegresar_Click(object sender, EventArgs e)
      {
         FormRepartidores formRepartidores = new FormRepartidores();
         formRepartidores.Show();// Se muestra el formulario anterior
         this.Hide();// Se oculta el formulario actual
      }

      // Botón para salir de la aplicación
      private void btnSalir_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      // Metodo para pasar al siguiente formulario
      private void btnSiguiente_Click(object sender, EventArgs e)
      {
         FormDetallePedidos siguiente = new FormDetallePedidos();
         siguiente.Show();// Muestra el siguiente formulario
         this.Hide();// Oculta el actual
      }

      //Metodo para consultar los pedidos
      private void btnConsultar_Click(object sender, EventArgs e)
      {
         // Se crea variable 'pedidos', se llama a 'NeogcioPedido' para consultar
         var pedidos = NegocioPedido.ConsultarPedidos();

         // Se carga el DataGridView
         dgvConsultas.DataSource = null;
         dgvConsultas.DataSource = pedidos;

         // Personaliza los nombres de las columnas
         if (dgvConsultas.Columns.Count > 0)
         {
            dgvConsultas.Columns["IdPedido"].HeaderText = "ID Pedido";
            dgvConsultas.Columns["FechaPedido"].HeaderText = "Fecha";
            dgvConsultas.Columns["IdCliente"].HeaderText = "ID Cliente";
            dgvConsultas.Columns["NombreCliente"].HeaderText = "Nombre Cliente";
            dgvConsultas.Columns["PrimerApellidoC"].HeaderText = "Apellido 1 Cliente";
            dgvConsultas.Columns["SegundoApellidoC"].HeaderText = "Apellido 2 Cliente";
            dgvConsultas.Columns["IdRepartidor"].HeaderText = "ID Repartidor";
            dgvConsultas.Columns["NombreRepartidor"].HeaderText = "Nombre Repartidor";
            dgvConsultas.Columns["PrimerApellidoR"].HeaderText = "Apellido 1 Repartidor";
            dgvConsultas.Columns["SegundoApellidoR"].HeaderText = "Apellido 2 Repartidor";
            dgvConsultas.Columns["DireccionPedido"].HeaderText = "Dirección";
         }
      }

      /*private void txtIdPedido_TextChanged(object sender, EventArgs e)
      {

      }*/
   }


}
