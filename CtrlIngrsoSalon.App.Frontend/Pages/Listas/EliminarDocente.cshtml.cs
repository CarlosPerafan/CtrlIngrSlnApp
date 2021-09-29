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
    public class EliminarDocenteModel : PageModel
    {
        private static IRepositorioDocente _repositorioDocente = new RepositorioDocente(new Persistencia.AppContext());
        [BindProperty]
        public Docente docente { get; set; }

        public IActionResult OnGet(int? docenteId)
        {
            Console.WriteLine("entro  " + docenteId);

            if (docenteId.HasValue)
            {
                docente = _repositorioDocente.GetDocente(docenteId.Value);

            }

            if (docente == null)
            {
                return RedirectToPage("./Mensaje");
            }
            else
            {
                return Page();
            }


        }

        public IActionResult OnPost()
        {
            Boolean eliminado = false;

            if (docente.id > 0 && docente.persona.id > 0)
            {
                docente = _repositorioDocente.GetDocente(docente.persona.id);
                eliminado = _repositorioDocente.DeleteDocente(docente.id, docente.persona.id);
            }
            

            Console.WriteLine("eliminado = " + eliminado);



            if (eliminado != true)
            {
                return RedirectToPage("./Mensaje");
            }
            else
            {
                //return Page();
                return RedirectToPage("./Docentes");
            }

        }

    }
}
