using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cemidex.Migrations
{
    public partial class Versao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Covas",
                columns: table => new
                {
                    IdCova = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdRequerente = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Covas", x => x.IdCova);
                });

            migrationBuilder.CreateTable(
                name: "Falecidos",
                columns: table => new
                {
                    IdFalecido = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdCova = table.Column<int>(type: "INTEGER", nullable: false),
                    IdRequerente = table.Column<int>(type: "INTEGER", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NomeMae = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NomePai = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Idade = table.Column<string>(type: "TEXT", nullable: false),
                    Sexo = table.Column<string>(type: "TEXT", maxLength: 1, nullable: false),
                    EstadoCivil = table.Column<string>(type: "TEXT", nullable: false),
                    DataObito = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataEnterro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RegistroObito = table.Column<string>(type: "TEXT", nullable: false),
                    CertidaoObito = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Falecidos", x => x.IdFalecido);
                });

            migrationBuilder.CreateTable(
                name: "Requerentes",
                columns: table => new
                {
                    IdRequerente = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cpf = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requerentes", x => x.IdRequerente);
                });

            migrationBuilder.CreateTable(
                name: "Sepultamentos",
                columns: table => new
                {
                    IdSepultamento = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdFalecido = table.Column<string>(type: "TEXT", nullable: false),
                    IdCova = table.Column<string>(type: "TEXT", nullable: false),
                    DataSepultamento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataExumacao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepultamentos", x => x.IdSepultamento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Covas");

            migrationBuilder.DropTable(
                name: "Falecidos");

            migrationBuilder.DropTable(
                name: "Requerentes");

            migrationBuilder.DropTable(
                name: "Sepultamentos");
        }
    }
}
