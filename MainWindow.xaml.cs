using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjerciciosLibroCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejercicio4_1Boton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo_4.Ejercicio4_1 pantalla = new Capitulo_4.Ejercicio4_1();
            pantalla.Show();
        }

        private void Ejercicio4_2Boton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo_4.Ejercicio4_2 pantalla = new Capitulo_4.Ejercicio4_2();
            pantalla.Show();
        }

        private void Ejercicio4_5Boton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo_4.Ejercicio4_5 pantalla = new Capitulo_4.Ejercicio4_5();
            pantalla.Show();
        }

        private void Ejercicio5_4Boton_Click(object sender, RoutedEventArgs e)
        {
            Tarea2.Capitulo_5.Ejercicio5_4 pantalla = new Tarea2.Capitulo_5.Ejercicio5_4();
            pantalla.Show();

        }

        private void Ejercicio5_5Boton_Click(object sender, RoutedEventArgs e)
        {
            Tarea2.Capitulo_5.Ejercicio5_5 pantalla = new Tarea2.Capitulo_5.Ejercicio5_5();
            pantalla.Show();
        }
    }
}
