using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanger_Eco.Data.Migrations
{
    public partial class _12_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_AspNetUsers_PersonnelMinistreId",
                table: "DemandeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_AspNetUsers_PersonnelUniversiteId",
                table: "DemandeModel");

            migrationBuilder.DropColumn(
                name: "PersonnelMinistreModelId",
                table: "DemandeModel");

            migrationBuilder.DropColumn(
                name: "PersonnelUniversiteModelId",
                table: "DemandeModel");

            migrationBuilder.DropColumn(
                name: "Ministry",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Poste",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "University",
                table: "AspNetUsers");

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

            migrationBuilder.CreateTable(
                name: "PersonnelMinistreModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelMinistreModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelUniversiteModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ministry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelUniversiteModel", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_PersonnelMinistreModel_PersonnelMinistreId",
                table: "DemandeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_PersonnelUniversiteModel_PersonnelUniversiteId",
                table: "DemandeModel");

            migrationBuilder.DropTable(
                name: "PersonnelMinistreModel");

            migrationBuilder.DropTable(
                name: "PersonnelUniversiteModel");

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

            migrationBuilder.AddColumn<int>(
                name: "PersonnelMinistreModelId",
                table: "DemandeModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelUniversiteModelId",
                table: "DemandeModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ministry",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Poste",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_AspNetUsers_PersonnelMinistreId",
                table: "DemandeModel",
                column: "PersonnelMinistreId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_AspNetUsers_PersonnelUniversiteId",
                table: "DemandeModel",
                column: "PersonnelUniversiteId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
