using System;
using System.Collections.Generic;
using System.Text;

namespace PracticoLinqEjercicio3
{
    public class Autor
    {
        public int IdAutor { get; set; }
        public string Nombre { get; set; }

        public Autor(int idAutor, string nombre)
        {
            this.IdAutor = idAutor;
            this.Nombre = nombre;
        }

        public static List<Autor> Autores()
        {
            return new List<Autor>
            {
                new Autor(1, "Miguel de Cervantes"),
                new Autor(2, "Charles Dickens"),
                new Autor(3, "J. R. R. Tolkien"),
                new Autor(4, "Antoine de Saint-Exupéry"),
                new Autor(5, "Cao Xueqin"),
                new Autor(6, "Lewis Car"),
                new Autor(7, "Agatha Christie"),
                new Autor(8, "C. S. Lewis"),
                new Autor(9, "Dan Brown"),
                new Autor(10, "J. D. Salinger"),
            };
        }
    }
}
