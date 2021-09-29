using System.Collections.Generic;
using CtrlIngrsoSalon.App.Dominio;
using System;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioProtocolo
    {
        IEnumerable<Protocolo> GetAllProtocolos();

        Protocolo AddProtocolo(Protocolo Protocolo);

        Protocolo UpdateProtocolo(Protocolo Protocolo);

        Boolean DeleteProtocolo(int idProtocolo);

        Protocolo GetProtocolo(int idProtocolo);
    }
}
