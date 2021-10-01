using System.Collections.Generic;
using System;
using  CtrlIngrsoSalon.App.Dominio;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioHorario
    {
        IEnumerable<Horario> GetAllHorario();

        Horario AddHorario (Horario horario);

        Horario UpdateHorario (Horario horario);

        Boolean DeleteHorario (int idHorario);

        Horario GetHorario(int idHorario); 

        IEnumerable<Horario> GetTodosHorarios();
        
    }
}
