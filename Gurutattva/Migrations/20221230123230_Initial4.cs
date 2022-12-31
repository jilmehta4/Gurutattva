using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurutattva.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Shibirs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Shibirs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "Shibirs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TalukaId",
                table: "Shibirs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Shibirs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Shibirs");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Shibirs");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Shibirs");

            migrationBuilder.DropColumn(
                name: "TalukaId",
                table: "Shibirs");

            migrationBuilder.UpdateData(
                table: "Shibirs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
