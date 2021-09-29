using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
<<<<<<< HEAD
        IEnumerable<Estudiante> GetAllEstudiante();
        Estudiante AddEstudiante (Estudiante estudiante);
        Estudiante UpdateEstudiante (Estudiante estudiante);
        Boolean DeleteEstudiante (int idEstudiante, int idPersona);
        Estudiante GetEstudiante(int idEstudiante);
=======
        IEnumerable<Estudiante> GetAllEstudiantes();
>>>>>>> 4760a6a1cbbbb163e03a3dbae578781f73168d22

        Estudiante AddEstudiante(Estudiante estudiante);

<<<<<<< HEAD
        //Boolean GetTodosEstudiante(); //ok
       IEnumerable<Estudiante> GetTodosEstudiantes();

=======
        Estudiante UpdateEstudiante(Estudiante estudiante);

        Boolean DeleteEstudiante(int idEstudiante);

        Estudiante GetEstudiante(int idEstudiante);
>>>>>>> 4760a6a1cbbbb163e03a3dbae578781f73168d22
    }
}
