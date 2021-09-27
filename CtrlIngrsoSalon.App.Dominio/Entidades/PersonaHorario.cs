using System;

namespace CtrlIngrsoSalon.App.Dominio
{
    public class PersonaHorario
    {
        public int id { set; get; }

        public Persona persona { set; get; }

        public Horario horario { set; get; }
    }
}
