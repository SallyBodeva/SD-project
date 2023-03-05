using Microsoft.EntityFrameworkCore.Migrations;

namespace ArchitectureCompany.Data.Migrations
{
    public partial class SetUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Departments_Name",
                table: "Departments",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BuildingTypes_TypeName",
                table: "BuildingTypes",
                column: "TypeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Name",
                table: "Addresses",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_Name",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_BuildingTypes_TypeName",
                table: "BuildingTypes");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_Name",
                table: "Addresses");
        }
    }
}
