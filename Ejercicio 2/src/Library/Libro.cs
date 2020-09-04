﻿using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
        //Incumple con el principio Srp, para crear un libro no hace falta almacenarlo, pero si conocer su ubicacion.
        //Se debería de crear otra clase que trabaje con ésta para cumplir el almacenamiento de libros llamada Biblioteca, por ejemplo, en la cual
        //puedas tanto almacenar como sacar el libro del almacen.
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
