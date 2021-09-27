using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioPersonaHorario
    {
        IEnumerable<PersonaHorario> GetAllPersonaHorarios();

        PersonaHorario AddPersonaHorario(PersonaHorario PersonaHorario);

        PersonaHorario UpdatePersonaHorario(PersonaHorario PersonaHorario);

        Boolean DeletePersonaHorario(int idPersonaHorario);

        PersonaHorario GetPersonaHorario(int idPersonaHorario);
    }
}
