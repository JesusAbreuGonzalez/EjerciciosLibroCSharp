
namespace EjerciciosCSharp.Capitulo8
{
    partial class Ejercicio8_5
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
            this.label2 = new System.Windows.Forms.Label();
            this.PrimeraCadenaTextBox = new System.Windows.Forms.TextBox();
            this.SegundaCadenaTextBox = new System.Windows.Forms.TextBox();
            this.CadenasLabel = new System.Windows.Forms.Label();
            this.OrganizarButton = new System.Windows.Forms.Button();
            this.MostrarCadenasListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primera Cadena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segunda Cadena";
            // 
            // PrimeraCadenaTextBox
            // 
            this.PrimeraCadenaTextBox.Location = new System.Drawing.Point(163, 56);
            this.PrimeraCadenaTextBox.Name = "PrimeraCadenaTextBox";
            this.PrimeraCadenaTextBox.Size = new System.Drawing.Size(212, 27);
            this.PrimeraCadenaTextBox.TabIndex = 2;
            // 
            // SegundaCadenaTextBox
            // 
            this.SegundaCadenaTextBox.Location = new System.Drawing.Point(163, 130);
            this.SegundaCadenaTextBox.Name = "SegundaCadenaTextBox";
            this.SegundaCadenaTextBox.Size = new System.Drawing.Size(212, 27);
            this.SegundaCadenaTextBox.TabIndex = 3;
            // 
            // CadenasLabel
            // 
            this.CadenasLabel.AutoSize = true;
            this.CadenasLabel.Location = new System.Drawing.Point(30, 195);
            this.CadenasLabel.Name = "CadenasLabel";
            this.CadenasLabel.Size = new System.Drawing.Size(65, 20);
            this.CadenasLabel.TabIndex = 5;
            this.CadenasLabel.Text = "Cadenas";
            // 
            // OrganizarButton
            // 
            this.OrganizarButton.Location = new System.Drawing.Point(281, 183);
            this.OrganizarButton.Name = "OrganizarButton";
            this.OrganizarButton.Size = new System.Drawing.Size(94, 29);
            this.OrganizarButton.TabIndex = 6;
            this.OrganizarButton.Text = "Organizar";
            this.OrganizarButton.UseVisualStyleBackColor = true;
            this.OrganizarButton.Click += new System.EventHandler(this.OrganizarButton_Click);
            // 
            // MostrarCadenasListBox
            // 
            this.MostrarCadenasListBox.FormattingEnabled = true;
            this.MostrarCadenasListBox.ItemHeight = 20;
            this.MostrarCadenasListBox.Location = new System.Drawing.Point(30, 235);
            this.MostrarCadenasListBox.Name = "MostrarCadenasListBox";
            this.MostrarCadenasListBox.Size = new System.Drawing.Size(345, 204);
            this.MostrarCadenasListBox.TabIndex = 7;
            // 
            // Ejercicio8_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 463);
            this.Controls.Add(this.MostrarCadenasListBox);
            this.Controls.Add(this.OrganizarButton);
            this.Controls.Add(this.CadenasLabel);
            this.Controls.Add(this.SegundaCadenaTextBox);
            this.Controls.Add(this.PrimeraCadenaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio8_5";
            this.Text = "Ejercicio8_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrimeraCadenaTextBox;
        private System.Windows.Forms.TextBox SegundaCadenaTextBox;
        private System.Windows.Forms.Label CadenasLabel;
        private System.Windows.Forms.Button OrganizarButton;
        private System.Windows.Forms.ListBox MostrarCadenasListBox;
    }
}