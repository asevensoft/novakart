using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaKart.Infraestructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixProductImageRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId1",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId1",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "ProductImages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductId1",
                table: "ProductImages",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId1",
                table: "ProductImages",
                column: "ProductId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId1",
                table: "ProductImages",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
