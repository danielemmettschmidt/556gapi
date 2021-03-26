using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GaugeSite.Migrations
{
    public partial class InitialGaugeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Observations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPPR = table.Column<byte>(type: "tinyint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Rounds = table.Column<int>(type: "int", nullable: false),
                    PPR = table.Column<double>(type: "float", nullable: false),
                    ProductTitle = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    ProductSource = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ScrapeUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WriteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Observations");
        }
    }
}
