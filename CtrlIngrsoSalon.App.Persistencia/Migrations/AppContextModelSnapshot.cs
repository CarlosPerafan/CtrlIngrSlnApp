﻿// <auto-generated />
using System;
using CtrlIngrsoSalon.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CtrlIngrsoSalon.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Directivo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<string>("unidadDesempenia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.ToTable("Directivos");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Docente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("materia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.ToTable("Docentes");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Encuesta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("preguntaid")
                        .HasColumnType("int");

                    b.Property<int?>("protocoloid")
                        .HasColumnType("int");

                    b.Property<bool>("respuesta")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("preguntaid");

                    b.HasIndex("protocoloid");

                    b.ToTable("Encuestas");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Estado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Estudiante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("carrera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<int>("semestre")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Horario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("codAsignatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codSemestre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaFinal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("salonid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("salonid");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("estadoCovidid")
                        .HasColumnType("int");

                    b.Property<string>("fechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("estadoCovidid");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.PersonaHorario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("horarioid")
                        .HasColumnType("int");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("horarioid");

                    b.HasIndex("personaid");

                    b.ToTable("PersonaHorarios");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.PersonaSede", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<int?>("sedeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.HasIndex("sedeid");

                    b.ToTable("PersonaSedes");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.PersonalAseo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<string>("turno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.ToTable("Aseadores");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Pregunta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("pregunta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("respuestaEsperada")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Preguntas");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Protocolo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("diagnosticoid")
                        .HasColumnType("int");

                    b.Property<string>("observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("periodoAislamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<int?>("sedeid")
                        .HasColumnType("int");

                    b.Property<double>("temperatura")
                        .HasColumnType("float");

                    b.Property<DateTime>("tomaMuestra")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("diagnosticoid");

                    b.HasIndex("personaid");

                    b.HasIndex("sedeid");

                    b.ToTable("Protocolos");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Salon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("aforo")
                        .HasColumnType("int");

                    b.Property<int?>("sedeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("sedeid");

                    b.ToTable("Salones");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Sede", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nroSalones")
                        .HasColumnType("int");

                    b.Property<int?>("universidadid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("universidadid");

                    b.ToTable("Sedes");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Universidad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Universidades");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Directivo", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Docente", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Encuesta", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Pregunta", "pregunta")
                        .WithMany()
                        .HasForeignKey("preguntaid");

                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Protocolo", "protocolo")
                        .WithMany()
                        .HasForeignKey("protocoloid");

                    b.Navigation("pregunta");

                    b.Navigation("protocolo");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Estudiante", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Horario", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Salon", "salon")
                        .WithMany()
                        .HasForeignKey("salonid");

                    b.Navigation("salon");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Persona", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Estado", "estadoCovid")
                        .WithMany()
                        .HasForeignKey("estadoCovidid");

                    b.Navigation("estadoCovid");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.PersonaHorario", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Horario", "horario")
                        .WithMany()
                        .HasForeignKey("horarioid");

                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("horario");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.PersonaSede", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Sede", "sede")
                        .WithMany()
                        .HasForeignKey("sedeid");

                    b.Navigation("persona");

                    b.Navigation("sede");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.PersonalAseo", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Protocolo", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Estado", "diagnostico")
                        .WithMany()
                        .HasForeignKey("diagnosticoid");

                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Sede", "sede")
                        .WithMany()
                        .HasForeignKey("sedeid");

                    b.Navigation("diagnostico");

                    b.Navigation("persona");

                    b.Navigation("sede");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Salon", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Sede", "sede")
                        .WithMany()
                        .HasForeignKey("sedeid");

                    b.Navigation("sede");
                });

            modelBuilder.Entity("CtrlIngrsoSalon.App.Dominio.Sede", b =>
                {
                    b.HasOne("CtrlIngrsoSalon.App.Dominio.Universidad", "universidad")
                        .WithMany()
                        .HasForeignKey("universidadid");

                    b.Navigation("universidad");
                });
#pragma warning restore 612, 618
        }
    }
}
