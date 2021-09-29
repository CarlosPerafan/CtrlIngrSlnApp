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
    public class EditarDocenteModel : PageModel
    {

        private static IRepositorioDocente _repositorioDocente = new RepositorioDocente(new Persistencia.AppContext());
        [BindProperty]
        public Docente docente { get; set; }

        public IActionResult OnGet(int? docenteId)
        {

            if (docenteId.HasValue)
            {
                docente = _repositorioDocente.GetDocente(docenteId.Value);
            }
            else
            {
                docente = new Docente();
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

/*
          if(!ModelState.IsValid)
          {
            return Page();
          }else 

          {*/
        

            if (docente.persona.id > 0)
            {
                docente = _repositorioDocente.UpdateDocente(docente);
            }
            else
            {                     
                docente = _repositorioDocente.AddDocente(docente);
            }



            if (docente == null)
            {
                return RedirectToPage("./Mensaje");
            }
            else
            {
                return Page();
                //return RedirectToPage("./Docentes");
            }
        //  }   
        }
    }
}
