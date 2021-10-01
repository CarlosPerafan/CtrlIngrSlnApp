using System;
using System.Collections.Generic;
using System.Linq;
using CtrlIngrsoSalon.App.Dominio;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public class RepositorioPregunta : IRepositorioPregunta
    {
        //Referencia al Contexto del Docente
        private readonly AppContext _appContext;

        public RepositorioPregunta(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Pregunta> IRepositorioPregunta.GetAllPreguntas()
        {
            return _appContext.Preguntas;
        }

        Pregunta IRepositorioPregunta.AddPregunta(Pregunta pregunta)
        {
            var preguntaAdicionado = _appContext.Preguntas.Add(pregunta);
            _appContext.SaveChanges();
            return preguntaAdicionado.Entity;
        }

        Pregunta IRepositorioPregunta.UpdatePregunta(Pregunta pregunta)
        {
            var preguntaEncontrado =
                _appContext.Preguntas.FirstOrDefault(p => p.id == pregunta.id);
            if (preguntaEncontrado != null)
            {
                preguntaEncontrado.pregunta = pregunta.pregunta;
                preguntaEncontrado.respuestaEsperada =
                    pregunta.respuestaEsperada;
                _appContext.SaveChanges();
            }
            return preguntaEncontrado;
        }

        void IRepositorioPregunta.DeletePregunta(int idPregunta)
        {
            var preguntaEncontrado =
                _appContext.Preguntas.FirstOrDefault(p => p.id == idPregunta);
            if (preguntaEncontrado == null)
            {
                return;
            }
            _appContext.Preguntas.Remove (preguntaEncontrado);
            _appContext.SaveChanges();
        }

        Pregunta IRepositorioPregunta.GetPregunta(int idPregunta)
        {
            return _appContext
                .Preguntas
                .FirstOrDefault(p => p.id == idPregunta);
        }
    }
}
