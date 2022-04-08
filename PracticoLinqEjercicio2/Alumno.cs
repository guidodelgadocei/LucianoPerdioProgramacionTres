using System;
using System.Collections.Generic;
using System.Text;

namespace PracticoLinqEjercicio2
{
    public class Alumno
    {
        public string Nombre { get; }
        public int Edad { get; }
        public int Nota { get; }

        public Alumno(string nombre, int edad, int nota)
        {
            Nombre = nombre;
            Edad = edad;
            Nota = nota;
        }

    }
}
