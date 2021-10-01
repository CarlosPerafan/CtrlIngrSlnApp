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
    public class HorarioModel : PageModel
    {
        private static IRepositorioHorario _repositorioHorario = new RepositorioHorario(new Persistencia.AppContext());
        public IEnumerable<Horario> Horarios{get;set;}

        public void OnGet()
        {

           Horarios=_repositorioHorario.GetAllHorario();
           //Horarios= _repositorioHorario.GetTodosHorarios();
        }
    }
}
