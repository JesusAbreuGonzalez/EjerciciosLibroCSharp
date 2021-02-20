
namespace EjerciciosCSharp.Capitulo8
{
    partial class Ejercicio8_3
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
            this.HoraLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.FechaTextBox = new System.Windows.Forms.TextBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HoraLabel
            // 
            this.HoraLabel.AutoSize = true;
            this.HoraLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoraLabel.Location = new System.Drawing.Point(64, 69);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(66, 28);
            this.HoraLabel.TabIndex = 0;
            this.HoraLabel.Text = "HORA";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaLabel.Location = new System.Drawing.Point(64, 140);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(71, 28);
            this.FechaLabel.TabIndex = 1;
            this.FechaLabel.Text = "FECHA";
            // 
            // HoraTextBox
            // 
            this.HoraTextBox.Location = new System.Drawing.Point(136, 73);
            this.HoraTextBox.Name = "HoraTextBox";
            this.HoraTextBox.Size = new System.Drawing.Size(125, 27);
            this.HoraTextBox.TabIndex = 2;
            // 
            // FechaTextBox
            // 
            this.FechaTextBox.Location = new System.Drawing.Point(136, 144);
            this.FechaTextBox.Name = "FechaTextBox";
            this.FechaTextBox.Size = new System.Drawing.Size(125, 27);
            this.FechaTextBox.TabIndex = 3;
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(82, 205);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(179, 50);
            this.MostrarButton.TabIndex = 4;
            this.MostrarButton.Text = "Mostrar fecha y hora";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // Ejercicio8_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 280);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.FechaTextBox);
            this.Controls.Add(this.HoraTextBox);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.HoraLabel);
            this.Name = "Ejercicio8_3";
            this.Text = "Ejercicio8_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.TextBox HoraTextBox;
        private System.Windows.Forms.TextBox FechaTextBox;
        private System.Windows.Forms.Button MostrarButton;
    }
}