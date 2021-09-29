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

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes;
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetTodosEstudiantes()
        {
            System.Collections.Generic.List<Estudiante> Lista = new List<Estudiante>();
            var infoq = (from es in _appContext.Estudiantes 
                          join pe in  _appContext.Personas
                           on es.persona.id equals pe.id
                          // where pe.id == es.
                           select new {ES = es,PE = pe } 
            );
              foreach (var item in infoq)
              {
                  var per = item.PE;
                  var est = item.ES;
                  var persona = new Persona
                  {

                      id        = per.id,
                      nombre    = per.nombre,
                      apellidos = per.apellidos,
                      fechaNacimiento = per.fechaNacimiento,
                      telefono  = per.telefono,
                      correo    = per.correo
                  };
                  var estudiante = new Estudiante
                  {
                      id = est.id,
                      persona = persona,
                      carrera = est.carrera,
                      semestre= est.semestre
                  };

                    Lista.Add(estudiante);

              }

               IEnumerable<Estudiante> enumerable = Lista.AsEnumerable();
            return enumerable;
        }

        Estudiante IRepositorioEstudiante.AddEstudiante (Estudiante estudiante)
        {
            var estudianteadicionada = _appContext.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteadicionada.Entity;

        }

        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            //var estudiantencontrado= _appContext.Estudiantes.FirstOrDefault(p => p.id==estudiante.id);
            var estudiantencontrado= _appContext.Estudiantes.SingleOrDefault(p => p.id==estudiante.id);            
            if (estudiantencontrado!= null)
            {   
                estudiantencontrado.persona.id          = estudiante.persona.id;
                estudiantencontrado.persona.nombre      = estudiante.persona.nombre;
                estudiantencontrado.persona.apellidos   = estudiante.persona.apellidos;
                estudiantencontrado.persona.fechaNacimiento = estudiante.persona.fechaNacimiento;
                estudiantencontrado.persona.telefono    = estudiante.persona.telefono;
                estudiantencontrado.persona.correo      = estudiante.persona.correo;
                estudiantencontrado.carrera = estudiante.carrera;
                estudiantencontrado.semestre = estudiante.semestre;
                _appContext.SaveChanges();                
            }else{Console.WriteLine("Algo ocurrio y no se ejecuto la actualizacion");}
            return estudiantencontrado;
        }
        Boolean IRepositorioEstudiante.DeleteEstudiante(int idEstudiante, int idPersona)
        {
           /* var estudiantencontrada= _appContext.Estudiantes.FirstOrDefault(p => p.id==idEstudiante);
            if (estudiantencontrada== null)
                return false;
                // Se saldria y no ejecutaria la linea siguiente
            _appContext.Remove(estudiantencontrada);   
            _appContext.SaveChanges();
            return true;     
*/
            var  estudiantencontrada= _appContext.Estudiantes.FirstOrDefault(p => p.id==idEstudiante);
            var personaencontrada = _appContext.Personas.FirstOrDefault(p => p.id == idPersona);

            if (estudiantencontrada == null && personaencontrada == null)  //docentencontrada
                return false;
            // Se saldria y no ejecutaria la linea siguiente
            _appContext.Remove(estudiantencontrada);  //docentencontrada
            _appContext.Remove(personaencontrada);
            _appContext.SaveChanges();
            return true;




        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int idEstudiante)
        {
           //return _appContext.Estudiantes.FirstOrDefault(p => p.persona.id==idEstudiante);

            Estudiante alumno = new Estudiante();   
             var infoq = (from pe in _appContext.Personas 
                          join es in  _appContext.Estudiantes
                           on pe.id equals es.persona.id
                            where pe.id == idEstudiante
                           select new {ES = es,PE = pe } 
                        );
            foreach (var item in infoq)
              {
                  var per = item.PE;
                  var est = item.ES;
                  var persona = new Persona
                  {

                      id        = per.id,
                      nombre    = per.nombre,
                      apellidos = per.apellidos,
                      fechaNacimiento = per.fechaNacimiento,
                      telefono  = per.telefono,
                      correo    = per.correo
                  };
                  var estudiante = new Estudiante
                  {
                      id = est.id,
                      persona = persona,
                      carrera = est.carrera,
                      semestre= est.semestre
                  };
                  alumno = estudiante;
              }    

         return alumno;
                
        }



}
}
