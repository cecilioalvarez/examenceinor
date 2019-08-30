using System;
using System.Collections.Generic;

namespace LibreriaPersonas
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        public override bool Equals(object obj)
        {
            return obj is Persona persona &&
                   Nombre == persona.Nombre &&
                   Apellidos == persona.Apellidos &&
                   Edad == persona.Edad;
        }

        public override int GetHashCode()
        {
            var hashCode = 1289742506;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
            hashCode = hashCode * -1521134295 + Edad.GetHashCode();
            return hashCode;
        }


    }
}
