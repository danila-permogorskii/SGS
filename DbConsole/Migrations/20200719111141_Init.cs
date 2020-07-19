using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbConsole.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Valutes",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    nominal = table.Column<int>(nullable: false),
                    previous = table.Column<double>(nullable: false),
                    value = table.Column<double>(nullable: false),
                    charCode = table.Column<string>(nullable: true),
                    numCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valutes", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Valutes");
        }
    }
}
