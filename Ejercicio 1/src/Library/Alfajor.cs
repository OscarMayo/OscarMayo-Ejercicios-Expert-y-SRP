using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        private Double PrecioDulce {get;set;}
        private Double PrecioMasa {get; set;}
    }
}