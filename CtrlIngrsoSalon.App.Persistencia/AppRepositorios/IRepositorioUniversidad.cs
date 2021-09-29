using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioUniversidad
    {
        IEnumerable<Universidad> GetAllUniversidads();

        Universidad AddUniversidad(Universidad Universidad);

        Universidad UpdateUniversidad(Universidad Universidad);

        Boolean DeleteUniversidad(int idUniversidad);

        Universidad GetUniversidad(int idUniversidad);
    }
}
