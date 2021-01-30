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
    public partial class Ejercicio7_1 : Form
    {
        ArrayList Calificaciones = new ArrayList();
        int cantidad = 0;
        int contador = 0;
        

        public Ejercicio7_1()
        {
            InitializeComponent();
        }

        float Promedio(ArrayList arrayList)
        {
            float suma = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                suma += Convert.ToInt32(arrayList[i]);
            }

            return suma / arrayList.Count;
        }

        float Mayor(ArrayList arrayList)
        {
            int mayor = -1;
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (Convert.ToInt32(arrayList[i]) > mayor)
                    mayor = Convert.ToInt32(arrayList[i]);
            }
            return mayor;
        }

        float Menor(ArrayList arrayList)
        {
            int menor = 10;
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (Convert.ToInt32(arrayList[i]) < menor)
                    menor = Convert.ToInt32(arrayList[i]);
            }
            return menor;
        }

        private void Ejercicio7_1_Load(object sender, EventArgs e)
        {
        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(CantidadTextBox.Text);
            cantidadRestanteLabel.Text = Convert.ToString((cantidad-contador)-1);
            Calificaciones.Add(Convert.ToInt32(CalificacionesTextBox.Text));
            contador++;
            CalificacionesTextBox.Text = "";

            if (cantidad - contador == 0)
            {
                AgregarBoton.Enabled = false;
                PromedioTextBox.Text = Convert.ToString(Promedio(Calificaciones));

                MaxTextBox.Text = Convert.ToString(Mayor(Calificaciones));

                MinTextBox.Text = Convert.ToString(Menor(Calificaciones));
            }
                

        }
    }
}
