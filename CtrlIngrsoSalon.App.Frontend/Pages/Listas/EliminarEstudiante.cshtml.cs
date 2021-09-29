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
    public class EliminarEstudianteModel : PageModel
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
            Boolean eliminado = false;

            if (estudiante.id > 0 && estudiante.persona.id > 0)
            {
                estudiante = _repositorioEstudiante.GetEstudiante(estudiante.persona.id);
                eliminado = _repositorioEstudiante.DeleteEstudiante(estudiante.id, estudiante.persona.id);
            }


            Console.WriteLine("eliminado = " + eliminado);



            if (eliminado != true)
            {
                return RedirectToPage("./Mensaje");
            }
            else
            {
                //return Page();
                return RedirectToPage("./Estudiantes");
            }

        }

    }
}
