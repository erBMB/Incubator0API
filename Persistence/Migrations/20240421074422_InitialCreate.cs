using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incubatoare",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    NumePasare = table.Column<string>(type: "TEXT", nullable: true),
                    ZileFormare = table.Column<int>(type: "INTEGER", nullable: false),
                    ZiIncepere = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ZiFinal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TempOptima = table.Column<string>(type: "TEXT", nullable: false),
                    TempSetata = table.Column<string>(type: "TEXT", nullable: false),
                    TempCurenta = table.Column<string>(type: "TEXT", nullable: false),
                    StareBec = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incubatoare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogIncubatoare",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataOra = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TempCurenta = table.Column<string>(type: "TEXT", nullable: false),
                    TempSetata = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogIncubatoare", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incubatoare");

            migrationBuilder.DropTable(
                name: "LogIncubatoare");
        }
    }
}
