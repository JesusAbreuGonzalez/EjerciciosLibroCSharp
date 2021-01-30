
namespace EjerciciosLibroCSharp.Capitulo7
{
    partial class Ejercicio7_1
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
            this.CalificacionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.PromedioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.CalificacionesTextBox = new System.Windows.Forms.TextBox();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadRestanteLabel = new System.Windows.Forms.Label();
            this.calificacionesRLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalificacionLabel
            // 
            this.CalificacionLabel.AutoSize = true;
            this.CalificacionLabel.Location = new System.Drawing.Point(46, 92);
            this.CalificacionLabel.Name = "CalificacionLabel";
            this.CalificacionLabel.Size = new System.Drawing.Size(242, 20);
            this.CalificacionLabel.TabIndex = 0;
            this.CalificacionLabel.Text = "Digite la cantidad de calificaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "El promedio es";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "La calificación más baja es";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "La calificación más alta es";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(294, 89);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(125, 27);
            this.CantidadTextBox.TabIndex = 6;
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(673, 135);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(125, 27);
            this.MaxTextBox.TabIndex = 8;
            // 
            // PromedioTextBox
            // 
            this.PromedioTextBox.Location = new System.Drawing.Point(673, 89);
            this.PromedioTextBox.Name = "PromedioTextBox";
            this.PromedioTextBox.Size = new System.Drawing.Size(125, 27);
            this.PromedioTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digite la calificación";
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(675, 184);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(125, 27);
            this.MinTextBox.TabIndex = 12;
            // 
            // CalificacionesTextBox
            // 
            this.CalificacionesTextBox.Location = new System.Drawing.Point(294, 135);
            this.CalificacionesTextBox.Name = "CalificacionesTextBox";
            this.CalificacionesTextBox.Size = new System.Drawing.Size(125, 27);
            this.CalificacionesTextBox.TabIndex = 13;
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(46, 184);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(137, 48);
            this.AgregarBoton.TabIndex = 14;
            this.AgregarBoton.Text = "Agregar calificación";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(154, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quedan por ingresar";
            // 
            // cantidadRestanteLabel
            // 
            this.cantidadRestanteLabel.AutoSize = true;
            this.cantidadRestanteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cantidadRestanteLabel.Location = new System.Drawing.Point(343, 28);
            this.cantidadRestanteLabel.Name = "cantidadRestanteLabel";
            this.cantidadRestanteLabel.Size = new System.Drawing.Size(23, 28);
            this.cantidadRestanteLabel.TabIndex = 16;
            this.cantidadRestanteLabel.Text = "0";
            // 
            // calificacionesRLabel
            // 
            this.calificacionesRLabel.AutoSize = true;
            this.calificacionesRLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calificacionesRLabel.Location = new System.Drawing.Point(372, 28);
            this.calificacionesRLabel.Name = "calificacionesRLabel";
            this.calificacionesRLabel.Size = new System.Drawing.Size(126, 28);
            this.calificacionesRLabel.TabIndex = 17;
            this.calificacionesRLabel.Text = "calificaciones";
            // 
            // Ejercicio7_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 314);
            this.Controls.Add(this.calificacionesRLabel);
            this.Controls.Add(this.cantidadRestanteLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.CalificacionesTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PromedioTextBox);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalificacionLabel);
            this.Name = "Ejercicio7_1";
            this.Text = "Ejercicio7_1";
            this.Load += new System.EventHandler(this.Ejercicio7_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalificacionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox PromedioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox CalificacionesTextBox;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cantidadRestanteLabel;
        private System.Windows.Forms.Label calificacionesRLabel;
    }
}