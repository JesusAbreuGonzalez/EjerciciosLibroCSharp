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
    public partial class Ejercicio6_3 : Form
    {
        int cantidad; //cantidad de alumnos
        int salones = 0; //cantidad de salones
        float[][] calificaciones; //Creamos el arreglo


        //variables para el promedio
        float suma = 0.0f;
        float promedio = 0.0f;
        int contador = 0;

        //variable para la menor calificacion
        float menor = 2147483648;
        float mayor = -2147483648;

        public Ejercicio6_3()
        {
            InitializeComponent();
        }

        private void CalificacionesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SalonesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            salones = Convert.ToInt32(SalonesTextBox.Text);
            calificaciones = new float[salones][];

            for (int i = 0; i < salones; i++)
            {
                cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de alumnos del salón " + (i + 1), "Cantidad de Alumnos", " ", 100, 0));
                calificaciones[i] = new float[cantidad];
                contador += cantidad;
                cantidad += cantidad;

            }
            SalonesTextBox.Text = "";
            AgregarBoton.Enabled = false;

        }

        private void calificacionesBoton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    calificaciones[i][j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la calificación del alumno " + (j + 1) + " del salón " + (i + 1), "Calificaciones Alumnos", " ", 100, 0));
                    suma += calificaciones[i][j];
                    if (calificaciones[i][j] < menor)
                        menor = calificaciones[i][j];
                    if (calificaciones[i][j] > mayor)
                        mayor = calificaciones[i][j];

                }
            }

            promedio = suma / contador;

            PromedioTextBox.Text = Convert.ToString(promedio);
            MenorTextBox.Text = Convert.ToString(menor);
            MayorTextBox.Text = Convert.ToString(mayor);
            calificacionesBoton.Enabled = false;
        }

        private void MostrarBoton_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < salones; n++)
            {
                CalificacionesListBox.Items.Add("Salón " + (n + 1));

                for (int m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    CalificacionesListBox.Items.Add("El alumno " + (m + 1) + " tiene " + calificaciones[n][m]);
                }
            }
        }
    }
}
