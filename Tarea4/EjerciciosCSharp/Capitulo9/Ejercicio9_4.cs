using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosCSharp.Capitulo9
{
    public partial class Ejercicio9_4 : Form
    {
        public Ejercicio9_4()
        {
            InitializeComponent();
        }

        enum neumaticos { invierno, Todoterreno, ParaCoche, ParaFurgoneta, PerfilBajo, PerfilAncho, Recauchutados, Verdes, Radiales, Diagonales }
        public void Elegir()
        {
            neumaticos llantas = neumaticos.invierno;
            int opcion = Convert.ToInt32(OpcionTextBox.Text);

            switch (opcion)
            {
                case 1:
                    ResultadoTextBox.Text = Convert.ToString(neumaticos.invierno);
                    break;

                case 2:
                    ResultadoTextBox.Text = Convert.ToString(neumaticos.Todoterreno);
                    break;

                case 3:
                    ResultadoTextBox.Text = Convert.ToString(neumaticos.ParaCoche);
                    break;

                case 4:
                    ResultadoTextBox.Text = Convert.ToString(neumaticos.ParaFurgoneta);
                    break;

                case 5:
                    ResultadoTextBox.Text = Convert.ToString(neumaticos.PerfilBajo);
                    break;

                case 6:
                    ResultadoTextBox.Text = Convert.ToString(neumaticos.PerfilAncho);
                    break;

                case 7:
                    ResultadoTextBox.Text = Convert.ToString(neumaticos.Recauchutados);
                    break;

                case 8:
                    ResultadoTextBox.Text = Convert.ToString(neumaticos.Verdes);
                    break;

                case 9:
                    ResultadoTextBox.Text = Convert.ToString(neumaticos.Radiales);
                    break;

                case 10:
                    ResultadoTextBox.Text = Convert.ToString(neumaticos.Diagonales);
                    break;

                default:
                    MessageBox.Show("Pruebe con un numero entre 1 y 10.");
                    break;
            }
        }
        private void MostrarButton_Click(object sender, EventArgs e)
        {
            Elegir();
        }
    }
}
