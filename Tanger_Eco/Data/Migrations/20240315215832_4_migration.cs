using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanger_Eco.Data.Migrations
{
    public partial class _4_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_UserModel_UserModelId",
                table: "DemandeModel");

            migrationBuilder.DropTable(
                name: "UserModel");

            migrationBuilder.RenameColumn(
                name: "UserModelId",
                table: "DemandeModel",
                newName: "DataCollectorModelId");

            migrationBuilder.RenameIndex(
                name: "IX_DemandeModel_UserModelId",
                table: "DemandeModel",
                newName: "IX_DemandeModel_DataCollectorModelId");

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

            migrationBuilder.CreateTable(
                name: "DataCollectorModel",
                columns: table => new
                {
                    DataCollectorModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIN = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCollectorModel", x => x.DataCollectorModelId);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelMinistreModel",
                columns: table => new
                {
                    UserModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIN = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelMinistreModel", x => x.UserModelId);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelUniversiteModel",
                columns: table => new
                {
                    UserModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ministry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIN = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelUniversiteModel", x => x.UserModelId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DemandeModel_PersonnelMinistreModelId",
                table: "DemandeModel",
                column: "PersonnelMinistreModelId");

            migrationBuilder.CreateIndex(
                name: "IX_DemandeModel_PersonnelUniversiteModelId",
                table: "DemandeModel",
                column: "PersonnelUniversiteModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_DataCollectorModel_DataCollectorModelId",
                table: "DemandeModel",
                column: "DataCollectorModelId",
                principalTable: "DataCollectorModel",
                principalColumn: "DataCollectorModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_PersonnelMinistreModel_PersonnelMinistreModelId",
                table: "DemandeModel",
                column: "PersonnelMinistreModelId",
                principalTable: "PersonnelMinistreModel",
                principalColumn: "UserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_PersonnelUniversiteModel_PersonnelUniversiteModelId",
                table: "DemandeModel",
                column: "PersonnelUniversiteModelId",
                principalTable: "PersonnelUniversiteModel",
                principalColumn: "UserModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_DataCollectorModel_DataCollectorModelId",
                table: "DemandeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_PersonnelMinistreModel_PersonnelMinistreModelId",
                table: "DemandeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_PersonnelUniversiteModel_PersonnelUniversiteModelId",
                table: "DemandeModel");

            migrationBuilder.DropTable(
                name: "DataCollectorModel");

            migrationBuilder.DropTable(
                name: "PersonnelMinistreModel");

            migrationBuilder.DropTable(
                name: "PersonnelUniversiteModel");

            migrationBuilder.DropIndex(
                name: "IX_DemandeModel_PersonnelMinistreModelId",
                table: "DemandeModel");

            migrationBuilder.DropIndex(
                name: "IX_DemandeModel_PersonnelUniversiteModelId",
                table: "DemandeModel");

            migrationBuilder.DropColumn(
                name: "PersonnelMinistreModelId",
                table: "DemandeModel");

            migrationBuilder.DropColumn(
                name: "PersonnelUniversiteModelId",
                table: "DemandeModel");

            migrationBuilder.RenameColumn(
                name: "DataCollectorModelId",
                table: "DemandeModel",
                newName: "UserModelId");

            migrationBuilder.RenameIndex(
                name: "IX_DemandeModel_DataCollectorModelId",
                table: "DemandeModel",
                newName: "IX_DemandeModel_UserModelId");

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    UserModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIN = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.UserModelId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_UserModel_UserModelId",
                table: "DemandeModel",
                column: "UserModelId",
                principalTable: "UserModel",
                principalColumn: "UserModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
