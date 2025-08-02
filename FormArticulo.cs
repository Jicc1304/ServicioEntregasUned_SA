/**
 * UNED II Cuatrimestre
 * Proyecto 1: Aplicacion de escritorio Entregas S.A
 * Estudiante: Jose Isaac Castillo Cordero
 * Cedula: 206270017
 * Fecha: 15/06/25
 */
using System;
using System.Linq;
using System.Windows.Forms;
using Datos;
using Negocio;
using Entidades;

namespace Presentacion
{
   // Declaracion del 'FormArticulo'
   public partial class FormArticulo : Form
   {
      // Se inicializan metodos
      public FormArticulo()
      {
         InitializeComponent();
         CargarTiposArticulo();
         CargarEstados();

         //  funciona para asignar el ID automático en 1 al empezar
         txtIdArticulo.Text = DatosArticulo.ObtenerSiguienteId().ToString();
         txtIdArticulo.ReadOnly = true;

      }
      // carga los metodos nombrados
      private void FormArticulo_Load(object sender, EventArgs e)
      {
         CargarTiposArticulo();
         CargarEstados();
         ConfigurarDgvConsultas();

      }


      //metodo para mostrar los nombres de la columnas de forma ordenada
      private void ConfigurarDgvConsultas()
      {
         dgvConsultas.Columns["IdArticulo"].HeaderText = "ID Artículo";
         dgvConsultas.Columns["NombreArticulo"].HeaderText = "Nombre";
         dgvConsultas.Columns["TipoArticulo"].HeaderText = "Tipo";
         dgvConsultas.Columns["ValorArticulo"].HeaderText = "Valor ";
         dgvConsultas.Columns["InventarioArticulo"].HeaderText = "Inventario";
         dgvConsultas.Columns["Estado"].HeaderText = "Estado";
      }


      // Carga los tipos de artículo en el ComboBox
      private void CargarTiposArticulo()
      {
         var listaTipos = NegocioTipoArticulo.Consultar();

         if (listaTipos == null || listaTipos.Length == 0)
         {
            MessageBox.Show("No hay tipos de artículo registrados.");
            return;
         }

         cmbTipoArt.DataSource = listaTipos.Where(t => t != null).ToList();
         cmbTipoArt.DisplayMember = "NombreTipoArticulo";
         cmbTipoArt.ValueMember = "IdTipoArticulo";
         cmbTipoArt.SelectedIndex = -1;
      }

      // Carga los estados posibles (Activo'Sí'/Inactivo'No')
      private void CargarEstados()
      {
         cmbActivo.Items.Clear();
         cmbActivo.Items.Add("Sí");
         cmbActivo.Items.Add("No");
         cmbActivo.SelectedIndex = -1;
      }

      // Botón para registrar un artículo, se valida que los espacios no esten vacíos
      private void btnRegistrar_Click(object sender, EventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtIdArticulo.Text) ||
             string.IsNullOrWhiteSpace(txtNombreArticulo.Text) ||
             cmbTipoArt.SelectedIndex == -1 ||
             string.IsNullOrWhiteSpace(txtValorArticulo.Text) ||
             string.IsNullOrWhiteSpace(txtInventarioArticulo.Text) ||
             cmbActivo.SelectedIndex == -1)
         {
            MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }

         try
         {
            // Conversión y validaciones
            int idArticulo = int.Parse(txtIdArticulo.Text.Trim());
            string nombreArticulo = txtNombreArticulo.Text.Trim();
            TipoArticulo tipoSeleccionado = cmbTipoArt.SelectedItem as TipoArticulo;

            if (tipoSeleccionado == null)
            {
               MessageBox.Show("Seleccione un tipo de artículo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
            // se declara variable valorarticulo
            double valorArticulo = double.Parse(txtValorArticulo.Text.Trim());

            if (!int.TryParse(txtInventarioArticulo.Text.Trim(), out int inventarioArticulo) || inventarioArticulo <= 0)// Se valida que el el inventario no se ingrese en 0
            {
               MessageBox.Show("Debe ingresar un inventario válido (mayor a cero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            bool estadoArticulo = cmbActivo.SelectedItem.ToString() == "Sí";

            // sirve para construir el objeto Articulo, se declara nuevoarticulo y se le pasan los valores
            Articulo nuevoArticulo = new Articulo
            {
               IdArticulo = idArticulo,
               NombreArticulo = nombreArticulo,
               TipoArt = tipoSeleccionado,
               ValorArticulo = valorArticulo,
               InventarioArticulo = inventarioArticulo, 
               EstadoArticulo = estadoArticulo
            };

            // Se registra el artículo
            string mensaje = NegocioArticulo.RegistrarArticulo(nuevoArticulo);
            MessageBox.Show(mensaje);

            if (mensaje.StartsWith("Se ha registrado"))
            {
               LimpiarCampos();
              

               // Funciona asignando el próximo ID automáticamente
               txtIdArticulo.Text = DatosArticulo.ObtenerSiguienteId().ToString();

            }
         }
         catch (FormatException)
         {
            MessageBox.Show("El ID, el valor y el inventario deben ser valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al registrar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      // Limpia todos los campos del formulario
      private void LimpiarCampos()
      {
         txtIdArticulo.Clear();
         txtNombreArticulo.Clear();
         txtValorArticulo.Clear();
         txtInventarioArticulo.Clear(); 
         cmbTipoArt.SelectedIndex = -1;
         cmbActivo.SelectedIndex = -1;
         txtIdArticulo.Focus();
      }

      // Muestra los artículos en el DataGridView
      private void btnConsultar_Click(object sender, EventArgs e)
      {
         var articulos = NegocioArticulo.Consultar();

         if (articulos == null || articulos.Length == 0 || articulos.All(a => a == null))
         {
            MessageBox.Show("No hay artículos registrados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }

         dgvConsultas.DataSource = null;// muestra los datos en el DataGridView

         // Mostrar nombre del tipo de artículo y estado legible y ordenada
         dgvConsultas.DataSource = articulos.Where(a => a != null).Select(a => new
         {
            a.IdArticulo,
            a.NombreArticulo,
            TipoArticulo = a.TipoArt?.NombreTipoArticulo,
            ValorArticulo = "₡" + a.ValorArticulo.ToString("N2"), // Convierte los valores en colones y con dos decimales
            a.InventarioArticulo,
            Estado = a.EstadoArticulo ? "Sí" : "No"
         }).ToList();

         ConfigurarDgvConsultas();// Se llama al metodo que ordena los nombres de las columnas
      }

      // Botón para regresar
      private void btnRegresar_Click(object sender, EventArgs e)
      {
         FormTipoArticulo formTipoArticulo = new FormTipoArticulo();
         formTipoArticulo.Show();
         this.Hide();
      }

      // Botón para salir
      private void btnSalir_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      // Botón para avanzar a Clientes
      private void btnSiguiente_Click(object sender, EventArgs e)
      {
         FormClientes formClientes = new FormClientes();
         formClientes.Show();
         this.Hide();
      }
   }
}

