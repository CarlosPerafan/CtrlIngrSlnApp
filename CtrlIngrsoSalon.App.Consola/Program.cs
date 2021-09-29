using System;
using System.Linq;
using CtrlIngrsoSalon.App.Dominio;
using CtrlIngrsoSalon.App.Persistencia;

namespace CtrlIngrsoSalon.App.Consola
{
    class Program
    {
        private static IRepositorioEstado _repositorioEstado = new RepositorioEstado(new Persistencia.AppContext());
        private static IRepositorioPersona _repositorioPersona = new RepositorioPersona(new Persistencia.AppContext());
        private static IRepositorioDocente _repositorioDocente = new RepositorioDocente(new Persistencia.AppContext());
        private static IRepositorioEstudiante _repositorioEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());    

       
        static void Main(string[] args)
        {



            Console.WriteLine("CRUD usando Entity Framework de .NET !!");
            Console.WriteLine("--------APLICACION CONTROL INGRESO SALONES------");


        /*---------------ENTIDAD DOCENTE-----------------*/
            //AddDocente();
           //BuscarDocente(9);  
           //EditarDocente(11);
           //BorrarDocente(4);
        /*--------------ENTIDAD ESTUDIANTE----------------*

           //AddEstudiante();
           //BuscarEstudiante(13);
           //EditarEstudiante(10);
           //BorrarEstudiante(8);
        /*--------------ENTIDAD ESTADO----------------*/
            //AddEstado();
            //BorrarEstado(1);
           
/*
 var query = _repositorioEstudiante.GetAllEstudiante();

var consulta = (from p in _repositorioPersona.GetAllPersona()
                 //join e in _repositorioEstudiante.GetAllEstudiante()
                  //on p.id equals e.persona.id
                   //   where p.id == 12
                       select new {P = p} 
 );



        foreach (var item in consulta)
        {
            var p = item.P;
            var e =  _repositorioEstudiante.GetEstudiante(p.id);
           if (e!= null)
           {
            Console.WriteLine("Sera que si funciono? "+ p.nombre+" id: "+p.id + "carrera : "+e.carrera);
           }else{
           Console.WriteLine("Sera que si funciono? "+ p.nombre+" id: "+p.id);      
           }      
        }
*/

//Buscar();
EditarEstudiante(12);
        }


       /* -----  Metodos ADICIONAR ------- */

        private static void AddPersona()
        {
            Estado estado = new Estado();     //Consultarlo


            var persona = new Persona
            {
                nombre          = "Retorico",
                apellidos       = "Preciso Dado",
                fechaNacimiento = "1939-07-03",
                telefono        = "320045503",                
                correo          = "retorico@yahoo.com",
                estadoCovid     = estado
            };
           var creado = _repositorioPersona.AddPersona(persona);
           if (creado != null)
           {
               Console.WriteLine("Persona: "+persona.nombre + "  "+ persona.apellidos + " creada correctamente "); 
           }else{
                Console.WriteLine("Ocurrio un error en al creacion !!! ");
           }
        }


        private static void AddDocente()
        {
            //Estado estado = new Estado();
            //estado.nombre= "Positivo";
            var profesor = new Persona
            {
                nombre          = "Evaluador",
                apellidos       = "Sprinte",
                fechaNacimiento = "1967-03-05",
                telefono        = "3218129876",                
                correo          = "escudeto@yahoo.com",
                //estadoCovid     = estado
            };
            var docente = new Docente
            {
                persona = profesor,
                departamento ="Artes",
                materia = "Dramaturrgia"

            };

           var creado = _repositorioDocente.AddDocente(docente);
           if (creado != null)
           {
               Console.WriteLine("Persona: "+profesor.nombre + "  "+ profesor.apellidos + " creada correctamente "); 
           }else{
                Console.WriteLine("Ocurrio un error en al creacion !!! ");
           }
        }

