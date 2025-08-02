namespace Presentacion
{
   partial class FormPedidos
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
         txtIdPedido = new TextBox();
         txtDireccionPedido = new TextBox();
         cmbcliente = new ComboBox();
         cmbrepartidores = new ComboBox();
         dtpFechaPedido = new DateTimePicker();
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         label4 = new Label();
         label5 = new Label();
         label6 = new Label();
         btnRegresar = new Button();
         btnRegistrar = new Button();
         btnSalir = new Button();
         btnSiguiente = new Button();
         btnConsultar = new Button();
         dgvConsultas = new DataGridView();
         ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
         SuspendLayout();
         // 
         // txtIdPedido
         // 
         txtIdPedido.BackColor = SystemColors.InactiveCaption;
         txtIdPedido.Location = new Point(12, 161);
         txtIdPedido.Name = "txtIdPedido";
         txtIdPedido.Size = new Size(100, 23);
         txtIdPedido.TabIndex = 0;
         //txtIdPedido.TextChanged += txtIdPedido_TextChanged;
         // 
         // txtDireccionPedido
         // 
         txtDireccionPedido.BackColor = SystemColors.InactiveCaption;
         txtDireccionPedido.Location = new Point(12, 428);
         txtDireccionPedido.Name = "txtDireccionPedido";
         txtDireccionPedido.Size = new Size(759, 23);
         txtDireccionPedido.TabIndex = 1;
         // 
         // cmbcliente
         // 
         cmbcliente.BackColor = SystemColors.InactiveCaption;
         cmbcliente.FormattingEnabled = true;
         cmbcliente.Location = new Point(12, 275);
         cmbcliente.Name = "cmbcliente";
         cmbcliente.Size = new Size(121, 23);
         cmbcliente.TabIndex = 2;
         // 
         // cmbrepartidores
         // 
         cmbrepartidores.BackColor = SystemColors.InactiveCaption;
         cmbrepartidores.FormattingEnabled = true;
         cmbrepartidores.Location = new Point(12, 332);
         cmbrepartidores.Name = "cmbrepartidores";
         cmbrepartidores.Size = new Size(121, 23);
         cmbrepartidores.TabIndex = 3;
         // 
         // dtpFechaPedido
         // 
         dtpFechaPedido.CalendarMonthBackground = SystemColors.InactiveCaption;
         dtpFechaPedido.Location = new Point(12, 216);
         dtpFechaPedido.Name = "dtpFechaPedido";
         dtpFechaPedido.Size = new Size(200, 23);
         dtpFechaPedido.TabIndex = 4;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.BackColor = Color.Transparent;
         label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label1.Location = new Point(2, 112);
         label1.Name = "label1";
         label1.Size = new Size(222, 21);
         label1.TabIndex = 5;
         label1.Text = "Ingreso de datos del pedido";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.BackColor = Color.Transparent;
         label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(12, 143);
         label2.Name = "label2";
         label2.Size = new Size(78, 15);
         label2.TabIndex = 6;
         label2.Text = "ID de pedido";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.BackColor = Color.Transparent;
         label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label3.Location = new Point(12, 198);
         label3.Name = "label3";
         label3.Size = new Size(100, 15);
         label3.TabIndex = 7;
         label3.Text = "Fecha del pedido";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.BackColor = Color.Transparent;
         label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label4.Location = new Point(12, 257);
         label4.Name = "label4";
         label4.Size = new Size(112, 15);
         label4.TabIndex = 8;
         label4.Text = "Seleccionar cliente";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.BackColor = Color.Transparent;
         label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label5.Location = new Point(12, 314);
         label5.Name = "label5";
         label5.Size = new Size(131, 15);
         label5.TabIndex = 9;
         label5.Text = "Seleccionar repartidor";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.BackColor = Color.Transparent;
         label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label6.Location = new Point(12, 410);
         label6.Name = "label6";
         label6.Size = new Size(121, 15);
         label6.TabIndex = 10;
         label6.Text = "Direccion del pedido";
         // 
         // btnRegresar
         // 
         btnRegresar.BackColor = Color.SaddleBrown;
         btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnRegresar.Location = new Point(12, 384);
         btnRegresar.Name = "btnRegresar";
         btnRegresar.Size = new Size(75, 23);
         btnRegresar.TabIndex = 11;
         btnRegresar.Text = "Regresar";
         btnRegresar.UseVisualStyleBackColor = false;
         btnRegresar.Click += btnRegresar_Click;
         // 
         // btnRegistrar
         // 
         btnRegistrar.BackColor = Color.PaleGreen;
         btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnRegistrar.Location = new Point(103, 384);
         btnRegistrar.Name = "btnRegistrar";
         btnRegistrar.Size = new Size(75, 23);
         btnRegistrar.TabIndex = 12;
         btnRegistrar.Text = "Registrar";
         btnRegistrar.UseVisualStyleBackColor = false;
         btnRegistrar.Click += btnRegistrar_Click;
         // 
         // btnSalir
         // 
         btnSalir.BackColor = Color.IndianRed;
         btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnSalir.Location = new Point(310, 384);
         btnSalir.Name = "btnSalir";
         btnSalir.Size = new Size(75, 23);
         btnSalir.TabIndex = 13;
         btnSalir.Text = "Salir";
         btnSalir.UseVisualStyleBackColor = false;
         btnSalir.Click += btnSalir_Click;
         // 
         // btnSiguiente
         // 
         btnSiguiente.BackColor = Color.LimeGreen;
         btnSiguiente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnSiguiente.Location = new Point(422, 384);
         btnSiguiente.Name = "btnSiguiente";
         btnSiguiente.Size = new Size(75, 23);
         btnSiguiente.TabIndex = 14;
         btnSiguiente.Text = "Siguiente";
         btnSiguiente.UseVisualStyleBackColor = false;
         btnSiguiente.Click += btnSiguiente_Click;
         // 
         // btnConsultar
         // 
         btnConsultar.BackColor = Color.Gold;
         btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnConsultar.Location = new Point(203, 384);
         btnConsultar.Name = "btnConsultar";
         btnConsultar.Size = new Size(75, 23);
         btnConsultar.TabIndex = 15;
         btnConsultar.Text = "Consultar";
         btnConsultar.UseVisualStyleBackColor = false;
         btnConsultar.Click += btnConsultar_Click;
         // 
         // dgvConsultas
         // 
         dgvConsultas.BackgroundColor = SystemColors.ButtonFace;
         dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvConsultas.GridColor = SystemColors.InactiveCaption;
         dgvConsultas.Location = new Point(12, 12);
         dgvConsultas.Name = "dgvConsultas";
         dgvConsultas.Size = new Size(776, 77);
         dgvConsultas.TabIndex = 16;
         // 
         // FormPedidos
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         BackgroundImage = Properties.Resources.ImagenTarea;
         ClientSize = new Size(800, 450);
         Controls.Add(dgvConsultas);
         Controls.Add(btnConsultar);
         Controls.Add(btnSiguiente);
         Controls.Add(btnSalir);
         Controls.Add(btnRegistrar);
         Controls.Add(btnRegresar);
         Controls.Add(label6);
         Controls.Add(label5);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(label1);
         Controls.Add(dtpFechaPedido);
         Controls.Add(cmbrepartidores);
         Controls.Add(cmbcliente);
         Controls.Add(txtDireccionPedido);
         Controls.Add(txtIdPedido);
         Name = "FormPedidos";
         Text = "FormPedidos";
         ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private TextBox txtIdPedido;
      private TextBox txtDireccionPedido;
      private ComboBox cmbcliente;
      private ComboBox cmbrepartidores;
      private DateTimePicker dtpFechaPedido;
      private Label label1;
      private Label label2;
      private Label label3;
      private Label label4;
      private Label label5;
      private Label label6;
      private Button btnRegresar;
      private Button btnRegistrar;
      private Button btnSalir;
      private Button btnSiguiente;
      private Button btnConsultar;
      private DataGridView dgvConsultas;
   }
}