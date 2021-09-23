using System.Collections.Generic;
using System;
using System.Linq;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        //Referencia al Contexto del Estudiante
        private readonly AppContext _appContext;

        public RepositorioEstudiante(AppContext appContext)
        {
             _appContext = appContext;
        }


        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiante()
        {
            return _appContext.Estudiantes;
        }

        Estudiante IRepositorioEstudiante.AddEstudiante (Estudiante estudiante)
        {
            var estudianteadicionada = _appContext.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteadicionada.Entity;

        }
        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudiantencontrada= _appContext.Estudiantes.FirstOrDefault(p => p.id==estudiante.id);
            if (estudiantencontrada!= null)
            {   
                estudiantencontrada.carrera = estudiante.carrera;
                estudiantencontrada.semestre = estudiante.semestre;
                _appContext.SaveChanges();                
            }
            return estudiantencontrada;
        }

        Boolean IRepositorioEstudiante.DeleteEstudiante(int idEstudiante)
        {
            var estudiantencontrada= _appContext.Estudiantes.FirstOrDefault(p => p.id==idEstudiante);
            if (estudiantencontrada== null)
                return false;
                // Se saldria y no ejecutaria la linea siguiente
            _appContext.Remove(estudiantencontrada);   
            _appContext.SaveChanges();
            return true;            

        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int idEstudiante)
        {
           return _appContext.Estudiantes.FirstOrDefault(p => p.persona.id==idEstudiante);
                
        }
        
    }
}
