
namespace EjerciciosLibroCSharp.Capitulo7
{
    partial class Ejercicio7_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.PalabraTextBox = new System.Windows.Forms.TextBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.SignificadoTextBox = new System.Windows.Forms.TextBox();
            this.DiccionarioTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese una palabra para saber su significado";
            // 
            // PalabraTextBox
            // 
            this.PalabraTextBox.Location = new System.Drawing.Point(344, 56);
            this.PalabraTextBox.Name = "PalabraTextBox";
            this.PalabraTextBox.Size = new System.Drawing.Size(125, 27);
            this.PalabraTextBox.TabIndex = 1;
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(491, 55);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(94, 29);
            this.BuscarBoton.TabIndex = 2;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // SignificadoTextBox
            // 
            this.SignificadoTextBox.Location = new System.Drawing.Point(29, 106);
            this.SignificadoTextBox.Multiline = true;
            this.SignificadoTextBox.Name = "SignificadoTextBox";
            this.SignificadoTextBox.Size = new System.Drawing.Size(440, 189);
            this.SignificadoTextBox.TabIndex = 3;
            // 
            // DiccionarioTextBox
            // 
            this.DiccionarioTextBox.Location = new System.Drawing.Point(494, 109);
            this.DiccionarioTextBox.Multiline = true;
            this.DiccionarioTextBox.Name = "DiccionarioTextBox";
            this.DiccionarioTextBox.Size = new System.Drawing.Size(99, 185);
            this.DiccionarioTextBox.TabIndex = 4;
            // 
            // Ejercicio7_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 353);
            this.Controls.Add(this.DiccionarioTextBox);
            this.Controls.Add(this.SignificadoTextBox);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.PalabraTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio7_2";
            this.Text = "Ejercicio7_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PalabraTextBox;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.TextBox SignificadoTextBox;
        private System.Windows.Forms.TextBox DiccionarioTextBox;
    }
}