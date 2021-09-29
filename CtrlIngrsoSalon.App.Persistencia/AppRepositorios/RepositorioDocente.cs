using System.Collections.Generic;
using System;
using System.Linq;
using CtrlIngrsoSalon.App.Dominio;
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



        IEnumerable<Docente> IRepositorioDocente.GetTodosDocentes()
        {
            System.Collections.Generic.List<Docente> Lista = new List<Docente>();
            var infoq = (from d in _appContext.Docentes
                         join pe in _appContext.Personas
                          on d.persona.id equals pe.id
                         // where pe.id == es.
                         select new { D = d, PE = pe }
            );

            if (infoq == null) { Console.WriteLine("No devolvio nada"); }
            foreach (var item in infoq)
            {
                var per = item.PE;
                var doc = item.D;
                var persona = new Persona
                {

                    id = per.id,
                    nombre = per.nombre,
                    apellidos = per.apellidos,
                    fechaNacimiento = per.fechaNacimiento,
                    telefono = per.telefono,
                    correo = per.correo
                };
                var docente = new Docente
                {
                    id = doc.id,
                    persona = persona,
                    departamento = doc.departamento,
                    materia = doc.materia
                };

                Lista.Add(docente);

            }

            IEnumerable<Docente> enumerable = Lista.AsEnumerable();
            return enumerable;
        }

        Docente IRepositorioDocente.AddDocente(Docente docente)
        {
            var docenteadicionada = _appContext.Add(docente);
            _appContext.SaveChanges();
            return docenteadicionada.Entity;

        }
        Docente IRepositorioDocente.UpdateDocente(Docente docente)
        {
            var docentencontrado = _appContext.Docentes.SingleOrDefault(p => p.id == docente.id);
            if (docentencontrado != null)
            {
                docentencontrado.persona.id = docente.persona.id;
                docentencontrado.persona.nombre = docente.persona.nombre;

                docentencontrado.persona.apellidos = docente.persona.apellidos;
                docentencontrado.persona.fechaNacimiento = docente.persona.fechaNacimiento;
                docentencontrado.persona.telefono = docente.persona.telefono;
                docentencontrado.persona.correo = docente.persona.correo;

                docentencontrado.departamento = docente.departamento;
                docentencontrado.materia = docente.materia;
                _appContext.SaveChanges();
            }
            return docentencontrado;
        }

        Boolean IRepositorioDocente.DeleteDocente(int idDocente, int idPersona)
        {
            var docentencontrada = _appContext.Docentes.FirstOrDefault(p => p.id == idDocente);
            var personaencontrada = _appContext.Personas.FirstOrDefault(p => p.id == idPersona);

            if (docentencontrada == null && personaencontrada == null)  //docentencontrada
                return false;
            // Se saldria y no ejecutaria la linea siguiente
            _appContext.Remove(docentencontrada);  //docentencontrada
            _appContext.Remove(personaencontrada);
            _appContext.SaveChanges();
            return true;

        }

        Docente IRepositorioDocente.GetDocente(int idDocente)
        {
            Docente profesor = new Docente();
            var infoq = (from pe in _appContext.Personas
                         join d in _appContext.Docentes
                          on pe.id equals d.persona.id
                         where pe.id == idDocente
                         select new { D = d, PE = pe }
                       );
            foreach (var item in infoq)
            {
                var per = item.PE;
                var doc = item.D;
                var persona = new Persona
                {

                    id = per.id,
                    nombre = per.nombre,
                    apellidos = per.apellidos,
                    fechaNacimiento = per.fechaNacimiento,
                    telefono = per.telefono,
                    correo = per.correo
                };
                var docente = new Docente
                {
                    id = doc.id,
                    persona = persona,
                    departamento = doc.departamento,
                    materia = doc.materia
                };
                profesor = docente;
            }

            return profesor;

        }

    }
}
