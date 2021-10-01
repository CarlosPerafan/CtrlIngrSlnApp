using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CtrlIngrsoSalon.App.Dominio;
using CtrlIngrsoSalon.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CtrlIngrsoSalon.App.Frontend.Pages
{
    public class ProtocoloCrudModel : PageModel { 
        private static IRepositorioProtocolo _repositorioProtocolo = new RepositorioProtocolo(new Persistencia.AppContext());
        [BindProperty]
        public Protocolo protocolo { get; set; }

    }
}
