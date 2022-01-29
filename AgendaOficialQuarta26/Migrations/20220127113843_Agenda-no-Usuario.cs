using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaOficialQuarta26.Migrations
{
    public partial class AgendanoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AgendaId",
                table: "Usuario",
                column: "AgendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Agenda_AgendaId",
                table: "Usuario",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Agenda_AgendaId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_AgendaId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Usuario");
        }
    }
}
