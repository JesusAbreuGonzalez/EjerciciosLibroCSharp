using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosCSharp.Capitulo8
{
    public partial class Ejercicio8_5 : Form
    {
        public Ejercicio8_5()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            MostrarCadenasListBox.Items.Clear();
        }
        private void OrganizarButton_Click(object sender, EventArgs e)
        {
            string cadena, cadena2;
            cadena = PrimeraCadenaTextBox.Text;
            cadena2 = SegundaCadenaTextBox.Text;

            int comparador = String.Compare(cadena, cadena2);

            if (comparador > 0)
            {
                Limpiar();
                MostrarCadenasListBox.Items.Add("Cadenas antes de ordenar:");
                MostrarCadenasListBox.Items.Add("1) " + cadena + " 2) " + cadena2);
                MostrarCadenasListBox.Items.Add("Cadenas despues de ordenar:");
                MostrarCadenasListBox.Items.Add("1) " + cadena2 + " 2) " + cadena);
            }
            else
            {
                Limpiar();
                MostrarCadenasListBox.Items.Add("Cadenas antes de ordenar:");
                MostrarCadenasListBox.Items.Add("1) " + cadena + " 2) " + cadena2);
                MostrarCadenasListBox.Items.Add("Cadenas despues de ordenar:");
                MostrarCadenasListBox.Items.Add("1) " + cadena + " 2) " + cadena2);
            }
        }
    }
}
