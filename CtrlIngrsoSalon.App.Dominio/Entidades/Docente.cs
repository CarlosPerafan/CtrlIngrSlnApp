using System;

namespace CtrlIngrsoSalon.App.Dominio
{
    public class Docente
    {
        public int id { set; get; }

        public Persona persona { set; get; }

        public string departamento { set; get; }

        public string materia { set; get; }
    }
}
