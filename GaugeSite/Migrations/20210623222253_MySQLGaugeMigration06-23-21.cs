using Microsoft.EntityFrameworkCore.Migrations;

namespace GaugeSite.Migrations
{
    public partial class MySQLGaugeMigration062321 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "RoundsMode",
                table: "DateStats",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "RoundsMin",
                table: "DateStats",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "RoundsMedian",
                table: "DateStats",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "RoundsMax",
                table: "DateStats",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "RoundsAverage",
                table: "DateStats",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "PriceMode",
                table: "DateStats",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "PriceMin",
                table: "DateStats",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "PriceMedian",
                table: "DateStats",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "PriceMax",
                table: "DateStats",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "PriceAverage",
                table: "DateStats",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AddColumn<string>(
                name: "PPRMaxMerchant",
                table: "DateStats",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PPRMinMerchant",
                table: "DateStats",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PriceMaxMerchant",
                table: "DateStats",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceMinMerchant",
                table: "DateStats",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoundsMaxMerchant",
                table: "DateStats",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoundsMinMerchant",
                table: "DateStats",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PPRMaxMerchant",
                table: "DateStats");

            migrationBuilder.DropColumn(
                name: "PPRMinMerchant",
                table: "DateStats");

            migrationBuilder.DropColumn(
                name: "PriceMaxMerchant",
                table: "DateStats");

            migrationBuilder.DropColumn(
                name: "PriceMinMerchant",
                table: "DateStats");

            migrationBuilder.DropColumn(
                name: "RoundsMaxMerchant",
                table: "DateStats");

            migrationBuilder.DropColumn(
                name: "RoundsMinMerchant",
                table: "DateStats");

            migrationBuilder.AlterColumn<double>(
                name: "RoundsMode",
                table: "DateStats",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RoundsMin",
                table: "DateStats",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RoundsMedian",
                table: "DateStats",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RoundsMax",
                table: "DateStats",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RoundsAverage",
                table: "DateStats",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PriceMode",
                table: "DateStats",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PriceMin",
                table: "DateStats",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PriceMedian",
                table: "DateStats",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PriceMax",
                table: "DateStats",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PriceAverage",
                table: "DateStats",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
