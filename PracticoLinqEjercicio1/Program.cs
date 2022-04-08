using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticoLinqEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numerosAleatorios = new List<int>() { 1,2,3,1,1,2,5};

            //var valoresAgrupados = numerosAleatorios.GroupBy(x => x).ToList();

            //foreach (var grupo in valoresAgrupados)
            //{
            //    var listaAgrupada = grupo.ToList();
            //}

            List<Auto> autos = new List<Auto>()
            {
                new Auto("Fiat","Uno"),
                new Auto("Fiat","Palio"),
                new Auto("Ford","Fiesta")
            };

            var primerAutoFiat = autos.FirstOrDefault(auto => auto.Marca == "Fiat");
            var pirmerAutoFiatConWhere = autos.Where(auto => auto.Marca == "Fiat").FirstOrDefault();

            var autosAgrupadosPorMarca = autos.GroupBy(x => x.Marca).ToList();


            foreach (var autosAgrupados in autosAgrupadosPorMarca)
            {

                Console.WriteLine($"Para la marca {autosAgrupados.Key}, existen {autosAgrupados.Count()} autos");

                autosAgrupados.Count();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
