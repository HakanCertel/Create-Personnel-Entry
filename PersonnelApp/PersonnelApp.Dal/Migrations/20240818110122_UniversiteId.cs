using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonnelApp.Dal.Migrations
{
    public partial class UniversiteId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GraduationId",
                table: "Personnel",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GraduationId",
                table: "Personnel");
        }
    }
}
