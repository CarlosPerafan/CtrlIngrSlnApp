using System;
using System.Collections.Generic;
using System.Linq;
using CtrlIngrsoSalon.App.Dominio;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public class RepositorioProtocolo : IRepositorioProtocolo
    {
        //Referencia al Contexto del Docente
        private readonly AppContext _appContext;

        public RepositorioProtocolo(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Protocolo> IRepositorioProtocolo.GetAllProtocolos()
        {
            return _appContext.Protocolos;
        }

        Protocolo IRepositorioProtocolo.AddProtocolo(Protocolo Protocolo)
        {
            return null;
        }

        Protocolo IRepositorioProtocolo.UpdateProtocolo(Protocolo Protocolo)
        {
            return null;
        }

        Boolean IRepositorioProtocolo.DeleteProtocolo(int idProtocolo)
        {
            return true;
        }

        Protocolo IRepositorioProtocolo.GetProtocolo(int idProtocolo)
        {
            return null;
        }
    }
}
