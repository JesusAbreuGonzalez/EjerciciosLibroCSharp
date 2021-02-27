using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioCSharp.Capitulo10
{
    public class Ejercicio10_1
    {
        public Ejercicio10_1()
        {

        }
    }

    class Productos
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public Productos()
        {
            Nombre = " ";
            Codigo = 0;
            Cantidad = 0;
            Descripcion = "";
            Precio = 0.0;
        }

        public Productos(string Nombre, int Codigo, string Descripcion, double Precio)
        {
            this.Nombre = Nombre;
            this.Codigo = Codigo;
            Cantidad = 1;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
        }

        public void Agregar(int Cantidad)
        {
            if (Cantidad > 0)
            {
                this.Cantidad += Cantidad;
            }
        }

        public int Retirar(int CantSolicitada)
        {
            if (CantSolicitada > 0)
            {
                if (Cantidad <= CantSolicitada)
                {
                    Cantidad -= CantSolicitada;
                }
                else
                {
                    CantSolicitada = Cantidad;
                    Cantidad -= Cantidad;
                }

                return CantSolicitada;
            }
            else
            {
                return 0;
            }
        }        
    }
}
