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
    public class EditarEstudianteModel : PageModel
    {

        private static IRepositorioEstudiante _repositorioEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        [BindProperty]
        public Estudiante estudiante { get; set; }

        public IActionResult OnGet(int? estudianteId)
        {

            if (estudianteId.HasValue)
            {
                estudiante = _repositorioEstudiante.GetEstudiante(estudianteId.Value);
            }
            else
            {
                estudiante = new Estudiante();
            }




            if (estudiante == null)
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

 

       /*   if(!ModelState.IsValid)
          {
            return Page();
          }
*/



            if (estudiante.persona.id > 0)
            {

                estudiante = _repositorioEstudiante.UpdateEstudiante(estudiante);
            }
            else
            {

                estudiante = _repositorioEstudiante.AddEstudiante(estudiante);
            }
            if (estudiante == null)
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
