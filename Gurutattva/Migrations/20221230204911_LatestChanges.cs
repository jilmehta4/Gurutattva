using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurutattva.Migrations
{
    public partial class LatestChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shibirs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Shibirs");

            migrationBuilder.DropColumn(
                name: "CountryId",
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

            migrationBuilder.RenameColumn(
                name: "StreetAddress2",
                table: "Shibirs",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "StreetAddress1",
                table: "Shibirs",
                newName: "Address");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Shibirs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Shibirs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Shibirs",
                newName: "StreetAddress2");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Shibirs",
                newName: "StreetAddress1");

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Shibirs",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Shibirs",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Shibirs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
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

            migrationBuilder.InsertData(
                table: "Shibirs",
                columns: new[] { "Id", "Capacity", "CityId", "CityName", "CountryId", "DistrictId", "DistrictName", "EmailAddress", "EndDate", "EndTime", "FirstName", "LastName", "Latitude", "Longitude", "PhoneNumber", "PinCode", "SanchalakEmail1", "SanchalakEmail2", "SanchalakName1", "SanchalakName2", "SanchalakPhoneNumber1", "SanchalakPhoneNumber2", "ShibirName", "StartDate", "StartTime", "StateId", "StateName", "StreetAddress1", "StreetAddress2", "TalukaId", "TalukaName" },
                values: new object[] { 1, 50, 0, "Waterloo", 0, 0, "Kitchener", "jilmehta52@gmaIL.com", new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), "Jil", "Mehta", 43.464300000000001, 80.520399999999995, "6478321825", "364340", "SanchalakEmail1", "SanchalakEmail2", "Sanchalak1", "SanchalakName2", "3456542312", "3454637234", 0, new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ontario", "802-131 University Ave", "Waterloo, Canada", 0, "Waterloo" });
        }
    }
}
