using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaOficialQuarta26.Migrations
{
    public partial class AgendaEventos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Evento",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evento_AgendaId",
                table: "Evento",
                column: "AgendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Agenda_AgendaId",
                table: "Evento",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Agenda_AgendaId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_AgendaId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Evento");
        }
    }
}
