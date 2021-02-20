
namespace EjerciciosCSharp.Capitulo9
{
    partial class Ejercicio9_4
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
            this.MostrarButton = new System.Windows.Forms.Button();
            this.OpcionLabel = new System.Windows.Forms.Label();
            this.OpcionTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(155, 111);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(94, 29);
            this.MostrarButton.TabIndex = 0;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // OpcionLabel
            // 
            this.OpcionLabel.AutoSize = true;
            this.OpcionLabel.Location = new System.Drawing.Point(50, 44);
            this.OpcionLabel.Name = "OpcionLabel";
            this.OpcionLabel.Size = new System.Drawing.Size(199, 20);
            this.OpcionLabel.TabIndex = 1;
            this.OpcionLabel.Text = "Escoja un numero del 1 al 10";
            // 
            // OpcionTextBox
            // 
            this.OpcionTextBox.Location = new System.Drawing.Point(255, 41);
            this.OpcionTextBox.Name = "OpcionTextBox";
            this.OpcionTextBox.Size = new System.Drawing.Size(125, 27);
            this.OpcionTextBox.TabIndex = 2;
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(255, 111);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(125, 27);
            this.ResultadoTextBox.TabIndex = 3;
            // 
            // Ejercicio9_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 177);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.OpcionTextBox);
            this.Controls.Add(this.OpcionLabel);
            this.Controls.Add(this.MostrarButton);
            this.Name = "Ejercicio9_4";
            this.Text = "Ejercicio9_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.Label OpcionLabel;
        private System.Windows.Forms.TextBox OpcionTextBox;
        private System.Windows.Forms.TextBox ResultadoTextBox;
    }
}