using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        //ConvertirAPesos no debería estar en esta clase, esta tiene la información necesaria, pero también limita a este método, tendiendo a incumplir con el principio SRP.
        //No se cumple el Expert, las responsabilidades de esta clase también dependen de la clase alfajor, la cual tampoco se encuentra encapsulada correctamente.
        private Double ConvertirAPesos(Double dinero, String moneda)
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