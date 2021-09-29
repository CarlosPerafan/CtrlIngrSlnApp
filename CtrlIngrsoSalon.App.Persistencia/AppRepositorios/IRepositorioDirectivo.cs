using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioDirectivo
    {
        IEnumerable<Directivo> GetAllDirectivos();

        Directivo AddDirectivo(Directivo Directivo);

        Directivo UpdateDirectivo(Directivo Directivo);

        Boolean DeleteDirectivo(int idDirectivo);

        Directivo GetDirectivo(int idDirectivo);
    }
}
