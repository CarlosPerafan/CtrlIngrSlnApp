using System.Collections.Generic;
using System;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public interface IRepositorioDocente 
    {
        IEnumerable<Docente> GetAllDocente();
        Docente AddDocente (Docente docente);
        Docente UpdateDocente (Docente docente);
        Boolean DeleteDocente (int idDocente);
        Docente GetDocente(int idDocente);


    }
}
