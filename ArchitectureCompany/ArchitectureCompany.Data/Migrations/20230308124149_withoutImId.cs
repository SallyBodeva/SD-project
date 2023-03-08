using Microsoft.EntityFrameworkCore.Migrations;

namespace ArchitectureCompany.Data.Migrations
{
    public partial class withoutImId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Projects");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Projects",
                type: "int",
                nullable: true);
        }
    }
}
