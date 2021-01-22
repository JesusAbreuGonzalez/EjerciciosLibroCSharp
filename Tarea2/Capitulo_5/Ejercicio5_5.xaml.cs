using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EjerciciosLibroCSharp.Tarea2.Capitulo_5
{
    /// <summary>
    /// Interaction logic for Ejercicio5_5.xaml
    /// </summary>
    public partial class Ejercicio5_5 : Window
    {
        public Ejercicio5_5()
        {
            InitializeComponent();
        }

        static string mostrarNumero(string op)
        {
            string texto;
            switch (op)
            {
                case "1":
                    texto = "Uno";
                    return texto;
                case "2":
                    texto = "Dos";
                    return texto;
                case "3":
                    texto = "Tres";
                    return texto;
                case "4":
                    texto = "Cuatro";
                    return texto;
                case "5":
                    texto = "Cinco";
                    return texto;
                case "6":
                    texto = "Seis";
                    return texto;
                case "7":
                    texto = "Siete";
                    return texto;
                case "8":
                    texto = "Ocho";
                    return texto;
                case "9":
                    texto = "Nueve";
                    return texto;
                case "10":
                    texto = "Diez";
                    return texto;
                case "11":
                    texto = "Once";
                    return texto;
                case "12":
                    texto = "Doce";
                    return texto;
                case "13":
                    texto = "Trece";
                    return texto;
                case "14":
                    texto = "Catorce";
                    return texto;
                case "15":
                    texto = "Quince";
                    return texto;
                case "16":
                    texto = "Dieciseis";
                    return texto;
                case "17":
                    texto = "Diecisiete";
                    return texto;
                case "18":
                    texto = "Dieciocho";
                    return texto;
                case "19":
                    texto = "Diecinueve";
                    return texto;
                case "20":
                    texto = "Veinte";
                    return texto;
                default:
                    MessageBox.Show("El numero introducido no se encuentra en el rango que comprenden estos numeros.\n" +
                        "Intente con un numero entre 1 y 20", "Ha ocurrido un error");
                    return "";
            }
        }
        private void MostrarBoton_Click(object sender, RoutedEventArgs e)
        {
            resultadoTextBox.Text = mostrarNumero(numeroTextBox.Text);
            
        }
    }
}
