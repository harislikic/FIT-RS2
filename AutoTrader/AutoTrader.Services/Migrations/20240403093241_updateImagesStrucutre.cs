using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrader.Services.Migrations
{
    /// <inheritdoc />
    public partial class updateImagesStrucutre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "AdImages");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "AutomobileAds",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AdImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "AdImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AdImages");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "AdImages");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "AutomobileAds",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "AdImages",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
