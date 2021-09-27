using System;

namespace CtrlIngrsoSalon.App.Dominio
{
    public class Persona
    {
        public int id { set; get; }

        public string nombre { set; get; }

        public string apellidos { set; get; }

        public string fechaNacimiento { set; get; }

        public string telefono { set; get; }

        public string correo { set; get; }

        public Estado estadoCovid { set; get; }
    }
}