        private static void AddEstudiante()
        {
            //Estado estado = new Estado();
            //estado.nombre= "Positivo";
            var persona = new Persona
            {
                nombre          = "Letanio",
                apellidos       = "Sosa Tolosa",
                fechaNacimiento = "1937-04-05",
                telefono        = "3223456789",                
                correo          = "letanio@hotmail.com",
                //estadoCovid     = estado
            };
            var alumno = new Estudiante
            {
                persona = persona,
                carrera ="Sanitaria",
                semestre = 2

            };

           var creado = _repositorioEstudiante.AddEstudiante(alumno);
           if (creado != null)
           {
               Console.WriteLine("Persona: "+persona.nombre + "  "+ persona.apellidos + " creada correctamente "); 
           }else{
                Console.WriteLine("Ocurrio un error en al creacion !!! ");
           }
            
        }        

        private static void AddEstado()
        {
            var estado = new Estado
            {
                nombre          = "Negativo",
            };
            _repositorioEstado.AddEstado(estado);
        }



       /* -----  Funcion BUSCAR ------- */
        private static void BuscarPersona(int idPersona)
        {
            var personabuscada = _repositorioPersona.GetPersona(idPersona);
            Console.WriteLine("Persona filtarada: "+personabuscada.nombre + "  "+ personabuscada.apellidos);
        }

        private static void BuscarDocente(int idDocente)
        {
            var persona = _repositorioPersona.GetPersona(idDocente);
            var docentebuscado = _repositorioDocente.GetDocente(idDocente);
            Console.WriteLine("Persona filtrada: "+ persona.nombre+ "  "+persona.apellidos+ "  "+docentebuscado.departamento + "  "+ docentebuscado.materia);
        }

        private static void BuscarEstudiante(int idEstudiante)
        {
            var persona = _repositorioPersona.GetPersona(idEstudiante);
            var estudiantebuscado = _repositorioEstudiante.GetEstudiante(idEstudiante);
            Console.WriteLine("Estudiante filtrada: "+ persona.nombre+ "  "+persona.apellidos+ "  "+estudiantebuscado.carrera + "  "+ estudiantebuscado.semestre);
        }


       /* -----  Funcion ACTUALIZAR------ */
        private static void EditarPersona(int idPersona)
        {

            var personabuscada = _repositorioPersona.GetPersona(idPersona);
            if (personabuscada != null)
            {
                var persona = new Persona
                {
                    id              = idPersona,
                    nombre          = "Elvis",
                    apellidos       = "Campo",
                    fechaNacimiento = "1997-05-30",
                    telefono        = "3229870000",
                    correo          = "Elvis@hotmail.com",
                    //estadoCovid     = estado
                };

                Persona personactualizado = _repositorioPersona.UpdatePersona(persona);

                if (personactualizado != null)
                    Console.WriteLine("Persona con Id : "+ personactualizado.id + "  actualizado exitosamente !");
            }
            else 
            {
               Console.WriteLine("Persona con Id : "+ idPersona + " no fue actualizada contacte al administrador de BD!!"); 
            }

        }  
//Ojo
        private static void EditarDocente(int idDocente)
        {
            var personabuscada = _repositorioPersona.GetPersona(idDocente);
            if (personabuscada != null)
            {

                var persona = new Persona
                {
                    id              = idDocente,
                    nombre          = "Rigoberto",
                    apellidos       = "Quintana",
                    fechaNacimiento = "1977-05-30",
                    telefono        = "3119870000",
                    correo          = "rigoqui@yahoo.com",
                    //estadoCovid     = estado
                };

                Persona personactualizado = _repositorioPersona.UpdatePersona(persona);

                if (personactualizado != null)
                {   
                    //var docentebuscado = _repositorioDocente.GetDocente(idDocente);
                    Docente docentebuscado = _repositorioDocente.GetDocente(idDocente);
                    if (docentebuscado != null)
                     {
                       var profesor = new Docente
                       {
                          id           = docentebuscado.id,
                          departamento = "Matematicas",
                          materia      = "Matematica Pura"
                       };
                       Docente docenteactualizado =  _repositorioDocente.UpdateDocente(profesor);
                       if (docenteactualizado != null)
                          Console.WriteLine("Docente con Id : "+ personactualizado.id + "  actualizado exitosamente !");     
                    } 
                }else 
                {
                    Console.WriteLine("Persona con Id : "+ idDocente + " no fue actualizada contacte al administrador de BD!!"); 
                }
                    //Console.WriteLine("Persona con Id : "+ personactualizado.id + "  actualizado exitosamente !");

            }
            else 
            {
               Console.WriteLine("Persona con Id : "+ idDocente + " no fue actualizada contacte al administrador de BD!!"); 
            }

        }  

