﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiWithDataBaseDemo.Migrations
{
    public partial class AddDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ShopItems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ShopItems");
        }
    }
}
