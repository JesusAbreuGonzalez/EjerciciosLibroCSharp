using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    class ParImpar
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite el numero que desea evaluar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0)
                Console.WriteLine("El numero {0} es par", numero);
            else
                Console.WriteLine("El numero {0} es impar", numero);
        }
    }
}