using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurutattva.Migrations
{
    public partial class ChangesInTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Shibirs",
                newName: "StreetAddress2");

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress1",
                table: "Shibirs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Shibirs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime", "StreetAddress1", "StreetAddress2" },
                values: new object[] { new DateTime(2022, 11, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "802-131 University Ave", "Waterloo, Canada" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetAddress1",
                table: "Shibirs");

            migrationBuilder.RenameColumn(
                name: "StreetAddress2",
                table: "Shibirs",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "Shibirs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "EndTime", "StartTime" },
                values: new object[] { "802-131 University Ave, Waterloo, Canada", new DateTime(2022, 11, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
