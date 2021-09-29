using System;
using System.ComponentModel.DataAnnotations;
namespace CtrlIngrsoSalon.App.Dominio
{
    public class Persona
    {

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


    }
}