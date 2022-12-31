using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurutattva.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "Shibirs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "Shibirs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Shibirs",
                columns: new[] { "Id", "Address", "Capacity", "CityName", "CountryName", "DistrictName", "EmailAddress", "FirstName", "LastName", "Latitude", "Longitude", "PhoneNumber", "PinCode", "SanchalakEmail1", "SanchalakEmail2", "SanchalakName1", "SanchalakName2", "SanchalakPhoneNumber1", "SanchalakPhoneNumber2", "ShibirName", "StartDate", "StartTime", "StateName", "TalukaName" },
                values: new object[] { 1, "Dixon Street", 50, "Waterloo", "India", "Kitchener", "jilmehta52@gmaIL.com", "Jil", "Mehta", null, null, "6478321825", "364340", "SanchalakEmail1", "SanchalakEmail2", "Sanchalak1", "SanchalakName2", "3456542312", "3454637234", 0, "2022/08/04", "16:00:00", "Ontario", "Waterloo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shibirs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Shibirs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Shibirs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
