using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrader.Services.Migrations
{
    /// <inheritdoc />
    public partial class new1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdditionalEquipmentId",
                table: "AutomobileAds",
                newName: "AdditionalEquipmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobileAds_AdditionalEquipmentId1",
                table: "AutomobileAds",
                column: "AdditionalEquipmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomobileAds_AdditionalEquipments_AdditionalEquipmentId1",
                table: "AutomobileAds",
                column: "AdditionalEquipmentId1",
                principalTable: "AdditionalEquipments",
                principalColumn: "AdditionalEquipmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomobileAds_AdditionalEquipments_AdditionalEquipmentId1",
                table: "AutomobileAds");

            migrationBuilder.DropIndex(
                name: "IX_AutomobileAds_AdditionalEquipmentId1",
                table: "AutomobileAds");

            migrationBuilder.RenameColumn(
                name: "AdditionalEquipmentId1",
                table: "AutomobileAds",
                newName: "AdditionalEquipmentId");
        }
    }
}
