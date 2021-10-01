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
    public class EliminarHorarioModel : PageModel
    {
        private static IRepositorioHorario _repositorioHorario = new RepositorioHorario(new Persistencia.AppContext());
        [BindProperty]
        public Horario horario { get; set; }

        public IActionResult OnGet(int? horarioId)
        {
            Console.WriteLine("Ingrese  " + horarioId);

            if (horarioId.HasValue)
            {
                horario = _repositorioHorario.GetHorario(horarioId.Value);

            }

            if (horario == null)
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

            if (horario.id > 0 && horario.id > 0)
            {
                horario = _repositorioHorario.GetHorario(horario.id);
                eliminado = _repositorioHorario.DeleteHorario(horario.id);
            }
            

            Console.WriteLine("eliminado = " + eliminado);



            if (eliminado != true)
            {
                return RedirectToPage("./Mensaje");
            }
            else
            {
                //return Page();
                return RedirectToPage("./Horario");
            }

        }

    }
}
