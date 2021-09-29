using System;

namespace CtrlIngrsoSalon.App.Dominio
{
    public class Protocolo
    {
        public int id { set; get; }

        public Sede sede { set; get; }

        public Persona persona { set; get; }

        public DateTime tomaMuestra { set; get; }

        public Estado diagnostico { set; get; }

        public Double temperatura { set; get; }

        public string periodoAislamiento { set; get; }

        public string observaciones { set; get; }
    }
}
