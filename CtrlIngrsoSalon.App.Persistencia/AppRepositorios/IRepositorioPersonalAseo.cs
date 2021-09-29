using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioPersonalAseo
    {
        IEnumerable<PersonalAseo> GetAllPersonalAseos();

        PersonalAseo AddPersonalAseo(PersonalAseo PersonalAseo);

        PersonalAseo UpdatePersonalAseo(PersonalAseo PersonalAseo);

        Boolean DeletePersonalAseo(int idPersonalAseo);

        PersonalAseo GetPersonalAseo(int idPersonalAseo);
    }
}
