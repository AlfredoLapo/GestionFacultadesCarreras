using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionFacultadesCarreras.Migrations
{
    /// <inheritdoc />
    public partial class AgregarFacultad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacultadId",
                table: "Carrera",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Facultad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono_Contacto = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultad", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carrera_FacultadId",
                table: "Carrera",
                column: "FacultadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrera_Facultad_FacultadId",
                table: "Carrera",
                column: "FacultadId",
                principalTable: "Facultad",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrera_Facultad_FacultadId",
                table: "Carrera");

            migrationBuilder.DropTable(
                name: "Facultad");

            migrationBuilder.DropIndex(
                name: "IX_Carrera_FacultadId",
                table: "Carrera");

            migrationBuilder.DropColumn(
                name: "FacultadId",
                table: "Carrera");
        }
    }
}
