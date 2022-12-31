using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurutattva.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Shibirs");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Shibirs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Shibirs");

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Shibirs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Shibirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CountryName",
                value: "Canada");
        }
    }
}
