using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrader.Services.Migrations
{
    /// <inheritdoc />
    public partial class serviceAutomoible : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_MaintenanceServies_MaintenanceServiceId",
                table: "AutomobileAds");

            migrationBuilder.DropTable(
                name: "MaintenanceServies");

            migrationBuilder.DropIndex(
                name: "IX_AutomobileAds_MaintenanceServiceId",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "MaintenanceServiceId",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AdImages");

            migrationBuilder.AddColumn<DateTime>(
                name: "Last_Big_Service",
                table: "AutomobileAds",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Last_Small_Service",
                table: "AutomobileAds",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Milage",
                table: "AutomobileAds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Last_Big_Service",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "Last_Small_Service",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "Milage",
                table: "AutomobileAds");

            migrationBuilder.AddColumn<int>(
                name: "MaintenanceServiceId",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AdImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MaintenanceServies",
                columns: table => new
                {
                    MaintenanceServieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Last_Big_Service = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Small_Service = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Milage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceServies", x => x.MaintenanceServieId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_MaintenanceServiceId",
                table: "AutomobileAds",
                column: "MaintenanceServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_MaintenanceServies_MaintenanceServiceId",
                table: "AutomobileAds",
                column: "MaintenanceServiceId",
                principalTable: "MaintenanceServies",
                principalColumn: "MaintenanceServieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
