using System;

namespace Library
{
    public class Paciente 
    {
        private string nombre;
        private string id;
        private string num_cel;
        private string edad;
    
        public Paciente(String nombre, String id, String num_cel, String edad)
        {
            this.Nombre = nombre;
            this.ID = id;
            this.Num_Cel = num_cel;
            this.edad = Edad;
        }
        public String Nombre {get;set;}
        public String ID {get; set;}
        public String Num_Cel {get; set;}
        public String Edad {get; set;}

        public bool Validez(string nombre, string id, string num_cel, string edad)
    {
        if (string.IsNullOrEmpty(this.Nombre)
         || string.IsNullOrEmpty(this.ID) 
         || string.IsNullOrEmpty(this.Num_Cel)
         || string.IsNullOrEmpty(this.Edad))
        {
            return false;
        }
        else{return true;}
    }
    }
    
}
    }
}

