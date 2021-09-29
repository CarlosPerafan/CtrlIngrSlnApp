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
    public class CrearEstudianteModel : PageModel
    {
        private static IRepositorioEstudiante _repositorioEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        public Estudiante estudiante{get;set;}
        public void OnGet()
        {

           // estudiante= _repositorioEstudiante.Estudiante.AddEstudiante(Estudiante alumno);
        }
    }
}
