
namespace EjerciciosLibroCSharp.Capitulo6
{
    partial class Ejercicio6_1
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
            this.CalificacionesListBox = new System.Windows.Forms.ListBox();
            this.MostrarBoton = new System.Windows.Forms.Button();
            this.calificacionesBoton = new System.Windows.Forms.Button();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.SalonesTextBox = new System.Windows.Forms.TextBox();
            this.salonesLabel = new System.Windows.Forms.Label();
            this.PromedioLabel = new System.Windows.Forms.Label();
            this.PromedioTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalificacionesListBox
            // 
            this.CalificacionesListBox.FormattingEnabled = true;
            this.CalificacionesListBox.ItemHeight = 20;
            this.CalificacionesListBox.Location = new System.Drawing.Point(58, 268);
            this.CalificacionesListBox.Name = "CalificacionesListBox";
            this.CalificacionesListBox.Size = new System.Drawing.Size(275, 144);
            this.CalificacionesListBox.TabIndex = 7;
            this.CalificacionesListBox.SelectedIndexChanged += new System.EventHandler(this.CalificacionesListBox_SelectedIndexChanged);
            // 
            // MostrarBoton
            // 
            this.MostrarBoton.Location = new System.Drawing.Point(352, 268);
            this.MostrarBoton.Name = "MostrarBoton";
            this.MostrarBoton.Size = new System.Drawing.Size(116, 53);
            this.MostrarBoton.TabIndex = 8;
            this.MostrarBoton.Text = "Mostrar calificaciones";
            this.MostrarBoton.UseVisualStyleBackColor = true;
            this.MostrarBoton.Click += new System.EventHandler(this.MostrarBoton_Click);
            // 
            // calificacionesBoton
            // 
            this.calificacionesBoton.Location = new System.Drawing.Point(271, 158);
            this.calificacionesBoton.Name = "calificacionesBoton";
            this.calificacionesBoton.Size = new System.Drawing.Size(126, 73);
            this.calificacionesBoton.TabIndex = 10;
            this.calificacionesBoton.Text = "Agregar calificaciones de alumnos";
            this.calificacionesBoton.UseVisualStyleBackColor = true;
            this.calificacionesBoton.Click += new System.EventHandler(this.calificacionesBoton_Click);
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(58, 158);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(127, 73);
            this.AgregarBoton.TabIndex = 17;
            this.AgregarBoton.Text = "Agregar cantidad de alumnos";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // SalonesTextBox
            // 
            this.SalonesTextBox.Location = new System.Drawing.Point(272, 41);
            this.SalonesTextBox.Name = "SalonesTextBox";
            this.SalonesTextBox.Size = new System.Drawing.Size(125, 27);
            this.SalonesTextBox.TabIndex = 16;
            this.SalonesTextBox.TextChanged += new System.EventHandler(this.SalonesTextBox_TextChanged);
            // 
            // salonesLabel
            // 
            this.salonesLabel.AutoSize = true;
            this.salonesLabel.Location = new System.Drawing.Point(58, 44);
            this.salonesLabel.Name = "salonesLabel";
            this.salonesLabel.Size = new System.Drawing.Size(205, 20);
            this.salonesLabel.TabIndex = 15;
            this.salonesLabel.Text = "Digite la cantidad de salones:";
            // 
            // PromedioLabel
            // 
            this.PromedioLabel.AutoSize = true;
            this.PromedioLabel.Location = new System.Drawing.Point(58, 95);
            this.PromedioLabel.Name = "PromedioLabel";
            this.PromedioLabel.Size = new System.Drawing.Size(109, 20);
            this.PromedioLabel.TabIndex = 23;
            this.PromedioLabel.Text = "El promedio es";
            // 
            // PromedioTextBox
            // 
            this.PromedioTextBox.Location = new System.Drawing.Point(272, 92);
            this.PromedioTextBox.Name = "PromedioTextBox";
            this.PromedioTextBox.Size = new System.Drawing.Size(125, 27);
            this.PromedioTextBox.TabIndex = 24;
            // 
            // Ejercicio6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.PromedioTextBox);
            this.Controls.Add(this.PromedioLabel);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.SalonesTextBox);
            this.Controls.Add(this.salonesLabel);
            this.Controls.Add(this.calificacionesBoton);
            this.Controls.Add(this.MostrarBoton);
            this.Controls.Add(this.CalificacionesListBox);
            this.Name = "Ejercicio6_1";
            this.Text = "Ejercicio6_1";
            this.Load += new System.EventHandler(this.Ejercicio6_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MostrarBoton;
        public System.Windows.Forms.ListBox CalificacionesListBox;
        public System.Windows.Forms.Button calificacionesBoton;
        private System.Windows.Forms.Button AgregarBoton;
        public System.Windows.Forms.TextBox SalonesTextBox;
        private System.Windows.Forms.Label salonesLabel;
        private System.Windows.Forms.Label PromedioLabel;
        private System.Windows.Forms.TextBox PromedioTextBox;
    }
}