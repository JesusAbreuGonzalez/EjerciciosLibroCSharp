using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosLibroCSharp.Capitulo6
{
    public partial class Ejercicio6_1 : Forms
    {
        int cantidad; //cantidad de alumnos
        int salones = 0; //cantidad de salones
        float[][] calificaciones; //Creamos el arreglo
        

        //variables para el promedio
        float suma = 0.0f;
        float promedio = 0.0f;
        int contador = 0;


        public Ejercicio6_1()
        {
            InitializeComponent();
        }

        private void Ejercicio6_1_Load(object sender, EventArgs e)
        {
            calificaciones = new float[salones][];
        }

        private void CalificacionesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                }
            }

            promedio = suma / contador;

            PromedioTextBox.Text = Convert.ToString(promedio);
            calificacionesBoton.Enabled = false;
        }      
    }
}
