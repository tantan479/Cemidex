using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cemidex.Migrations
{
    public partial class versao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertidaoObito",
                table: "Falecidos");

            migrationBuilder.DropColumn(
                name: "DataEnterro",
                table: "Falecidos");

            migrationBuilder.DropColumn(
                name: "RegistroObito",
                table: "Falecidos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CertidaoObito",
                table: "Falecidos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEnterro",
                table: "Falecidos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RegistroObito",
                table: "Falecidos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
