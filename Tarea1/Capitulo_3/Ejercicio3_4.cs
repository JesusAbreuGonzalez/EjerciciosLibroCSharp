using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Ejercicio3_4
    {
        public Ejercicio3_4()
        {
            int numero;

            Console.Write("Digite un numero del 1 al 7: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch(numero)
            {
                case 1:
                    Console.WriteLine("El numero {0} corresponde al dia Domingo", numero);
                    break;
                case 2:
                    Console.WriteLine("El numero {0} corresponde al dia Lunes", numero);
                    break;
                case 3:
                    Console.WriteLine("El numero {0} corresponde al dia Martes", numero);
                    break;
                case 4:
                    Console.WriteLine("El numero {0} corresponde al dia Miercoles", numero);
                    break;
                case 5:
                    Console.WriteLine("El numero {0} corresponde al dia Jueves", numero);
                    break;
                case 6:
                    Console.WriteLine("El numero {0} corresponde al dia Viernes", numero);
                    break;
                case 7:
                    Console.WriteLine("El numero {0} corresponde al dia Sabado", numero);
                    break;
                default:
                    Console.WriteLine("El numero {0} no es una opcion valida", numero);
                    break;
            }
        }
    }