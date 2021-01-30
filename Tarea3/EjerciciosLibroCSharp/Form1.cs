using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibroCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio1Boton_Click(object sender, EventArgs e)
        {
            Capitulo6.Ejercicio6_1 ventana = new Capitulo6.Ejercicio6_1();
            ventana.Show();
        }

        private void Ejercicio2Boton_Click(object sender, EventArgs e)
        {
            Capitulo6.Ejercicio6_2 ventana = new Capitulo6.Ejercicio6_2();
            ventana.Show();
        }

        private void Ejercicio3Boton_Click(object sender, EventArgs e)
        {
            Capitulo6.Ejercicio6_3 ventana = new Capitulo6.Ejercicio6_3();
            ventana.Show();
        }

        private void Ejercicio4Boton_Click(object sender, EventArgs e)
        {
            Capitulo6.Ejercicio6_4 ventana = new Capitulo6.Ejercicio6_4();
            ventana.Show();
        }

        private void Ejercicio5Boton_Click(object sender, EventArgs e)
        {
            Capitulo6.Ejercicio6_5 ventana = new Capitulo6.Ejercicio6_5();
            ventana.Show();
        }

        private void Ejercicio7_1Boton_Click(object sender, EventArgs e)
        {
            Capitulo7.Ejercicio7_1 ventana = new Capitulo7.Ejercicio7_1();
            ventana.Show();
        }

        private void Ejercicio7_2Boton_Click(object sender, EventArgs e)
        {
            Capitulo7.Ejercicio7_2 ventana = new Capitulo7.Ejercicio7_2();
            ventana.Show();
        }

        private void Ejercicio7_5Boton_Click(object sender, EventArgs e)
        {
            Capitulo7.Ejercicio7_5 ventana = new Capitulo7.Ejercicio7_5();
            ventana.Show();
        }
    }
}
