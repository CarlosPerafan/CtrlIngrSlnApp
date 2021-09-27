using System;

namespace CtrlIngrsoSalon.App.Dominio
{
    public class PersonalAseo
    {
        public int id { set; get; }

        public Persona persona { set; get; }

        public string turno { set; get; } // definido como: mañana | tarde
    }
}
