namespace Presentacion
{
   partial class FormArticulo
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         txtIdArticulo = new TextBox();
         txtNombreArticulo = new TextBox();
         txtValorArticulo = new TextBox();
         txtInventarioArticulo = new TextBox();
         cmbTipoArt = new ComboBox();
         cmbActivo = new ComboBox();
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         label4 = new Label();
         label5 = new Label();
         label6 = new Label();
         dgvConsultas = new DataGridView();
         btnRegresar = new Button();
         btnRegistrar = new Button();
         btnConsultar = new Button();
         btnSalir = new Button();
         btnSiguiente = new Button();
         ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
         SuspendLayout();
         // 
         // txtIdArticulo
         // 
         txtIdArticulo.BackColor = SystemColors.InactiveCaption;
         txtIdArticulo.Location = new Point(12, 48);
         txtIdArticulo.Name = "txtIdArticulo";
         txtIdArticulo.Size = new Size(100, 23);
         txtIdArticulo.TabIndex = 0;
         // 
         // txtNombreArticulo
         // 
         txtNombreArticulo.BackColor = SystemColors.InactiveCaption;
         txtNombreArticulo.Location = new Point(12, 104);
         txtNombreArticulo.Name = "txtNombreArticulo";
         txtNombreArticulo.Size = new Size(100, 23);
         txtNombreArticulo.TabIndex = 1;
         // 
         // txtValorArticulo
         // 
         txtValorArticulo.BackColor = SystemColors.InactiveCaption;
         txtValorArticulo.Location = new Point(12, 210);
         txtValorArticulo.Name = "txtValorArticulo";
         txtValorArticulo.Size = new Size(100, 23);
         txtValorArticulo.TabIndex = 2;
         // 
         // txtInventarioArticulo
         // 
         txtInventarioArticulo.BackColor = SystemColors.InactiveCaption;
         txtInventarioArticulo.Location = new Point(12, 262);
         txtInventarioArticulo.Name = "txtInventarioArticulo";
         txtInventarioArticulo.Size = new Size(100, 23);
         txtInventarioArticulo.TabIndex = 3;
         // 
         // cmbTipoArt
         // 
         cmbTipoArt.BackColor = SystemColors.InactiveCaption;
         cmbTipoArt.FormattingEnabled = true;
         cmbTipoArt.Location = new Point(12, 155);
         cmbTipoArt.Name = "cmbTipoArt";
         cmbTipoArt.Size = new Size(121, 23);
         cmbTipoArt.TabIndex = 4;
         // 
         // cmbActivo
         // 
         cmbActivo.BackColor = SystemColors.InactiveCaption;
         cmbActivo.FormattingEnabled = true;
         cmbActivo.Location = new Point(12, 319);
         cmbActivo.Name = "cmbActivo";
         cmbActivo.Size = new Size(121, 23);
         cmbActivo.TabIndex = 5;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.BackColor = Color.Transparent;
         label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label1.Location = new Point(12, 30);
         label1.Name = "label1";
         label1.Size = new Size(151, 15);
         label1.TabIndex = 6;
         label1.Text = "Ingrese el 'ID' del articulo";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.BackColor = Color.Transparent;
         label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(12, 86);
         label2.Name = "label2";
         label2.Size = new Size(174, 15);
         label2.TabIndex = 7;
         label2.Text = "Ingrese el nombre del articulo";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.BackColor = Color.Transparent;
         label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label3.Location = new Point(12, 137);
         label3.Name = "label3";
         label3.Size = new Size(167, 15);
         label3.TabIndex = 8;
         label3.Text = "Seleccione el tipo de articulo";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.BackColor = Color.Transparent;
         label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label4.Location = new Point(12, 191);
         label4.Name = "label4";
         label4.Size = new Size(158, 15);
         label4.TabIndex = 9;
         label4.Text = "Ingrese el valor del articulo";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.BackColor = Color.Transparent;
         label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label5.Location = new Point(12, 244);
         label5.Name = "label5";
         label5.Size = new Size(188, 15);
         label5.TabIndex = 10;
         label5.Text = "Ingrese la cantidad en inventario";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.BackColor = Color.Transparent;
         label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label6.Location = new Point(12, 301);
         label6.Name = "label6";
         label6.Size = new Size(48, 15);
         label6.TabIndex = 11;
         label6.Text = "Activo?";
         // 
         // dgvConsultas
         // 
         dgvConsultas.BackgroundColor = SystemColors.ButtonFace;
         dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvConsultas.Location = new Point(201, 35);
         dgvConsultas.Name = "dgvConsultas";
         dgvConsultas.Size = new Size(573, 66);
         dgvConsultas.TabIndex = 12;
         // 
         // btnRegresar
         // 
         btnRegresar.BackColor = Color.Chocolate;
         btnRegresar.Location = new Point(12, 402);
         btnRegresar.Name = "btnRegresar";
         btnRegresar.Size = new Size(75, 23);
         btnRegresar.TabIndex = 13;
         btnRegresar.Text = "Regresar";
         btnRegresar.UseVisualStyleBackColor = false;
         btnRegresar.Click += btnRegresar_Click;
         // 
         // btnRegistrar
         // 
         btnRegistrar.BackColor = Color.LightGreen;
         btnRegistrar.Location = new Point(131, 402);
         btnRegistrar.Name = "btnRegistrar";
         btnRegistrar.Size = new Size(75, 23);
         btnRegistrar.TabIndex = 14;
         btnRegistrar.Text = "Registrar";
         btnRegistrar.UseVisualStyleBackColor = false;
         btnRegistrar.Click += btnRegistrar_Click;
         // 
         // btnConsultar
         // 
         btnConsultar.BackColor = Color.IndianRed;
         btnConsultar.Location = new Point(247, 402);
         btnConsultar.Name = "btnConsultar";
         btnConsultar.Size = new Size(75, 23);
         btnConsultar.TabIndex = 15;
         btnConsultar.Text = "Consultar";
         btnConsultar.UseVisualStyleBackColor = false;
         btnConsultar.Click += btnConsultar_Click;
         // 
         // btnSalir
         // 
         btnSalir.BackColor = Color.Tomato;
         btnSalir.Location = new Point(361, 402);
         btnSalir.Name = "btnSalir";
         btnSalir.Size = new Size(75, 23);
         btnSalir.TabIndex = 16;
         btnSalir.Text = "Salir";
         btnSalir.UseVisualStyleBackColor = false;
         btnSalir.Click += btnSalir_Click;
         // 
         // btnSiguiente
         // 
         btnSiguiente.BackColor = Color.LimeGreen;
         btnSiguiente.Location = new Point(489, 402);
         btnSiguiente.Name = "btnSiguiente";
         btnSiguiente.Size = new Size(75, 23);
         btnSiguiente.TabIndex = 17;
         btnSiguiente.Text = "Siguiente";
         btnSiguiente.UseVisualStyleBackColor = false;
         btnSiguiente.Click += btnSiguiente_Click;
         // 
         // FormArticulo
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         BackgroundImage = Properties.Resources.ImagenTarea;
         ClientSize = new Size(800, 450);
         Controls.Add(btnSiguiente);
         Controls.Add(btnSalir);
         Controls.Add(btnConsultar);
         Controls.Add(btnRegistrar);
         Controls.Add(btnRegresar);
         Controls.Add(dgvConsultas);
         Controls.Add(label6);
         Controls.Add(label5);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(label1);
         Controls.Add(cmbActivo);
         Controls.Add(cmbTipoArt);
         Controls.Add(txtInventarioArticulo);
         Controls.Add(txtValorArticulo);
         Controls.Add(txtNombreArticulo);
         Controls.Add(txtIdArticulo);
         Name = "FormArticulo";
         Text = "FormArticulo";
         ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private TextBox txtIdArticulo;
      private TextBox txtNombreArticulo;
      private TextBox txtValorArticulo;
      private TextBox txtInventarioArticulo;
      private ComboBox cmbTipoArt;
      private ComboBox cmbActivo;
      private Label label1;
      private Label label2;
      private Label label3;
      private Label label4;
      private Label label5;
      private Label label6;
      private DataGridView dgvConsultas;
      private Button btnRegresar;
      private Button btnRegistrar;
      private Button btnConsultar;
      private Button btnSalir;
      private Button btnSiguiente;
   }
}