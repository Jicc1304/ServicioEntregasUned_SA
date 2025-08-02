/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */
using Entidades;
using Negocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
   // Declaracionde la clase 'FormDetallePedidos'
   public partial class FormDetallePedidos : Form
   {
      public FormDetallePedidos()
      {
         // Se inicializa la carga de pedidos,articulos y el Dgv organizado
         InitializeComponent();
         CargarPedidos();
         CargarArticulos();
         ConfigurarDgvConsultas();


      }
      // Metodo para mostarr los datos en el dataViewGrid de forma ordenada
      private void ConfigurarDgvConsultas()
      {
         dgvConsultas.Columns.Clear();
         dgvConsultas.AutoGenerateColumns = false;
         dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         dgvConsultas.AllowUserToAddRows = false;
         dgvConsultas.ReadOnly = true;
         dgvConsultas.RowHeadersVisible = false;

         dgvConsultas.Columns.Add("IdPedido", "ID Pedido");
         dgvConsultas.Columns.Add("IdArticulo", "ID Artículo");
         dgvConsultas.Columns.Add("NombreArticulo", "Nombre del Artículo");
         dgvConsultas.Columns.Add("TipoArticulo", "Tipo de Artículo");
         dgvConsultas.Columns.Add("Cantidad", "Cantidad");
         dgvConsultas.Columns.Add("Monto", "Monto");

         dgvConsultas.Columns["Monto"].DefaultCellStyle.Format = "C"; // Muestra en formato moneda
         dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      }


      // Carga todos los pedidos en el ComboBox
      private void CargarPedidos()
      {
         // Declara variable 'pedidos' con valores del metodo Consultar de la clase NegocioPedido 
         var pedidos = NegocioPedido.Consultar();
         cmbPedidos.DataSource = pedidos.Where(p => p != null).ToList();
         cmbPedidos.DisplayMember = "IdPedido";
         cmbPedidos.ValueMember = "IdPedido";
         cmbPedidos.SelectedIndex = -1;
      }

      // Carga todos los artículos activos con inventario
      private void CargarArticulos()
      {
         // Se declara variable 'articulos' de el metodo consultar de la clase 'NegocioArticulo' para cargar en cmb
         var articulos = NegocioArticulo.Consultar();
         cmbArticulos.DataSource = articulos
             .Where(a => a != null && a.EstadoArticulo && a.InventarioArticulo > 0)
             .ToList();
         cmbArticulos.DisplayMember = "NombreArticulo";
         cmbArticulos.ValueMember = "IdArticulo";
         cmbArticulos.SelectedIndex = -1;
      }

      // Registrar detalle del pedido
      private void btnRegistrar_Click(object sender, EventArgs e)
      {
         try
         {
            if (cmbPedidos.SelectedItem == null || cmbArticulos.SelectedItem == null)
            {
               MessageBox.Show("Debe seleccionar un pedido y un artículo.");
               return;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
               MessageBox.Show("Debe ingresar una cantidad.");
               return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
               MessageBox.Show("La cantidad debe ser un número entero positivo.");
               return;
            }
            // Se crea Pedidos tomando los valores de los cmb
            Pedidos pedido = (Pedidos)cmbPedidos.SelectedItem;
            //Se toman los articulos del cmb
            Articulo articulo = (Articulo)cmbArticulos.SelectedItem;

            // Se crea un nuevo detalle de pedido
            DetallePedidos nuevoDetalle = new DetallePedidos
            {
               Pedido = pedido,
               Articulo = articulo,
               CantidadArticulos = cantidad
            };

            string resultado = NegocioDetallePedidos.RegistrarDetalle(nuevoDetalle);
            MessageBox.Show(resultado);

            if (resultado.Contains("correctamente"))
            {
               
               txtCantidad.Clear();// Se limpia el espacio de cantidad
               CargarArticulos(); // Se llama al metodo CargarArticulos
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error inesperado: " + ex.Message);
         }
      }

      // Muestra los  detalles del pedido seleccionado
      private void MostrarDetallesPedido(int idPedido)
      {
         // Se declara variable 'detalles' que estan asociados a cda pedido por su idPedido
         var detalles = NegocioDetallePedidos.ConsultarPorPedido(idPedido);
         dgvConsultas.Rows.Clear();// Limpia los campos de Dgv

         //Se recorre cada detalle
         foreach (var d in detalles.Where(d => d != null))
         {
            // Agrega los detalles a las columnas asignadas
            dgvConsultas.Rows.Add(
                d.Pedido.IdPedido,
                d.Articulo.IdArticulo,
                d.Articulo.NombreArticulo,
                d.Articulo.TipoArt?.NombreTipoArticulo,
                d.CantidadArticulos,
                d.ValorArticulo.ToString("C")
            );
         }
      }

      // Metodo para cargar detalles del pedido automaticamente al seleccionar el id del pedido
      private void cmbPedidos_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (cmbPedidos.SelectedItem is Pedidos pedido)
         {
            MostrarDetallesPedido(pedido.IdPedido);
         }
      }

      // Botón Consultar 
      private void btnConsultar_Click(object sender, EventArgs e)
      {
         if (cmbPedidos.SelectedItem is Pedidos pedido)
         {
            MostrarDetallesPedido(pedido.IdPedido);// Muestra los detalles
         }
      }

      // Botón para salir de la aplicación
      private void btnSalir_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      // Botón para regresar al formulario anterior
      private void btnRegresar_Click(object sender, EventArgs e)
      {
         FormPedidos formPedidos = new FormPedidos();
         formPedidos.Show();// Muestra el formulario anterior
         this.Hide();// Oculta el formulario actual
      }

      
   }
}
