using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioCSharp.Capitulo12
{
    public class Ejercicio12_1
    {
        public Ejercicio12_1()
        {

        }
        
        public int Factorial(int numero)
        {
            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public void Mostrar()
        {
            int numero;

            Console.WriteLine("En este programa se mostrara el valor del factorial del numero que ingrese.");

            Console.Write("Ingrese el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El factorial de {numero} es: {Factorial(numero)}");
        }

    }    
}
