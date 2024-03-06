using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrader.Services.Migrations
{
    /// <inheritdoc />
    public partial class NewTabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalEquipment_AutomobileAds_AutomobileAdId",
                table: "AdditionalEquipment");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_carCategories_CarCategoryId",
                table: "AutomobileAds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdditionalEquipment",
                table: "AdditionalEquipment");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalEquipment_AutomobileAdId",
                table: "AdditionalEquipment");

            migrationBuilder.DropColumn(
                name: "Mileage",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "AutomobileAdId",
                table: "AdditionalEquipment");

            migrationBuilder.RenameTable(
                name: "AdditionalEquipment",
                newName: "AdditionalEquipments");

            migrationBuilder.RenameColumn(
                name: "EquipmentName",
                table: "AdditionalEquipments",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "AdditionalEquipmentId",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaintenanceServiceId",
                table: "AutomobileAds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdditionalEquipments",
                table: "AdditionalEquipments",
                column: "AdditionalEquipmentId");

            migrationBuilder.CreateTable(
                name: "CarCategory",
                columns: table => new
                {
                    CarCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategory", x => x.CarCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutomobileAdId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_AutomobileAds_AutomobileAdId",
                        column: x => x.AutomobileAdId,
                        principalTable: "AutomobileAds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceServies",
                columns: table => new
                {
                    MaintenanceServieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Last_Small_Service = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Big_Service = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Milage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceServies", x => x.MaintenanceServieId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_AdditionalEquipmentId",
                table: "AutomobileAds",
                column: "AdditionalEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_MaintenanceServiceId",
                table: "AutomobileAds",
                column: "MaintenanceServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AutomobileAdId",
                table: "Comment",
                column: "AutomobileAdId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_AdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAds",
                column: "AdditionalEquipmentId",
                principalTable: "AdditionalEquipments",
                principalColumn: "AdditionalEquipmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_CarCategory_CarCategoryId",
                table: "AutomobileAds",
                column: "CarCategoryId",
                principalTable: "CarCategory",
                principalColumn: "CarCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_MaintenanceServies_MaintenanceServiceId",
                table: "AutomobileAds",
                column: "MaintenanceServiceId",
                principalTable: "MaintenanceServies",
                principalColumn: "MaintenanceServieId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_AdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_CarCategory_CarCategoryId",
                table: "AutomobileAds");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_MaintenanceServies_MaintenanceServiceId",
                table: "AutomobileAds");

            migrationBuilder.DropTable(
                name: "CarCategory");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "MaintenanceServies");

            migrationBuilder.DropIndex(
                name: "IX_AutomobileAds_AdditionalEquipmentId",
                table: "AutomobileAds");

            migrationBuilder.DropIndex(
                name: "IX_AutomobileAds_MaintenanceServiceId",
                table: "AutomobileAds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdditionalEquipments",
                table: "AdditionalEquipments");

            migrationBuilder.DropColumn(
                name: "AdditionalEquipmentId",
                table: "AutomobileAds");

            migrationBuilder.DropColumn(
                name: "MaintenanceServiceId",
                table: "AutomobileAds");

            migrationBuilder.RenameTable(
                name: "AdditionalEquipments",
                newName: "AdditionalEquipment");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AdditionalEquipment",
                newName: "EquipmentName");

            migrationBuilder.AddColumn<string>(
                name: "Mileage",
                table: "AutomobileAds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AutomobileAdId",
                table: "AdditionalEquipment",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdditionalEquipment",
                table: "AdditionalEquipment",
                column: "AdditionalEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalEquipment_AutomobileAdId",
                table: "AdditionalEquipment",
                column: "AutomobileAdId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalEquipment_AutomobileAds_AutomobileAdId",
                table: "AdditionalEquipment",
                column: "AutomobileAdId",
                principalTable: "AutomobileAds",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_carCategories_CarCategoryId",
                table: "AutomobileAds",
                column: "CarCategoryId",
                principalTable: "carCategories",
                principalColumn: "CarCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
