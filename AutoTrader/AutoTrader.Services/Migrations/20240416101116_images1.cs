﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTrader.Services.Migrations
{
    /// <inheritdoc />
    public partial class images1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Bytes",
                table: "AdImages",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bytes",
                table: "AdImages");
        }
    }
}
