using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioCSharp.Capitulo10
{
    public class Ejercicio10_2
    {
        public Ejercicio10_2()
        {

        }
    }

    class Estudiantes
    {
        public int Codigo { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Curso { get; set; }
        public string Telefono { get; set; }


        public Estudiantes()
        {
            Codigo = 0;
            NombreCompleto = "";
            Edad = 0;
            Direccion = "";
            Curso = "";
            Telefono = "";
        }

        public Estudiantes(int Codigo, string NombreCompleto, int Edad, string Curso, string Direccion, string Telefono)
        {
            this.Codigo = Codigo;
            this.NombreCompleto = NombreCompleto;
            this.Edad = Edad;
            this.Direccion = Direccion;
            this.Curso = Curso;
            this.Telefono = Telefono;
        }
    }
}
