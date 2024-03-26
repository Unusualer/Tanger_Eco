using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanger_Eco.Data.Migrations
{
    public partial class _8_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_DemandeModel_DataCollectorModelId",
                table: "DemandeModel");

            migrationBuilder.DropIndex(
                name: "IX_DemandeModel_PersonnelMinistreModelId",
                table: "DemandeModel");

            migrationBuilder.DropIndex(
                name: "IX_DemandeModel_PersonnelUniversiteModelId",
                table: "DemandeModel");

            migrationBuilder.AddColumn<string>(
                name: "DataCollectorId",
                table: "DemandeModel",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonnelMinistreId",
                table: "DemandeModel",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonnelUniversiteId",
                table: "DemandeModel",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "Ministry",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
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

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateIndex(
                name: "IX_DemandeModel_DataCollectorId",
                table: "DemandeModel",
                column: "DataCollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_DemandeModel_PersonnelMinistreId",
                table: "DemandeModel",
                column: "PersonnelMinistreId");

            migrationBuilder.CreateIndex(
                name: "IX_DemandeModel_PersonnelUniversiteId",
                table: "DemandeModel",
                column: "PersonnelUniversiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_AspNetUsers_DataCollectorId",
                table: "DemandeModel",
                column: "DataCollectorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_AspNetUsers_DataCollectorId",
                table: "DemandeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_AspNetUsers_PersonnelMinistreId",
                table: "DemandeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_AspNetUsers_PersonnelUniversiteId",
                table: "DemandeModel");

            migrationBuilder.DropIndex(
                name: "IX_DemandeModel_DataCollectorId",
                table: "DemandeModel");

            migrationBuilder.DropIndex(
                name: "IX_DemandeModel_PersonnelMinistreId",
                table: "DemandeModel");

            migrationBuilder.DropIndex(
                name: "IX_DemandeModel_PersonnelUniversiteId",
                table: "DemandeModel");

            migrationBuilder.DropColumn(
                name: "DataCollectorId",
                table: "DemandeModel");

            migrationBuilder.DropColumn(
                name: "PersonnelMinistreId",
                table: "DemandeModel");

            migrationBuilder.DropColumn(
                name: "PersonnelUniversiteId",
                table: "DemandeModel");

            migrationBuilder.DropColumn(
                name: "Ministry",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
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
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "DataCollectorModel",
                columns: table => new
                {
                    DataCollectorModelId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_DataCollectorModel", x => x.DataCollectorModelId);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelMinistreModel",
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
                    Poste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIN = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ministry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelUniversiteModel", x => x.UserModelId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DemandeModel_DataCollectorModelId",
                table: "DemandeModel",
                column: "DataCollectorModelId");

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
    }
}
