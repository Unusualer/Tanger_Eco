using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanger_Eco.Data.Migrations
{
    public partial class _15_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_AspNetUsers_DataCollectorId",
                table: "DemandeModel");

            migrationBuilder.DropIndex(
                name: "IX_DemandeModel_DataCollectorId",
                table: "DemandeModel");

            migrationBuilder.DropColumn(
                name: "DataCollectorId",
                table: "DemandeModel");

            migrationBuilder.AlterColumn<string>(
                name: "DataCollectorModelId",
                table: "DemandeModel",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DemandeModel_DataCollectorModelId",
                table: "DemandeModel",
                column: "DataCollectorModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_AspNetUsers_DataCollectorModelId",
                table: "DemandeModel",
                column: "DataCollectorModelId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeModel_AspNetUsers_DataCollectorModelId",
                table: "DemandeModel");

            migrationBuilder.DropIndex(
                name: "IX_DemandeModel_DataCollectorModelId",
                table: "DemandeModel");

            migrationBuilder.AlterColumn<string>(
                name: "DataCollectorModelId",
                table: "DemandeModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataCollectorId",
                table: "DemandeModel",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DemandeModel_DataCollectorId",
                table: "DemandeModel",
                column: "DataCollectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeModel_AspNetUsers_DataCollectorId",
                table: "DemandeModel",
                column: "DataCollectorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
