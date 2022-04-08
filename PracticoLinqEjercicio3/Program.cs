using System;
using System.Linq;

namespace PracticoLinqEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var libros = Libro.Libros();
            var autores = Autor.Autores();


            /*var ventasDeAutores = libros.Join(autores,
                                                libro => libro.IdAutor,
                                                autor => autor.IdAutor,
                                                (libro, autor) => new { NombreAutor = autor.Nombre, CantidadDeVentas = libro.CantidadDeVentas, Titulo = libro.Titulo })
                                         .ToList();


            var autoresConLibros = libros.Join(autores,
                                                 libro => libro.IdAutor,
                                                 autor => autor.IdAutor,
                                                 (libro, autor) => new { IdAutor = autor.IdAutor, NombreAutor = autor.Nombre, TituloLibro = libro.Titulo }).ToList();


            var autoresConLibrosEl = autoresConLibros.Where(autorConLibro => autorConLibro.TituloLibro.StartsWith("El"))
                                                     .Select(autor => autor.NombreAutor)
                                                     .Distinct()
                                                     .ToList();*/


            var autoresJoinLibros = libros.Join(autores,
                                                libro => libro.IdAutor,
                                                autor => autor.IdAutor,
                                                (libro, autor) => new { IdAutor = autor.IdAutor, NombreAutor = autor.Nombre, TituloLibro = libro.Titulo }).ToList();

            foreach (var autorLibro in autoresJoinLibros)
            {
                Console.WriteLine(autorLibro.NombreAutor);
            }

        }
    }
}
