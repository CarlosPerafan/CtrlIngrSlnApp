using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioEncuesta
    {
        IEnumerable<Encuesta> GetAllEncuestas();

        Encuesta AddEncuesta(Encuesta Encuesta);

        Encuesta UpdateEncuesta(Encuesta Encuesta);

        Boolean DeleteEncuesta(int idEncuesta);

        Encuesta GetEncuesta(int idEncuesta);
    }
}
