using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CtrlIngrsoSalon.App.Dominio;
using CtrlIngrsoSalon.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CtrlIngrsoSalon.App.Frontend.Pages
{
    public class PreguntasModel : PageModel
    {
        private static IRepositorioPregunta
            _repositorioPregunta =
                new RepositorioPregunta(new Persistencia.AppContext());

        public IEnumerable<Pregunta> Preguntas { get; set; }

        public void OnGet()
        {
            Preguntas = _repositorioPregunta.GetAllPreguntas();
        }
    }
}
