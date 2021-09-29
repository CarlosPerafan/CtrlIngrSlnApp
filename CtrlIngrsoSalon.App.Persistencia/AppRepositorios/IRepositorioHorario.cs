using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioHorario
    {
        IEnumerable<Horario> GetAllHorarios();

        Horario AddHorario(Horario Horario);

        Horario UpdateHorario(Horario Horario);

        Boolean DeleteHorario(int idHorario);

        Horario GetHorario(int idHorario);
    }
}
