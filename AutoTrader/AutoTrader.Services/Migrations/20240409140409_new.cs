using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrader.Services.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_AdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAds");

            migrationBuilder.DropIndex(
                name: "IX_AutomobileAds_AdditionalEquipmentId",
                table: "AutomobileAds");

            migrationBuilder.AddColumn<int>(
                name: "AutomobileAdId",
                table: "AdditionalEquipments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalEquipments_AutomobileAdId",
                table: "AdditionalEquipments",
                column: "AutomobileAdId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalEquipments_AutomobileAds_AutomobileAdId",
                table: "AdditionalEquipments",
                column: "AutomobileAdId",
                principalTable: "AutomobileAds",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalEquipments_AutomobileAds_AutomobileAdId",
                table: "AdditionalEquipments");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalEquipments_AutomobileAdId",
                table: "AdditionalEquipments");

            migrationBuilder.DropColumn(
                name: "AutomobileAdId",
                table: "AdditionalEquipments");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_AdditionalEquipmentId",
                table: "AutomobileAds",
                column: "AdditionalEquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_AdditionalEquipments_AdditionalEquipmentId",
                table: "AutomobileAds",
                column: "AdditionalEquipmentId",
                principalTable: "AdditionalEquipments",
                principalColumn: "AdditionalEquipmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
