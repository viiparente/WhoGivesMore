using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhoGivesMore.Infrastructure.Persistence.Migrations
{
    public partial class twoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
