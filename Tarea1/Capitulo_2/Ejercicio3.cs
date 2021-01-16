using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3
{
    class Conversion
    {
        static void Main(string[] args)
        {
            float grados;
            double radianes;

            Console.Write("Digite la cantidad de grados que desea convertir: ");
            grados = Convert.ToSingle(Console.ReadLine());
            
            radianes = grados * (System.Math.PI/180);

            Console.Write("{0} grados ", grados);
            Console.WriteLine("es igual a {0} radianes", radianes);
        }
    }
}