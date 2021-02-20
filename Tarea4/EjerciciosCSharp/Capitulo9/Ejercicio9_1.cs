using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static EjerciciosCSharp.Capitulo9.Ejercicio9_1;

namespace EjerciciosCSharp.Capitulo9
{
    public partial class Ejercicio9_1 : Form
    {
        public Ejercicio9_1()
        {
            InitializeComponent();
        }

        public struct Articulos
        {
            public string nombre;
            public double precio;

            public Articulos(string Nombre, double Precio)
            {
                nombre = Nombre;
                precio = Precio;
            }

            public override string ToString()
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat($"El producto {nombre} cuesta {Convert.ToString(precio)}");

                return cadena.ToString();
            }
        }

        Articulos[] articulos = new Articulos[50];
        int contador = 0;

        public void Limpiar()
        {
            ProductosListBox.Items.Clear();
        }

        private void Ejercicio9_1_Load(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            articulos[contador].precio = Convert.ToDouble(PrecioTextBox.Text);
            articulos[contador].nombre = NombreTextBox.Text;
            contador++;
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            for (int i = 0; i < contador; i++)
            {
                ProductosListBox.Items.Add(articulos[i].ToString());
            }
            
        }
    }
}
