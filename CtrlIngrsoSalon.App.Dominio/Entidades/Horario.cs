using System;
namespace CtrlIngrsoSalon.App.Dominio
{
    public class Horario
    {
        public int id {set;get;}
        public Salon salon {set;get;}
        public string codSemestre {set;get;}
        public string dia {set;get;}
        public string horaInicio {set;get;}
        public string horaFinal {set;get;}
        public string codAsignatura {set;get;}
    }

}