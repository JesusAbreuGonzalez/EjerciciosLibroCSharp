using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioCSharp.Capitulo10
{
    public class Ejercicio10_5
    {
        public Ejercicio10_5()
        {

        }
    }
    class Poligono5
    {
        public float Lados
        {
            get
            {
                return Lados;
            }
            set
            {
                if (value <= 0)
                {
                    Lados = 3;
                }
                else
                {
                    Lados = value;
                }
            }
        }
        public float MedidasLados
        {
            get
            {
                return MedidasLados;
            }
            set
            {
                if (value <= 0)
                {
                    MedidasLados = 3;
                }
                else
                {
                    MedidasLados = value;
                }
            }
        }
        public Poligono5()
        {
            Lados = 0;
            MedidasLados = 0.0f;
        }

        public Poligono5(int Lados, float MedidasLados)
        {
            if (Lados <= 2)
            {
                this.Lados = Lados;
            }

            if (MedidasLados <= 0)
            {
                this.MedidasLados = MedidasLados;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Poligono: \n\tLados del polígono: {Lados}\n\tMedidas de los lados: {MedidasLados}");
            return (sb.ToString());
        }
    }
}
