using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaPersonas
{
    public class PersonaService : IPersonaService
    {
        private static List<Persona> listaPersonas = new List<Persona>();

        static  PersonaService() {

            listaPersonas.Add(new Persona("pepe", "perez", 20));
            listaPersonas.Add(new Persona("juan", "sanchez", 40));
            listaPersonas.Add(new Persona("ana", "gomez", 25));
        }

         
        public List<Persona> BuscarTodos()
        {
            return listaPersonas;
        }

        public void InsertarPersona(Persona persona)
        {
            listaPersonas.Add(persona);
         
        }
    }
}
