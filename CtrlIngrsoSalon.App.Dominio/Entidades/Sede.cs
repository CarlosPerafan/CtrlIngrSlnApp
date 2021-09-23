using System;
namespace CtrlIngrsoSalon.App.Dominio
{
    public class Sede
    {
        public int id {set;get;}
        public Universidad universidad {set;get;}
	    public string nombre {set;get;}
	    public string direccion{set;get;}
	    public string ciudad {set;get;}
        public int nroSalones {set;get;}
    }
}