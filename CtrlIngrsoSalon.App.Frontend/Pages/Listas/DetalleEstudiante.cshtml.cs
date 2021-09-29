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
    public class DetalleEstudianteModel : PageModel
    {
        private static IRepositorioEstudiante _repositorioEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
 
        public Estudiante estudiante{get;set;}
       

        public IActionResult OnGet(int personaId , int estudId)
        {


          estudiante = _repositorioEstudiante.GetEstudiante(personaId);
   
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
