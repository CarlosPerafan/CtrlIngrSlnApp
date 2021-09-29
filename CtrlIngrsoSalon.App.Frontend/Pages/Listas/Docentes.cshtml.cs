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
    public class DocentesModel : PageModel
    {
        private static IRepositorioDocente _repositorioDocente = new RepositorioDocente(new Persistencia.AppContext());
        public IEnumerable<Docente> Docentes{get;set;}

        public void OnGet()
        {

            //Estudiantes=_repositorioEstudiante.GetAllEstudiante();
           Docentes= _repositorioDocente.GetTodosDocentes();
        }
    }
}
