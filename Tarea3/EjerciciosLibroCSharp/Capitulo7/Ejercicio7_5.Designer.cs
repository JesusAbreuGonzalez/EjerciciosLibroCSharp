
namespace EjerciciosLibroCSharp.Capitulo7
{
    partial class Ejercicio7_5
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
            this.TelefonoResultTextBox = new System.Windows.Forms.TextBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TelefonoResultTextBox
            // 
            this.TelefonoResultTextBox.Location = new System.Drawing.Point(33, 187);
            this.TelefonoResultTextBox.Name = "TelefonoResultTextBox";
            this.TelefonoResultTextBox.Size = new System.Drawing.Size(309, 27);
            this.TelefonoResultTextBox.TabIndex = 7;
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(348, 187);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(94, 29);
            this.BuscarBoton.TabIndex = 6;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(183, 75);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(125, 27);
            this.TelefonoTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número de teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número de teléfono";
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(314, 73);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(94, 29);
            this.AgregarBoton.TabIndex = 9;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre del contacto";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(183, 36);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(125, 27);
            this.NombreTextBox.TabIndex = 11;
            // 
            // Ejercicio7_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 301);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TelefonoResultTextBox);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio7_5";
            this.Text = "Ejercicio7_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TelefonoResultTextBox;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTextBox;
    }
}