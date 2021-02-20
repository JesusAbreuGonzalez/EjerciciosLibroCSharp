using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosCSharp.Capitulo8
{
    public partial class Ejercicio8_3 : Form
    {
        public Ejercicio8_3()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            HoraTextBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
            FechaTextBox.Text = DateTime.Now.ToString("yyyy/dd/MM");
            
        }
    }
}
