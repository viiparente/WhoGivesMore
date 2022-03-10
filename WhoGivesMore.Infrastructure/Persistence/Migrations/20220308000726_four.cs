using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhoGivesMore.Infrastructure.Persistence.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_IdBidder",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_IdOwner",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_IdBidder",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_IdOwner",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "IdBidder",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "IdOwner",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserId",
                table: "Items",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserId1",
                table: "Items",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_UserId",
                table: "Items",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_UserId1",
                table: "Items",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_UserId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_UserId1",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_UserId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_UserId1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "IdBidder",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdOwner",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_IdBidder",
                table: "Items",
                column: "IdBidder");

            migrationBuilder.CreateIndex(
                name: "IX_Items_IdOwner",
                table: "Items",
                column: "IdOwner");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_IdBidder",
                table: "Items",
                column: "IdBidder",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_IdOwner",
                table: "Items",
                column: "IdOwner",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
