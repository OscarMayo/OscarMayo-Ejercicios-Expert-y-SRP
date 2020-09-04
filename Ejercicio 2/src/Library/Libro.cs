using System;

namespace SRP
{
    public class Libro
    {

        private String titulo;
        private String autor;
        private String codigo;

        public Libro(String titulo, String autor, String codigo)
        {
        this.Titulo = titulo;
        this.Autor = autor;
        this.Codigo = codigo;

        }
        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }
    }
}
