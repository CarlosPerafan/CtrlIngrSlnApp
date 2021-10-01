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
    public class DetallePreguntasModel : PageModel { 
        private static IRepositorioPregunta _repositorioPregunta = new RepositorioPregunta(new Persistencia.AppContext());
        [BindProperty]
        public Pregunta pregunta { get; set; }

    }
}
