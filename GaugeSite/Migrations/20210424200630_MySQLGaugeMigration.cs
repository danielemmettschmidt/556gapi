using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GaugeSite.Migrations
{
    public partial class MySQLGaugeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Observations",
                columns: table => new
                {
                    ObsId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsPPR = table.Column<byte>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Rounds = table.Column<int>(nullable: false),
                    PPR = table.Column<double>(nullable: false),
                    ProductTitle = table.Column<string>(maxLength: 35, nullable: true),
                    ProductSource = table.Column<string>(maxLength: 15, nullable: true),
                    ScrapeUrl = table.Column<string>(maxLength: 50, nullable: true),
                    WhenObserved = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observations", x => x.ObsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Observations");
        }
    }
}
