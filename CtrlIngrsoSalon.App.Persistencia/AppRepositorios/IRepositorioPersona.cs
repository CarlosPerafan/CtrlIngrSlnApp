using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();

        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);

        Boolean DeletePersona(int idPersona);

        Persona GetPersona(int idPersona);
    }
}
