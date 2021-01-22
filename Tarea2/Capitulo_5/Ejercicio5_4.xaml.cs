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
    /// Interaction logic for Ejercicio5_4.xaml
    /// </summary>
    public partial class Ejercicio5_4 : Window
    {
        public Ejercicio5_4()
        {
            InitializeComponent();
        }

        static long factorial(long valor)
        {
            if (valor < 0)
                valor *= -1;

            else if (valor == 0)
                return 1;

            long i = valor-1;
            do
            {
                valor *= i;
                i--;
            } while (i != 0);

            return valor;
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            long num, resultado;

            num = Convert.ToInt64(numTextBox.Text);
            resultado = factorial(num);

            factorialLabel.Content = resultado;
        }
    }
}
