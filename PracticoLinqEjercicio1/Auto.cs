using System;
using System.Collections.Generic;
using System.Text;

namespace PracticoLinqEjercicio1
{
    public class Auto
    {
        public string Marca { get; }
        public string Modelo { get; }

        public Auto(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }
    }
}
