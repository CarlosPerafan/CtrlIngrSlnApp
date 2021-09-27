using System;

namespace CtrlIngrsoSalon.App.Dominio
{
    public class PersonaSede
    {
        public int id { set; get; }

        public Persona persona { set; get; }

        public Sede sede { set; get; }
    }
}
