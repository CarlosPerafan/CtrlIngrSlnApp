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
    public class EstudiantesModel : PageModel
    {
        private static IRepositorioEstudiante _repositorioEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        public IEnumerable<Estudiante> Estudiantes{get;set;}

        public void OnGet()
        {

            //Estudiantes=_repositorioEstudiante.GetAllEstudiante();
           Estudiantes= _repositorioEstudiante.GetTodosEstudiantes();
        }
    }
}
