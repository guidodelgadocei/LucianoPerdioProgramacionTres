using System;
using System.Collections.Generic;
using System.Text;

namespace PracticoLinqEjercicio3
{
    public class Libro
    {
        public string Titulo { get; }
        public int IdAutor { get; }
        public int AnioPublicacion { get; }
        public int CantidadDeVentas { get; }

        public Libro(string titulo, int idAutor, int anioPublicacion, int cantidadDeVentas)
        {
            this.Titulo = titulo;
            this.IdAutor = idAutor;
            this.AnioPublicacion = anioPublicacion;
            this.CantidadDeVentas = cantidadDeVentas;
        }

        public static List<Libro> Libros()
        {
            return new List<Libro>
            {
                new Libro("Don Quijote de la Mancha", 1, 1605, 500),
                new Libro("Historia de dos ciudades", 2, 1859, 200),
                new Libro("El Señor de los Anillos", 3, 1978, 150),
                new Libro("El principito", 4, 1951, 140),
                new Libro("El hobbit", 3, 1982, 100),
                new Libro("Sueño en el pabellón rojo", 5, 1792, 100),
                new Libro("Las aventuras de Alicia en el país de las maravillas", 6, 1865, 100),
                new Libro("Diez negritos", 7, 1939, 100),
                new Libro("El león, la bruja y el armario", 8, 1950, 85),
                new Libro("El código Da Vinci", 9, 2003, 80),
                new Libro("El guardián entre el centeno", 10, 1951, 65),
                new Libro("El alquimista", 11, 1988, 65),
            };
        }
    }
}
