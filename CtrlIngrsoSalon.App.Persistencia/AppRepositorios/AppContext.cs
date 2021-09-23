using Microsoft.EntityFrameworkCore;
using CtrlIngrsoSalon.App.Dominio;


namespace CtrlIngrsoSalon.App.Persistencia
{
    public class AppContext : DbContext 
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Directivo> Directivos {get; set;}
        public DbSet<Estudiante> Estudiantes {get; set;}
        public DbSet<Docente> Docentes {get; set;}
        public DbSet<PersonalAseo> Aseadores {get; set;}
        public DbSet<Universidad> Universidades {get; set;}  
        public DbSet<Sede> Sedes {get; set;}
        public DbSet<Salon> Salones {get; set;} 
        public DbSet<Horario> Horarios {get; set;}              
        public DbSet<Protocolo> Protocolos {get; set;}  
        public DbSet<Pregunta> Preguntas {get; set;}      
        public DbSet<Encuesta> Encuestas {get; set;}               
        public DbSet<Estado> Estados {get; set;}
        public DbSet<PersonaHorario> PersonaHorarios {get; set;}
        public DbSet<PersonaSede> PersonaSedes {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = CtrlIngSlnAppData");
                    
                }
        }
    }
}