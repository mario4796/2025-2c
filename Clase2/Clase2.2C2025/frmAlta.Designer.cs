namespace Clase2._2C2025
{
    partial class frmAlta
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
            label1 = new Label();
            txtNuevoLocal = new TextBox();
            btnIngresarLocal = new Button();
            btnCancelarIngreso = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese nuevo tipo de local";
            // 
            // txtNuevoLocal
            // 
            txtNuevoLocal.Location = new Point(23, 27);
            txtNuevoLocal.Name = "txtNuevoLocal";
            txtNuevoLocal.Size = new Size(270, 23);
            txtNuevoLocal.TabIndex = 1;
            // 
            // btnIngresarLocal
            // 
            btnIngresarLocal.Location = new Point(23, 56);
            btnIngresarLocal.Name = "btnIngresarLocal";
            btnIngresarLocal.Size = new Size(145, 48);
            btnIngresarLocal.TabIndex = 2;
            btnIngresarLocal.Text = "Ingresar";
            btnIngresarLocal.UseVisualStyleBackColor = true;
            // 
            // btnCancelarIngreso
            // 
            btnCancelarIngreso.Location = new Point(174, 56);
            btnCancelarIngreso.Name = "btnCancelarIngreso";
            btnCancelarIngreso.Size = new Size(119, 48);
            btnCancelarIngreso.TabIndex = 3;
            btnCancelarIngreso.Text = "Cancelar";
            btnCancelarIngreso.UseVisualStyleBackColor = true;
            // 
            // frmAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 287);
            Controls.Add(btnCancelarIngreso);
            Controls.Add(btnIngresarLocal);
            Controls.Add(txtNuevoLocal);
            Controls.Add(label1);
            Name = "frmAlta";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNuevoLocal;
        private Button btnIngresarLocal;
        private Button btnCancelarIngreso;
    }
}