using System.Collections.Generic;
using System;
using System.Linq;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public class RepositorioEstado : IRepositorioEstado
    {
        //Referencia al Contexto del Estado
        private readonly AppContext _appContext;

        public RepositorioEstado(AppContext appContext)
        {
             _appContext = appContext;
        }


        IEnumerable<Estado> IRepositorioEstado.GetAllEstado()
        {
            return _appContext.Estados;
        }

        Estado IRepositorioEstado.AddEstado (Estado estado)
        {
            var estadoadicionado = _appContext.Add(estado);
            _appContext.SaveChanges();
            return estadoadicionado.Entity;

        }
        Estado IRepositorioEstado.UpdateEstado(Estado estado)
        {
            var estadoencontrado= _appContext.Estados.FirstOrDefault(p => p.id==estado.id);
            if (estadoencontrado!= null)
            {   
                estadoencontrado.nombre= estado.nombre;
                _appContext.SaveChanges();                
            }
            return estadoencontrado;
        }

        Boolean IRepositorioEstado.DeleteEstado(int idEstado)
        {
            var estadoencontrado= _appContext.Estados.FirstOrDefault(p => p.id==idEstado);
            if (estadoencontrado== null)
                return false;
                // Se saldria y no ejecutaria la linea siguiente
            _appContext.Remove(estadoencontrado);   
            _appContext.SaveChanges();
            return true;            

        }

        Estado IRepositorioEstado.GetEstado(int idEstado)
        {
            return _appContext.Estados.FirstOrDefault(p => p.id==idEstado);
        }
    }
}
