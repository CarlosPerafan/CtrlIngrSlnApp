using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioPregunta
    {
        IEnumerable<Pregunta> GetAllPreguntas();

        Pregunta AddPregunta(Pregunta pregunta);

        Pregunta UpdatePregunta(Pregunta Pregunta);

        void DeletePregunta(int idPregunta);

        Pregunta GetPregunta(int idPregunta);
    }
}
