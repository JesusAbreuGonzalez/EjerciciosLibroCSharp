using EjerciciosCSharp.Capitulo8;
using EjerciciosCSharp.Capitulo9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCSharp
{
    public partial class Menu_Cap8_Cap9 : Form
    {
        public Menu_Cap8_Cap9()
        {
            InitializeComponent();
        }

        private void Ejercicio8_3Button_Click(object sender, EventArgs e)
        {
            var ventana = new Ejercicio8_3();
            ventana.Show();
        }

        private void Ejercicio8_5Button_Click(object sender, EventArgs e)
        {
            var ventana = new Ejercicio8_5();
            ventana.Show();
        }

        private void Ejercicio9_1Button_Click(object sender, EventArgs e)
        {
            var ventana = new Ejercicio9_1();
            ventana.Show();
        }

        private void Ejercicio9_4Button_Click(object sender, EventArgs e)
        {
            var ventana = new Ejercicio9_4();
            ventana.Show();
        }
    }
}
