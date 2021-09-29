using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
        IEnumerable<Estudiante> GetAllEstudiantes();
        Estudiante AddEstudiante (Estudiante estudiante);
        Estudiante UpdateEstudiante (Estudiante estudiante);
        Boolean DeleteEstudiante (int idEstudiante, int idPersona);
        Estudiante GetEstudiante(int idEstudiante);


        //Boolean GetTodosEstudiante(); //ok
       IEnumerable<Estudiante> GetTodosEstudiantes();

    }
}
