using System.Collections.Generic;
<<<<<<< HEAD
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

=======
using CtrlIngrsoSalon.App.Dominio;

namespace CtrlIngrsoSalon.App.Persistencia
{
    public interface IRepositorioProtocolo
    {
        IEnumerable<Protocolo> GetAllProtocolos();

        Protocolo AddProtocolo(Protocolo Protocolo);

        Protocolo UpdateProtocolo(Protocolo Protocolo);

        Boolean DeleteProtocolo(int idProtocolo);

        Protocolo GetProtocolo(int idProtocolo);
>>>>>>> 4760a6a1cbbbb163e03a3dbae578781f73168d22
    }
}
