using System;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======

>>>>>>> 4760a6a1cbbbb163e03a3dbae578781f73168d22
namespace CtrlIngrsoSalon.App.Dominio
{
    public class Persona
    {
        public int id { set; get; }

        public string nombre { set; get; }

        public string apellidos { set; get; }

        public string fechaNacimiento { set; get; }

<<<<<<< HEAD
        public int id {set;get;}
        [Required, StringLength(30)]
        public string nombre {set;get;}
        [Required, StringLength(50)]
        public string apellidos {set;get;}
        [Required, StringLength(10)]
        public string fechaNacimiento {set;get;}
        [Required, StringLength(15)]
        public string telefono {set;get;}
        public string correo {set;get;}
        public Estado estadoCovid {set;get;}
=======
        public string telefono { set; get; }
>>>>>>> 4760a6a1cbbbb163e03a3dbae578781f73168d22

        public string correo { set; get; }

        public Estado estadoCovid { set; get; }
    }
}
