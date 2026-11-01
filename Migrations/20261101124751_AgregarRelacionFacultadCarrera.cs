using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionFacultadesCarreras.Migrations
{
    /// <inheritdoc />
    public partial class AgregarRelacionFacultadCarrera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrera_Facultad_FacultadId",
                table: "Carrera");

            migrationBuilder.AlterColumn<int>(
                name: "FacultadId",
                table: "Carrera",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carrera_Facultad_FacultadId",
                table: "Carrera",
                column: "FacultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrera_Facultad_FacultadId",
                table: "Carrera");

            migrationBuilder.AlterColumn<int>(
                name: "FacultadId",
                table: "Carrera",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrera_Facultad_FacultadId",
                table: "Carrera",
                column: "FacultadId",
                principalTable: "Facultad",
                principalColumn: "Id");
        }
    }
}
