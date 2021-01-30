using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibroCSharp.Capitulo6
{
    public partial class Ejercicio6_4 : Form
    {
        int salones;
        int cantidad;
        int cant = 0;
        float[][] calificaciones;

        public Ejercicio6_4()
        {
            InitializeComponent();
        }
        void CalificacionesAlumnos()
        {
            float suma = 0;
            float promedio = 0;
            int menor = 200;
            int mayor = -999;

            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    calificaciones[i][j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la calificacionesicación del alumno " + (j + 1) + " del salón " + (i + 1), "calificacionesicaciones", " ", 100, 0));
                    suma += calificaciones[i][j];

                    if (calificaciones[i][j] < menor)
                        menor = Convert.ToInt32(calificaciones[i][j]);

                    if (calificaciones[i][j] > mayor)
                        mayor = Convert.ToInt32(calificaciones[i][j]);
                }
            }

            //Mostrar resultados
            MenorTextBox.Text = menor.ToString();
            MayorTextBox.Text = mayor.ToString();
            promedio = suma / cant;
            PromedioTextBox.Text = promedio.ToString();

        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            salones = Convert.ToInt32(SalonesTextBox.Text);
            calificaciones = new float[salones][];

            for (int i = 0; i < salones; i++)
            {
                cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de alumnos del salón " + (i + 1), "Cantidad de Alumnos", " ", 100, 0));
                calificaciones[i] = new float[cantidad];
                cant += cantidad;
            }
            SalonesTextBox.Text = "";
            AgregarBoton.Enabled = false;
        }

        private void calificacionesBoton_Click(object sender, EventArgs e)
        {
            CalificacionesAlumnos();
            calificacionesBoton.Enabled = false;
        }

        private void MostrarBoton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < salones; i++)
            {
                CalificacionesListBox.Items.Add("Salón " + (i + 1));

                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    CalificacionesListBox.Items.Add("El alumno " + (j + 1) + " tiene " + calificaciones[i][j]);
                }
            }
        }

        private void Ejercicio6_4_Load(object sender, EventArgs e)
        {

        }

        private void SalonesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PromedioLabel_Click(object sender, EventArgs e)
        {

        }

        private void PromedioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salonesLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
