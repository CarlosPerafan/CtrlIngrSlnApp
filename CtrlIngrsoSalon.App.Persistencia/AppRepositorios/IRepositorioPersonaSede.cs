using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioPersonaSede
    {
        IEnumerable<PersonaSede> GetAllPersonaSedes();

        PersonaSede AddPersonaSede(PersonaSede PersonaSede);

        PersonaSede UpdatePersonaSede(PersonaSede PersonaSede);

        Boolean DeletePersonaSede(int idPersonaSede);

        PersonaSede GetPersonaSede(int idPersonaSede);
    }
}
