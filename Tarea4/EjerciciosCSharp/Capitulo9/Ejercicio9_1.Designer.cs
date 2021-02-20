
namespace EjerciciosCSharp.Capitulo9
{
    partial class Ejercicio9_1
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
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NombreProductoLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.PrecioProductoLabel = new System.Windows.Forms.Label();
            this.ProductosListBox = new System.Windows.Forms.ListBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(43, 169);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(94, 29);
            this.GuardarButton.TabIndex = 0;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NombreProductoLabel
            // 
            this.NombreProductoLabel.AutoSize = true;
            this.NombreProductoLabel.Location = new System.Drawing.Point(43, 53);
            this.NombreProductoLabel.Name = "NombreProductoLabel";
            this.NombreProductoLabel.Size = new System.Drawing.Size(154, 20);
            this.NombreProductoLabel.TabIndex = 1;
            this.NombreProductoLabel.Text = "Nombre del producto";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(216, 50);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(125, 27);
            this.NombreTextBox.TabIndex = 2;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(216, 113);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(125, 27);
            this.PrecioTextBox.TabIndex = 4;
            // 
            // PrecioProductoLabel
            // 
            this.PrecioProductoLabel.AutoSize = true;
            this.PrecioProductoLabel.Location = new System.Drawing.Point(43, 116);
            this.PrecioProductoLabel.Name = "PrecioProductoLabel";
            this.PrecioProductoLabel.Size = new System.Drawing.Size(140, 20);
            this.PrecioProductoLabel.TabIndex = 3;
            this.PrecioProductoLabel.Text = "Precio del producto";
            // 
            // ProductosListBox
            // 
            this.ProductosListBox.FormattingEnabled = true;
            this.ProductosListBox.ItemHeight = 20;
            this.ProductosListBox.Location = new System.Drawing.Point(413, 30);
            this.ProductosListBox.Name = "ProductosListBox";
            this.ProductosListBox.Size = new System.Drawing.Size(339, 204);
            this.ProductosListBox.TabIndex = 5;
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(247, 169);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(94, 29);
            this.MostrarButton.TabIndex = 6;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // Ejercicio9_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 265);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.ProductosListBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.PrecioProductoLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NombreProductoLabel);
            this.Controls.Add(this.GuardarButton);
            this.Name = "Ejercicio9_1";
            this.Text = "Ejercicio9_1";
            this.Load += new System.EventHandler(this.Ejercicio9_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label NombreProductoLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label PrecioProductoLabel;
        private System.Windows.Forms.ListBox ProductosListBox;
        private System.Windows.Forms.Button MostrarButton;
    }
}