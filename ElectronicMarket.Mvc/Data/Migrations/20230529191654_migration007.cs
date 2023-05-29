﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicMarket.Mvc.Data.Migrations
{
    /// <inheritdoc />
    public partial class migration007 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Carts");
        }
    }
}
