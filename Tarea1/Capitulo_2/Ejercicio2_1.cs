using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Ejercicio2_1
    {
        public Ejercicio2_1()
        {
            int cantidadLado;
            float medidaLado;
            float perimetro;

            Console.Write("Digite la cantidad de lados del poligono regular: ");
            cantidadLado = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite la medida de los lados del poligono: ");
            medidaLado = Convert.ToSingle(Console.ReadLine());

            perimetro = medidaLado * cantidadLado;

            Console.Write("El perimetro del poligono es: {0}", perimetro);
        }
    }