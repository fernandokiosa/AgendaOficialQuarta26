using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaOficialQuarta26.Migrations
{
    public partial class AgendaIdPermiteNullu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Agenda_AgendaId",
                table: "Evento");

            migrationBuilder.AlterColumn<int>(
                name: "AgendaId",
                table: "Evento",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Agenda_AgendaId",
                table: "Evento",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Agenda_AgendaId",
                table: "Evento");

            migrationBuilder.AlterColumn<int>(
                name: "AgendaId",
                table: "Evento",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Agenda_AgendaId",
                table: "Evento",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id");
        }
    }
}
