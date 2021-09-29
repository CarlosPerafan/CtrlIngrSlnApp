using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioPregunta
    {
        IEnumerable<Pregunta> GetAllPreguntas();

        Pregunta AddPregunta(Pregunta Pregunta);

        Pregunta UpdatePregunta(Pregunta Pregunta);

        Boolean DeletePregunta(int idPregunta);

        Pregunta GetPregunta(int idPregunta);
    }
}
