using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioDocente
    {
        IEnumerable<Docente> GetAllDocentes();
        Docente AddDocente (Docente docente);
        Docente UpdateDocente (Docente docente);
        Boolean DeleteDocente (int idDocente, int idPersona);
        Docente GetDocente(int idDocente);

        IEnumerable<Docente> GetTodosDocentes();
   
    }
}
