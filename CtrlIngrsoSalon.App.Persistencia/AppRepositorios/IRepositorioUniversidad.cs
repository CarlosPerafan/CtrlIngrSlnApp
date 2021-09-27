using System.Collections.Generic;
using CtrlIngrsoUniversidad.App.Dominio;

namespace CtrlIngrsoUniversidad.App.Persistencia
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
