using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CtrlIngrsoSalon.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Preguntas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pregunta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    respuestaEsperada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preguntas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Universidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoCovidid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_Estados_estadoCovidid",
                        column: x => x.estadoCovidid,
                        principalTable: "Estados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    universidadid = table.Column<int>(type: "int", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nroSalones = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sedes_Universidades_universidadid",
                        column: x => x.universidadid,
                        principalTable: "Universidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aseadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    turno = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aseadores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Aseadores_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Directivos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    unidadDesempenia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directivos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Directivos_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Docentes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    departamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    materia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Docentes_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    carrera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    semestre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaSedes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    sedeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaSedes", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonaSedes_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaSedes_Sedes_sedeid",
                        column: x => x.sedeid,
                        principalTable: "Sedes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Protocolos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sedeid = table.Column<int>(type: "int", nullable: true),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    tomaMuestra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    diagnosticoid = table.Column<int>(type: "int", nullable: true),
                    temperatura = table.Column<double>(type: "float", nullable: false),
                    periodoAislamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protocolos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Protocolos_Estados_diagnosticoid",
                        column: x => x.diagnosticoid,
                        principalTable: "Estados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Protocolos_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Protocolos_Sedes_sedeid",
                        column: x => x.sedeid,
                        principalTable: "Sedes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sedeid = table.Column<int>(type: "int", nullable: true),
                    aforo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Salones_Sedes_sedeid",
                        column: x => x.sedeid,
                        principalTable: "Sedes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Encuestas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    protocoloid = table.Column<int>(type: "int", nullable: true),
                    preguntaid = table.Column<int>(type: "int", nullable: true),
                    respuesta = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuestas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Encuestas_Preguntas_preguntaid",
                        column: x => x.preguntaid,
                        principalTable: "Preguntas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Encuestas_Protocolos_protocoloid",
                        column: x => x.protocoloid,
                        principalTable: "Protocolos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salonid = table.Column<int>(type: "int", nullable: true),
                    codSemestre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    horaInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    horaFinal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codAsignatura = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Horarios_Salones_salonid",
                        column: x => x.salonid,
                        principalTable: "Salones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaHorarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    horarioid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaHorarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonaHorarios_Horarios_horarioid",
                        column: x => x.horarioid,
                        principalTable: "Horarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaHorarios_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aseadores_personaid",
                table: "Aseadores",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Directivos_personaid",
                table: "Directivos",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Docentes_personaid",
                table: "Docentes",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Encuestas_preguntaid",
                table: "Encuestas",
                column: "preguntaid");

            migrationBuilder.CreateIndex(
                name: "IX_Encuestas_protocoloid",
                table: "Encuestas",
                column: "protocoloid");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_personaid",
                table: "Estudiantes",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_salonid",
                table: "Horarios",
                column: "salonid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaHorarios_horarioid",
                table: "PersonaHorarios",
                column: "horarioid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaHorarios_personaid",
                table: "PersonaHorarios",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_estadoCovidid",
                table: "Personas",
                column: "estadoCovidid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaSedes_personaid",
                table: "PersonaSedes",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaSedes_sedeid",
                table: "PersonaSedes",
                column: "sedeid");

            migrationBuilder.CreateIndex(
                name: "IX_Protocolos_diagnosticoid",
                table: "Protocolos",
                column: "diagnosticoid");

            migrationBuilder.CreateIndex(
                name: "IX_Protocolos_personaid",
                table: "Protocolos",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Protocolos_sedeid",
                table: "Protocolos",
                column: "sedeid");

            migrationBuilder.CreateIndex(
                name: "IX_Salones_sedeid",
                table: "Salones",
                column: "sedeid");

            migrationBuilder.CreateIndex(
                name: "IX_Sedes_universidadid",
                table: "Sedes",
                column: "universidadid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aseadores");

            migrationBuilder.DropTable(
                name: "Directivos");

            migrationBuilder.DropTable(
                name: "Docentes");

            migrationBuilder.DropTable(
                name: "Encuestas");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "PersonaHorarios");

            migrationBuilder.DropTable(
                name: "PersonaSedes");

            migrationBuilder.DropTable(
                name: "Preguntas");

            migrationBuilder.DropTable(
                name: "Protocolos");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Salones");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Sedes");

            migrationBuilder.DropTable(
                name: "Universidades");
        }
    }
}
