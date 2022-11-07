using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurutattva.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShibirName",
                table: "Shibirs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShibirName",
                table: "Shibirs");
        }
    }
}