        private static void EditarEstudiante(int idEstudiante)
        {
            var personabuscada = _repositorioPersona.GetPersona(idEstudiante);
            if (personabuscada != null)
            {

                var persona = new Persona
                {
                    id              = idEstudiante,
                    nombre          = "Yuberjen Joselo",
                    apellidos       = "Samaniego Fresno",
                    fechaNacimiento = "1957-05-15",
                    telefono        = "3173456789",                
                    correo          = "yubersa@hotmail.com",
                    //estadoCovid     = estado
                };

                Persona personactualizado = _repositorioPersona.UpdatePersona(persona);

                if (personactualizado != null)
                {   
                    //var docentebuscado = _repositorioDocente.GetDocente(idDocente);
                    Estudiante estudiantebuscado = _repositorioEstudiante.GetEstudiante(idEstudiante);
                    if (estudiantebuscado != null)
                     {
                       var alumno = new Estudiante
                       {
                          id      = estudiantebuscado.id,
                          carrera = "Deportes",
                          semestre= 10
                       };
                       Estudiante estudianteactualizado =  _repositorioEstudiante.UpdateEstudiante(alumno);
                       if (estudianteactualizado != null)
                          Console.WriteLine("Estudiante con Id : "+ personactualizado.id + "  actualizado exitosamente !");     
                    } 
                }else 
                {
                    Console.WriteLine("Persona con Id : "+ idEstudiante + " no fue actualizada contacte al administrador de BD!!"); 
                }
                    //Console.WriteLine("Persona con Id : "+ personactualizado.id + "  actualizado exitosamente !");

            }
            else 
            {
               Console.WriteLine("Persona con Id : "+ idEstudiante + " no fue actualizada contacte al administrador de BD!!"); 
            }

        } 

       /* -----  Funcion BORRAR------- */
        private static void BorrarEstado(int idEstado)
        {
            Boolean estadoborrar = _repositorioEstado.DeleteEstado(idEstado);
            Console.WriteLine("Valor de la variable Booleana es: " + estadoborrar);
            if (estadoborrar)
            {
                Console.WriteLine("Estado  Eliminado");
            }
            else
            {
                Console.WriteLine("Estado no existe o hubo inconvenientes en el proceso");
            }
        }


        private static void BorrarPersona(int idPersona)
        {
            Boolean personaborrar = _repositorioPersona.DeletePersona(idPersona);
            Console.WriteLine("Valor de la variable Booleana es: " + personaborrar);
            if (personaborrar)
            {
                Console.WriteLine("Persona  Eliminada");
            }
            else
            {
                Console.WriteLine("Persona no existe o hubo inconvenientes en el proceso");
            }
        }

        private static void BorrarDocente(int idDocente)
        {
            Docente docentebuscado = _repositorioDocente.GetDocente(idDocente);
            Boolean docenteborrar = _repositorioDocente.DeleteDocente(docentebuscado.id);

            Boolean personaborrar = _repositorioPersona.DeletePersona(idDocente);
            Console.WriteLine("Valor de la variable Booleana es: " + personaborrar);
            if (personaborrar && docenteborrar)
            {
                Console.WriteLine("Persona  Eliminada");
            }
            else
            {
                Console.WriteLine("Persona no existe o hubo inconvenientes en el proceso");
            }
        }

        private static void BorrarEstudiante(int idEstudiante)
        {
            Estudiante estudiantebuscado = _repositorioEstudiante.GetEstudiante(idEstudiante);
            Boolean estudianteborrar = _repositorioEstudiante.DeleteEstudiante(estudiantebuscado.id);

            Boolean personaborrar = _repositorioPersona.DeletePersona(idEstudiante);
            Console.WriteLine("Valor de la variable Booleana es: " + personaborrar);
            if (personaborrar && estudianteborrar)
            {
                Console.WriteLine("Persona  Eliminada");
            }
            else
            {
                Console.WriteLine("Persona no existe o hubo inconvenientes en el proceso");
            }
        }



        private static void Buscar()
        {
            var personabuscada = _repositorioEstudiante.GetTodosEstudiantes();
            Console.WriteLine("Persona filtarada: "+personabuscada);
        }


    }
}
