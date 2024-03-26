using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanger_Eco.Data.Migrations
{
    public partial class _14_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "PersonnelUniversiteModel",
                newName: "University");

            migrationBuilder.RenameColumn(
                name: "Ministry",
                table: "PersonnelUniversiteModel",
                newName: "Poste");

            migrationBuilder.RenameColumn(
                name: "University",
                table: "PersonnelMinistreModel",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "Poste",
                table: "PersonnelMinistreModel",
                newName: "Ministry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "University",
                table: "PersonnelUniversiteModel",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "Poste",
                table: "PersonnelUniversiteModel",
                newName: "Ministry");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "PersonnelMinistreModel",
                newName: "University");

            migrationBuilder.RenameColumn(
                name: "Ministry",
                table: "PersonnelMinistreModel",
                newName: "Poste");
        }
    }
}
