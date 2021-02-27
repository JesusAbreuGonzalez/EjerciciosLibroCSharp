using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioCSharp.Capitulo10
{
    public class Ejercicio10_3
    {
        public Ejercicio10_3()
        {

        }
    }
    class Poligonos
    {
        public int CantidadLados { get; set; }
        public float MedidaLados { get; set; }

        public Poligonos()
        {
            CantidadLados = 0;
            MedidaLados = 0.0f;
        }

        public Poligonos(int CantidadLados, float MedidaLados)
        {
            this.CantidadLados = CantidadLados;
            this.MedidaLados = MedidaLados;
        }
    }
}
