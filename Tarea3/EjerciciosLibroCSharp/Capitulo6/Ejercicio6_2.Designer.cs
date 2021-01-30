
namespace EjerciciosLibroCSharp.Capitulo6
{
    partial class Ejercicio6_2
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
            this.PromedioTextBox = new System.Windows.Forms.TextBox();
            this.PromedioLabel = new System.Windows.Forms.Label();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.SalonesTextBox = new System.Windows.Forms.TextBox();
            this.salonesLabel = new System.Windows.Forms.Label();
            this.calificacionesBoton = new System.Windows.Forms.Button();
            this.MostrarBoton = new System.Windows.Forms.Button();
            this.CalificacionesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PromedioTextBox
            // 
            this.PromedioTextBox.Location = new System.Drawing.Point(259, 87);
            this.PromedioTextBox.Name = "PromedioTextBox";
            this.PromedioTextBox.Size = new System.Drawing.Size(125, 27);
            this.PromedioTextBox.TabIndex = 32;
            // 
            // PromedioLabel
            // 
            this.PromedioLabel.AutoSize = true;
            this.PromedioLabel.Location = new System.Drawing.Point(48, 90);
            this.PromedioLabel.Name = "PromedioLabel";
            this.PromedioLabel.Size = new System.Drawing.Size(112, 20);
            this.PromedioLabel.TabIndex = 31;
            this.PromedioLabel.Text = "El promedio es:";
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(48, 175);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(127, 73);
            this.AgregarBoton.TabIndex = 30;
            this.AgregarBoton.Text = "Agregar cantidad de alumnos";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // SalonesTextBox
            // 
            this.SalonesTextBox.Location = new System.Drawing.Point(259, 40);
            this.SalonesTextBox.Name = "SalonesTextBox";
            this.SalonesTextBox.Size = new System.Drawing.Size(125, 27);
            this.SalonesTextBox.TabIndex = 29;
            // 
            // salonesLabel
            // 
            this.salonesLabel.AutoSize = true;
            this.salonesLabel.Location = new System.Drawing.Point(48, 43);
            this.salonesLabel.Name = "salonesLabel";
            this.salonesLabel.Size = new System.Drawing.Size(205, 20);
            this.salonesLabel.TabIndex = 28;
            this.salonesLabel.Text = "Digite la cantidad de salones:";
            // 
            // calificacionesBoton
            // 
            this.calificacionesBoton.Location = new System.Drawing.Point(259, 175);
            this.calificacionesBoton.Name = "calificacionesBoton";
            this.calificacionesBoton.Size = new System.Drawing.Size(126, 73);
            this.calificacionesBoton.TabIndex = 27;
            this.calificacionesBoton.Text = "Agregar calificaciones de alumnos";
            this.calificacionesBoton.UseVisualStyleBackColor = true;
            this.calificacionesBoton.Click += new System.EventHandler(this.calificacionesBoton_Click_1);
            // 
            // MostrarBoton
            // 
            this.MostrarBoton.Location = new System.Drawing.Point(329, 267);
            this.MostrarBoton.Name = "MostrarBoton";
            this.MostrarBoton.Size = new System.Drawing.Size(116, 53);
            this.MostrarBoton.TabIndex = 26;
            this.MostrarBoton.Text = "Mostrar calificaciones";
            this.MostrarBoton.UseVisualStyleBackColor = true;
            this.MostrarBoton.Click += new System.EventHandler(this.MostrarBoton_Click_1);
            // 
            // CalificacionesListBox
            // 
            this.CalificacionesListBox.FormattingEnabled = true;
            this.CalificacionesListBox.ItemHeight = 20;
            this.CalificacionesListBox.Location = new System.Drawing.Point(48, 267);
            this.CalificacionesListBox.Name = "CalificacionesListBox";
            this.CalificacionesListBox.Size = new System.Drawing.Size(275, 144);
            this.CalificacionesListBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "La calificacion menor es:";
            // 
            // MenorTextBox
            // 
            this.MenorTextBox.Location = new System.Drawing.Point(259, 133);
            this.MenorTextBox.Name = "MenorTextBox";
            this.MenorTextBox.Size = new System.Drawing.Size(125, 27);
            this.MenorTextBox.TabIndex = 34;
            // 
            // Ejercicio6_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 442);
            this.Controls.Add(this.MenorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PromedioTextBox);
            this.Controls.Add(this.PromedioLabel);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.SalonesTextBox);
            this.Controls.Add(this.salonesLabel);
            this.Controls.Add(this.calificacionesBoton);
            this.Controls.Add(this.MostrarBoton);
            this.Controls.Add(this.CalificacionesListBox);
            this.Name = "Ejercicio6_2";
            this.Text = "Ejercicio6_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PromedioTextBox;
        private System.Windows.Forms.Label PromedioLabel;
        private System.Windows.Forms.Button AgregarBoton;
        public System.Windows.Forms.TextBox SalonesTextBox;
        private System.Windows.Forms.Label salonesLabel;
        public System.Windows.Forms.Button calificacionesBoton;
        private System.Windows.Forms.Button MostrarBoton;
        public System.Windows.Forms.ListBox CalificacionesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MenorTextBox;
    }
}