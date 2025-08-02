namespace Presentacion
{
   partial class FormClientes
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
         txtIdCliente = new TextBox();
         txtNombreCliente = new TextBox();
         txtPrimerApellidoC = new TextBox();
         txtSegundoApellidoC = new TextBox();
         dtpFechaNacimientoC = new DateTimePicker();
         cmbActivo = new ComboBox();
         dgvConsultas = new DataGridView();
         btnRegistrar = new Button();
         btnRegresar = new Button();
         btnConsultar = new Button();
         btnSalir = new Button();
         btnSiguiente = new Button();
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         label4 = new Label();
         label5 = new Label();
         label6 = new Label();
         ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
         SuspendLayout();
         // 
         // txtIdCliente
         // 
         txtIdCliente.BackColor = SystemColors.InactiveCaption;
         txtIdCliente.Location = new Point(28, 28);
         txtIdCliente.Name = "txtIdCliente";
         txtIdCliente.Size = new Size(100, 23);
         txtIdCliente.TabIndex = 0;
         // 
         // txtNombreCliente
         // 
         txtNombreCliente.BackColor = SystemColors.InactiveCaption;
         txtNombreCliente.Location = new Point(28, 86);
         txtNombreCliente.Name = "txtNombreCliente";
         txtNombreCliente.Size = new Size(100, 23);
         txtNombreCliente.TabIndex = 1;
         // 
         // txtPrimerApellidoC
         // 
         txtPrimerApellidoC.BackColor = SystemColors.InactiveCaption;
         txtPrimerApellidoC.Location = new Point(28, 143);
         txtPrimerApellidoC.Name = "txtPrimerApellidoC";
         txtPrimerApellidoC.Size = new Size(100, 23);
         txtPrimerApellidoC.TabIndex = 2;
         // 
         // txtSegundoApellidoC
         // 
         txtSegundoApellidoC.BackColor = SystemColors.InactiveCaption;
         txtSegundoApellidoC.Location = new Point(28, 198);
         txtSegundoApellidoC.Name = "txtSegundoApellidoC";
         txtSegundoApellidoC.Size = new Size(100, 23);
         txtSegundoApellidoC.TabIndex = 3;
         // 
         // dtpFechaNacimientoC
         // 
         dtpFechaNacimientoC.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         dtpFechaNacimientoC.CalendarMonthBackground = SystemColors.InactiveCaption;
         dtpFechaNacimientoC.Location = new Point(28, 255);
         dtpFechaNacimientoC.Name = "dtpFechaNacimientoC";
         dtpFechaNacimientoC.Size = new Size(200, 23);
         dtpFechaNacimientoC.TabIndex = 4;
         // 
         // cmbActivo
         // 
         cmbActivo.BackColor = SystemColors.InactiveCaption;
         cmbActivo.FormattingEnabled = true;
         cmbActivo.Location = new Point(28, 309);
         cmbActivo.Name = "cmbActivo";
         cmbActivo.Size = new Size(121, 23);
         cmbActivo.TabIndex = 5;
         // 
         // dgvConsultas
         // 
         dgvConsultas.BackgroundColor = SystemColors.ButtonFace;
         dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvConsultas.Location = new Point(194, 14);
         dgvConsultas.Name = "dgvConsultas";
         dgvConsultas.Size = new Size(594, 95);
         dgvConsultas.TabIndex = 6;
         // 
         // btnRegistrar
         // 
         btnRegistrar.BackColor = Color.LightGreen;
         btnRegistrar.Location = new Point(203, 376);
         btnRegistrar.Name = "btnRegistrar";
         btnRegistrar.Size = new Size(75, 23);
         btnRegistrar.TabIndex = 7;
         btnRegistrar.Text = "Registrar";
         btnRegistrar.UseVisualStyleBackColor = false;
         btnRegistrar.Click += btnRegistrar_Click;
         // 
         // btnRegresar
         // 
         btnRegresar.BackColor = Color.Chocolate;
         btnRegresar.Location = new Point(74, 376);
         btnRegresar.Name = "btnRegresar";
         btnRegresar.Size = new Size(75, 23);
         btnRegresar.TabIndex = 8;
         btnRegresar.Text = "Regresar";
         btnRegresar.UseVisualStyleBackColor = false;
         btnRegresar.Click += btnRegresar_Click;
         // 
         // btnConsultar
         // 
         btnConsultar.BackColor = Color.IndianRed;
         btnConsultar.Location = new Point(352, 376);
         btnConsultar.Name = "btnConsultar";
         btnConsultar.Size = new Size(75, 23);
         btnConsultar.TabIndex = 9;
         btnConsultar.Text = "Consultar";
         btnConsultar.UseVisualStyleBackColor = false;
         btnConsultar.Click += btnConsultar_Click;
         // 
         // btnSalir
         // 
         btnSalir.BackColor = Color.Red;
         btnSalir.Location = new Point(500, 376);
         btnSalir.Name = "btnSalir";
         btnSalir.Size = new Size(75, 23);
         btnSalir.TabIndex = 10;
         btnSalir.Text = "Salir";
         btnSalir.UseVisualStyleBackColor = false;
         btnSalir.Click += btnSalir_Click;
         // 
         // btnSiguiente
         // 
         btnSiguiente.BackColor = Color.Lime;
         btnSiguiente.Location = new Point(634, 376);
         btnSiguiente.Name = "btnSiguiente";
         btnSiguiente.Size = new Size(75, 23);
         btnSiguiente.TabIndex = 11;
         btnSiguiente.Text = "Siguiente";
         btnSiguiente.UseVisualStyleBackColor = false;
         btnSiguiente.Click += btnSiguiente_Click;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.BackColor = Color.Transparent;
         label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label1.Location = new Point(28, 10);
         label1.Name = "label1";
         label1.Size = new Size(136, 15);
         label1.TabIndex = 12;
         label1.Text = "Ingrese el ID de cliente";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.BackColor = Color.Transparent;
         label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(28, 68);
         label2.Name = "label2";
         label2.Size = new Size(157, 15);
         label2.TabIndex = 13;
         label2.Text = "Ingrese nombre del cliente";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.BackColor = Color.Transparent;
         label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label3.Location = new Point(28, 125);
         label3.Name = "label3";
         label3.Size = new Size(116, 15);
         label3.TabIndex = 14;
         label3.Text = "Ingrese 1er Apelldo";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.BackColor = Color.Transparent;
         label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label4.Location = new Point(28, 180);
         label4.Name = "label4";
         label4.Size = new Size(121, 15);
         label4.TabIndex = 15;
         label4.Text = "Ingrese 2do Apellido";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.BackColor = Color.Transparent;
         label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label5.Location = new Point(28, 237);
         label5.Name = "label5";
         label5.Size = new Size(148, 15);
         label5.TabIndex = 16;
         label5.Text = "Ingrese fecha nacimiento";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.BackColor = Color.Transparent;
         label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label6.Location = new Point(28, 291);
         label6.Name = "label6";
         label6.Size = new Size(48, 15);
         label6.TabIndex = 17;
         label6.Text = "Activo?";
         // 
         // FormClientes
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         BackgroundImage = Properties.Resources.ImagenTarea;
         ClientSize = new Size(800, 450);
         Controls.Add(label6);
         Controls.Add(label5);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(label1);
         Controls.Add(btnSiguiente);
         Controls.Add(btnSalir);
         Controls.Add(btnConsultar);
         Controls.Add(btnRegresar);
         Controls.Add(btnRegistrar);
         Controls.Add(dgvConsultas);
         Controls.Add(cmbActivo);
         Controls.Add(dtpFechaNacimientoC);
         Controls.Add(txtSegundoApellidoC);
         Controls.Add(txtPrimerApellidoC);
         Controls.Add(txtNombreCliente);
         Controls.Add(txtIdCliente);
         Name = "FormClientes";
         Text = "FormClientes";
         ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      private void BtnRegresar_Click(object sender, EventArgs e)
      {
         throw new NotImplementedException();
      }

      #endregion

      private TextBox txtIdCliente;
      private TextBox txtNombreCliente;
      private TextBox txtPrimerApellidoC;
      private TextBox txtSegundoApellidoC;
      private DateTimePicker dtpFechaNacimientoC;
      private ComboBox cmbActivo;
      private DataGridView dgvConsultas;
      private Button btnRegistrar;
      private Button btnRegresar;
      private Button btnConsultar;
      private Button btnSalir;
      private Button btnSiguiente;
      private Label label1;
      private Label label2;
      private Label label3;
      private Label label4;
      private Label label5;
      private Label label6;
   }
}