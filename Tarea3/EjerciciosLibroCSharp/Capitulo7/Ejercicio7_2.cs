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
    public partial class Ejercicio7_2 : Form
    {
        Hashtable diccionarioPalabra = new Hashtable();
        public Ejercicio7_2()
        {
            InitializeComponent();
            DiccionarioTextBox.Text = "Las palabras disponibles son:\n1)Arreglo\n2)Hardware\n3)Software\n4)Algoritmo\n5)Sistema";
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            diccionarioPalabra.Add("arreglo", "En programación, un arreglo es una colección de elementos que tienen como referencia un mismo nombre.");
            diccionarioPalabra.Add("hardware", "Conjunto de elementos físicos o materiales que constituyen una computadora o un sistema informático.");
            diccionarioPalabra.Add("software", "Conjunto de programas y rutinas que permiten a la computadora realizar determinadas tareas.");
            diccionarioPalabra.Add("algoritmo", "Conjunto ordenado de operaciones sistemáticas que permite hacer un cálculo y hallar la solución de un tipo de problemas.");
            diccionarioPalabra.Add("sistema", "Conjunto ordenado de normas y procedimientos que regulan el funcionamiento de un grupo o colectividad.");

            SignificadoTextBox.Text = (string)diccionarioPalabra[PalabraTextBox.Text.ToLower()];
        }
    }
}
