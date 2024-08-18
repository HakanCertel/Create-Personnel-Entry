using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonnelApp.Dal.Migrations
{
    public partial class Gender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GraduationId",
                table: "Personnel");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Personnel",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Personnel");

            migrationBuilder.AddColumn<int>(
                name: "GraduationId",
                table: "Personnel",
                type: "int",
                nullable: true);
        }
    }
}
