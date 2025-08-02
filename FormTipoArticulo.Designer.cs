namespace Presentacion
{

   partial class FormTipoArticulo
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
         txtIdTipoArticulo = new TextBox();
         txtNombreTipoArticulo = new TextBox();
         txtDescripcionTipoArticulo = new TextBox();
         btnRegistrar = new Button();
         btnConsultar = new Button();
         btnSalir = new Button();
         btnSiguiente = new Button();
         dgvConsultar = new DataGridView();
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         ((System.ComponentModel.ISupportInitialize)dgvConsultar).BeginInit();
         SuspendLayout();
         // 
         // txtIdTipoArticulo
         // 
         txtIdTipoArticulo.BackColor = SystemColors.InactiveCaption;
         txtIdTipoArticulo.Location = new Point(8, 42);
         txtIdTipoArticulo.Name = "txtIdTipoArticulo";
         txtIdTipoArticulo.Size = new Size(184, 23);
         txtIdTipoArticulo.TabIndex = 0;
         // 
         // txtNombreTipoArticulo
         // 
         txtNombreTipoArticulo.BackColor = SystemColors.InactiveCaption;
         txtNombreTipoArticulo.Location = new Point(8, 116);
         txtNombreTipoArticulo.Name = "txtNombreTipoArticulo";
         txtNombreTipoArticulo.Size = new Size(184, 23);
         txtNombreTipoArticulo.TabIndex = 1;
         // 
         // txtDescripcionTipoArticulo
         // 
         txtDescripcionTipoArticulo.BackColor = SystemColors.InactiveCaption;
         txtDescripcionTipoArticulo.Location = new Point(12, 191);
         txtDescripcionTipoArticulo.Name = "txtDescripcionTipoArticulo";
         txtDescripcionTipoArticulo.Size = new Size(180, 23);
         txtDescripcionTipoArticulo.TabIndex = 2;
         // 
         // btnRegistrar
         // 
         btnRegistrar.BackColor = Color.Aqua;
         btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnRegistrar.Location = new Point(60, 396);
         btnRegistrar.Name = "btnRegistrar";
         btnRegistrar.Size = new Size(75, 23);
         btnRegistrar.TabIndex = 3;
         btnRegistrar.Text = "Registrar";
         btnRegistrar.UseVisualStyleBackColor = false;
         btnRegistrar.Click += btnRegistrar_Click;
         // 
         // btnConsultar
         // 
         btnConsultar.BackColor = SystemColors.ActiveCaption;
         btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnConsultar.Location = new Point(209, 396);
         btnConsultar.Name = "btnConsultar";
         btnConsultar.Size = new Size(75, 23);
         btnConsultar.TabIndex = 4;
         btnConsultar.Text = "Consultar";
         btnConsultar.UseVisualStyleBackColor = false;
         btnConsultar.Click += btnConsultar_Click;
         // 
         // btnSalir
         // 
         btnSalir.BackColor = Color.IndianRed;
         btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnSalir.Location = new Point(377, 396);
         btnSalir.Name = "btnSalir";
         btnSalir.Size = new Size(75, 23);
         btnSalir.TabIndex = 5;
         btnSalir.Text = "Salir";
         btnSalir.UseVisualStyleBackColor = false;
         btnSalir.Click += btnSalir_Click;
         // 
         // btnSiguiente
         // 
         btnSiguiente.BackColor = Color.LimeGreen;
         btnSiguiente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnSiguiente.Location = new Point(547, 396);
         btnSiguiente.Name = "btnSiguiente";
         btnSiguiente.Size = new Size(75, 23);
         btnSiguiente.TabIndex = 6;
         btnSiguiente.Text = "Siguiente";
         btnSiguiente.UseVisualStyleBackColor = false;
         btnSiguiente.Click += btnSiguiente_Click;
         // 
         // dgvConsultar
         // 
         dgvConsultar.BackgroundColor = SystemColors.Control;
         dgvConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvConsultar.Location = new Point(218, 12);
         dgvConsultar.Name = "dgvConsultar";
         dgvConsultar.Size = new Size(570, 94);
         dgvConsultar.TabIndex = 7;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.BackColor = Color.Transparent;
         label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label1.Location = new Point(12, 68);
         label1.Name = "label1";
         label1.Size = new Size(185, 15);
         label1.TabIndex = 8;
         label1.Text = "Ingrese el ID del tipo de articulo";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.BackColor = Color.Transparent;
         label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(8, 142);
         label2.Name = "label2";
         label2.Size = new Size(213, 15);
         label2.TabIndex = 9;
         label2.Text = "Ingrese el nombre de tipo de articulo";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.BackColor = Color.Transparent;
         label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label3.Location = new Point(12, 217);
         label3.Name = "label3";
         label3.Size = new Size(231, 15);
         label3.TabIndex = 10;
         label3.Text = "Ingrese la descripcion de tipo de articulo";
         // 
         // FormTipoArticulo
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         BackgroundImage = Properties.Resources.ImagenTarea;
         ClientSize = new Size(800, 450);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(label1);
         Controls.Add(dgvConsultar);
         Controls.Add(btnSiguiente);
         Controls.Add(btnSalir);
         Controls.Add(btnConsultar);
         Controls.Add(btnRegistrar);
         Controls.Add(txtDescripcionTipoArticulo);
         Controls.Add(txtNombreTipoArticulo);
         Controls.Add(txtIdTipoArticulo);
         Name = "FormTipoArticulo";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "FormTipoArticulo";
         ((System.ComponentModel.ISupportInitialize)dgvConsultar).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private TextBox txtIdTipoArticulo;
      private TextBox txtNombreTipoArticulo;
      private TextBox txtDescripcionTipoArticulo;
      private Button btnRegistrar;
      private Button btnConsultar;
      private Button btnSalir;
      private Button btnSiguiente;
      private DataGridView dgvConsultar;
      private Label label1;
      private Label label2;
      private Label label3;
   }
}