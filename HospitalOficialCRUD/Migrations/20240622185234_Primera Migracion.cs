using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalOficialCRUD.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RutPaciente = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NombrePaciente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ApellidoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DireccionPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    FonoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.IdPaciente);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
