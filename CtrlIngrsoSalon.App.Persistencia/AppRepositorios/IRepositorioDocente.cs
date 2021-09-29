using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioDocente
    {
<<<<<<< HEAD
        IEnumerable<Docente> GetAllDocente();
        Docente AddDocente (Docente docente);
        Docente UpdateDocente (Docente docente);
        Boolean DeleteDocente (int idDocente, int idPersona);
        Docente GetDocente(int idDocente);

        IEnumerable<Docente> GetTodosDocentes();
   
=======
        IEnumerable<Docente> GetAllDocentes();

        Docente AddDocente(Docente docente);
>>>>>>> 4760a6a1cbbbb163e03a3dbae578781f73168d22

        Docente UpdateDocente(Docente docente);

        Boolean DeleteDocente(int idDocente);

        Docente GetDocente(int idDocente);
    }
}
