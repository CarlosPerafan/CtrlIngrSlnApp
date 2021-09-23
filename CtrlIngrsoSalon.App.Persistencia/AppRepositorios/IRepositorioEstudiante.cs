using System.Collections.Generic;
using System;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public interface IRepositorioEstudiante
    {
        IEnumerable<Estudiante> GetAllEstudiante();
        Estudiante AddEstudiante (Estudiante estudiante);
        Estudiante UpdateEstudiante (Estudiante estudiante);
        Boolean DeleteEstudiante (int idEstudiante);
        Estudiante GetEstudiante(int idEstudiante);


    }
}
