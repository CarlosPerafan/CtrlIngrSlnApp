using System.Collections.Generic;
using CtrlIngrsoSede.App.Dominio;

namespace CtrlIngrsoSede.App.Persistencia
{
    public interface IRepositorioSede
    {
        IEnumerable<Sede> GetAllSedes();

        Sede AddSede(Sede Sede);

        Sede UpdateSede(Sede Sede);

        Boolean DeleteSede(int idSede);

        Sede GetSede(int idSede);
    }
}
