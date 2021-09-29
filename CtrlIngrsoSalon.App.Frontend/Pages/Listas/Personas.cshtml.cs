using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CtrlIngrsoSalon.App.Persistencia;
using CtrlIngrsoSalon.App.Dominio;

namespace CtrlIngrsoSalon.App.Frontend.Pages
{
    public class PersonasModel : PageModel
    {
        private static IRepositorioPersona _repositorioPersona = new RepositorioPersona(new Persistencia.AppContext());
        public IEnumerable<Persona> Personas {get;set;}
        public void OnGet()
        {
            Personas = _repositorioPersona.GetAllPersonas();
        }
    }
}
