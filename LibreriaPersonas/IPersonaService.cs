using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaPersonas
{
    public interface IPersonaService
    {
        List<Persona> BuscarTodos();
        void InsertarPersona(Persona persona);
    }
}
