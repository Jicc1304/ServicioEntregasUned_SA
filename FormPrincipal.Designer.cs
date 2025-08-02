namespace Presentacion
{
   partial class FormPrincipal
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
         btnIniciar = new Button();
         btnSalir = new Button();
         SuspendLayout();
         // 
         // btnIniciar
         // 
         btnIniciar.BackColor = SystemColors.ActiveCaption;
         btnIniciar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnIniciar.Location = new Point(21, 390);
         btnIniciar.Name = "btnIniciar";
         btnIniciar.Size = new Size(199, 48);
         btnIniciar.TabIndex = 0;
         btnIniciar.Text = "Iniciar Sistema";
         btnIniciar.UseVisualStyleBackColor = false;
         this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
         // 
         // btnSalir
         // 
         btnSalir.BackColor = Color.IndianRed;
         btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnSalir.Location = new Point(602, 391);
         btnSalir.Name = "btnSalir";
         btnSalir.Size = new Size(186, 47);
         btnSalir.TabIndex = 1;
         btnSalir.Text = "Salir de Sistema";
         btnSalir.UseVisualStyleBackColor = false;
         this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
         // 
         // FormPrincipal
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         BackgroundImage = Properties.Resources.ImagenTarea;
         ClientSize = new Size(800, 450);
         Controls.Add(btnSalir);
         Controls.Add(btnIniciar);
         Name = "FormPrincipal";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "FormPrincipal";
         ResumeLayout(false);
      }

      #endregion

      private Button btnIniciar;
      private Button btnSalir;
   }
}