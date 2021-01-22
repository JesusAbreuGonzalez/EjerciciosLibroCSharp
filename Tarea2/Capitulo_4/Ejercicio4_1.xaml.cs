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
    /// Interaction logic for Ejercicio4_1.xaml
    /// </summary>
    public partial class Ejercicio4_1 : Window
    {
        public Ejercicio4_1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int valor;
            valor = Convert.ToInt32(valorTextBox.Text);

            _1Label.Content = valorTextBox.Text;
            _2Label.Content = valorTextBox.Text;
            _3Label.Content = valorTextBox.Text;
            _4Label.Content = valorTextBox.Text;
            _5Label.Content = valorTextBox.Text;
            _6Label.Content = valorTextBox.Text;
            _7Label.Content = valorTextBox.Text;
            _8Label.Content = valorTextBox.Text;
            _9Label.Content = valorTextBox.Text;
            _10Label.Content = valorTextBox.Text;

            result1.Content = 1 * valor;
            result2.Content = 2 * valor;
            result3.Content = 3 * valor;
            result4.Content = 4 * valor;
            result5.Content = 5 * valor;
            result6.Content = 6 * valor;
            result7.Content = 7 * valor;
            result8.Content = 8 * valor;
            result9.Content = 9 * valor;
            result10.Content = 10 * valor;
        }
    }
}
