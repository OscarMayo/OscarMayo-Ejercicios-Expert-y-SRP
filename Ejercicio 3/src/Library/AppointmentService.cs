using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
       public class Appoinment 
    {
        private DateTime fecha;
        private String lugar;
        private double identificador;
        private double numero=0;

        public Appoinment(DateTime fecha,String lugar,double identificador )
        {
            this.Fecha = fecha;
            this.Lugar = Lugar;
            this.Identificador= identificador;
        }
        public DateTime Fecha {
            get{return this.Fecha;}
            set{
            
                this.Fecha=value;
            }
        }
        public String Lugar {
            get{return this.Lugar;}
            set{if (! String.IsNullOrEmpty(value))
            {
                this.Lugar=value;
            };
            }}
        public Double Identificador {
            get{return this.Identificador;}
            set{this.Identificador=numero;
            numero+=1;
            }}
        public bool Validoappointment(DateTime fecha, string lugar, double identificador)
            {
                if (string.IsNullOrEmpty(this.lugar) || (this.identificador==0))
                {
                    return false;
                }
                else{return true;}

        public static string CreateAppointment(string name,string age, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName, string especialidad, double identifica)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
            
            if (Validoappointment(date,appoinmentPlace,identifica))
            {
                
            }
            else
            {
            isValid=false;
            stringBuilder.Append("Error con el appointment");
            }


            if (Paciente.Validez(name,id,phoneNumber,age))
            {
                
            }
            else
            {
            isValid=false;
            stringBuilder.Append("Error con el paciente");
            }

            if (Doctor.Valido(doctorName,especialidad))
            {
                
            }
            else
            {
            isValid=false;
            stringBuilder.Append("Error con el Doctor");
            }


            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
