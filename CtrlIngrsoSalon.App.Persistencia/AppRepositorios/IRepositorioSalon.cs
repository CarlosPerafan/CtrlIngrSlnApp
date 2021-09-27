using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioSalon
    {
        IEnumerable<Salon> GetAllSalons();

        Salon AddSalon(Salon Salon);

        Salon UpdateSalon(Salon Salon);

        Boolean DeleteSalon(int idSalon);

        Salon GetSalon(int idSalon);
    }
}
