using System.Collections.Generic;
using System;
using System.Linq;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public class RepositorioDocente : IRepositorioDocente
    {
        //Referencia al Contexto del Docente
        private readonly AppContext _appContext;

        public RepositorioDocente(AppContext appContext)
        {
             _appContext = appContext;
        }


        IEnumerable<Docente> IRepositorioDocente.GetAllDocente()
        {
            return _appContext.Docentes;
        }

        Docente IRepositorioDocente.AddDocente (Docente docente)
        {
            var docenteadicionada = _appContext.Add(docente);
            _appContext.SaveChanges();
            return docenteadicionada.Entity;

        }
        Docente IRepositorioDocente.UpdateDocente(Docente docente)
        {
            var docentencontrada= _appContext.Docentes.FirstOrDefault(p => p.id==docente.id);
            if (docentencontrada!= null)
            {   
                docentencontrada.departamento = docente.departamento;
                docentencontrada.materia = docente.materia;
                _appContext.SaveChanges();                
            }
            return docentencontrada;
        }

        Boolean IRepositorioDocente.DeleteDocente(int idDocente)
        {
            var docentencontrada= _appContext.Docentes.FirstOrDefault(p => p.id==idDocente);
            if (docentencontrada== null)
                return false;
                // Se saldria y no ejecutaria la linea siguiente
            _appContext.Remove(docentencontrada);   
            _appContext.SaveChanges();
            return true;            

        }

        Docente IRepositorioDocente.GetDocente(int idDocente)
        {
           return _appContext.Docentes.FirstOrDefault(p => p.persona.id==idDocente);
            /*   return  _appContext.Docentes.Join(_appContext.Personas,
                d=> d.persona.id, 
                p=> p.id,
                (d,p)=> new
                {
                    id = d.id,
                    persona = new
                    {
                        p.id,
                        p.nombre,
                        p.apellidos,
                        p.fechaNacimiento,
                        p.telefono,
                        p.correo,
                        p.estadoCovid
                    },
                    departamento = d.departamento,
                    materia = d.materia 
                }).Where(dp=> dp.persona.id== idDocente);
           */
                
        }
        
    }
}
