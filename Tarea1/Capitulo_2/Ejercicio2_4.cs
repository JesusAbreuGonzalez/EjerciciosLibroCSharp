using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Ejercicio2_4
    {
        public Ejercicio2_4()
        {
            float celsius;
            float fahrenheit;

            Console.Write("Digite la cantidad de grados Celsius que desea convertir: ");
            celsius = Convert.ToSingle(Console.ReadLine());

            fahrenheit = ((celsius * 9)/5) + 32;

            Console.Write("{0} grados Celsius es igual a ", celsius);
            Console.WriteLine("{0} grados Fahrenheit", fahrenheit);
        }
    }