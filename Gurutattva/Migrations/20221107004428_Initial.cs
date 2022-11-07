using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurutattva.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shibirs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TalukaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanchalakName1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanchalakEmail1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanchalakPhoneNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanchalakName2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanchalakEmail2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanchalakPhoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shibirs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Shibirs",
                columns: new[] { "Id", "Address", "Capacity", "CityName", "CountryName", "DistrictName", "EmailAddress", "EndDate", "EndTime", "FirstName", "LastName", "Latitude", "Longitude", "PhoneNumber", "PinCode", "SanchalakEmail1", "SanchalakEmail2", "SanchalakName1", "SanchalakName2", "SanchalakPhoneNumber1", "SanchalakPhoneNumber2", "StartDate", "StartTime", "StateName", "TalukaName" },
                values: new object[] { 1, "802-131 University Ave, Waterloo, Canada", 50, "Waterloo", "Canada", "Kitchener", "jilmehta52@gmaIL.com", new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), "Jil", "Mehta", 43.464300000000001, 80.520399999999995, "6478321825", "364340", "SanchalakEmail1", "SanchalakEmail2", "Sanchalak1", "SanchalakName2", "3456542312", "3454637234", new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), "Ontario", "Waterloo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shibirs");
        }
    }
}
