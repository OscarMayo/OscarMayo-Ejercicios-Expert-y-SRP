using System;

namespace SRP
{
    public class Biblioteca
    {
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

        public void ExtraerLibro()
        {
            this.SectorBiblioteca = "Fuera";
            this.EstanteBiblioteca = "Fuera";
        }

    }
}