using System;
namespace CtrlIngrsoSalon.App.Dominio
{
    public class Encuesta
    {
        public int id {set;get;}
        public Protocolo protocolo {set;get;}
        public Pregunta pregunta {set;get;}
	    public Boolean respuesta {set;get;}
    }
}