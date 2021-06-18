using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GaugeSite.Migrations
{
    public partial class MySQLGaugeMigration061821 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DateStats",
                columns: table => new
                {
                    DateStatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    PPRMax = table.Column<double>(nullable: false),
                    PPRMin = table.Column<double>(nullable: false),
                    PPRAverage = table.Column<double>(nullable: false),
                    PPRMedian = table.Column<double>(nullable: false),
                    PPRMode = table.Column<double>(nullable: false),
                    PriceMax = table.Column<double>(nullable: false),
                    PriceMin = table.Column<double>(nullable: false),
                    PriceAverage = table.Column<double>(nullable: false),
                    PriceMedian = table.Column<double>(nullable: false),
                    PriceMode = table.Column<double>(nullable: false),
                    RoundsMax = table.Column<double>(nullable: false),
                    RoundsMin = table.Column<double>(nullable: false),
                    RoundsAverage = table.Column<double>(nullable: false),
                    RoundsMedian = table.Column<double>(nullable: false),
                    RoundsMode = table.Column<double>(nullable: false),
                    IsCarriedOverFromPriorDay = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateStats", x => x.DateStatId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateStats");
        }
    }
}
