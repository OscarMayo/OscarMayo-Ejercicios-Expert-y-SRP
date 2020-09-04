using System;
namespace Expert_SRP
{
    class Convertir
    {
        private Double dinero;
        private String moneda;

        public Convertir(Double precioMasa, String precioDulce)
        {
            this.Dinero = dinero;
            this.Moneda = moneda;
        }
        public Double Dinero {get; set;}
        public String Moneda {get; set;}



    public static Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}