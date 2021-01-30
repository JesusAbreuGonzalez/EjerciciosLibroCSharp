using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibroCSharp.Capitulo7
{
    public partial class Ejercicio7_5 : Form
    {
        Hashtable Agenda = new Hashtable();
        public Ejercicio7_5()
        {
            InitializeComponent();
        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            Agenda.Add(Convert.ToString(NombreTextBox.Text), Convert.ToString(TelefonoTextBox.Text));
            TelefonoTextBox.Text = "";
            NombreTextBox.Text = "";
        }
        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            TelefonoResultTextBox.Text = (string)Agenda[Convert.ToString(NombreTextBox.Text)];
        }

    }
}
