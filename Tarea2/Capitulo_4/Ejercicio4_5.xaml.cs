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

namespace EjerciciosLibroCSharp.Capitulo_4
{
    /// <summary>
    /// Interaction logic for Ejercicio4_5.xaml
    /// </summary>
    public partial class Ejercicio4_5 : Window
    {
        float promedio = 0;
        int contador = 1;
        int mayor = -2147483648;
        int menor = 2147483647;

        public Ejercicio4_5()
        {
            InitializeComponent();
        }

        

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            promedioTextBox.Text = Convert.ToString(promedio / Convert.ToSingle(cantidadTextBox.Text));
            mayorTextBox.Text = Convert.ToString(mayor);
            menorTextBox.Text = Convert.ToString(menor);
        }

        private void guardarBoton_Click(object sender, RoutedEventArgs e)
        {
            int cantidad = Convert.ToInt32(cantidadTextBox.Text);

            edadesRestantesLabel.Content = cantidad - contador;
            promedio += Convert.ToSingle(edadTextBox.Text);

            if (Convert.ToInt32(edadTextBox.Text) < menor)
                menor = Convert.ToInt32(edadTextBox.Text);

            if (Convert.ToInt32(edadTextBox.Text) > mayor)
                mayor = Convert.ToInt32(edadTextBox.Text);

             if((cantidad - contador) == 0)
                 guardarBoton.IsEnabled = false;

            contador += 1;
            edadTextBox.Text = "";
        }

        private void ReiniciarBoton_Click(object sender, RoutedEventArgs e)
        {
            cantidadTextBox.Text = "";
            edadTextBox.Text = "";
            promedioTextBox.Text = "";
            mayorTextBox.Text = "";
            menorTextBox.Text = "";
            guardarBoton.IsEnabled = true;
            contador = 1;
        }
    }
}
