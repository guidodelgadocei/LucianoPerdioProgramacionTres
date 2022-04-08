using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> numeros = new List<int>() { 1,2,3,4,5,6,7,8,9};

            Sumar();
            SumarPares();
            OrdenarDescendiente();
            ImprimirPares();
        }

        static void Sumar()
        {
            var valores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var suma = 0;

            foreach (var valor in valores)
            {
                suma += valor;
            }

            Console.WriteLine(suma);
        }
        static void SumarPares()
        {
            var valores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var suma = 0;
            foreach (var valor in valores)
            {
                if (valor % 2 == 0)
                {
                    suma += valor;
                }
            }
            Console.WriteLine(suma);
        }
        static void OrdenarDescendiente()
        {
            List<int> valores = new List<int>() { 3, 6, 9, 7, 4, 1, 2, 5, 8 };

            for (var indice = 0; indice < valores.Count - 1; indice++)
            {

                if (valores[indice] > valores[indice + 1])
                {
                    var valorTemporal = valores[indice];

                    valores[indice] = valores[indice + 1];
                    valores[indice + 1] = valorTemporal;

                    indice = -1;
                }
            }

            foreach (var valorOrdenado in valores)
            {
                Console.WriteLine(valorOrdenado);
            }
        }
        static void ImprimirPares()
        {
            var valores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valoresPares = new List<int>();

            foreach (var valor in valores)
            {
                if (valor % 2 == 0)
                {
                    valoresPares.Add(valor);
                }
            }

            foreach (var par in valoresPares)
            {
                Console.WriteLine(par);
            }
        }
    }
}
