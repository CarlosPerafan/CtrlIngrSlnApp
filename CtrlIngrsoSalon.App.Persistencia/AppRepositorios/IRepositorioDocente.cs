using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioDocente
    {
        IEnumerable<Docente> GetAllDocentes();

        Docente AddDocente(Docente docente);

        Docente UpdateDocente(Docente docente);

        Boolean DeleteDocente(int idDocente);

        Docente GetDocente(int idDocente);
    }
}
