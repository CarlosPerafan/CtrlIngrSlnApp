using System.Collections.Generic;
using System;
using System.Linq;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public class RepositorioPersonaHorario : IRepositorioPersonaHorario
    {

      //Referencia al Contexto de PersonaHorario
        private readonly AppContext _appContext;

        public RepositorioPersonaHorario(AppContext appContext)
        {
             _appContext = appContext;
        }


        IEnumerable<PersonaHorario> IRepositorioPersonaHorario.GetAllPersonaHorarios()
        {
            return _appContext.PersonaHorarios;
        }

        PersonaHorario IRepositorioPersonaHorario.AddPersonaHorario (PersonaHorario personaHorario)
        {
            var perhorarioadicionado = _appContext.Add(personaHorario);
            _appContext.SaveChanges();
            return perhorarioadicionado.Entity;

        }
        PersonaHorario IRepositorioPersonaHorario.UpdatePersonaHorario(PersonaHorario personaHorario)
        {
            var perhorarioadicionado= _appContext.PersonaHorarios.FirstOrDefault(p => p.id==personaHorario.id);
            if (perhorarioadicionado!= null)
            {   
                perhorarioadicionado.persona = personaHorario.persona;
                perhorarioadicionado.horario = personaHorario.horario;
                
                _appContext.SaveChanges();                
            }
            return perhorarioadicionado;
        }

        Boolean IRepositorioPersonaHorario.DeletePersonaHorario(int idPersonaHorario)
        {
            var perhorarioadicionado= _appContext.PersonaHorarios.FirstOrDefault(p => p.id== idPersonaHorario);
            if (perhorarioadicionado== null)
                return false;

                // Se saldria y no ejecutaria la linea siguiente
            _appContext.Remove(perhorarioadicionado);   
            _appContext.SaveChanges();
            return true;            

        }

        PersonaHorario IRepositorioPersonaHorario.GetPersonaHorario(int idPersonaHorario)
        {
           return _appContext.PersonaHorarios.FirstOrDefault(p => p.id==idPersonaHorario);
                
        }
        
    }

}