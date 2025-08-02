namespace Presentacion
{
   partial class FormRepartidores
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
         txtIdRepartidor = new TextBox();
         txtNombreRepartidor = new TextBox();
         txtPrimerApellidoR = new TextBox();
         txtSegundoApellidoR = new TextBox();
         dtpFechaNacimientoR = new DateTimePicker();
         dtpFechaContratacionR = new DateTimePicker();
         cmbEstadoRepartidor = new ComboBox();
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
         label7 = new Label();
         label8 = new Label();
         ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
         SuspendLayout();
         // 
         // txtIdRepartidor
         // 
         txtIdRepartidor.BackColor = SystemColors.InactiveCaption;
         txtIdRepartidor.Location = new Point(12, 37);
         txtIdRepartidor.Name = "txtIdRepartidor";
         txtIdRepartidor.Size = new Size(100, 23);
         txtIdRepartidor.TabIndex = 0;
         // 
         // txtNombreRepartidor
         // 
         txtNombreRepartidor.BackColor = SystemColors.InactiveCaption;
         txtNombreRepartidor.Location = new Point(133, 37);
         txtNombreRepartidor.Name = "txtNombreRepartidor";
         txtNombreRepartidor.Size = new Size(100, 23);
         txtNombreRepartidor.TabIndex = 1;
         // 
         // txtPrimerApellidoR
         // 
         txtPrimerApellidoR.BackColor = SystemColors.InactiveCaption;
         txtPrimerApellidoR.Location = new Point(250, 37);
         txtPrimerApellidoR.Name = "txtPrimerApellidoR";
         txtPrimerApellidoR.Size = new Size(100, 23);
         txtPrimerApellidoR.TabIndex = 2;
         // 
         // txtSegundoApellidoR
         // 
         txtSegundoApellidoR.BackColor = SystemColors.InactiveCaption;
         txtSegundoApellidoR.Location = new Point(369, 37);
         txtSegundoApellidoR.Name = "txtSegundoApellidoR";
         txtSegundoApellidoR.Size = new Size(100, 23);
         txtSegundoApellidoR.TabIndex = 3;
         // 
         // dtpFechaNacimientoR
         // 
         dtpFechaNacimientoR.Location = new Point(12, 90);
         dtpFechaNacimientoR.Name = "dtpFechaNacimientoR";
         dtpFechaNacimientoR.Size = new Size(200, 23);
         dtpFechaNacimientoR.TabIndex = 4;
         // 
         // dtpFechaContratacionR
         // 
         dtpFechaContratacionR.Location = new Point(250, 90);
         dtpFechaContratacionR.Name = "dtpFechaContratacionR";
         dtpFechaContratacionR.Size = new Size(200, 23);
         dtpFechaContratacionR.TabIndex = 5;
         // 
         // cmbEstadoRepartidor
         // 
         cmbEstadoRepartidor.FormattingEnabled = true;
         cmbEstadoRepartidor.Location = new Point(487, 90);
         cmbEstadoRepartidor.Name = "cmbEstadoRepartidor";
         cmbEstadoRepartidor.Size = new Size(121, 23);
         cmbEstadoRepartidor.TabIndex = 6;
         // 
         // dgvConsultas
         // 
         dgvConsultas.BackgroundColor = SystemColors.ButtonFace;
         dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvConsultas.Location = new Point(12, 378);
         dgvConsultas.Name = "dgvConsultas";
         dgvConsultas.Size = new Size(776, 60);
         dgvConsultas.TabIndex = 7;
         // 
         // btnRegistrar
         // 
         btnRegistrar.BackColor = Color.MediumAquamarine;
         btnRegistrar.Location = new Point(698, 89);
         btnRegistrar.Name = "btnRegistrar";
         btnRegistrar.Size = new Size(75, 23);
         btnRegistrar.TabIndex = 8;
         btnRegistrar.Text = "Registrar";
         btnRegistrar.UseVisualStyleBackColor = false;
         btnRegistrar.Click += btnRegistrar_Click;
         // 
         // btnRegresar
         // 
         btnRegresar.BackColor = Color.SandyBrown;
         btnRegresar.Location = new Point(698, 46);
         btnRegresar.Name = "btnRegresar";
         btnRegresar.Size = new Size(75, 23);
         btnRegresar.TabIndex = 9;
         btnRegresar.Text = "Regresar";
         btnRegresar.UseVisualStyleBackColor = false;
         btnRegresar.Click += btnRegresar_Click;
         // 
         // btnConsultar
         // 
         btnConsultar.BackColor = Color.IndianRed;
         btnConsultar.Location = new Point(698, 135);
         btnConsultar.Name = "btnConsultar";
         btnConsultar.Size = new Size(75, 23);
         btnConsultar.TabIndex = 10;
         btnConsultar.Text = "Consultar";
         btnConsultar.UseVisualStyleBackColor = false;
         btnConsultar.Click += btnConsultar_Click;
         // 
         // btnSalir
         // 
         btnSalir.BackColor = Color.Coral;
         btnSalir.Location = new Point(698, 180);
         btnSalir.Name = "btnSalir";
         btnSalir.Size = new Size(75, 23);
         btnSalir.TabIndex = 11;
         btnSalir.Text = "Salir";
         btnSalir.UseVisualStyleBackColor = false;
         btnSalir.Click += btnSalir_Click;
         // 
         // btnSiguiente
         // 
         btnSiguiente.BackColor = Color.LimeGreen;
         btnSiguiente.Location = new Point(698, 233);
         btnSiguiente.Name = "btnSiguiente";
         btnSiguiente.Size = new Size(75, 23);
         btnSiguiente.TabIndex = 12;
         btnSiguiente.Text = "Siguiente";
         btnSiguiente.UseVisualStyleBackColor = false;
         btnSiguiente.Click += btnSiguiente_Click;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.BackColor = Color.Transparent;
         label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label1.Location = new Point(19, 63);
         label1.Name = "label1";
         label1.Size = new Size(83, 15);
         label1.TabIndex = 13;
         label1.Text = "Identificación";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.BackColor = Color.Transparent;
         label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(161, 63);
         label2.Name = "label2";
         label2.Size = new Size(53, 15);
         label2.TabIndex = 14;
         label2.Text = "Nombre";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.BackColor = Color.Transparent;
         label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label3.Location = new Point(250, 63);
         label3.Name = "label3";
         label3.Size = new Size(91, 15);
         label3.TabIndex = 15;
         label3.Text = "Primer apellido";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.BackColor = Color.Transparent;
         label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label4.Location = new Point(370, 63);
         label4.Name = "label4";
         label4.Size = new Size(102, 15);
         label4.TabIndex = 16;
         label4.Text = "Segundo apellido";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.BackColor = Color.Transparent;
         label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label5.Location = new Point(522, 116);
         label5.Name = "label5";
         label5.Size = new Size(48, 15);
         label5.TabIndex = 17;
         label5.Text = "Activo?";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.BackColor = Color.Transparent;
         label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label6.Location = new Point(52, 116);
         label6.Name = "label6";
         label6.Size = new Size(121, 15);
         label6.TabIndex = 18;
         label6.Text = "Fecha de nacimiento";
         // 
         // label7
         // 
         label7.AutoSize = true;
         label7.BackColor = Color.Transparent;
         label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label7.Location = new Point(290, 116);
         label7.Name = "label7";
         label7.Size = new Size(129, 15);
         label7.TabIndex = 19;
         label7.Text = "Fecha de contratacion";
         // 
         // label8
         // 
         label8.AutoSize = true;
         label8.BackColor = Color.Transparent;
         label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label8.Location = new Point(339, 9);
         label8.Name = "label8";
         label8.Size = new Size(163, 21);
         label8.TabIndex = 20;
         label8.Text = "Datos del repartidor";
         // 
         // FormRepartidores
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         BackgroundImage = Properties.Resources.ImagenTarea;
         ClientSize = new Size(800, 450);
         Controls.Add(label8);
         Controls.Add(label7);
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
         Controls.Add(cmbEstadoRepartidor);
         Controls.Add(dtpFechaContratacionR);
         Controls.Add(dtpFechaNacimientoR);
         Controls.Add(txtSegundoApellidoR);
         Controls.Add(txtPrimerApellidoR);
         Controls.Add(txtNombreRepartidor);
         Controls.Add(txtIdRepartidor);
         Name = "FormRepartidores";
         Text = "FormRepartidores";
         ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private TextBox txtIdRepartidor;
      private TextBox txtNombreRepartidor;
      private TextBox txtPrimerApellidoR;
      private TextBox txtSegundoApellidoR;
      private DateTimePicker dtpFechaNacimientoR;
      private DateTimePicker dtpFechaContratacionR;
      private ComboBox cmbEstadoRepartidor;
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
      private Label label7;
      private Label label8;
   }
}