using System.Collections.Generic;
using System;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public interface IRepositorioEstado 
    {
        IEnumerable<Estado> GetAllEstado();
        Estado AddEstado (Estado estado);
        Estado UpdateEstado (Estado estado);
        Boolean DeleteEstado (int idEstado);
        Estado GetEstado(int idEstado);

    }
}
