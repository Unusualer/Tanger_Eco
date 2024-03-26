using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanger_Eco.Data.Migrations
{
    public partial class _13_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_PersonnelMinistreModel_PersonnelMinistreId",
                table: "DemandeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_PersonnelUniversiteModel_PersonnelUniversiteId",
                table: "DemandeModel");

            migrationBuilder.AlterColumn<string>(
                name: "PersonnelUniversiteId",
                table: "DemandeModel",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PersonnelMinistreId",
                table: "DemandeModel",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "DataCollectorModelId",
                table: "DemandeModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_PersonnelMinistreModel_PersonnelMinistreId",
                table: "DemandeModel",
                column: "PersonnelMinistreId",
                principalTable: "PersonnelMinistreModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_PersonnelUniversiteModel_PersonnelUniversiteId",
                table: "DemandeModel",
                column: "PersonnelUniversiteId",
                principalTable: "PersonnelUniversiteModel",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_PersonnelMinistreModel_PersonnelMinistreId",
                table: "DemandeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_PersonnelUniversiteModel_PersonnelUniversiteId",
                table: "DemandeModel");

            migrationBuilder.AlterColumn<string>(
                name: "PersonnelUniversiteId",
                table: "DemandeModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PersonnelMinistreId",
                table: "DemandeModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DataCollectorModelId",
                table: "DemandeModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_PersonnelMinistreModel_PersonnelMinistreId",
                table: "DemandeModel",
                column: "PersonnelMinistreId",
                principalTable: "PersonnelMinistreModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_PersonnelUniversiteModel_PersonnelUniversiteId",
                table: "DemandeModel",
                column: "PersonnelUniversiteId",
                principalTable: "PersonnelUniversiteModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
