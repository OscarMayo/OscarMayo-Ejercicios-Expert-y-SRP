using System;

namespace Library
{
    public class Doctor 
    {
        private string nombre;
        private string especialidad;
        public Doctor(String nombre, String especialidad)
        {
            this.Nombre = nombre;
            this.Especialidad = especialidad;
        }
        public String Nombre {get;set;}
        public String Especialidad {get; set;}

        public bool Valido(string nombre, string especialidad)
    {
        if (string.IsNullOrEmpty(this.Nombre) || string.IsNullOrEmpty(this.Especialidad))
        {
            return false;
        }
        else{return true;}
    }
    }
    
}

