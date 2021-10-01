using System.Collections.Generic;
using System;
using System.Linq;
using  CtrlIngrsoSalon.App.Dominio;
namespace CtrlIngrsoSalon.App.Persistencia
{

    public class RepositorioHorario : IRepositorioHorario
    {

      //Referencia al Contexto del Horario
        private readonly AppContext _appContext;

        public RepositorioHorario(AppContext appContext)
        {
             _appContext = appContext;
        }


        IEnumerable<Horario> IRepositorioHorario.GetAllHorario()
        {
            return _appContext.Horarios;
        }

        IEnumerable<Horario> IRepositorioHorario.GetTodosHorarios()
        {
            System.Collections.Generic.List<Horario> Lista = new List<Horario>();
            var infoq = (from ho in _appContext.Horarios 
                          join sa in  _appContext.Salones
                           on ho.salon.id equals sa.id
                          // where pe.id == es.
                           select new {HO = ho,SA = sa } 
            );
              foreach (var item in infoq)
              {
                  var sal = item.SA;
                  var hor = item.HO;
                  var salon = new Salon
                  {

                      id      = sal.id,
                      sede    = sal.sede,
                      aforo = sal.aforo,
                      
                  };
                  var horario = new Horario
                  {
                      id = hor.id,
                      salon = salon,
                      codSemestre = hor.codSemestre,
                      dia= hor.dia,
                      horaInicio = hor.horaInicio,
                      horaFinal = hor.horaFinal,
                      codAsignatura = hor.codAsignatura,
                  };

                    Lista.Add(horario);

              }

               IEnumerable<Horario> enumerable = Lista.AsEnumerable();
            return enumerable;
        }

        Horario IRepositorioHorario.AddHorario (Horario horario)
        {
            var horarioadicionado = _appContext.Add(horario);
            _appContext.SaveChanges();
            return horarioadicionado.Entity;

        }
        Horario IRepositorioHorario.UpdateHorario(Horario horario)
        {
            var horarioadicionado= _appContext.Horarios.FirstOrDefault(h => h.id==horario.id);
            if (horarioadicionado!= null)
            {   
                horarioadicionado.codSemestre = horario.codSemestre;
                horarioadicionado.dia = horario.dia;
                horarioadicionado.horaInicio = horario.horaInicio;
                horarioadicionado.horaFinal = horario.horaFinal;
                horarioadicionado.codAsignatura = horario.codAsignatura;

                _appContext.SaveChanges();                
            }
            return horarioadicionado;
        }

        Boolean IRepositorioHorario.DeleteHorario(int idHorario)
        {
            var horarioadicionado= _appContext.Horarios.FirstOrDefault(h => h.id== idHorario);
            if (horarioadicionado== null)
                return false;
                // Se saldria y no ejecutaria la linea siguiente
            _appContext.Remove(horarioadicionado);   
            _appContext.SaveChanges();
            return true;            

        }

        Horario IRepositorioHorario.GetHorario(int idHorario)
        {
           return _appContext.Horarios.FirstOrDefault(h => h.id==idHorario);
                
        }
        
    }

}