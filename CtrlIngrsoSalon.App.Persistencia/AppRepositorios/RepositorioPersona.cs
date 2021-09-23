using System.Collections.Generic;
using System;
using System.Linq;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public class RepositorioPersona : IRepositorioPersona 
    {
        //Referencia al Contexto del Persona
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }


        IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
        {
            return _appContext.Personas;
        }
        
        Persona IRepositorioPersona.AddPersona (Persona persona)
        {
            var personadicionada = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personadicionada.Entity;

        }
       Persona IRepositorioPersona.UpdatePersona (Persona persona)
        {
            var personaencontrada= _appContext.Personas.FirstOrDefault(p => p.id==persona.id);
            if (personaencontrada!= null)
            {
                personaencontrada.nombre= persona.nombre;
                personaencontrada.apellidos= persona.apellidos;
                personaencontrada.telefono = persona.telefono;
                personaencontrada.fechaNacimiento = persona.fechaNacimiento;
                personaencontrada.correo = persona.correo;
                personaencontrada.estadoCovid = persona.estadoCovid;
                _appContext.SaveChanges();                
            }
            return personaencontrada;
        }
         Boolean IRepositorioPersona.DeletePersona(int idPersona)
        {
            var personaencontrada= _appContext.Personas.FirstOrDefault(p => p.id==idPersona);
            if (personaencontrada== null)
                return false;
                // Se saldria y no ejecutaria la linea siguiente
            _appContext.Personas.Remove(personaencontrada);   
            _appContext.SaveChanges();
            return true;            

        }
        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.id==idPersona);
        }

    }
}
