namespace Presentacion
{
   partial class FormDetallePedidos
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
         cmbPedidos = new ComboBox();
         cmbArticulos = new ComboBox();
         txtCantidad = new TextBox();
         dgvConsultas = new DataGridView();
         btnRegistrar = new Button();
         btnConsultar = new Button();
         btnSalir = new Button();
         btnRegresar = new Button();
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         label4 = new Label();
         label5 = new Label();
         ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
         SuspendLayout();
         // 
         // cmbPedidos
         // 
         cmbPedidos.BackColor = SystemColors.InactiveCaption;
         cmbPedidos.FormattingEnabled = true;
         cmbPedidos.Location = new Point(28, 62);
         cmbPedidos.Name = "cmbPedidos";
         cmbPedidos.Size = new Size(121, 23);
         cmbPedidos.TabIndex = 0;
         // 
         // cmbArticulos
         // 
         cmbArticulos.BackColor = SystemColors.InactiveCaption;
         cmbArticulos.FormattingEnabled = true;
         cmbArticulos.Location = new Point(28, 121);
         cmbArticulos.Name = "cmbArticulos";
         cmbArticulos.Size = new Size(121, 23);
         cmbArticulos.TabIndex = 1;
         // 
         // txtCantidad
         // 
         txtCantidad.BackColor = SystemColors.InactiveCaption;
         txtCantidad.Location = new Point(28, 184);
         txtCantidad.Name = "txtCantidad";
         txtCantidad.Size = new Size(121, 23);
         txtCantidad.TabIndex = 2;
         // 
         // dgvConsultas
         // 
         dgvConsultas.BackgroundColor = SystemColors.ButtonFace;
         dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvConsultas.Location = new Point(12, 378);
         dgvConsultas.Name = "dgvConsultas";
         dgvConsultas.Size = new Size(776, 60);
         dgvConsultas.TabIndex = 3;
         // 
         // btnRegistrar
         // 
         btnRegistrar.BackColor = Color.LightGreen;
         btnRegistrar.Location = new Point(602, 95);
         btnRegistrar.Name = "btnRegistrar";
         btnRegistrar.Size = new Size(75, 23);
         btnRegistrar.TabIndex = 5;
         btnRegistrar.Text = "Registrar";
         btnRegistrar.UseVisualStyleBackColor = false;
         btnRegistrar.Click += btnRegistrar_Click;
         // 
         // btnConsultar
         // 
         btnConsultar.BackColor = Color.IndianRed;
         btnConsultar.Location = new Point(602, 130);
         btnConsultar.Name = "btnConsultar";
         btnConsultar.Size = new Size(75, 23);
         btnConsultar.TabIndex = 6;
         btnConsultar.Text = "Consultar";
         btnConsultar.UseVisualStyleBackColor = false;
         this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);

         // 
         // btnSalir
         // 
         btnSalir.BackColor = Color.LimeGreen;
         btnSalir.Location = new Point(602, 163);
         btnSalir.Name = "btnSalir";
         btnSalir.Size = new Size(75, 23);
         btnSalir.TabIndex = 7;
         btnSalir.Text = "Salir";
         btnSalir.UseVisualStyleBackColor = false;
         this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
         // 
         // btnRegresar
         // 
         btnRegresar.BackColor = Color.SaddleBrown;
         btnRegresar.Location = new Point(602, 62);
         btnRegresar.Name = "btnRegresar";
         btnRegresar.Size = new Size(75, 23);
         btnRegresar.TabIndex = 8;
         btnRegresar.Text = "Regresar";
         btnRegresar.UseVisualStyleBackColor = false;
         this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.BackColor = Color.Transparent;
         label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label1.Location = new Point(48, 44);
         label1.Name = "label1";
         label1.Size = new Size(78, 15);
         label1.TabIndex = 9;
         label1.Text = "ID de pedido";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.BackColor = Color.Transparent;
         label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(60, 99);
         label2.Name = "label2";
         label2.Size = new Size(51, 15);
         label2.TabIndex = 10;
         label2.Text = "Articulo";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.BackColor = Color.Transparent;
         label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label3.Location = new Point(60, 166);
         label3.Name = "label3";
         label3.Size = new Size(55, 15);
         label3.TabIndex = 11;
         label3.Text = "Cantidad";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.BackColor = Color.Transparent;
         label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label4.Location = new Point(319, 316);
         label4.Name = "label4";
         label4.Size = new Size(181, 25);
         label4.TabIndex = 12;
         label4.Text = "Detalles del pedido";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.BackColor = Color.Transparent;
         label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label5.Location = new Point(206, 9);
         label5.Name = "label5";
         label5.Size = new Size(380, 25);
         label5.TabIndex = 13;
         label5.Text = "Seleccione los datos de detalle del pedido";
         // 
         // FormDetallePedidos
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         BackgroundImage = Properties.Resources.ImagenTarea;
         ClientSize = new Size(800, 450);
         Controls.Add(label5);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(label1);
         Controls.Add(btnRegresar);
         Controls.Add(btnSalir);
         Controls.Add(btnConsultar);
         Controls.Add(btnRegistrar);
         Controls.Add(dgvConsultas);
         Controls.Add(txtCantidad);
         Controls.Add(cmbArticulos);
         Controls.Add(cmbPedidos);
         Name = "FormDetallePedidos";
         Text = "FormDetallePedidos";
         ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private ComboBox cmbPedidos;
      private ComboBox cmbArticulos;
      private TextBox txtCantidad;
      private DataGridView dgvConsultas;
      private Button btnRegistrar;
      private Button btnConsultar;
      private Button btnSalir;
      private Button btnRegresar;
      private Label label1;
      private Label label2;
      private Label label3;
      private Label label4;
      private Label label5;
   }
}