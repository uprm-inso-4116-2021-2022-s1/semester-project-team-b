using Microsoft.EntityFrameworkCore.Migrations;

namespace SList.Domain.Migrations
{
    public partial class added_recipe_properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Steps",
                table: "recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cook_duration",
                table: "recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "prepation_duration",
                table: "recipes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Steps",
                table: "recipes");

            migrationBuilder.DropColumn(
                name: "cook_duration",
                table: "recipes");

            migrationBuilder.DropColumn(
                name: "prepation_duration",
                table: "recipes");
        }
    }
}
