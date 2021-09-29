using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
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
