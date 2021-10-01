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
    public class DetalleHorarioModel : PageModel
    {
        private static IRepositorioHorario _repositorioHorario = new RepositorioHorario(new Persistencia.AppContext());
 
        public Horario horario{get;set;}
       

        public IActionResult OnGet(int horarioId)
        {


          horario = _repositorioHorario.GetHorario(horarioId);
   
          if (horario == null)
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
