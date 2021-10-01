using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioPersonaHorario
    {
        IEnumerable<PersonaHorario> GetAllPersonaHorarios();

        PersonaHorario AddPersonaHorario(PersonaHorario personaHorario);

        PersonaHorario UpdatePersonaHorario(PersonaHorario personaHorario);

        Boolean DeletePersonaHorario(int idPersonaHorario);

        PersonaHorario GetPersonaHorario(int idPersonaHorario);
    }
}
