using System.Collections.Generic;
using System;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public interface IRepositorioProtocolo 
    {
        IEnumerable<Protocolo> GetAllProtocolo();
        Protocolo AddProtocolo (Protocolo protocolo);
        Protocolo UpdateProtocolo (Protocolo protocolo);
        Boolean DeleteProtocolo(int idProtocolo);
        Protocolo GetProtocolo(int idProtocolo);

    }
}
