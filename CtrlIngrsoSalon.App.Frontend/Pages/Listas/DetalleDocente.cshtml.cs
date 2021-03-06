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
    public class DetalleDocenteModel : PageModel
    {
        private static IRepositorioDocente
            _repositorioDocente =
                new RepositorioDocente(new Persistencia.AppContext());

        public Docente docente { get; set; }

        public IActionResult OnGet(int docenteId, int docId)
        {
            docente = _repositorioDocente.GetDocente(docenteId);

            if (docente == null)
            {
                return RedirectToPage("./Mensaje");
            }
            else
            {
                return Page();
            }
        }
    }
}
