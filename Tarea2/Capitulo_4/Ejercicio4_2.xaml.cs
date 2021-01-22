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
    /// Interaction logic for Ejercicio4_2.xaml
    /// </summary>
    public partial class Ejercicio4_2 : Window
    {
        public Ejercicio4_2()
        {
            InitializeComponent();
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            double valor1, valor2, valor3;
            valor1 = Convert.ToInt32(CoeficienteTextBox.Text);
            valor2 = Convert.ToInt32(ExponenteTextBox.Text);
            valor3 = Math.Pow(valor1, valor2);
            resultTextBox.Text = Convert.ToString(valor3);
        }
    }
}
