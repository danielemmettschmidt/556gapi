using Microsoft.EntityFrameworkCore.Migrations;

namespace GaugeSite.Migrations
{
    public partial class MySQLGaugeMigration42521 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BackupID",
                table: "Observations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackupID",
                table: "Observations");
        }
    }
}
