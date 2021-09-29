using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioEstado
    {
        IEnumerable<Estado> GetAllEstados();

        Estado AddEstado(Estado estado);

        Estado UpdateEstado(Estado estado);

        Boolean DeleteEstado(int idEstado);

        Estado GetEstado(int idEstado);
    }
}
