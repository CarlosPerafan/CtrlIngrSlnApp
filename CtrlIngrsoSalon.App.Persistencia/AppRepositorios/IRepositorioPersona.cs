using System.Collections.Generic;
using System;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public interface IRepositorioPersona 
    {
        IEnumerable<Persona> GetAllPersona();
        Persona AddPersona (Persona persona);
        Persona UpdatePersona (Persona persona);
        Boolean DeletePersona (int idPersona);
        Persona GetPersona(int idPersona);

    }
}
